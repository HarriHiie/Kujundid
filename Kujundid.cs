using System.Data;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {     
            Console.WriteLine("sisesta number mis kujundit tahad: ");
            Console.WriteLine("1. Ruut");
            Console.WriteLine("2. Teemant");
            Console.WriteLine("3. Ristkülik");
            Console.WriteLine("4. Kolmnurk");

            string Kujud = Console.ReadLine();

            switch (Kujud)
            {
                case "1":
                    Ruut();
                    break;

                case "2":
                    Teemant();
                    break;

                case "3":
                    Ristkülik();
                    break;

                case "4":
                    Kolmnurk();
                    break;

                default:
                    Console.WriteLine("vale kujund");
                    break;
            }
        }
        private static void Ruut()
        {
            Console.WriteLine("sisesta ruudu külje pikkus");

            int size = Convert.ToInt32(Console.ReadLine());


            for (int row = 1; row <= size; row++)
            {
                for (int column = 1; column <= size; column++)
                {
                    string mark;
                    if (row == column || row + column <= size + 1)
                    {
                        mark = "*";
                    }
                    else
                    {
                        mark = "*";
                    }
                    Console.Write(mark);
                }
                Console.WriteLine();
            }
            Console.WriteLine("sisesta teise külje pikkus");
            int külg = Convert.ToInt32(Console.ReadLine());
            int pindala = külg * külg;
            int ümbermõõt = 4 * külg;
            Console.WriteLine("Pindala on {0}", pindala);
            Console.WriteLine("Ümbermõõt on {0}", ümbermõõt);
        }
        private static void Teemant()
        {
            Console.WriteLine("sisesta teemanti külje pikkus");

            int row = Convert.ToInt32(Console.ReadLine());

            int j;

            for (int i = 0; i <= row; i++)
            {
                for (j = 1; j <= row - i; j++)
                {
                    Console.Write(" ");
                }
                for (j = 1; j <= 2 * i - 1; j++)
                {
                    Console.Write("*");
                }
                Console.Write("\n");
            }

            for (int i = row - 1; i >= 1; i--)
            {
                for (j = 1; j <= row - i; j++)
                {
                    Console.Write(" ");
                }
                for (j = 1; j <= 2 * i - 1; j++)
                {
                    Console.Write("*");
                }
                Console.Write("\n");
            }
            Console.WriteLine("sisesta teise külje pikkus");
            int külg = Convert.ToInt32(Console.ReadLine());
            double ümbermõõt = 2 * 3.14159265359 * külg;
            double pindala = 3.14159265359 * külg * külg;
            Console.WriteLine("Teemanti pindala on {0}", pindala);
            Console.WriteLine("Teemanti ümbermõõt on {0}", ümbermõõt);
        }
        private static void Ristkülik()
        {

            Console.Write("sisesta ristküliku külje pikkus : ");
            int height = Convert.ToInt32(Console.ReadLine());

            Console.Write("sisesta ristküliku külje laius : ");
            int width = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= height; i++)
            {
                for (int j = 1; j <= width; j++)
                {
                    if ((i == 1 || i == height) || (j == 1 || j == width))
                        Console.Write("*");
                    else
                        Console.Write("*");
                }
                Console.WriteLine();
            }
            Console.WriteLine("sisesta teise külje pikkus");
            int pikkus = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("sisesta teise külje laius");
            int laius = Convert.ToInt32(Console.ReadLine());
            int pindala = pikkus * laius;
            int ümbermõõt = 2 * (pikkus + laius);
            Console.WriteLine("ristküliku pindala on {0}", pindala);
            Console.WriteLine("ristküliku ümbermõõt on {0}", ümbermõõt);
        }
        private static void Kolmnurk()
        {
            Console.WriteLine("sisesta kolmnurga külje suurus: ");

            int rows = Convert.ToInt32(Console.ReadLine());

            int spc = rows + 4 - 1;

            for (int i = 1; i <= rows; i++)
            {
                Console.Write("\n");
                for (int k = spc; k >= 1; k--)
                {
                    Console.Write(" ");
                }
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("* ");
                }
                   spc--;
            }
            Console.WriteLine("sisesta teise külje pikkus : ");
            int suurus = Convert.ToInt32(Console.ReadLine());
            int pindala = (suurus * suurus) / 2;
            int ümbermõõt = suurus + suurus + suurus;
            Console.WriteLine("kolmnurga pindala on {0}", pindala);
            Console.WriteLine("kolmnurga ümbermõõt on {0}", ümbermõõt);

        }
    }
}


