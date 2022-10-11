using System.Security.Cryptography.X509Certificates;

namespace Baze
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            //ex1();
            //ex2();
            //ex3();
            //ex4();
            ex5();
        }
        static void ex1()
        {
            int n = int.Parse(Console.ReadLine());
            int oglindit = 0;
            //ex 12345 => oglidnim , scoatem cifrele impare , oglindim dinou si avem nr initial fara cele
            //impare => 24 .
            while (n > 0)
            {
                int c = n % 10;
                n = n / 10;
                if (c % 2 == 0)
                    oglindit = oglindit * 10 + c;
            }
            while (oglindit > 0)
            {
                int c = oglindit % 10;
                oglindit /= 10;
                n = n * 10 + c;
            }
            Console.WriteLine("Nr dubluoglindit: " + n);
        }
        static void ex2()
        {
            //adaugarea medii aritmetice intr-e cele doua cifre
            int n = int.Parse(Console.ReadLine());//1483 => 1246853
            int oglindit = 0;
            while (n > 0)
            {
                int c = n % 10;
                n = n / 10;
                
                oglindit = oglindit * 10 + c;
            }
            int d = 0;
            while (oglindit > 0)
            {
                int c = oglindit % 10;
                int ma = 0;
                oglindit /= 10;
                if (d != 0)
                    ma = (c + d) / 2;

                if (ma != 0)
                    n = n * 10 + ma;

                n = n * 10 + c;              
                d = c;
            }
            Console.WriteLine("Nr dubluoglindit: " + n);
        }
        static void ex3()
        {
            //descompunerea n in factori primi
            int n = int.Parse(Console.ReadLine());
            int x = n;
            Console.Write("{0} = " ,n);
            for(int d = 2; d <= x; d++)
            {
                if(x%d== 0)
                {
                    
                    int p = 0;
                    while (x % d == 0)
                    {
                        p++;
                        x = x / d;
                    }
                    Console.Write("{0}^{1} * ", d,p);
                }
            }
            Console.Write("1");
        }
        static void ex4()
        {
            //verificam daca n este nr prim
            int n = int.Parse(Console.ReadLine());
            bool ok = true;
            for (int d = 2; d < n; d++)
            {                
                if(n%d== 0)
                {
                    ok = false;
                }
            }
            if (ok)
            {
                Console.WriteLine("nr este prim.");
            }
            else
            {
                Console.WriteLine("nr nu este prim.");
            }
        }
        static void ex5()
        {

        }
    }
}