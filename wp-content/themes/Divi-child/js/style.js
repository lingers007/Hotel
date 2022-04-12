


var contactFormEmail = "";
var readoutEmail = "";

/*setTimeout(function() {
  if (window.location.pathname.split( '/' )[1] == 'dining' || window.location.pathname.split( '/' )[1] == 'spa-health-club' || window.location.pathname.split( '/' )[1] == 'spa-at-the-landmark-london') {
      jQuery('.book-direct').hide();
  } 
}, 200);*/
jQuery(document).ready(function($){
  /*if (window.location.pathname.split( '/' )[1] == 'dining' || window.location.pathname.split( '/' )[1] == 'spa-health-club' || window.location.pathname.split( '/' )[1] == 'spa-at-the-landmark-london') {
      jQuery('.book-direct').hide();
  } */
	var currentURL = document.URL;
  var pages = [
  "/suites-rooms/",
	"https://www.landmarklondon.co.uk/dining/",
	"https://www.landmarklondon.co.uk/meetings-events/",
	"https://www.landmarklondon.co.uk/spa-at-the-landmark-london/",
	"https://www.landmarklondon.co.uk/offers/",
	"https://www.landmarklondon.co.uk/location/",
	"https://www.landmarklondon.co.uk/gallery/",
	"https://www.landmarklondon.co.uk/careers/",
	"https://www.landmarklondon.co.uk/corporate-social-responsibility/",
	"https://www.landmarklondon.co.uk/privacy-policy/",
	"https://www.landmarklondon.co.uk/terms-and-conditions/",
	"https://www.landmarklondon.co.uk/hotel-policy/",
	"https://www.landmarklondon.co.uk/car-parking/",
	"https://www.landmarklondon.co.uk/media/",
	"https://www.landmarklondon.co.uk/suites-rooms/",
	"https://www.landmarklondon.co.uk/festive-season/"
	];
	var foundMainPage = false;
	for (var a = 0; a < pages.length; a++) {
		if (currentURL.toLowerCase().indexOf(pages[a]) > -1 && currentURL.substring(0, currentURL.length - 1).toLowerCase().indexOf(pages[a]) == -1) {
			jQuery(".back_to_section").show();

      jQuery(".back-section-text").html("BACK");

      jQuery(".back_to_section").click(function () {
          window.location.href = 'https://www.landmarklondon.co.uk/';
      });
      foundMainPage = true;
      break;
		}
	}
  currentURL = currentURL.substring(0, currentURL.length - 1);
  if (currentURL.toLowerCase().indexOf("https://www.landmarklondon.co.uk/location/") > -1 ||
      currentURL.toLowerCase().indexOf("https://www.landmarklondon.co.uk/gallery/") > -1 ||
      currentURL.toLowerCase().indexOf("https://www.landmarklondon.co.uk/offers/") > -1 ||
      currentURL.toLowerCase().indexOf("https://www.landmarklondon.co.uk/promotions/") > -1 ||
      currentURL.toLowerCase().indexOf("https://www.landmarklondon.co.uk/spa-at-the-landmark-london/") > -1) {
      jQuery(".back_to_section").show();

      jQuery(".back-section-text").html("BACK");

      jQuery(".back_to_section").click(function () {
          window.history.go(-1);
      });
  }


    /*
	**************************** Anchor scrolling ****************************
	*/
	var $hash = window.location.hash;
			
	$hash = $hash.replace('#','');

	if($hash.length) MSToffsetTop($hash);

    /*
	**************************** start page ****************************
	*/
		jQuery(".list-link-container").hover(function () {
			if(isMobile == false){
                $(this).parent().parent().parent().parent().addClass("visible");
                //$(this).parent().parent().addClass("active");
			}



        });

    jQuery(".list-link-wrap").hover(function () {
        if(isMobile == false) {

            jQuery(".list-item").removeClass("visible");
        }
    });

	/*
	**************************** Guest suitability info text on click ****************************
	*/
	$('.suitability_info').click(function(){

		var elem = $(this).siblings('.suitability_text');

		if(elem.hasClass('open')){

			elem.removeClass('open');

		} else {

			$('.suitability_text.open').removeClass('open');

			elem.addClass('open');

		}

	});

	

	$('body').click(function(evt){

		if(!$(evt.target).is('.suitability_info span')) $('.suitability_text.open').removeClass('open');

	});

	/*
	**************************** Newsletter binding ****************************
	*/
	$(".newsletter-submit a").click(function(evt){

		evt.preventDefault();

		var elem = $(this).parents('.element-newsletter');

		var mail = $(this).parents(".wrapper-newsletter").find(".newsletter-input input.input-newsletterEmail").val();

		var type = $(this).parents(".wrapper-newsletter").find(".newsletter-input input.input-newsletterType").val();

		if(isValidEmailAddress(mail)){

			elem.children('.newsletter-input').removeClass('error');
			elem.children('.newsletter-input').find('input').attr('disabled', 'disabled');
			elem.children('.newsletter-submit').addClass('hide');

			$.ajax({
				type: "POST",
				url: ajaxurl,
				data: {
					action: "add_contact_to_dotmailer",
					mail: mail,
					type: type
				}, success: function(response) {
					console.log(response);
					elem.children('.newsletter-input').addClass('success');
				}
			});

		} else {
			elem.children('.newsletter-input').addClass('error');
		}

	});

	function isValidEmailAddress(emailAddress) {
		var pattern = /^([a-z\d!#$%&'*+\-\/=?^_`{|}~\u00A0-\uD7FF\uF900-\uFDCF\uFDF0-\uFFEF]+(\.[a-z\d!#$%&'*+\-\/=?^_`{|}~\u00A0-\uD7FF\uF900-\uFDCF\uFDF0-\uFFEF]+)*|"((([ \t]*\r\n)?[ \t]+)?([\x01-\x08\x0b\x0c\x0e-\x1f\x7f\x21\x23-\x5b\x5d-\x7e\u00A0-\uD7FF\uF900-\uFDCF\uFDF0-\uFFEF]|\\[\x01-\x09\x0b\x0c\x0d-\x7f\u00A0-\uD7FF\uF900-\uFDCF\uFDF0-\uFFEF]))*(([ \t]*\r\n)?[ \t]+)?")@(([a-z\d\u00A0-\uD7FF\uF900-\uFDCF\uFDF0-\uFFEF]|[a-z\d\u00A0-\uD7FF\uF900-\uFDCF\uFDF0-\uFFEF][a-z\d\-._~\u00A0-\uD7FF\uF900-\uFDCF\uFDF0-\uFFEF]*[a-z\d\u00A0-\uD7FF\uF900-\uFDCF\uFDF0-\uFFEF])\.)+([a-z\u00A0-\uD7FF\uF900-\uFDCF\uFDF0-\uFFEF]|[a-z\u00A0-\uD7FF\uF900-\uFDCF\uFDF0-\uFFEF][a-z\d\-._~\u00A0-\uD7FF\uF900-\uFDCF\uFDF0-\uFFEF]*[a-z\u00A0-\uD7FF\uF900-\uFDCF\uFDF0-\uFFEF])\.?$/i;
		return pattern.test(emailAddress);
	};

	/*
	**************************** Weather plugin ****************************
	*/
	$.simpleWeather({
		location: 'London, United Kingdom',
		woeid: '',
		unit: 'c',
		success: function(weather) {
			html = '<div class="weather-date">'+weather.forecast[0].date+'</div>';
			html += '<div class="weather-icon-temp"><div class="weather-icon"><i class="icon-'+weather.code+'"></i></div>';
			html += '<div class="weather-temp">'+weather.temp+'&deg;'+weather.units.temp+'</div></div>';
			
			$("#weather").html(html);
		},
		error: function(error) {
			$("#weather").html('<p>'+error+'</p>');
		}
	});



	$(window).load(function() {
		
		$("body").removeClass("preload");

		/*
		**************************** Review link automatically open review form ****************************
		*/
		if($(".wrapper-reviews").length){

			var url = window.location.hash;
			
			url = url.replace('#','');

			if(url == "review"){

				$(".wrapper-reviews a.show_overlay").trigger("click");

			}

		}

		/*
		**************************** Accordion wrapper for listing elements - amenities & media ****************************
		*/
		$(".accordion").each(function(){
			
			var Aheight = $(this).outerHeight();
			
			if(Aheight > 300){
				
				$(this).siblings(".wrapper-cta").find(".hidden").removeClass("hidden");
				
				$(this).wrap("<div class='wrapper-accordion'></div>");
				
			}
			
		});
		
		$(".cta.stretch_accordion").click(function(evt){
			
			evt.preventDefault();
			
			if($(this).hasClass("open")){
				
				$(this).parents(".wrapper-cta").prev(".wrapper-accordion").css("max-height", "");



            } else {

				var Amaxheight = $(this).parents(".wrapper-cta").prev(".wrapper-accordion").children(".accordion").outerHeight();
				
				$(this).parents(".wrapper-cta").prev(".wrapper-accordion").css("max-height", Amaxheight+"px");


            }
			
			$(this).parents(".wrapper-cta").prev(".wrapper-accordion").toggleClass("open");
			
			$(this).parents(".wrapper-cta").find("a").each(function(){

                $(this).toggleClass("open grey");

			});
			
		});
		
	});
	
	/*
	**************************** Scroll functions ****************************
	*/
	jQuery(window).scroll( function(){

		// back to top scroll function
		var scroll_top = jQuery(window).scrollTop();

		if(scroll_top >= "500"){
			jQuery(".back_to_top").css("opacity", "0.5");
		} else {
			jQuery(".back_to_top").css("opacity", "0");
		}

        // back to section scroll function
        var scroll_top = jQuery(window).scrollTop();

        if(scroll_top >= "500"){
            jQuery(".back_to_section").css("opacity", "0.5");
        } else {
            jQuery(".back_to_section").css("opacity", "0");
        }

	});

	/*
	**************************** Back to top click function ****************************
	*/
	var flag = 0;

	jQuery(".anchor-item a").click(function(){

		flag = 1;

	});

	jQuery(".back_to_top").click(function(){

		var top = 0;

		if(flag == 1){
			flag = 0;
			top = ( $(".wrapper-anchors").offset().top ) - 150;
		}

		jQuery('body,html').animate({
			scrollTop: top,
		}, 750 );

	});

	/*
	**************************** Category list - CPT that have promotions - on click, rotate the item ****************************
	*/
	$(".list-item.hasBackface").each(function(){
		
		var item = $(this);

		$(".list-image a").click(function(evt){
			if(item.hasClass("active")){
				evt.preventDefault();
				item.removeClass("active");
			}
		});

		$(this).find(".front .anim_anchor").each(function(){

			$(this).click(function(evt){

				evt.preventDefault();
				var elem = $(this).attr("id");
				$(this).parents("."+elem).toggleClass("active");

			});

		});

	});

	/*
	**************************** Close buttons ****************************
	*/
	$(".button_close").click(function(e){
		
		e.preventDefault();
		
		var elem_selector = $(this).attr("data-close");
		
		var elem = $(this).closest("."+elem_selector);
		
		elem.addClass("fadeOut").one("transitionend webkitTransitionEnd", function(){
			$(this).remove();
		});
		
	});
	
	/*
	**************************** Switches ****************************
	*/
	$(".promowidget-switch").click(function(){
		
		$(this).toggleClass("on");
		
		$(this).siblings(".promowidget-drawer").slideToggle(500);
		
	});

	$(".harmonic-switch").click(function(){

		$(this).toggleClass("on");
		
		$(this).siblings(".harmonic-drawer").slideToggle(500);

	});

    /*
	**************************** Rooms Filter categorie ****************************
	*/
		if (window.location.search.substr(1) && window.location.search.substr(1).indexOf("suite") > -1) {
			$(".cta.filter-button-rooms.suites").removeClass("inactive");
      $(".cta.filter-button-rooms.rooms").removeClass("inactive");
      $(".cta.filter-button-rooms.rooms").addClass("inactive");

      $(".card-item.room").removeClass("active");
      $(".card-item.suite").addClass("active");
		} else {
    	$(".card-item.room").addClass("active");
		}


    $(".cta.filter-button-rooms.suites").click(function(e){
        e.preventDefault();

				$(".cta.filter-button-rooms.suites").removeClass("inactive");
        $(".cta.filter-button-rooms.rooms").removeClass("inactive");
        $(".cta.filter-button-rooms.rooms").addClass("inactive");

        $(".card-item.room").removeClass("active");
        $(".card-item.suite").addClass("active");

    });

    $(".cta.filter-button-rooms.rooms").click(function(e){
        e.preventDefault();

        $(".cta.filter-button-rooms.suites").removeClass("inactive");
        $(".cta.filter-button-rooms.rooms").removeClass("inactive");
        $(".cta.filter-button-rooms.suites").addClass("inactive");


        $(".card-item.room").addClass("active");
        $(".card-item.suite").removeClass("active");

    });

    /*
    **************************** Show / hide overlays ****************************
    */
	$(".show_overlay").click(function(e){
		
		e.preventDefault();
		
		var elem = $(this).attr("id");
		
		var elemData = $(this).attr("data-overlay");
		if (elemData == 'booking') {
			//$(".booking-widget").toggle();
		} else {

			var roomData = "";

			if($(this).attr("data-room")) roomData = $(this).attr("data-room");
			
			var elemDataResponse = ajax_get_overlay(elem, elemData, roomData);
			
			$("."+elem).toggleClass("show");
			
			$("#page-container").toggleClass("hide");
			
			toggle_overflow_hidden("body");
		}
		
	});

    $(".hide_overlay").click(function(e){

        e.preventDefault();

        $(this).parents(".show").toggleClass("show");

        jQuery("#page-container").toggleClass("hide");

        toggle_overflow_hidden("body");

        $("#ui-datepicker-div").hide();


    });

    $(".show_overlay-fixcontent").unbind('click').click(function(e){

        e.preventDefault();

        var elem = $(this).attr("id");
        var type = $(this).attr("type");

        $("."+elem+"."+type).toggleClass("show");

        //$("#page-container").toggleClass("hide");

        toggle_overflow_hidden("body");

    });

    if($('a[href^="mailto:"]').length != 0){

        var mails = $('a[href^="mailto:"]');

        if(contactFormEmail.length == 0){

            if(mails.length > 1) {
                jQuery.each(mails, function () {
                    if (jQuery(this).attr("href") == "mailto:reservations@thelandmark.co.uk") {
                        return;
                    } else {
                        contactFormEmail = jQuery(this).attr("href").replace("mailto:", "");
                    }
                });
            } else {

                contactFormEmail = jQuery(mails[0]).attr("href").replace("mailto:", "");
            }
        }

        jQuery.each($('a[href^="mailto:"]'), function () {
            var mail = $(this);

            mail.html(mail.text().replace("@", "&shy;@"));

        });

	}

    $('a[href^="mailto:"]').click(function(e){
		
		if (jQuery(this).attr("href") == "mailto:reservations@thelandmark.co.uk") {
			return;
		}

        var type = $(this).attr("type");

        if(typeof type != "undefined" && type == "contact"){
            return;
        }
        e.preventDefault();

        //var elem = $(this).attr("id");



        $(".wrapper-overlay-fixcontent.contact").toggleClass("show");

        //$("#page-container").toggleClass("hide");

        toggle_overflow_hidden("body");
    });

    jQuery(".hide_overlay-fixcontent").click(function(e){


        e.preventDefault();

        jQuery(this).parents(".show").toggleClass("show");

        //$("#page-container").toggleClass("hide");

        toggle_overflow_hidden("body");

    });


    /*
    **************************** Whenever body has overflow: hidden, the scrollbar dissaperas and the site jumps. ****************************
    **************************** Prevent this jumping with this function bellow ****************************
    */

	var body_widthCurent = $("body").width();

	function toggle_overflow_hidden(elem_tag){

		$elem = $(elem_tag);

		$elem.toggleClass("overflow");

		var body_widthOverflow = $("body").width();

		var body_widthDifference = body_widthOverflow - body_widthCurent;

		if(body_widthDifference > 0){
			// If overflow is hidden, deduct the scrollbar width from the body and appyl new width
			$elem.css("width", body_widthCurent);
		} else {
			// Else remove the dynamicaly added width
			$elem.css("width", "");
		}

	}
	
	/*
	**************************** Arrow down click function ****************************
	*/
	$(".element-arrowdown").click(function(){

		var elem = $("#anchor-arrowdown");
		MSTscrollTop(elem);
		
	});
	
	/*
	**************************** Mobile icon ****************************
	*/
	$(".mobileIcon").click(function(evt){

		evt.preventDefault();
		toggleMenu();
		
	});
	
	/*
	**************************** Define sliders ****************************
	*/
	$(".MSTslider").MSTslider({
		auto_slide: true,
		showNav: false,
		unlock_duration: 1250
	});
	
	$(".reviews-slider").MSTslider({
		autoheight: true,
		pagination: false,
		nav_fig_click: true,
		unlock_duration: 500
	});
	
	/*
	$(".photos-slider").MSTslider({
		pagination: false,
		nav_fig_click: true,
		lightbox: true,
		starting_slide: 1,
		unlock_duration: 500
	});
	*/
	
	$(".slider-menus").MSTslider({
		pagination: false,
		nav_fig_click: true,
		starting_slide: 1,
		unlock_duration: 500
	});

	$(".slider-activepromo").each(function(){
		$(this).MSTslider({
			pagination: false,
			nav_fig_click: true,
			unlock_duration: 1000
		});
	});
	
	/*
	**************************** Function : Additional element animations when click on mobile icon ****************************
	*/
	function toggleMenu(){
		
		$(".mobileIcon").toggleClass("open");
		$(".wrapper-mobileMenu").toggleClass("open");
		/*$(".wrapper-search").toggleClass("hide");*/
		$("body").toggleClass("overflow");

	}
	
	/*
	**************************** Function : Offset top scrolling ****************************
	*/
	function MSTscrollTop(elem){
		
		var oft = (elem.offset().top) - 150;
		$('html, body').animate({scrollTop: oft}, 1500);
		
	}

	/*
	**************************** Function : Offset top to element ****************************
	*/
	function MSToffsetTop(hash){
		
		var $header_height = $('header').outerHeight();

		$elem_top = ( $('#'+$hash).offset().top ) - $header_height - 10;

		$('body,html').animate({
			scrollTop: $elem_top,
		}, 750 );
		
	}

	/*
	**************************** SEARCH - when we change the dropdown for types, call the function for population ****************************
	*/
	$(".wrapper-overlay").on('change', 'select.filter-select-type', function(){
		
		// When filter select changes, start the function
		var type = $(this).val();
		
		get_type_fields(type);
		
	});
	
	/*
	**************************** Ajax - depending on what overlay button we clicked, populate the overlay accordingly with forms or filter ****************************
	*/
	function ajax_get_overlay(elem, elemData, roomData){
		
		$.ajax({
			type: "POST",
			url: ajaxurl,
			data: {
				action: "add_shortcode_to_overlay",
				elemData: elemData,
				roomData: roomData
			}, success: function(response) {
				$("."+elem+" .wrapper-overlay-inner").html(response);
			}
		});
		
	}
	
	/*
	**************************** AJAX - SEARCH - depending on what type we chose, populate the filter option fields accordingly ****************************
	*/
	function get_type_fields(type){

		$.ajax({
			type: "POST",
			url: ajaxurl,
			data: {
				action: "get_type_fields",
				type: type
			}, success: function(response) {
				$(".filter-return").html(response);
			}
		});
		
	}
	
	/*
	**************************** On ajax complete functions ****************************
	*/
	$(document).ajaxComplete(function() {

		/*
		** Send review to wordpress **
		*/
		$(".sendReview").click(function(evt){

			evt.preventDefault();

			if(!$(this).hasClass('faded')){

				$(this).addClass('faded');

				// submit the comment and refresh the page
				var comment = $("#previewReview-comment").text();
				var author = $("#previewReview-author").text();
				var room_id = $("select.select-room").find("option:selected").attr("id");

				$.ajax({
					type: "POST",
					url: ajaxurl,
					data: {
						action: "send_review",
						c_content: comment,
						c_user: author,
						c_roomID: room_id
					}, success: function(response) {

						$('.addComment-preview').find('.wrapper-preview').each(function(){

							if($(this).hasClass('hidden')){
								$(this).addClass('show');
							} else {
								$(this).addClass('hide');
							}

							$('.sendReview').removeClass('faded');

						});

					}
				});

			}

		});

		/*
		** Preview the review on click **
		*/
		$(".addReview-preview").click(function(evt){

			evt.preventDefault();

			$(".myForm .error").removeClass('error');

			// Test if fields are filled correctly
			var dateFrom = $("#addReview-dateFrom").val();
			var dateTo = $("#addReview-dateTo").val();
			var comment = $("#addReview-comment").val();

			if(!dateFrom) $("#addReview-dateFrom").addClass('error');
			if(!dateTo) $("#addReview-dateTo").addClass('error');
			if(!comment) $("#addReview-comment").addClass('error');

			// If all the fields are filled out, show the preview
			if(dateFrom && dateTo && comment){

				$('.addComment-preview .wrapper-preview').removeClass('show hide');

				$(".addComment").addClass("close");
				$(".addComment-preview").addClass("open");
				$("#previewReview-comment").text(comment);

			}

		});

		/*
		** Declare datepickers on Ajax laods; like on addReview **
		*/
		$( function() {

			$( "#addReview-dateFrom" ).datepicker({
				dateFormat: 'd MM, yy',
				// set Minimum date on the second date field
				onSelect: function(date){
					var dateMin = $("#addReview-dateFrom").datepicker("getDate");
					$("#addReview-dateTo").datepicker("option", "minDate", dateMin);
				}
			});

			$( "#addReview-dateTo" ).datepicker({
				dateFormat: 'd MM, yy',
				// set Maximum date on the first date field
				onSelect: function(date){
					var dateMax = $("#addReview-dateTo").datepicker("getDate");
					$("#addReview-dateFrom").datepicker("option", "maxDate", dateMax);
				}
			});

			/*
			**************************** Guest suitability info text on click ****************************
			*/
			$( "#booking-arrival" ).datepicker({
				dateFormat:'<span>d</span> MM, yy',
				// set Minimum date on the second date field
				onSelect: function(date){
					var dateMin = $("#booking-arrival").datepicker("getDate");
					$("#booking-departure").datepicker("option", "minDate", dateMin);
					copy_dates();
				}
			});

			$( "#booking-departure" ).datepicker({
				dateFormat: '<span>d</span> MM, yy',
				// set Minimum date on the second date field
				onSelect: function(date){
					var dateMax = $("#booking-departure").datepicker("getDate");
					$("#booking-arrival").datepicker("option", "maxDate", dateMax);
					copy_dates();
				}
			});

			var datenow = new Date();
			var datethen = '+7';
			$( "#booking-arrival" ).datepicker( "setDate", datenow);
			$( "#booking-arrival" ).datepicker( "option", "maxDate", datethen);
			$( "#booking-departure" ).datepicker( "setDate", datethen);
			$( "#booking-departure" ).datepicker( "option", "minDate", datenow);

			copy_dates();

		});

		/*
		** Copying arrival & departure dates from datepicker to the formatted field **
		*/
		function copy_dates(){

			var val_arrival = $('#booking-arrival').val();
			var val_departure= $('#booking-departure').val();

			$('#booking-arrival-alternate').html(val_arrival);
			$('#booking-arrival-departure').html(val_departure);

		}

		/*
		** Adults plus minus + / - **
		*/
		$('.wrapper-adults .element-adults').click(function(){

			if($(this).hasClass('number')) return;

			var num = parseInt($('.element-adults.number').text());

			var newNum = 1;

			if($(this).hasClass('plus')) newNum = num + 1;

			if($(this).hasClass('minus')) if(num > 1) newNum = num - 1;

			$('.element-adults.number').text(newNum);

		});

		/*
		** Declare select-2-ul on Ajax loads; like on addReview, search,... **
		*/
		$('select.mySelect').select2();

		/*
		** Option slider **
		*/
		function updateSL(elem, units, sliderBlock, sliderRatio){
			
			var dataLegend = elem.attr("data-legend");
			
			// Position the sliders on the bar correctly according to the value
			elem.css("left", units * sliderRatio);
			
			// Update the input
			elem.siblings("input#"+dataLegend).val(units);
			
			// Update the legend
			sliderBlock.find(".optionSlider-legend ."+dataLegend+" span").text(units);
			
		}
		
		if($(".wrapper-optionSlider").length){
			
			$(".wrapper-optionSlider").each(function(){
				
				var sliderBlock = $(this);

				var elem1 = sliderBlock.find("#optionSlider-slide1");
				var elem2 = sliderBlock.find("#optionSlider-slide2");
				
				var units1 = elem1.attr("data-value");
				var units2 = elem2.attr("data-value");
				
				// Define the ratio from width to units; 1px = 'sliderRatio' units
				var sliderWidth = sliderBlock.find(".optionSlider").width();
				var sliderUnits = units2 - units1;
				var sliderRatio = sliderWidth / sliderUnits;
				
				// Update slider & Legend
				updateSL(elem1, units1, sliderBlock, sliderRatio);
				updateSL(elem2, units2, sliderBlock, sliderRatio);
				
				var sliderSelected = 0;
				
				// Click on the start slider
				sliderBlock.find("#optionSlider-slide1").on("mousedown", function(evt){
					sliderSelected = 1;
				});
				
				// Click on the end slider
				sliderBlock.find("#optionSlider-slide2").on("mousedown", function(evt){
					sliderSelected = 2;
				});
				
				// On mouse up
				$('body').on("mouseup", function(evt){
					sliderSelected = 0;
				});
				
				// Dragging
				$('body').mousemove(function(e){
					
					var elem;
					
					// Check if slider was clicked
					if(sliderSelected != 0){
						
						// Which slider was selected
						if (sliderSelected == 1){ elem = sliderBlock.find("#optionSlider-slide1");}
						if (sliderSelected == 2){ elem = sliderBlock.find("#optionSlider-slide2");}
						
						var move =  e.pageX - sliderBlock.offset().left - (elem.width() / 2);
						
						// Move untill 'move' is smaller than the width of the slider
						if(move > sliderWidth) { move = sliderWidth; }
						if(move < 0 ) { move = 0; }
						
						// Update data-value attribute on the selected slider
						var units =  Math.round(move / sliderRatio) + 1;
						updateSL(elem, units, sliderBlock, sliderRatio);
						
						elem.css("left", move);
					}
					
				});
				
			});
			
		}

	});
});

if (userLang == "de") {

} else {

}

function deleteAllCookies() {
    var cookies = document.cookie.split(";");

    for (var i = 0; i < cookies.length; i++) {
        var cookie = cookies[i];
        var eqPos = cookie.indexOf("=");
        var name = eqPos > -1 ? cookie.substr(0, eqPos) : cookie;
        if (name.indexOf("cookieconsent") !== -1) {
            continue;
        }
        document.cookie = name + "=;expires=Thu, 01 Jan 1970 00:00:00 GMT";
    }
}
/*
window.addEventListener("load", function () {
    window.cookieconsent.initialise({
        "palette": {
            "popup": {
                "background": "#A49169",
                "text": "#ffffff"
            },
            "button": {
                "background": "transparent",
                "text": "#6d6a60",
                "border": "#6d6a60"
            }
        },
        "showLink": false,
        "type": "opt-out",
        "content": {
            "message": "This website uses cookies to ensure you get the best experience on our website.",
            "dismiss": "Hide message",
            "deny": "Do not track"
        },
        onInitialise: function (status) {
            var type = this.options.type;
            var didConsent = this.hasConsented();
            if (type == 'opt-in' && didConsent) {
                // enable cookies
            }
            if (type == 'opt-out' && !didConsent) {
                // disable cookies
                setTimeout(function () {
                    deleteAllCookies();

                }, 1300);
                deleteAllCookies();
            }
        },

        onStatusChange: function (status, chosenBefore) {
            var type = this.options.type;
            var didConsent = this.hasConsented();
            if (type == 'opt-in' && didConsent) {
                // enable cookies
            }
            if (type == 'opt-out' && !didConsent) {
                // disable cookies
                deleteAllCookies();
            }
        },

        onRevokeChoice: function () {
            var type = this.options.type;
            if (type == 'opt-in') {
                // disable cookies
            }
            if (type == 'opt-out') {
                // enable cookies
                deleteAllCookies();
            }
        }
    })
});
*/
/*
window.addEventListener("load", function(){
	window.cookieconsent.initialise({
		"palette": {
			"popup": {
				"background": "#b6b33f",
				"text": "#ffffff"
			},
			"button": {
				"background": "transparent",
				"text": "#6d6a60",
				"border": "#6d6a60"
			}
		},
		"showLink": false,
		"type": "opt-out",
		"content": {
			"message": "This website uses cookies to ensure you get the best experience on our website.",
			"dismiss": "OK",
			"deny": "Refuse"
		}
	})
});
*/
/*Set scrollbar on categories - Added by Rexhep*/
jQuery(function() {
    var getHeight = document.getElementsByClassName('.neighbourhood .dropdown-menu');
    if (getHeight.length > 50) {
        jQuery('.neighbourhood ul.dropdown-menu').css("overflow-y", "scroll");
    }


    jQuery('.neighbourhood ul.dropdown-menu li').click(function(){
    	//jQuery(this).siblings()
    });	
});

(function($) {
    jQuery(window).on("load", function() {

        jQuery(".dropdown-menu.modal-body").mCustomScrollbar({
            setHeight: 150,
            theme: "minimal-dark"
        });
    });
})(jQuery);

(function($) {
    jQuery(window).on("load", function() {

        jQuery(".dropdown-menu-mob.modal-body").mCustomScrollbar({
            setHeight: 150,
            theme: "minimal-dark"
        });
    });
})(jQuery);

(function($) {
    jQuery(window).on("load", function() {

        jQuery(".neighbour-details .description.modal-body").mCustomScrollbar({
            setHeight: 70,
            theme: "minimal-dark"
        });
    });
})(jQuery);