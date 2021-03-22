// $(document).ready(function() {
//     $('#autoWidth').lightSlider({
//         item:5,
//         loop:true,
//         slideMove:1,
//         easing: 'cubic-bezier(0.25, 0, 0.25, 1)',
//         speed:600,
//         responsive : [
//             {
//                 breakpoint:1600,
//                 settings: {
//                     item:5,
//                     slideMove:1,
//                     slideMargin:6,
//                   }
//             },
//             {
//                 breakpoint:1024,
//                 settings: {
//                     item:3,
//                     slideMove:1,
//                     slideMargin:6,
//                   }
//             },
//             {
//                 breakpoint:739,
//                 settings: {
//                     item:2,
//                     slideMove:1
//                   }
//             }
//         ]
//     });  
//   });

$(document).ready(function() {
  
    $(".movie-wrapper").slick({
      slidesToShow: 5,
      slidesToScroll: 1,
      loop: true,
      autoplay: false,
      autoplaySpeed: 2000,
      nextArrow: $(".next"),
      prevArrow: $(".prev"),
      responsive: [
        {
          breakpoint: 1024,
          settings: {
            slidesToShow: 3,
            slidesToScroll: 3,
            infinite: true,
            dots: true
          }
        },
        {
          breakpoint: 740,
          settings: {
            slidesToShow: 2,
            slidesToScroll: 2
          }
        },
        // {
        //   breakpoint: 480,
        //   settings: {
        //     slidesToShow: 1,
        //     slidesToScroll: 1
        //   }
        // }
        // You can unslick at a given breakpoint now by adding:
        // settings: "unslick"
        // instead of a settings object
      ]
    });
  });


// document.querySelector('.site-nav-action')
// .addEventListener('click', () => {
//   document.querySelector('.site-nav-action')
//   .classList.toggle('active');
//   document.querySelector('.dropdown')
//   .classList.toggle('active');
// })


$(document).ready(function(){
  $('.next').click(function(){
    $('.film__pagination').find('.pageNumber.active').next()
    .addClass('active')
    $('.film__pagination').find('.pageNumber.active').prev()
    .removeClass('active')
  })

  $('.pre').click(function(){
    $('.film__pagination').find('.pageNumber.active').prev()
    .addClass('active')
    $('.film__pagination').find('.pageNumber.active').next()
    .removeClass('active')
  })

  $('.pageNumber').click(function(){
    $(this).addClass('active').siblings().removeClass('active')
  })
})


// $('li').click(function(){
//   $(this).addClass('active').siblings().removeClass('active')
// })