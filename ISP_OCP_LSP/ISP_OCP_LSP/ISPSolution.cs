using System;
using System.Collections.Generic;
using System.Text;

namespace ISP_OCP_LSP
{
    interface IActionsStudent
    {
        void Study();
    }

    interface IActionsEmployee
    {
        void Work();
        void SignContract();
    }

    class Student1 : IActionsStudent
    {
        public void Study()
        {
            Console.WriteLine("Studying...");
        }
    }

    class Employee1 : IActionsEmployee
    {
        public void SignContract()
        {
            Console.WriteLine("Sign Contract");
        }

        public void Work()
        {
            Console.WriteLine("Working");
        }
    }
}
