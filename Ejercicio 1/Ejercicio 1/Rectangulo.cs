using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_1
{
    class Rectangulo
    {

        //Base del rectángulo
        private int baseRectangulo;

        //Altura del rectángulo
        private int alturaRectangulo;
        

        //Método constructor
        public Rectangulo()
        {
            Console.WriteLine("Ingrese el valor de la base del rectángulo:");
            baseRectangulo = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese el valor de la altura del rectángulo:");
            alturaRectangulo = int.Parse(Console.ReadLine());

        }

        //Método que calcula el área de un rectángulo
        public double areaRectangulo()
        {
            double areaRectangulo;
            areaRectangulo = baseRectangulo * alturaRectangulo;

            return areaRectangulo;
        }

        //Método que calcula el perímetro de un rectángulo
        public double perimetroRectangulo()
        {
            double perimetroRectangulo;
            perimetroRectangulo = (alturaRectangulo * 2) + (baseRectangulo * 2);

            return perimetroRectangulo;
        }



    }
}
