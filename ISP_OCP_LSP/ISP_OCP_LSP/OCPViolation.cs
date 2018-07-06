using System;
using System.Collections.Generic;
using System.Text;

namespace ISP_OCP_LSP
{ 
    class Client 
    {
        public static void Main(String[] args)
        {
            Printer1 p = new Printer1();
            p.PrintMessage();
        }                
    }

    class Printer1 
    {
        public void PrintMessage()
        {
            Console.WriteLine("Print from Printer1 class");
        }
    }

    //To create another Printer class we need to modify the Client class by create a new instance of a new Printer class created for using his methods 
                                                                                                                                  //which means that violate OCP principle
    //The solution is to create a abstract class Printer 


}
