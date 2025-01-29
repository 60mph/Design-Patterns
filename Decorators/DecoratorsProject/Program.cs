// See https://aka.ms/new-console-template for more information
using DecoratorsProject.Beverages;
using DecoratorsProject.Decorator;

Console.WriteLine("Hello, World!");
BeverageBase espresso = new Espresso();
BeverageBase blackTea = new BlackTea();
BeverageBase greenTea = new GreenTea();

printBeverage(espresso);
printBeverage(blackTea);
printBeverage(greenTea);

Console.WriteLine("__________________________");

BeverageBase capuccino = new SugarCondiment(new MilkCondiment(espresso));
printBeverage(capuccino);

void printBeverage(BeverageBase beverage)
{
    Console.WriteLine("Beverage: {0}; Price: {1}", beverage.GetDescriptoin(), beverage.GetCost());
}
