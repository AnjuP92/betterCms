//iPad Banner Styling
function iPadStyling() {
    if (navigator.platform == 'iPad' && window.innerWidth == 768) {

        $('.textContainer').css({
            'top': '5%'
        });
        $('.textContainer').css({
            'width': '65%'
        });
        $('.textContainer').css({
            'height': '80%'
        });
        $('.contryIcon').css({
            'width': '200px'
        });
        $('.heading').css({
            'font-size': '1.5em'
        });
        $('.heading').css({
            'font-size': '1.5em'
        });
        $(".heading").css("left", "60%");
        $(".heading").css("bottom", "28%");
        $('#sticky_navigation ul li a').css("margin-left", "0%");

        var bookMarkPosition = 0;
        bookMarkPosition = $('#feature').offset().top;

        var scroll_top = $(window).height();
        if (scroll_top > bookMarkPosition) {
            if ($('#featureImage').attr('src').filename() == "device1") {
                $("#featureImage").removeClass('featureImage');
                $("#featureImage").addClass('featureImageAnimation');
                $('.bounce').removeClass('hideCallout');
            }
        }
        $("#bannerBox").css("position", "absolute");
        $("#bannerBox").css("top", "auto");
        $("#bannerBox").css("width", "148%");
        $("#bannerBox").css("bottom", "-14%");

    }
    if (navigator.platform == 'iPad' && window.innerWidth == 1024) {
        $('#sticky_navigation ul li a').css("margin-left", "2%");
        $('.textContainer').css({
            'height': '70%'
        });
        $('.textContainer').css({
            'top': '14%'
        });
        $('.textContainer').css({
            'width': '65%'
        });
        $('#logoImage').css({
            'position': 'absolute'
        });
        $('#logoImage').css({
            'right': '0'
        });
        $('.contryIcon').css({
            'width': '200px'
        });
        $('.contryIcon > span').css('font-size', '15px');
        $(".heading").css("left", "62%");
        $(".heading").css("bottom", "40%");
        if (isOnScreen($('#feature'))) {
            if ($('#featureImage').attr('src').filename() == "device1") {
                $("#featureImage").removeClass('featureImage');
                $("#featureImage").addClass('featureImageAnimation');
                $('.bounce').removeClass('hideCallout');

            }


        }

        $("#bannerBox").css("position", "absolute");
        $("#bannerBox").css("top", "auto");
        $("#bannerBox").css("width", "148%");
        $("#bannerBox").css("bottom", "-2%");

    }
}
$(window).resize(function () {
    iPadStyling();
    if ($('#banner-mobile').css('display') == 'block') {
        var textContainerHeight = $("#heading").height();
        $("#heading").css({
            'line-height': textContainerHeight + 'px'
        });
    } else {
        var textContainerHeight = $(".heading").height();
        $(".heading").css({
            'line-height': textContainerHeight + 'px'
        });
    }

});

