using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 1, key = 1;


            Console.WriteLine("Введите слово,которое нужно зашифровать:");
            string s = Console.ReadLine();
            Console.WriteLine("Введите слово,которое нужно дешифровать:");
            string z = Console.ReadLine();

            Console.WriteLine("Введите ключ:");
            key = Convert.ToInt32(Console.ReadLine());

            string s1 = "";
            string z1 = "";

            string alfphabet = "абвгдежзийклмнопрстуфхцчшщъыьэюя";

            int m = alfphabet.Length;

            for (int i = 0; i < s.Length; i++)
            {
                for (int j = 0; j < alfphabet.Length; j++)
                {
                    if (s[i] == alfphabet[j])
                    {
                        int temp = j * n + key;

                        while (temp >= m)
                            temp -= m;

                        s1 = s1 + alfphabet[temp];
                    }
                }

            }
            Console.WriteLine("Зашифрованное слово:" + s1);


            for (int i = 0; i < z.Length; i++)
            {
                for (int j = 0; j < alfphabet.Length; j++)
                {
                    if (z[i] == alfphabet[j])
                    {
                        int temp = j * n - key;

                        while (temp < 0)
                            temp += m;

                        z1 = z1 + alfphabet[temp];
                    }
                }

            }

            Console.WriteLine("Дешифрованное слово:" + z1);
            Console.ReadLine();
        }
    }
}