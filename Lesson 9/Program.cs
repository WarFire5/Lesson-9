using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Программа 1

            Console.WriteLine("Введите целое число:");
            int number = Convert.ToInt32(Console.ReadLine());

            if (number > 0 && number < 10)
            {
                Console.WriteLine("Число принадлежит диапазону от 0 до 10.");
            }

            else if (number > 20 && number < 30)
            {
                Console.WriteLine("Число принадлежит диапазону от 20 до 30.");
            }

            else if (number > 40 && number < 50)
            {
                Console.WriteLine("Число принадлежит диапазону от 40 до 50.");
            }

            else //Если пользователь вводит число непринадлежащее обозначенным диапазонам.
            {
                Console.WriteLine("Введите другое число.");
            }

            Console.ReadLine();



            //Программа 2

            Console.WriteLine("Введите три целых числа:");

            int n1, n2, n3;
            n1 = Convert.ToInt32(Console.ReadLine());
            n2 = Convert.ToInt32(Console.ReadLine());
            n3 = Convert.ToInt32(Console.ReadLine());

            int sum1, sum2, sum3;
            sum1 = n1 + n2;
            sum2 = n1 + n3;
            sum3 = n2 + n3;

            if (sum1 > n3 && sum2 > n2 && sum3 > n1)
            {
                Console.WriteLine("Подходящая комбинация чисел.");
            }

            else //Если сумма любых двух чисел из комбинации не больше оставшегося третьего числа.
            {
                Console.WriteLine("Неподходящая комбинацияа чисел.");
            }

            Console.ReadLine();



            //Программа 3

            Console.WriteLine("Введите три целых числа:");

            int a1, a2, a3;
            a1 = Convert.ToInt32(Console.ReadLine());
            a2 = Convert.ToInt32(Console.ReadLine());
            a3 = Convert.ToInt32(Console.ReadLine());

            if ((a1 != a2) && (a1 != a3) && (a2 != a3))
            {
                if (a1 > a2 && a1 > a3)
                {
                    if (a2 > a3)
                    {
                        Console.WriteLine(a1 + "," + " " + a2 + "," + " " + a3 + ".");
                    }
                    else
                    {
                    Console.WriteLine(a1 + "," + " " + a3 + "," + " " + a2 + ".");
                    }
                }
                

                if (a2 > a1 && a2 > a3)
                {
                    if (a1 > a3)
                    {
                        Console.WriteLine(a2 + "," + " " + a1 + "," + " " + a3 + ".");
                    }
                    else
                    {
                        Console.WriteLine(a2 + "," + " " + a3 + "," + " " + a1 + ".");
                    }
                }                

                if (a3 > a1 && a3 > a2)
                {
                    if (a1 > a2)
                    {
                        Console.WriteLine(a3 + "," + " " + a1 + "," + " " + a2 + ".");
                    }
                    else
                    {
                    Console.WriteLine(a3 + "," + " " + a2 + "," + " " + a1 + ".");
                    }
                }                
            }

            else //Если пользователь вводит два или три одинаковых числа.
            {
                Console.WriteLine("Попробуйте другую комбинацию.");
            }

            Console.ReadLine();
        }
    }
}
