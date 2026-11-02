using System;

namespace MemoryManagementApp.Models
{
    /// <summary>
    /// Modelo que encapsula los resultados de la prueba de rendimiento
    /// comparando arreglos redimensionados vs listas enlazadas en memoria dinámica.
    /// </summary>
    public class BenchmarkResult
    {
        /// <summary>
        /// Número de elementos procesados en la prueba.
        /// </summary>
        public int ElementCount { get; set; }

        /// <summary>
        /// Tiempo en milisegundos que tomó la inserción en el arreglo con redimensionamiento dinámico continuo.
        /// </summary>
        public double ArrayTimeMs { get; set; }

        /// <summary>
        /// Ticks transcurridos en el arreglo.
        /// </summary>
        public long ArrayTicks { get; set; }

        /// <summary>
        /// Tiempo en milisegundos que tomó la inserción en la estructura enlazada dinámica (Heap).
        /// </summary>
        public double DynamicListTimeMs { get; set; }

        /// <summary>
        /// Ticks transcurridos en la lista dinámica.
        /// </summary>
        public long DynamicListTicks { get; set; }

        /// <summary>
        /// Memoria aproximada consumida por la operación con arreglo en bytes.
        /// </summary>
        public long ArrayMemoryBytes { get; set; }

        /// <summary>
        /// Memoria aproximada consumida por la lista dinámica en bytes.
        /// </summary>
        public long DynamicMemoryBytes { get; set; }

        /// <summary>
        /// Número total de reasignaciones de memoria contigua realizadas en el arreglo.
        /// </summary>
        public int ArrayReallocations { get; set; }
    }
}
