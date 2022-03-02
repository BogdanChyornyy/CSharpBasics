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
            /*
            
            1. Запросить у пользователя минимальную и максимальную температуру за сутки и вывести среднесуточную температуру.

            float mintemp, maxtemp;

            Console.WriteLine("Сбор данных о среднесуточной температуре.");

            Console.WriteLine("Введите минимальную температуру за день ");
            
            mintemp = float.Parse(Console.ReadLine());

            Console.WriteLine("Введите максимальную температуру за день ");

            maxtemp = float.Parse(Console.ReadLine());

            float avertemp = (mintemp + maxtemp) / 2;

            Console.WriteLine("Среденесуточная температура: " + avertemp);
            */

            /*
            
            2. Запросить у пользователя порядковый номер текущего месяца и вывести его название.

            string[] month = { "Январь", "Февраль", "Март", "Апрель", "Май", "Июнь", "Июль", "Август", "Сентябрь", "Октябрь", "Ноябрь", "Декабрь" };
            
            Console.WriteLine("Введите порядековый номер месяца (от 1 до 12): ");

            int indexmont = int.Parse(Console.ReadLine());

            if (indexmont < 1 || indexmont > 12) { 
                Console.WriteLine("Некоректный ввод данных!");
                Console.WriteLine("Введите порядековый номер месяца: ");
                indexmont = int.Parse(Console.ReadLine());
                int realmonth = indexmont -= 1;
                Console.WriteLine(month[realmonth]);
            }
            else
            {
                int realmonth = indexmont -= 1;
                Console.WriteLine(month[realmonth]);
            }
            */

            /*
            Console.WriteLine("Введите число для проверки на четность: ");

            int number = int.Parse(Console.ReadLine());

            int divis = number % 2;
            if (divis == 0)
            {
                Console.WriteLine("Число " + number + " - четное.");
            }
            else
            {
                Console.WriteLine("Число " + number + " - не четное.");
            }
            */

            string name_of_owner = "ИП Чёрный Б.К.";
            string defolt = "Кассовый чек";
            string IE = "ИП ЧЁРНЫЙ БОГДАН КОНСТАНТИНОВИЧ";
            string cashier = "Иванов И.И.";
            string location = "Калининградская обл. г. Калининград ул. Нарвская д. 12.";
            string place = "Кофейня";

            Console.WriteLine("Укажите номер товара: ");
            Console.WriteLine("1. Капучино 100р");
            Console.WriteLine("2. Латте 100р");
            Console.WriteLine("3. Эспрессо 80р");
            string[] choice = {"Капучино", "Латте", "Эспрессо"};
            
            int coffee_number = int.Parse(Console.ReadLine());
            int real_number = coffee_number -= 1;

            int[] coffee_price = {100,100,80};
            int coffee_price_numder = real_number;

            Console.WriteLine("Сколько чашек кофе вы желаете?");
            int quontity_coffee = int.Parse(Console.ReadLine());

            Console.WriteLine("Сколько пакетиков сахара добавить?");
            Console.WriteLine("Один пакетик сахара 5р.");
            int sugar = int.Parse(Console.ReadLine());
            int sugar_price = 5;

            int type = real_number;
            int total = sugar * sugar_price + quontity_coffee * coffee_price[coffee_price_numder];

            Console.WriteLine(name_of_owner);
            Console.WriteLine(defolt);
            Console.WriteLine(choice[type] + " *" + quontity_coffee + " =" + quontity_coffee*coffee_price[coffee_price_numder]);
            Console.WriteLine("НДС не облагается");
            Console.WriteLine("Сахар " + " *" + sugar + " =" + sugar*sugar_price);
            Console.WriteLine("НДС не облагается");
            Console.WriteLine("------------------------");
            Console.WriteLine("ИТОГ " + " =" + total);
            Console.WriteLine("------------------------");
            Console.WriteLine("СУММА БЕЗ НДС " + " =" + total);
            Console.WriteLine("Кассир " + cashier);
            Console.WriteLine(IE);
            Console.WriteLine(location);
            Console.WriteLine("Место расчетов " + place);

        }
    }
}
