//jQuery(document).ready(function () {
//    var height = $(window).height();
//    $('section').css('height', height)
//});

jQuery(document).ready(function () {
    $('section').css('height', screen.height);
    $(window).resize(function()
    {
        $('#menu-xl').css(
        {
            top: ($(window).height() - $('#menu-xl').outerHeight()) / 100
        });
    });

    // call `resize` to center elements
    $(window).resize();
});