using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArchivoCSV
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] lineas = File.ReadAllLines("./FILES/vial.csv");

            foreach (var linea in lineas)
            {
                var valores = linea.Split(',');
                ArchivoVial items = new ArchivoVial(valores[0], valores[1], valores[2], valores[3], valores[4]);
                items.imprimir();
                Console.ReadLine();

            }
        }
    }
}
