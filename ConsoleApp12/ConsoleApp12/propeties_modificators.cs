using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp12
{

    class Person
    {
        private string name;

        public string Name  // вспомогательная свойство с методами
        {
            get // modificator not private
            {
                return name;
            }

            private set
            {
                name = value;
            }
        }

        private int age;
        // свойство только для записи
        public int Age // вспомогательная свойство с методами
        {
            get // not private
            {
                return age; 
            }
            private set
            {
                if (value < 18)
                {
                    age = 17;
                }
                else
                {
                    age = value;
                }
            }
        }
        // конструткор - параметры name и age присваиваются Name и Age, после вызывается метод set 
        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }
    }



    class BankAccount
    {
        public string name;
        private int sum;

        public int Sum
        {
            get
            {
                return sum;
            }

            set
            {
                if (value > 0)
                {
                    sum = value;
                }
                else
                {
                    sum = 0;
                }
            }
        }
        // конструткор с 2 входными параметрами
        public BankAccount(string name, int sum)
        {
            this.name = name;   // public instance.name равен входному параметру name 
            Sum = sum;          // public свойство Sum равно входному параметру sum
        }

    }

    class Program
        {
        static void Main()
        {
            Person Peter = new Person("Peter",777);
            // Peter.Name = "Pet";  could not do becouse method set private
            // Peter.Age = "Pet";  could not do becouse method set private

            Console.WriteLine(Peter.Name);
            Console.WriteLine(Peter.Age);

            BankAccount BankPeter = new BankAccount("Good BankPater",777);
            Console.WriteLine($"name: {BankPeter.name}\nsum: {BankPeter.Sum}");

            Console.ReadLine();
        }        
    }
}
