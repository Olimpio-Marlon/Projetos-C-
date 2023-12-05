using System;
using System.Text;
using System.Globalization;

namespace LBA3
{
    public class Program
    {
        public static void Main(string[] args)
        {

            /*// Criando Arrays
            // var myDateTime2 = DateTime.Now;
             String texto1 = "Olá,";
            char[] texto = new char[] { ' ', '!' };
            String texto2 = "Mundo";
            int[] num = new int[] { 1, 2, 3};

            

            // formatando o texto todo em Mínusculo
            Console.WriteLine("Digite um texto: ");
            string data = (Console.ReadLine());
            string lowerCaseString = data.ToLower();
            Console.WriteLine(lowerCaseString);

            // formatando o texto em maísculas

            string upperCaseString = "Treinamento DOT NET na CI&T";
            upperCaseString = upperCaseString.ToUpper().Replace("DOT NET", ".NET");
            Console.WriteLine(upperCaseString);

            // Concatenação 
            StringBuilder builder = new StringBuilder();
            
            builder.Append(texto1);
            builder.Append(texto);
            builder.Append(texto2);
            
            // Console.WriteLine($"Olá, {builder}.");

            // Data automática
            DateTime dataEntrada = DateTime.Now;

            Console.WriteLine(dataEntrada);


            // Data personalizável
             var usCulture = new CultureInfo("pt-BR");
             Console.WriteLine("Digite uma data: " + usCulture.DateTimeFormat.ShortDatePattern);
             string dateString = Console.ReadLine();
             DateTime userDate;
             if (DateTime.TryParse(dateString, usCulture.DateTimeFormat, DateTimeStyles.None, out userDate))
                 Console.WriteLine("Data valida: " + userDate.ToLongDateString());
             else
                 Console.WriteLine("Data invalida!");


            // DateTime today = DateTime.Now;
            //DateTime answer = today.AddDays(1);
            //DateTime hora = hora.AddHours(4);
            //Console.WriteLine("Hoje: {0:dddd}", today);
            //Console.WriteLine("Daqui um dia será: {0:dddd}", answer); */


            // Exercício 2 do LAB3

            Console.WriteLine("Digite um número seguido por vírgula: ");
            string resposta = Console.ReadLine();
            int inicial;


            StringBuilder sb = new StringBuilder();



            if (!int.TryParse(resposta, out inicial))
            {
                Console.WriteLine("Digite apenas um número inteiro");
            }
            else
            {
                Console.WriteLine("Ok, pode continuar: ");

                //for (int i = inicial; i > inicial - 10; i--)
                //{

                //    sb.Append(i);

                //    if (!(i == inicial - 10 + 1))
                //    {
                //        sb.Append(",");
                //    }



                //}

                for (int i = inicial; i <= inicial + 9; i++)
                {
                    sb.Append(i);

                    if (!(i == inicial + 9))
                    {
                        sb.Append(",");
                    }




                }

                resposta = sb.ToString();
                Console.WriteLine(resposta);
            }



            // Exercício 3 do LAB3

            /* Console.WriteLine("Digite a data e hora:");
             var myDateTime2 = DateTime.Parse(Console.ReadLine());

             Console.WriteLine($"myDateTime2: {myDateTime2.ToShortDateString()}, {myDateTime2.ToShortTimeString()}, {myDateTime2.ToLongDateString()}");




             // Exercício 4 do LAB3

             var data3 = DateTime.Parse(Console.ReadLine());
             Console.WriteLine("Digite uma data e hora");
             // var data = DateTime.Parse(Console.ReadLine());

             var formatada = String.Format("{0:d}, {0:T}", data);
             Console.WriteLine(formatada);

             var data2 = DateTime.Now;
             Console.WriteLine(data2);

             Console.WriteLine(data2.AddDays(1));
             Console.WriteLine(data2.AddHours(4));
             Console.WriteLine(data2.AddMinutes(30));

             TimeSpan tsInstance = new TimeSpan(1, 4, 30, 0);

             Console.WriteLine(data3 + tsInstance);



              // Dia da semana em espanhol
              DateTime dateValue = new DateTime(2008, 6, 11);
              Console.WriteLine(dateValue.ToString("dddd",
                                new CultureInfo("es-ES")));

              // Dia da semana em português
              DateTime dateValue2 = new DateTime(2008, 6, 11);
              Console.WriteLine(dateValue2.ToString("dddd",
                                new CultureInfo("pt-BR")));


             }

                 public static void ShowProprerties(TimeSpan timeZoneBR, TimeSpan timeZoneUS)
             {
                 TimeSpan intervalo = timeZoneBR - timeZoneUS;*/



        }
    }
}
