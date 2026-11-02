using System;
using System.Diagnostics;
using MemoryManagementApp.Models;

namespace MemoryManagementApp.Services
{
    /// <summary>
    /// Servicio que realiza pruebas comparativas empíricas de desempeño y consumo de memoria
    /// entre redimensionamiento dinámico de arreglos contiguos vs asignación de nodos en Heap.
    /// </summary>
    public class MemoryBenchmarkService
    {
        /// <summary>
        /// Ejecuta una prueba comparativa controlada insertando 'count' elementos en ambas estructuras.
        /// </summary>
        /// <param name="count">Número de elementos a insertar.</param>
        /// <param name="progressCallback">Callback opcional para reportar el porcentaje de avance (0 a 100).</param>
        /// <returns>Objeto <see cref="BenchmarkResult"/> con métricas de tiempo y memoria.</returns>
        public BenchmarkResult RunBenchmark(int count, Action<int>? progressCallback = null)
        {
            if (count <= 0)
            {
                throw new ArgumentException("El conteo de elementos debe ser mayor a cero.", nameof(count));
            }

            BenchmarkResult result = new BenchmarkResult
            {
                ElementCount = count
            };

            // Aseguramos que el Garbage Collector limpie antes de medir
            GC.Collect();
            GC.WaitForPendingFinalizers();
            GC.Collect();

            // -------------------------------------------------------------
            // 1. PRUEBA DE ARREGLO CON REDIMENSIONAMIENTO DINÁMICO INCREMENTAL
            // -------------------------------------------------------------
            // Simulamos el caso donde se agrega 1 a 1 redimensionando el bloque continuo
            // Costo acumulado: 1 + 2 + 3 + ... + N = O(N^2) operaciones de copia
            long memBeforeArray = GC.GetTotalMemory(true);
            Stopwatch swArray = Stopwatch.StartNew();

            int[] testArray = new int[0];
            int reallocCount = 0;

            for (int i = 0; i < count; i++)
            {
                int[] newArr = new int[i + 1];
                for (int j = 0; j < i; j++)
                {
                    newArr[j] = testArray[j];
                }
                newArr[i] = i * 2;
                testArray = newArr;
                reallocCount++;

                if (i % 500 == 0 && progressCallback != null)
                {
                    int progress = (int)((i / (double)(count * 2)) * 100);
                    progressCallback(progress);
                }
            }

            swArray.Stop();
            long memAfterArray = GC.GetTotalMemory(false);

            result.ArrayTimeMs = swArray.Elapsed.TotalMilliseconds;
            result.ArrayTicks = swArray.ElapsedTicks;
            result.ArrayMemoryBytes = Math.Max(0, memAfterArray - memBeforeArray);
            result.ArrayReallocations = reallocCount;

            // Liberamos referencia y forzamos GC antes de la siguiente prueba
            testArray = null!;
            GC.Collect();
            GC.WaitForPendingFinalizers();
            GC.Collect();

            // -------------------------------------------------------------
            // 2. PRUEBA DE ESTRUCTURA DINÁMICA (NODOS ENLAZADOS EN HEAP)
            // -------------------------------------------------------------
            // Cada inserción reserva memoria independiente con 'new' y enlaza el puntero Next.
            // Costo por inserción: O(1). Costo total: O(N).
            long memBeforeDynamic = GC.GetTotalMemory(true);
            Stopwatch swDynamic = Stopwatch.StartNew();

            DynamicNode? head = null;
            DynamicNode? tail = null;

            for (int i = 0; i < count; i++)
            {
                DynamicNode newNode = new DynamicNode(i + 1, i * 2);
                if (head == null)
                {
                    head = newNode;
                    tail = newNode;
                }
                else
                {
                    tail!.Next = newNode;
                    tail = newNode;
                }

                if (i % 500 == 0 && progressCallback != null)
                {
                    int progress = 50 + (int)((i / (double)(count * 2)) * 100);
                    progressCallback(Math.Min(100, progress));
                }
            }

            swDynamic.Stop();
            long memAfterDynamic = GC.GetTotalMemory(false);

            result.DynamicListTimeMs = swDynamic.Elapsed.TotalMilliseconds;
            result.DynamicListTicks = swDynamic.ElapsedTicks;
            result.DynamicMemoryBytes = Math.Max(0, memAfterDynamic - memBeforeDynamic);

            // Notificamos progreso completado
            progressCallback?.Invoke(100);

            // Limpieza de referencias
            head = null;
            tail = null;

            return result;
        }

        /// <summary>
        /// Genera la conclusión formal y técnica para la rúbrica y reporte académico.
        /// </summary>
        public static string GenerateAcademicConclusion(BenchmarkResult result)
        {
            double speedupFactor = result.DynamicListTimeMs > 0 
                ? (result.ArrayTimeMs / result.DynamicListTimeMs) 
                : 0;

            return 
$@"========================================================================================
CONCLUSIÓN FORMAL SOBRE GESTIÓN DE MEMORIA Y RENDIMIENTO (TAREA 1.2)
========================================================================================

1. DESEMPEÑO TEMPORAL (CPU / COMPLEJIDAD ALGORÍTMICA):
- Para insertar {result.ElementCount:N0} elementos:
  * Arreglo Redimensionado: {result.ArrayTimeMs:F3} ms ({result.ArrayTicks:N0} ticks) con {result.ArrayReallocations:N0} reasignaciones contiguas.
  * Memoria Dinámica (Heap): {result.DynamicListTimeMs:F3} ms ({result.DynamicListTicks:N0} ticks).
- Conclusión de tiempo: La estructura dinámica fue aproximadamente {speedupFactor:F1}x más rápida.
  Esto valida la teoría algorítmica: redimensionar un vector continuo elemento a elemento presenta
  una complejidad acumulada de O(N²), requiriendo copiar una suma cuadrática de datos. En cambio,
  la asignación dinámica en Heap opera en tiempo O(1) por inserción, logrando O(N) global.

2. GESTIÓN Y CONSUMO DE MEMORIA (ESPACIO / OVERHEAD):
- Arreglo (Memoria Contigua):
  * Ventaja: Densidad máxima de datos en caché de CPU (principio de localidad espacial) y sin sobrecarga
    de punteros adicionales por elemento.
  * Desventaja: Requiere fragmentos continuos contiguos de memoria. Durante la redimensionamiento, coexisten
    temporalmente en el Heap el bloque viejo y el nuevo, disparando picos de memoria e invocaciones del GC.
- Lista Enlazada (Memoria Dinámica Dispersa):
  * Ventaja: Asignación bajo demanda; no requiere bloques contiguos y no sufre penalización de copiado.
  * Desventaja: Mayor sobrecarga de memoria (Memory Overhead). Cada nodo aloja metadatos de objeto (.NET Object Header,
    MethodTable Pointer) más el puntero 'Next' (8 bytes en 64 bits), consumiendo entre 24 y 32 bytes por elemento entero.

3. SÍNTESIS TÉCNICA:
- Utilizar ARREGLOS cuando el tamaño se conozca de antemano o requiera acceso aleatorio O(1) indexado.
- Utilizar MEMORIA DINÁMICA / LISTAS cuando la cantidad de elementos fluctúe impredeciblemente y
  predominen las operaciones frecuentes de inserción/eliminación en tiempo de ejecución.
========================================================================================";
        }
    }
}
