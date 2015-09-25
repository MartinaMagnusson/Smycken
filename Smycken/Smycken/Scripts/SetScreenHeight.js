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

    var $root = $('html, body');
    $('a').click(function () {
        var href = $.attr(this, 'href');
        $root.animate({
            scrollTop: $(href).offset().top
        }, 1000, function () {
            window.location.hash = href;
        });
        return false;
    });
});

