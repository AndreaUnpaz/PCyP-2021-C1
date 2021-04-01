using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArchivoCSV
{
    class ArchivoVial
    {
        private string número_de_hoja;
        private string tipo_objeto;
        private string identificador_tramo;
        private string tipo_camino;
        private string longitud;

        public string Número_de_hoja
        {
            get
            {
                return número_de_hoja;
            }

            set
            {
                número_de_hoja = value;
            }
        }

        public string Tipo_objeto
        {
            get
            {
                return tipo_objeto;
            }

            set
            {
                tipo_objeto = value;
            }
        }

        public string Identificador_tramo
        {
            get
            {
                return identificador_tramo;
            }

            set
            {
                identificador_tramo = value;
            }
        }

        public string Tipo_camino
        {
            get
            {
                return tipo_camino;
            }

            set
            {
                tipo_camino = value;
            }
        }

        public string Longitud
        {
            get
            {
                return longitud;
            }

            set
            {
                longitud = value;
            }
        }

        public ArchivoVial(string número_de_hoja, string tipo_objeto, string identificador_tramo, string tipo_camino, string longitud)
        {
            this.número_de_hoja = número_de_hoja;
            this.tipo_objeto = tipo_objeto;
            this.identificador_tramo = identificador_tramo;
            this.tipo_camino = tipo_camino;
            this.longitud = longitud;
        }
        public ArchivoVial()
        {

        }

        public void imprimir()
        {
            Console.WriteLine("Número_de_hoja: " + this.número_de_hoja);
            Console.WriteLine("Tipo_objeto: " + this.tipo_objeto);
            Console.WriteLine("Identificador_tramo: " + this.identificador_tramo);
            Console.WriteLine("Tipo_camino: " + this.tipo_camino);
            Console.WriteLine("Longitud: " + this.longitud);
        }
    }
}

   