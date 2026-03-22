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
int totalimpactosbajos = 0;
int totalimpactosaltos = 0;
int totalimpactosmedios = 0;
int totalpublicados = 0;
int totalenrevision = 0;

do
{
    Console.WriteLine("              MENÚ");
    Console.WriteLine();
    for (int i = 1; i<=35; i++)
    {
        Console.Write("-");
    }
    Console.WriteLine();
    Console.WriteLine();
    Console.WriteLine("1. Evaluar Nuevo Contendio");
    Console.WriteLine();
    Console.WriteLine("2. Mostrar Reglas del Sistema");
    Console.WriteLine();
    Console.WriteLine("3. Mostrar Estadísticas de la Sesión");
    Console.WriteLine();
    Console.WriteLine("4. Reiniciar Estadísticas");
    Console.WriteLine();
    Console.WriteLine("5. Salir");
    Console.WriteLine("");
    for (int i = 1; i <= 35; i++)
    {
        Console.Write("-");
    }
    Console.WriteLine();
    Console.WriteLine();
    Console.WriteLine("Elija una Opción");
    Console.WriteLine();
    while (!int.TryParse(Console.ReadLine(), out opcion))
    {
        Console.WriteLine();
        Console.WriteLine("Entrada no válida. Por favor, Ingrese una Opción.");
        Console.WriteLine();
    }
    Console.WriteLine("");
    Console.Clear();
    switch (opcion)
    {
        case 1:
            ValidacionDeDatos();
            resultadotecnico = ValidacionTecnica(EntrarEvaluacionTecnica);
            Console.WriteLine();
            duracion = 0;
            clasificacion = 0;
            hora = 0;
            produccion = 0;
            tipo = 0;
            Console.WriteLine("Presione ENTER para volver al menú");
            Console.WriteLine();
            Console.ReadLine();
            Console.Clear();
            break;
        case 2:
            MostrarReglas();
            break;
        case 3:
           EstadisticasSesion();
            break;
        case 4:
            contadorevaluados = 0;
            totalpublicados = 0;
            contadorrechazados = 0;
            totalenrevision = 0;
            totalimpactosaltos = 0;
            totalimpactosmedios = 0;
            totalimpactosbajos = 0;
            Console.WriteLine("Estadísticas reiniciadas");
            Console.WriteLine();
            Console.WriteLine("Presione ENTER");
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
            Console.WriteLine("Elija una Opción que sea válida");
            Console.WriteLine("");
            Console.WriteLine("Presione ENTER para continuar");
            Console.ReadLine();
            Console.Clear();
            break;
    }
} while (opcion != 5);
EstadisticasSesion();
Console.WriteLine();
Console.WriteLine("Programa Finalizado");