$.fn.scrollStopped = function (callback) {
    var $this = $(this),
        self = this;
    $this.scroll(function () {
        if ($this.data('scrollTimeout')) {
            clearTimeout($this.data('scrollTimeout'));
        }
        $this.data('scrollTimeout', setTimeout(callback, 200, self));
    });
};
$(window).scrollStopped(function () {
    if (!scrolling) {
        var totalHeight;
        if ($('#featureIE').css('display') == "block") {
            totalHeight = $('#banner').height() + $('#featureIE').height() + $('#download').height() + $('#faq').height() + $('#aboutUs').height() + $('#buynow').height();
        } else {
            totalHeight = $('#banner').height() + $('#feature').height() + $('#download').height() + $('#faq').height() + $('#aboutUs').height() + $('#buynow').height();
        }
        if ($(window).scrollTop() + $(window).height() > $(document).height() - 90 || $(window).scrollTop() >= totalHeight) {
            $('.demo_container').find('a').each(function () {
                $('.demo_container ul li a').removeClass("selected");
                $('#featureLink').attr('src', '/images/icon_features.png');
                $('#buynowLink').attr('src', '/images/icon_buynow.png');
                $('#downloadLink').attr('src', '/images/icon_dwonload.png');
                $('#faqLink').attr('src', '/images/icon_faq.png');
                $('#aboutLink').attr('src', '/images/icon_aboutus.png');
                $('#contactLink').attr('src', '/images/icon_contanctus.png');
            });
            //$('#aboutLink').attr('src','/images/icon_aboutus_hover.png');	
            $('#contactLink').attr('src', '/images/icon_contanctus_hover.png');
            $('#cLink').addClass("selected");
            if ($('#featureImage').attr('src').filename() == "device1") {
                $("#featureImage").addClass('featureImage');
                $("#featureImage").removeClass('featureImageAnimation');
                $('.bounce').addClass('hideCallout');
            }
            return;
        }
        var scrollPos = $(document).scrollTop();
        $('.demo_container').find('a').each(function () {
            var currLink = $(this);
            var refElement = $(currLink.attr("name"));
            if (refElement.position().top <= scrollPos + 115) {
                $('.demo_container ul li a').removeClass("selected");

                $('#featureLink').attr('src', '/images/icon_features.png');
                $('#buynowLink').attr('src', '/images/icon_buynow.png');
                $('#downloadLink').attr('src', '/images/icon_dwonload.png');
                $('#faqLink').attr('src', '/images/icon_faq.png');
                $('#aboutLink').attr('src', '/images/icon_aboutus.png');
                $('#contactLink').attr('src', '/images/icon_contanctus.png');
                if ($(currLink).attr("id") == "fLink") {
                    $('#featureLink').attr('src', '/images/icon_features_hover.png');
                    currLink.addClass("selected");
                    if ($('#featureImage').attr('src').filename() == "device1") {
                        $("#featureImage").removeClass('featureImage');
                        $("#featureImage").addClass('featureImageAnimation');
                        $('.bounce').removeClass('hideCallout');
                    }
                }
                if ($(currLink).attr("id") == "bLink") {
                    $('#buynowLink').attr('src', '/images/icon_buynow_hover.png');
                    currLink.addClass("selected");
                    if ($('#featureImage').attr('src').filename() == "device1") {
                        $("#featureImage").removeClass('featureImage');
                        $("#featureImage").addClass('featureImageAnimation');
                        $('.bounce').removeClass('hideCallout');
                    }
                }
                if ($(currLink).attr("id") == "dLink") {
                    $('#downloadLink').attr('src', '/images/icon_dwonload_hover.png');
                    currLink.addClass("selected");
                    if ($('#featureImage').attr('src').filename() == "device1") {
                        $("#featureImage").addClass('featureImage');
                        $("#featureImage").removeClass('featureImageAnimation');
                        $('.bounce').addClass('hideCallout');
                    }
                }
                if ($(currLink).attr("id") == "abLink") {
                    $('#aboutLink').attr('src', '/images/icon_aboutus_hover.png');
                    currLink.addClass("selected");
                    if ($('#featureImage').attr('src').filename() == "device1") {
                        $("#featureImage").addClass('featureImage');
                        $("#featureImage").removeClass('featureImageAnimation');
                        $('.bounce').addClass('hideCallout');
                    }
                }
                if ($(currLink).attr("id") == "faLink") {
                    $('#faqLink').attr('src', '/images/icon_faq_hover.png');
                    currLink.addClass("selected");
                    if ($('#featureImage').attr('src').filename() == "device1") {
                        $("#featureImage").addClass('featureImage');
                        $("#featureImage").removeClass('featureImageAnimation');
                        $('.bounce').addClass('hideCallout');
                    }
                }

            } else {
                if ($(currLink).attr("id") == "fLink") {
                    currLink.removeClass("selected");
                    $('#featureLink').attr('src', '/images/icon_features.png');
                }

                if ($(currLink).attr("id") == "bLink") {
                    currLink.removeClass("selected");
                    $('#buynowLink').attr('src', '/images/icon_buynow.png');
                }

                if ($(currLink).attr("id") == "dLink") {
                    currLink.removeClass("selected");
                    $('#downloadLink').attr('src', '/images/icon_dwonload.png');
                }
                if ($(currLink).attr("id") == "faLink") {
                    currLink.removeClass("selected");
                    $('#faqLink').attr('src', '/images/icon_faq.png');
                }

                if ($(currLink).attr("id") == "abLink") {
                    currLink.removeClass("selected");
                    $('#aboutLink').attr('src', '/images/icon_aboutus.png');
                }

                if ($(currLink).attr("id") == "cLink") {
                    currLink.removeClass("selected");
                    $('#contactLink').attr('src', '/images/icon_contanctus.png');
                }
                currLink.removeClass("selected");
            }
        });
    }
});

function loadimg(s) {
    var i = document.createElement("img");
    i.setAttribute("src", s);
}
var current = "general";
var changerTimer = null;
var step = "";
var firstTime = "";
var title = "";
var image = "";
var mobileBanner = "";
var titleMobile = "";
var i = 0;
var j = 0;
var images = "";
var textsUSA = "";
var textsMaxico = "";
var textsIndonasia = "";
var textsMalaysia = "";
var textsThailand = "";
var textsVietnam = "";
var textsColumbia = "";
var textsKorea = "";
var textsMyanmar = "";
var textsTurkey = "";
var textsJapan = "";
var textsChina = "";
var textsSingapore = "";
var textsEcuador = "";
var textsPhilippines = "";
var textsSrilanka = "";
var textsCostarica = "";
var textsHongKong = "";
var textsIndia = "";
var textsGreece = "";
var textsCyprus = "";
var textsPoland = "";

$(window).load(function () {


});

$(document).ready(function () {


    window.addEventListener("orientationchange", function () {
        location.reload();

    }, false);
    startAnimation();
    /*var countryIconWidth = 0; 
    var c=0;
    $("#countries-desktop").find("div").each(function(){
	
    if($(this).hasClass('contryIcon'))
    {
    	//alert($(this).width());
    	countryIconWidth = countryIconWidth + $(this).width();
    	c= c+1;
    }
    });
    alert(c);
    $("#countries-desktop").css({'width':countryIconWidth+'px'});
    	
    */




});

