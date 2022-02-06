using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Lab
    {
        public string Name;
        public string Surname;
        public int Age;
        
        

        public Lab(string Name, string Surname, int Age)
        {
            this.Name = Name;
            this.Surname = Surname;
            this.Age = Age;
        }
        public override string ToString()
        {
            return $"{Name}\n" +
                $"{Surname}\n" +
                $"{Age}\n";
        }
    }
}
