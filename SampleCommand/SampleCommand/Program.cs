// See https://aka.ms/new-console-template for more information
using SampleCommand;
using SampleCommand.Command;

Console.WriteLine("Hello, World!");
var remote = new RemoteControl();
String userInput;

remote.SetCommandForButton(1, new LightCommand(new SampleCommand.Reciver.Light()));
remote.SetCommandForButton(2, new MusicCommand(new SampleCommand.Reciver.Music()));
remote.SetCommandForButton(3, new TvCommand(new SampleCommand.Reciver.Tv()));
remote.SetCommandForButton(4, new TeapotCommand(new SampleCommand.Reciver.Teapot()));

do
{
    Console.WriteLine("Выберите вариант:");
    Console.WriteLine(remote);
    Console.WriteLine("Ваш выбор: ");
    int buttonId;
    int.TryParse(Console.ReadLine(), out buttonId);

    remote.PushButton(buttonId);
    remote.UndoButton(buttonId);
    Console.WriteLine("Вы хотите продолжить? (y/n): ");
    userInput = Console.ReadLine();
} while (userInput == "y");