using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tum_LAB_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
                Console.WriteLine("Упражнение 3.1 Создать перечислимый тип данных отображающий виды банковского\r\nсчета (текущий и сберегательный");
                bank_account now = bank_account.Current;
                Console.WriteLine("Банковский счет - {0}, номер - {1}", now, (int)now);

                Console.WriteLine("Упражнение 3.2 Создать структуру данных, которая хранит информацию о банковском\r\nсчете – его номер, тип и баланс");
                Bank bank = new Bank();
                bank.number = 346352;
                bank.balance = 1000000000;
                bank.type = "Current";
                bank.print();


                Console.WriteLine("Домашнее задание 3.3 Создать перечислимый тип ВУЗ{КГУ, КАИ, КХТИ}. Создать\r\nструктуру работник с двумя полями: имя, ВУЗ. Заполнить структуру данными и\r\nраспечатать.");
                ВУЗ кхти = ВУЗ.КХТИ;
                worker person = new worker();
                person.name = "Том";
                person.university = Convert.ToString(кхти);

                Console.ReadKey();
            }
            enum bank_account // к 3.1
            {
                Current,
                Saving
            }

            struct Bank // к 3.2
            {
                public int number;
                public float balance;
                public string type;
                public void print()
                {
                    Console.WriteLine($"Номер - {number}, баланс - {balance}, тип - {type}");
                }
            }
            enum ВУЗ // к 3.3
            {
                КГУ,
                КАИ,
                КХТИ
            }
            struct worker // к 3.3
            {
                public string name;
                public string university;
                public void Print()
                {
                    Console.WriteLine($"ВУЗ - {university}, имя - {name}");
                }
            }


        }




    }