void ValidacionDeDatos()
{
    Console.WriteLine("Seleccione el Tipo de Contenido");
    Console.WriteLine("");
    Console.WriteLine("1. Pelicula");
    Console.WriteLine("2. Serie");
    Console.WriteLine("3. Documental");
    Console.WriteLine("4. En vivo");
    Console.WriteLine("");
    while (!int.TryParse(Console.ReadLine(), out tipo) || tipo < 1 || tipo > 4)
    {
        Console.WriteLine("");
        Console.Write("Error. Reingrese el Tipo (número entre 1 y 4): ");
        Console.WriteLine("");
    }

    Console.WriteLine();
    Console.WriteLine("Presione ENTER para continuar");
    Console.WriteLine("");
    Console.ReadLine();
    Console.Clear();
    Console.WriteLine("");
    Console.WriteLine("Ingrese la Duración del Contenido (minutos)");
    Console.WriteLine("");
    while (!double.TryParse(Console.ReadLine(), out duracion) || duracion <= 0)
    {
        Console.WriteLine("");
        Console.Write("Error. Reingrese la Duracion (número mayor a 0): ");
        Console.WriteLine("");
    }

    Console.WriteLine();
    Console.WriteLine("Presione ENTER para continuar");
    Console.WriteLine("");
    Console.ReadLine();
    Console.Clear();
    Console.WriteLine("Seleccione la Clasificación del Contenido");
    Console.WriteLine("");
    Console.WriteLine("1. Todo publico");
    Console.WriteLine("2. +13");
    Console.WriteLine("3. +18");
    Console.WriteLine("");
    while (!int.TryParse(Console.ReadLine(), out clasificacion) || clasificacion < 1 || clasificacion > 3)
    {
        Console.WriteLine("");
        Console.Write("Error. Reingrese Clasificacion (número entre 1 y 3): ");
        Console.WriteLine("");
    }

    Console.WriteLine();
    Console.WriteLine("Presione ENTER para continuar");
    Console.WriteLine("");
    Console.ReadLine();
    Console.Clear();
    Console.Write("");
    Console.WriteLine("Ingrese la Hora de Transmisión del Contenido (0-23)");
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
    Console.WriteLine("Seleccione el nivel de Producción del Contenido");
    Console.WriteLine("");
    Console.WriteLine("1. Bajo");
    Console.WriteLine("2. Medio");
    Console.WriteLine("3. Alto");
    Console.WriteLine("");
    while (!int.TryParse(Console.ReadLine(), out produccion) || produccion < 1 || produccion > 3)
    {
        Console.WriteLine("");
        Console.Write("Error. Reingrese el Nivel (número entre 1 y 3): ");
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
    if ((clasificacion==1 && (hora>=0 || hora<=23)) || (clasificacion==2 && (hora>=5 && hora<=23)) || (clasificacion==3 && ((hora>=20 && hora<=23) ||(hora>=0 && hora<=6))))
    {
        if ((tipo==1 && (duracion>=60 && duracion<=180)) || (tipo==2 && (duracion>=20 && duracion<=90)) || (tipo==3 && (duracion>=30 && duracion<=120)) || (tipo==4 && (duracion>=30 && duracion<=240)))
        {
            if ((produccion==1 && (clasificacion==1 ||  clasificacion == 2)) || (produccion==2 ||produccion==3 ))
            {
                contadorevaluados++;
                Console.WriteLine();
                Console.WriteLine("Validación Técnica Satisfactoria");
                Console.WriteLine();
                Console.WriteLine("Presione ENTER para continuar");
                Console.WriteLine("");
                Console.ReadLine();
                Console.Clear();
                Console.WriteLine($"{ClasificacionImpacto(resultadotecnico)}");
                return true;
            }
            else
            {
                contadorevaluados++;
                contadorrechazados++;
                Console.WriteLine();
                Console.WriteLine("No entra en ningún Impacto");
                Console.WriteLine();
                Console.WriteLine("Decisión Final: Rechazar");
                Console.WriteLine();
                Console.WriteLine("Razón: Incumple regla/s obligatoria/s");
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
            Console.WriteLine();
            Console.WriteLine("No entra en ningún Impacto");
            Console.WriteLine();
            Console.WriteLine("Decisión Final: Rechazar");
            Console.WriteLine();
            Console.WriteLine("Razón: Incumple regla/s obligatoria/s");
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
        Console.WriteLine();
        Console.WriteLine("No entra en ningún Impacto");
        Console.WriteLine();
        Console.WriteLine("Decisión Final: Rechazar");
        Console.WriteLine();
        Console.WriteLine("Razón: Incumple regla/s obligatoria/s");
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
    if ((produccion == 3 || duracion > 120 || hora >= 20 && hora <= 23) || ((produccion == 2 && ((tipo == 2 && duracion >= 60 && duracion <= 90) || (tipo == 3 && duracion >= 60 && duracion <= 120) || (tipo == 4 && duracion >= 60 && duracion <= 120) || (tipo == 1 && duracion >= 60 && duracion <= 120))) && (produccion == 1 && ((tipo == 2 && duracion >= 20 && duracion < 60) || (tipo == 3 && duracion >= 30 && duracion < 60) || (tipo == 4 && duracion >= 30 && duracion < 60)))))
    {
        totalenrevision++;
        totalimpactosaltos++;
        Console.WriteLine("Impacto del Contenido: Alto");
        Console.WriteLine("");
        Console.WriteLine("Decisión Final: Enviar a Revisión");
        Console.WriteLine("");
        Console.WriteLine("Razón: Cumple Reglas Técnicas, pero tiene Impacto Alto");
        return "";
    }
    else if (produccion == 2 && ((tipo == 2 && duracion >= 60 && duracion <=90) || (tipo == 3 && duracion >= 60 && duracion <= 120) || (tipo == 4 && duracion >= 60 && duracion <= 120) || (tipo == 1 && duracion >= 60 && duracion <=120)))
    {
        if ((clasificacion == 2 && (hora == 5 || hora == 23)) || (clasificacion == 3 && ((hora == 20 || hora==21 || hora == 6))))
        {
            totalimpactosmedios++;
            Console.WriteLine("Impacto del Contenido: Medio");
            Console.WriteLine();
            Console.WriteLine("Desición Final: Publicar con Ajustes");
            Console.WriteLine();
            Console.WriteLine("Razón: Cumple con Reglas Técnicas, pero se necesita ajustar el Horario permitido");
            Console.WriteLine();
            return "";
        }
        else
        {
            totalpublicados++;
            totalimpactosmedios++;
            Console.WriteLine("Impacto del Contenido: Medio");
            Console.WriteLine();
            Console.WriteLine("Decisión Final: Publicar");
            Console.WriteLine();
            Console.WriteLine("Razón: Cumple con Reglas Técnicas y tiene Impacto Medio");
            Console.WriteLine();
            return "";
        }
    }
    else if (produccion == 1 && ((tipo == 2 && duracion >= 20 && duracion<60) || (tipo == 3 && duracion >=30 && duracion<60) || (tipo == 4 && duracion >= 30 && duracion < 60)))
    {
        if ((clasificacion == 2 && (hora == 5 || hora == 23)) || (clasificacion == 3 && ((hora == 20 || hora == 21 || hora == 6))))
        {
            totalimpactosbajos++;
            Console.WriteLine("Impacto del Contenido: Bajo");
            Console.WriteLine();
            Console.WriteLine("Decisión Final: Publicar con Ajustes");
            Console.WriteLine();
            Console.WriteLine("Razón: Cumple con Reglas Técnicas, pero se necesita ajustar el Horario permitido");
            Console.WriteLine();
            return "";
        }
        else
        {
            totalpublicados++;
            totalimpactosbajos++;
            Console.WriteLine("Impacto del Contenido: Bajo");
            Console.WriteLine("");
            Console.WriteLine("Decisión Final: Publicar");
            Console.WriteLine();
            Console.WriteLine("Razón: Cumple con Reglas Técnicas y tiene Impacto Bajo");
            Console.WriteLine();
            return "";
        }
    }
    else
    {
        return "";
    }
}

void MostrarReglas()
{
    for (int i = 0; i < 50; i++)
    {
        Console.Write("-");
    }
    Console.WriteLine("");
    Console.WriteLine("          REGLAS OBLIGATORIAS DEL SISTEMA");
    for (int i = 0; i < 50; i++)
    {
        Console.Write("-");
    }
    Console.WriteLine("");

    Console.WriteLine("");
    Console.WriteLine("1. REGLAS DE CLASIFICACIÓN Y HORARIO");
    Console.WriteLine();
    Console.WriteLine("- Todo público: permitido a cualquier hora.");
    Console.WriteLine();
    Console.WriteLine("- +13: permitido entre las 5 y las 23 horas.");
    Console.WriteLine("  *Nota de ajustes: Si se programa a las 5 o 23 horas, se decide 'Publicar con ajustes'.");
    Console.WriteLine();
    Console.WriteLine("- +18: permitido entre las 20 y las 6 horas.");
    Console.WriteLine("  *Nota de ajustes: Si se programa a las 20, 21 o 6 horas, se decide 'Publicar con ajustes'.");
    Console.WriteLine();
    Console.WriteLine("");
    Console.WriteLine("2. REGLAS DE DURACIÓN POR TIPO DE CONTENIDO");
    Console.WriteLine();
    Console.WriteLine("- Película: 60-180 minutos.");
    Console.WriteLine("- Serie: 20-90 minutos.");
    Console.WriteLine("- Documental: 30-120 minutos.");
    Console.WriteLine("- Evento en vivo: 30-240 minutos.");
    Console.WriteLine();
    Console.WriteLine("");
    Console.WriteLine("3. REGLAS DE NIVEL DE PRODUCCIÓN");
    Console.WriteLine();
    Console.WriteLine("-Producción baja: solo válida para Todo público o +13");
    Console.WriteLine("- Producción media o alta: válida para cualquier clasificación.");
    Console.WriteLine();
    Console.WriteLine("");
    Console.WriteLine("4. CLASIFICACIÓN DE IMPACTO");
    Console.WriteLine();
    Console.WriteLine("- Impacto Alto: producción alta, o duración mayor a 120 minutos, o programado entre 20 y 23 horas.");
    Console.WriteLine("- Impacto Medio: producción media o duración entre 60 y 120 minutos.");
    Console.WriteLine("- Impacto Bajo: producción baja y duración menor a 60 minutos.");
    Console.WriteLine();
    Console.WriteLine("");
    for (int i = 0; i < 50; i++)
    {
        Console.Write("-");
    }
    Console.WriteLine();
    Console.WriteLine("");
    Console.WriteLine("Presione ENTER para volver al menú");
    Console.ReadLine();
    Console.Clear();
}
void EstadisticasSesion()
{
    for (int i = 0; i < 50; i++)
    {
        Console.Write("-");
    }
    Console.WriteLine();
    Console.Write("           ESTADÍSTICAS DE LA SESIÓN");
    Console.WriteLine();
    for (int i = 0; i < 50; i++)
    {
        Console.Write("-");
    }
    Console.WriteLine();
    Console.WriteLine();
    Console.WriteLine($"Total de Contenidos Evaluados: {contadorevaluados}");
    Console.WriteLine();
    Console.WriteLine($"Total de Contenidos Publicados: {totalpublicados}");
    Console.WriteLine();
    Console.WriteLine($"Total de Contenidos Rechazados: {contadorrechazados}");
    Console.WriteLine();
    Console.WriteLine($"Total de Contenidos en Revisión: {totalenrevision}");
    Console.WriteLine();
    if (totalimpactosaltos > totalimpactosmedios && totalimpactosaltos > totalimpactosbajos)
    {
        Console.WriteLine("El Impacto predominante es el Impacto Alto");
        Console.WriteLine();
    }
    else if (totalimpactosmedios > totalimpactosaltos && totalimpactosmedios > totalimpactosbajos)
    {
        Console.WriteLine("El Impacto predominante es el Impacto Medio");
        Console.WriteLine();
    }
    else if (totalimpactosbajos > totalimpactosaltos && totalimpactosbajos > totalimpactosmedios)
    {
        Console.WriteLine("El Impacto predominante es el Impacto Bajo");
        Console.WriteLine();
    }
    else
    {
        Console.WriteLine("No hay un solo Impacto predominante por ahora");
        Console.WriteLine();
    }
    if (contadorevaluados==0)
    {
        Console.WriteLine($"El Porcentaje de Aprobación es del 0%");
        Console.WriteLine();
    }
    else
    {
        Console.WriteLine($"El Porcentaje de Aprobación es del {(totalpublicados / contadorevaluados) * 100}%");
        Console.WriteLine();
    }
    for (int i = 0; i < 50; i++)
    {
        Console.Write("-");
    }
    Console.WriteLine();
    Console.WriteLine();
    Console.WriteLine("Presione ENTER para volver al menú");
    Console.WriteLine("");
    Console.ReadLine();
    Console.Clear();
}