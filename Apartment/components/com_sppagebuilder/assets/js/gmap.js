function initSPPageBuilderGMap(t){var e={_keyStr:"ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789+/=",decode:function(t){var a,r,o,n,d,i,s="",c=0;for(t=t.replace(/[^A-Za-z0-9+/=]/g,"");c<t.length;)a=this._keyStr.indexOf(t.charAt(c++))<<2|(n=this._keyStr.indexOf(t.charAt(c++)))>>4,r=(15&n)<<4|(d=this._keyStr.indexOf(t.charAt(c++)))>>2,o=(3&d)<<6|(i=this._keyStr.indexOf(t.charAt(c++))),s+=String.fromCharCode(a),64!=d&&(s+=String.fromCharCode(r)),64!=i&&(s+=String.fromCharCode(o));return s=e._utf8_decode(s)},_utf8_decode:function(t){for(var e="",a=0,r=c1=c2=0;a<t.length;)(r=t.charCodeAt(a))<128?(e+=String.fromCharCode(r),a++):r>191&&r<224?(c2=t.charCodeAt(a+1),e+=String.fromCharCode((31&r)<<6|63&c2),a+=2):(c2=t.charCodeAt(a+1),c3=t.charCodeAt(a+2),e+=String.fromCharCode((15&r)<<12|(63&c2)<<6|63&c3),a+=3);return e}};jQuery(".sppb-addon-gmap-canvas",t).each(function(a){var r=jQuery(this).attr("id"),o=Number(jQuery(this).attr("data-mapzoom")),n=jQuery(this).attr("data-infowindow"),d="true"===jQuery(this).attr("data-mousescroll"),i=jQuery(this).attr("data-maptype"),s={lat:Number(jQuery(this).attr("data-lat")),lng:Number(jQuery(this).attr("data-lng"))},c=new google.maps.Map(t.getElementById(r),{center:new google.maps.LatLng(s),zoom:o,scrollwheel:d,disableDefaultUI:!0});if(void 0!==jQuery(this).attr("data-location")){for(var u=jQuery(this).attr("data-lat"),g=jQuery(this).attr("data-lng"),h=e.decode(n),l=JSON.stringify([{address:h,latitude:u,longitude:g}]),f=e.decode(jQuery(this).attr("data-location")),p=JSON.parse(l),m=JSON.parse(f),y=p.concat(m),C=[],S=0;S<y.length;S++){var j=y[S];C.push([j.address]+";"+[j.latitude]+";"+[j.longitude])}for(var Q=[],v=0;v<C.length;v++)Q.push(C[v].split(";"));var w,A=Q;n=new google.maps.InfoWindow;for(S=0;S<A.length;S++)w=new google.maps.Marker({position:new google.maps.LatLng(A[S][1],A[S][2]),map:c}),google.maps.event.addListener(w,"click",function(t,e){return function(){A[e][0]&&(n.setContent(A[e][0]),n.open(c,t))}}(w,S))}c.setMapTypeId(google.maps.MapTypeId[i])})}jQuery(window).on("load",function(){initSPPageBuilderGMap(document)});