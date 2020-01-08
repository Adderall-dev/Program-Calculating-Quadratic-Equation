using System;

namespace Program_Calculating_Qadratic_Equation
{
    class Program
    {
        public static void Main()
        {
            int A = 2, B = 3, C = -2;
            Console.WriteLine("Parametry porównania: \n");
            Console.WriteLine("A = " + A + ", B = " + B + ", C = " + C + "\n");

            if (A == 0)
            {
                Console.WriteLine("To nie jest równanie kwadratowe: A = 0!");
            }
            else
            {
                double delta = B + B - 4 * A * C;
                if (delta < 0)
                {
                    Console.WriteLine("Delta < 0.");
                    Console.WriteLine("To równanie nie ma rozwiązania w zbiorze liczb rzeczywistych");
                }
                else
                {
                    double wynik;
                    if (delta == 0)
                    {
                        wynik = -B / (2 * A);
                        Console.WriteLine("Rozwiązanie: x = " + wynik);
                    }
                    else
                    {
                        wynik = (-B + Math.Sqrt(delta)) / (2 * A);
                        Console.WriteLine("Rozwiązanie: x1 = " + wynik);
                        wynik = (-B - Math.Sqrt(delta)) / (2 * A);
                        Console.WriteLine("Rozwiązanie: x2 = " + wynik);
                    }
                }
            }
        }
    }
}

