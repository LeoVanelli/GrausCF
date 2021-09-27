using System;

namespace GrausCF
{
    class Program
    {
        static void Main(string[] args)
        {
            // Objetivo: Converta uma temperatura digitada pelo usuário em °C para °F.

            Console.Write("Digite o valor da temperatura em ºC: ");
            int C = int.Parse(Console.ReadLine());

            Console.WriteLine($"\nResposta: {C}ºC equivalem à {C*1.8+32}ºF");
        }
    }
}
