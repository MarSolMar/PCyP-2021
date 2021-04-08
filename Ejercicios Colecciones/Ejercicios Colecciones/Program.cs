using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios_Colecciones
{
    class Program
    {
        //Vectores
        private static readonly string[] colors = { "MAGENTA", "RED", "WHITE", "BLUE", "CYAN" };
        private static readonly string[] removeColors = { "RED", "WHITE", "BLUE" };

        static void Main(string[] args)
        {


            //1- Manejo básico del diccionario
            Console.WriteLine("\n--------------------------------------------------------");
            Console.WriteLine("\nMANEJO DEL DICCIONARIO");


            //Creación y carga de los datos del diccionario
            Dictionary<String, String> agenda = new Dictionary<string, String>();

            agenda.Add("Juan",    "55423412");
            agenda.Add("Ernesto", "56985623");
            agenda.Add("Mariana", "54787451");

            //A) Existe un índice llamado "Juan" ?

            Console.WriteLine("\n--------------------------------------------------------");
            Console.WriteLine("A) Existe un índice llamado 'Juan' ?\n");

            if (agenda.ContainsKey("Juan"))
            {
                Console.WriteLine("TRUE");
                Console.WriteLine("\n El índice es:  " + agenda["Juan"]);
            }

           

            //B) Existe un índice llamado “Pedro”?

            String value;

            Console.WriteLine("\n--------------------------------------------------------");
            Console.WriteLine("\n B) Existe un índice llamado 'Pedro' ?\n");

            if (agenda.TryGetValue("Pedro", out value))
            {
                Console.WriteLine("TRUE");
                Console.WriteLine("\n El índice es:" + agenda["Pedro"]);
            }

            else
            {
                Console.WriteLine("FALSE");
                Console.WriteLine("\n No contiene la llave");
            }
           

            //C) Recorrer el diccionario mostrando todos sus datos: índice y valor

            Console.WriteLine("\n--------------------------------------------------------");
            Console.WriteLine("\n C) Contenido del diccionario: \n");
           

            foreach (var tupla in agenda)
            {
                Console.WriteLine(tupla.Key + "\t" + tupla.Value);

            }

            //D) Alterar el valor cuyo índice es "Mariana"

            Console.WriteLine("\n--------------------------------------------------------");
            Console.WriteLine("D) Alterar el valor cuyo índice es 'Mariana' \n");

            agenda["Mariana"] = "58251425";

            if (agenda.TryGetValue("Mariana", out value))
            {
                Console.WriteLine("TRUE");
                Console.WriteLine("\n Nuevo teléfono de Mariana:" + agenda["Mariana"]);
            }

            else
            {
                Console.WriteLine("FALSE");
                Console.WriteLine("\n No contiene la llave");
            }


            //2- Manejo de Listas
            Console.WriteLine("\n--------------------------------------------------------");
            Console.WriteLine("LISTAS");



            //A) Armar dos listas, con los valores de los vectores
            Console.WriteLine("\n--------------------------------------------------------");

            Console.WriteLine("\nA) Armar dos listas, con los valores de los vectores:\n");

            Console.WriteLine("private static readonly string[] colors = { MAGENTA, RED, WHITE, BLUE, CYAN };");
            Console.WriteLine("private static readonly string[] removeColors = { RED, WHITE, BLUE };");


            //Creación de las Listas
            List<String> colores        = new List<string>();
            List<String> removerColores = new List<string>();


            //Se agregan los valores de los vectores a las listas

            //Lista COLORS: se recorre el vector y se agregan los valores a la lista 'colores'
            for (int i = 0; i < colors.Length; i++)
            {
                colores.Add(colors[i]);
            }

            //Lista REMOVECOLORS: se recorre el vector y se agregan los valores a la lista 'colores'
            for (int i = 0; i < removeColors.Length; i++)
            {
                removerColores.Add(removeColors[i]);
            }


            //B) Mostrar las listas de colores por pantalla
            Console.WriteLine("\n--------------------------------------------------------");
            Console.WriteLine("\nB) Mostrar las listas de colores por pantalla");

            Console.WriteLine("\nLista COLORES:\n");

            foreach (String row in colores)
            {
                Console.WriteLine(row);
            }

            Console.WriteLine("\nLista REMOVERCOLORES:\n");

            foreach (String row in removerColores)
            {
                Console.WriteLine(row);
            }

            //C) De la lista de colores eliminar los colores listados en la otra lista (removeColors).
            Console.WriteLine("\n--------------------------------------------------------");
            Console.WriteLine("\nC) De la lista de colores eliminar los colores listados en la otra lista (removeColors).\n");

            for (int i = 0; i < colores.Count; i++)
            {
                for(int j = 0; j < removerColores.Count; j++)
                {
                    if (colores[i] == removerColores[j])
                    {
                        colores.RemoveAt(i);
                    }
                }
            }

            //D) Volver a mostrar la lista de colores por pantalla.
            Console.WriteLine("\n--------------------------------------------------------");
            Console.WriteLine("\nD) Volver a mostrar la lista de colores por pantalla:");

            Console.WriteLine("\nLista COLORES:\n");

            foreach (String row in colores)
            {
                Console.WriteLine(row);
            }

            //3- CONTADOR DE PALABRAS
            Console.WriteLine("\n--------------------------------------------------------");
            Console.WriteLine("\n3- CONTADOR DE PALABRAS\n");

           

            Dictionary <String, int> ocurrencias = new Dictionary<String, int>();

            int    cantidad = 0;
            String palabra = " ";

            String teclado;

            Console.WriteLine("\nIngrese un texto:\n");

            teclado = Console.ReadLine();

            string[] parrafo = teclado.Split(new char[] { '.', '?', '!', ' ', ';', ':', ',' }, StringSplitOptions.RemoveEmptyEntries);



            for (int i = 0; i < parrafo.Length; i++)
            {

                for (int j = 0; j < parrafo.Length; j++)
                {

                    if (parrafo[i] == parrafo[j])
                    {

                        cantidad++;
                     
                    }                  

                }

                if (!ocurrencias.ContainsKey(parrafo[i]))
                {
                    ocurrencias.Add(parrafo[i], cantidad);
                }
                else if (i == 0)
                {
                    ocurrencias.Add(parrafo[i], 1);
                }

                cantidad = 0;
                
            }


            Console.WriteLine("\nPalabra          " + "Cantidad\n");
            Console.WriteLine("------------------------------------\n");

            foreach (var tupla in ocurrencias)
            {             
                Console.WriteLine(tupla.Key + "\t" + "\t" + "\t" +  tupla.Value);        
            }



            //4- NETFLIX
            Console.WriteLine("\n--------------------------------------------------------");
            Console.WriteLine("\n4- NETFLIX\n");




            Console.WriteLine("\n Presione cualquier tecla para salir.");
            System.Console.ReadKey();

        }


    }
}
