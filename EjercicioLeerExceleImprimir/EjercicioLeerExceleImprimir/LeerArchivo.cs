using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioLeerExceleImprimir
{
    class LeerArchivo
    {
        //Variable para almacenar la ruta del archivo
        private String ruta;
        //private String barra = "\";

        //Método constructor
        public LeerArchivo()
        {
            Console.WriteLine("Ingrese la ruta del archivo que desea imprimir:");


            ruta = Console.ReadLine();

            //Como no puede pegar en la consola la ruta la dejo literal
           //ruta = "C:\Users\PC1\Desktop\UNPAZ 2021\1er Cuatrim.2021\PCyP (Optativa 1)\2- Clase 1\Ejercicios clase 1\vial.csv";

          
        }

        //Método que imprime el contenido del archivo por pantalla
        public void imprimir()
        {
            //Recupera el contenido del archivo en "lines"
            string[] lines = System.IO.File.ReadAllLines(ruta);

            //Se imprime por pantalla la cabecera del archivo
            System.Console.WriteLine("número-de-hoja     tipo-objeto  -   identificador-tramo  -  tipo-camino -  longitud");


            //Se recorre cada línea del archivo y se la muestra por pantalla
            foreach (string line in lines)
            {

                Console.WriteLine("\t" + line);
            }

            Console.WriteLine("Presione cualquier tecla para salir.");
            System.Console.ReadKey();


        }

    }
}
