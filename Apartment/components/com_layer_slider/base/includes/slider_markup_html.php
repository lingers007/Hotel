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

if(!defined('LS_ROOT_FILE')) {
	header('HTTP/1.0 403 Forbidden');
	exit;
}

// Popup
if( !empty($slides['properties']['attrs']['type']) && $slides['properties']['attrs']['type'] === 'popup' ) {
	$slides['properties']['props']['width']  = ! empty( $slides['properties']['attrs']['popupWidth'] ) ? $slides['properties']['attrs']['popupWidth'] : 640;
	$slides['properties']['props']['height'] = ! empty( $slides['properties']['attrs']['popupHeight']) ? $slides['properties']['attrs']['popupHeight'] : 360;
}

// Get slider style
$sliderStyleAttr[] = 'width:'.layerslider_check_unit($slides['properties']['props']['width']).';';

if( ( !empty($slides['properties']['attrs']['type']) && $slides['properties']['attrs']['type'] === 'fullsize' ) && ( empty($slides['properties']['attrs']['fullSizeMode']) || $slides['properties']['attrs']['fullSizeMode'] !== 'fitheight' ) ) {
	$sliderStyleAttr[] = 'height:100vh;';
} else {
	$sliderStyleAttr[] = 'height:'.layerslider_check_unit($slides['properties']['props']['height']).';';
}

if(!empty($slides['properties']['props']['maxwidth'])) {
	$sliderStyleAttr[] = 'max-width:'.layerslider_check_unit($slides['properties']['props']['maxwidth']).';';
}

$sliderStyleAttr[] = 'margin:0 auto;';
if(isset($slides['properties']['props']['sliderStyle'])) {
	$sliderStyleAttr[] = $slides['properties']['props']['sliderStyle'];
}

// Before slider content hook
if(has_action('layerslider_before_slider_content')) {
	do_action('layerslider_before_slider_content');
}

// Wrap Popups
if( !empty($slides['properties']['attrs']['type']) && $slides['properties']['attrs']['type'] === 'popup' ) {
	$lsContainer[] = '<div class="ls-popup">';
}

$customClasses = '';
if( ! empty( $slides['properties']['props']['sliderclass'] ) ) {
	$customClasses = ' '.$slides['properties']['props']['sliderclass'];
}

// Start of slider container
$lsContainer[] = '<div id="'.$sliderID.'" class="ls-wp-container fitvidsignore'.$customClasses.'" style="'.implode('', $sliderStyleAttr).'">';

