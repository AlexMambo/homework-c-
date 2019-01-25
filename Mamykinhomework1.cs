using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            ///Мамыкин
            ///1. Написать программу «Анкета». Последовательно задаются вопросы (имя, фамилия, возраст, рост, вес). В результате вся информация выводится в одну строчку.
            ///а) используя склеивание;
            Console.WriteLine("Вас приветствует Анкета!");
            Console.WriteLine("Пожалуйста, введите ваше имя:");
            var Name = Console.ReadLine();
            Console.WriteLine("Пожалуйста, введите вашу фамилию:");
            var Name1 = Console.ReadLine();
            Console.WriteLine("Пожалуйста, введите ваш возраст:");
            var Name2 = Console.ReadLine();
            Console.WriteLine("Пожалуйста, введите ваш рост:");
            var Name3 = Console.ReadLine();
            Console.WriteLine("Пожалуйста, введите ваш вес:");
            var Name4 = Console.ReadLine();
            Console.WriteLine("Информация о вас: " + "Имя: " + Name + " Фамилия: " + Name1 + " Возраст: " + Name2 + " Рост: " + Name3 + " Вес: " + Name4);
            Console.ReadKey();

            ///2. Ввести вес и рост человека. Рассчитать и вывести индекс массы тела (ИМТ) по формуле I=m/(h*h); где m — масса тела в килограммах, h — рост в метрах
            Console.WriteLine("");
            Console.WriteLine("Вас приветствует калькулятор индекса массы тела!");
            Console.WriteLine("Пожалуйста, введите ваш вес:");
            var Weight = int.Parse(Console.ReadLine());
            Console.WriteLine("Пожалуйста, введите ваш рост:");
            var Height =  int.Parse(Console.ReadLine());
            var i = Weight / (Height*Height); 
            Console.WriteLine("Индекс массы вашего тела составляет: " + i);
            Console.ReadKey();
            
            ///3.
            ///а) Написать программу, которая подсчитывает расстояние между точками с координатами x1, y1 и x2,y2 по формуле r=Math.Sqrt(Math.Pow(x2-x1,2)+Math.Pow(y2-y1,2). 
            ///Вывести результат, используя спецификатор формата .2f (с двумя знаками после запятой);
            Console.WriteLine("");
            Console.WriteLine("Вас приветствует измеритель расстояния между точками!");
            Console.WriteLine("Введите координаты точки 1 по оси X: ");
            var x1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите координаты точки 1 по оси Y: ");
            var y1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите координаты точки 2 по оси X: ");
            var x2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите координаты точки 2 по оси Y: ");
            var y2 = int.Parse(Console.ReadLine());
            var r = Math.Sqrt(Math.Pow(x2 - x1,2) + Math.Pow(y2 - y1,2));
            Console.WriteLine("Расстояние между точками 1 и 2 составляет: {0:F2}", r);
            Console.ReadKey();
        }
    }
}
