using Ex._1.Classes;

namespace Ex._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Printer printer = new Printer();
            Printer greenPrinter = new GreenPrinter();
            Printer bluePrinter = new BluePrinter();

            Room room = new Room(printer);

            room.MakeThisLazyPrinterWork("Метод Print базового класса Printer");

            room.SwapPrinter(greenPrinter);
            room.MakeThisLazyPrinterWork("Метод Print производного класса GreenPrinter");

            room.SwapPrinter(bluePrinter);
            room.MakeThisLazyPrinterWork("Метод Print производного класса BluePrinter");
        }
    }
}