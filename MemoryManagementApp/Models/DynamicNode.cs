using System;
using System.Runtime.CompilerServices;

namespace MemoryManagementApp.Models
{
    /// <summary>
    /// Representa un nodo instanciado individualmente en la memoria dinámica (Managed Heap).
    /// Contiene datos del elemento y una referencia por puntero (<see cref="Next"/>) hacia el siguiente nodo.
    /// </summary>
    public class DynamicNode
    {
        /// <summary>
        /// Identificador correlativo del nodo para trazabilidad pedagógica.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Valor numérico almacenado en el nodo.
        /// </summary>
        public int Data { get; set; }

        /// <summary>
        /// Referencia al siguiente objeto nodo alojado en el Heap.
        /// Funciona como puntero lógico en la memoria administrada de .NET.
        /// </summary>
        public DynamicNode? Next { get; set; }

        /// <summary>
        /// Marca temporal de cuándo fue asignada la memoria para esta instancia.
        /// </summary>
        public DateTime AllocatedAt { get; set; }

        /// <summary>
        /// Obtiene una representación hexadecimal simulada del puntero/dirección de memoria
        /// calculada a partir del Hash de identidad único del objeto en el Heap.
        /// </summary>
        public string HeapAddress => $"0x{RuntimeHelpers.GetHashCode(this):X8}";

        /// <summary>
        /// Constructor que inicializa el nodo reservando memoria en el Heap mediante el operador 'new'.
        /// </summary>
        /// <param name="id">Identificador único del nodo.</param>
        /// <param name="data">Valor entero a almacenar.</param>
        public DynamicNode(int id, int data)
        {
            Id = id;
            Data = data;
            Next = null;
            AllocatedAt = DateTime.Now;
        }

        /// <summary>
        /// Obtiene una descripción legible del estado del nodo y sus enlaces.
        /// </summary>
        public override string ToString()
        {
            string nextTarget = Next != null ? $"Nodo #{Next.Id} ({Next.HeapAddress})" : "null (Fin de lista)";
            return $"Nodo #{Id} | Dir: {HeapAddress} | Valor: {Data} | Apunta a -> {nextTarget}";
        }
    }
}
