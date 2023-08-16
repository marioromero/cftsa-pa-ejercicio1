using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1_c
{
    public class Cuadrado : Figura
    {
        public Cuadrado()
        {
            Nombre = "Cuadrado";
            Id = 1;
            NumeroLados = 4;
        }
        public int Lado1 { get; set; }
        public int Lado2 { get; set; }
        public int Lado3 { get; set; }
        public int Lado4 { get; set; }

    }
}
