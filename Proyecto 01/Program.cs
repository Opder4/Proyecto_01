using System.Xml;
int tipocontenido = 0;
int opcion = -1;
double duracioncontendio = 0;
int clasificacioncontenido = 0;
int horaprogramacion = 0;
int nivelproduccion = 0;
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
            Console.WriteLine("Seleccione el tipo de contenido a envíar");
            Console.WriteLine();
            Console.WriteLine("1. Película");
            Console.WriteLine("2. Serie");
            Console.WriteLine("3. Documental");
            Console.WriteLine("4. Evento en vivo");
            Console.WriteLine("");
            tipocontenido=int.Parse(Console.ReadLine());
            Console.WriteLine("");
            Console.Clear();
            //Aquí empieza la validación de los datos para proseguir con la evaluación
            while (tipocontenido>=1 && tipocontenido<=4)
            {
                Console.WriteLine("Ingrese la duración del contendio (minutos): ");
                Console.WriteLine("");
                duracioncontendio=double.Parse(Console.ReadLine());
                Console.WriteLine("");
                Console.Clear();
                while (duracioncontendio>0)
                {
                    Console.WriteLine("Seleccione la clasificación del contenido");
                    Console.WriteLine("");
                    Console.WriteLine("1. Para todo público");
                    Console.WriteLine("2. Contenido +13");
                    Console.WriteLine("3. Contenido +18");
                    Console.WriteLine("");
                    clasificacioncontenido=int.Parse(Console.ReadLine());
                    Console.WriteLine("");
                    Console.Clear();
                    while (clasificacioncontenido>=1 && clasificacioncontenido<=3)
                    {
                        Console.WriteLine("Ingrese la hora de programación del contenido (0-23)");
                        Console.WriteLine("");
                        horaprogramacion=int.Parse(Console.ReadLine());
                        Console.WriteLine("");
                        Console.Clear();
                        while (horaprogramacion>=0 && horaprogramacion<=23)
                        {
                            Console.WriteLine("Seleccione el nivel de producción del contenido");
                            Console.WriteLine("");
                            Console.WriteLine("1. Bajo");
                            Console.WriteLine("2. Medio");
                            Console.WriteLine("3. Alto");
                            Console.WriteLine("");
                            nivelproduccion=int.Parse(Console.ReadLine());
                            Console.WriteLine("");
                            Console.Clear();
                            while (nivelproduccion>=1 && nivelproduccion<=3)
                            {
                                // Aquí empieza la validación técnica, la clasificación del tiempo, y la desición final
                            }
                            Console.WriteLine("Opción del nivel de producción no válida");
                            Console.WriteLine("Presione ENTER");
                            Console.WriteLine("");
                            Console.ReadLine();
                            Console.Clear();
                        }
                        Console.WriteLine("Hora de programación no válida");
                        Console.WriteLine("Presione ENTER");
                        Console.WriteLine("");
                        Console.ReadLine();
                        Console.Clear();
                    }
                    Console.WriteLine("Opción de clasificación no válida");
                    Console.WriteLine("Presione ENTER");
                    Console.WriteLine("");
                    Console.ReadLine();
                    Console.Clear();
                }
                Console.WriteLine("Duración de contenido no válido");
                Console.WriteLine("Presione ENTER");
                Console.WriteLine("");
                Console.ReadLine();
                Console.Clear();
            }
            Console.WriteLine("Opción de contenido no válida");
            Console.WriteLine("Presione ENTER");
            Console.WriteLine("");
            Console.ReadLine();
            Console.Clear();
            break;
        case 2:

            break;
        case 3:

            break;

        case 4:
            duracioncontendio = 0;
            clasificacioncontenido = 0;
            horaprogramacion = 0;
            nivelproduccion = 0;
            tipocontenido = 0;
            Console.WriteLine("Estadísticas reiniciadas");
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
            Console.ReadLine();
            Console.Clear();
            break;
    }
} while (opcion != 5);
Console.WriteLine("Programa finalizado");