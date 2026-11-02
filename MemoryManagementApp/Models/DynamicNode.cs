namespace MemoryManagementApp.Models
{
    // Clase cuyas instancias se asignarán dinámicamente en el Heap
    public class DynamicNode
    {
        public int Data { get; set; }
        public DynamicNode? Next { get; set; } // Puntero de referencia a otro objeto

        public DynamicNode(int data)
        {
            Data = data;
            Next = null;
        }
    }
}