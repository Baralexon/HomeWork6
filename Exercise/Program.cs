using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise
{
    internal class Program
    {
        /// <summary>
        /// Задание: справочник «Сотрудники»
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            Console.WriteLine("Если хотите посмотреть список сотрудников нажмите - 1\nЕсли хотите заполнить список сотрудников нажмите - 2");
            string N = Console.ReadLine();// выбор номера метода
            switch (N)
            {
            case "1": ShowList();
                break;
            case "2": FillList();
                break;
                default:
                    Console.WriteLine("Введено неверно");
                    break;
            }
            //Console.WriteLine("Hi, I am here!");
            //DateTime date = new DateTime(2022, 06, 20);
            //Console.WriteLine((DateTime.Now.Subtract(date).TotalDays));
            //Console.WriteLine(Math.Abs(-25));
            Console.ReadKey();
        }

        /// <summary>
        /// Метод вывода на экран списка сотрудников из файла  
        /// </summary>
        /// <param name="args"></param>
        static void ShowList()
        {
            string text = File.ReadAllText(@"c:\Users\Александр\source\repos\HomeWork6\employees.txt");
            string[] lines = text.Split('#');
                        
            foreach (string line in lines)  Console.Write($"{line} ");
            
        }

        /// <summary>
        /// Метод заполнения списка сотрудников
        /// </summary>
        /// <param name="TEXT"></param>
        /// <returns></returns>
        static void FillList()
        {
            int count = 1;

            do
            {
                //string note = string.Empty;
                Console.Write("Введите Ф.И.О. сотрудника: ");
                string Name = Console.ReadLine();
                Console.Write("Введите возраст сотрудника: ");
                string age = Console.ReadLine();
                Console.Write("Введите рост сотрудника (в см): ");
                string height = Console.ReadLine();
                Console.Write("Введите год рождения сотрудника (в см): ");
                int year = Convert.ToInt32(Console.ReadLine());
                Console.Write("Введите месяц рождения сотрудника: ");
                int month = Convert.ToInt32(Console.ReadLine());
                Console.Write("Введите день рождения сотрудника: ");
                int day = Convert.ToInt32(Console.ReadLine());
                DateTime birthday = new DateTime(year, month, day);
                Console.Write("Введите место рождения сотрудника: ");
                string birthplace = Console.ReadLine();

                string TEXT = $"{count}#{DateTime.Now}#{Name}#{age}#{height}#{birthday.ToShortDateString()}#{birthplace}";
                File.AppendAllText(@"c:\Users\Александр\source\repos\HomeWork6\employees.txt", TEXT);
                count++;

            } while (Console.ReadKey(true).Key == ConsoleKey.Escape);
             
            
        }
    
    }
}
