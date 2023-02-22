using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestAndProgram
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите первое число: ");
            int a = 0;
            while (true)
            {
                try
                {
                    a = Convert.ToInt32(Console.ReadLine());
                    break;
                }
                catch
                {
                    Console.Write("Что-то пошло не так..\nПовторите ввод: ");
                }
            }
            Console.Write("Введите второе число: ");
            int b = 0;
            while (true)
            {
                try
                {
                    b = Convert.ToInt32(Console.ReadLine());
                    break;
                }
                catch
                {
                    Console.Write("Что-то пошло не так..\nПовторите ввод: ");
                }
            }
            Console.Write("Выберите действие:\n1.Сумма\n2.Разность\n3.Умножение\n4.Деление\nОтвет: ");
            int otv = 0;
            while (true)
            {
                try
                {
                    otv = Convert.ToInt32(Console.ReadLine());
                    break;
                }
                catch
                {
                    Console.Write("Что-то пошло не так..\nПовторите ввод: ");
                }
            }
            switch (otv)
            {
                case 1:
                    Console.WriteLine("Результат: " + Summa(a, b));
                    break;
                case 2:
                    Console.WriteLine("Результат: " + Difference(a, b));
                    break;
                case 3:
                    Console.WriteLine("Результат: " + Multiplication(a, b));
                    break;
                case 4:
                    Console.WriteLine("Результат: " + Division(a, b));
                    break;
                default:
                    Console.WriteLine("Такого варианта не существует..");
                    break;
            }
        }
        public static int Summa(int x, int y)
        {
            return x + y;
        }

        public static int Difference(int x, int y)
        {
            return x - y;
        }

        public static int Multiplication(int x, int y)
        {
            return x * y;
        }

        public static double Division(int x, int y)
        {
            return x / y;
        }

    }
}
