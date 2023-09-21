using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tum_LAB_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
                Console.WriteLine("Задание 2.1. Написать программу, которая спрашивает имя пользователя, и затем\r\nприветствует пользователя по имени");
                Console.WriteLine("Как тебя зовут?");
                string name = Console.ReadLine();
                Console.WriteLine("Привет, " + name);

                Console.WriteLine("Упражнение 2.2 Написать программу, которой на вход подается два целых числа, на\r\nвыходе – результат деления одного числа на другое.");
                Console.WriteLine("Введите два целых числа, чтобы выполнить деление a/b:");
                try
                {
                    double a = Int32.Parse(Console.ReadLine());
                    double b = Int32.Parse(Console.ReadLine());
                    double c = a / b;
                    Console.WriteLine("Ответ: " + c);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }

                Console.WriteLine("Домашнее задание 2.1 Прочитать букву с экрана и вывести на печать следующую за ней букву в алфавитном порядке.");
                Console.WriteLine("Введите букву: ");
                char next;
                char letter = Convert.ToChar(Console.ReadLine());

                if (letter == 'я')
                    next = 'а';
                else if (letter == 'Я')
                    next = 'А';

                else
                    next = (char)(((int)letter) + 1); // +1 к юникоду символа
                Console.WriteLine(next);

                Console.WriteLine("Домашнее задание 2.2 Написать программу, которая решает квадратное уравнение.");
                Console.WriteLine("Введите коэффиценты a,b,c кв. уравнения");
                double A = Convert.ToDouble(Console.ReadLine());
                double B = Convert.ToDouble(Console.ReadLine());
                double C = Convert.ToDouble(Console.ReadLine());
                double sqrtD = Math.Sqrt(B * B - 4 * A * C);
                if (sqrtD > 0)
                {
                    Console.WriteLine($"Ответ: x1 = {(-B - sqrtD) / (2 * A)}, x2 = {(-B + sqrtD) / (2 * A)}");
                }
                else if (sqrtD == 0)
                {
                    Console.WriteLine($"Ответ: x = {-B / (2 * A)}");
                }
                else
                {
                    Console.WriteLine("Нет действительных корней");
                }
                Console.WriteLine();

                Console.ReadLine();
            }
        }
    }

