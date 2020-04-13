using System;
using GolfettoFramework.Core.HttpUtilities;

namespace GolfettoFramework.ConsoleTests
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Vamos fazer um get");

            var req = new SimpleRequest();

            var resultado = req.GetString("http://copafilmes.azurewebsites.net/api/filmes");

            Console.WriteLine(resultado);
            Console.WriteLine("Fim de jogo");
            Console.ReadKey();
        }
    }
}
