using System;
using System.Collections.Generic;
using System.Linq;


namespace Desafio.Classes
{
    class ContaPalavras
    {
        public int Executar(string palavra)
        {

            if (palavra.Length > 100)
                Console.WriteLine("O texto digitado não pode ser superior a 100 digitos");
            else {
                        string[] textoCompleto = palavra.Split(',');
                        int contador = 0;

                        foreach (var item in textoCompleto)
                       {
                                contador += item.Trim().Length;                  
                       } 

                        return contador;
            }

            return 0;
        }
    }
}
