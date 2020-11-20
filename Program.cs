using System;

namespace Sequencia_Centena
{
    class Program
    {
        static void Main(string[] args)
        {
            int Numero = 0;
            while (Numero<=100)
        

            {
                Console.BackgroundColor = ConsoleColor.Black;
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine($"Numero = { Numero }");
                Numero++;
                Console.ResetColor();
            }
        
                Console.WriteLine("TECLE ENTER PARA SAIR");
                Console.ReadLine();
                Console.WriteLine("FIM");
                Console.ReadKey();
                
            
        }
    }
}
