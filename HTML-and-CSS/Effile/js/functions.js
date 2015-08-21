$("html").niceScroll();

// <!-- Preloader -->		
//<![CDATA[
$(window).load(function() { // makes sure the whole site is loaded
	$('#status').fadeOut(); // will first fade out the loading animation
	$('#preloader').delay(350).fadeOut('slow'); // will fade out the white DIV that covers the website.
	$('body').delay(350).css({'overflow':'visible'});
});
//]]>
/*============================================
	*	Smooth Scrolling
*=============================================*/

	$('nav a[href*=#]:not([href=#])').click(function() {
		if (location.pathname.replace(/^\//, '') === this.pathname.replace(/^\//, '') && location.hostname === this.hostname) {

			var target = $(this.hash);
			target = target.length ? target : $('[name=' + this.hash.slice(1) + ']');
			if (target.length) {
				$('html,body').animate({
					scrollTop: target.offset().top
				}, 2000);
				return false;
			}
		}
	});

	$(document).ready(function() {
		
		$("#owl-carousel").owlCarousel({
			
			slideSpeed : 300,
			paginationSpeed : 400,
			singleItem:true				 
		});
		
	});
// var t = $('#services').offset().top - 100;
// var t1 = $('#about').offset().top - 100;

// $(document).scroll(function(){
//     if($(this).scrollTop() > t1) {   
//         $('header').css({"background-color":"blue"});
//     } else if($(this).scrollTop() > t) {   
//         $('header').css({"background-color":"green"});
//     } else {
//         $('header').css({"background-color":"#520833"});
//     }
// });