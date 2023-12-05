using System;


namespace LAB1
{
    class Program
    {
        public static void Main(string[] args)
        {


            
            //int numero2 = 100;

            Console.WriteLine("Digite um número: ");
            int num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Seu número é: " + num);
            

            if (num < 1 || num > 100)
                
            {
                Console.WriteLine("Número inválido, digite um número entre 1 e 100");
            }
            else
            {
                if (num == 35 || num == 75 || num == 90)
                {
                    Console.WriteLine("Parabéns você ganhou um carro :)");

                }
                else
                {
                    Console.WriteLine("Tente outra vez quem sabe você ganha");
                }
            }

            Console.ReadLine();
        }

       
    }
}
