$(document).ready(function(){	
	"use strict";

	/***** Sicky Menubar *****/
	$(window).on('scroll',function() {    
		var scroll = $(window).scrollTop();
		if (scroll < 150) {
			$(".menu-sticky").removeClass("sticky");
		}else{
			$(".menu-sticky").addClass("sticky");
		}
	});

	/***** WOW Js *****/
	new WOW().init();

	/***** Mobile Menu *****/
	jQuery('nav#dropdown').meanmenu({
		meanScreenWidth: "767"
	});

	/***** Date Picker *****/
	$('#datetimepicker').datetimepicker();

	/***** Owl Slider *****/
	$(".slider-wrapper").owlCarousel({
		autoplay:true,
    	autoplayTimeout:5000,
    	animateOut: 'fadeOut',
        animateIn: 'fadeIn',
    	autoplayHoverPause:true,
    	smartSpeed:700,
		loop: true,
		responsiveClass: true,
		items : 1,
		nav : true,
		navText: ['<img src="images/left-arrow.png" alt="" />', '<img src="images/right-arrow.png" alt="" />'],
		margin: 0,
		dots: false,
		responsive: {
			0: {
				items: 1
			},
			576: {
				items: 1
			},
			768: {
				items: 1
			},
			992: {
				items: 1
			}
		}
    });

    $(".slider-wrapper").on('translate.owl.carousel', function() {
        $('.slider-item .slider-heading').removeClass('wow fadeInDown').hide();
        $('.slider-item .slider-para').removeClass('wow fadeInUp').hide();
        $('.slider-item .slider-btn').removeClass('wow fadeInUp').hide();
    });

    $(".slider-wrapper").on('translated.owl.carousel', function() {
        $('.owl-item.active .slider-item .slider-heading').addClass('animated fadeInDown').show();
        $('.owl-item.active .slider-item .slider-para').addClass('animated fadeInUp').show();
        $('.owl-item.active .slider-item .slider-btn').addClass('animated fadeInUp').show();
    });

    $(".owl-doctor").owlCarousel({
		autoplay:true,
    	autoplayTimeout:3000,
    	autoplayHoverPause:true,
    	smartSpeed:700,
		loop: true,
		responsiveClass: true,
		items : 4,
		nav : false,
		margin: 30,
		dots: false,
		responsive: {
			0: {
				items: 1
			},
			576: {
				items: 2
			},
			768: {
				items: 3
			},
			992: {
				items: 4
			}
		}
    });

    $(".owl-testimonial").owlCarousel({
		autoplay:false,
    	autoplayTimeout:3000,
    	autoplayHoverPause:true,
    	smartSpeed:700,
		loop: true,
		responsiveClass: true,
		items : 2,
		nav : false,
		margin: 30,
		dots: true,
		responsive: {
			0: {
				items: 1
			},
			576: {
				items: 1
			},
			768: {
				items: 1
			},
			992: {
				items: 2
			}
		}
    });

    $(".m-slider").owlCarousel({
		autoplay:true,
    	autoplayTimeout:3000,
    	autoplayHoverPause:true,
    	smartSpeed:700,
		loop: true,
		responsiveClass: true,
		items : 1,
		nav : false,
		margin: 0,
		dots: false,
    });

    /***** Isotope Gallery *****/	
	$(window).on('load', function(){
		$(".gallery-items").isotope({
			itemSelector:'.grid-item',
			percentPosition:true,
			masonry:{
				columnWidth:'.grid-item'
			},
		});
		$("ul.gallery-filter > li").on("click",function(){
			$("ul.gallery-filter > li").removeClass("active");
			$(this).addClass("active");
			var selector=$(this).attr("data-filter");
			$(".gallery-items").isotope({
				filter: selector,
				animationOptions: {
					duration: 750,
					easing: 'linear',
					queue: true
				}
			});
			return false;
		});

		//Preloader
		$("#preloader").fadeOut("500");
	});

	/***** Magnific-popup *****/
	$('.grid-item').magnificPopup({
		delegate: '.fc-icon a',
		type: 'image',
		gallery: {
			// options for gallery
			enabled: true
		},
		removalDelay: 300,
		mainClass: 'mfp-fade'
	});

	/***** Counter Up *****/
	$('.counter').counterUp({
		delay: 10,
		time: 2000
	});

	/***** Smooth Scroll *****/
	smoothScroll.init({
		speed: 700
	});

	/***** Syotimer *****/
	$('#timer-wrapper').syotimer({
		year: 2019,
		month: 6,
		day: 1,
		hour: 7,
		minute: 30
	});

	/***** Back To Top *****/
	$(window).scroll(function(){
		if($(this).scrollTop()>500){
		    $(".back-to-top a").fadeIn();
		} else{
		    $(".back-to-top a").fadeOut();
		}
	});
});