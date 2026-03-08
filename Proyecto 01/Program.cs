int opcion = -1;
do
{
    Console.WriteLine("Menú");
    Console.WriteLine("");
    Console.WriteLine("1. Evaluar nuevo contendio");
    Console.WriteLine("2. Mostrar reglas del sistema");
    Console.WriteLine("3. Mostrar estadísticas de la sesión");
    Console.WriteLine("4. Reiniciar estadísticas");
    Console.WriteLine("5. Salir");
    Console.WriteLine("");
    opcion =int.Parse(Console.ReadLine());
    Console.WriteLine("");
    switch (opcion)
    {
        case 1:

            break;
        case 2:

            break;
        case 3:

            break;

        case 4:

            break;
        case 5:
            Console.WriteLine("Saliendo del programa...");
            Console.WriteLine("");
            break;
        default:
            Console.WriteLine("Opción no válida");
            Console.WriteLine("");
            Console.WriteLine("Elija una opción que sea válida");
            break;
    }
} while (opcion != 5);
Console.WriteLine("Programa finalizado");