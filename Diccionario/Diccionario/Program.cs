using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diccionario
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> values = new Dictionary<string, string>();
            values.Add("Juan", "55423412");
            values.Add("Ernesto", "56985623");
            values.Add("Mariana", "54787451");

            string key = "Juan";
            if (values.ContainsKey(key))
            {
                Console.WriteLine("Teléfono de Juan: " + values["Juan"]);
            }

            string value = "Pedro";
            if (values.TryGetValue("Pedro", out value))
            {
                Console.WriteLine("El teléfono de Pedro es " + values["Pedro"]);
            }
            else
            {
                Console.WriteLine("No contiene la llave");
            }

            foreach (var pair in values)
            {
                Console.WriteLine(pair.Key + ", " + pair.Value);
            }

            values.Remove("Mariana");
            values.Add("Mariana", "58251425");
            Console.WriteLine("Nuevo teléfono de Mariana: " + values["Mariana"]);
            Console.ReadLine();


        }
    }

}