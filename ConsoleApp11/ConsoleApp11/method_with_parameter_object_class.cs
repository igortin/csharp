using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp11
{
    class Program
    {

        static void ChangePerson(Person person)
        {
            // сработает
            person.name = "Tim";
            person.age = 77;
            Console.WriteLine(person.name); // Bill
            Console.WriteLine(person.age); // 77
            Console.WriteLine(person.GetHashCode());

            // ChangePerson(Person person) сработает только в рамках данного метода, новый объект в памяти
            // ChangePerson(ref Person person) ссылка на объект в памяти
            person = new Person();
            person.name = "Bill";
            person.age = 777;
            
            Console.WriteLine(person.name);
            Console.WriteLine(person.age);
            Console.WriteLine(person.GetHashCode());

        }


        static void Main(string[] args)
        {
            Person p = new Person();
            p.name = "Tom";
            p.age = 23;

            Console.WriteLine(p.name); // Tom
            Console.WriteLine(p.age); // 23
            Console.WriteLine(p.GetHashCode());

            ChangePerson(p);
            Console.WriteLine(p.name); // Tim
            Console.WriteLine(p.age); // 77
            Console.WriteLine(p.GetHashCode());
/*
            ChangePerson(ref p);
            Console.WriteLine(p.name); // Bill
            Console.WriteLine(p.age); // 777
            Console.WriteLine(p.GetHashCode());
*/


            Console.Read();
        }

    }
    class Person
    {
        public string name;
        public int age;
    }
}
