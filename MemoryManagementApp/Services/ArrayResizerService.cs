using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using MemoryManagementApp.Models;

namespace MemoryManagementApp.Services
{
    /// <summary>
    /// Servicio que administra la creación, acceso y redimensionamiento de arreglos (vectores)
    /// en bloques de memoria contigua en tiempo de ejecución.
    /// 
    /// Concepto clave:
    /// Un arreglo en C#/.NET es un tipo de referencia alojado en el Managed Heap pero cuyos
    /// elementos internos ocupan un bloque estrictamente contiguo de memoria.
    /// Por esta razón, un arreglo NO puede expandirse in situ si el bloque de memoria contiguo adyacente
    /// está ocupado; en su lugar, el runtime debe reservar un nuevo bloque contiguo de tamaño N,
    /// copiar los elementos anteriores (costo temporal O(n)) y descartar el bloque viejo para el Garbage Collector.
    /// </summary>
    public class ArrayResizerService
    {
        private int[] _array;
        private int _totalReallocations;

        /// <summary>
        /// Obtiene la longitud actual del arreglo.
        /// </summary>
        public int Length => _array.Length;

        /// <summary>
        /// Obtiene el número acumulado de reubicaciones de bloque de memoria efectuadas.
        /// </summary>
        public int TotalReallocations => _totalReallocations;

        /// <summary>
        /// Obtiene la dirección lógica simulada de la referencia actual del arreglo en el Heap.
        /// </summary>
        public string CurrentHeapReference => _array != null ? $"0x{RuntimeHelpers.GetHashCode(_array):X8}" : "null";

        /// <summary>
        /// Inicializa el servicio con un arreglo de tamaño inicial especificado.
        /// </summary>
        /// <param name="initialSize">Tamaño inicial del vector (debe ser mayor o igual a 0).</param>
        /// <exception cref="ArgumentOutOfRangeException">Si el tamaño es menor a cero.</exception>
        public ArrayResizerService(int initialSize = 5)
        {
            if (initialSize < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(initialSize), "El tamaño inicial no puede ser negativo.");
            }

            _array = new int[initialSize];
            _totalReallocations = 0;
        }

        /// <summary>
        /// Reinicializa el arreglo con un nuevo tamaño y limpia los contadores.
        /// </summary>
        /// <param name="size">Nuevo tamaño inicial.</param>
        public void Initialize(int size)
        {
            if (size < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(size), "El tamaño inicial no puede ser negativo.");
            }

            _array = new int[size];
            _totalReallocations = 0;
        }

        /// <summary>
        /// Redimensiona el arreglo en tiempo de ejecución generando un nuevo bloque de memoria contigua.
        /// </summary>
        /// <param name="newSize">Nuevo tamaño deseado para el vector.</param>
        /// <returns>Reporte con métricas de tiempo, copia y referencias antes/después.</returns>
        public ArrayResizeReport ResizeArray(int newSize)
        {
            if (newSize < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(newSize), "El nuevo tamaño del arreglo no puede ser negativo.");
            }

            int previousSize = _array.Length;
            string previousAddress = CurrentHeapReference;

            Stopwatch sw = Stopwatch.StartNew();

            // Demostración explícita de lo que sucede internamente con la memoria contigua:
            // 1. Se crea un nuevo bloque contiguo de tamaño 'newSize' en el Heap.
            int[] newBlock = new int[newSize];

            // 2. Se copian los elementos del bloque viejo al nuevo bloque (Complejidad O(n))
            int elementsToCopy = Math.Min(previousSize, newSize);
            for (int i = 0; i < elementsToCopy; i++)
            {
                newBlock[i] = _array[i];
            }

            // 3. Se sustituye la referencia: el bloque antiguo queda huérfano para el Garbage Collector.
            _array = newBlock;

            sw.Stop();
            _totalReallocations++;

            return new ArrayResizeReport
            {
                PreviousSize = previousSize,
                NewSize = newSize,
                PreviousReferenceAddress = previousAddress,
                NewReferenceAddress = CurrentHeapReference,
                ElapsedMicroseconds = (sw.ElapsedTicks * 1_000_000.0) / Stopwatch.Frequency,
                ElementsCopied = elementsToCopy
            };
        }

        /// <summary>
        /// Asigna un valor en un índice específico con validación de límites.
        /// Complejidad de acceso aleatorio directo: O(1).
        /// </summary>
        /// <param name="index">Posición a modificar.</param>
        /// <param name="value">Valor entero a almacenar.</param>
        public void SetElement(int index, int value)
        {
            if (index < 0 || index >= _array.Length)
            {
                throw new IndexOutOfRangeException($"El índice {index} está fuera de los límites del arreglo [0, {_array.Length - 1}].");
            }

            _array[index] = value;
        }

        /// <summary>
        /// Obtiene el valor alojado en una posición específica. Acceso O(1).
        /// </summary>
        public int GetElement(int index)
        {
            if (index < 0 || index >= _array.Length)
            {
                throw new IndexOutOfRangeException($"El índice {index} está fuera de los límites del arreglo [0, {_array.Length - 1}].");
            }

            return _array[index];
        }

        /// <summary>
        /// Llena el arreglo con números enteros generados aleatoriamente dentro de un rango.
        /// </summary>
        public void FillRandom(int min = 1, int max = 100)
        {
            Random rnd = new Random();
            for (int i = 0; i < _array.Length; i++)
            {
                _array[i] = rnd.Next(min, max + 1);
            }
        }

        /// <summary>
        /// Retorna una copia defensiva de los elementos actuales del arreglo.
        /// </summary>
        public int[] GetElements()
        {
            return (int[])_array.Clone();
        }

        /// <summary>
        /// Restablece todos los elementos del arreglo a su valor por defecto (0).
        /// </summary>
        public void ClearElements()
        {
            Array.Clear(_array, 0, _array.Length);
        }
    }
}
