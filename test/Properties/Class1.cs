using System;

namespace MathLib
{
    public class Class1
    {
        public static double SCR(double a, double b) {
            a = Math.Pow(a,b);
            return a;
        }
        public static double SIN(double a)
        {
            a = Math.Sin(a);
            return a;
        }
        public static double MOD(double a)
        {
            a = Math.Abs(a);
            return a;
        }
        public static double RiV(double a, double b, double x)
        {
            double c = 2.4 * MathLib.Class1.MOD((MathLib.Class1.SCR(x, 2) + b) / a) +
                (a - b) * MathLib.Class1.SCR(MathLib.Class1.SIN(a - b), 2) +
                MathLib.Class1.SCR(10, -2) * (x - b);
            return c;
        }

    }
    public class Class2
    {
        public static int KVRIV(double a, double b, double c, out double d, out double x1, out double x2) {
            d = MathLib.Class1.SCR(b, 2) - 4 * a * c;
            if (d < 0) {
                x1 = 0;
                x2 = 0;
                return 0;
            }
            else if (d == 0)
            {
                x1 = (-b + MathLib.Class1.SCR(d, 0.5)) / 2 * a;
                x2 = 0;
                return 1;
            }
            else
            {
                x1 = (-b + MathLib.Class1.SCR(d, 0.5)) / 2 * a;
                x2 = (-b - MathLib.Class1.SCR(d, 0.5)) / 2 * a;
                return 2;
            }
            
  
            
        }
    }

   
}
