using System;
using System.Windows.Forms;
using MemoryManagementApp.Services;

namespace MemoryManagementApp.Forms
{
    public partial class MainForm : Form
    {
        private ArrayResizerService _arrayService;
        private DynamicMemoryService _dynamicService;

        public MainForm()
        {
            InitializeComponent();
            _arrayService = new ArrayResizerService(5); // Tamaño inicial estático
            _dynamicService = new DynamicMemoryService();
        }

        private void btnResizeArray_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtNewSize.Text, out int newSize) && newSize > 0)
            {
                _arrayService.ResizeArray(newSize);
                MessageBox.Show($"Arreglo redimensionado a {newSize} posiciones.");
            }
        }

        private void btnAddDynamicNode_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtNodeData.Text, out int data))
            {
                _dynamicService.AddNodeDynamic(data);
                MessageBox.Show($"Nodo alojado en el Heap. Total nodos: {_dynamicService.GetNodeCount()}");
            }
        }
    }
}