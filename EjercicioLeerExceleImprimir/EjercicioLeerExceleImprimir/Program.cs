using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioLeerExceleImprimir
{
    class Program
    {
        static void Main(string[] args)
        {

            LeerArchivo archivo = new LeerArchivo();

            //String[] auxiliar;
            //auxiliar = archivo.imprimir();

            archivo.imprimir();

        }
    }
}
