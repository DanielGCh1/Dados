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
            int caraSuperior = 0;
            int caraInferior = 0;
            int caraFrontal = 0;
            int caraTrasera = 0;
            int caraIzquierda = 0;
            int caraDerecha = 0;
            int[] numerosAleatorios = { 0, 0, 0, 0, 0, 0 };

            do {
                Console.WriteLine(mensaje);
                for (int i = 0; i < 2; i++)
                {
                    numerosAleatorios = programa.obtenerNumerosRamdom(caraSuperior, caraInferior, caraFrontal, caraTrasera, caraIzquierda, caraDerecha);

                    caraSuperior = numerosAleatorios[0];
                    caraInferior = numerosAleatorios[1];
                    caraFrontal = numerosAleatorios[2];
                    caraTrasera = numerosAleatorios[3];
                    caraIzquierda = numerosAleatorios[4];
                    caraDerecha = numerosAleatorios[5];

                    programa.dibujarDado(caraSuperior, caraInferior, caraFrontal, caraTrasera, caraIzquierda, caraDerecha);
                    Console.WriteLine();
                }
                Console.WriteLine("Las caras superiores de ambos dados son diferentes");

                Console.ReadKey();
                consola = Console.Read();
                Console.Read();
            } while (consola == enter);
        }

        public void dibujarDado(int caraSupe, int caraInfe, int caraFron, int caraTrase, int caraIzquier,
        int caraDere)
        {
            Console.WriteLine("        #####");
            Console.WriteLine("        # {0} #", caraSupe);
            Console.WriteLine("#################");
            Console.WriteLine("# {0} # {1} # {2} # {3} #", caraTrase, caraIzquier, caraFron, caraDere);
            Console.WriteLine("#################");
            Console.WriteLine("        # {0} #", caraInfe);
            Console.WriteLine("        #####");
        }

        public int[] obtenerNumerosRamdom(int caraSupe, int caraInfe, int caraFron, int caraTrase, int caraIzquier,
        int caraDere)
        {
            int[] numerosAleatorios = {0,0,0,0,0,0};
            Random random = new Random();
            int numeroParaCaraSuperiorDado2 = random.Next(1, 7);
            while (caraSupe == numeroParaCaraSuperiorDado2)
            {
                numeroParaCaraSuperiorDado2 = random.Next(1, 7);
            }
            caraSupe = numeroParaCaraSuperiorDado2;
            caraInfe = 7 - caraSupe;
            int ran = random.Next(1, 7);

            do {
                ran = random.Next(1, 7);
            } while (ran == caraSupe || ran == caraInfe);
            caraFron = ran;
            caraTrase = 7 - caraFron;

            caraIzquier = 1;
            while (caraIzquier==caraSupe || caraIzquier==caraInfe || caraIzquier==caraFron || caraIzquier==caraTrase)
            {
                caraIzquier++;
            }
            caraDere = 7 - caraIzquier;

            numerosAleatorios[0] = caraSupe;
            numerosAleatorios[1] = caraInfe;
            numerosAleatorios[2] = caraFron;
            numerosAleatorios[3] = caraTrase;
            numerosAleatorios[4] = caraIzquier;
            numerosAleatorios[5] = caraDere;

            return numerosAleatorios;
        }
    }
}
