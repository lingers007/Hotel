<?php
/*-------------------------------------------------------------------------
# com_creative_slider - Creative Slider
# -------------------------------------------------------------------------
# @ author    John Gera, George Krupa, Janos Biro, Balint Polgarfi
# @ copyright Copyright (C) 2018 Offlajn.com  All Rights Reserved.
# @ license   http://www.gnu.org/licenses/gpl-2.0.html GNU/GPL
# @ website   http://www.offlajn.com
-------------------------------------------------------------------------*/
namespace CreativeSlider;
use stdClass, ZipArchive;
defined('_JEXEC') or die;
?><?php




class KM_UpdatesV3 {


	
	const API_VERSION = 3;


	
	const TIMEOUT = 60;


	
	protected $config;


	
	protected $data;




	
	public function __construct($config = array()) {

		// Get and check params
		extract($config, EXTR_SKIP);
		if(!isset($repoUrl, $root, $version, $itemID, $codeKey, $authKey, $channelKey)) {
			wp_die('Missing params in $config for KM_Updates constructor');
		}

		// Bug fix in v5.3.0: WPLANG is not always defined
		if( ! defined('WPLANG')) { define('WPLANG', ''); }

		// Build config
		$this->config = array_merge($config, array(
			'slug' => basename(dirname($config['root'])),
			'base' => plugin_basename($config['root']),
			'channel' => get_option($config['channelKey'], 'stable'),
			'license' => get_option($config['codeKey'], ''),
			'domain' => $_SERVER['SERVER_NAME'],
			'option' => strtolower(basename(dirname($config['root']))) . '_update_info',
			'locale' => WPLANG
		));
	}




	
	public function set_update_transient($transient) {

		$this->_check_updates();

		if( empty($transient) || ! is_object($transient) ) {
			$transient = new stdClass;
		}

		if(!isset($transient->response)) {
			$transient->response = array();
		}


		if(!empty($this->data->basic) && is_object($this->data->basic)) {
			if(version_compare($this->config['version'], $this->data->basic->version, '<')) {

				$this->data->basic->new_version = $this->data->basic->version;
				$transient->response[$this->config['base']] = $this->data->basic;
			}
		} else {
			unset($transient->response[$this->config['base']]);
		}

		return $transient;
	}




	
	public function set_updates_api_results($result, $action, $args) {

		$this->_check_updates();

		if(isset($args->slug) && $args->slug == $this->config['slug'] && $action == 'plugin_information') {
			if(is_object($this->data->full) && !empty($this->data->full)) {
				$result = $this->data->full;
			}
		}

		return $result;
	}



	
	public function pre_download_filter($reply, $package, $updater) {

		$skin = $updater->skin;

		// Filter out 3rd party items
		if( ( isset( $skin->plugin ) && $skin->plugin === $this->config['base'] ) ||
			( isset( $skin->plugin_info ) && $skin->plugin_info['Name'] === $this->config['name'] ) ) {

				// Check validity
				if( $GLOBALS['lsAutoUpdateBox'] && ! get_option( $this->config['authKey'], false ) ) {
					return new WP_Error('ls_update_error', sprintf(
						__('License activation is required to receive updates. Please read our %sonline documentation%s to learn more.', 'LayerSlider'),
						'<a href="http://docs.offlajn.com/creative-slider#activation" target="_blank">',
						'</a>')
					);
				}
		}

		return $reply;
	}



	
	public function update_message() {

		// Provide license activation warning on non-activated sites
		if( ! get_option( $this->config['authKey'], false ) ) {
			printf(__('License activation is required in order to receive updates for LayerSlider. %sPurchase a license%s or %sread the documentation%s to learn more. %sGot LayerSlider in a theme?%s', 'installer'),
							'<a href="http://codecanyon.net/cart/add_items?ref=kreatura&amp;item_ids=1362246" target="_blank">', '</a>', '<a href="http://docs.offlajn.com/creative-slider#activation" target="_blank">', '</a>', '<a href="http://docs.offlajn.com/creative-slider#activation-bundles" target="_blank">', '</a>');
		}
	}



	
	public function check_activation_state() {

		if( get_option( $this->config['authKey'], false ) ) {

			update_option( $this->config['authKey'], 0 );
			update_option( $this->config['codeKey'], '' );
			update_option( 'ls-show-canceled_activation_notice', 1);
			update_option('layerslider_cancellation_update_info', $this->data);
		}
	}




	
	protected function _check_updates( $forceCheck = false ) {

		// Get data
		if(empty($this->data)) {
			$data = get_option($this->config['option'], false);
			$data = $data ? $data : new stdClass;
			$this->data = is_object($data) ? $data : maybe_unserialize($data);
		}

		// Just installed
		if(!isset($this->data->checked)) {
			$this->data->checked = time();
		}

		// Check for updates
		if( $forceCheck || $this->data->checked < time() - self::TIMEOUT) {
			$response = $this->sendApiRequest($this->config['repoUrl'].'updates/');

			if(!empty($response) && $newData = maybe_unserialize($response)) {
				if(is_object($newData)) {
					$this->data = $newData;
					$this->data->checked = time();
				}
			}


			// Store version number of the latest release
			// to notify unauthorized site owners
			if( ! empty( $this->data->_latest_version ) ) {
				update_option('ls-latest-version', $this->data->_latest_version);
			}


			// Check activation state on client side in
			// case of receiving a "Not Activated" flag
			if( ! empty( $this->data->_not_activated ) ) {
				$this->check_activation_state();
			}
		}

		// Save results
		update_option($this->config['option'], $this->data);
	}



	
	public function sendApiRequest($url) {

		if(empty($url)) { return false; }

		// Build request
		$request = wp_remote_post($url, array(
			'method' => 'POST',
			'timeout' => 60,
			'user-agent' => 'WordPress/'.$GLOBALS['wp_version'].'; '.get_bloginfo('url'),
			'body' => array(
				'slug' => $this->config['slug'],
				'base' => $this->config['base'],
				'version' => $this->config['version'],
				'channel' => $this->config['channel'],
				'license' => $this->config['license'],
				'item_id' => $this->config['itemID'],
				'domain' => $this->config['domain'],
				'locale' => $this->config['locale'],
				'api_version' => self::API_VERSION
			)
		));

		return wp_remote_retrieve_body($request);
	}




	
	public function parseApiResponse($response) {

		// Get response
		$json = !empty($response) ? json_decode($response) : false;

		// ERR: Unexpected error
		if(empty($json)) {
			die(json_encode(array(
				'message' => 'An unexpected error occurred. Please try again later. If this error persist, it\'s most likely a web server configuration issue. Please contact your web host and ask them to allow external connection to the following domain: repository.kreaturamedia.com. If you need further assistance in resolving this issue, please email us from our CodeCanyon profile page.',
				'errCode' => 'ERR_UNEXPECTED_ERROR')
			));
		}

		return array($response, $json);
	}



	
	public function handleActivation() {

		// Required informations
		if(empty(${'_POST'}['purchase_code']) || empty(${'_POST'}['channel'])) {
			die(json_encode(array(
				'status' => 'Please enter your purchase code.',
				'errCode' => 'ERR_INVALID_DATA_RECEIVED')
			));
		}

		// Re-validation
		if(get_option('layerslider-validated', null) === '1' && !empty($this->config['license']) && get_option('layerslider-authorized-site', null) === null) {
			${'_POST'}['purchase_code'] = $this->config['license'];
		}

		// Save release channel
		update_option($this->config['channelKey'], ${'_POST'}['channel']);

		// Only update release channel?
		if(get_option($this->config['authKey'], false)) {
			if( strpos(${'_POST'}['purchase_code'], '???') === 0 || $this->config['license'] == ${'_POST'}['purchase_code']) {
				die(json_encode(array('message' => __('Your settings were successfully saved.', 'LayerSlider'))));
			}
		}

		// Validate purchase
		$this->config['license'] = ${'_POST'}['purchase_code'];
		$data = $this->sendApiRequest($this->config['repoUrl'].'authorize/');
		list($response, $json) = $this->parseApiResponse($data);

		// Failed authorization
		if(!empty($json->errCode)) {
			update_option($this->config['authKey'], 0);
			update_option($this->config['codeKey'], '');

		// Successful authorization
		} else {
			$json->code = call_user_func('base'.'64_encode', ${'_POST'}['purchase_code']);
			update_option($this->config['authKey'], 1);
			update_option($this->config['codeKey'], ${'_POST'}['purchase_code']);


			// v6.1.5: Make sure to empty the stored update data from cache,
			// so we can avoid issues caused by outdated and potentially
			// unreliable information like special flags set by the update server.
			//
			// Force checking updates to immediately replace the missing update info
			// with fresh data. Suppressing error reporting to make sure that nothing
			// can break the JSON output, as user feedback is crucial here.
			delete_option($this->config['option']);
			@$this->_check_updates( true );

			// v6.2.0: Automatically hide the "Canceled activation" notice when
			// re-activating the plugin to make things easier and more convenient.
			update_option('ls-show-canceled_activation_notice', 0);
		}


		die(json_encode($json));
	}



	
	public function handleDeactivation() {

		// Get response
		$data = $this->sendApiRequest($this->config['repoUrl'].'deauthorize/');
		list($response, $json) = $this->parseApiResponse($data);

		// Deauthorize
		delete_option($this->config['codeKey']);
		delete_option($this->config['authKey']);

		die($response);
	}
}
