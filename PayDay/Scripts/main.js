$(document).ready(function () {
    //Scroll button
    $(window).scroll(function () {

        if ($(this).scrollTop() != 0) {
            $(".to-top").fadeIn();
        } else {
            $(".to-top").fadeOut();
        }
    });

    $(".to-top").click(function () {
        $('body,html').animate({ scrollTop: 0 }, 800);
    });
    /////////
//MOBILE-menu button
    $(".fa-bars").click(function () {
        $(".header .nav-menu").toggle(300);
    });
    ///
    function() {
        lmpost.collect("interaction", "focus", $(this).attr("name"))
    }
});