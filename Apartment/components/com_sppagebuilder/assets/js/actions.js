jQuery(function(e){function a(a,t){0===e(".sp-pagebuilder-notifications").length&&e('<div class="sp-pagebuilder-notifications"></div>').appendTo("body"),e('<div class="notify-'+t+'">'+a+"</div>").css({opacity:0,"margin-top":-15,"margin-bottom":0}).animate({opacity:1,"margin-top":0,"margin-bottom":15},200).prependTo(".sp-pagebuilder-notifications"),e(".sp-pagebuilder-notifications").find(">div").each(function(){var a=e(this);setTimeout(function(){a.animate({opacity:0,"margin-top":-15,"margin-bottom":0},200,function(){a.remove()})},3e3)})}e(".sp-pagebuilder-form-group-toggler").find(">span").on("click",function(a){a.preventDefault(),e(this).parent().hasClass("active")?e(this).parent().removeClass("active"):(e(".sp-pagebuilder-form-group-toggler").removeClass("active"),e(this).parent().addClass("active"))});window.onbeforeunload=function(e){if(void 0!==window.warningAtReload&&1==window.warningAtReload){var a="Do you want to lose unsaved data?";return(e=e||window.event)&&(e.returnValue=a),a}return null},e(document).on("click","#btn-save-page",function(a){a.preventDefault();var t=e(this),i=e.parseJSON(e("#jform_sptext").val());i.filter(function(e){return e.columns.filter(function(e){return e.addons.filter(function(e){return"sp_row"===e.type||"inner_row"===e.type?e.columns.filter(function(e){return e.addons.filter(function(e){return null!=typeof e.htmlContent&&delete e.htmlContent,null!=typeof e.assets&&delete e.assets,e})}):(null!=typeof e.htmlContent&&delete e.htmlContent,null!=typeof e.assets&&delete e.assets,e)})})}),e("#jform_sptext").val(JSON.stringify(i));var n=e("#adminForm"),o=e("#sp-page-builder").data("pageid");e.ajax({type:"POST",url:pagebuilder_base+"index.php?option=com_sppagebuilder&task=page.apply&pageId="+o,data:n.serialize(),beforeSend:function(){t.find(".fa-save").removeClass("fa-save").addClass("fa-spinner fa-spin")},success:function(i){try{var n=e.parseJSON(i);t.find(".fa").removeClass("fa-spinner fa-spin").addClass("fa-save"),0===e(".sp-pagebuilder-notifications").length&&e('<div class="sp-pagebuilder-notifications"></div>').appendTo("body");var o="success";if(!n.status)o="error";if(n.title&&e("#jform_title").val(n.title),n.id&&e("#jform_id").val(n.id),e('<div class="notify-'+o+'">'+n.message+"</div>").css({opacity:0,"margin-top":-15,"margin-bottom":0}).animate({opacity:1,"margin-top":0,"margin-bottom":15},200).prependTo(".sp-pagebuilder-notifications"),void 0!==window.warningAtReload&&1==window.warningAtReload&&(window.warningAtReload=!1),e(".sp-pagebuilder-notifications").find(">div").each(function(){var a=e(this);setTimeout(function(){a.animate({opacity:0,"margin-top":-15,"margin-bottom":0},200,function(){a.remove()})},3e3)}),!n.status)return;window.history.replaceState("","",n.redirect),n.preview_url&&0===e("#btn-page-preview").length&&e("#btn-page-options").parent().before('<div class="sp-pagebuilder-btn-group"><a id="btn-page-preview" target="_blank" href="'+n.preview_url+'" class="sp-pagebuilder-btn sp-pagebuilder-btn-primary"><i class="fa fa-eye"></i> Preview</a></div>'),"btn-save-new"==a.target.id&&(window.location.href="index.php?option=com_sppagebuilder&view=page&layout=edit"),"btn-save-close"==a.target.id&&(window.location.href="index.php?option=com_sppagebuilder&view=pages")}catch(e){window.location.href="index.php?option=com_sppagebuilder&view=pages"}}})}),e(".page-builder-form-menu").on("submit",function(t){t.preventDefault();var i=e(this).serialize();e.ajax({type:"POST",url:pagebuilder_base+"index.php?option=com_sppagebuilder&task=page.addToMenu&pageId="+e("#sp-page-builder").data("pageid"),dataType:"json",cache:!1,data:i,beforeSend:function(){e("#sp-pagebuilder-btn-add-to-menu").find(".fa").removeClass("fa-save").addClass("fa-spinner fa-spin")},success:function(t){e("#sp-pagebuilder-btn-add-to-menu").find(".fa").removeClass("fa-spinner fa-spin").addClass("fa-save"),t.status?(a(t.success,"success"),window.location.href=t.redirect):a(t.error,"error")}.bind(this)})}),e("#jform_menutype").change(function(){var a=e(this).val();e.ajax({url:pagebuilder_base+"index.php?option=com_sppagebuilder&task=page.getMenuParentItem&menutype="+a,dataType:"json"}).done(function(a){e("#jform_menuparent_id option").each(function(){"1"!=e(this).val()&&e(this).remove()}),e.each(a,function(a,t){var i=e("<option>");i.text(t.title).val(t.id),e("#jform_menuparent_id").append(i)}),e("#jform_menuparent_id").trigger("liszt:updated")})})});