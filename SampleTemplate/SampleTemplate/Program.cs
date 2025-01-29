// See https://aka.ms/new-console-template for more information
using SampleTemplate.FastFood;

Console.WriteLine("Hello, World!");
var hamburger = new Hamburger();
var hotdog = new HotDog();
Console.WriteLine("\nHotDog:");
hotdog.Prepare();
Console.WriteLine("\nHamburger:");
hamburger.Prepare();