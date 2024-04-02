class EjercicioColeccionesOperadores
{
    static void Main(string[] args)
    {
        Console.WriteLine("Ingrese el numero de la solucion que desea obtener");
        int opcion;
        bool esNumero = int.TryParse(Console.ReadLine(), out opcion);

        if (!esNumero || opcion < 1 || opcion > 19)
        {
            Console.WriteLine("Error. Debe ingresar un numero entre 1 y 19");
            return;
        }

        try
        {
            switch (opcion)
            {
                case 3:
                    Console.WriteLine("Ingrese un numero:");
                    int numero = int.Parse(Console.ReadLine());

                    if (numero < 0)
                    {
                        Console.WriteLine("El numero ingresado es negativo");
                    } else if(numero > 0)
                    {
                        Console.WriteLine("El numero ingresado es positivo");
                    } else
                    {
                        Console.WriteLine("El numero ingresado es 0");
                    }
                    break;

                default:
                    Console.WriteLine("Error, número de solución no válido.");
                    break;

                case 11:
                    int[] numeros = { 9, 1, 5, 3, 8, 2, 5 };
                    Console.WriteLine("El numero minimo es: " + numeros.Min());
                    Console.WriteLine("El numero maximo es: " + numeros.Max());
                    break;

                case 15:
                    List<int> numerosLista = new List<int> { 6, 3, 4, 8, 10 };
                    Console.WriteLine("La suma de todos los numeros de la lista es: " + numerosLista.Sum());
                    break;

                    case 19:
                    Dictionary<string, int> edades = new Dictionary<string, int>() { 
                        { "Lucia", 15 },
                        { "Diego", 18 }, 
                        { "Pedro", 16 }, 
                        { "Juan", 17 }, 
                        { "Sofia", 18 } 
                    };
                    double promedio = edades.Values.Average();
                    Console.WriteLine("El promedio de las edades es de: " + promedio);
                    break;
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error: " + ex.Message);
        }
    }
}
