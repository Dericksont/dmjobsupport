/***********************************************
Capture clicks
***********************************************/


$(function() {
	$('.tile').hover(function() {
		if ($(this).find('.tileMetrics').css('display')=='none')
		{
			$(this).find('.tileCount').hide();
			$(this).find('.tileMetrics').fadeIn(500);
		} else 
		{
			$(this).find('.tileMetrics').hide();
			$(this).find('.tileCount').fadeIn(500);
		}
	});
});

$(function() {
	$('.tile').click(function() {
		window.location.href='distiTable.html';
	});
});
































