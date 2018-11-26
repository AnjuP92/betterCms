/*$(window).swipe({
	swipeLeft: function(event, direction, distance, duration, fingerCount) {
		if(fingerCount == 1)
		{
			var sidebar = $('[data-sidebar]');
			var overlay = $('[data-sidebar-overlay]');
			sidebar.css('margin-left', sidebar.width() * -1 + 'px');
			overlay.fadeTo('500', 0, function() {
				overlay.hide();
			});  
		}
	},
	swipeRight: function(event, direction, distance, duration, fingerCount) {
		if(fingerCount == 1)
		{
			var sidebar = $('[data-sidebar]');
			var overlay = $('[data-sidebar-overlay]');
			sidebar.css('margin-left', '0');
			overlay.show(0, function() {
				overlay.fadeTo('500', 0.5);
			});
		}
	},
	preventDefaultEvents: false,
	fingers:'all'
  });*/
 $(document).ready(function(){
 $("#mainContainer").on("swipeleft",function(){
	if($('#mobile-menu').css('display') == 'block')
	 {
		var sidebar = $('[data-sidebar]');
			var overlay = $('[data-sidebar-overlay]');
			sidebar.css('margin-left', sidebar.width() * -1 + 'px');
			overlay.fadeTo('500', 0, function() {
				overlay.hide();
			});  
	 }
  
});
 $("#mainContainer").on("swiperight",function(){
	if($('#mobile-menu').css('display') == 'block')
	 {
		var sidebar = $('[data-sidebar]');
			var overlay = $('[data-sidebar-overlay]');
			sidebar.css('margin-left', '0');
			overlay.show(0, function() {
				overlay.fadeTo('500', 0.5);
			});
	 }
  
});

 });
var didScroll;
var lastScrollTop = 0;
var delta = 5;
var navbarHeight = $('.mobile-header').outerHeight();

$(window).scroll(function(event){
	didScroll = true;
});

setInterval(function() {
	if (didScroll) {
		hasScrolled();
		didScroll = false;
	}
}, 0);

function hasScrolled() {
	var st = $(this).scrollTop();
	
	// Make sure they scroll more than delta
	if(Math.abs(lastScrollTop - st) <= delta)
		return;
	
	// If they scrolled down and are past the navbar, add class .nav-up.
	// This is necessary so you never see what is "behind" the navbar.
	if (st > lastScrollTop && st > navbarHeight){
		// Scroll Down
		//alert("Down");
		$('.mobile-header').removeClass('nav-down').addClass('nav-up');
	} else {
		// Scroll Up
		//alert("Up");
		if(st + $(window).height() < $(document).height()) {
			$('.mobile-header').removeClass('nav-up').addClass('nav-down');
			//setTimeout(function() { $('.header').removeClass('nav-down').addClass('nav-up'); }, 2000);
		}
	}
	
	lastScrollTop = st;
}
$(function() {
	//setTimeout(function() { $('.header').removeClass('nav-down').addClass('nav-up'); }, 2000);
});