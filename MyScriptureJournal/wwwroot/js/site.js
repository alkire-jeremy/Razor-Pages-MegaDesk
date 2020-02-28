// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your Javascript code.
var click = new Audio();
click.src = "http://faintdev.net/academic/sounds/bg2click.mp3";

function playClick() {
    click.play();
}