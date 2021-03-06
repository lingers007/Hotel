<?php
/**
 * @copyright	Copyright (c) 2014 Skyline Technology Ltd (http://extstore.com). All rights reserved.
 * @license		GNU General Public License version 2 or later; see LICENSE.txt
 */

// no direct access
defined('_JEXEC') or die;


class PlgSystemLoginPopupHelper {
	/**
	 * Retrieve the url where the user should be returned after logging in
	 *
	 * @param   JRegistry  $params  module parameters
	 * @param   string     $type    return type
	 *
	 * @return string
	 */
	public static function getReturnURL($params, $type) {
		$app	= JFactory::getApplication();
		$router = $app::getRouter();
		$url = null;

		if ($itemid = $params->get($type)) {
			$db		= JFactory::getDbo();
			$query	= $db->getQuery(true)
					   ->select($db->quoteName('link'))
					   ->from($db->quoteName('#__menu'))
					   ->where($db->quoteName('published') . '=1')
					   ->where($db->quoteName('id') . '=' . $db->quote($itemid))
			;

			$db->setQuery($query);

			if ($link = $db->loadResult()) {
				if ($router->getMode() == JROUTER_MODE_SEF) {
					$url = 'index.php?Itemid=' . $itemid;
				} else {
					$url = $link . '&Itemid=' . $itemid;
				}
			}
		}

		if (!$url) {
			// Stay on the same page
			$uri = clone JUri::getInstance();
			$vars = $router->parse($uri);
			unset($vars['lang']);

			if ($router->getMode() == JROUTER_MODE_SEF) {
				if (isset($vars['Itemid'])) {
					$itemid = $vars['Itemid'];
					$menu = $app->getMenu();
					$item = $menu->getItem($itemid);
					unset($vars['Itemid']);

					if (isset($item) && $vars == $item->query) {
						$url = 'index.php?Itemid=' . $itemid;
					} else {
						$url = 'index.php?' . JUri::buildQuery($vars) . '&Itemid=' . $itemid;
					}
				} else {
					$url = 'index.php?' . JUri::buildQuery($vars);
				}
			} else {
				$url = 'index.php?' . JUri::buildQuery($vars);
			}
		}

		return base64_encode($url);
	}

	/**
	 * Get list of available two factor methods
	 *
	 * @return array
	 */
	public static function getTwoFactorMethods() {
		require_once JPATH_ADMINISTRATOR . '/components/com_users/helpers/users.php';

		return UsersHelper::getTwoFactorMethods();
	}
}