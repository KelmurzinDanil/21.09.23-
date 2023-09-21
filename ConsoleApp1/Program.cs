using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
                Console.WriteLine("1. Выведите на экран информацию о каждом типе данных в виде:\r\nТип данных – максимальное значение – минимальное значение");
                Console.WriteLine($"byte: {byte.MinValue} - {byte.MaxValue}");
                Console.WriteLine($"sbyte: {sbyte.MinValue} - {sbyte.MaxValue}");
                Console.WriteLine($"short: {short.MinValue} - {short.MaxValue}");
                Console.WriteLine($"ushort {ushort.MinValue} - {ushort.MaxValue}");
                Console.WriteLine($"int: {int.MinValue} - {int.MaxValue}");
                Console.WriteLine($"uint: {uint.MinValue} - {uint.MaxValue}");
                Console.WriteLine($"long: {long.MinValue} - {long.MaxValue}");
                Console.WriteLine($"ulong: {ulong.MinValue} - {ulong.MaxValue}");

                Console.WriteLine("2. Напишите программу, в которой принимаются данные пользователя в виде имени,\r\nгорода, возраста и PIN-кода. Далее сохраните все значение в соответствующей\r\nпеременной, а затем распечатайте всю информацию в правильном формате");

                Console.Write("Как тебя зовут? ");
                string name = Console.ReadLine();
                Console.Write($"Привет {name}. Сколько тебе лет? ");
                int age = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("В каком городе ты живешь?");
                string city = Console.ReadLine();
                Console.WriteLine("Ваш PIN-код:");
                int PIN = Convert.ToInt32(Console.ReadLine());
                (string, int, string, int) Person_N_1 = (name, age, city, PIN);
                Console.Write($"Мы сохранили ваши данные: {Person_N_1}");

                Console.WriteLine();

                Console.WriteLine("3.Преобразуйте входную строку: строчные буквы замените на заглавные, заглавные – на строчные.");
                Console.WriteLine("Введите любое слово: ");
                string word = Console.ReadLine();
                string val = "";
                foreach (var ch in word) // цикл foreach пробегается по всем символам строки      
                {
                    if (char.IsLower(ch))
                        val += char.ToUpper(ch);
                    else
                        val += char.ToLower(ch);

                }
                Console.WriteLine(val);

                Console.WriteLine("4. Введите строку, введите подстроку. Необходимо найти количество вхождений и вывести на экран.");
                Console.WriteLine("Введите строку и подстроку: ");
                string line1 = Console.ReadLine();
                string line2 = Console.ReadLine();
                int n = (line1.Length - line1.Replace(line2, "").Length) / line2.Length; // Length - число знаков в текущем объекте, Replace - заменяет одни данные на другие
                Console.WriteLine(n);

                Console.WriteLine("5. Цель этой задачи - определить, сколько бутылок виски беспошлинной торговли вам\r\nнужно будет купить, чтобы экономия по сравнению с обычной средней ценой фактически\r\nпокрыла расходы на ваш отпуск.");
                Console.WriteLine("Введите стандартную цену бутылки, скидку в % и стоимасть вашего отпуска(в таком же порядке числа должны быть целые):");
                try
                {
                    double normPrice = Int32.Parse(Console.ReadLine());
                    double salePrice = Int32.Parse(Console.ReadLine());
                    double holidayPrice = Int32.Parse(Console.ReadLine());
                    double equantity = Math.Round(holidayPrice / (normPrice - normPrice * (1 - salePrice / 100)), 0);
                    Console.WriteLine(equantity);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }

                Console.WriteLine("6. Воспроизвести разговор Гарри Поттера и дневника Тома Реддла.");
                Console.BackgroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine("Пишите только те вопросы, которые были при их разговоре ");
                Console.BackgroundColor = ConsoleColor.Black;
                Thread.Sleep(2000);
                Console.WriteLine("Дневник Тома Реддла: Как тебя зовут?");
                string Name = Console.ReadLine();
                Console.WriteLine("Дневник Тома Реддла: Привет " + Name);
                string a = Console.ReadLine();
                Console.WriteLine(Name + ":" + a);
                Console.WriteLine("Дневник Тома Реддла: Да");
                string b = Console.ReadLine();
                Console.WriteLine(Name + ":" + b);
                Console.WriteLine("Нет");
                Thread.Sleep(5000);
                Console.BackgroundColor = ConsoleColor.DarkRed;
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.WriteLine("Но могу показать");
                Console.BackgroundColor = ConsoleColor.Black;

                Console.WriteLine("7. Вычислить контрольную цифру штрихкода (EAN13).");
                Console.WriteLine("Введите штрихкод(через каждую цифру нажимайте Enter): ");
                int[] array = new int[12];
                for (int i = 0; i < array.Length; i++)
                    array[i] = int.Parse(Console.ReadLine());

                int parity = 0;
                for (int i = 0; i < array.Length; i++)
                {
                    if (i % 2 == 0)
                    {
                        parity += array[i];

                    }
                }

                int odd = 0;
                for (int i = 0; i < array.Length; i++)
                {
                    if (i % 2 != 0)
                    {
                        odd += array[i];

                    }
                }
                int sum = parity * 3 + odd;
                int control = (sum - sum % 10 + 10) - sum;
                Console.WriteLine("контрольная цифра:" + control);

                Console.WriteLine("Для рандомных чисел ");

                int[] array1 = new int[12];
                Random rand = new Random();
                for (int i = 0; i < array.Length; i++)
                    array1[i] = rand.Next(10);

                int parity1 = 0;
                for (int i = 0; i < array1.Length; i++)
                {
                    if (i % 2 == 0)
                    {
                        parity1 += array1[i];

                    }
                }

                int odd1 = 0;
                for (int i = 0; i < array1.Length; i++)
                {
                    if (i % 2 != 0)
                    {
                        odd1 += array1[i];

                    }
                }
                int sum1 = parity1 * 3 + odd1;
                int control1 = (sum1 - sum1 % 10 + 10) - sum1;
                Console.WriteLine("контрольная цифра:" + control1);



                Console.ReadLine();
            }
        }
    }

