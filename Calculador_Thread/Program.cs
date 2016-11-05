using System;
using System.Threading;

namespace Calculador_Thread
{
    class Program
    {
        static void Main(string[] args)
        {
            //Creacion de la instancia de la clase e inicializacion de la misma.
            Operaciones Op = new Operaciones(5, 7);
            //Creacion de cada uno de los hilos para cada una de las operaciones de la clase
            Thread Hilo1 = new Thread(new ThreadStart(Op.Sumar));
            Hilo1.Name = String.Format("Hilo1");
            Thread Hilo2 = new Thread(new ThreadStart(Op.Restar));
            Hilo2.Name = String.Format("Hilo2");
            Thread Hilo3 = new Thread(new ThreadStart(Op.Multiplicar));
            Hilo3.Name = String.Format("Hilo3");

            //Inicio de ejecucion de cada uno de los hilos creados
            Hilo1.Start();
            Hilo2.Start();
            Hilo3.Start();
            //Espera para que el usuario presione una tecla. 
            Console.ReadKey();

        }
    }
}
