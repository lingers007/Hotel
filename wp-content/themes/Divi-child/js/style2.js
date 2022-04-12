
var startDateEventForm = null;
var endDateEventForm = null;
var eventFormElement =  null;
var eventFormDataHolder = null;
var dateIndex = 1;

(function($) {

    /*
     *  new_map
     *
     *  This function will render a Google Map onto the selected jQuery element
     *
     *  @type	function
     *  @date	8/11/2013
     *  @since	4.3.0
     *
     *  @param	$el (jQuery element)
     *  @return	n/a
     */

    function new_map( $el ) {

        // var
        var $markers = $el.find('.marker');


        // vars
        var args = {
            zoom		: 16,
            center		: new google.maps.LatLng(0, 0),
            mapTypeId	: google.maps.MapTypeId.ROADMAP
        };


        // create map
        var map = new google.maps.Map( $el[0], args);


        // add a markers reference
        map.markers = [];


        // add markers
        $markers.each(function(){

            add_marker( $(this), map );

        });


        // center map
        center_map( map );


        // return
        return map;

    }

    /*
     *  add_marker
     *
     *  This function will add a marker to the selected Google Map
     *
     *  @type	function
     *  @date	8/11/2013
     *  @since	4.3.0
     *
     *  @param	$marker (jQuery element)
     *  @param	map (Google Map object)
     *  @return	n/a
     */

    function add_marker( $marker, map ) {

        // var
        var latlng = new google.maps.LatLng( $marker.attr('data-lat'), $marker.attr('data-lng') );

        // create marker
        var marker = new google.maps.Marker({
            position	: latlng,
            map			: map
        });

        // add to array
        map.markers.push( marker );

        // if marker contains HTML, add it to an infoWindow
        if( $marker.html() )
        {
            // create info window
            var infowindow = new google.maps.InfoWindow({
                content		: $marker.html()
            });

            // show info window when marker is clicked
            google.maps.event.addListener(marker, 'click', function() {

                infowindow.open( map, marker );

            });
        }

    }

    /*
     *  center_map
     *
     *  This function will center the map, showing all markers attached to this map
     *
     *  @type	function
     *  @date	8/11/2013
     *  @since	4.3.0
     *
     *  @param	map (Google Map object)
     *  @return	n/a
     */

    function center_map( map ) {

        // vars
        var bounds = new google.maps.LatLngBounds();

        // loop through all markers and create bounds
        $.each( map.markers, function( i, marker ){

            var latlng = new google.maps.LatLng( marker.position.lat(), marker.position.lng() );

            bounds.extend( latlng );

        });

        // only 1 marker?
        if( map.markers.length == 1 )
        {
            // set center of map
            map.setCenter( bounds.getCenter() );
            map.setZoom( 16 );
        }
        else
        {
            // fit to bounds
            map.fitBounds( bounds );
        }

    }

    /*
     *  document ready
     *
     *  This function will render each map when the document is ready (page has loaded)
     *
     *  @type	function
     *  @date	8/11/2013
     *  @since	5.0.0
     *
     *  @param	n/a
     *  @return	n/a
     */
// global var
    var map = null;

    $(document).ready(function(){

        $('.acf-map').each(function(){

            // create map
            map = new_map( $(this) );

        });

    });

})(jQuery);

