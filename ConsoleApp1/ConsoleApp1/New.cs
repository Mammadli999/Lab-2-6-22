using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class New
    {
        public int Id;
        public string Name;
        public string Surname;
        public int Age;
        public int PhoneNumber;
        public static int Counter = 0;

        static New()
        {
            Console.WriteLine("Program is Running");
        }

        public New(string Name, string Surname, int Age, int PhoneNumber)
        {
            Counter++;
            Id = Counter;
            this.Name = Name;
            this.Surname = Surname;
            this.Age = Age;
            this.PhoneNumber = PhoneNumber;

        }

        public override string ToString()
        {
            return $"Id:{Id}\n"+
                $"Ad:{Name}\n" +
                $"Soyad:{Surname}\n" +
                $"Yash:{Age}\n" +
                $"TelefonNomre:{PhoneNumber}\n";
        }
    }
}

