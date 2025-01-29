// See https://aka.ms/new-console-template for more information
using SampleFacade.WashingMachine;
using System.ComponentModel.DataAnnotations;

Console.WriteLine("Hello, World!");
var washingMachineFacade = new WashingMachineFacade();

//Cotton
Console.WriteLine("Cotton");
washingMachineFacade.WashCotton();

Console.WriteLine();
//Wool
Console.WriteLine("Wool");
washingMachineFacade.WashWool();