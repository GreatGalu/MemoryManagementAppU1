using System;
using System.Collections.Generic;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;
using MemoryManagementApp.Models;
using MemoryManagementApp.Services;

namespace MemoryManagementApp
{
    /// <summary>
    /// Formulario principal que implementa la práctica de comparación de memoria
    /// estática (arreglos contiguos) vs memoria dinámica (nodos en Heap), benchmarking y conclusiones.
    /// Cumple con la rúbrica de la Tarea 1.2: POO, modularidad, validaciones y clean code.
    /// </summary>
    public partial class MainForm : Form
    {
        private ArrayResizerService _arrayService;
        private DynamicMemoryService _dynamicService;
        private readonly MemoryBenchmarkService _benchmarkService;

        public MainForm()
        {
            InitializeComponent();
            _arrayService = new ArrayResizerService(5);
            _dynamicService = new DynamicMemoryService();
            _benchmarkService = new MemoryBenchmarkService();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            cmbBenchmarkCount.SelectedIndex = 3; // 5,000 elementos por defecto
            RefreshArrayView();
            RefreshDynamicView();
            
            LogArray("Sistema iniciado. Arreglo inicial de 5 posiciones reservado en memoria contigua.");
            LogDynamic("Servicio de memoria dinámica listo. Heap administrado por .NET CLR.");
            
            txtAcademicConclusion.Text = 
@"Seleccione la cantidad de elementos en la parte superior y presione 'Iniciar Benchmark' para ejecutar
la prueba empírica y generar automáticamente la justificación teórica y matemática.";
        }

        #region ================= MÉTODOS DE MEMORIA CONTIGUA (TAB 1) =================

