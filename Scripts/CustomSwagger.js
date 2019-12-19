$(function () {

    //Change the default Swagger text
    $("#logo").html("&nbsp;&nbsp;&nbsp; The Golden Egg");


    //Turning off the textbox
    $("input[name='baseUrl'], input[name='apiKey']").css("display", "none");

    //Custom Icon
    $("link[type='image/png']").attr("href", "/Images/goldenegg.png");

    //Custom Title
    $("title").text("The Golden Egg - API");

    //Custom button text
    $("#explore").text("Ding!");





})

//url and logo
$(function () {
    var logo = document.getElementById('logo');
    logo.href = "https://dcportalapi.azurewebsites.net/swagger";

    var logoImg = document.getElementsByClassName('logo__img')[0];
    logoImg.alt = "The Golden Egg";
    logoImg.src = "/Images/goldenegg.png";
    logoImg.width = 30;
})();