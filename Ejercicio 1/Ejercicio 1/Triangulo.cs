using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_1
{
    class Triangulo
    {

        //Lado del triángulo
        private int ladoT;


        //Método constructor
        public Triangulo()
        {
            Console.WriteLine("Ingrese el valor del lado del tritángulo:");
            ladoT = int.Parse(Console.ReadLine());

        }
        // Método que calcula la altura del triángulo
        public double alturaTriangulo()
        {
            double altura;

            altura = Math.Sqrt(
                               (Math.Pow(ladoT, 2)) - (Math.Pow((ladoT / 2), 2))
                               );
            return altura; 
        }


        //Método que calcula el área de un triángulo
        public double areaTriangulo()
        {
            double areaTriangulo;
            areaTriangulo = (ladoT * alturaTriangulo()) / 2;

            return areaTriangulo;
        }

        //Método que calcula el perímetro de un Triángulo
        public double perimetroTriangulo()
        {
            double perimetroTriangulo;

            perimetroTriangulo =  ladoT * 3;

            return perimetroTriangulo;
        }

    }
}
