using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViolationSRP
{
    class Contract
    {
        private int id;
        public int Id { get { return id; } }

        private int numberContract;
        public int NumberContract { get { return numberContract; } }


        public void Agree(String name)
        {
            if (PassContract())
            {
                Console.WriteLine("Successfully");
            }else
            {
                Console.WriteLine("Unsuccessfully");
            }                   
        }

        public bool PassContract()
        {
            Console.WriteLine("Passed");
            return true;
        }
       
    }
}
