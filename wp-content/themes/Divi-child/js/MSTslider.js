jQuery.fn.extend({
	
	MSTslider: function (slider){
		
		if(jQuery(this).length){
			
			// Automatically adapt the height of the slider according to the currently selected slide : true / false ; DEFAULT false
			var autoheight = typeof slider.autoheight == "undefined" ? false : slider.autoheight;
			
			// Show or hide navigation; DEFAULT true
			var showNav = typeof slider.showNav == "undefined" ? true : slider.showNav;
			
			// Display pagination; DEFAULT true
			var pagination = typeof slider.pagination == "undefined" ? true : slider.pagination;
			
			// Speed of the slider; DEFAULT 5000
			var duration = typeof slider.duration == "undefined" ? 5000 : slider.duration;
			
			// Should be at least as long as the slider figure transition time; DEFAULT 750
			var unlock_duration = typeof slider.unlock_duration == "undefined" ? 750 : slider.unlock_duration;
			
			// Automatic sliding : true / false ; DEFAULT false
			var auto_slide = typeof slider.auto_slide == "undefined" ? false : slider.auto_slide;
			
			// Starting slide; 0 based index; 0 = first slide
			var starting_slide = typeof slider.starting_slide == "undefined" ? 0 : slider.starting_slide;
			
			// Lightbox; DEFAULT false
			var lightbox = typeof slider.lightbox == "undefined" ? false : slider.lightbox;
			
			// Navigate on figure click
			var nav_fig_click = typeof slider.nav_fig_click == "undefined" ? false : slider.nav_fig_click;
			
			var $this = jQuery(this);
			var locked = false;
			var timerX;
			
			/*
			** Get number of slides **
			*/
			var num_figures = $this.find("figure").size();
			
			/*
			** Add classes to the figures **
			*/
			if(num_figures == 1){
				// If there is only 1 slide, then add a animating class to it
				$this.find("figure:eq(0)").addClass("single-slide active-slide");
				showNav = false;
				auto_slide = false;
			} else {
				for (var i = 0; i < num_figures; i++){
					var current_slide = $this.find("figure:eq("+i+")");
					var next_slide = current_slide.next();
					current_slide.addClass("slide"+(i+1));
					if(i == starting_slide){
						current_slide.addClass("active-slide");
					} else {
						current_slide.addClass("unactive-slide");
					}
				}
			}
			
			/*
			** Add more classes (before and after) to the figures **
			*/
			function regex_remove_class($element){
				$element.removeClass(function (index, css) {return (css.match (/\bbefore-slide-\S+/g) || []).join(' ');});
				$element.removeClass(function (index, css) {return (css.match (/\bafter-slide-\S+/g) || []).join(' ');});
				$element.removeClass("slides-before slides-after");
			}
			
			/*
			** Add more classes **
			*/
			function add_more_classes(){
				
				if(num_figures > 1){
				
					var previous_slide = $this.find(".active-slide").prev("figure");
					var next_slide = $this.find(".active-slide").next("figure");
					var this_slide = $this.find(".active-slide");
					
					var i = j = 1;
					
					regex_remove_class($this.find(".active-slide"));
					
					// add before classes
					if(previous_slide.size()){
						function add_before_class(){
							regex_remove_class(previous_slide);
							previous_slide.addClass("slides-before before-slide-"+i);
							previous_slide = previous_slide.prev("figure");
							if(previous_slide.size()){
								i++;
								add_before_class();
							}
						}
						add_before_class();
					}
					
					// add after classes
					if(next_slide.size()){
						
						function add_after_class(){
							regex_remove_class(next_slide);
							next_slide.addClass("slides-after after-slide-"+j);
							next_slide = next_slide.next("figure");
							if(next_slide.size()){
								j++;
								add_after_class();
							}
						}
						add_after_class();
						
					}
				}
			}
			add_more_classes();
			
			/*
			** Add class to whichever the next slide is **
			*/
			function add_next_class(){

				if(num_figures > 1){
				
					var j = 1;
					var current = $this.find(".active-slide");
					add_next();
					add_prev();
					
					function add_next(){
					
						if(j <= num_figures){
							// add next classes
							current.removeClass(function (index, css) {return (css.match (/\bnext-slide-\S+/g) || []).join(' ');});
							current.addClass("next-slide-"+j);
							current = current.next("figure");
							j++;
							
							if(current.length){
								add_next();
							} else {
								current = $this.find("figure:eq(0)");
								add_next();
							}
						}
						
					}
					
					function add_prev(){
					
						if(j <= num_figures){
							// add next classes
							current = current.prev("figure");
							
							if(current.length){
								current.removeClass(function (index, css) {return (css.match (/\bprev-slide-\S+/g) || []).join(' ');});
								current.addClass("prev-slide-"+j);
							} else {
								current = $this.find("figure:eq("+num_figures+")");
								add_next();
							}
							j++;
						}
						
					}

				}
				
			}
			add_next_class();
			
			
			function unlock () {
				locked = false;
			}
			
			/*
			************************************ Navigate on figure click ************************************
			*/
			if(nav_fig_click){
				$this.find("figure").click(function(){
					var this_slide = jQuery(this);
					if(!this_slide.hasClass("active-slide")){
						var active_slide = $this.find(".active-slide");
						active_slide.removeClass("active-slide").addClass("transition-slide").one("transitionend webkitTransitionEnd", function(){
							active_slide.removeClass("transition-slide").addClass("unactive-slide");
						});
						this_slide.removeClass("unactive-slide").addClass("active-slide");
						
						callAll();
					}
				});
			}
			
			/*
			************************************ Active slider replacement function ************************************
			*/
			function switch_active_slide(next_active){
				
				locked = true;
				setTimeout(unlock, unlock_duration);
				clearTimeout(timerX);

				// Get the current slide & its index
				var active_slide = $this.find("figure.active-slide");
				var active = active_slide.index();
				
				// If NEXT ACTIVE SLIDE is undefined, set index
				if(typeof next_active == "undefined") {
					next_active = active + 1;
				}
				var next_active_slide = $this.find("figure:eq("+next_active+")");
				
				// If second to current slide doesent exists it means we've reached the end. So select the first figure instead
				if(next_active_slide.size() == 0){
					next_active_slide = $this.find("figure:eq(0)");
				}
				
				active_slide.removeClass("active-slide").addClass("transition-slide").one("transitionend webkitTransitionEnd", function(){
					active_slide.removeClass("transition-slide").addClass("unactive-slide");
				});
				next_active_slide.removeClass("unactive-slide").removeClass("transition-slide").addClass("active-slide");
				
				if(pagination == true && num_figures > 1){
					
					var id = next_active_slide.attr("id");
					jQuery(".MSTslider-pagination").find(".active").removeClass("active");
					jQuery(".MSTslider-pagination").find("#"+id).addClass("active");
					
				}
				
				if(lightbox == true){
					
				}
				
				callAll();
			}
			
			/*
			************************************ AUTOMATIC SLIDING ************************************
			*/
			function automatic_sliding(){
				
				if(auto_slide === true){
					
					timerX = setTimeout(function(){
						
						switch_active_slide();
						
					}, duration);
					
				}
				
			}
			
			/*
			************************************ NEXT SLIDE ************************************
			*/
			function MSTnext(){
				if(num_figures > 1){
					if(!locked){
						switch_active_slide();
					}
				}
			}
			
			/*
			************************************ PREVIOUS SLIDE ************************************
			*/
			function MSTprev(){
				if(num_figures > 1){
					if(!locked){

						var active_slide_index = $this.find("figure.active-slide").index();

						var prev_active_slide_index = active_slide_index -1;

						if(prev_active_slide_index <= -1){
							prev_active_slide_index = $this.find("figure").last().index();
						}

						switch_active_slide(prev_active_slide_index);
					}
				}
			}
			
			/*
			************************************ ARROW NAVIGATION ************************************
			*/
			if(showNav == true){
				
				$this.append('<div class="wrapper-MSTnav"><div class="MSTnav left"></div><div class="MSTnav right"></div></div>');
			}
			
			/*
			************************************ LIGHTBOX ************************************
			*/
			if(lightbox == true){
				
				$this.addClass("hasLightbox");
				
				// Define the wrapper for lightbox and prepend it to body			
				jQuery("body").prepend(
					"<div class='wrapper-lightbox'>"
						+"<div class='lightbox-close'></div>"
						+"<div class='container-lightbox'>"
							+"<div class='lightbox-nav lightbox-prev'><div class='lightboxnav left'></div></div>"
							+"<div class='lightbox-nav lightbox-next'><div class='lightboxnav right'></div></div>"
							+"<div class='element-lightbox'></div>"
						+"</div>"
					+"</div>"
				);
				
				// Define some shortcut variables
				var lightboxWrapper = jQuery(".wrapper-lightbox");
				var lightboxElement = jQuery(".element-lightbox");
				var i = "";
				
				// On image click, open the image in a lightbox
				$this.find("figure").click(function(){
					
					i = jQuery(this).index();
					show_image_lightbox(jQuery(this));
					
				});
				
				// Navigate left / right
				jQuery("body").on("click", ".lightbox-prev", function(){
					if(i > 0){
						i--;
						var fig = $this.find("figure:eq("+i+")");
						show_image_lightbox(fig);
					}
				});
				jQuery("body").on("click", ".lightbox-next", function(){
					if(i < (num_figures-1)){
						i++;
						var fig = $this.find("figure:eq("+i+")");
						show_image_lightbox(fig);
					}
				});
				
				jQuery(document).on("keyup", function(e){
					if(jQuery(".wrapper-lightbox").is(".open")){
						if (e.keyCode == 37) {
							if(i > 0){
								i--;
								var fig = $this.find("figure:eq("+i+")");
								show_image_lightbox(fig);
							}
						}
						if (e.keyCode == 39) {
							if(i < (num_figures-1)){
								i++;
								var fig = $this.find("figure:eq("+i+")");
								show_image_lightbox(fig);
							}
						}
					}
				});
				
				// Close the lightbox
				jQuery(document).keyup(function(e) {
					if (e.keyCode === 27) {lightboxWrapper.removeClass("open")};
				});
				jQuery("body").on("click", ".lightbox-close", function(){
					lightboxWrapper.removeClass("open")
				});
				
				function show_image_lightbox($fig){
					
					var img = $fig.html().replace("30vw", "100vw");
					
					lightboxWrapper.addClass("open");
					lightboxElement.html(img);
				}
			
			}
			
			/*
			************************************ PAGINATION ************************************
			*/
			if(pagination == true && num_figures > 1){
				
				var divs = "";
				
				$this.find("figure").each(function(){
					
					var active = "";
					
					if(jQuery(this).hasClass("active-slide")){
						active = "active";
					}
					
					var id = jQuery(this).attr("id");
					divs += "<div class='MSTslider-pageitem "+active+"' id='"+id+"'></div>";
					
				});
				
				$this.append("<div class='MSTslider-pagination'>"+divs+"</div>");
				
				$this.on("click", ".MSTslider-pageitem", function(){
					
					if(!locked){
						
						if(!jQuery(this).hasClass("active")){
							var id = jQuery(this).attr("id");
							paginationSlide(id);
						}
					
					}
					
				});
				
				/*
				** Pagination slide **
				*/
				function paginationSlide(id){
					
					new_active_slide_index = $this.find("figure#"+id).index();
					
					switch_active_slide(new_active_slide_index);
					
					callAll();
					
				}
				
			}
			
			/*
			************************************ AUTOHEIGHT ************************************
			*/
			function do_autoheight(){
				
				if(autoheight == true){
				
					var active_height = $this.find(".active-slide").height() + 30;
					
					$this.stop().animate({height:active_height}, 1000);
				
				}
				
			}
			
			/*
			************************************ WINDOW Tab BLUR / FOCUS ************************************
			*/
			var save_auto_slide = JSON.parse(JSON.stringify(auto_slide));
			
			jQuery(window).blur(function(){
				clearTimeout(timerX);
				$this.find(".transition-slide").each(function(){
					jQuery(this).removeClass("transition-slide");
					jQuery(this).addClass("unactive-slide");
				});
				auto_slide = false;
			})
			
			jQuery(window).focus(function(){
				auto_slide = save_auto_slide;
				automatic_sliding();
			});
			
			/*
			************************************ Click navigation ************************************
			*/
			$this.find(".MSTnav.left").on('click', function(){ MSTprev(); });
			$this.find(".MSTnav.right").on('click', function(){ MSTnext(); });
			
			/*
			************************************ Keyboard arrow navigation ************************************
			*/
			jQuery(document).on("keyup", function(e){
				if (e.keyCode == 37) {
					if(!jQuery(".wrapper-lightbox").is(".open")){
						MSTprev();
					}
				}
				if (e.keyCode == 39) {
					if(!jQuery(".wrapper-lightbox").is(".open")){
						MSTnext();
					}
				}
			});
			
			/*
			************************************ Prevent dragging images ************************************
			*/
			$this.find("img").on("dragstart", function(e) { e.preventDefault(); });
			
			/*
			************************************ Swipe navigation ************************************
			*/
			$this.on("swipeleft",function(){ MSTnext();});
			$this.on("swiperight",function(){ MSTprev();});
			
			/*
			************************************ Stacked functions ************************************
			*/
			function callAll(){
					
				automatic_sliding();
				
				add_more_classes();
				
				add_next_class();
				
				do_autoheight();
				
			}
			
			/*
			************************************ on load functions ************************************
			*/
			setTimeout(function(){
				
				automatic_sliding();

				do_autoheight();
				
			}, 500);

		}
		
	}
	
});