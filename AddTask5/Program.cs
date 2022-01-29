// See https://aka.ms/new-console-template for more information
using AddTask5;

Console.WriteLine("Hello, Teacher!");

Printer redPrinter = new RedPrinter();
redPrinter.Print("Red printer");

Printer greenPrinter = new GreenPrinter();
greenPrinter.Print("Green printer");

Printer yellowPrinter = new YellowPrinter();
yellowPrinter.Print("Yellow printer");
