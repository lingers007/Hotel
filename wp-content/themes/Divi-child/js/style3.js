jQuery(document).ready(function($){
	$(".book-button").click(function(e) {
		e.preventDefault();
		$(".booking-widget").toggle();
	});
	$("#booking-close").click(function(e) {
		$(".booking-widget").hide();
	});
	$(".book-direct").click(function(e) {
		e.preventDefault();
		$(".wrapper-popup").fadeIn();
	});
	$("#popup-close").click(function(e) {
		$(".wrapper-popup").fadeOut();
	});
	$(".wrapper-popup").click(function(e) {
		if (e.target == $(".wrapper-popup")[0]) {
			$(".wrapper-popup").fadeOut();
		}
	});
	
	
	$("#check-avail").click(function(e) {
    var f = document.getElementById('booking-form');

    var start_date_value = $("#booking-arrival").datepicker("getDate");
    var end_date_value = $("#booking-departure").datepicker("getDate");

    var start_date = moment(start_date_value, "DD MMMM, YYYY");
    var end_date = moment(end_date_value, "DD MMMM, YYYY");

    var difference = end_date.diff(start_date, 'days')


    f.f.value = start_date.format("YYYY-MM-DD");
    f.t.value = end_date.format("YYYY-MM-DD");

    f.a.value = $('#number-adults').val();
		f.c.value = $('#number-children').val();
		f.rac.value = $('#promo-code').val();
		var linkers = [];
		var gaKey = '';
		var gaValue = '';
		try {
			trackers = ga.getAll();
			if(trackers.length) {
				linkers = trackers[0].get('linkerParam').split('&');
				linkers.forEach(function(param) {
				  gaKey = param.split('=')[0];
			    gaValue = param.split('=')[1];
					if(f[gaKey]) {
	          f[gaKey].value = gaValue;
	        }
        });
			}
		} catch (error) {
    	console.log("Cross domain tracking error");
    	console.log(error);
    }
    f.submit();
	});
	
	
	var datenow = new Date();
	var datethen = '+1';

	$( "#booking-arrival" ).datepicker({
		dateFormat:'dd.mm.yy',
		// set Minimum date on the second date field
		onSelect: function(date){
			var dateMin = $("#booking-arrival").datepicker("getDate");
			dateMin.setDate(dateMin.getDate()+1);
			$("#booking-departure").datepicker("option", "minDate", dateMin).datepicker('hide');
		},
		minDate: datenow,
		nextText: '>>',
		prevText: '<<'
	});

	$( "#booking-departure" ).datepicker({
		dateFormat: 'dd.mm.yy',
		// set Minimum date on the second date field
		onSelect: function(date){
			/*
			var dateMax = $("#booking-departure").datepicker("getDate");
			$("#booking-arrival").datepicker("option", "maxDate", dateMax).datepicker('hide');
			*/
		},
		minDate: datenow,
		nextText: '>>',
		prevText: '<<'
	});

	$( "#booking-arrival" ).datepicker( "setDate", datenow).datepicker('hide');
	$( "#booking-departure" ).datepicker( "setDate", datethen).datepicker('hide');
    $('#ui-datepicker-div').css('display','none');  

	$('#number-adults').select2({minimumResultsForSearch: -1});
	$('#number-children').select2({minimumResultsForSearch: -1});
	$('#number-rooms').select2({minimumResultsForSearch: -1});
	
	
	
	/* replace image in gallery with video.. */
	jQuery(".main-gallery .MST_custom_gallery .figure_set:first-child div:nth-child(3)").html('<video autoplay loop style="width:100%;height:100%;background:#000" controls=""><source src="/wp-content/themes/Divi-child/assets/hotel-video.mp4" type="video/mp4">Your browser does not support HTML5 video.</video>');
	
	/* hack for CTA on Social Occasions */
	/*
	jQuery("#post-1696 .card-item img, #post-1696 .card-item a").click(function(e) {

		window.location = '/enquire-now/';
		e.preventDefault();
	});
	*/
	jQuery(".start-button .cta").click(function(e) {
		e.preventDefault();
		jQuery(".followus-window").slideToggle();
	});

	jQuery("#followus-close").click(function(e) {
		jQuery(".followus-window").slideUp();
	});

	jQuery("#menu-item-5030").addClass("show-1024");

});