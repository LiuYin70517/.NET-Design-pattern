// See https://aka.ms/new-console-template for more information

using Abstract_Factory.Services;

var F1 =new DellFactory();
var keyboard = F1.GetKeyboard();
var mouse = F1.GetMouse();
keyboard.ShowKeyboardBrand();
mouse.ShowMouseBrand();