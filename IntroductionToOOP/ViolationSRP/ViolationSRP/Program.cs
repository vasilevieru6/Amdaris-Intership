using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViolationSRP
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }

    class Student
    {
        private int id;
        public int Id { get { return id; } }
        private string name;
        public string Name { get { return name; } }
        private int knowledge;
        public int Knowledge { get { return knowledge; } }
        private int experience;
        public int Experience { get { return experience; } }
    

        public Student() { }

        public Student(int id, string name, int knowledge, int experience)
        {
            this.id = id;
            this.name = name;
            this.knowledge = knowledge;
            this.experience = experience;
        }

        public void Study()
        {
            knowledge++;
        }

        public void work()
        {
            experience++;
        }

        public void Sign(Contract contract)
        {
            contract.Agree(name);
        }
    }
}
