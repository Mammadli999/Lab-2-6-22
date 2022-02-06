using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            New Person1 = new New("Abbas","Mammadli",22,0518311881);
            New Person2 = new New("Samid","Samadade",22,0556240937);
            New Person3 = new New("Eli","Mammadeov",20,0553597652);

            New[] people = new New[3];

            people[0] = Person1;
            people[1] = Person2;
            people[2] = Person3;

            foreach (var person in people )
            {
                Console.WriteLine(person);
            }
        }
    }
}
