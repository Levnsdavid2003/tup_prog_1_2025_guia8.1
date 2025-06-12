using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio2.Models
{
    internal class Servicio
    {
        #region Declaración de Variables
        public int edad0, edad1, edad2, edad3;
        public double monto;
        public double porcentaje0, porcentaje1, porcentaje2, porcentaje3;
        public double monto0, monto1, monto2, monto3;
        #endregion

        #region Resolución del Problema

        public void RegistrarMontoARepartir(double valor)
        {
            monto = valor;
        }
        public void RegistrarEdad(int edad, int nroNiña)
        {
            switch (nroNiña)
            {
                case 0:
                    edad0 = edad;
                    break;
                case 1:
                    edad1 = edad;
                    break;
                case 2:
                    edad2 = edad;
                    break;
                case 3:
                    edad3 = edad;
                    break;
            }
        }
        public void CalcularMontosYPorcentajesARepartir()
        {
            int sumaEdades = edad0 + edad1 + edad2 + edad3;
            porcentaje0 = (double)edad0 / sumaEdades * 100;
            porcentaje1 = (double)edad1 / sumaEdades * 100;
            porcentaje2 = (double)edad2 / sumaEdades * 100;
            porcentaje3 = (double)edad3 / sumaEdades * 100;
            monto0 = monto * porcentaje0 / 100;
            monto1 = monto * porcentaje1 / 100;
            monto2 = monto * porcentaje2 / 100;
            monto3 = monto * porcentaje3 / 100;
        }
        #endregion
    }
}
