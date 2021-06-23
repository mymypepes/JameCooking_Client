/*<script type='text/javascript' src='https://healey.sculptureqode.com/wp-content/plugins/super-simple-recipes/assets/js/super-simple-recipes.js?ver=5.4.6'></script>*/

jQuery(document).ready(function () {

	// Hover events for star ratings
	jQuery('.star').hover(
		function () {
			jQuery(this).prevAll('.star').andSelf().addClass('hover');
			jQuery(this).nextAll('.star').removeClass('hover');
		},
		function () {
			jQuery(this).prevAll().andSelf().removeClass('hover');
		}
	);

	// Star ajax 
	jQuery('.recipe-rating .star-rating .star').click(function () {

		// Get the clicked star (1-5)
		var star_rating = jQuery(this).index();
		var ajax_admin_url = ssr_ajax_var.url;
		var recipe_id = ssr_ajax_var.recipe_id;
		var ajax_nonce = ssr_ajax_var.nonce;

		jQuery.ajax({

			type: "post",
			url: ajax_admin_url,
			data: {
				action: 'ssr_save_recipe_rating',
				recipe_id: recipe_id,
				star_rating: star_rating,
				nonce: ajax_nonce
			},
			success: function (data) {
				jQuery('#recipe-' + recipe_id).find('.recipe-rating').addClass('voted').html(data);
			},
			error: function (errorThrown) {
				console.log('Error');
			}

		});

		return false;

	});

});

jQuery(document).ready(function () {

	jQuery('.recipe-print').click(function () {
		jQuery(this).closest('.recipe').printThis();
	});

});

jQuery(document).on('hover', '.recipe', function () {

	jQuery('.tooltip').tooltipster({
		theme: 'tooltipster-shadow',
		animation: 'grow',
		animationDuration: 100
	});

});