function startAnimation() {
    iPadStyling();
    $(document).on("scroll", onScrollForMobile);
    loadimg("/images/banner_img.jpg");
    loadimg("/images/user_4.png");
    loadimg("/images/user_5.png");
    loadimg("/images/user_6.png");
    loadimg("/images/user_7.png");
    loadimg("/images/user_8.png");
    loadimg("/images/user_9.png");
    loadimg("/images/user_10.png");
    loadimg("/images/user_11.png");
    loadimg("/images/demo_now_nomral.png");
    loadimg("/images/demo_now_hover.png");
    loadimg("/images/icon_dwonload.png");
    loadimg("/images/icon_faq.png");
    loadimg("/images/icon_contanctus.png");
    loadimg("/images/icon_features.png");
    loadimg("/images/icon_dwonload_hover.png");
    loadimg("/images/icon_faq_hover.png");
    loadimg("/images/icon_contanctus_hover.png");
    loadimg("/images/icon_features_hover.png");


    if (isOnScreen()) {
        if ($('#featureImage').attr('src').filename() == "device1") {
            $("#featureImage").removeClass('featureImage');
            $("#featureImage").addClass('featureImageAnimation');
            $('.bounce').removeClass('hideCallout');

        }
    }

    if ($('#banner-mobile').css('display') == 'block') {
        var textContainerHeight = $("#heading").height();
        $("#heading").css({
            'line-height': textContainerHeight + 'px'
        });
    } else {
        var textContainerHeight = $("heading").height();
        $(".heading").css({
            'line-height': textContainerHeight + 'px'
        });
    }




    changerTimer = null;
    step = 1;
    firstTime = false;
    title = $("#heading>span");
    image = $("#user_img");
    mobileBanner = $("#user_img_mobile img");
    titleMobile = $("#bannerBox-mobile").find("#heading>span");
    i = 0;
    j = 0;
    images = ['./images/user_1.png', './images/user_2.png', './images/user_3.png', './images/user_4.png', './images/user_5.png', './images/user_6.png', './images/user_7.png', './images/user_8.png', './images/user_9.png', './images/user_10.png', './images/user_11.png'];

    textsUSA = ["Speak. English. Fast.", "Anywhere.<br/> Anytime.<br/> Any Device.", "NYC English is Learning on the Go!", "Research-based", "Record and compare your voice", "Native English speakers teach you English", "NYC English has an attractive, modern design", "Themed based instruction for accelerating conversational English", "NYC English<br/>is<br/>24/7", "Correlated to National and International Standards", "Writing prompts at your fingertips"];

    textsMaxico = ["Aprender. Inglés. Rápido.", "Dondequiera, <br/>en cualquier momento,<br/>cualquier dispositivo", "Belleza e inteligencia todo en uno", "Basada en la investigación", "NYCE tiene hablante nativos en vIdeo HD.", "Practica a su propio ritmo con la herramienta de grabación de voz", "NYCE tiene un diseño atractivo, elegante y moderno.", "Instrucción de base temática para acelerar la conversación de Ingles", "NYC English<br/>es<br/>24/7", "Correlated to National and International Standards", "Writing prompts at your fingertips"];

    textsIndonasia = ["Belajar.Inggris.Cepat", "Dimana saja.<br/>Kapan saja.<br/> Semua jenis perangkat", "keindahan dan kepintaran tergabung dalam satu produk", "Berdasarkan penelitian", "NYCE menampilkan native speaker dalam bentuk HD video", "Berlatih berbicara dengan kecepatan anda sendiri dengan alat perekam suara", "NYCE menampilkan desain yang menarik, atraktif dan modern", "Instruksi berbasis tematik untuk mempercepat kemampuan berkomunikasi dalam bahasa Inggris", "NYC English dapat diakses 24/7", "Correlated to National and International Standards", "Writing prompts at your fingertips"];

    textsMalaysia = ["Belajar.Inggris.Cepat", "Dimana saja.<br/>Kapan saja.<br/>Semua jenis perangkat", "keindahan dan kepintaran tergabung dalam satu produk", "Berdasarkan penelitian", "NYCE menampilkan native speaker dalam bentuk HD video", "Berlatih berbicara dengan kecepatan anda sendiri dengan alat perekam suara", "NYCE menampilkan desain yang menarik, atraktif dan modern", "Instruksi berbasis tematik untuk mempercepat kemampuan berkomunikasi dalam bahasa Inggris", "NYC English dapat diakses 24/7", "Correlated to National and International Standards", "Writing prompts at your fingertips"];

    textsThailand = ["เรียน อังกฤษ รวดเร็ว", ": ไม่ว่าที่ใด ตลอดเวลา อุปกรณ์ใด ๆ 24/7", "ความงามและสมองทั้งหมดในที่เดียว", "ความงามและสมองทั้งหมดในที่เดียว", "ความงามและสมองทั้งหมดในที่เดียว", "ความงามและสมองทั้งหมดในที่เดียว", "Correlated to National and International Standards", "Writing prompts at your fingertips"];

    textsVietnam = ["Tìm hiểu. Tiếng Anh. Nhanh.", "Bất cứ nơi nào. MỌI LÚC. BẤT KỲ THIẾT BỊ.24/7", "Vẻ đẹp và bộ não của tất cả trong một.", "Vẻ đẹp và bộ não của tất cả trong một.", "Vẻ đẹp và bộ não của tất cả trong một.", "Vẻ đẹp và bộ não của tất cả trong một.", "Correlated to National and International Standards", "Writing prompts at your fingertips"];

    textsColumbia = ["Aprender. Inglés. Rápido.", "Dondequiera, <br/>en cualquier momento,<br/>cualquier dispositivo", "Belleza e inteligencia todo en uno", "Basada en la investigación", "NYCE tiene hablante nativos en vIdeo HD.", "Practica a su propio ritmo con la herramienta de grabación de voz", "NYCE tiene un diseño atractivo, elegante y moderno.", "Instrucción de base temática para acelerar la conversación de Ingles", "NYC English<br/>es<br/>24/7", "Correlated to National and International Standards", "Writing prompts at your fingertips"];

    textsKorea = ["Speak. English. Fast.", "Anywhere.<br/> Anytime.<br/> Any Device.", "NYC English is Learning on the Go!", "Research-based", "Record and compare your voice", "Native English speakers teach you English", "NYC English has an attractive, modern design", "Themed based instruction for accelerating conversational English", "NYC English<br/>is<br/>24/7", "Correlated to National and International Standards", "Writing prompts at your fingertips"];

    textsMyanmar = ["Speak. English. Fast.", "Anywhere.<br/> Anytime.<br/> Any Device.", "NYC English is Learning on the Go!", "Research-based", "Record and compare your voice", "Native English speakers teach you English", "NYC English has an attractive, modern design", "Themed based instruction for accelerating conversational English", "NYC English<br/>is<br/>24/7", "Correlated to National and International Standards", "Writing prompts at your fingertips"];

    textsJapan = ["Speak. English. Fast.", "Anywhere.<br/> Anytime.<br/> Any Device.", "NYC English is Learning on the Go!", "Research-based", "Record and compare your voice", "Native English speakers teach you English", "NYC English has an attractive, modern design", "Themed based instruction for accelerating conversational English", "NYC English<br/>is<br/>24/7", "Correlated to National and International Standards", "Writing prompts at your fingertips"];

    textsChina = ["Speak. English. Fast.", "Anywhere.<br/> Anytime.<br/> Any Device.", "NYC English is Learning on the Go!", "Research-based", "Record and compare your voice", "Native English speakers teach you English", "NYC English has an attractive, modern design", "Themed based instruction for accelerating conversational English", "NYC English<br/>is<br/>24/7", "Correlated to National and International Standards", "Writing prompts at your fingertips"];

    textsSingapore = ["Speak. English. Fast.", "Anywhere.<br/> Anytime.<br/> Any Device.", "NYC English is Learning on the Go!", "Research-based", "Record and compare your voice", "Native English speakers teach you English", "NYC English has an attractive, modern design", "Themed based instruction for accelerating conversational English", "NYC English<br/>is<br/>24/7", "Correlated to National and International Standards", "Writing prompts at your fingertips"];

    textsEcuador = ["Speak. English. Fast.", "Anywhere.<br/> Anytime.<br/> Any Device.", "NYC English is Learning on the Go!", "Research-based", "Record and compare your voice", "Native English speakers teach you English", "NYC English has an attractive, modern design", "Themed based instruction for accelerating conversational English", "NYC English<br/>is<br/>24/7", "Correlated to National and International Standards", "Writing prompts at your fingertips"];

    textsPhilippines = ["Speak. English. Fast.", "Anywhere.<br/> Anytime.<br/> Any Device.", "NYC English is Learning on the Go!", "Research-based", "Record and compare your voice", "Native English speakers teach you English", "NYC English has an attractive, modern design", "Themed based instruction for accelerating conversational English", "NYC English<br/>is<br/>24/7", "Correlated to National and International Standards", "Writing prompts at your fingertips"];

    textsSrilanka = ["Speak. English. Fast.", "Anywhere.<br/> Anytime.<br/> Any Device.", "NYC English is Learning on the Go!", "Research-based", "Record and compare your voice", "Native English speakers teach you English", "NYC English has an attractive, modern design", "Themed based instruction for accelerating conversational English", "NYC English<br/>is<br/>24/7", "Correlated to National and International Standards", "Writing prompts at your fingertips"];

    textsHongKong = ["Speak. English. Fast.", "Anywhere.<br/> Anytime.<br/> Any Device.", "NYC English is Learning on the Go!", "Research-based", "Record and compare your voice", "Native English speakers teach you English", "NYC English has an attractive, modern design", "Themed based instruction for accelerating conversational English", "NYC English<br/>is<br/>24/7", "Correlated to National and International Standards", "Writing prompts at your fingertips"];

    textsIndia = ["Speak. English. Fast.", "Anywhere.<br/> Anytime.<br/> Any Device.", "NYC English is Learning on the Go!", "Research-based", "Record and compare your voice", "Native English speakers teach you English", "NYC English has an attractive, modern design", "Themed based instruction for accelerating conversational English", "NYC English<br/>is<br/>24/7", "Correlated to National and International Standards", "Writing prompts at your fingertips"];

    textsGreece = ["Speak. English. Fast.", "Anywhere.<br/> Anytime.<br/> Any Device.", "NYC English is Learning on the Go!", "Research-based", "Record and compare your voice", "Native English speakers teach you English", "NYC English has an attractive, modern design", "Themed based instruction for accelerating conversational English", "NYC English<br/>is<br/>24/7", "Correlated to National and International Standards", "Writing prompts at your fingertips"];

    textsCyprus = ["Speak. English. Fast.", "Anywhere.<br/> Anytime.<br/> Any Device.", "NYC English is Learning on the Go!", "Research-based", "Record and compare your voice", "Native English speakers teach you English", "NYC English has an attractive, modern design", "Themed based instruction for accelerating conversational English", "NYC English<br/>is<br/>24/7", "Correlated to National and International Standards", "Writing prompts at your fingertips"];

    textsPoland = ["Speak. English. Fast.", "Anywhere.<br/> Anytime.<br/> Any Device.", "NYC English is Learning on the Go!", "Research-based", "Record and compare your voice", "Native English speakers teach you English", "NYC English has an attractive, modern design", "Themed based instruction for accelerating conversational English", "NYC English<br/>is<br/>24/7", "Correlated to National and International Standards", "Writing prompts at your fingertips"];

    imageChanger(0, textsUSA);
    if ($('#banner-mobile').css('display') == 'block') {
        $("#countries-mobile").find("div").each(function () {
            $(this).on({
                mouseenter: function () {
                    clearInterval(changerTimer);
                    clearInterval(image_animation_mobile);
                    var country = $(this).attr("country");
                    switch (country) {
                        case 'usa':
                            title.html(textsUSA[j]);
                            imageChanger(j, textsUSA);
                            break;
                        case 'mexico':
                            title.html(textsMaxico[j]);
                            imageChanger(j, textsMaxico);
                            break;
                        case 'indonasia':
                            title.html(textsIndonasia[j]);
                            imageChanger(j, textsIndonasia);
                            break;
                        case 'malaysia':
                            title.html(textsMalaysia[j]);
                            imageChanger(j, textsMalaysia);
                            break;
                        case 'thailand':
                            title.html(textsThailand[j]);
                            imageChanger(j, textsThailand);
                            break;
                        case 'vietnam':
                            title.html(textsVietnam[j]);
                            imageChanger(j, textsVietnam);
                            break;
                        case 'columbia':
                            title.html(textsColumbia[j]);
                            imageChanger(j, textsColumbia);
                            break;
                        case 'korea':
                            title.html(textsKorea[j]);
                            imageChanger(j, textsKorea);
                            break;
                        case 'myanmar':
                            title.html(textsMyanmar[j]);
                            imageChanger(j, textsMyanmar);
                            break;
                        case 'japan':
                            title.html(textsJapan[j]);
                            imageChanger(j, textsJapan);
                            break;
                        case 'china':
                            title.html(textsChina[j]);
                            imageChanger(j, textsChina);
                            break;
                        case 'singapore':
                            title.html(textsSingapore[j]);
                            imageChanger(j, textsSingapore);
                            break;
                        case 'ecuador':
                            title.html(textsEcuador[j]);
                            imageChanger(j, textsEcuador);
                            break;
                        case 'philippines':
                            title.html(textsPhilippines[j]);
                            imageChanger(j, textsPhilippines);
                            break;
                        case 'srilanka':
                            title.html(textsSrilanka[j]);
                            imageChanger(j, textsSrilanka);
                            break;
                        case 'hongkong':
                            title.html(textsHongKong[j]);
                            imageChanger(j, textsHongKong);
                            break;
                        case 'india':
                            title.html(textsIndia[j]);
                            imageChanger(j, textsIndia);
                            break;
                        case 'greece':
                            title.html(textsGreece[j]);
                            imageChanger(j, textsGreece);
                            break;
                        case 'cyprus':
                            title.html(textsCyprus[j]);
                            imageChanger(j, textsCyprus);
                            break;
                        case 'poland':
                            title.html(textsPoland[j]);
                            imageChanger(j, textsPoland);
                            break;

                    }
                },
                mouseleave: function () {
                    clearInterval(changerTimer);
                    clearInterval(image_animation);
                    imageChanger(i, textsUSA);
                }
            });
        });
    } else {
        $("#countries-desktop").find("div").each(function () {
            $(this).on({
                mouseenter: function () {
                    clearInterval(changerTimer);
                    clearInterval(image_animation);
                    var country = $(this).attr("country");
                    switch (country) {
                        case 'usa':
                            //title.html(textsUSA[j]);
                            imageChanger(j, textsUSA);
                            break;
                        case 'mexico':
                            //title.html(textsMaxico[j]);		
                            imageChanger(j, textsMaxico);
                            break;
                        case 'indonasia':
                            //title.html(textsIndonasia[j]);
                            imageChanger(j, textsIndonasia);
                            break;
                        case 'malaysia':
                            //title.html(textsMalaysia[j]);	
                            imageChanger(j, textsMalaysia);
                            break;
                        case 'thailand':
                            //title.html(textsThailand[j]);	
                            imageChanger(j, textsThailand);
                            break;
                        case 'vietnam':
                            //title.html(textsVietnam[j]);
                            imageChanger(j, textsVietnam);
                            break;
                        case 'columbia':
                            //title.html(textsColumbia[j]);
                            imageChanger(j, textsColumbia);
                            break;
                        case 'korea':
                            //title.html(textsKorea[j]);
                            imageChanger(j, textsKorea);
                            break;
                        case 'myanmar':
                            //title.html(textsKorea[j]);
                            imageChanger(j, textsMyanmar);
                            break;
                        case 'japan':
                            //title.html(textsKorea[j]);
                            imageChanger(j, textsJapan);
                            break;
                        case 'china':
                            //title.html(textsKorea[j]);
                            imageChanger(j, textsChina);
                            break;
                        case 'singapore':
                            //title.html(textsGermany[j]);
                            imageChanger(j, textsSingapore);
                            break;
                        case 'ecuador':
                            //title.html(textsGermany[j]);
                            imageChanger(j, textsEcuador);
                            break;
                        case 'philippines':
                            //title.html(textsGermany[j]);
                            imageChanger(j, textsPhilippines);
                            break;
                        case 'srilanka':
                            //title.html(textsGermany[j]);
                            imageChanger(j, textsSrilanka);
                            break;
                        case 'hongkong':
                            //title.html(textsGermany[j]);
                            imageChanger(j, textsHongKong);
                            break;
                        case 'india':
                            //title.html(textsGermany[j]);
                            imageChanger(j, textsIndia);
                            break;
                        case 'greece':
                            //title.html(textsGermany[j]);
                            imageChanger(j, textsGreece);
                            break;
                        case 'cyprus':
                            //title.html(textsGermany[j]);
                            imageChanger(j, textsCyprus);
                            break;
                        case 'poland':
                            //title.html(textsGermany[j]);
                            imageChanger(j, textsPoland);
                            break;
                    }
                },
                mouseleave: function () {
                    clearInterval(changerTimer);
                    clearInterval(image_animation);
                    imageChanger(i, textsUSA);
                }
            });
        });
    }
    /*	$("#countries-desktop").find("div").each(function ()
    	{
    		$(this).on(
    		{
    			click: function ()
    			{ 
    				clearInterval(changerTimer);						
    				var country = $(this).attr("country");
    				switch (country)
    				{
    					case 'usa':
    						title.html(textsUSA[j]);								
    						break;
    					case 'mexico':
    						title.html(textsMaxico[j]);                                
    						break;
    					case 'indonasia':
    						title.html(textsIndonasia[j]);                               
    						break;
    					case 'malaysia':
    						title.html(textsMalaysia[j]);                                
    						break;
    					case 'thailand':
    						title.html(textsThailand[j]);                                
    						break;
    					case 'vietnam':
    						title.html(textsVietnam[j]);                               
    						break;
    				}
    			}
    		});
    	});*/
    if (navigator.platform == 'iPad' || navigator.platform == 'iPhone' || navigator.platform == 'android') {} else {
        $(".demo_container").find("a").each(function () {

            $(this).on({
                mouseenter: function () {
                    if ($(this).attr('id') == "fLink") {
                        $('#featureLink').attr('src', '/images/icon_features_hover.png');
                    }
                    if ($(this).attr('id') == "bLink") {
                        $('#buynowLink').attr('src', '/images/icon_buynow_hover.png');
                    }
                    if ($(this).attr('id') == "dLink") {
                        $('#downloadLink').attr('src', '/images/icon_dwonload_hover.png');
                    }
                    if ($(this).attr('id') == "faLink") {
                        $('#faqLink').attr('src', '/images/icon_faq_hover.png');
                    }
                    if ($(this).attr('id') == "abLink") {
                        $('#aboutLink').attr('src', '/images/icon_aboutus_hover.png');
                    }
                    if ($(this).attr('id') == "cLink") {
                        $('#contactLink').attr('src', '/images/icon_contanctus_hover.png');
                    }
                },
                mouseleave: function () {
                    if (!$(this).hasClass('selected')) {
                        if ($(this).attr('id') == "fLink") {
                            $('#featureLink').attr('src', '/images/icon_features.png');
                        }
                        if ($(this).attr('id') == "bLink") {
                            $('#buynowLink').attr('src', '/images/icon_buynow.png');
                        }
                        if ($(this).attr('id') == "dLink") {
                            $('#downloadLink').attr('src', '/images/icon_dwonload.png');
                        }
                        if ($(this).attr('id') == "faLink") {
                            $('#faqLink').attr('src', '/images/icon_faq.png');
                        }
                        if ($(this).attr('id') == "abLink") {
                            $('#aboutLink').attr('src', '/images/icon_aboutus.png');
                        }
                        if ($(this).attr('id') == "cLink") {
                            $('#contactLink').attr('src', '/images/icon_contanctus.png');
                        }
                    }
                }
            });


        });
    }
    $(".modal").delay(10).fadeOut("slow");
}





