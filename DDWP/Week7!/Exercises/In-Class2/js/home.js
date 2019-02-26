$(document).ready(function () {
    $('#akronInfoDiv').hide();
    $('#minneapolisInfoDiv').hide();
    $('#louisvilleInfoDiv').hide();
    //$('#akronWeather').hide();
    //$('#minneapolisWeather').hide();
    //$('#louisvilleWeather').hide();


    //$('#minneapolisInfoDiv').addClass('btn btn-default');
    //$('#louisvilleInfoDiv').addClass('btn btn-default');
});

$('#akronButton').on('click', function () {
$('#mainInfoDiv').hide();
$('#akronWeather').hide();
$('#akronInfoDiv').show()});
$('#akronWeatherButton').on('click', function () {
$('#akronWeather').toggle()});

//$('#minneapolisButton').on('click', function () {
// $('#minneapolisInfoDiv').toggle();
// $('#minneapolisWeather').toggle()});

// $('#louisvilleButton').on('click', function () {
// $('#louisvilleInfoDiv').toggle();
// $('#louisvilleWeather').hide()});
