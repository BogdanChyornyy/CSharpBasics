using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson_1_enter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите имя пользователя: ");
            string name = Console.ReadLine();
            Console.Write("Введите текущую дату: ");
            string date = Console.ReadLine();
            Console.WriteLine("Привет, " + name + ", сегодня " + date + ".");
        }
    }
}