function imageChanger(index, params) {
    i = index;
    j = index;
    if ($('#banner-mobile').css('display') == 'block') {
        titleMobile.html(params[j]);
    } else {
        title.html(params[j]);
    }
    changerTimer = setInterval(function () {
        i++;
        j++;
        if ($('#banner-mobile').css('display') == 'block') {
            image_animation_mobile(i);
            titleMobile.fadeOut(1000, function () {
                titleMobile.html(params[j]);
                titleMobile.fadeIn(1000);
            });
        } else {
            image_animation(i);
            title.fadeOut(1000, function () {
                title.html(params[j]);
                title.fadeIn(1000);
            });
        }
        if (i == images.length) {
            i = 0;
            j = 0;
        }
    }, 7000);
}

function image_animation_mobile(imgIndex) {
    step = imgIndex;
    var opacity = 0.0;
    if (step == 11) {
        n = 11;
        step = 1;
        opacity = 1.0;
        $("#user_m_" + step).animate({
            'opacity': opacity
        }, 2000);
        $("#user_m_" + n).animate({
            'opacity': 0.0
        }, 2000);
        return;
    }
    var n = step + 1;
    $("#user_m_" + step).animate({
        'opacity': opacity
    }, 2000);
    $("#user_m_" + n).animate({
        'opacity': 1.0
    }, 2000);
    step = n;
}

