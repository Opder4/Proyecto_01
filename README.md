# Simulador de Decisiones para Plataforma de Streaming
**Universidad Rafael Landívar | Facultad de Ingeniería** 
| **Curso:** Pensamiento Computacional 

## 1. Descripción del Sistema
Este programa es una herramienta de consola diseñada para simular la toma de decisiones de un equipo de contenido en una plataforma de streaming. El sistema evalúa solicitudes de películas, series, documentales y eventos en vivo basándose en parámetros técnicos, reglas de horario y niveles de producción para determinar si el contenido es apto para su publicación.


## 2. Instrucciones para Ejecutarlo
Siga estos pasos para poner en marcha el programa:

1.  **Clonación:** Copie el repositorio a su máquina local usando `git clone`.
2.  **Entorno:** Asegúrese de tener instalado el entorno de ejecución de **.NET SDK**.
3.  **Ejecución:**
    * Abra una terminal o consola de comandos.
    * Navegue hasta la carpeta del proyecto.
    * Escriba el comando: `dotnet run`.
4.  **Uso:** Interactúe con el programa a través del menú numérico principal.


## 3. Breve Explicación del Proyecto

El proyecto consiste en un algoritmo de evaluación que procesa datos en tiempo real. Su lógica se divide en tres partes:

1.  **Validación Técnica:** Verifica que el contenido cumpla con los rangos de duración y horarios permitidos según el tipo de contenido y la clasificación.
2.  **Clasificación de Impacto:** Determina si el contenido tiene una relevancia Baja, Media o Alta según parámetros preestablecidos.
3.  **Decisión Final:** Basándose en los resultados previos, el sistema decide si se debe **Publicar**, **Publicar con ajustes**, **Enviar a revisión** o **Rechazar**.