jQuery(document).ready(function($){
    jQuery(".add_to").click(function(event) {
        //alert( "add bookmark" );
        var theid = jQuery(this).attr("dataid");
        jQuery.post(
            ajaxurl,
            {
                'action': 'lancaster_add_to_bookmark',
                'method': 'add',
                'item': theid
            },
            function(response){
                //alert('The server responded: ' + response);
            }
        );
        event.preventDefault();
    });

    jQuery(".delete-from").click(function(event) {
        //alert( "remove bookmark" );
        var theid = jQuery(this).attr("dataid");
        jQuery.post(
            ajaxurl,
            {
                'action': 'lancaster_add_to_bookmark',
                'method': 'remove',
                'item': theid
            },
            function(response){
                location.reload();
                //lert('The server responded: ' + response);
            }
        );
        event.preventDefault();
    });

    jQuery(".topdf").click(function(event) {
        //alert( "add bookmark" );
        var html = $(".page-inner-content").html();


        jQuery.post(
            "https://www.landmarklondon.co.uk/wp-content/themes/Divi-child/functions/generatePDF.php",
            {
                mycontent: html
            },
            function(data) {
                //alert('The server responded: ' + response);
                //$("html").html(data);
                window.location.href = data;
                //window.open(data, "_blank");
            }
        );


        event.preventDefault();
    });

    var currentURL = window.location.pathname;

    var pageName = currentURL.split("https://www.landmarklondon.co.uk/");

    console.log("aaaaaaaaaaaa");
    console.log(currentURL);
    if (currentURL.toLowerCase().indexOf("https://www.landmarklondon.co.uk/location/") > -1 ||
        currentURL.toLowerCase().indexOf("https://www.landmarklondon.co.uk/gallery/") > -1 ||
        currentURL.toLowerCase().indexOf("https://www.landmarklondon.co.uk/offers/") > -1 ||
        currentURL.toLowerCase().indexOf("https://www.landmarklondon.co.uk/spa-at-the-landmark-london/") > -1) {
        jQuery(".back_to_section").show();

        jQuery(".back-section-text").html("BACK");

        jQuery(".back_to_section").click(function () {
            window.history.go(-1);
        });
    }

    if (currentURL.toLowerCase().indexOf("https://www.landmarklondon.co.uk/dining/") >= 0 && pageName[pageName.length-2] != "dining"){
        jQuery(".back_to_section").show();

        jQuery(".back-section-text").html("BACK");

        jQuery(".back_to_section").click(function () {
            window.history.go(-1);
        });
    }

    if (currentURL.toLowerCase().indexOf("https://www.landmarklondon.co.uk/meetings-events/") >= 0 && pageName[pageName.length-2] != "meetings-events"){
        jQuery(".back_to_section").show();

        jQuery(".back-section-text").html("BACK");

        jQuery(".back_to_section").click(function () {
            window.history.go(-1);
        });
    }



    function playVideo(){
        jQuery(".videoplayer")[0].play();

        jQuery(".room-player").hide();
        //jQuery(".room-playbutton").hide();
    }


    jQuery(".videoplayholder, .room-playbutton").click(function () {
        playVideo();
    });






    function opendata(data){
        alert("fff");
        var myWindow = window.open("", "MsgWindow", "width=200,height=100");
        myWindow.document.write(data);
    }



    var createFieldOnDate = function() {
        var startDate = moment(startDateEventForm);
        var endDate = moment(endDateEventForm);


        var differents = endDate.diff(startDate, 'days');

        console.log("tage: " + differents);
        if (typeof  eventFormElement == 'undefined' || eventFormElement == null) {
            jQuery("#roomlistform").css("display", "none");
            jQuery(".elementoccupancy").css("display", "block");
            return;
        }
        var parent = eventFormElement.parent().find(".form-group-more");

        var numberofChilds = parent.children().length;

        if (typeof  eventFormElement != 'undefined' && eventFormElement.parent().parent().length != 0 && differents == 0) {
            //eventFormElement.parent().parent().attr("style", "display:none;")
            jQuery("#roomlistform").css("display", "none");
            jQuery(".elementoccupancy").css("display", "block");

        } else {
            //eventFormElement.parent().parent().attr("style", "display:block;")

            var elementRoom = jQuery("#roomlistform");

            if (typeof elementRoom != "undefined" && elementRoom.length != 0) {
                jQuery("#roomlistform").css("display", "block");

                jQuery(".elementoccupancy").css("display", "none");
            }


        }

        if (numberofChilds != differents) {
            parent.empty();
        }

        var numberofChilds = parent.children().length;

        var calcTotal = function (elementindex) {

            var elementBedroom = jQuery("input[name=eventday" + elementindex + "bedroom]");
            var elementTwobedroom = jQuery("input[name=eventday" + elementindex + "twobedroom]");
            var elementSuites = jQuery("input[name=eventday" + elementindex + "suites]");

            var bedroomNumber = parseInt(elementBedroom.val());
            var twobedroomNumber = parseInt(elementTwobedroom.val());
            var suitesNumber = parseInt(elementSuites.val());


            var calc = (isNaN(bedroomNumber) ? 0 : bedroomNumber) + (isNaN(twobedroomNumber) ? 0 : twobedroomNumber) + (isNaN(suitesNumber) ? 0 : suitesNumber);

            var elementTotal = jQuery("input[name=eventday" + elementindex + "total]");
            elementTotal.val(calc);

            var formdata = JSON.stringify(jQuery("#roomlistform").serializeArray());
            jQuery(eventFormDataHolder).val(formdata);

        };


        if (numberofChilds == 0) {

            for (var i = 0; i <= differents; i++) {
                var newDate = moment(startDate).add(i, 'days');

                if (i == 0) {

                    if (typeof  eventFormElement != 'undefined') {
                        eventFormElement.find('[name="eventday0date"]').val(startDate.format("MM/DD/YYYY")).end();
                        eventFormElement.find('[name="eventday0bedroom"]').attr("index", i + "").change(function () {
                            var index = jQuery(this).attr("index");
                            calcTotal(index);
                        }).end();
                        eventFormElement.find('[name="eventday0twobedroom"]').attr("index", i + "").change(function () {
                            var index = jQuery(this).attr("index");
                            calcTotal(index);
                        }).end();
                        eventFormElement.find('[name="eventday0suites"]').attr("index", i + "").change(function () {
                            var index = jQuery(this).attr("index");
                            calcTotal(index);
                        }).end();
                        eventFormElement.find('[name="eventday0total"]').attr("index", i + "").end();
                    }


                } else {

                    if (typeof  eventFormElement != 'undefined') {


                        var newsElement = eventFormElement.clone();


                        newsElement.find('[name="eventday0date"]').attr('name', 'eventday' + i + 'date').attr("index", i + "").val(newDate.format("MM/DD/YYYY")).end();
                        newsElement.find('[name="eventday0bedroom"]').attr('name', 'eventday' + i + 'bedroom').attr("index", i + "").change(function () {
                            var index = jQuery(this).attr("index");
                            calcTotal(index);
                        }).end();
                        newsElement.find('[name="eventday0twobedroom"]').attr('name', 'eventday' + i + 'twobedroom').attr("index", i + "").change(function () {
                            var index = jQuery(this).attr("index");
                            calcTotal(index);
                        }).end();
                        newsElement.find('[name="eventday0suites"]').attr('name', 'eventday' + i + 'suites').attr("index", i + "").change(function () {
                            var index = jQuery(this).attr("index");
                            calcTotal(index);
                        }).end();
                        newsElement.find('[name="eventday0total"]').attr('name', 'eventday' + i + 'total').attr("index", i + "").end();


                        //eventFormElement.insertAfter(newsElement);
                        parent.append(newsElement);

                    }
                }
            }
        }
    };

    var calcTotal = function (elementindex) {

        var elementBedroom = jQuery("input[name=eventday" + elementindex + "bedroom]");
        var elementTwobedroom = jQuery("input[name=eventday" + elementindex + "twobedroom]");
        var elementSuites = jQuery("input[name=eventday" + elementindex + "suites]");

        var bedroomNumber = parseInt(elementBedroom.val());
        var twobedroomNumber = parseInt(elementTwobedroom.val());
        var suitesNumber = parseInt(elementSuites.val());


        var calc = (isNaN(bedroomNumber) ? 0 : bedroomNumber) + (isNaN(twobedroomNumber) ? 0 : twobedroomNumber) + (isNaN(suitesNumber) ? 0 : suitesNumber);

        var elementTotal = jQuery("input[name=eventday" + elementindex + "total]");
        elementTotal.val(calc);

        var formdata = JSON.stringify(jQuery("#roomlistform").serializeArray());
        jQuery(eventFormDataHolder).val(formdata);

    };


    var addfields = function () {


        if (typeof  eventFormElement != 'undefined') {

            var parent = eventFormElement.parent().find(".form-group-more");


            var i =  dateIndex;


            var newsElement = eventFormElement.clone();

            newsElement.addClass("dateitem"+i);

            var datefield = newsElement.find('[name="eventday0date"]');
            datefield.attr('name', 'eventday' + i + 'date').attr("index", i + "").val("").end();

            newsElement.find('[name="eventday0bedroom"]').attr('name', 'eventday' + i + 'bedroom').attr("index", i + "").val("").change(function () {
                var index = jQuery(this).attr("index");
                calcTotal(index);
            }).end();
            newsElement.find('[name="eventday0twobedroom"]').attr('name', 'eventday' + i + 'twobedroom').attr("index", i + "").val("").change(function () {
                var index = jQuery(this).attr("index");
                calcTotal(index);
            }).end();
            newsElement.find('[name="eventday0suites"]').attr('name', 'eventday' + i + 'suites').attr("index", i + "").val("").change(function () {
                var index = jQuery(this).attr("index");
                calcTotal(index);
            }).end();
            newsElement.find('[name="eventday0total"]').attr('name', 'eventday' + i + 'total').attr("index", i + "").val("").end();

            newsElement.find(".addButton").removeClass("addButton").addClass("removeButton");
            newsElement.find(".removeButton i").removeClass("fa-plus").addClass("fa-minus").end();

            newsElement.find(".removeButton").click(function () {
                removelement(i);
            }).end();

            //eventFormElement.insertAfter(newsElement);
            parent.append(newsElement);

            var picker = new Pikaday({ field: datefield[0], format: 'MM/DD/YYYY' });


            dateIndex++;

        }


    };

    var removelement = function(index) {
        jQuery(".dateitem"+index).remove();
    };

    var addAddFunction = function(){

        if (typeof  eventFormElement != 'undefined') {

            var datefield = eventFormElement.find('[name="eventday0date"]');

            datefield.val("").end();
            eventFormElement.find('[name="eventday0bedroom"]').attr("index", 0 + "").change(function () {
                var index = jQuery(this).attr("index");
                calcTotal(index);
            }).end();
            eventFormElement.find('[name="eventday0twobedroom"]').attr("index", 0 + "").change(function () {
                var index = jQuery(this).attr("index");
                calcTotal(index);
            }).end();
            eventFormElement.find('[name="eventday0suites"]').attr("index", 0 + "").change(function () {
                var index = jQuery(this).attr("index");
                calcTotal(index);
            }).end();
            eventFormElement.find('[name="eventday0total"]').attr("index", 0 + "").end();

            var picker = new Pikaday({ field: datefield[0], format: 'MM/DD/YYYY' });
        }

        jQuery(".addButton").click(function () {

            addfields();


        });


    };

    var changeEventStartDate = function(element) {
        console.log("change start");
        startDateEventForm = element.value;
        createFieldOnDate();
    };

    var changeEventEndDate = function(element) {
        console.log("change end");
        endDateEventForm = element.value;
        createFieldOnDate();
    };

    if(typeof Marionette != "undefined") {
        // Create a new object for custom validation of a custom field.
        var myFormsEventController = Marionette.Object.extend({

            initialize: function () {

                // Listen to the render:view event for a field type. Example: Textbox field.
                this.listenTo(nfRadio.channel('date'), 'render:view', this.renderView);
                this.listenTo(nfRadio.channel('html'), 'render:view', this.renderView);
                this.listenTo(nfRadio.channel('checkbox'), 'render:view', this.renderView);
                this.listenTo(nfRadio.channel('textarea'), 'render:view', this.renderView);
                this.listenTo(nfRadio.channel('textbox'), 'render:view', this.renderView);
            },

            renderView: function (view) {

                // Check if this is the right field. Example check for field key.
                //if ( 'example_key' != view.model.get( 'key' ) ) return false;

                var el = jQuery(view.el).find('#nf-field-34');
                if (typeof el != 'undefined' && el.length != 0) {
                    el.on('change', function () {
                        changeEventStartDate(this);
                    });
                }

                var el1 = jQuery(view.el).find('#nf-field-35');
                if (typeof el1 != 'undefined' && el1.length != 0) {
                    el1.on('change', function () {
                        changeEventEndDate(this);
                    });
                }

                var el2 = jQuery(view.el).find('.form-group');
                if (typeof el2 != 'undefined' && el2.length != 0) {
                    eventFormElement = el2;
                }

                var el3 = jQuery(view.el).find('#nf-field-48');
                if (typeof el3 != 'undefined' && el3.length != 0) {

                    el3.on("change", function () {
                        setTimeout(function () {
                            createFieldOnDate();
                        }, 200);
                    });

                    el3.wrap("<label class='cta check-48'></label>");

                    jQuery( "<span>Enter Your Accommodation requirements</span>" ).insertAfter( el3 );
                }

                var el3a = jQuery(view.el).find('#nf-field-60');
                if (typeof el3a != 'undefined' && el3a.length != 0) {

                    el3a.on("change", function () {
                        setTimeout(function () {
                            addAddFunction();
                        }, 200);
                    });



                    el3a.wrap("<label class='cta check-60'></label>");

                    jQuery( "<span>Add accommodation requirements (optional)</span>" ).insertAfter( el3a );
                }

                var el3b = jQuery(view.el).find('#nf-field-89');
                if (typeof el3b != 'undefined' && el3b.length != 0) {

                    el3b.wrap("<label class='cta check-89'></label>");

                    jQuery( "<span>Add A/V and room configurations (optional)</span>" ).insertAfter( el3b );
                }

                var el4 = jQuery(view.el).find('#nf-field-49');
                if (typeof el4 != 'undefined' && el4.length != 0) {
                    eventFormDataHolder = el4[0];
                }

                var el4 = jQuery(view.el).find('#nf-field-70');
                if (typeof el4 != 'undefined' && el4.length != 0) {
                    eventFormDataHolder = el4[0];
                }

                var contactFormEmailTo = jQuery(view.el).find('#nf-field-141');
            if (typeof contactFormEmailTo != 'undefined' && contactFormEmailTo.length != 0 && typeof contactFormEmail != 'undefined') {
                    jQuery(contactFormEmailTo[0]).val(contactFormEmail);
                }



            }


        });

        // Create a new object for custom validation of a custom field.
        var myFormsSubmitEventController = Marionette.Object.extend({

            initialize: function () {

                this.listenTo(nfRadio.channel("forms"), "submit:response", this.actionSubmit);
                this.listenTo(nfRadio.channel("forms"), "submit:failed", this.actionSubmitFailure);


            },

            actionSubmitFailure : function(e){
                //console.log("get fail");
                var container = $("html,body");
                var scrollTo = $($('.nf-error-msg')[0]);

                container.animate({scrollTop: scrollTo.offset().top - 300, scrollLeft: 0},300);

            },

            actionSubmit: function (e) {
                //console.log("get data");

                var parentid = 0;

                if (typeof e != 'undefined' &&
                    typeof  e.data != 'undefined' &&
                    typeof  e.data != 'undefined' &&
                    typeof  e.data.actions != 'undefined' &&
                    typeof  e.data.actions.save != 'undefined' &&
                    typeof  e.data.actions.save.sub_id != 'undefined') {

                    parentid = e.data.actions.save.sub_id;

                }
                var formdata = JSON.stringify(jQuery("#roomlistform").serializeArray());


                var data = {
                    'action': 'action_add_eventdata',
                    'parentid': parentid,
                    'formdata': formdata
                };

                jQuery.post(ajaxurl, data, function (response) {
                    //alert('Got this from the server: ' + response);
                });
            }
        });



        // Instantiate our custom field's controller, defined above.
        new myFormsEventController();

        new myFormsSubmitEventController();
    }



});