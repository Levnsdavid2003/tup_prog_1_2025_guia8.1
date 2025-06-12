using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio1.Models
{
    internal class Servicio
    {
        #region Declaración de Variables
        public int contador;
        public int acumulador;
        public int Maximo;
        public int Minimo;
        #endregion

        #region Resolución del Problema
        public void RegistrarValor(int valor)
        {
            acumulador += valor;

            if (valor > Maximo || contador == 0)
            {
                Maximo = valor;
            }
            if (valor < Minimo || contador == 0)
            {
                Minimo = valor;
            }
            contador++;
        }
        public double CalcularPromedio()
        {
            double promedio = 0;
            if (contador > 0)
            {
                promedio = 1d * acumulador / contador;
            }
            return promedio;
        }
        #endregion

    }
}
