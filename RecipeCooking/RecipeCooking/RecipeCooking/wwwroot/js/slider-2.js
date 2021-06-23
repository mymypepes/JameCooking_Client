/*<script type='text/javascript' src='https://healey.sculptureqode.com/wp-content/themes/healey/js/slider-2.js?ver=20151215'></script>*/

(function ($) {

	'use strict';

	$(document).ready(function () {

		// Featured Post Slider
		$('.featured-post-slider').slick({
			slidesToShow: 2,
			slidesToScroll: 1,
			infinite: true,
			arrows: true,
			centerPadding: 0,
			prevArrow: '<i class="fa fa-angle-left slick-prev" aria-hidden="true"></i>',
			nextArrow: '<i class="fa fa-angle-right slick-next" aria-hidden="true"></i>',
			responsive: [
				{
					breakpoint: 768,
					settings: {
						slidesToShow: 1,
						slidesToScroll: 1
					}
				}
			]
		});

	});

}(jQuery));		