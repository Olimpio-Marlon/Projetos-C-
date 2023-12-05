using System;

namespace LAB2
{
    class Program
    {
        public static void Main(string[] args)
        {

            Console.WriteLine("Valores pares: ");
            int p = Convert.ToInt32(Console.ReadLine());

            for ( p = 0; p <= 10; p++)
            {
                if (p % 2 == 0)
                {
                    Console.WriteLine(p);
                }
               
            }

            Console.WriteLine("Sequencia: ");
            int s = Convert.ToInt32(Console.ReadLine());
           // int s = 0;
            while (s >= 0 && s <= 5)
            {
                Console.WriteLine(s);
                s++;

            }

            Console.WriteLine("Valores impares: ");
            for (int i = 0; i <= 10; i++)
            {
                if (i % 2 != 0)
                {
                    Console.WriteLine(i);
                }

                
            }
            Console.ReadLine();
        }
    }
}
