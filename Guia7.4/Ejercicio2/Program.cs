using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int cantZonas = 0;
            int contador = 0;
            double acumulador = 0;
            Console.WriteLine("Solicitar Cantidad de zonas");
            cantZonas = Convert.ToInt32(Console.ReadLine());

            for (int zonas = 1; zonas <= cantZonas; zonas++)
            {
                int line = 0;
                bool conti = false;
                while (!conti)
                {
                    console.WriteLine("Ingrese el valor por tipo");
                    switch (line)
                    {
                        case 1:
                            console.writeline("Motos");
                            double Motos = convert.ToInt32(console.ReadLine());
                            break;
                        case 2:
                            console.writeline("Autos");
                            double Autos = convert.ToInt32(console.ReadLine());
                            break;
                        case 3:
                            console.writeline("Utilarios");
                            double Utilarios = convert.ToInt32(console.ReadLine());
                            break;
                        case 4:
                            console.writeline("Camiones");
                            double Camiones = convert.ToInt32(console.ReadLine());
                            break;
                    }
                    line++
                    conti = true;
                }
                do
                {

                    console.writeline("Indicar tipo de vehiculo");
                    console.writeline("Moto-Auto-Utilarios-Camiones");
                    string tipo = console.readline();

                    
                } while ()
            }
        }
    }
}
