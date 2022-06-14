////$(".carousel").owlCarousel({
////    margin: 20,
////    loop: true,
////    autoplay: true,
////    autoplayTimeout: 3000,
////    autoplayHoverPause: true,
////    responsive: {
////        0: {
////            items: 1,
////            nav: false
////        },
////        600: {
////            items: 2,
////            nav: false
////        },
////        1000: {
////            items: 4,
////            nav: false
////        }
////    }
////});

$(document).ready(function () {
    $(".owl-carousel").owlCarousel();
});

$('.owl-carousel').owlCarousel({
    loop: true,
    autoplay: true,
    autoplayTimeout: 3000,
    autoplayHoverPause: true,
    margin: 10,
    nav: true,
     navText: ["<div class='nav-btn prev-slide' style='color:#ffffff'>Anterior</div>", "<div class='nav-btn next-slide'style='color:#ffffff'>Siguiente</div>"],
   /* navText: ["<i class='fa fa-chevron-left' style='font-size:2rem;color:#ffffff'></i>", "<i class='fa fa-chevron-right'style='font-size:2rem;color:#ffffff'></i>"],*/
    responsive: {
        0: {
            items: 1
        },
        600: {
            items: 2
        },
        1000: {
            items: 4
        }
    }
})