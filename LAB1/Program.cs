using System;


namespace LAB1
{
    class Program
    {
        public static void Main(string[] args)
        {


            
            //int numero2 = 100;

            Console.WriteLine("Digite um n�mero: ");
            int num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Seu n�mero �: " + num);
            

            if (num < 1 || num > 100)
                
            {
                Console.WriteLine("N�mero inv�lido, digite um n�mero entre 1 e 100");
            }
            else
            {
                if (num == 35 || num == 75 || num == 90)
                {
                    Console.WriteLine("Parab�ns voc� ganhou um carro :)");

                }
                else
                {
                    Console.WriteLine("Tente outra vez quem sabe voc� ganha");
                }
            }

            Console.ReadLine();
        }

       
    }
}
