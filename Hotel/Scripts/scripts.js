
var SlideShowSpeed = 5050;
var CrossFadeDuration = 20;
var Picture = new Array(); 


Picture[1]  = 'images/changin/1.jpg';
Picture[2]  = 'images/changin/2.jpg';
Picture[3]  = 'images/changin/3.jpg';
Picture[4]  = 'images/changin/4.jpg';
Picture[5]  = 'images/changin/5.jpg';
Picture[6]  = 'images/changin/6.jpg';
Picture[7]  = 'images/changin/7.jpg';





var tss;
var iss;
var jss = 1;
var pss = Picture.length-1;

var preLoad = new Array();
for (iss = 1; iss < pss+1; iss++){
preLoad[iss] = new Image();
preLoad[iss].src = Picture[iss];}

function runSlideShow(){
if (document.all){
document.images.PictureBox.style.filter="blendTrans(duration=4)";
document.images.PictureBox.style.filter="blendTrans(duration=CrossFadeDuration)";
document.images.PictureBox.filters.blendTrans.Apply();}
document.images.PictureBox.src = preLoad[jss].src;
if (document.all) document.images.PictureBox.filters.blendTrans.Play();
jss = jss + 1;
if (jss > (pss)) jss=1;
tss = setTimeout('runSlideShow()', SlideShowSpeed);
}