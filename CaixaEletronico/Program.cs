using System;

namespace dojo
{
    class Program
    {
        static void Main(string[] args)
        {
            int nota_100 = 0;
            int nota_50 = 0;
            int nota_20 = 0;
            int nota_10 = 0;

            Console.Write("Quantidade: ");
            int number = Int32.Parse(Console.ReadLine());

            if(number >= 100) {
                nota_100 = number / 100;
                number = number - 100 * nota_100;
            if(number >= 50){
                nota_50 = (number / 50);
                number = number - 50 * nota_50;
            if(number >= 20){
                nota_20 = number / 20;
                number = number - 20 * nota_20;
            if(10 <= number){
                nota_10 = number / 10;
                number = number - 10 * nota_10;
                    }
                }
            }
        }
            
            Console.Write("Resultado Esperado: ");

            if(nota_100 != 0){
            Console.Write($"Entregar {nota_100} notas de R$100,00");
            }
            if(nota_50 != 0 ){
                Console.Write($" , {nota_50} notas de R$50,00");
            }
            if(nota_20 != 0){
                Console.Write($" , {nota_20} notas de R$20,00");
            }
            if(nota_10 !=0){
                Console.Write($" e {nota_10} notas de R$10,00");
            }
        }
    }
}
