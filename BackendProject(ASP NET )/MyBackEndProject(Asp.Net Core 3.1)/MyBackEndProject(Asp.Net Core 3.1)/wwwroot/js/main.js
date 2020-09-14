

(function ($) {
    "use strict";  

  
    let count = 9;
    $(document).on("click", ".loadmore", function (e) {
        let Coursecount = $("#Coursecount").val();
       let controller = $(this).attr("href");
       
            $.ajax({

                url: `${controller}/Load?count=` + count,
              
                type: "Get",
                success: function (res) {
                    $("#CourseList").append(res);
                  
                    count += 9;
                    if (count >= Coursecount) {
                        $(".loadmore").remove();
                    }
                }
            })
            e.preventDefault();

       
       
    })
   
       
    $(document).on('keyup', "#searchinput", function () {
       
            let hidden = $("#hidden").val();
            let search = $(this).val().trim();
            $("#searchlist  tr").remove();
            if (search.length > 0) {
                $.ajax({
                    url: "/Ajax/Search?search=" + search + "&hidden=" + hidden,
                    success: function (res) {
                        if (hidden == "course") {
                            for (let item of res) {

                                let div = `<tr  class="searches text-center">  
                                       <td> <img class="searchimage" src="~/../img/${hidden}/${item.image}"/></td>
                                      <td>${item.courseName.toUpperCase()}</td> 

                                     </tr>`


                                $("#searchlist").append(div)
                            }
                        }
                        else if (hidden == "event") {
                            for (let item of res) {
                               
                                let div = `<tr  class="searches text-center">  
                                       <td> <img class="searchimage" src="~/../img/${hidden}/${item.image}"/></td>
                                      <td>${item.name}</td> 

                                     </tr>`


                                $("#searchlist").append(div)
                            }
                        }

                        else if (hidden == "teacher") {
                            for (let item of res) {
                                
                                let div = `<tr  class="searches text-center">  
                                       <td> <img class="searchimage" src="~/../img/${hidden}/${item.image}"/></td>
                                      <td>${item.name}</td> 

                                     </tr>`


                                $("#searchlist").append(div)
                            }
                        }
                        else if (hidden == "blog") {
                            for (let item of res) {
                                console.log(item)
                                let div = `<tr  class="searches text-center">  
                                       <td> <img class="searchimage" src="~/../img/${hidden}/${item.image}"/></td>
                                      <td>${item.blogname}</td> 

                                     </tr>`


                                $("#searchlist").append(div)
                            }
                        }
                       
                       
                       
                    }
                })
            }



        })


   
/*------------------------------------
	Sticky Menu 
--------------------------------------*/
 var windows = $(window);
    var stick = $(".header-sticky");
	windows.on('scroll',function() {    
		var scroll = windows.scrollTop();
		if (scroll < 5) {
			stick.removeClass("sticky");
		}else{
			stick.addClass("sticky");
		}
	});  
/*------------------------------------
	jQuery MeanMenu 
--------------------------------------*/
	$('.main-menu nav').meanmenu({
		meanScreenWidth: "767",
		meanMenuContainer: '.mobile-menu'
	});
    
    
    /* last  2 li child add class */
    $('ul.menu>li').slice(-2).addClass('last-elements');
/*------------------------------------
	Owl Carousel
--------------------------------------*/
    $('.slider-owl').owlCarousel({
        loop:true,
        nav:true,
        animateOut: 'fadeOut',
        animateIn: 'fadeIn',
        smartSpeed: 2500,
        navText:['<i class="fa fa-angle-left"></i>','<i class="fa fa-angle-right"></i>'],
        responsive:{
            0:{
                items:1
            },
            768:{
                items:1
            },
            1000:{
                items:1
            }
        }
    });

    $('.partner-owl').owlCarousel({
        loop:true,
        nav:true,
        navText:['<i class="fa fa-angle-left"></i>','<i class="fa fa-angle-right"></i>'],
        responsive:{
            0:{
                items:1
            },
            768:{
                items:3
            },
            1000:{
                items:5
            }
        }
    });  

    $('.testimonial-owl').owlCarousel({
        loop:true,
        nav:true,
        navText:['<i class="fa fa-angle-left"></i>','<i class="fa fa-angle-right"></i>'],
        responsive:{
            0:{
                items:1
            },
            768:{
                items:1
            },
            1000:{
                items:1
            }
        }
    });
/*------------------------------------
	Video Player
--------------------------------------*/
    $('.video-popup').magnificPopup({
        type: 'iframe',
        mainClass: 'mfp-fade',
        removalDelay: 160,
        preloader: false,
        zoom: {
            enabled: true,
        }
    });
    
    $('.image-popup').magnificPopup({
        type: 'image',
        gallery:{
            enabled:true
        }
    }); 
/*----------------------------
    Wow js active
------------------------------ */
    new WOW().init();
/*------------------------------------
	Scrollup
--------------------------------------*/
    $.scrollUp({
        scrollText: '<i class="fa fa-angle-up"></i>',
        easingType: 'linear',
        scrollSpeed: 900,
        animation: 'fade'
    });
/*------------------------------------
	Nicescroll
--------------------------------------*/
     $('body').scrollspy({ 
            target: '.navbar-collapse',
            offset: 95
        });
$(".notice-left").niceScroll({
            cursorcolor: "#EC1C23",
            cursorborder: "0px solid #fff",
            autohidemode: false,
            
        });

})(jQuery);	