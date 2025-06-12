using ejercicio2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ejercicio2
{
    internal class Program
    {
        static Servicio servicio = new Servicio();


        #region Metodos de Pantalla
        static int MostrarPantallaSolicitarOpcionMenu()
        {
            Console.Clear();
            Console.WriteLine(
                @"Procesar mensualidad de Niñas

        1. Iniciar Monto a repartir
        2. Solicitar Edad por Niña
        3. Mostrar monto y porcentajes que corresponde a cada niña.");
            int eleccion = Convert.ToInt32(Console.ReadLine());

            return eleccion;
        }
        static void MostrarPantallaSolicitarMontoARepartir()
        {
            Console.Clear();
            Console.WriteLine("Monto a repartir entre las niñas\n");
            Console.WriteLine("Ingrese el monto a repartir entre las niñas:");
            double monto = Convert.ToDouble(Console.ReadLine());
            servicio.RegistrarMontoARepartir(monto);
            Console.WriteLine("\n\nPresione cualquier tecla para salir.");
            Console.ReadKey();
        }
        static void MostrarPantallaSolicitarEdadesNiñas()
        {
            Console.Clear();
            Console.WriteLine("Edades de niñas:\n");
            Console.WriteLine("Ingrese la edad de cada niña\n");
            Console.WriteLine("Niña 1:");
            int edad = Convert.ToInt32(Console.ReadLine());
            servicio.RegistrarEdad(edad, 0);
            Console.WriteLine("Niña 2:");
            edad = Convert.ToInt32(Console.ReadLine());
            servicio.RegistrarEdad(edad, 1);
            Console.WriteLine("Niña 3:");
            edad = Convert.ToInt32(Console.ReadLine());
            servicio.RegistrarEdad(edad, 2);
            Console.WriteLine("Niña 4:");
            edad = Convert.ToInt32(Console.ReadLine());
            servicio.RegistrarEdad(edad, 3);

            Console.WriteLine("\n\nPresione cualquier tecla para salir.");
            Console.ReadKey();
        }
        static void MostrarPantallaCalcularMostrarMontoYPorcentajePorNiña()
        {
            Console.Clear();
            servicio.CalcularMontosYPorcentajesARepartir();
            Console.WriteLine("Monto y porcentajes que corresponde a cada niña:\n");
            Console.WriteLine($"Niña 1: {servicio.monto0:f2}$ ({servicio.porcentaje0:f2}%)");
            Console.WriteLine($"Niña 2: {servicio.monto1:f2}$ ({servicio.porcentaje1:f2}%)");
            Console.WriteLine($"Niña 3: {servicio.monto2:f2}$ ({servicio.porcentaje2:f2}%)");
            Console.WriteLine($"Niña 4: {servicio.monto3:f2}$ ({servicio.porcentaje3:f2}%)");
            Console.WriteLine("\n\nPresione cualquier tecla para salir.");
            Console.ReadKey();
        }
        #endregion


        static void Main(string[] args)
        {
            int op = MostrarPantallaSolicitarOpcionMenu();

            while (op != -1)
            {
                switch (op)
                {
                    case 1:
                        MostrarPantallaSolicitarMontoARepartir();
                        break;
                    case 2:
                        MostrarPantallaSolicitarEdadesNiñas();
                        break;
                    case 3:
                        MostrarPantallaCalcularMostrarMontoYPorcentajePorNiña();
                        break;
                    default:
                        op = -1;
                        break;

                }
                op = MostrarPantallaSolicitarOpcionMenu();
            }
        }
    }
}
