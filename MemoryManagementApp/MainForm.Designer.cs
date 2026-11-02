namespace MemoryManagementApp
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            pnlHeader = new Panel();
            lblSubtitle = new Label();
            lblTitle = new Label();
            tabControlMain = new TabControl();
            tabStaticMemory = new TabPage();
            tlpStatic = new TableLayoutPanel();
            gbStaticControls = new GroupBox();
            lblArrayInitSize = new Label();
            nudArraySize = new NumericUpDown();
            btnInitArray = new Button();
            lblNewSizePrompt = new Label();
            nudNewSize = new NumericUpDown();
            btnResizeArray = new Button();
            btnFillRandom = new Button();
            btnClearArray = new Button();
            gbElementOps = new GroupBox();
            lblIndex = new Label();
            nudIndex = new NumericUpDown();
            lblValue = new Label();
            nudValue = new NumericUpDown();
            btnSetElement = new Button();
            btnGetElement = new Button();
            pnlStaticMetrics = new Panel();
            lblStaticMemoryEst = new Label();
            lblStaticReallocs = new Label();
            lblStaticLength = new Label();
            lblStaticRef = new Label();
            dgvArray = new DataGridView();
            colIndex = new DataGridViewTextBoxColumn();
            colValue = new DataGridViewTextBoxColumn();
            colStorage = new DataGridViewTextBoxColumn();
            colComplexity = new DataGridViewTextBoxColumn();
            txtArrayLog = new TextBox();
            tabDynamicMemory = new TabPage();
            tlpDynamic = new TableLayoutPanel();
            gbDynamicControls = new GroupBox();
            lblDynamicValue = new Label();
            nudDynamicValue = new NumericUpDown();
            btnAddLast = new Button();
            btnAddFirst = new Button();
            btnRemoveFirst = new Button();
            btnRemoveLast = new Button();
            btnClearDynamic = new Button();
            gbGC = new GroupBox();
            btnForceGC = new Button();
            lblGCStatus = new Label();
            pnlDynamicMetrics = new Panel();
            lblDynamicOverhead = new Label();
            lblDynamicTail = new Label();
            lblDynamicHead = new Label();
            lblDynamicCount = new Label();
            dgvDynamicNodes = new DataGridView();
            colNodeId = new DataGridViewTextBoxColumn();
            colNodeData = new DataGridViewTextBoxColumn();
            colNodeAddress = new DataGridViewTextBoxColumn();
            colNodeNext = new DataGridViewTextBoxColumn();
            colNodeTimestamp = new DataGridViewTextBoxColumn();
            txtDynamicLog = new TextBox();
            tabBenchmark = new TabPage();
            tlpBenchmark = new TableLayoutPanel();
            gbBenchmarkConfig = new GroupBox();
            lblBenchmarkElements = new Label();
            cmbBenchmarkCount = new ComboBox();
            btnRunBenchmark = new Button();
            pbBenchmark = new ProgressBar();
            lblBenchmarkProgress = new Label();
            dgvBenchmark = new DataGridView();
            colBenchMetric = new DataGridViewTextBoxColumn();
            colBenchArray = new DataGridViewTextBoxColumn();
            colBenchDynamic = new DataGridViewTextBoxColumn();
            colBenchNotes = new DataGridViewTextBoxColumn();
            txtAcademicConclusion = new TextBox();
            statusStrip = new StatusStrip();
            statusLabel = new ToolStripStatusLabel();
            pnlHeader.SuspendLayout();
            tabControlMain.SuspendLayout();
            tabStaticMemory.SuspendLayout();
            tlpStatic.SuspendLayout();
            gbStaticControls.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudArraySize).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudNewSize).BeginInit();
            gbElementOps.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudIndex).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudValue).BeginInit();
            pnlStaticMetrics.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvArray).BeginInit();
            tabDynamicMemory.SuspendLayout();
            tlpDynamic.SuspendLayout();
            gbDynamicControls.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudDynamicValue).BeginInit();
            gbGC.SuspendLayout();
            pnlDynamicMetrics.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDynamicNodes).BeginInit();
            tabBenchmark.SuspendLayout();
            tlpBenchmark.SuspendLayout();
            gbBenchmarkConfig.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvBenchmark).BeginInit();
            statusStrip.SuspendLayout();
            SuspendLayout();
            // 
            // pnlHeader
            // 
            pnlHeader.BackColor = Color.FromArgb(24, 43, 73);
            pnlHeader.Controls.Add(lblSubtitle);
            pnlHeader.Controls.Add(lblTitle);
            pnlHeader.Dock = DockStyle.Top;
            pnlHeader.Location = new Point(0, 0);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Size = new Size(1008, 65);
            pnlHeader.TabIndex = 0;
            // 
            // lblSubtitle
            // 
            lblSubtitle.AutoSize = true;
            lblSubtitle.Font = new Font("Segoe UI", 9F);
            lblSubtitle.ForeColor = Color.FromArgb(190, 215, 255);
            lblSubtitle.Location = new Point(16, 38);
            lblSubtitle.Name = "lblSubtitle";
            lblSubtitle.Size = new Size(686, 15);
            lblSubtitle.TabIndex = 1;
            lblSubtitle.Text = "Estructuras de Datos - Unidad 1 | Redimensionamiento de Vectores, Instancias Dinámicas en Heap, Punteros y Garbage Collection";
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 13.5F, FontStyle.Bold);
            lblTitle.ForeColor = Color.White;
            lblTitle.Location = new Point(14, 10);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(711, 25);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Práctica 1.2: Gestión de Memoria Estática (Contigua) vs Memoria Dinámica (Heap)";
            // 
            // tabControlMain
            // 
            tabControlMain.Controls.Add(tabStaticMemory);
            tabControlMain.Controls.Add(tabDynamicMemory);
            tabControlMain.Controls.Add(tabBenchmark);
            tabControlMain.Dock = DockStyle.Fill;
            tabControlMain.Font = new Font("Segoe UI Semibold", 9.5F, FontStyle.Bold);
            tabControlMain.Location = new Point(0, 65);
            tabControlMain.Name = "tabControlMain";
            tabControlMain.SelectedIndex = 0;
            tabControlMain.Size = new Size(1008, 630);
            tabControlMain.TabIndex = 1;
            // 
            // tabStaticMemory
            // 
            tabStaticMemory.Controls.Add(tlpStatic);
            tabStaticMemory.Location = new Point(4, 26);
            tabStaticMemory.Name = "tabStaticMemory";
            tabStaticMemory.Padding = new Padding(8);
            tabStaticMemory.Size = new Size(1000, 600);
            tabStaticMemory.TabIndex = 0;
            tabStaticMemory.Text = "  1. Arreglos en Memoria Contigua  ";
            tabStaticMemory.UseVisualStyleBackColor = true;
            // 
            // tlpStatic
            // 
            tlpStatic.ColumnCount = 2;
            tlpStatic.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 330F));
            tlpStatic.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tlpStatic.Controls.Add(gbStaticControls, 0, 0);
            tlpStatic.Controls.Add(gbElementOps, 0, 1);
            tlpStatic.Controls.Add(pnlStaticMetrics, 1, 0);
            tlpStatic.Controls.Add(dgvArray, 1, 1);
            tlpStatic.Controls.Add(txtArrayLog, 0, 2);
            tlpStatic.Dock = DockStyle.Fill;
            tlpStatic.Location = new Point(8, 8);
            tlpStatic.Name = "tlpStatic";
            tlpStatic.RowCount = 3;
            tlpStatic.RowStyles.Add(new RowStyle(SizeType.Absolute, 185F));
            tlpStatic.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpStatic.RowStyles.Add(new RowStyle(SizeType.Absolute, 130F));
            tlpStatic.Size = new Size(984, 584);
            tlpStatic.TabIndex = 0;
            // 
            // gbStaticControls
            // 
            gbStaticControls.Controls.Add(lblArrayInitSize);
            gbStaticControls.Controls.Add(nudArraySize);
            gbStaticControls.Controls.Add(btnInitArray);
            gbStaticControls.Controls.Add(lblNewSizePrompt);
            gbStaticControls.Controls.Add(nudNewSize);
            gbStaticControls.Controls.Add(btnResizeArray);
            gbStaticControls.Controls.Add(btnFillRandom);
            gbStaticControls.Controls.Add(btnClearArray);
            gbStaticControls.Dock = DockStyle.Fill;
            gbStaticControls.Font = new Font("Segoe UI", 9F);
            gbStaticControls.Location = new Point(3, 3);
            gbStaticControls.Name = "gbStaticControls";
            gbStaticControls.Size = new Size(324, 179);
            gbStaticControls.TabIndex = 0;
            gbStaticControls.TabStop = false;
            gbStaticControls.Text = "Configuración y Redimensionamiento";
            // 
            // lblArrayInitSize
            // 
            lblArrayInitSize.AutoSize = true;
            lblArrayInitSize.Location = new Point(10, 24);
            lblArrayInitSize.Name = "lblArrayInitSize";
            lblArrayInitSize.Size = new Size(87, 15);
            lblArrayInitSize.TabIndex = 0;
            lblArrayInitSize.Text = "Tamaño inicial:";
            // 
            // nudArraySize
            // 
            nudArraySize.Location = new Point(105, 22);
            nudArraySize.Maximum = new decimal(new int[] { 100000, 0, 0, 0 });
            nudArraySize.Name = "nudArraySize";
            nudArraySize.Size = new Size(70, 23);
            nudArraySize.TabIndex = 1;
            nudArraySize.Value = new decimal(new int[] { 5, 0, 0, 0 });
            // 
            // btnInitArray
            // 
            btnInitArray.Location = new Point(185, 20);
            btnInitArray.Name = "btnInitArray";
            btnInitArray.Size = new Size(125, 26);
            btnInitArray.TabIndex = 2;
            btnInitArray.Text = "Inicializar";
            btnInitArray.UseVisualStyleBackColor = true;
            btnInitArray.Click += btnInitArray_Click;
            // 
            // lblNewSizePrompt
            // 
            lblNewSizePrompt.AutoSize = true;
            lblNewSizePrompt.Location = new Point(10, 62);
            lblNewSizePrompt.Name = "lblNewSizePrompt";
            lblNewSizePrompt.Size = new Size(89, 15);
            lblNewSizePrompt.TabIndex = 3;
            lblNewSizePrompt.Text = "Nuevo tamaño:";
            // 
            // nudNewSize
            // 
            nudNewSize.Location = new Point(105, 60);
            nudNewSize.Maximum = new decimal(new int[] { 100000, 0, 0, 0 });
            nudNewSize.Name = "nudNewSize";
            nudNewSize.Size = new Size(70, 23);
            nudNewSize.TabIndex = 3;
            nudNewSize.Value = new decimal(new int[] { 8, 0, 0, 0 });
            // 
            // btnResizeArray
            // 
            btnResizeArray.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnResizeArray.Location = new Point(185, 58);
            btnResizeArray.Name = "btnResizeArray";
            btnResizeArray.Size = new Size(125, 28);
            btnResizeArray.TabIndex = 4;
            btnResizeArray.Text = "Redimensionar O(n)";
            btnResizeArray.UseVisualStyleBackColor = true;
            btnResizeArray.Click += btnResizeArray_Click;
            // 
            // btnFillRandom
            // 
            btnFillRandom.Location = new Point(10, 105);
            btnFillRandom.Name = "btnFillRandom";
            btnFillRandom.Size = new Size(145, 28);
            btnFillRandom.TabIndex = 5;
            btnFillRandom.Text = "Llenar Aleatorio";
            btnFillRandom.UseVisualStyleBackColor = true;
            btnFillRandom.Click += btnFillRandom_Click;
            // 
            // btnClearArray
            // 
            btnClearArray.Location = new Point(165, 105);
            btnClearArray.Name = "btnClearArray";
            btnClearArray.Size = new Size(145, 28);
            btnClearArray.TabIndex = 6;
            btnClearArray.Text = "Limpiar Valores";
            btnClearArray.UseVisualStyleBackColor = true;
            btnClearArray.Click += btnClearArray_Click;
            // 
            // gbElementOps
            // 
            gbElementOps.Controls.Add(lblIndex);
            gbElementOps.Controls.Add(nudIndex);
            gbElementOps.Controls.Add(lblValue);
            gbElementOps.Controls.Add(nudValue);
            gbElementOps.Controls.Add(btnSetElement);
            gbElementOps.Controls.Add(btnGetElement);
            gbElementOps.Dock = DockStyle.Fill;
            gbElementOps.Font = new Font("Segoe UI", 9F);
            gbElementOps.Location = new Point(3, 188);
            gbElementOps.Name = "gbElementOps";
            gbElementOps.Size = new Size(324, 263);
            gbElementOps.TabIndex = 1;
            gbElementOps.TabStop = false;
            gbElementOps.Text = "Acceso Directo por Índice (O(1))";
            // 
            // lblIndex
            // 
            lblIndex.AutoSize = true;
            lblIndex.Location = new Point(12, 32);
            lblIndex.Name = "lblIndex";
            lblIndex.Size = new Size(69, 15);
            lblIndex.TabIndex = 0;
            lblIndex.Text = "Posición [i]:";
            // 
            // nudIndex
            // 
            nudIndex.Location = new Point(88, 30);
            nudIndex.Maximum = new decimal(new int[] { 100000, 0, 0, 0 });
            nudIndex.Name = "nudIndex";
            nudIndex.Size = new Size(80, 23);
            nudIndex.TabIndex = 0;
            // 
            // lblValue
            // 
            lblValue.AutoSize = true;
            lblValue.Location = new Point(12, 68);
            lblValue.Name = "lblValue";
            lblValue.Size = new Size(61, 15);
            lblValue.TabIndex = 1;
            lblValue.Text = "Valor (int):";
            // 
            // nudValue
            // 
            nudValue.Location = new Point(88, 66);
            nudValue.Maximum = new decimal(new int[] { 999999, 0, 0, 0 });
            nudValue.Minimum = new decimal(new int[] { 999999, 0, 0, int.MinValue });
            nudValue.Name = "nudValue";
            nudValue.Size = new Size(80, 23);
            nudValue.TabIndex = 1;
            nudValue.Value = new decimal(new int[] { 42, 0, 0, 0 });
            // 
            // btnSetElement
            // 
            btnSetElement.Location = new Point(180, 28);
            btnSetElement.Name = "btnSetElement";
            btnSetElement.Size = new Size(130, 26);
            btnSetElement.TabIndex = 2;
            btnSetElement.Text = "Asignar (O(1))";
            btnSetElement.UseVisualStyleBackColor = true;
            btnSetElement.Click += btnSetElement_Click;
            // 
            // btnGetElement
            // 
            btnGetElement.Location = new Point(180, 64);
            btnGetElement.Name = "btnGetElement";
            btnGetElement.Size = new Size(130, 26);
            btnGetElement.TabIndex = 3;
            btnGetElement.Text = "Leer (O(1))";
            btnGetElement.UseVisualStyleBackColor = true;
            btnGetElement.Click += btnGetElement_Click;
            // 
            // pnlStaticMetrics
            // 
            pnlStaticMetrics.BackColor = Color.FromArgb(245, 248, 252);
            pnlStaticMetrics.BorderStyle = BorderStyle.FixedSingle;
            pnlStaticMetrics.Controls.Add(lblStaticMemoryEst);
            pnlStaticMetrics.Controls.Add(lblStaticReallocs);
            pnlStaticMetrics.Controls.Add(lblStaticLength);
            pnlStaticMetrics.Controls.Add(lblStaticRef);
            pnlStaticMetrics.Dock = DockStyle.Fill;
            pnlStaticMetrics.Location = new Point(333, 3);
            pnlStaticMetrics.Name = "pnlStaticMetrics";
            pnlStaticMetrics.Size = new Size(648, 179);
            pnlStaticMetrics.TabIndex = 2;
            // 
            // lblStaticMemoryEst
            // 
            lblStaticMemoryEst.AutoSize = true;
            lblStaticMemoryEst.Font = new Font("Segoe UI", 9.5F);
            lblStaticMemoryEst.Location = new Point(15, 105);
            lblStaticMemoryEst.Name = "lblStaticMemoryEst";
            lblStaticMemoryEst.Size = new Size(323, 17);
            lblStaticMemoryEst.TabIndex = 0;
            lblStaticMemoryEst.Text = "Consumo neto de datos: ~0 bytes (contiguo en Heap)";
            // 
            // lblStaticReallocs
            // 
            lblStaticReallocs.AutoSize = true;
            lblStaticReallocs.Font = new Font("Segoe UI", 9.5F);
            lblStaticReallocs.Location = new Point(15, 75);
            lblStaticReallocs.Name = "lblStaticReallocs";
            lblStaticReallocs.Size = new Size(210, 17);
            lblStaticReallocs.TabIndex = 1;
            lblStaticReallocs.Text = "Total de reasignaciones (copias): 0";
            // 
            // lblStaticLength
            // 
            lblStaticLength.AutoSize = true;
            lblStaticLength.Font = new Font("Segoe UI", 9.5F);
            lblStaticLength.Location = new Point(15, 45);
            lblStaticLength.Name = "lblStaticLength";
            lblStaticLength.Size = new Size(191, 17);
            lblStaticLength.TabIndex = 2;
            lblStaticLength.Text = "Capacidad del Bloque: 0 celdas";
            // 
            // lblStaticRef
            // 
            lblStaticRef.AutoSize = true;
            lblStaticRef.Font = new Font("Consolas", 10F, FontStyle.Bold);
            lblStaticRef.ForeColor = Color.FromArgb(10, 60, 140);
            lblStaticRef.Location = new Point(15, 15);
            lblStaticRef.Name = "lblStaticRef";
            lblStaticRef.Size = new Size(280, 17);
            lblStaticRef.TabIndex = 3;
            lblStaticRef.Text = "Dirección Base en Heap: 0x00000000";
            // 
            // dgvArray
            // 
            dgvArray.AllowUserToAddRows = false;
            dgvArray.AllowUserToDeleteRows = false;
            dgvArray.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvArray.BackgroundColor = Color.White;
            dgvArray.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvArray.Columns.AddRange(new DataGridViewColumn[] { colIndex, colValue, colStorage, colComplexity });
            dgvArray.Dock = DockStyle.Fill;
            dgvArray.Location = new Point(333, 188);
            dgvArray.MultiSelect = false;
            dgvArray.Name = "dgvArray";
            dgvArray.ReadOnly = true;
            dgvArray.RowHeadersVisible = false;
            dgvArray.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvArray.Size = new Size(648, 263);
            dgvArray.TabIndex = 3;
            // 
            // colIndex
            // 
            colIndex.FillWeight = 20F;
            colIndex.HeaderText = "Índice [i]";
            colIndex.Name = "colIndex";
            colIndex.ReadOnly = true;
            // 
            // colValue
            // 
            colValue.FillWeight = 25F;
            colValue.HeaderText = "Valor";
            colValue.Name = "colValue";
            colValue.ReadOnly = true;
            // 
            // colStorage
            // 
            colStorage.FillWeight = 30F;
            colStorage.HeaderText = "Almacenamiento Físico";
            colStorage.Name = "colStorage";
            colStorage.ReadOnly = true;
            // 
            // colComplexity
            // 
            colComplexity.FillWeight = 25F;
            colComplexity.HeaderText = "Cálculo de Dirección";
            colComplexity.Name = "colComplexity";
            colComplexity.ReadOnly = true;
            // 
            // txtArrayLog
            // 
            txtArrayLog.BackColor = Color.FromArgb(20, 24, 30);
            tlpStatic.SetColumnSpan(txtArrayLog, 2);
            txtArrayLog.Dock = DockStyle.Fill;
            txtArrayLog.Font = new Font("Consolas", 8.5F);
            txtArrayLog.ForeColor = Color.FromArgb(200, 240, 200);
            txtArrayLog.Location = new Point(3, 457);
            txtArrayLog.Multiline = true;
            txtArrayLog.Name = "txtArrayLog";
            txtArrayLog.ReadOnly = true;
            txtArrayLog.ScrollBars = ScrollBars.Vertical;
            txtArrayLog.Size = new Size(978, 124);
            txtArrayLog.TabIndex = 4;
            // 
            // tabDynamicMemory
            // 
            tabDynamicMemory.Controls.Add(tlpDynamic);
            tabDynamicMemory.Location = new Point(4, 26);
            tabDynamicMemory.Name = "tabDynamicMemory";
            tabDynamicMemory.Padding = new Padding(8);
            tabDynamicMemory.Size = new Size(1000, 600);
            tabDynamicMemory.TabIndex = 1;
            tabDynamicMemory.Text = "  2. Memoria Dinámica (Nodos en Heap)  ";
            tabDynamicMemory.UseVisualStyleBackColor = true;
            // 
            // tlpDynamic
            // 
            tlpDynamic.ColumnCount = 2;
            tlpDynamic.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 330F));
            tlpDynamic.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tlpDynamic.Controls.Add(gbDynamicControls, 0, 0);
            tlpDynamic.Controls.Add(gbGC, 0, 1);
            tlpDynamic.Controls.Add(pnlDynamicMetrics, 1, 0);
            tlpDynamic.Controls.Add(dgvDynamicNodes, 1, 1);
            tlpDynamic.Controls.Add(txtDynamicLog, 0, 2);
            tlpDynamic.Dock = DockStyle.Fill;
            tlpDynamic.Location = new Point(8, 8);
            tlpDynamic.Name = "tlpDynamic";
            tlpDynamic.RowCount = 3;
            tlpDynamic.RowStyles.Add(new RowStyle(SizeType.Absolute, 185F));
            tlpDynamic.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpDynamic.RowStyles.Add(new RowStyle(SizeType.Absolute, 130F));
            tlpDynamic.Size = new Size(984, 584);
            tlpDynamic.TabIndex = 1;
            // 
            // gbDynamicControls
            // 
            gbDynamicControls.Controls.Add(lblDynamicValue);
            gbDynamicControls.Controls.Add(nudDynamicValue);
            gbDynamicControls.Controls.Add(btnAddLast);
            gbDynamicControls.Controls.Add(btnAddFirst);
            gbDynamicControls.Controls.Add(btnRemoveFirst);
            gbDynamicControls.Controls.Add(btnRemoveLast);
            gbDynamicControls.Controls.Add(btnClearDynamic);
            gbDynamicControls.Dock = DockStyle.Fill;
            gbDynamicControls.Font = new Font("Segoe UI", 9F);
            gbDynamicControls.Location = new Point(3, 3);
            gbDynamicControls.Name = "gbDynamicControls";
            gbDynamicControls.Size = new Size(324, 179);
            gbDynamicControls.TabIndex = 0;
            gbDynamicControls.TabStop = false;
            gbDynamicControls.Text = "Operaciones en Memoria Dinámica";
            // 
            // lblDynamicValue
            // 
            lblDynamicValue.AutoSize = true;
            lblDynamicValue.Location = new Point(12, 25);
            lblDynamicValue.Name = "lblDynamicValue";
            lblDynamicValue.Size = new Size(88, 15);
            lblDynamicValue.TabIndex = 0;
            lblDynamicValue.Text = "Valor del Nodo:";
            // 
            // nudDynamicValue
            // 
            nudDynamicValue.Location = new Point(105, 23);
            nudDynamicValue.Maximum = new decimal(new int[] { 999999, 0, 0, 0 });
            nudDynamicValue.Minimum = new decimal(new int[] { 999999, 0, 0, int.MinValue });
            nudDynamicValue.Name = "nudDynamicValue";
            nudDynamicValue.Size = new Size(80, 23);
            nudDynamicValue.TabIndex = 1;
            nudDynamicValue.Value = new decimal(new int[] { 100, 0, 0, 0 });
            // 
            // btnAddLast
            // 
            btnAddLast.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnAddLast.Location = new Point(195, 20);
            btnAddLast.Name = "btnAddLast";
            btnAddLast.Size = new Size(120, 26);
            btnAddLast.TabIndex = 2;
            btnAddLast.Text = "+ Add Last O(1)";
            btnAddLast.UseVisualStyleBackColor = true;
            btnAddLast.Click += btnAddLast_Click;
            // 
            // btnAddFirst
            // 
            btnAddFirst.Location = new Point(12, 60);
            btnAddFirst.Name = "btnAddFirst";
            btnAddFirst.Size = new Size(145, 26);
            btnAddFirst.TabIndex = 3;
            btnAddFirst.Text = "+ Add First O(1)";
            btnAddFirst.UseVisualStyleBackColor = true;
            btnAddFirst.Click += btnAddFirst_Click;
            // 
            // btnRemoveFirst
            // 
            btnRemoveFirst.Location = new Point(170, 60);
            btnRemoveFirst.Name = "btnRemoveFirst";
            btnRemoveFirst.Size = new Size(145, 26);
            btnRemoveFirst.TabIndex = 4;
            btnRemoveFirst.Text = "- Remove First";
            btnRemoveFirst.UseVisualStyleBackColor = true;
            btnRemoveFirst.Click += btnRemoveFirst_Click;
            // 
            // btnRemoveLast
            // 
            btnRemoveLast.Location = new Point(12, 100);
            btnRemoveLast.Name = "btnRemoveLast";
            btnRemoveLast.Size = new Size(145, 26);
            btnRemoveLast.TabIndex = 5;
            btnRemoveLast.Text = "- Remove Last";
            btnRemoveLast.UseVisualStyleBackColor = true;
            btnRemoveLast.Click += btnRemoveLast_Click;
            // 
            // btnClearDynamic
            // 
            btnClearDynamic.Location = new Point(170, 100);
            btnClearDynamic.Name = "btnClearDynamic";
            btnClearDynamic.Size = new Size(145, 26);
            btnClearDynamic.TabIndex = 6;
            btnClearDynamic.Text = "Vaciar Todo (Clear)";
            btnClearDynamic.UseVisualStyleBackColor = true;
            btnClearDynamic.Click += btnClearDynamic_Click;
            // 
            // gbGC
            // 
            gbGC.Controls.Add(btnForceGC);
            gbGC.Controls.Add(lblGCStatus);
            gbGC.Dock = DockStyle.Fill;
            gbGC.Font = new Font("Segoe UI", 9F);
            gbGC.Location = new Point(3, 188);
            gbGC.Name = "gbGC";
            gbGC.Size = new Size(324, 263);
            gbGC.TabIndex = 1;
            gbGC.TabStop = false;
            gbGC.Text = "Garbage Collector & Liberación de Heap";
            // 
            // btnForceGC
            // 
            btnForceGC.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnForceGC.Location = new Point(15, 30);
            btnForceGC.Name = "btnForceGC";
            btnForceGC.Size = new Size(295, 35);
            btnForceGC.TabIndex = 0;
            btnForceGC.Text = "Forzar Recolección (GC.Collect)";
            btnForceGC.UseVisualStyleBackColor = true;
            btnForceGC.Click += btnForceGC_Click;
            // 
            // lblGCStatus
            // 
            lblGCStatus.Font = new Font("Segoe UI", 8.8F);
            lblGCStatus.Location = new Point(15, 75);
            lblGCStatus.Name = "lblGCStatus";
            lblGCStatus.Size = new Size(295, 170);
            lblGCStatus.TabIndex = 1;
            lblGCStatus.Text = "El Garbage Collector rastrea objetos inalcanzables en el Heap y reclama su memoria de forma no determinista.\r\n\r\nPresione el botón para forzar un ciclo de compactación y ver la memoria recuperada.";
            // 
            // pnlDynamicMetrics
            // 
            pnlDynamicMetrics.BackColor = Color.FromArgb(245, 252, 248);
            pnlDynamicMetrics.BorderStyle = BorderStyle.FixedSingle;
            pnlDynamicMetrics.Controls.Add(lblDynamicOverhead);
            pnlDynamicMetrics.Controls.Add(lblDynamicTail);
            pnlDynamicMetrics.Controls.Add(lblDynamicHead);
            pnlDynamicMetrics.Controls.Add(lblDynamicCount);
            pnlDynamicMetrics.Dock = DockStyle.Fill;
            pnlDynamicMetrics.Location = new Point(333, 3);
            pnlDynamicMetrics.Name = "pnlDynamicMetrics";
            pnlDynamicMetrics.Size = new Size(648, 179);
            pnlDynamicMetrics.TabIndex = 2;
            // 
            // lblDynamicOverhead
            // 
            lblDynamicOverhead.AutoSize = true;
            lblDynamicOverhead.Font = new Font("Segoe UI", 9.5F);
            lblDynamicOverhead.Location = new Point(15, 105);
            lblDynamicOverhead.Name = "lblDynamicOverhead";
            lblDynamicOverhead.Size = new Size(460, 17);
            lblDynamicOverhead.TabIndex = 3;
            lblDynamicOverhead.Text = "Sobrecarga de punteros: ~32 bytes por nodo (Header + TypeHandle + Next)";
            // 
            // lblDynamicTail
            // 
            lblDynamicTail.AutoSize = true;
            lblDynamicTail.Font = new Font("Consolas", 9.5F);
            lblDynamicTail.Location = new Point(15, 75);
            lblDynamicTail.Name = "lblDynamicTail";
            lblDynamicTail.Size = new Size(203, 15);
            lblDynamicTail.TabIndex = 2;
            lblDynamicTail.Text = "Puntero Cola   (_tail): null";
            // 
            // lblDynamicHead
            // 
            lblDynamicHead.AutoSize = true;
            lblDynamicHead.Font = new Font("Consolas", 9.5F);
            lblDynamicHead.Location = new Point(15, 45);
            lblDynamicHead.Name = "lblDynamicHead";
            lblDynamicHead.Size = new Size(203, 15);
            lblDynamicHead.TabIndex = 1;
            lblDynamicHead.Text = "Puntero Cabeza (_head): null";
            // 
            // lblDynamicCount
            // 
            lblDynamicCount.AutoSize = true;
            lblDynamicCount.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblDynamicCount.ForeColor = Color.FromArgb(20, 100, 50);
            lblDynamicCount.Location = new Point(15, 15);
            lblDynamicCount.Name = "lblDynamicCount";
            lblDynamicCount.Size = new Size(182, 19);
            lblDynamicCount.TabIndex = 0;
            lblDynamicCount.Text = "Nodos Activos en Heap: 0";
            // 
            // dgvDynamicNodes
            // 
            dgvDynamicNodes.AllowUserToAddRows = false;
            dgvDynamicNodes.AllowUserToDeleteRows = false;
            dgvDynamicNodes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvDynamicNodes.BackgroundColor = Color.White;
            dgvDynamicNodes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDynamicNodes.Columns.AddRange(new DataGridViewColumn[] { colNodeId, colNodeData, colNodeAddress, colNodeNext, colNodeTimestamp });
            dgvDynamicNodes.Dock = DockStyle.Fill;
            dgvDynamicNodes.Location = new Point(333, 188);
            dgvDynamicNodes.MultiSelect = false;
            dgvDynamicNodes.Name = "dgvDynamicNodes";
            dgvDynamicNodes.ReadOnly = true;
            dgvDynamicNodes.RowHeadersVisible = false;
            dgvDynamicNodes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvDynamicNodes.Size = new Size(648, 263);
            dgvDynamicNodes.TabIndex = 3;
            // 
            // colNodeId
            // 
            colNodeId.FillWeight = 15F;
            colNodeId.HeaderText = "ID Nodo";
            colNodeId.Name = "colNodeId";
            colNodeId.ReadOnly = true;
            // 
            // colNodeData
            // 
            colNodeData.FillWeight = 20F;
            colNodeData.HeaderText = "Dato (int)";
            colNodeData.Name = "colNodeData";
            colNodeData.ReadOnly = true;
            // 
            // colNodeAddress
            // 
            colNodeAddress.FillWeight = 25F;
            colNodeAddress.HeaderText = "Dirección en Heap (Puntero)";
            colNodeAddress.Name = "colNodeAddress";
            colNodeAddress.ReadOnly = true;
            // 
            // colNodeNext
            // 
            colNodeNext.FillWeight = 25F;
            colNodeNext.HeaderText = "Puntero Siguiente (Next)";
            colNodeNext.Name = "colNodeNext";
            colNodeNext.ReadOnly = true;
            // 
            // colNodeTimestamp
            // 
            colNodeTimestamp.FillWeight = 20F;
            colNodeTimestamp.HeaderText = "Hora Asignación";
            colNodeTimestamp.Name = "colNodeTimestamp";
            colNodeTimestamp.ReadOnly = true;
            // 
            // txtDynamicLog
            // 
            txtDynamicLog.BackColor = Color.FromArgb(20, 24, 30);
            tlpDynamic.SetColumnSpan(txtDynamicLog, 2);
            txtDynamicLog.Dock = DockStyle.Fill;
            txtDynamicLog.Font = new Font("Consolas", 8.5F);
            txtDynamicLog.ForeColor = Color.FromArgb(200, 240, 255);
            txtDynamicLog.Location = new Point(3, 457);
            txtDynamicLog.Multiline = true;
            txtDynamicLog.Name = "txtDynamicLog";
            txtDynamicLog.ReadOnly = true;
            txtDynamicLog.ScrollBars = ScrollBars.Vertical;
            txtDynamicLog.Size = new Size(978, 124);
            txtDynamicLog.TabIndex = 4;
            // 
            // tabBenchmark
            // 
            tabBenchmark.Controls.Add(tlpBenchmark);
            tabBenchmark.Location = new Point(4, 26);
            tabBenchmark.Name = "tabBenchmark";
            tabBenchmark.Padding = new Padding(8);
            tabBenchmark.Size = new Size(1000, 600);
            tabBenchmark.TabIndex = 2;
            tabBenchmark.Text = "  3. Comparativa de Rendimiento y Conclusión  ";
            tabBenchmark.UseVisualStyleBackColor = true;
            // 
            // tlpBenchmark
            // 
            tlpBenchmark.ColumnCount = 1;
            tlpBenchmark.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tlpBenchmark.Controls.Add(gbBenchmarkConfig, 0, 0);
            tlpBenchmark.Controls.Add(dgvBenchmark, 0, 1);
            tlpBenchmark.Controls.Add(txtAcademicConclusion, 0, 2);
            tlpBenchmark.Dock = DockStyle.Fill;
            tlpBenchmark.Location = new Point(8, 8);
            tlpBenchmark.Name = "tlpBenchmark";
            tlpBenchmark.RowCount = 3;
            tlpBenchmark.RowStyles.Add(new RowStyle(SizeType.Absolute, 95F));
            tlpBenchmark.RowStyles.Add(new RowStyle(SizeType.Absolute, 155F));
            tlpBenchmark.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpBenchmark.Size = new Size(984, 584);
            tlpBenchmark.TabIndex = 0;
            // 
            // gbBenchmarkConfig
            // 
            gbBenchmarkConfig.Controls.Add(lblBenchmarkElements);
            gbBenchmarkConfig.Controls.Add(cmbBenchmarkCount);
            gbBenchmarkConfig.Controls.Add(btnRunBenchmark);
            gbBenchmarkConfig.Controls.Add(pbBenchmark);
            gbBenchmarkConfig.Controls.Add(lblBenchmarkProgress);
            gbBenchmarkConfig.Dock = DockStyle.Fill;
            gbBenchmarkConfig.Font = new Font("Segoe UI", 9F);
            gbBenchmarkConfig.Location = new Point(3, 3);
            gbBenchmarkConfig.Name = "gbBenchmarkConfig";
            gbBenchmarkConfig.Size = new Size(978, 89);
            gbBenchmarkConfig.TabIndex = 0;
            gbBenchmarkConfig.TabStop = false;
            gbBenchmarkConfig.Text = "Configuración del Experimento Comparativo (O(N²) vs O(N))";
            // 
            // lblBenchmarkElements
            // 
            lblBenchmarkElements.AutoSize = true;
            lblBenchmarkElements.Location = new Point(15, 25);
            lblBenchmarkElements.Name = "lblBenchmarkElements";
            lblBenchmarkElements.Size = new Size(132, 15);
            lblBenchmarkElements.TabIndex = 0;
            lblBenchmarkElements.Text = "Cantidad de Elementos:";
            // 
            // cmbBenchmarkCount
            // 
            cmbBenchmarkCount.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbBenchmarkCount.FormattingEnabled = true;
            cmbBenchmarkCount.Items.AddRange(new object[] { "500 elementos", "1,000 elementos", "2,500 elementos", "5,000 elementos", "10,000 elementos (Recomendado)", "20,000 elementos" });
            cmbBenchmarkCount.Location = new Point(150, 22);
            cmbBenchmarkCount.Name = "cmbBenchmarkCount";
            cmbBenchmarkCount.Size = new Size(210, 23);
            cmbBenchmarkCount.TabIndex = 1;
            // 
            // btnRunBenchmark
            // 
            btnRunBenchmark.BackColor = Color.FromArgb(24, 75, 145);
            btnRunBenchmark.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnRunBenchmark.ForeColor = Color.White;
            btnRunBenchmark.Location = new Point(375, 18);
            btnRunBenchmark.Name = "btnRunBenchmark";
            btnRunBenchmark.Size = new Size(210, 30);
            btnRunBenchmark.TabIndex = 2;
            btnRunBenchmark.Text = "▶ Iniciar Benchmark";
            btnRunBenchmark.UseVisualStyleBackColor = false;
            btnRunBenchmark.Click += btnRunBenchmark_Click;
            // 
            // pbBenchmark
            // 
            pbBenchmark.Location = new Point(15, 55);
            pbBenchmark.Name = "pbBenchmark";
            pbBenchmark.Size = new Size(570, 18);
            pbBenchmark.TabIndex = 3;
            // 
            // lblBenchmarkProgress
            // 
            lblBenchmarkProgress.AutoSize = true;
            lblBenchmarkProgress.Location = new Point(595, 57);
            lblBenchmarkProgress.Name = "lblBenchmarkProgress";
            lblBenchmarkProgress.Size = new Size(142, 15);
            lblBenchmarkProgress.TabIndex = 4;
            lblBenchmarkProgress.Text = "Listo para iniciar prueba...";
            // 
            // dgvBenchmark
            // 
            dgvBenchmark.AllowUserToAddRows = false;
            dgvBenchmark.AllowUserToDeleteRows = false;
            dgvBenchmark.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvBenchmark.BackgroundColor = Color.White;
            dgvBenchmark.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvBenchmark.Columns.AddRange(new DataGridViewColumn[] { colBenchMetric, colBenchArray, colBenchDynamic, colBenchNotes });
            dgvBenchmark.Dock = DockStyle.Fill;
            dgvBenchmark.Location = new Point(3, 98);
            dgvBenchmark.MultiSelect = false;
            dgvBenchmark.Name = "dgvBenchmark";
            dgvBenchmark.ReadOnly = true;
            dgvBenchmark.RowHeadersVisible = false;
            dgvBenchmark.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvBenchmark.Size = new Size(978, 149);
            dgvBenchmark.TabIndex = 1;
            // 
            // colBenchMetric
            // 
            colBenchMetric.FillWeight = 25F;
            colBenchMetric.HeaderText = "Métrica de Desempeño";
            colBenchMetric.Name = "colBenchMetric";
            colBenchMetric.ReadOnly = true;
            // 
            // colBenchArray
            // 
            colBenchArray.FillWeight = 25F;
            colBenchArray.HeaderText = "Arreglo (Memoria Contigua)";
            colBenchArray.Name = "colBenchArray";
            colBenchArray.ReadOnly = true;
            // 
            // colBenchDynamic
            // 
            colBenchDynamic.FillWeight = 25F;
            colBenchDynamic.HeaderText = "Lista Dinámica (Heap)";
            colBenchDynamic.Name = "colBenchDynamic";
            colBenchDynamic.ReadOnly = true;
            // 
            // colBenchNotes
            // 
            colBenchNotes.FillWeight = 35F;
            colBenchNotes.HeaderText = "Fundamento Teórico / Complejidad";
            colBenchNotes.Name = "colBenchNotes";
            colBenchNotes.ReadOnly = true;
            // 
            // txtAcademicConclusion
            // 
            txtAcademicConclusion.BackColor = Color.FromArgb(248, 250, 253);
            txtAcademicConclusion.Dock = DockStyle.Fill;
            txtAcademicConclusion.Font = new Font("Consolas", 9F);
            txtAcademicConclusion.ForeColor = Color.FromArgb(20, 30, 45);
            txtAcademicConclusion.Location = new Point(3, 253);
            txtAcademicConclusion.Multiline = true;
            txtAcademicConclusion.Name = "txtAcademicConclusion";
            txtAcademicConclusion.ReadOnly = true;
            txtAcademicConclusion.ScrollBars = ScrollBars.Vertical;
            txtAcademicConclusion.Size = new Size(978, 328);
            txtAcademicConclusion.TabIndex = 2;
            // 
            // statusStrip
            // 
            statusStrip.Items.AddRange(new ToolStripItem[] { statusLabel });
            statusStrip.Location = new Point(0, 695);
            statusStrip.Name = "statusStrip";
            statusStrip.Size = new Size(1008, 22);
            statusStrip.TabIndex = 2;
            // 
            // statusLabel
            // 
            statusLabel.Name = "statusLabel";
            statusLabel.Size = new Size(325, 17);
            statusLabel.Text = "Aplicación iniciada. Seleccione una pestaña para interactuar.";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1008, 717);
            Controls.Add(tabControlMain);
            Controls.Add(statusStrip);
            Controls.Add(pnlHeader);
            MinimumSize = new Size(950, 680);
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Estructuras de Datos - Tarea 1.2: Memoria Estática vs Dinámica";
            Load += MainForm_Load;
            pnlHeader.ResumeLayout(false);
            pnlHeader.PerformLayout();
            tabControlMain.ResumeLayout(false);
            tabStaticMemory.ResumeLayout(false);
            tlpStatic.ResumeLayout(false);
            tlpStatic.PerformLayout();
            gbStaticControls.ResumeLayout(false);
            gbStaticControls.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudArraySize).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudNewSize).EndInit();
            gbElementOps.ResumeLayout(false);
            gbElementOps.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudIndex).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudValue).EndInit();
            pnlStaticMetrics.ResumeLayout(false);
            pnlStaticMetrics.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvArray).EndInit();
            tabDynamicMemory.ResumeLayout(false);
            tlpDynamic.ResumeLayout(false);
            tlpDynamic.PerformLayout();
            gbDynamicControls.ResumeLayout(false);
            gbDynamicControls.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudDynamicValue).EndInit();
            gbGC.ResumeLayout(false);
            pnlDynamicMetrics.ResumeLayout(false);
            pnlDynamicMetrics.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDynamicNodes).EndInit();
            tabBenchmark.ResumeLayout(false);
            tlpBenchmark.ResumeLayout(false);
            tlpBenchmark.PerformLayout();
            gbBenchmarkConfig.ResumeLayout(false);
            gbBenchmarkConfig.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvBenchmark).EndInit();
            statusStrip.ResumeLayout(false);
            statusStrip.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblSubtitle;
        private System.Windows.Forms.TabControl tabControlMain;
        
        // Tab 1 controls
        private System.Windows.Forms.TabPage tabStaticMemory;
        private System.Windows.Forms.TableLayoutPanel tlpStatic;
        private System.Windows.Forms.GroupBox gbStaticControls;
        private System.Windows.Forms.Label lblArrayInitSize;
        private System.Windows.Forms.NumericUpDown nudArraySize;
        private System.Windows.Forms.Button btnInitArray;
        private System.Windows.Forms.Label lblNewSizePrompt;
        private System.Windows.Forms.NumericUpDown nudNewSize;
        private System.Windows.Forms.Button btnResizeArray;
        private System.Windows.Forms.Button btnFillRandom;
        private System.Windows.Forms.Button btnClearArray;
        private System.Windows.Forms.GroupBox gbElementOps;
        private System.Windows.Forms.Label lblIndex;
        private System.Windows.Forms.NumericUpDown nudIndex;
        private System.Windows.Forms.Label lblValue;
        private System.Windows.Forms.NumericUpDown nudValue;
        private System.Windows.Forms.Button btnSetElement;
        private System.Windows.Forms.Button btnGetElement;
        private System.Windows.Forms.Panel pnlStaticMetrics;
        private System.Windows.Forms.Label lblStaticRef;
        private System.Windows.Forms.Label lblStaticLength;
        private System.Windows.Forms.Label lblStaticReallocs;
        private System.Windows.Forms.Label lblStaticMemoryEst;
        private System.Windows.Forms.DataGridView dgvArray;
        private System.Windows.Forms.DataGridViewTextBoxColumn colIndex;
        private System.Windows.Forms.DataGridViewTextBoxColumn colValue;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStorage;
        private System.Windows.Forms.DataGridViewTextBoxColumn colComplexity;
        private System.Windows.Forms.TextBox txtArrayLog;

        // Tab 2 controls
        private System.Windows.Forms.TabPage tabDynamicMemory;
        private System.Windows.Forms.TableLayoutPanel tlpDynamic;
        private System.Windows.Forms.GroupBox gbDynamicControls;
        private System.Windows.Forms.Label lblDynamicValue;
        private System.Windows.Forms.NumericUpDown nudDynamicValue;
        private System.Windows.Forms.Button btnAddLast;
        private System.Windows.Forms.Button btnAddFirst;
        private System.Windows.Forms.Button btnRemoveFirst;
        private System.Windows.Forms.Button btnRemoveLast;
        private System.Windows.Forms.Button btnClearDynamic;
        private System.Windows.Forms.GroupBox gbGC;
        private System.Windows.Forms.Button btnForceGC;
        private System.Windows.Forms.Label lblGCStatus;
        private System.Windows.Forms.Panel pnlDynamicMetrics;
        private System.Windows.Forms.Label lblDynamicCount;
        private System.Windows.Forms.Label lblDynamicHead;
        private System.Windows.Forms.Label lblDynamicTail;
        private System.Windows.Forms.Label lblDynamicOverhead;
        private System.Windows.Forms.DataGridView dgvDynamicNodes;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNodeId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNodeData;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNodeAddress;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNodeNext;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNodeTimestamp;
        private System.Windows.Forms.TextBox txtDynamicLog;

        // Tab 3 controls
        private System.Windows.Forms.TabPage tabBenchmark;
        private System.Windows.Forms.TableLayoutPanel tlpBenchmark;
        private System.Windows.Forms.GroupBox gbBenchmarkConfig;
        private System.Windows.Forms.Label lblBenchmarkElements;
        private System.Windows.Forms.ComboBox cmbBenchmarkCount;
        private System.Windows.Forms.Button btnRunBenchmark;
        private System.Windows.Forms.ProgressBar pbBenchmark;
        private System.Windows.Forms.Label lblBenchmarkProgress;
        private System.Windows.Forms.DataGridView dgvBenchmark;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBenchMetric;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBenchArray;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBenchDynamic;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBenchNotes;
        private System.Windows.Forms.TextBox txtAcademicConclusion;

        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel statusLabel;
    }
}
