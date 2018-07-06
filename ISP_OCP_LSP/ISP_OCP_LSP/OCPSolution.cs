using System;
using System.Collections.Generic;
using System.Text;

namespace ISP_OCP_LSP
{
   class Client1
    {       
        public void PrintingMessage(PrinterP p)
        {
            p.Print();
        }
    }

    abstract class PrinterP
    {
       abstract public void Print();
    }

    class PrinterP1 : PrinterP
    {
        public override void Print()
        {
            Console.WriteLine("Print from Printer1");
        }
    }

    class PrinterP2 : PrinterP
    {
        public override void Print()
        {
            Console.WriteLine("Print from Printer2");
        }
    }
}
