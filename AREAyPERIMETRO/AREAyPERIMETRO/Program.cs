using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AREAyPERIMETRO
{
    class Program
    {
        static void Main(string[] args)
        {
            int b, a, area, perim, num;
            string si;
            do
            {
                Console.WriteLine("Elija una figura geométrica");
                Console.WriteLine("1.Cuadrado");
                Console.WriteLine("2.Rectángulo");
                Console.WriteLine("3.Triángulo");
                num = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Ingrese la base o el lado");
                b = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Ingrese la altura o el lado");
                a = Convert.ToInt32(Console.ReadLine());
                switch (num)
                {

                    case 1:
                        area = b * a;
                        perim = (a * 2) + (b * 2);
                        Console.WriteLine(" El área del cuadrado es: " + area + " El perímetro del cuadrado es: " + perim);
                        break;
                    case 2:
                        area = b * a;
                        perim = (a * 2) + (b * 2);
                        Console.WriteLine(" El área del rectángulo es: " + area + " El perímetro del rectángulo es: " + perim);
                        break;
                    case 3:
                        area = (b * a) / 2;
                        perim = b * 3;
                        Console.WriteLine(" El área del triángulo es: " + area + " El perímetro del triángulo es: " + perim);
                        break;

                }
                Console.WriteLine("¿Desea volver a intentarlo? Presione 0 para continuar. Enter para salir");
                si = (Console.ReadLine());
            }
            while (si == "0");
        }

    }
}
