using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_1
{
    class Program
    {

 

        static void Main(string[] args)
        {

            Console.WriteLine("------------Rectángulo--------------------");
            double auxR;

            Rectangulo Rect = new Rectangulo();

            auxR = Rect.areaRectangulo();
            Console.WriteLine("El área del rectángulo es: {0}", auxR);
            Console.ReadLine();

            auxR = Rect.perimetroRectangulo();
            Console.WriteLine("El perímetro del rectángulo es: {0}", auxR);
            Console.ReadLine();


            Console.WriteLine("------------Cuadrado--------------------");
            double auxC;

            Cuadrado Cuad = new Cuadrado();

            auxC = Cuad.areaCuadrado();
            Console.WriteLine("El área del cuadrado es: {0}", auxC);
            Console.ReadLine();

            auxC = Cuad.perimetroCuadrado();
            Console.WriteLine("El perímetro del cuadrado es: {0}", auxC);
            Console.ReadLine();


            Console.WriteLine("------------Triángulo equilátero--------------------");
            double auxT;

            Triangulo Triang = new Triangulo();

            auxT = Triang.areaTriangulo();
            Console.WriteLine("El área del triángulo es: {0}", auxT);
            Console.ReadLine();

            auxT = Triang.perimetroTriangulo();
            Console.WriteLine("El perímetro del triángulo es: {0}", auxT);
            Console.ReadLine();
        }
    }
}
