using System;

namespace Tarea_LPOO
{
    class Program
    {
        static void Main(string[] args)
        {
            int respuesta;
            double valorQuincenal, bonoProfesionalizacion, bonoTransporte, bonoAlimentación, totalSueldo, valorquincena;
            valorQuincenal = 1050000;
            bonoProfesionalizacion = (valorQuincenal / 100) * 10;
            bonoTransporte = 120000;
            bonoAlimentación = (25000 * 15);


            Console.WriteLine("Por favor ingrese 1 si es profesional, de lo contrario, por favor ingrese 2");
            respuesta = Convert.ToInt32(Console.ReadLine());



            if (respuesta == 1)
            {
                valorquincena = valorQuincenal + bonoProfesionalizacion + bonoTransporte + bonoAlimentación;

                totalSueldo = valorquincena - ((valorquincena / 100) * 7);
            }
            else
            {
                valorquincena = valorQuincenal + bonoTransporte + bonoAlimentación;

                totalSueldo = valorquincena - ((valorquincena / 100) * 7);

            }

            Console.WriteLine("El total que recibirá al final de la quincena será " + totalSueldo);


        }
    }
    
}
