using MemoryManagementApp.Models;

namespace MemoryManagementApp.Services
{
    public class DynamicMemoryService
    {
        private DynamicNode? _head;
        private int _nodeCount;

        // Uso explícito de memoria dinámica mediante la creación de instancias 'new'
        public void AddNodeDynamic(int data)
        {
            DynamicNode newNode = new DynamicNode(data); // Reserva de memoria en el Heap

            if (_head == null)
            {
                _head = newNode;
            }
            else
            {
                DynamicNode current = _head;
                while (current.Next != null)
                {
                    current = current.Next;
                }
                current.Next = newNode;
            }
            _nodeCount++;
        }

        public int GetNodeCount() => _nodeCount;
    }
}