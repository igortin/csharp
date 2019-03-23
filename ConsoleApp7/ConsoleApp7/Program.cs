using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{

    class Person
    {
        public string name;
        public int age;


        public Person() // конструтор 1 без входных значений
        {
            name = "default name";
            age = 57;
        }




        public Person(string n)  // конструтор 2 с 1 входным значением
        {
            name = n;
            age = 77;
        }




        public Person(string n, int a)  // конструтор 3 с 2 входными значениями
        {
            name = n;
            age = a;
        }



        public void GetInfo()
            {
            Console.WriteLine($"name:{name}\nage:{age}\n");
            }
    }

    class Program
    {
        
        static void Main(string[] args)
        {
            // создания объекта Person используется выражение new Person().Оператор new выделяет память для объекта Person. Выполнится конструтор в зависимости от количества входных параметров. 

            // конструктор 1
            Person Peter = new Person();
            Peter.GetInfo(); 

            // конструктор 2
            Person Tom = new Person("Tom");
            Tom.GetInfo();

            // конструктор 3
            Person Pet = new Person("Pet", 777);
            Pet.GetInfo();




            Console.ReadLine();
        }
    }
}
