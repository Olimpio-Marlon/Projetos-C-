using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testando
{
    internal class Program
    {

        static void Main(string[] args)
        {

            /*string[] Chamada = new string[] {"Marlon", "Tais", "Celina", "Angela", "Toni" };


             Console.WriteLine(Chamada[0]);
             Console.WriteLine("Testando o C#");
            */

             double nota;


             Console.WriteLine("Digite a nota do meliante: ");
             nota = double.Parse(Console.ReadLine());



             if(nota <= 4)
             {
                 Console.WriteLine("Deveria ter estudado parça");
             }
             else if (nota == 6 || nota == 5 )
             {
                 Console.WriteLine("Raspando, hein parça");
             }
             else if (nota > 6)
            {
                Console.WriteLine("Você estudou parça");
            }

            


            /*int numero;
            int num;



            Console.WriteLine("Digite um número de 1 a 99: ");
            numero = int.Parse(Console.ReadLine());

            if (numero <=0 || numero >= 100)
            {
                Console.WriteLine("Esse número não é válido");
            }
            else if(numero == 10 || numero == 20 || numero == 30)
            {
                Console.WriteLine("Você ganhou");
            }
            

            /*
            for(num=0; num <= 10; num++)
            {
                Console.WriteLine(num);
            }
            */


            /*
            int test = 0;

            while( test++ < 10 )
            {
                Console.WriteLine("contando");
            }
            */



            Console.ReadKey();
            
        }



        



    }
}
