using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
            static void minNumber()
            {
                int a, b, c, min;
                Console.WriteLine("Введите три числа и я найду минимальное.");
                Console.Write("Первое число: ");
                a = Convert.ToInt32(Console.ReadLine());
                Console.Write("Второе число: ");
                b = Convert.ToInt32(Console.ReadLine());
                Console.Write("Третье число: ");
                c = Convert.ToInt32(Console.ReadLine());
                if (a < b && a < c)
                {
                    min = a;
                }
                else
                {
                    if (b < c)
                        min = b;
                    else
                        min = c;
                };
                Console.WriteLine("Минимальное число: " + min);
                Console.ReadLine();

            }
            static void countNumberdigits()
            {
                Console.WriteLine("Введите число и я определю количество цифр в нём: ");
                int num = int.Parse(Console.ReadLine());
                int i = 0;
                while (num > 0)
                {
                i++;
                num /= 10;
                }
                Console.WriteLine("Количество цифр введенного числа: " + i);
                Console.ReadLine();
            }
            static void summNumber()
            {
                int sum = 0;
                int num = 0;
                do
                {
                
                Console.WriteLine("Вводите числа, для совершения подсчёта нечётных, введите 0.");
                num = int.Parse(Console.ReadLine());
                if (num > 0 && num % 2 == 1)
                sum += num;
 
                } while (num != 0);

                Console.WriteLine("Сумма введённых нечётных чисел равна: " + sum);
                Console.ReadLine();
            }
            static void loginpasswordcheck()
            {
            string login = "root";
            string password = "geekbrains";
            int count = 3;

            Console.WriteLine("У вас есть 3 попытки входа в систему.");

            do
            {
                Console.WriteLine("Введите логин: ");
                string checkLogin = Console.ReadLine();

                Console.WriteLine("Введите пароль: ");
                string checkPassword = Console.ReadLine();

                if (login == checkLogin && password == checkPassword)
                {
                    Console.WriteLine("Добро пожаловать!");
                    Console.ReadKey();
                    break;
                }
                --count;
                Console.WriteLine("Неверно введен логин или пароль, попробуйте еще раз, осталось попыток: " + count);

            } while (count > 0);
            Console.WriteLine("Для вас вход воспрещён, вы не знаете верного логина и пароля.");
            Console.ReadKey();
            }
            

        static void Main(string[] args)
            {
            ///Мамыкин
       
            ///Написать метод, возвращающий минимальное из трех чисел.
            minNumber();

            ///Написать метод подсчета количества цифр числа.
            countNumberdigits();

            ///С клавиатуры вводятся числа, пока не будет введен 0. Подсчитать сумму всех нечетных положительных чисел.
            summNumber();

            ///4.Реализовать метод проверки логина и пароля.На вход подается логин и пароль. 
            ///На выходе истина, если прошел авторизацию, и ложь, если не прошел(Логин: root, Password: GeekBrains). 
            ///Используя метод проверки логина и пароля, написать программу: пользователь вводит логин и пароль, программа пропускает его дальше или не пропускает.
            ///С помощью цикла do while ограничить ввод пароля тремя попытками.
            loginpasswordcheck();
            }

    }
}
