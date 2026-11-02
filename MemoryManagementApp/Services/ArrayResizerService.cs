using System;

namespace MemoryManagementApp.Services
{
    public class ArrayResizerService
    {
        private int[] _staticArray;

        // Inicializa el arreglo estático con un tamaño predeterminado
        public ArrayResizerService(int initialSize)
        {
            _staticArray = new int[initialSize];
        }

        // Redimensiona el arreglo en tiempo de ejecución (genera un nuevo bloque y copia datos)
        public void ResizeArray(int newSize)
        {
            Array.Resize(ref _staticArray, newSize);
        }

        public int[] GetElements()
        {
            return (int[])_staticArray.Clone();
        }
    }
}