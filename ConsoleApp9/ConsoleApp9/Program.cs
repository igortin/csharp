using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9
{
    // В отличае от класса свойства не могут про инициализированны в структуре. Находится в стеке в памяти и хранит значение - "Значение" тип.
    struct Student
    {
        public string name;
        public int age;

        public Student(string name, int age)
            {
            this.name = name;
            this.age = age;
            }

        public void View()
        {
            Console.WriteLine($"name: {name}\nage: {age}\n");

        }

    }


    class Program
    {
        static void Main(string[] args)
        {
            Student Tom = new Student("Tom", 777);
            Tom.View();

        }
    }
}
