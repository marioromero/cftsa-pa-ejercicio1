using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1_c
{
	internal class Helpers
	{
		public static int SolicitarOpcion() //mètodo estático, puede llamarse sin hacer una instancia de su clase.
		{
			Console.WriteLine("Escoja el tipo de figura:");
			Console.WriteLine("Cuadrilátero: 1");
			Console.WriteLine("Triángulo: 2");
			Console.WriteLine("círculo: 3");

			return int.Parse(Console.ReadLine());
		}

		

	}
}
