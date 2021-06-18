using System;
namespace Jokenpo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o primeiro Jogador: ");
            string Jogar = Console.ReadLine();
            
            Console.WriteLine("Digite o segundo Jogador: ");
            string Jogar2 = Console.ReadLine();

            string Jogador1 = "Jogador 1 Ganhou";
            string Jogador2 = "Jogador 2 Ganhou";

            string Empate = "Empate";

            string Pedra = "Pedra";
            string Tesoura = "Tesoura";
            string Papel = "Papel";

            Console.WriteLine("Resultado:");
            
            if(Jogar == Tesoura && Jogar2 == Pedra ){
                Console.WriteLine($"{Jogador2}");
            }
            if(Jogar == Tesoura && Jogar2 == Papel ){
                Console.WriteLine($"{Jogador1}");
            }
            if(Jogar == Pedra && Jogar2 == Tesoura){
                Console.WriteLine($"{Jogador1}");
            }
            if(Jogar == Pedra && Jogar2 == Papel ){
                Console.WriteLine($"{Jogador2}");
            }
            if(Jogar == Papel && Jogar2 == Pedra ){
                Console.WriteLine($"{Jogador1}");
            }
            if(Jogar == Papel && Jogar2 == Tesoura ){
                Console.WriteLine($"{Jogador2}");
            }
            if(Jogar == Papel && Jogar2 == Papel ){
                Console.WriteLine($"{Empate}");
            }
            if(Jogar == Tesoura && Jogar2 == Tesoura ){
                Console.WriteLine($"{Empate}");
            }
            if(Jogar == Pedra && Jogar2 == Pedra ){
                Console.WriteLine($"{Empate}");
            }
            
        }
    }
}