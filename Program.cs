using System;
using Desafio.Classes;

namespace Desafio
{
    class Program
    {
        static void Main(string[] args)
        {                
                //Henrique Ferreira Costa

                string palavra;
                Console.Write("Digite o texto: ");
                 palavra = Console.ReadLine();

                int numeroPalavras = new ContaPalavras().Executar(palavra);

                if (numeroPalavras > 0)
               {
                     Console.WriteLine("Letras no Total: " + numeroPalavras.ToString());
               }
                Console.ReadKey();
            }
    }
}
