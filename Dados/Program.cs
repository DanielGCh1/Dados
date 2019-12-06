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
            Program programa = new Program();
            int caraSuperio = 0;
            int caraInferior = 0;
            int caraFrontal = 0;
            int caraTrasera = 0;
            int caraIzquierda = 0;
            int caraDerecha = 0;

            do {
                Console.WriteLine(mensaje);
                programa.dibujarDado(caraSuperio, caraInferior, caraFrontal, caraTrasera, caraIzquierda, caraDerecha);
                Console.ReadKey();
                consola = Console.Read();
                Console.Read();
            } while (consola == enter);
        }

        public void dibujarDado(int caraSupe, int caraInferior, int caraFron, int caraTrase, int caraIzquier,
        int caraDere)
        {
            Console.WriteLine("        #####");
            Console.WriteLine("        # {0} #", caraSupe);
            Console.WriteLine("#################");
            Console.WriteLine("# {0} # {1} # {2} # {3} #", caraTrase, caraIzquier, caraFron, caraDere);
            Console.WriteLine("#################");
            Console.WriteLine("        # {0} #", caraInferior);
            Console.WriteLine("        #####");
        }
    }
}