function image_animation(imgIndex) {
    step = imgIndex;
    var opacity = 0.0;
    if (step == 11) {
        n = 11;
        step = 1;
        opacity = 1.0;
        $("#user_" + step).animate({
            'opacity': opacity
        }, 2000);
        $("#user_" + n).animate({
            'opacity': 0.0
        }, 2000);
        return;
    }
    var n = step + 1;
    $("#user_" + step).animate({
        'opacity': opacity
    }, 2000);
    $("#user_" + n).animate({
        'opacity': 1.0
    }, 2000);
    step = n;
}
var isScrolled = false;
var scrolling = false;
$(window).scroll(function () {
    if (isScrolled == false) {
        if (isOnScreen()) {
            if ($('#featureImage').attr('src').filename() == "device1") {
                $("#featureImage").removeClass('featureImage');
                $("#featureImage").addClass('featureImageAnimation');
                $('.bounce').removeClass('hideCallout');

            }
        }
    }
    var sticky_navigation_offset_top = 0;
    sticky_navigation_offset_top = $('#navAnchor').offset().top;
    var headPosition = $('#banner').height();
    var scroll_top = $(window).scrollTop();
    if (scroll_top > headPosition) {
        $('#sticky_navigation').css({
            'position': 'fixed',
            'top': 0,
            'left': 0
        });
        $('#logoMenu').css({
            'display': 'block'
        });
        $('#feature').css({
            'margin-top': '115px'
        })
        $('#featureIE').css({
            'margin-top': '115px'
        })
    } else {
        $('#sticky_navigation').css({
            'position': 'relative'
        });
        $('#logoMenu').css({
            'display': 'none'
        });
        $('#feature').css({
            'margin-top': '0'
        })
    }
});


