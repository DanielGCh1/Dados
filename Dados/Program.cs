using System;

namespace Dados
{
    class Program
    {
        

        static void Main(string[] args)
        {
            string mensaje = "Nueva visualización";
            int enter = 13;
            int consola = 0;
            do {
                Console.WriteLine(mensaje);
                Console.ReadKey();
                consola = Console.Read();
                Console.Read();
            } while (consola == enter);
        }
    }
}
