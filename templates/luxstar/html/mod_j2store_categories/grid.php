<?php
defined( '_JEXEC' ) or die( 'Restricted access' );
?>

<ul class="j2store-categories-module<?php echo $moduleclass_sfx; ?>">
<?php require JModuleHelper::getLayoutPath('mod_j2store_categories', $params->get('layout', 'default') . '_items'); ?>
</ul>

