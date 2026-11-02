using System;
using System.Collections.Generic;
using MemoryManagementApp.Models;

namespace MemoryManagementApp.Services
{
    /// <summary>
    /// Servicio que administra estructuras de datos dinámicas mediante instancias de objetos
    /// y punteros/referencias alojadas en el Managed Heap.
    /// 
    /// Concepto clave:
    /// En la memoria dinámica (Heap), los elementos no necesitan ocupar bloques contiguos.
    /// Cada instancia de <see cref="DynamicNode"/> se crea en cualquier fragmento libre del Heap
    /// mediante el operador 'new', y se vincula con otros nodos a través de referencias de memoria (punteros gestionados).
    /// Cuando una referencia se anula o se desvincula, el objeto queda huérfano y es reclamado
    /// automáticamente por el Garbage Collector (GC).
    /// </summary>
    public class DynamicMemoryService
    {
        private DynamicNode? _head;
        private DynamicNode? _tail;
        private int _nodeCount;
        private int _nextIdSequence;

        /// <summary>
        /// Obtiene el número total de nodos activos actualmente en la estructura enlazada.
        /// </summary>
        public int NodeCount => _nodeCount;

        /// <summary>
        /// Obtiene la referencia al primer nodo (cabeza) de la lista.
        /// </summary>
        public DynamicNode? Head => _head;

        /// <summary>
        /// Inicializa el servicio de memoria dinámica.
        /// </summary>
        public DynamicMemoryService()
        {
            _head = null;
            _tail = null;
            _nodeCount = 0;
            _nextIdSequence = 1;
        }

        /// <summary>
        /// Agrega un nuevo nodo al final de la estructura enlazada.
        /// Reserva de memoria en el Heap con complejidad temporal O(1).
        /// </summary>
        /// <param name="data">Valor numérico a almacenar en el nuevo nodo.</param>
        /// <returns>El nodo recién creado y alojado en Heap.</returns>
        public DynamicNode AddNodeDynamic(int data)
        {
            return AddLast(data);
        }

        /// <summary>
        /// Inserta un nuevo nodo al final de la lista enlazada (O(1)).
        /// </summary>
        public DynamicNode AddLast(int data)
        {
            DynamicNode newNode = new DynamicNode(_nextIdSequence++, data);

            if (_head == null)
            {
                _head = newNode;
                _tail = newNode;
            }
            else
            {
                // Se enlaza el puntero Next del último nodo hacia la nueva dirección en Heap
                _tail!.Next = newNode;
                _tail = newNode;
            }

            _nodeCount++;
            return newNode;
        }

        /// <summary>
        /// Inserta un nuevo nodo al inicio de la lista enlazada (O(1)).
        /// </summary>
        public DynamicNode AddFirst(int data)
        {
            DynamicNode newNode = new DynamicNode(_nextIdSequence++, data);

            if (_head == null)
            {
                _head = newNode;
                _tail = newNode;
            }
            else
            {
                newNode.Next = _head;
                _head = newNode;
            }

            _nodeCount++;
            return newNode;
        }

        /// <summary>
        /// Elimina el primer nodo de la lista, cortando la referencia en memoria
        /// para que el Garbage Collector pueda liberar el espacio en el Heap.
        /// Complejidad: O(1).
        /// </summary>
        /// <returns>True si se eliminó un nodo; False si la lista ya estaba vacía.</returns>
        public bool RemoveFirst(out int removedValue)
        {
            removedValue = 0;
            if (_head == null)
            {
                return false;
            }

            removedValue = _head.Data;
            DynamicNode oldHead = _head;

            // Se traslada la cabeza al siguiente elemento
            _head = _head.Next;

            // Cortamos la referencia del nodo eliminado para facilitar la recolección
            oldHead.Next = null;

            if (_head == null)
            {
                _tail = null;
            }

            _nodeCount--;
            return true;
        }

        /// <summary>
        /// Elimina el último nodo de la lista enlazada.
        /// </summary>
        public bool RemoveLast(out int removedValue)
        {
            removedValue = 0;
            if (_head == null)
            {
                return false;
            }

            if (_head == _tail)
            {
                removedValue = _head.Data;
                _head = null;
                _tail = null;
                _nodeCount--;
                return true;
            }

            DynamicNode current = _head;
            while (current.Next != null && current.Next != _tail)
            {
                current = current.Next;
            }

            removedValue = _tail!.Data;
            current.Next = null;
            _tail = current;
            _nodeCount--;
            return true;
        }

        /// <summary>
        /// Libera todos los nodos de la estructura desvinculando la referencia raíz (_head = null).
        /// Todos los nodos en la cadena quedan inalcanzables y marcados para recolección en el Heap.
        /// </summary>
        public void Clear()
        {
            _head = null;
            _tail = null;
            _nodeCount = 0;
        }

        /// <summary>
        /// Retorna una lista lineal con todos los nodos para inspección visual y análisis pedagógico.
        /// </summary>
        public List<DynamicNode> GetAllNodes()
        {
            List<DynamicNode> list = new List<DynamicNode>();
            DynamicNode? current = _head;

            while (current != null)
            {
                list.Add(current);
                current = current.Next;
            }

            return list;
        }

        /// <summary>
        /// Invoca explícitamente al Garbage Collector de .NET para recolectar objetos huérfanos en el Heap
        /// y calcula la memoria en bytes recuperada.
        /// </summary>
        /// <returns>Tupla con memoria antes, memoria después y memoria liberada en bytes.</returns>
        public (long memoryBefore, long memoryAfter, long freedBytes) CollectGarbage()
        {
            long memoryBefore = GC.GetTotalMemory(false);

            GC.Collect();
            GC.WaitForPendingFinalizers();
            GC.Collect();

            long memoryAfter = GC.GetTotalMemory(true);
            long freed = Math.Max(0, memoryBefore - memoryAfter);

            return (memoryBefore, memoryAfter, freed);
        }

        /// <summary>
        /// Obtiene el número total de nodos (mantenido para compatibilidad).
        /// </summary>
        public int GetNodeCount() => _nodeCount;
    }
}
