using Ejercicio1_c;

int opcionFigura;
bool figuraValida = false;

while (!figuraValida) 
{
	opcionFigura = Helpers.SolicitarOpcion(); //muestra opciones y recibe elección del usuario

	if (opcionFigura < 4 && opcionFigura > 0)
	{
		var fig = ObtenerInstanciaFigura(opcionFigura);
		Console.WriteLine(fig.Nombre); //muestra el nombre por pantalla

		int lado = 1;
		while (lado <= fig.NumeroLados)
		{
			Console.WriteLine("Lado " + lado);
			lado++;
		}

		figuraValida = true;
	}
	else
	{
		Console.WriteLine("Ingresa una opción válida");
	}

}

dynamic ObtenerInstanciaFigura(int opc)
{
	dynamic obj = null;
	if (opc == 1)
		obj = new Cuadrado();
	//Otras opciones
	return obj;
}






