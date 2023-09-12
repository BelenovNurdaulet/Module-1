using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Exmpl05() {
            Console.WriteLine("ФИО пользователя:");
            string name = Console.ReadLine();
            Console.WriteLine("Добро пожаловать {0}" , name);
            Console.ReadKey(true);
        }
        static void Exmpl06()
        {
            Console.WriteLine("Введите 3 числа: ");
            string string01 = Console.ReadLine(); 
            int int01 = Int32.Parse(string01);
            string string02 = Console.ReadLine(); 
            int int02 = Int32.Parse(string02);
            string string03 = Console.ReadLine(); 
            int int03 = Int32.Parse(string03);
            
            Console.WriteLine("Сумма чисел {0}" , int01 + int02 + int03);
            Console.ReadKey(true);
        }

        static void Main(string[] args)
    {
        Exmpl05();
    }

}

}


