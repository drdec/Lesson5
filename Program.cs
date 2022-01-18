using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

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
                Console.WriteLine("Введите количество чисел, которое вы хотите ввести");
                int n = Convert.ToInt32(Console.ReadLine());

                string arrayNumer = "";

                for (int i = 0; i < n; i++)
                {
                    int tempNumber = Convert.ToInt32(Console.ReadLine());

                    if (tempNumber >= 0 && tempNumber <= 255)
                    {
                        arrayNumer += tempNumber + " ";
                    }
                    else
                    {
                        Console.WriteLine("Вы вышли за диапозон знначений, пожалуйста, проверьте правильность ввода");
                        i--;
                    }
                }

                BinaryFormatter formatter = new();

                formatter.Serialize(new FileStream("numbers.bin", FileMode.OpenOrCreate), arrayNumer);

                Console.WriteLine("Запись в файл была успешно проведена");
            }
        }
    }
}