using System.Xml;
int tipo = 0;
int opcion = -1;
double duracion = 0;
int clasificacion = 0;
int hora = 0;
int produccion = 0;
int rechazados = 0;
int impacto = 0;
int contadorevaluados = 0;
int contadorrechazados = 0;
int EntrarEvaluacionTecnica = 0;
bool resultadotecnico = false;
int totalimpactos = 0;

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
    while (!int.TryParse(Console.ReadLine(), out opcion))
    {
        Console.WriteLine();
        Console.WriteLine("Entrada no válida. Por favor, ingrese un número.");
        Console.WriteLine();
    }
    Console.WriteLine("");
    Console.Clear();
    switch (opcion)
    {
        case 1:
            ValidacionDeDatos();
            resultadotecnico = ValidacionTecnica(EntrarEvaluacionTecnica);
            Console.WriteLine($"{ClasificacionImpacto(resultadotecnico)}");
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
    while (!int.TryParse(Console.ReadLine(), out tipo) || tipo < 1 || tipo > 4)
    {
        Console.WriteLine("");
        Console.Write("Error. Reingrese el tipo (número entre 1 y 4): ");
        Console.WriteLine("");
    }

    Console.WriteLine();
    Console.WriteLine("Presione ENTER para continuar");
    Console.WriteLine("");
    Console.ReadLine();
    Console.Clear();
    Console.WriteLine("");
    Console.WriteLine("Ingrese la duración del contenido (minutos)");
    Console.WriteLine("");
    while (!double.TryParse(Console.ReadLine(), out duracion) || duracion <= 0)
    {
        Console.WriteLine("");
        Console.Write("Error. Reingrese la duracion (número mayor a 0): ");
        Console.WriteLine("");
    }

    Console.WriteLine();
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
    while (!int.TryParse(Console.ReadLine(), out clasificacion) || clasificacion < 1 || clasificacion > 3)
    {
        Console.WriteLine("");
        Console.Write("Error. Reingrese clasificacion (número entre 1 y 3): ");
        Console.WriteLine("");
    }

    Console.WriteLine();
    Console.WriteLine("Presione ENTER para continuar");
    Console.WriteLine("");
    Console.ReadLine();
    Console.Clear();
    Console.Write("");
    Console.WriteLine("Ingrese la hora de transmisión del contenido (0-23)");
    Console.WriteLine("");
    while (!int.TryParse(Console.ReadLine(), out hora) || hora < 0 || hora > 23)
    {
        Console.WriteLine("");
        Console.Write("Error. Reingrese la hora (número entre 0 y 23): ");
        Console.WriteLine("");
    }

    Console.WriteLine();
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
    while (!int.TryParse(Console.ReadLine(), out produccion) || produccion < 1 || produccion > 3)
    {
        Console.WriteLine("");
        Console.Write("Error. Reingrese el nivel (número entre 1 y 3): ");
        Console.WriteLine("");
    }

    Console.WriteLine("");
    Console.WriteLine("Presione ENTER para continuar el proceso");
    Console.WriteLine("");
    Console.ReadLine();
    Console.Clear();
}

bool ValidacionTecnica(int b)
{
    if ((clasificacion==1 && (hora>=0 || hora<=23)) || (clasificacion==2 && (hora>=6 || hora<=22)) || (clasificacion==3 && (hora>=22 || hora<=5)))
    {
        if ((tipo==1 && (duracion>=60 && duracion<=180)) || (tipo==2 && (duracion>=20 && duracion<=90)) || (tipo==3 && (duracion>=30 && duracion<=120)) || (tipo==4 && (duracion>=30 && duracion<=240)))
        {
            if ((produccion==1 && (clasificacion==1 ||  clasificacion == 2)) || (produccion==2 ||produccion==3 ))
            {
                contadorevaluados++;
                Console.WriteLine();
                Console.WriteLine("Validación Técnica satisfactoria");
                Console.WriteLine();
                Console.WriteLine("Presione ENTER para continuar");
                Console.WriteLine("");
                Console.ReadLine();
                Console.Clear();
                return true;
            }
            else
            {
                contadorevaluados++;
                contadorrechazados++;
                Console.WriteLine("");
                Console.WriteLine("Validación Técnica insatisfactoria");
                Console.WriteLine();
                Console.WriteLine("No entra en ningún impacto");
                Console.WriteLine();
                Console.WriteLine("Desición Final: Rechazar");
                Console.WriteLine();
                Console.WriteLine("Razón: Incumple regla/s obligatorias");
                Console.WriteLine();
                Console.WriteLine("Presione ENTER para continuar");
                Console.WriteLine("");
                Console.ReadLine();
                Console.Clear();
                return false;
            }
        }
        else
        {
            contadorevaluados++;
            contadorrechazados++;
            Console.WriteLine("");
            Console.WriteLine("Validación Técnica insatisfactoria");
            Console.WriteLine();
            Console.WriteLine("No entra en ningún impacto");
            Console.WriteLine();
            Console.WriteLine("Desición Final: Rechazar");
            Console.WriteLine();
            Console.WriteLine("Razón: Incumple regla/s obligatorias");
            Console.WriteLine();
            Console.WriteLine("Presione ENTER para continuar");
            Console.WriteLine("");
            Console.ReadLine();
            Console.Clear();
            return false;
        }
    }
    else
    {
        contadorevaluados++;
        contadorrechazados++;
        Console.WriteLine("");
        Console.WriteLine("Validación Técnica insatisfactoria");
        Console.WriteLine();
        Console.WriteLine("No entra en ningún impacto");
        Console.WriteLine();
        Console.WriteLine("Desición Final: Rechazar");
        Console.WriteLine();
        Console.WriteLine("Razón: Incumple regla/s obligatorias");
        Console.WriteLine();
        Console.WriteLine("Presione ENTER para continuar");
        Console.WriteLine("");
        Console.ReadLine();
        Console.Clear();
        return false;
    }
}

string ClasificacionImpacto(bool b)
{
    if (produccion==3 || duracion>=120 || hora>=20 && hora<=23)
    {
        totalimpactos++;
        Console.WriteLine("Impacto del contenido: Alto");
        Console.WriteLine("");
        Console.WriteLine("Desición final: Enviar a revisión");
        Console.WriteLine("");
        Console.WriteLine("Razón: cumple reglas técnicas, pero tiene Impacto Alto");
        return "";
    }
    else if (produccion==2 || duracion>=60 && duracion<=120)
    {
        totalimpactos++;
        return "Impacto del contenido: Medio";
    }
    else if (produccion==1 && duracion<60)
    {
        totalimpactos++;
        return "Impacto del contenido: Bajo";
    }
    else
    {
        return "No entra a ningún impacto";
    }
}