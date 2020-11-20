using System;

namespace Sequencia_Centena
{
    class Program
    {
        static void Main(string[] args)
        {
            int Numero = 1;
            while (Numero<=100)
        

            {
                Console.BackgroundColor = ConsoleColor.Black;
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.Write(Numero);
                Console.Write(" ");
                Numero += 1;
                Console.ResetColor();
            }
                Console.WriteLine("\n");
                Console.WriteLine("TECLE ENTER PARA SAIR");
                Console.ReadLine();
                Console.WriteLine("FIM");
                Console.ReadKey();
                
            
        }
    }
}
