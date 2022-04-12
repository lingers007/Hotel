
/*-------------------------------------------------------------------------
# com_layer_slider - Creative Slider
# -------------------------------------------------------------------------
# @ author    John Gera, George Krupa, Janos Biro, Balint Polgarfi
# @ copyright Copyright (C) 2017 Offlajn.com  All Rights Reserved.
# @ license   http://www.gnu.org/licenses/gpl-2.0.html GNU/GPL
# @ website   http://www.offlajn.com
-------------------------------------------------------------------------*/



(function($){

	window._layerSlider.plugins.debug = function( ls, $slider, sliderUID, userSettings ){

		var d = this,
			params = document.location.hash.split( '?' )[1],
			param,
			defaultKeys = {
				transitionduration: 	'transitionDuration',
				td: 					'transitionDuration',
				firstslide: 			'firstSlide',
				fs: 					'firstSlide',
				timeline: 				'timeline',
				tl: 					'timeline'
			},
			timeline = {
				namespace: 'timeline',
				js: 'timeline/layerslider.timeline.js',
				css: 'timeline/layerslider.timeline.css',
				settings: {
					showLayersInfo: true,
					showLayersProperties: true
				}
			},
			forceSliderSettings = {
					autoStart 					: false,
					startInViewport				: false,
					pauseOnHover				: 'looplayers',
					skin						: 'v6',
					navPrevNext					: true,
					navStartStop				: true,
					navButtons					: true,
					keybNav						: true,
					touchNav					: true,
					hoverPrevNext				: true,
					hoverBottomNav				: false,
					showBarTimer				: true,
					showCircleTimer				: true,
					showSlideBarTimer 			: false,
					thumbnailNavigation			: 'hover',
					preventSliderClip 			: true
			};

		d.pluginData = {
			name: 'Debug Plugin for CreativeSlider',
			version: '1.1',
			requiredLSVersion: '6.1.0',
			authorName: 'Kreatura',
			releaseDate: '2016. 12. 07.'
		};

		d.init = function(){
			ls.debugMode = true;
			ls.debug = ls.initializedPlugins.debug;
			$.extend( ls.o, forceSliderSettings );
			d.showInfo();
		};

		d.options = {};

		if( params ){

			params = params.split( '&' );

			for( var p=0; p < params.length; p++ ){
				param = params[p].split( '=' );
				d.options[ defaultKeys[ $.trim( param[0].toLowerCase() ) ] ] = $.isNumeric( param[1] ) ? parseFloat( param[1] ) : $.trim( param[1] );
			}

			if( d.options.timeline ){
				ls.o.plugins.push( timeline );
				ls.o.pauseLayers = true;
			}
		}

		d.slider = 'CreativeSlider(' + sliderUID + '):';

		d.showInfo = function(){

			// Add settings table after the slider container
			var settingsRowsMarkup = [];

			// Prevent slider from clipping by parent elements
			$slider.parents( ':not(body, html)').each(function(){
				$(this).addClass( 'ls-overflow-visible' );
			});

			d.$tables = $('\
				<div class="ls-debug-window-wrapper">\
					<table class="ls-debug-slider-settings">\
						<thead>\
							<tr>\
								<th>User overwritten slider settings</th>\
								<th>Option keys</th>\
								<th>Defaults</th>\
								<th>New values</th>\
							</tr>\
						</thead>\
						<tbody>\
							\
						</tbody>\
					</table>\
				</div>\
				<div class="ls-debug-window-wrapper">\
					<table class="ls-debug-logs">\
						<thead>\
							<tr>\
								<th>Debug logs</th>\
							</tr>\
						</thead>\
						<tbody>\
							\
						</tbody>\
					</table>\
				</div>\
			').insertAfter( $slider );

			d.$logsTable = d.$tables.find( '.ls-debug-logs' );

			// Gather the markup of each option row in settingsRowsMarkup
			$.each( ls.userInitOptions, function( optionKey, optionVal) {

				var optionData 		= d.lng.sliderSettings[ optionKey ] || {},
					optionName 		= optionData.name || optionKey,
					optionDesc 		= optionData.desc || '',
					optionDefault 	= ls.defaults.init.options[ optionKey ];

				settingsRowsMarkup.push('\
					<tr data-help="'+optionDesc+'">\
						<td>'+optionName+'</td>\
						<td>'+optionKey+'</td>\
						<td>'+optionDefault+'</td>\
						<td>'+optionVal+'</td>\
					</tr>\
				');
			});

			// Insert the combined markup with a single DOM operation
			d.$tables.find('.ls-debug-slider-settings tbody').html( settingsRowsMarkup.join('') );
		};

		d.add = function( type, name, prop, forceCreateGroup ){

			if( name && name.indexOf('.') === -1 ){
				name += '.info';
			}

			var	groupName = name.split('.')[0],
				subName = name.split('.')[1],
				lng = d.lng[groupName];

			if( d.cache && type + groupName + subName !== d.cache ){
				d.showInfo();
			}

			if( typeof prop !== 'object' ){
				prop = [prop];
			}

			if( forceCreateGroup || type === 'group' ){
				if( d.lng[groupName].delay ){
					d.openedDelayedGroup = groupName;
					d.openedDelayedSub = subName;
					d.save( d.openedDelayedGroup, 'group', d.slider+' '+lng.n[subName].toUpperCase(), subName );
				}else{
					d.openedGroup = groupName;
					d.save( d.openedGroup, 'group', d.slider+' '+lng.n[subName].toUpperCase() );
				}
			}

			if( type === 'log' ){
				d.set( type, d.lng[groupName].l[subName], prop, groupName, subName );
			}else if( type === 'warn' ){
				d.set( type, d.lng[groupName].w[subName], prop, groupName, subName );
			}

			if( forceCreateGroup ){
				d.groupEnd( name );
			}
		};

		d.groupEnd = function( name ){

			if( name && name.indexOf('.') === -1 ){
				name += '.info';
			}

			var	groupName = name ? name.split('.')[0] : false,
				subName = name ? name.split('.')[1] : false;

			if( d.cache ){
				d.showInfo();
			}
			if( groupName && groupName === d.openedDelayedGroup && d.lng[d.openedDelayedGroup].delay ){
				d.save( d.openedDelayedGroup, 'groupEnd', false, d.openedDelayedSub );
				delete d.openedDelayedGroup;
				delete d.openedDelayedSub;
			}else{
				d.save( d.openedGroup, 'groupEnd', false, subName );
				delete d.openedGroup;
			}
		};

		d.set = function( type, lng, prop, groupName, subName ){

			var	curProp,
				msg;

			switch( type ){

				case 'log':
					for( var p=0; p<prop.length; p++ ){

						curProp = prop[p];
						msg = lng[p];

						if( typeof curProp !== 'undefined' ){
							if( typeof curProp !== 'object' ){
								curProp = [curProp];
							}
							for( var o=0; o<curProp.length; o++ ){
								msg = msg.replace( '$'+o, curProp[o] );
							}
							d.save( groupName, type, msg, subName );
						}
					}
				break;

				case 'warn':
					msg = lng[0];
					for( var p=0; p<prop.length; p++ ){
						msg = msg.replace( '$'+p, prop[p] );
					}
					d.save( groupName, type, msg, subName );

					if( lng[1] ){
						msg = lng[1];

						for( var p=0; p<prop.length; p++ ){
							msg = msg.replace( '$'+p, prop[p] );
						}

						d.cache = 'warn' + groupName + subName;
						d.showInfo = function(){
							d.save( groupName, 'info', msg, subName );
							delete d.cache;
							delete d.showInfo;
						};
					}
				break;
			}
		};

		d.save = function( groupName, type, msg, subName ){

			if( !d.lng[groupName].delay ){
				d.show( groupName, type, msg );
			}else{
				if( !d.collector ){
					d.collector = {};
				}
				if( !d.collector[subName] || type === 'group' ){
					d.collector[subName] = [];
				}
				d.collector[subName].push( [type,msg] );

				clearTimeout( d.debugTimeout );
				d.debugTimeout = setTimeout(function(){
					d.show( d.openedDelayedGroup, type, false, true );
				}, d.lng[groupName].delay );
			}
		};

		d.show = function( groupName, type, msg, delayed ){

			if( !d.extension ){
				d.extension = [];
			}

			if( delayed ){
				var p;
				for( var key in d.collector ){
					for( var f=0; f<d.collector[key].length; f++ ){
						p = d.collector[key][f];
						console[p[0]]( p[1] );
						d.extension.push( [type,p[1]] );
						if( p[1] ){
							if( p[1].indexOf( 'CreativeSlider(' + sliderUID + '):' ) !== -1 ){
								p[1] = p[1].split( 'CreativeSlider(' + sliderUID + '): ' )[1];
								type = 'group';
							}else{
								type = 'log';
							}
							d.$logsTable.append( '<tr class="ls-debug-log-type-' + type + '"><td>' + p[1] + '</td></tr>');
						}
					}
				}

				delete d.collector;
			}else{
				if( !msg && type === 'groupEnd' ){
					console[type]();
					d.extension.push( [type] );
				}else{
					console[type]( msg );
					d.extension.push( [type,msg] );
					if( type === 'group' ){
						msg = msg.split( ':' )[1];
					}
					d.$logsTable.append( '<tr class="ls-debug-log-type-' + type + '"><td>' + msg + '</td></tr>');
				}
			}
		};

		d.lng = {

			sliderInit: {
				n: {
					info: 'Initial slider data',
					style: 'Initial slider style'
				},
				l: {
					info: [
						'Plugin version: $0',
						'Release Date: $0',
						'Slider version: $0',
						'Slider id attribute: #$0',
						'Unique slider ID: $0',
						'jQuery version: $0',
						'WordPress Plugin Version: $0',
						'WordPress version: $0',
					],
					style: [
						'Width: $0px',
						'Height: $0px',
						'Original width: $0',
						'Original height: $0',
						'layersContainerWidth: $0px',
						'layersContainerHeight: $0px',
						'Ratio of slider width & height: $0',
						'Maximum Width: $0px',
						'Margin left & right: $0, $1'
					],
					customTransitions: [
						'layerSliderCustomTransitions object found. Custom slide transitions are loaded.'
					]
				},
				w: {
					margin: [
						'Originally detected horizontal margins ($0px) are converted to "auto".',
						'Margins of slider element should be specified in the element style attribute and not in external CSS file or in inline <style> element!'
					],
					noWidth: [
						'Slider has no initial width specified!',
						'Setting slider width to layersContainerWidth ($0px).'
					],
					noHeight: [
						'Slider has no initial height specified!',
						'Setting slider height to layersContainerHeight ($0px).'
					],
					noWidth2: [
						'Neighter initial width nor layersContainerWidth width specified!',
						'Setting slider width to element.clientWidth ($0px).'
					],
					noHeight2: [
						'Neighter initial height nor layersContainerHeight specified!',
						'Setting slider height to element.parent.clientHeight ($0px).'
					],

					responsive: [
						'Slider type is "$0", but it has percentage intial height: $1!',
						'Setting slider height to element.parent.clientHeight ($2px).'
					],

					fullsize: [
						'Slider type is "$0" and it has percentage intial width: $1!',
						'Converting percentage width to: $2px, (slider parent width is: $3px, layersContainerWidth is: $4px).'
					],
					fullsize2: [
						'Slider type is "$0" and it has percentage intial height: $1!',
						'Converting percentage height to: $2px, (window.height is: $3px, layersContainerHeight is: $4px).'
					],

					fullwidth: [
						'Slider type is "fullwidth", but it has no responsiveUnder property specified!',
						'Setting responsiveUnder to layersContainerWidth ($0px).'
					],
					fullwidth2: [
						'Slider type is "$0", but it has percentage intial height: $1!',
						'Converting percentage height to: $2px (regarding to element.parent.clientHeight).'
					],

					percWidth: [
						'Slider type is "$0", but it has percentage intial width: $1!',
						'Setting slider width to element.clientWidth ($2px)!'
					],

					conWidth: [
						'Slider type is "$0" and it has no layersContainerWidth property specified!',
						'Setting layersContainerWidth to sliderWidth ($1px).'
					],
					conHeight: [
						'Slider type is "$0" and it has no layersContainerHeight property specified!',
						'Saving layersContainerHeight to sliderHeight ($1px).'
					],
					conWidth2: [
						'Slider type is "$0" and it has unnecessary layersContainerWidth property: $1px!'
					],
					conHeight2: [
						'Slider type is "$0" and it has unnecessary layersContainerHeight property: $1px!'
					],

					bgCover: [
						'Slider type is "$0" and it has no backgroundSize property specified!',
						'Setting backgroundSize to "auto".'
					],
					slideTransitions: [
						'layerSliderTransitions object not found. Possible issue: layerslider.transitions.js file is not loaded.'
					],
					customTransitions: [
						'Slide $0 has custom transitions specified, but layerSliderCustomTransitions object not found! Using default - transition2d: 1 - slide transition. Possible issue: layerslider.customtransitions.js file is not loaded.'
					],
					noSlideTransitions: [
						'layerSliderTransitions or layerSliderCustomTransitions objects not found. Skipping slide transitions. Possible issue: layerslider.transitions.js and layerslider.customtransitions.js files are not loaded.'
					]
				}
			},

			layerInit: {
				n: {
					info: 'Initializing layers...'
				},
				w: {
					splitType1: [
						'Layer Init: A $0 layer on slide $1 which with children element(s) has text transition property! Possible issues: \r\n- the whole layer is invisible\r\n- parts of the layer are invisible\r\n- appearance (layer style) is wrong'
					],
					splitType2: [
						'Layer Init: An image or media layer on slide $0 has text transition property. $1 layer could not be splitted, ignoring.'
					],
					splitType3a: [
						'Layer Init: $0 layer has wrong texttypein property: $1',
						'Skipping text transition in on this layer.'
					],
					splitType3b: [
						'Layer Init: $0 layer has wrong texttypeout property: $1',
						'Skipping text transition out on this layer.'
					],
					prop1: [
						'Layer Init: Detected multiple property values in a non text transition related property: $0',
						'Original value: $1 -> converted to: $2'
					],
					prop2: [
						'Layer Init: Detected the following property with no value: $0'
					],
					prop3: [
						'Layer Init: Detected mistyped(?) comma character inside the value of property name $0: $1',
						'Cycled properties in text transitions must be separated with: | character.'
					],
					prop4: [
						'Layer Init: Unknown property name in layer data-ls: $0'
					]
				}
			},

			preload: {
				n: {
					info: 'Preload'
				},
				l: {
					info: [
						'Starting preload images of slide $0'
					],
					success: [
						'preloaded: $0'
					]
				},
				w: {
					fail: [
						'NOT preloaded: $0',
						'Possible issue: Wrong file name or URL!'
					]
				}
			},

			slideshow: {
				n: {
					info: 'Slideshow'
				},
				l: {
					inviewport: [
						'STARTINVIEWPORT: At least half of the slider is in viewport, starting layer transitions after preload...'
					],
					change: [
						'Current side index: $0',
						'Next slide index: $0',
						'Slideshow direction: $0',
						'Navigation direction: $0'
					],
					changedByUser: [
						'Changed by user'
					],
					setdir: [
						'Switching slideshow direction to: $0'
					]
				},
				w: {
					invalidSlideIndex: [
						'Tried to change to an invalid slide index: $0, (total number of slides: $1)'
					]
				}
			},

			resize: {
				delay: 250,
				n: {
					info: 'Resize layers',
					window: 'User Event: Viewport is resized!'
				},
				l: {
					window: [
						'New viewport width: $0px'
					]
				},
				w: {
					width: [
						'Layer[$0] has wrong original width property: $1'
					],
					height: [
						'Layer[$0] has wrong original height property: $1'
					]				}
			},

			slideTransition: {
				n: {
					info: 'Slide Transition'
				},
				l: {
					info: [
						'Type: $0',
						'Id: $0',
						'Name: $0'
					],
					properties: [
						'Cols * Rows: $0 * $1',
						'Total number of tiles: $0'
					]
				},
				w: {
					customTransition: [
						'The following $0 slide transition with ID $1 is not found. Using default - transition2d: 1 - slide transition.'
					],
					noSlideTransition: [
						'layerSliderTransitions or layerSliderCustomTransitions objects not found! Skipping slide transition on slide $0.'
					]
				}
			},

			layerTransition: {
				n: {
					info: 'Layer Transition'
				},
				w: {
					infinite: [
						'Warning: layer $0 has wrong timing properties which would cause an infinite loop!'
					],
					timing1: [
						'Wrong timing name: $0'
					],
					timing2: [
						'Calculated timing error of $0 property: $2',
						'Original value was: $1$2 -> will be 0'
					],
					timing3: [
						'Timing hierarchy does not match: $0[$1] <-> $2[$3]'
					]
				}
			},

			slideTimeline: {
				n: {
					info: 'Slide Timeline'
				},
				w: {
					restart: [
						'Slide Timeline: at least one layer on the current slide has loop offset x, loop offset y or clip transition.',
						'Slide timeline restart on resize is: $0'
					],
					duration: [
						'Slide Timeline: user specified slide duration is less than calculated ( $0s < $1s )!',
						'Some layer transitions may not visible before slide change'
					]
				}
			},

			sliderSettings: {

				// Layout
				// ====================
				'section_layout': {
					'title': 'Layout options'
				},

				'type': {
					'name': 'Layout type',
					'desc': 'The layout type.'
				},

				'responsiveUnder': {
					'name': 'Responsive under',
					'desc': 'Turns on responsive mode in a full-width slider under the specified value in pixels. Can only be used with full-width mode.'
				},

				'fitScreenWidth': {
					'name': 'Fit to screen width',
					'desc': 'If enabled, the slider will always have the same width as the viewport, even if a theme uses a boxed layout, unless you choose the "Fit to parent height" full size mode.'
				},

				'fullSizeMode': {
					'name': 'Full size mode',
					'desc': 'Select the sizing behavior of your full size sliders (e.g. hero scene).'
				},

				'allowFullscreen': {
					'name': 'Allow fullscreen mode',
					'desc': 'Visitors can enter OS native full-screen mode when double clicking on the slider.'
				},

				'maxRatio': {
					'name': 'Maximum responsive ratio',
					'desc': 'The slider will not enlarge your layers above the target ratio. The value 1 will keep your layers in their initial size, without any upscaling.'
				},

				'insertMethod': {
					'name': 'Insert method',
					'desc': 'Move your slider to a different part of the page by providing a jQuery DOM manipulation method & selector for the target destination.'
				},

				'insertSelector': {
					'name': 'Insert selector',
					'desc': 'Move your slider to a different part of the page by providing a jQuery DOM manipulation method & selector for the target destination.'
				},

				'clipSlideTransition': {
					'name': 'Allow fullscreen mode',
					'desc': 'Choose on which axis (if any) you want to clip the overflowing content (i.e. that breaks outside of the slider bounds).'
				},

				'preventSliderClip': {
					'name': 'Prevent slider clipping',
					'desc': 'Ensures that the theme cannot clip parts of the slider when used in a boxed layout.'
				},



				// Mobile
				// ====================
				'section_slideshow': {
					'title': 'Mobile options'
				},

				'hideOnMobile': {
					'name': 'Hide on mobile',
					'desc': 'Hides the slider on mobile devices, including tablets.'
				},

				'hideUnder': {
					'name': 'Hide under',
					'desc': 'Hides the slider when the viewport width goes under the specified value.'
				},

				'hideOver': {
					'name': 'Hide over',
					'desc': 'Hides the slider when the viewport becomes wider than the specified value.'
				},

				'slideOnSwipe': {
					'name': 'Use slide effect when swiping',
					'desc': 'Ignore selected slide transitions and use sliding effects only when users are changing slides with a swipe gesture on mobile devices.'
				},

				'optimizeForMobile': {
					'name': 'Optimize for mobile',
					'desc': 'Enable optimizations on mobile devices to avoid performance issues (e.g. fewer tiles in slide transitions, reducing performance-heavy effects with very similar results, etc).'
				},




				// Slideshow
				// ====================
				'section_slideshow': {
					'title': 'Slideshow options'
				},

				'firstSlide': {
					'name': 'Start with slide',
					'desc': 'The slider will start with the specified slide. You can also use the value "random".'
				},

				'autoStart': {
					'name': 'Auto-start slideshow',
					'desc': 'Slideshow will automatically start after page load.'
				},

				'startInViewport': {
					'name': 'Start only in viewport',
					'desc': 'If you enable this option, layer transitions will not start playing until the slideshow is in a paused state.'
				},

				'pauseOnHover': {
					'name': 'Pause on hover',
					'desc': 'The slider will not start until it becomes visible.'
				},

				'pauseLayers': {
					'name': 'Pause layers',
					'desc': 'Decide what should happen when you move your mouse cursor over the slider.'
				},

				'keybNav': {
					'name': 'Keyboard navigation	',
					'desc': 'You can navigate through slides with the left and right arrow keys.'
				},

				'touchNav': {
					'name': 'Touch navigation',
					'desc': 'Gesture-based navigation when swiping on touch-enabled devices.'
				},

				'playByScroll': {
					'name': 'Enable playByScroll',
					'desc': 'Play the slider by scrolling your mouse wheel.'
				},

				'playByScrollSpeed': {
					'name': 'PlayByScroll speed',
					'desc': 'Set the playing speed of Play by Scroll.'
				},

				'cycles': {
					'name': 'Cycles',
					'desc': 'Number of cycles if slideshow is enabled.'
				},

				'forceCycles': {
					'name': 'Force number of cycles',
					'desc': 'The slider will always stop at the given number of cycles, even if the slideshow restarts.'
				},

				'twoWaySlideshow': {
					'name': 'Two way slideshow',
					'desc': 'Slideshow can go backwards if someone switches to a previous slide.'
				},

				'shuffleSlideshow': {
					'name': 'Shuffle mode',
					'desc': 'Slideshow will proceed in random order. This feature does not work with looping.'
				},




				// Appearance
				// ====================
				'section_appearance': {
					'title': 'Appearance options'
				},

				'skin': {
					'name': 'Skin',
					'desc': 'The skin used for this slider. The \'noskin\' skin is a border- and buttonless skin. Your custom skins will appear in the list when you create their folders.'
				},

				'sliderFadeInDuration': {
					'name': 'Initial fade duration',
					'desc': 'Change the duration of the initial fade animation when the page loads. Enter 0 to disable fading.'
				},

				'globalBGColor': {
					'name': 'Background color',
					'desc': 'Global background color of the slider. Slides with non-transparent background will cover this one. You can use all CSS methods such as HEX or RGB(A) values.'
				},

				'globalBGImage': {
					'name': 'Background image',
					'desc': 'Global background image of the slider. Slides with non-transparent backgrounds will cover it. This image will not scale in responsive mode.'
				},

				'globalBGRepeat': {
					'name': 'Background repeat',
					'desc': 'Global background image repeat.'
				},

				'globalBGAttachment': {
					'name': 'Background behavior',
					'desc': 'Choose between a scrollable or fixed global background image.'
				},

				'globalBGPosition': {
					'name': 'Background position',
					'desc': 'Global background image position of the slider. The first value is the horizontal position and the second value is the vertical.'
				},

				'globalBGSize': {
					'name': 'Background size',
					'desc': 'Global background size of the slider. You can set the size in pixels, percentages, or constants: auto | cover | contain'
				},





				// Navigation
				// ====================
				'section_navigation': {
					'title': 'Navigation options'
				},

				'navPrevNext': {
					'name': 'Show Prev & Next buttons',
					'desc': 'Disabling this option will hide the Prev and Next buttons.'
				},

				'navStartStop': {
					'name': 'Show Start & Stop buttons',
					'desc': 'Disabling this option will hide the Start & Stop buttons.'
				},

				'navButtons': {
					'name': 'Show slide navigation buttons',
					'desc': 'Disabling this option will hide slide navigation buttons or thumbnails.'
				},

				'hoverPrevNext': {
					'name': 'Show Prev & Next buttons on hover',
					'desc': 'Show the buttons only when someone moves the mouse cursor over the slider. This option depends on the previous setting.'
				},

				'hoverBottomNav': {
					'name': 'Slide navigation on hover',
					'desc': 'Slide navigation buttons (including thumbnails) will be shown on mouse hover only.'
				},

				'showBarTimer': {
					'name': 'Show bar timer',
					'desc': 'Show the bar timer to indicate slideshow progression.'
				},

				'showCircleTimer': {
					'name': 'Show circle timer',
					'desc': 'Use circle timer to indicate slideshow progression.'
				},

				'showSlideBarTimer': {
					'name': 'Show slidebar timer',
					'desc': 'You can grab the slidebar timer playhead and seek the whole slide real-time like a movie.'
				},



				// Thumbnail Navigation
				// ====================
				'section_navarea': {
					'title': 'Thumbnail Navigation options'
				},

				'thumbnailNavigation': {
					'name': 'Thumbnail navigation',
					'desc': 'Use thumbnail navigation instead of slide bullet buttons.'
				},

				'tnContainerWidth': {
					'name': 'Thumbnail container width',
					'desc': 'The width of the thumbnail area relative to the slider size.'
				},

				'tnWidth': {
					'name': 'Thumbnail width',
					'desc': 'The width of thumbnails in the navigation area.'
				},

				'tnHeight': {
					'name': 'Thumbnail height',
					'desc': 'The height of thumbnails in the navigation area.'
				},

				'tnActiveOpacity': {
					'name': 'Active thumbnail opacity',
					'desc': 'Opacity in percentage of the active slide\'s thumbnail.'
				},

				'tnInactiveOpacity': {
					'name': 'Inactive thumbnail opacity',
					'desc': 'Opacity in percentage of inactive slide thumbnails.'
				},



				// Video
				// ====================
				'section_video': {
					'title': 'Video options'
				},

				'autoPlayVideos': {
					'name': 'Automatically play videos',
					'desc': 'Videos will be automatically started on the active slide.'
				},

				'autoPauseSlideshow': {
					'name': 'Pause slideshow',
					'desc': 'The slideshow can temporally be paused while videos are playing. You can choose to permanently stop the pause until manual restarting.'
				},

				'youtubePreview': {
					'name': 'Youtube preview',
					'desc': 'The automatically fetched preview image quaility for YouTube videos when you do not set your own. Please note, some videos do not have HD previews, and you may need to choose a lower quaility.'
				},


				// YourLogo
				// ====================
				'section_yourlogo': {
					'title': 'YourLogo'
				},

				'yourLogo': {
					'name': 'YourLogo',
					'desc': 'A fixed image layer can be shown above the slider that remains still during slide progression. Can be used to display logos or watermarks.'
				},

				'yourLogoStyle': {
					'name': 'YourLogo style',
					'desc': 'CSS properties to control the image placement and appearance.'
				},

				'yourLogoLink': {
					'name': 'yourLogo link',
					'desc': 'Enter an URL to link the YourLogo image.'
				},

				'yourLogoTarget': {
					'name': 'yourLogo target',
					'desc': ''
				},


				// DEFAULT OPTIONS
				// ====================
				'section_default_options': {
					'title': 'Default Options'
				},

				'slideBGSize': {
					'name': 'Background size',
					'desc': 'This will be used as a default on all slides, unless you choose to explicitly override it on a per slide basis.'
				},

				'slideBGPosition': {
					'name': 'Background position',
					'desc': 'This will be used as a default on all slides, unless you choose the explicitly override it on a per slide basis.'
				},

				'parallaxSensitivity': {
					'name': 'Parallax sensitivity',
					'desc': 'Increase or decrease the sensitivity of parallax content when moving your mouse cursor or tilting your mobile device.'
				},

				'parallaxCenterLayers': {
					'name': 'Parallax center layers',
					'desc': 'Choose a center point for parallax content where all layers will be aligned perfectly according to their original position.'
				},

				'parallaxCenterDegree': {
					'name': 'Parallax center degree	',
					'desc': 'Provide a comfortable holding position (in degrees) for mobile devices, which should be the center point for parallax content where all layers should align perfectly.'
				},

				'parallaxScrollReverse': {
					'name': 'Reverse scroll direction',
					'desc': 'Your parallax layers will move to the opposite direction when scrolling the page.'
				},

				'forceLayersOutDuration': {
					'name': 'Forced animation duration',
					'desc': 'The animation speed in milliseconds when the slider forces remaining layers out of scene before swapping slides.'
				},



				// MISC
				// ====================
				'section_misc': {
					'title': 'Misc'
				},


				'allowRestartOnResize': {
					'name': 'Allow restarting slides on resize',
					'desc': 'Certain transformation and transition options cannot be updated on the fly when the browser size or device orientation changes. By enabling this option, the slider will automatically detect such situations and will restart the itself to preserve its appearance.'
				},

				'useSrcset': {
					'name': 'Use srcset attribute',
					'desc': 'The srcset attribute allows loading dynamically scaled images based on screen resolution. It can save bandwidth and allow using retina-ready images on high resolution devices. In some rare edge cases, this option might cause blurry images.'
				}
			}
		};
	};

})(jQuery, undefined);