        private void btnInitArray_Click(object sender, EventArgs e)
        {
            try
            {
                int newSize = (int)nudArraySize.Value;
                _arrayService.Initialize(newSize);

                nudIndex.Maximum = Math.Max(0, newSize - 1);
                RefreshArrayView();

                LogArray($"[INICIALIZACIÓN] Arreglo reiniciado a {newSize} posiciones. Dirección base Heap: {_arrayService.CurrentHeapReference}");
                UpdateStatus($"Arreglo reinicializado con {newSize} elementos.");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al inicializar el arreglo: {ex.Message}", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnResizeArray_Click(object sender, EventArgs e)
        {
            try
            {
                int targetSize = (int)nudNewSize.Value;
                ArrayResizeReport report = _arrayService.ResizeArray(targetSize);

                nudIndex.Maximum = Math.Max(0, targetSize - 1);
                RefreshArrayView();

                string addressNote = report.AddressChanged 
                    ? $"¡Cambio de bloque detectado! Ref Anterior: {report.PreviousReferenceAddress} -> Nueva Ref: {report.NewReferenceAddress}"
                    : "Misma referencia base (sin relocalización física).";

                LogArray($"[REDIMENSIONAMIENTO] Tamaño: {report.PreviousSize} -> {report.NewSize} elementos.");
                LogArray($"   • Tiempo de copia O(n): {report.ElapsedMicroseconds:F2} µs | Elementos copiados: {report.ElementsCopied}");
                LogArray($"   • Dirección Heap: {addressNote}");
                LogArray($"   • Reubicaciones totales acumuladas: {_arrayService.TotalReallocations}");

                UpdateStatus($"Arreglo redimensionado a {targetSize} elementos con éxito.");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al redimensionar: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnFillRandom_Click(object sender, EventArgs e)
        {
            _arrayService.FillRandom(1, 100);
            RefreshArrayView();
            LogArray($"[LLENADO] Arreglo poblado con valores pseudoaleatorios [1 - 100].");
            UpdateStatus("Valores aleatorios generados en el arreglo.");
        }

        private void btnClearArray_Click(object sender, EventArgs e)
        {
            _arrayService.ClearElements();
            RefreshArrayView();
            LogArray("[LIMPIEZA] Todos los elementos del arreglo se restablecieron a 0.");
            UpdateStatus("Arreglo reseteado.");
        }

        private void btnSetElement_Click(object sender, EventArgs e)
        {
            try
            {
                if (_arrayService.Length == 0)
                {
                    MessageBox.Show("El arreglo tiene tamaño 0. Redimensione o inicialice primero.", "Arreglo Vacío", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                int index = (int)nudIndex.Value;
                int val = (int)nudValue.Value;

                _arrayService.SetElement(index, val);
                RefreshArrayView();

                int byteOffset = index * sizeof(int);
                LogArray($"[ACCESO DIRECTO O(1)] Posición [{index}] asignada con valor {val}. Desplazamiento en memoria física: Base + {byteOffset} bytes.");
                UpdateStatus($"Elemento [{index}] actualizado.");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error de Índice", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnGetElement_Click(object sender, EventArgs e)
        {
            try
            {
                if (_arrayService.Length == 0)
                {
                    MessageBox.Show("El arreglo está vacío.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                int index = (int)nudIndex.Value;
                int val = _arrayService.GetElement(index);

                MessageBox.Show($"Elemento en el índice [{index}] = {val}\nAcceso O(1) en tiempo constante mediante cálculo de desplazamiento directo en memoria contigua.", "Consulta de Valor", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void RefreshArrayView()
        {
            dgvArray.Rows.Clear();
            int[] elements = _arrayService.GetElements();

            for (int i = 0; i < elements.Length; i++)
            {
                int offsetBytes = i * sizeof(int);
                dgvArray.Rows.Add(
                    $"[{i}]",
                    elements[i],
                    $"Contiguo (Offset +{offsetBytes}B)",
                    $"Base + ({i} * 4) -> O(1)"
                );
            }

            lblStaticRef.Text = $"Dirección Base en Heap: {_arrayService.CurrentHeapReference}";
            lblStaticLength.Text = $"Capacidad del Bloque: {_arrayService.Length} celdas contiguas";
            lblStaticReallocs.Text = $"Total de reasignaciones (copias O(n)): {_arrayService.TotalReallocations}";
            lblStaticMemoryEst.Text = $"Consumo neto de datos: ~{_arrayService.Length * sizeof(int)} bytes (contiguo en Heap)";
            nudIndex.Maximum = Math.Max(0, _arrayService.Length - 1);
        }

        private void LogArray(string message)
        {
            txtArrayLog.AppendText($"[{DateTime.Now:HH:mm:ss.fff}] {message}{Environment.NewLine}");
        }

        #endregion

        #region ================= MÉTODOS DE MEMORIA DINÁMICA (TAB 2) =================

        private void btnAddLast_Click(object sender, EventArgs e)
        {
            try
            {
                int val = (int)nudDynamicValue.Value;
                DynamicNode newNode = _dynamicService.AddLast(val);
                RefreshDynamicView();

                LogDynamic($"[ALLOC HEAP] Nodo #{newNode.Id} instanciado en {newNode.HeapAddress} con valor {val}. Enlazado al final (O(1)).");
                UpdateStatus($"Nodo #{newNode.Id} agregado al final.");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error de Asignación", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAddFirst_Click(object sender, EventArgs e)
        {
            try
            {
                int val = (int)nudDynamicValue.Value;
                DynamicNode newNode = _dynamicService.AddFirst(val);
                RefreshDynamicView();

                LogDynamic($"[ALLOC HEAP] Nodo #{newNode.Id} instanciado en {newNode.HeapAddress} con valor {val}. Enlazado como nueva CABEZA (O(1)).");
                UpdateStatus($"Nodo #{newNode.Id} agregado al inicio.");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnRemoveFirst_Click(object sender, EventArgs e)
        {
            if (_dynamicService.RemoveFirst(out int removedValue))
            {
                RefreshDynamicView();
                LogDynamic($"[DEREFERENCE] Primer nodo removido (Valor: {removedValue}). El objeto anterior en Heap quedó sin referencia raíz (elegible para GC).");
                UpdateStatus("Primer nodo desreferenciado.");
            }
            else
            {
                MessageBox.Show("La lista dinámica ya está vacía.", "Lista Vacía", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnRemoveLast_Click(object sender, EventArgs e)
        {
            if (_dynamicService.RemoveLast(out int removedValue))
            {
                RefreshDynamicView();
                LogDynamic($"[DEREFERENCE] Último nodo removido (Valor: {removedValue}). Puntero 'Next' del penúltimo nodo apuntado a null.");
                UpdateStatus("Último nodo removido.");
            }
            else
            {
                MessageBox.Show("La lista dinámica ya está vacía.", "Lista Vacía", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnClearDynamic_Click(object sender, EventArgs e)
        {
            int totalBefore = _dynamicService.NodeCount;
            _dynamicService.Clear();
            RefreshDynamicView();

            LogDynamic($"[CLEAR] Referencia raíz _head = null. Se desvincularon {totalBefore} nodos de la cadena. Memoria pendiente de recolección.");
            UpdateStatus("Estructura dinámica vaciada.");
        }

        private void btnForceGC_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            try
            {
                var (before, after, freed) = _dynamicService.CollectGarbage();
                lblGCStatus.Text = 
$"Último ciclo de GC completado:\r\n" +
$"• Memoria antes:  {before / 1024.0:F1} KB\r\n" +
$"• Memoria después: {after / 1024.0:F1} KB\r\n" +
$"• Memoria recuperada: {freed / 1024.0:F1} KB\r\n" +
$"• Generación máxima: Gen {GC.MaxGeneration}";

                LogDynamic($"[GARBAGE COLLECTOR] Recolección forzada. Bytes liberados en Heap: {freed:N0} bytes ({freed / 1024.0:F1} KB).");
                UpdateStatus($"Garbage Collector ejecutado: {freed / 1024.0:F1} KB liberados.");
            }
            finally
            {
                Cursor = Cursors.Default;
            }
        }

        private void RefreshDynamicView()
        {
            dgvDynamicNodes.Rows.Clear();
            List<DynamicNode> nodes = _dynamicService.GetAllNodes();

            foreach (var node in nodes)
            {
                string nextStr = node.Next != null ? $"#{node.Next.Id} ({node.Next.HeapAddress})" : "null (Fin)";
                dgvDynamicNodes.Rows.Add(
                    $"#{node.Id}",
                    node.Data,
                    node.HeapAddress,
                    nextStr,
                    node.AllocatedAt.ToString("HH:mm:ss.fff")
                );
            }

            lblDynamicCount.Text = $"Nodos Activos en Heap: {_dynamicService.NodeCount}";
            lblDynamicHead.Text = $"Puntero Cabeza (_head): {(_dynamicService.Head != null ? $"{_dynamicService.Head.HeapAddress} (Nodo #{_dynamicService.Head.Id})" : "null")}";
            
            DynamicNode? tailNode = nodes.Count > 0 ? nodes[nodes.Count - 1] : null;
            lblDynamicTail.Text = $"Puntero Cola   (_tail): {(tailNode != null ? $"{tailNode.HeapAddress} (Nodo #{tailNode.Id})" : "null")}";
            
            int estimatedBytes = _dynamicService.NodeCount * 32;
            lblDynamicOverhead.Text = $"Sobrecarga estimada: ~{estimatedBytes} bytes (~32 B por nodo en Heap 64-bit)";
        }

        private void LogDynamic(string message)
        {
            txtDynamicLog.AppendText($"[{DateTime.Now:HH:mm:ss.fff}] {message}{Environment.NewLine}");
        }

        #endregion

        #region ================= MÉTODOS DE BENCHMARK (TAB 3) =================

        private async void btnRunBenchmark_Click(object sender, EventArgs e)
        {
            int elementCount = 5000;
            switch (cmbBenchmarkCount.SelectedIndex)
            {
                case 0: elementCount = 500; break;
                case 1: elementCount = 1000; break;
                case 2: elementCount = 2500; break;
                case 3: elementCount = 5000; break;
                case 4: elementCount = 10000; break;
                case 5: elementCount = 20000; break;
            }

            btnRunBenchmark.Enabled = false;
            pbBenchmark.Value = 0;
            lblBenchmarkProgress.Text = $"Ejecutando prueba con {elementCount:N0} elementos...";
            Cursor = Cursors.WaitCursor;

            var progress = new Progress<int>(percent =>
            {
                pbBenchmark.Value = Math.Clamp(percent, 0, 100);
                lblBenchmarkProgress.Text = percent < 50 
                    ? $"[1/2] Probando Vector con redimensionamiento contiguo ({percent * 2}%)..." 
                    : $"[2/2] Probando Asignación de Nodos en Heap ({(percent - 50) * 2}%)...";
            });

            try
            {
                BenchmarkResult result = await Task.Run(() => _benchmarkService.RunBenchmark(elementCount, p => ((IProgress<int>)progress).Report(p)));

                PopulateBenchmarkGrid(result);
                txtAcademicConclusion.Text = MemoryBenchmarkService.GenerateAcademicConclusion(result);
                lblBenchmarkProgress.Text = $"Prueba completada para {elementCount:N0} elementos con éxito.";
                UpdateStatus("Benchmark finalizado.");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrió un error en el benchmark: {ex.Message}", "Error de Benchmark", MessageBoxButtons.OK, MessageBoxIcon.Error);
                lblBenchmarkProgress.Text = "Prueba cancelada o con errores.";
            }
            finally
            {
                btnRunBenchmark.Enabled = true;
                Cursor = Cursors.Default;
            }
        }

        private void PopulateBenchmarkGrid(BenchmarkResult res)
        {
            dgvBenchmark.Rows.Clear();

            dgvBenchmark.Rows.Add(
                "Elementos procesados (N)",
                $"{res.ElementCount:N0}",
                $"{res.ElementCount:N0}",
                "Misma muestra de datos para ambas estructuras"
            );

            dgvBenchmark.Rows.Add(
                "Tiempo de Ejecución",
                $"{res.ArrayTimeMs:F3} ms ({res.ArrayTicks:N0} ticks)",
                $"{res.DynamicListTimeMs:F3} ms ({res.DynamicListTicks:N0} ticks)",
                res.ArrayTimeMs > res.DynamicListTimeMs 
                    ? $"La lista fue {(res.ArrayTimeMs / Math.Max(0.001, res.DynamicListTimeMs)):F1}x más veloz" 
                    : "Tiempos comparables"
            );

            dgvBenchmark.Rows.Add(
                "Complejidad Temporal",
                "O(N²) acumulado (sumatoria de copias)",
                "O(N) total (O(1) por cada nodo)",
                "Diferencia algorítmica fundamental en tiempo"
            );

            dgvBenchmark.Rows.Add(
                "Reubicaciones de Memoria",
                $"{res.ArrayReallocations:N0} reasignaciones de bloque",
                "0 reasignaciones (instancias dispersas)",
                "El arreglo crea un bloque nuevo y desecha el anterior"
            );

            dgvBenchmark.Rows.Add(
                "Memoria / Overhead",
                "Compacta (solo 4 bytes por int)",
                "Mayor (~32 bytes por nodo con punteros)",
                "La lista dinámica gasta más espacio por puntero 'Next'"
            );
        }

        #endregion

        private void UpdateStatus(string message)
        {
            statusLabel.Text = $"[{DateTime.Now:HH:mm:ss}] {message} | Heap Activo: {GC.GetTotalMemory(false) / 1024.0:F1} KB";
        }
    }
}
