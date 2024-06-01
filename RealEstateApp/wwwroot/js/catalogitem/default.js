$(document).ready(function () {
    var lol = document.getElementById('#inputTelephone');
    alert(lol);
    $('#inputTelephone').mask('+ { 7}(000)000-00-00');
    $('#phone-number').mask('0000-0000');
});