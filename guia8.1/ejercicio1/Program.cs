using ejercicio1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio1
{
    internal class Program
    {
        static Servicio servicio = new Servicio();

        #region Metodos de Pantalla

        static int MostrarPantallaSolicitarOpcionMenu()
        {
            Console.Clear();
            Console.WriteLine(
                @"Procesar Números

        1 - Procesar un solo número.
        2 - Procesar varios números.
        3 - Mostrar máximo y mínimo.
        4 - Mostrar promedio.
        5 - Mostrar cantidad de números ingresados.
        6 - Reiniciar variables.");
            int eleccion = Convert.ToInt32(Console.ReadLine());


            return eleccion;
        }

        static void MostrarPantallaIngresarNumero()
        {
            Console.Clear();
            Console.WriteLine("Solicitud de Ingreso de Número\n");
            Console.WriteLine("Ingrese un número:");
            int valor = Convert.ToInt32(Console.ReadLine());
            servicio.RegistrarValor(valor);
        }

        static void MostrarPantallaSolicitarVariosNumeros()
        {
            int num = 0;
            int cantidad = 0;
            Console.Clear();
            Console.WriteLine("Solicitud de Ingreso de Varios Numeros\n");
            Console.WriteLine("Escriba la cantidad de numeros:");
            cantidad = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= cantidad; i++)
            {
                Console.WriteLine("\nIngrese el número {0} :", i);
                num = Convert.ToInt32(Console.ReadLine());
                servicio.RegistrarValor(num);
            }
            Console.WriteLine("Presione cualquier tecla para salir.");
            Console.ReadKey();
        }

        static void MostrarMaximoyMinimo()
        {
            Console.Clear();
            Console.WriteLine("\t\t Mostrar Máximo y Minimo\n");
            Console.WriteLine($"El número máximo es: {servicio.Maximo}");
            Console.WriteLine($"El número minimo es: {servicio.Minimo}\n\n");
            Console.WriteLine("Presione cualquier tecla para salir.");
            Console.ReadKey();
        }

        static void MostrarPantallaPromedio()
        {
            Console.Clear();
            Console.WriteLine("Promedio de los números\n");
            Console.WriteLine("El promedio del/los numeros es: {0} \n\n", servicio.CalcularPromedio());
            Console.WriteLine("Presione cualquier tecla para salir.");
            Console.ReadKey();
        }

        static void MostrarPantallaCantidad()
        {
            Console.Clear();
            Console.WriteLine("Cantidad de números ingresados\n");
            Console.WriteLine("La cantidad de números procesados son: {0} \n\n", servicio.contador);
            Console.WriteLine("Presione cualquier tecla para salir.");
            Console.ReadKey();
        }

        static void ReiniciarValores()
        {
            servicio.contador = 0;
            servicio.acumulador = 0;
            servicio.Maximo = 0;
            servicio.Minimo = 0;
            Console.Clear();
            Console.WriteLine("Valores reiniciados\n\n");
            Console.WriteLine("Presione cualquier tecla para salir.");
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
                        MostrarPantallaIngresarNumero();
                        break;
                    case 2:
                        MostrarPantallaSolicitarVariosNumeros();
                        break;
                    case 3:
                        MostrarMaximoyMinimo();
                        break;
                    case 4:
                        MostrarPantallaPromedio();
                        break;
                    case 5:
                        MostrarPantallaCantidad();
                        break;
                    case 6:
                        ReiniciarValores();
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
