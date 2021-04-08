using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contador
{
    class Program
    {
        static void Main(string[] args)
        {
            string parrafo = "Son las 5 menos 5 faltan 5 para las 5 cuantas veces dije 5 sin contar el primer 5";
            string[] arr = parrafo.Split(' ');
            Console.WriteLine("El párrafo es: Son las 5 menos 5 faltan 5 para las 5 cuantas veces dije 5 sin contar el primer 5");

            Dictionary<string, int> words = new Dictionary<string, int>();


            for (int i = 0; i < arr.Length; i++)
            {
                if (words.ContainsKey(arr[i]))
                {
                    words[arr[i]]++;
                }
                else
                {
                    words.Add(arr[i], 1);
                }
            }

            Console.WriteLine();
            Mostrar(words);

            Console.WriteLine("Cantidad de palabras distintas: " + words.Keys.Count);
            Console.WriteLine("Presione enter para continuar");
            Console.ReadLine();


        }

        public static void Mostrar(Dictionary<string, int> words)
        {
            Console.WriteLine("Key" + "\t\t\t Value \n");
            foreach (var value in words)
            {
                Console.WriteLine(value.Key.PadRight(10) + "\t\t   " + value.Value);
            }

        }
    }
}
