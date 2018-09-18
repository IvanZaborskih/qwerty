using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyLib;

namespace _1._1._12_консоль_
{
    class CulcConsole
    {
        static int Input()
        {
            bool b;
            int znach = 0;
            do
            {
                try
                {
                    znach = Convert.ToInt32(Console.ReadLine());
                    if (znach == 0)
                    {
                        Console.WriteLine("Введите число отличное от нуля");
                        b = false;
                    }
                    else
                        b = true;
                }
                catch
                {
                    Console.WriteLine("Введите число");
                    b = false;
                }
            } while (b == false);
            return znach;
        }
        
        static void Sum(int sumNum, int sumDen)
        {
            Console.WriteLine("Результат: ");
            Console.WriteLine(sumNum);
            Console.WriteLine("--");
            Console.WriteLine(sumDen);
        }

        static void Sub(int subNum, int subDen)
        {
            Console.WriteLine("Результат: ");
            Console.WriteLine(subNum);
            Console.WriteLine("--");
            Console.WriteLine(subDen);
        }

        static void Mult(int multNum, int multDen)
        {
            Console.WriteLine("Результат: ");
            Console.WriteLine(multNum);
            Console.WriteLine("--");
            Console.WriteLine(multDen);
        }

        static void Div(int divNum, int divDen)
        {
            Console.WriteLine("Результат: ");
            Console.WriteLine(divNum);
            Console.WriteLine("--");
            Console.WriteLine(divDen);
        }

        static void Main(string[] args)
        {
            int prov = 0;
            do
            {
                Console.WriteLine("Введите первую дробь:");
                int xNum = Input();
                Console.WriteLine("--");
                int xDen = Input();
                Console.WriteLine("Введите вторую дробь:");
                int yNum = Input();
                Console.WriteLine("--");
                int yDen = Input();
                Number wr = new Number(xNum, xDen, yNum, yDen);

                Console.Write("Введите операцию(+,-,*,/): ");
                char znak = Convert.ToChar(Console.ReadLine());
                if (znak == '+')
                    Sum(wr.SumNum(), wr.SumDen());
                if (znak == '-')
                    Sub(wr.SubNum(), wr.SubDen());
                if (znak == '*')
                    Mult(wr.MultNum(), wr.MultDen());
                if (znak == '/')
                    Div(wr.DivNum(), wr.DivDen());
                Console.WriteLine();
                Console.WriteLine("Если хотите завершить работу, нажмите 1, если хотите продолжить, нажмите 0");
                prov = Convert.ToInt32(Console.ReadLine());
            }
            while (prov == 0);
            Console.ReadKey();
        }
    }
}
