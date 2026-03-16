using System.Xml;
int tipo = 0;
int opcion = -1;
double duracion = 0;
int clasificacion = 0;
int hora = 0;
int produccion = 0;

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
    Console.Clear();
    switch (opcion)
    {
        case 1:
            ValidacionDeDatos();
            Console.WriteLine();
            Console.WriteLine("Presione ENTER para volver al menú");
            Console.WriteLine();
            Console.ReadLine();
            Console.Clear();
            break;
        case 2:

            break;
        case 3:

            break;

        case 4:
            duracion = 0;
            clasificacion = 0;
            hora = 0;
            produccion = 0;
            tipo = 0;
            Console.WriteLine("Estadísticas reiniciadas");
            Console.WriteLine();
            Console.WriteLine("Presione Enter");
            Console.WriteLine("");
            Console.ReadLine();
            Console.Clear();
            break;
        case 5:
            Console.WriteLine("Saliendo del programa...");
            Console.WriteLine("");
            break;
        default:
            Console.WriteLine("Opción no válida");
            Console.WriteLine("");
            Console.WriteLine("Elija una opción que sea válida");
            Console.WriteLine("");
            Console.WriteLine("Presione Enter para continuar");
            Console.ReadLine();
            Console.Clear();
            break;
    }
} while (opcion != 5);
Console.WriteLine("Programa finalizado");

void ValidacionDeDatos()
{
    Console.WriteLine("Seleccione el Tipo de Contenido a enviar");
    Console.WriteLine("");
    Console.WriteLine("1. Pelicula");
    Console.WriteLine("2. Serie");
    Console.WriteLine("3. Documental");
    Console.WriteLine("4. En vivo");
    Console.WriteLine("");
    tipo = int.Parse(Console.ReadLine());
    Console.WriteLine("");
    while (tipo < 1 || tipo > 4)
    {
        Console.WriteLine("");
        Console.Write("Error. Reingrese el tipo: ");
        Console.WriteLine("");
        tipo = int.Parse(Console.ReadLine());
        Console.WriteLine("");
    }

    Console.WriteLine("Presione ENTER para continuar");
    Console.WriteLine("");
    Console.ReadLine();
    Console.Clear();
    Console.WriteLine("");
    Console.WriteLine("Ingrese la duración del contenido (minutos)");
    Console.WriteLine("");
    duracion = int.Parse(Console.ReadLine());
    Console.WriteLine("");
    while (duracion <= 0)
    {
        Console.WriteLine("");
        Console.Write("Error. Reingrese duracion: ");
        Console.WriteLine("");
        duracion = int.Parse(Console.ReadLine());
        Console.WriteLine("");
    }

    Console.WriteLine("Presione ENTER para continuar");
    Console.WriteLine("");
    Console.ReadLine();
    Console.Clear();
    Console.WriteLine("Seleccione la clasificación del contenido");
    Console.WriteLine("");
    Console.WriteLine("1. Todo publico");
    Console.WriteLine("2. +13");
    Console.WriteLine("3. +18");
    Console.WriteLine("");
    clasificacion = int.Parse(Console.ReadLine());
    Console.WriteLine("");
    while (clasificacion < 1 || clasificacion > 3)
    {
        Console.WriteLine("");
        Console.Write("Error. Reingrese clasificacion: ");
        Console.WriteLine("");
        clasificacion = int.Parse(Console.ReadLine());
        Console.WriteLine("");
    }

    Console.WriteLine("Presione ENTER para continuar");
    Console.WriteLine("");
    Console.ReadLine();
    Console.Clear();
    Console.Write("");
    Console.WriteLine("Ingrese la hora de transmisión del contenido (0-23)");
    Console.WriteLine("");
    hora = int.Parse(Console.ReadLine());
    Console.WriteLine("");
    while (hora < 0 || hora > 23)
    {
        Console.WriteLine("");
        Console.Write("Error. Reingrese la hora: ");
        Console.WriteLine("");
        hora = int.Parse(Console.ReadLine());
        Console.WriteLine("");
    }

    Console.WriteLine("Presione ENTER para continuar");
    Console.WriteLine("");
    Console.ReadLine();
    Console.Clear();
    Console.WriteLine("Seleccione el nivel de producción del contenido");
    Console.WriteLine("");
    Console.WriteLine("1. Bajo");
    Console.WriteLine("2. Medio");
    Console.WriteLine("3. Alto");
    Console.WriteLine("");
    produccion = int.Parse(Console.ReadLine());
    while (produccion < 1 || produccion > 3)
    {
        Console.WriteLine("");
        Console.Write("Error. Reingrese el nivel: ");
        Console.WriteLine("");
        produccion = int.Parse(Console.ReadLine());
        Console.WriteLine("");
    }
    Console.WriteLine("");
    Console.WriteLine("Presione ENTER para continuar el proceso");
    Console.WriteLine("");
    Console.ReadLine();
    Console.Clear();
}