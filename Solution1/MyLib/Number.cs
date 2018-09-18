using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLib
{
    public class Number
    {
        public int Xnum { get; set; }
        public int Xden { get; set; }
        public int Ynum { get; set; }
        public int Yden { get; set; }

        public Number(int xNum, int xDen, int yNum, int yDen)
        {
            Xnum = xNum;
            Xden = xDen;
            Ynum = yNum;
            Yden = yDen;
        }

        //сумма
        public int SumNum()
        {
            if (Xden == Yden)
                return Xnum + Ynum;
            else if (Xden % Yden == 0)
                return Xnum + Ynum * (Xden / Yden);
            else if (Yden % Xden == 0)
                return Ynum + Xnum * (Yden / Xden);
            else
                return Xnum * Yden + Ynum * Xden;
        }
        public int SumDen()
        {
            if (Xden == Yden)
                return Xden;
            else if (Xden % Yden == 0)
                return Xden;
            else if (Yden % Xden == 0)
                return Yden;
            else
                return Xden * Yden;
        }

        //разность
        public int SubNum()
        {
            if (Xden == Yden)
                return Xnum - Ynum;
            else if (Xden % Yden == 0)
                return Xnum - Ynum * (Xden / Yden);
            else if (Yden % Xden == 0)
                return Ynum - Xnum * (Yden / Xden);
            else
                return Xnum * Yden - Ynum * Xden;
        }
        public int SubDen()
        {
            if (Xden == Yden)
                return Xden;
            else if (Xden % Yden == 0)
                return Xden;
            else if (Yden % Xden == 0)
                return Yden;
            else
                return Xden * Yden;
        }

        //умножение
        public int MultNum()
        {
            return Xnum * Ynum;
        }
        public int MultDen()
        {
            return Xden * Yden;
        }

        //деление
        public int DivNum()
        {
            return Xnum * Yden;
        }
        public int DivDen()
        {
            return Xden * Ynum;
        }
    }
}