function isOnScreen() {
    var bookMarkPosition = 0;
    bookMarkPosition = $('#featureBackground').offset().top;
    var scroll_top = $(window).scrollTop();
    var bookMarkReach = $('#banner').height() / 2;
    if (scroll_top > bookMarkReach) {
        return true;
        isScrolled = true;
    } else {
        return false;
        isScrolled = false;
    }
}

function makeSelected(obj) {
    $('#mobile-menu').find('a').each(function () {
        $(this).removeClass('active');
    });
    $(obj).addClass('active');
    if ($(obj).attr('id') == "home-link") {
        var home = "banner-mobile";
        scrollToDiv(home);
    }
    if ($(obj).attr('id') == "feature-link") {
        var feature = "feature-mobile";
        scrollToDiv(feature);
    }
    if ($(obj).attr('id') == "buynow-link") {
        var buynow = "buynow";
        scrollToDiv(buynow);
    }
    if ($(obj).attr('id') == "download-link") {
        var download = 'download-mobile';
        scrollToDiv(download);
    }
    if ($(obj).attr('id') == "faq-link") {
        var faq = "faq";
        scrollToDiv(faq);
    }
    if ($(obj).attr('id') == "about-link") {
        var about = "aboutUs";
        scrollToDiv(about);
    }
    if ($(obj).attr('id') == "contact-link") {
        var contact = "contectUs";
        scrollToDiv(contact);
    }
}

