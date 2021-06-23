/*<script type='text/javascript' src='https://healey.sculptureqode.com/wp-content/themes/healey/js/scripts.2015js?ver=20151215'></script>*/

(function ($) {
	'use strict';

	$(document).ready(function () {

		// Mobile Menu
		$(".mobile-navigation li").has("ul").prepend('<span class="sub-menu-toggle"><i class="fa fa-angle-down"></i></span>');
		$('.sub-menu-toggle').click(function () {
			$(this).find('i').toggleClass(' fa-angle-down');
			$(this).find('i').addClass(' fa-angle-up');
			$(this).parent().find('ul:first').slideToggle(300);
			return false;
		});

		// Mobile Menu Toggle 
		$('#toggle-menu').click(function () {
			$(this).toggleClass('active');
			$('.mobile-navigation').slideToggle();
			return false;
		});

		// Toggle Follow
		$('.toggle-follow').click(function () {
			$(this).toggleClass('active');
			$('.follow').toggleClass('active');
		});

		// Toggle Search
		$('.toggle-search').click(function () {
			$(this).toggleClass('active');
			$('.search-form').toggleClass('active');
		});

		$('.content-boxes').slick({
			slidesToShow: 4,
			slidesToScroll: 4,
			infinite: true,
			arrows: false,
			dots: true,
			prevArrow: '<i class="fa fa-angle-left slick-prev" aria-hidden="true"></i>',
			nextArrow: '<i class="fa fa-angle-right slick-next" aria-hidden="true"></i>',
			responsive: [
				{
					breakpoint: 960,
					settings: {
						slidesToShow: 3,
						slidesToScroll: 3,
					}
				},
				{
					breakpoint: 768,
					settings: {
						slidesToShow: 2,
						slidesToScroll: 2
					}
				},
				{
					breakpoint: 520,
					settings: {
						slidesToShow: 1,
						slidesToScroll: 1
					}
				}
			]
		});


	});

}(jQuery));