// Add slides
if(!empty($slider['slides']) && is_array($slider['slides'])) {
	foreach($slider['slides'] as $slidekey => $slide) {

		// Skip this slide?
		if (!empty($slide['props']['skip']) ||
			!empty($slide['props']['schedule_start']) && strtotime($slide['props']['schedule_start']) > time() ||
			!empty($slide['props']['schedule_end']) && strtotime($slide['props']['schedule_end']) < time()) {
			continue;
		}

		// Get slide attributes
		$slideId = !empty($slide['props']['id']) ? ' id="'.$slide['props']['id'].'"' : '';
		$slideAttrs = !empty($slide['attrs']) ? ls_array_to_attr($slide['attrs']) : '';
		$postContent = false;


		// Check for the origami plugin
		if( ! empty( $slide['attrs']['transitionorigami'] ) ) {
			$lsPlugins[] = 'origami';
		}

		// Post content
		//if( !isset($slide['props']['post_content']) || $slide['props']['post_content']) {
			$queryArgs = array(
				'post_status' => 'publish',
				'limit' => 1,
				'posts_per_page' => 1,
				'suppress_filters' => false
			);


			if(isset($slide['props']['post_offset'])) {
				if($slide['props']['post_offset'] == -1) {
					$slide['props']['post_offset'] = $slidekey;
				}

				$queryArgs['offset'] = $slide['props']['post_offset'];
			}

			if(!empty($slides['properties']['props']['post_type'])) {
				$queryArgs['post_type'] = $slides['properties']['props']['post_type']; }

			if(!empty($slides['properties']['props']['post_orderby'])) {
				$queryArgs['orderby'] = $slides['properties']['props']['post_orderby']; }

			if(!empty($slides['properties']['props']['post_order'])) {
				$queryArgs['order'] = $slides['properties']['props']['post_order']; }

			if(!empty($slides['properties']['props']['post_categories'][0])) {
				$queryArgs['category__in'] = $slides['properties']['props']['post_categories']; }

			if(!empty($slides['properties']['props']['post_tags'][0])) {
				$queryArgs['tag__in'] = $slides['properties']['props']['post_tags']; }

			if(!empty($slides['properties']['props']['post_taxonomy']) && !empty($slides['properties']['props']['post_tax_terms'])) {
				$queryArgs['tax_query'][] = array(
					'taxonomy' => $slides['properties']['props']['post_taxonomy'],
					'field' => 'id',
					'terms' => $slides['properties']['props']['post_tax_terms']
				);
			}

			$postContent = LS_Posts::find($queryArgs);
		//}

		// Start of slide
		$slideAttrs = !empty($slideAttrs) ? 'data-ls="'.$slideAttrs.'"' : '';
		$lsMarkup[] = '<div class="ls-slide"'.$slideId.' '.$slideAttrs.'>';

		// Add slide background
		if( ! empty($slide['props']['background'])) {
			$lsBG = '';
			$alt = empty($slide['props']['alt']) ? 'Slide background' : $slide['props']['alt'];
			$title = empty($slide['props']['title']) ? '' : 'title="'.$slide['props']['title'].'"';

			if( ! empty($slide['props']['backgroundId'])) {
				$lsBG = wp_get_attachment_image($slide['props']['backgroundId'], 'full', false, array('class' => 'ls-bg'));

			} elseif($slide['props']['background'] == '[image-url]') {
				$src = $postContent->getWithFormat($slide['props']['background']);

				if(is_object($postContent->post)) {
					$attchID = get_post_thumbnail_id($postContent->post->ID);
					$lsBG = wp_get_attachment_image($attchID, 'full', false, array('class' => 'ls-bg'));
				}
			} else {
				$src = do_shortcode($slide['props']['background']);
			}

			if( ! empty( $lsBG ) ) {
				$lsMarkup[] = $lsBG;
			} elseif( ! empty( $src ) ) {
				$lsMarkup[] = '<img src="'.$src.'" class="ls-bg" alt="'.$alt.'" '.$title.'/>';
			}
		}

		// Add slide thumbnail
		if(!isset($slides['properties']['attrs']['thumbnailNavigation']) || $slides['properties']['attrs']['thumbnailNavigation'] != 'disabled') {
			if(!empty($slide['props']['thumbnail'])) {

				$lsTN = '';
				if( ! empty($slide['props']['thumbnailId']) ) {
					$lsTN = wp_get_attachment_image($slide['props']['thumbnailId'], 'full', false, array('class' => 'ls-tn'));
				}

				$lsMarkup[] = ! empty( $lsTN ) ? $lsTN : '<img src="'.$slide['props']['thumbnail'].'" class="ls-tn" alt="Slide thumbnail" />';
			}
		}

		// Add layers
		if(!empty($slide['layers']) && is_array($slide['layers'])) {
			foreach($slide['layers'] as $layerkey => $layer) {

				// Skip this slide?
				if(!empty($layer['props']['skip'])) { continue; }

				unset($layerAttributes);
				unset($innerAttributes);
				$layerAttributes = array('style' => '', 'class' => 'ls-l');
				$innerAttributes = array('style' => '', 'class' => '');

				if( empty( $layer['props']['url'] ) ) {
					$innerAttributes =& $layerAttributes;
				}

				// WPML support
				if( has_filter( 'wpml_translate_single_string' ) ) {

					// Check 'createdWith' property to decide which WPML implementation
					// should we use. This property was added in v6.5.5 along with the
					// new WPML implementation, so no version comparison required.
					if( ! empty( $slides['properties']['attrs']['createdWith'] ) ) {
						$string_name = "slider-{$id}-layer-{$layer['props']['uuid']}-html";
						$layer['props']['html'] = apply_filters( 'wpml_translate_single_string', $layer['props']['html'], 'LayerSlider Sliders', $string_name );

					// Old implementation
					} else {
						$string_name = '<'.$layer['props']['type'].':'.substr(sha1($layer['props']['html']), 0, 10).'> layer on slide #'.($slidekey+1).' in slider #'.$id.'';
						$layer['props']['html'] = apply_filters( 'wpml_translate_single_string', $layer['props']['html'], 'LayerSlider WP', $string_name);
					}

					// v6.5.6: Don't add the 'lang' param to URL if it's a permalink for a post.
					// WPML will filter permalink correctly later.
					if( ! empty( $layer['props']['url'] ) && ! empty( ${'_GET'}['lang'] ) && $layer['props']['url'] !== '[post-url]' ) {

						if( strpos( $layer['props']['url'], 'http' ) !== 0 || strpos( $layer['props']['url'], $_SERVER['SERVER_NAME'] ) !== false ) {

							if(strpos($layer['props']['url'], '?') !== false) {
								$layer['props']['url'] .= '&amp;lang=' . ICL_LANGUAGE_CODE;
							} else {
								$layer['props']['url'] .= '?lang=' . ICL_LANGUAGE_CODE;
							}
						}
					}
				}

				// Get layer type
				$layer['props']['media'] = !empty($layer['props']['media']) ? $layer['props']['media'] : '';
				if(!empty($layer['props']['media'])) {
					switch($layer['props']['media']) {
						case 'img':
							$layer['props']['type'] = 'img';
							break;
						case 'html':
						case 'media':
							$layer['props']['type'] = 'div';
							break;
						case 'post':
							$layer['props']['type'] = 'div';
							break;
					}
				}

				// Post layer
				if(!empty($layer['props']['media']) && $layer['props']['media'] == 'post') {
					$layer['props']['post_text_length'] = !empty($layer['props']['post_text_length']) ? $layer['props']['post_text_length'] : 0;
					$layer['props']['html'] = $postContent->getWithFormat($layer['props']['html'], $layer['props']['post_text_length']);
					$layer['props']['html'] = do_shortcode($layer['props']['html']);
				}

				// Skip image layer without src
				if($layer['props']['type'] == 'img' && empty($layer['props']['image'])) { continue; }

				// Create layer
				$first = substr($layer['props']['html'], 0, 1);
				$last = substr($layer['props']['html'], strlen($layer['props']['html'])-1, 1);

				// Image layer
				$layerIMG = false;
				if($layer['props']['type'] == 'img') {
					if( ! empty($layer['props']['imageId'])) {
						$layerIMG = wp_get_attachment_image( (int)$layer['props']['imageId'], 'full', false, array('class' => 'ls-l'));

					} elseif($layer['props']['image'] == '[image-url]') {

						if(is_object($postContent->post)) {
							$attchID = get_post_thumbnail_id($postContent->post->ID);
							$layerIMG = wp_get_attachment_image($attchID, 'full', false, array('class' => 'ls-l'));
						} else {
							$innerAttributes['src'] = $postContent->getWithFormat($layer['props']['image']);
						}

					} else {
						$innerAttributes['src'] = $layer['props']['image'];

						if(!empty($layer['props']['alt'])) {
						$innerAttributes['alt'] = $layer['props']['alt']; }
							else { 	$innerAttributes['alt'] = ''; }
					}
				}

				if($layer['props']['media'] == 'post' && ($first == '<' && $last == '>')) {
					$type = $layer['props']['html'];
				} else {
					$type = ! empty($layerIMG) ? $layerIMG : '<'.$layer['props']['type'].'>';
				}

				if( ! empty($layer['props']['url']) ) {
					$el = LayerSlider\PHPQuery\phpQuery::newDocumentHTML('<a>')->children();
					if($layer['props']['url'] == '[post-url]') {
						$layer['props']['url'] = $postContent->getWithFormat($layer['props']['url']);
					}
					$layerAttributes['href'] = $layer['props']['url'];
					if(!empty($layer['props']['target'])) {
						$layerAttributes['target'] =  $layer['props']['target'];
					}

					$inner = $el->append($type)->children();

				} else {
					$el = $inner = LayerSlider\PHPQuery\phpQuery::newDocumentHTML($type)->children();
				}

				// HTML attributes
				$layerAttributes['class'] = 'ls-l';

				if(!empty($layer['props']['id'])) { $innerAttributes['id'] = $layer['props']['id']; }
				if(!empty($layer['props']['class'])) { $innerAttributes['class'] .= ' '.$layer['props']['class']; }
				if(!empty($layer['props']['url'])) {
					if(!empty($layer['props']['rel'])) {
						$layerAttributes['rel'] = $layer['props']['rel']; }
					if(!empty($layer['props']['title'])) {
						$layerAttributes['title'] = $layer['props']['title']; }
				} else {
					if(!empty($layer['props']['title'])) {
						$innerAttributes['title'] = $layer['props']['title']; }
				}

				if(isset($layer['attrs']) && isset($layer['props']['transition'])) { $layerAttributes['data-ls'] = ls_array_to_attr($layer['attrs']); }
					elseif(isset($layer['attrs'])) { $layerAttributes['style'] .= ls_array_to_attr($layer['attrs']); }

				if(!empty($layer['props']['style'])) {
					if(substr($layer['props']['style'], -1) != ';') { $layer['props']['style'] .= ';'; }
					$innerAttributes['style'] .= preg_replace('/\s\s+/', ' ', $layer['props']['style']);
				}

				if( ! empty($layer['props']['wordwrap']) || ! empty($layer['props']['styles']['wordwrap']) ) {
					$innerAttributes['style'] .= 'white-space: normal;';
				}

				if(!empty($layer['props']['styles'])) {
					$innerAttributes['style'] .= ls_array_to_attr($layer['props']['styles'], 'css');
				}

				// Text / HTML layer
				if($layer['props']['media'] != 'post' || ($first != '<' && $last != '>')) {
					$inner->html(do_shortcode(stripslashes($layer['props']['html'])));
				}

				// Rewrite Youtube/Vimeo iframe src to data-src
				$video = $inner->find('iframe[src*="youtube-nocookie.com"], iframe[src*="youtube.com"], iframe[src*="youtu.be"], iframe[src*="player.vimeo"]');
				if( $video->length ) {
					$video->attr('data-src', $video->attr('src') );
					$video->removeAttr('src');
				}

				// Device dependent responsive classes
				if( ! empty($layer['props']['hide_on_desktop']) ) {
					$layerAttributes['class'] .=  ' ls-hide-desktop';
				}

				if( ! empty($layer['props']['hide_on_tablet']) ) {
					$layerAttributes['class'] .= ' ls-hide-tablet';
				}

				if( ! empty($layer['props']['hide_on_phone']) ) {
					$layerAttributes['class'] .= ' ls-hide-phone';
				}

				$el->attr( $layerAttributes );
				$inner->attr( $innerAttributes );

				if( ! empty( $layer['props']['outerAttributes'] ) ) {
					foreach( $layer['props']['outerAttributes'] as $key => $val ) {
						if( $key === 'class' ) {
							$el->addClass( $val );
						} else {
							$el->attr( $key, $val );
						}
					}
				}

				if( ! empty( $layer['props']['innerAttributes'] ) ) {
					foreach( $layer['props']['innerAttributes'] as $key => $val ) {
						if( $key === 'class' ) {
							$inner->addClass( $val );
						} else {
							$inner->attr( $key, $val );
						}
					}
				}

				$lsMarkup[] = $el;
				LayerSlider\PHPQuery\phpQuery::unloadDocuments();
			}
		}

		// Link this slide
		if(!empty($slide['props']['linkUrl'])) {
			if(!empty($slide['props']['linkTarget'])) {
				$target = ' target="'.$slide['props']['linkTarget'].'"'; } else { $target = '';
			}

			if($slide['props']['linkUrl'] == '[post-url]') {
				$slide['props']['linkUrl'] = $postContent->getWithFormat($slide['props']['linkUrl']);
			}

			// WPML support
			if( has_filter( 'wpml_translate_single_string' ) ) {

				if(!empty(${'_GET'}['lang']) && (strpos($slide['props']['linkUrl'], 'http') !== 0 || strpos($slide['props']['linkUrl'], $_SERVER['SERVER_NAME']) !== false)) {
					if(strpos($slide['props']['linkUrl'], '?') !== false) { $slide['props']['linkUrl'] .= '&amp;lang=' . ICL_LANGUAGE_CODE; }
					else { $slide['props']['linkUrl'] .= '?lang=' . ICL_LANGUAGE_CODE; }
				}
			}


			$linkClass = 'ls-link';
			if( empty( $slide['props']['linkType'] ) || $slide['props']['linkType'] === 'over' ) {
				$linkClass .= ' ls-link-on-top';
			}

			$lsMarkup[] = '<a href="'.$slide['props']['linkUrl'].'"'.$target.' class="'.$linkClass.'"></a>';
		}

		// End of slide
		$lsMarkup[] = '</div>';
	}
}

// End of slider container
$lsMarkup[] = '</div>';

// End of Popup wrapper
if( !empty($slides['properties']['attrs']['type']) && $slides['properties']['attrs']['type'] === 'popup' ) {
	$lsMarkup[] = '</div>';
}

// After slider content hook
if(has_action('layerslider_after_slider_content')) {
	do_action('layerslider_after_slider_content');
}