function scrollToDiv(id) {
    scrolling = true;
    $('html, body').animate({
        scrollTop: $('#' + id).offset().top
    }, 2000);

}

function onScrollForMobile() {
    var scrollPos = $(document).scrollTop();
    if (scrollPos == 0 || scrollPos <= $('mobile-menu').height()) {
        $('#home-link').addClass('active');
        $('#feature-link').removeClass('active');
        return;
    }
    $('#mobile-menu').find('a').each(function () {
        var currLink = $(this);
        var refElement = $(currLink.attr("name"));

        if (refElement.position().top <= scrollPos + 55) {
            $('#mobile-menu ul li a').removeClass("active");
            currLink.addClass("active");
        } else {
            currLink.removeClass("active");
        }
    });
}

function activeClass(obj) {
    $('.demo_container').find('a').each(function () {
        $(this).removeClass('selected');

        $('#featureLink').attr('src', '/images/icon_features.png');
        $('#buynowLink').attr('src', '/images/icon_buynow.png');
        $('#downloadLink').attr('src', '/images/icon_dwonload.png');
        $('#faqLink').attr('src', '/images/icon_faq.png');
        $('#aboutLink').attr('src', '/images/icon_aboutus.png');
        $('#contactLink').attr('src', '/images/icon_contanctus.png');
    });
    if ($(obj).attr('id') == "fLink") {
        $('#featureLink').attr('src', '/images/icon_features_hover.png');
        var feature;
        if ($('#featureIE').css('display') == "block") {
            feature = "featureIE";
        } else {
            feature = "feature";
        }
        smoothScroll(feature);
        resetToInitialOnClick();
    }
    if ($(obj).attr('id') == "bLink") {
        $('#buynowLink').attr('src', '/images/icon_buynow_hover.png');
        var download = 'buynow';
        smoothScroll(download);
    }
    if ($(obj).attr('id') == "dLink") {
        $('#downloadLink').attr('src', '/images/icon_dwonload_hover.png');
        var download = 'download';
        smoothScroll(download);
    }
    if ($(obj).attr('id') == "faLink") {
        $('#faqLink').attr('src', '/images/icon_faq_hover.png');
        var faq = "faq";
        smoothScroll(faq);
    }
    if ($(obj).attr('id') == "abLink") {
        $('#aboutLink').attr('src', '/images/icon_aboutus_hover.png');
        var contact = "aboutUs";
        smoothScroll(contact);
    }
    if ($(obj).attr('id') == "cLink") {
        $('#contactLink').attr('src', '/images/icon_contanctus_hover.png');
        var contact = "contectUs";
        smoothScroll(contact);
    }
}

