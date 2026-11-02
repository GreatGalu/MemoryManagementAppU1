namespace MemoryManagementApp.Models
{
    /// <summary>
    /// Información detallada sobre una operación de redimensionamiento de un arreglo en memoria contigua.
    /// </summary>
    public class ArrayResizeReport
    {
        public int PreviousSize { get; set; }
        public int NewSize { get; set; }
        public string PreviousReferenceAddress { get; set; } = string.Empty;
        public string NewReferenceAddress { get; set; } = string.Empty;
        public double ElapsedMicroseconds { get; set; }
        public int ElementsCopied { get; set; }
        public bool AddressChanged => !string.Equals(PreviousReferenceAddress, NewReferenceAddress, StringComparison.OrdinalIgnoreCase);
    }
}
