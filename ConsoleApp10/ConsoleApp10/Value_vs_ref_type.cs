using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp10
{
    class Program
    {
        private static void Main(string[] args)
        {
            State state1 = new State(); // структура 1
            State state2 = new State(); // струткура 2

            state2.country = new Country(); // инциализируем свойства структуры тип класса Country, важно что класс "ref" тип 
            state2.country.x = 5;
            state2.x = 7;


            state1 = state2; // state1  копия  state2 , важно state1.country.x ссылается на тоже объект в heap что и state2.country.x , state1.x копирует значение state2.x (не ссылается)


            state2.x = 777;
            state2.country.x = 1777; // получаем state2.country.x=1777 теперь и state1.country.x=1777, так как state1.country и state2.country
                                    // указывают на один объект в хипе


            Console.WriteLine(state1.x); // 7
            Console.WriteLine(state2.x); // 777
            Console.WriteLine(state2.country.x); // 1777
            Console.WriteLine(state2.country.x); // 1777
            Console.Read();
        }
    }
    struct State   // струткуры относяться к "Value" тип в стеке
    {
        public int x;
        public int y;
        public Country country;  // переменная типа Class Country (класс "ref" тип), в стеке указатель на объект в Heap-е 
    }
    class Country
    {
        public int x;
        public int y;
    }
}