function smoothScroll(id) {
    scrolling = true;
    $('html, body').animate({
        scrollTop: $('#' + id).offset().top - 100
    }, 1600);


    if (id == 'feature') {
        $("#featureImage").removeClass('featureImage');
        $("#featureImage").addClass('featureImageAnimation');
        $('.bounce').removeClass('hideCallout');
    }
    if (id == "banner") {
        $('.demo_container').find('a').each(function () {
            $(this).removeClass('selected'); {
                $('#featureLink').attr('src', '/images/icon_features.png');
                $('#buynowLink').attr('src', '/images/icon_buynow.png');
                $('#downloadLink').attr('src', '/images/icon_dwonload.png');
                $('#faqLink').attr('src', '/images/icon_faq.png');
                $('#aboutLink').attr('src', '/images/icon_aboutus.png');
                $('#contactLink').attr('src', '/images/icon_contanctus.png');
            }
        });
    }
    scrolling = false;
}

function showHide(obj, btnClick) {
    current = btnClick;
    if (btnClick == "general") {
        var div = $("#licensing");
        div.hide();
        var div = $("#support");
        div.hide();
    } else if (btnClick == "licensing") {
        var div = $("#general");
        div.hide();
        var div = $("#support");
        div.hide();
    } else {
        var div = $("#general");
        div.hide();
        var div = $("#licensing");
        div.hide();
    }
    var div = $("#" + btnClick);
    div.show();
    $(".tabs").find(".tabCover").each(function () {
        $(this).removeClass("active");
    });
    $(obj).addClass("active");
}

function ExpandCoolapseAll() {
    var collExp = $("#" + current).find(".showHideLink").text();
    if (collExp == "Expand all Answers in this section") {
        $("#" + current).find("input[id^='header']").each(function () {
            $(this).prop('checked', true);
            $(".answer").show();
        });
        $("#" + current).find(".showHideLink").each(function () {
            $(this).text("Collapse all Answers in this section");
        });
    } else {
        $("#" + current).find("input[id^='header']").each(function () {
            $(this).prop('checked', false);
            $(".answer").hide();
        });

        $("#" + current).find(".showHideLink").each(function () {
            $(this).text("Expand all Answers in this section");
        });
    }
}

function CheckExpand(obj) {
    var flag = false;
    var collExp = $("#" + current).find(".showHideLink").text();
    $("#" + current).find("input[id^='header']").each(function () {
        if ($(this).prop('checked') == true) {
            flag = true;
            return false;
        } else {
            flag = false;
        }
    });
    if (flag == true) {
        $("#" + current).find(".showHideLink").each(function () {
            $(this).text("Collapse all Answers in this section");
        });
    } else {
        $("#" + current).find(".showHideLink").each(function () {
            $(this).text("Expand all Answers in this section");
        });
    }
    if ($(obj).is(":checked")) {
        var id = $(obj).attr("id");
        $(obj).prop('checked', true);
        $(obj).prop('checked', "checked");
        $(obj).attr('checked', "checked");
        $(obj).attr('checked', true);
        $("#Div" + id).show();
    } else {
        var id = $(obj).attr("id");
        $(obj).prop('checked', false);
        $(obj).prop('checked', "");
        $(obj).attr('checked', "");
        $(obj).attr('checked', false);
        $("#Div" + id).hide();
    }
}
