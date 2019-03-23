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

        // слово this представляет ссылку на текущий экземпляр  - self at python,
        public Person() : this("unkown") // конструктор 1,  так как this - 1 входное значение ( вызываем текущий экземпляр c входным занчением "uknouwn", тоетсь Person Peter = new Person("uknown") ), сначала запускается конструктор 2 - Person(string name)
        {
        }
       



        public Person(string name) : this(name, 77)  // конструтор 2 с 1 входным значением,  так как this - 2 входных значения ( вызываем текущий экземпляр c входным занчением "name" и 77, тоетсь Person Peter = new Person("Peter",77) ), запускается конструктор 3
        {
        }




        public Person(string name, int age)  // конструтор 3 с 2 входными значениями, вызываем текущий экземпляр c входным занчением "name" и 77, тоетсь Person Peter = new Person("Peter",77)
        {
            this.name = name;
            this.age = age;
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
