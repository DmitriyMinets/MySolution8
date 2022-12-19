using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex._1.Classes
{
    internal class Room
    {
        private Printer printer;

        public Room(Printer printer)
        {
            this.printer = printer;
        }

        public void MakeThisLazyPrinterWork(string value)
        {
            printer.Print(value);
        }

        public void SwapPrinter(Printer printer)
        {
            this.printer = printer;
        }
    }
}
