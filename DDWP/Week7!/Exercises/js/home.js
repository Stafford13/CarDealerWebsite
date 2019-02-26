$(document).ready(function () {
    $('h1').addClass('text-center');
    $('h2').addClass('text-center');
    $('.myBannerHeading').removeClass('myBannerHeading').addClass('page-header');
    $('#yellowHeading').text("Yellow Team");
    $('#redTeamList').css('background-color', 'Red');
    $('#blueTeamList').css('background-color', 'Blue');
    $('#orangeTeamList').css('background-color', 'darkOrange');
    $('#yellowTeamList').css('background-color', 'Yellow');
    $('#yellowTeamList').append('<li>Joseph Banks</li><li>Simon Jones</li>');
    $('#oops').hide();
    $('#footerPlaceholder').remove();
    $('#footer').addClass('h2').append('Eric Stafford. Number').css('font-family', 'Courier', 'font-size', '24px');
});
