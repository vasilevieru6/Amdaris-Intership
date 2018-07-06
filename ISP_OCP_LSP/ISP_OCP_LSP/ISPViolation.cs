using System;
using System.Collections.Generic;
using System.Text;

namespace ISP_OCP_LSP
{
       interface IActionsToDo
    {
        void SignContract();
        void Study();
        void Work();        
    }

    class Student : IActionsToDo
    {
        public void SignContract()
        {
            throw new NotImplementedException();
        }

        public void Study()
        {
            Console.WriteLine("Studying...");
        }

        public void Work()
        {
            throw new NotImplementedException();
        }
    }

    class Employee : IActionsToDo
    {
        public void SignContract()
        {
            Console.WriteLine("Signed");
        }

        public void Study()
        {
            throw new NotImplementedException();
        }

        public void Work()
        {
            Console.WriteLine("Working...");
        }
    }
}
