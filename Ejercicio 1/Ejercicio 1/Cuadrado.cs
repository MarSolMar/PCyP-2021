using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_1
{
    class Cuadrado
    {

        //Lado del cuadrado
        private int lado;

            //Método constructor
            public Cuadrado()
            {
              Console.WriteLine("Ingrese el valor para un lado de un cuadrado:");
              lado = int.Parse(Console.ReadLine());

            }

            //Método que calcula el área de un cuadrado
            public double areaCuadrado()
            {
              double areaCuadrado;
              areaCuadrado = lado * lado;

            return areaCuadrado;
            }

            //Método que calcula el perímetro de un cuadrado
            public double perimetroCuadrado()
            {
            double perimetroCuadrado;
            perimetroCuadrado = lado * 4;

            return perimetroCuadrado;
            }




    }
}
