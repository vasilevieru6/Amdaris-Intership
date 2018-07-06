using System;
using System.Collections.Generic;
using System.Text;

namespace ISP_OCP_LSP
{
    class Bird
    {
        public void Fly()
        {
            Console.WriteLine("I can fly");
        }
    }

    class Sparrow : Bird
    {

    }

    class Ostrich : Bird
    {

    }
}
