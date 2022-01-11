using System;
using System.IO;

namespace HomeWork
{
    class Program
    {
        static void Main()
        {
            goto tempVariable;

            Console.WriteLine("Задание 1");
            {
                Console.WriteLine("Введите любую строку");
                string userText = Console.ReadLine();

                File.WriteAllText("readme.txt", userText);
                Console.WriteLine();
                Console.WriteLine("Текс записан в файл readme.txt");
            }

            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("Задание 2");
            {
                Console.WriteLine("Дописываем дату в файл с первым заданием!");

                DateTime dateTime = DateTime.Now;

                File.AppendAllText("readme.txt", Environment.NewLine);
                File.AppendAllText("readme.txt", dateTime.ToString());
            }

            Console.WriteLine();
            Console.WriteLine();
        tempVariable:

            Console.WriteLine("Задание 3");
            {
                bool cz = true;
                int n = 0;

                while (cz)
                {
                    Console.WriteLine("Введите количесво чисел, которое вы хотите ввести");
                    n = Convert.ToInt32(Console.ReadLine());

                    if (n >= 0)
                    {
                        cz = false;
                    }
                    else
                    {
                        Console.WriteLine("Количество чисел должно быть больше нуля.");
                    }
                }

                byte[] userData = new byte[n];

                Console.WriteLine("Пожалуйста, введите числа от 0 до 255");

                for (int i = 0; i < userData.Length; i++)
                {
                    int tempNumber = Convert.ToInt32(Console.ReadLine());

                    if (tempNumber > 0 && tempNumber < 256)
                    {
                        userData[i] = (byte)tempNumber;
                    }
                    else
                    {
                        Console.WriteLine("пожалуйста, проверьте диапазон чисел и ваше число, после повторите попытку.");
                        i--;
                    }
                }

                for (int i = 0; i < userData.Length; i++)
                {
                    Console.Write(userData[i] + " ");
                }

                File.WriteAllBytes("readme.bin", userData);
            }
        }
    }
}