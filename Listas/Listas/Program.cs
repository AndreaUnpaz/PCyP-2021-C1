using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Listas
{
    class Program
    {
        static void Main(string[] args)
        {

            List<string> colors = new List<string> { "MAGENTA", "RED", "WHITE", "BLUE", "CYAN" };
            List<string> removeColors = new List<string> { "RED", "WHITE", "BLUE" };

            MostrarVector(colors);

            for (int i = 0; i < colors.Count; i++)
            {
                for (int r = 0; r < removeColors.Count; r++)
                {
                    if (colors[i].Equals(removeColors[r]))
                    {
                        colors.RemoveAt(i);

                    }
                }
            }
            Console.WriteLine("Presione una tecla para continuar");
            Console.ReadLine();
            Console.WriteLine("Lista, luego de remover ítems: ");
            MostrarVector(colors);

            Console.ReadLine();
        }

        public static void MostrarVector(List<string> vector)
        {
            foreach (var i in vector)
            {
                Console.WriteLine(i);
            }
        }
    }
}