using System;

namespace per_analisisNumerico
{
    class Program
    {
        public static decimal x1;
        public static decimal x2;
        public static decimal x3;
        public static decimal y1;
        public static decimal y2;
        public static decimal y3;
        public static decimal z1;
        public static decimal z2;
        public static decimal z3;
        public static decimal s1;
        public static decimal s2;
        public static decimal s3;
        public static decimal Ds;
        public static decimal Dx;
        public static decimal Dy;
        public static decimal Dz;
        static void DelataS()
        {
            Ds = ((x1*y2*z3)+(x2*y3*z1)+(x3*y1*z2))-((z1*y2*x3)+(z2*y3*x1)+(z3*y1*x2));
            System.Console.WriteLine($"Ds = {Ds}");
        }
        static void DelataX()
        {
            Dx = ((s1*y2*z3)+(s2*y3*z1)+(s3*y1*z2))-((z1*y2*s3)+(z2*y3*s1)+(z3*y1*s2));
            System.Console.WriteLine($"Dx = {Dx}");
        }
        static void DelataY()
        {
            Dy = ((x1*s2*z3)+(x2*s3*z1)+(x3*s1*z2))-((z1*s2*x3)+(z2*s3*x1)+(z3*s1*x2));
            System.Console.WriteLine($"Dy = {Dy}");
        }
        static void DelataZ()
        {
            Dz = ((x1*y2*s3)+(x2*y3*s1)+(x3*y1*s2))-((s1*y2*x3)+(s2*y3*x1)+(s3*y1*x2));
            System.Console.WriteLine($"Dz = {Dz}");
        }
        static void Cramer()
        {
            System.Console.WriteLine("x1");
            x1 = Convert.ToDecimal(Console.ReadLine());
            System.Console.WriteLine("x2");
            x2 = Convert.ToDecimal(Console.ReadLine());
            System.Console.WriteLine("x3");
            x3 = Convert.ToDecimal(Console.ReadLine());
            System.Console.WriteLine("y1");
            y1 = Convert.ToDecimal(Console.ReadLine());
            System.Console.WriteLine("y2");
            y2 = Convert.ToDecimal(Console.ReadLine());
            System.Console.WriteLine("y3");
            y3 = Convert.ToDecimal(Console.ReadLine());
            System.Console.WriteLine("z1");
            z1 = Convert.ToDecimal(Console.ReadLine());
            System.Console.WriteLine("z2");
            z2 = Convert.ToDecimal(Console.ReadLine());
            System.Console.WriteLine("z3");
            z3 = Convert.ToDecimal(Console.ReadLine());
            System.Console.WriteLine("s1");
            s1 = Convert.ToDecimal(Console.ReadLine());
            System.Console.WriteLine("s2");
            s2 = Convert.ToDecimal(Console.ReadLine());
            System.Console.WriteLine("s3");
            s3 = Convert.ToDecimal(Console.ReadLine());
            DelataS();
            DelataX();
            DelataY();
            DelataZ();
            Console.WriteLine($"x = {Dx/Ds}");
            Console.WriteLine($"y = {Dy/Ds}");
            Console.WriteLine($"z = {Dz/Ds}");
        }
        static void Main(string[] args)
        {
            Cramer();
        }
    }
}
