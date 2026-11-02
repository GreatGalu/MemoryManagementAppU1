namespace MemoryManagementApp
{
    partial class MainForm
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            gbStaticMemory = new GroupBox();
            lblNewSize = new Label();
            txtNewSize = new TextBox();
            btnResizeArray = new Button();
            gbDynamicMemory = new GroupBox();
            lblNodeData = new Label();
            txtNodeData = new TextBox();
            btnAddDynamicNode = new Button();
            gbStaticMemory.SuspendLayout();
            gbDynamicMemory.SuspendLayout();
            SuspendLayout();
            // 
            // gbStaticMemory
            // 
            gbStaticMemory.Controls.Add(lblNewSize);
            gbStaticMemory.Controls.Add(txtNewSize);
            gbStaticMemory.Controls.Add(btnResizeArray);
            gbStaticMemory.Location = new Point(18, 11);
            gbStaticMemory.Margin = new Padding(3, 2, 3, 2);
            gbStaticMemory.Name = "gbStaticMemory";
            gbStaticMemory.Padding = new Padding(3, 2, 3, 2);
            gbStaticMemory.Size = new Size(306, 90);
            gbStaticMemory.TabIndex = 0;
            gbStaticMemory.TabStop = false;
            gbStaticMemory.Text = "Memoria estática (Redimensionamiento de la matriz)";
            // 
            // lblNewSize
            // 
            lblNewSize.AutoSize = true;
            lblNewSize.Location = new Point(18, 30);
            lblNewSize.Name = "lblNewSize";
            lblNewSize.Size = new Size(148, 15);
            lblNewSize.TabIndex = 0;
            lblNewSize.Text = "Nuevo tamaño del arreglo:";
            // 
            // txtNewSize
            // 
            txtNewSize.Location = new Point(172, 29);
            txtNewSize.Margin = new Padding(3, 2, 3, 2);
            txtNewSize.Name = "txtNewSize";
            txtNewSize.Size = new Size(88, 23);
            txtNewSize.TabIndex = 1;
            txtNewSize.TextChanged += txtNewSize_TextChanged;
            // 
            // btnResizeArray
            // 
            btnResizeArray.Location = new Point(172, 56);
            btnResizeArray.Margin = new Padding(3, 2, 3, 2);
            btnResizeArray.Name = "btnResizeArray";
            btnResizeArray.Size = new Size(88, 22);
            btnResizeArray.TabIndex = 2;
            btnResizeArray.Text = "Redimensionar Arreglo";
            btnResizeArray.UseVisualStyleBackColor = true;
            btnResizeArray.Click += btnResizeArray_Click;
            // 
            // gbDynamicMemory
            // 
            gbDynamicMemory.Controls.Add(lblNodeData);
            gbDynamicMemory.Controls.Add(txtNodeData);
            gbDynamicMemory.Controls.Add(btnAddDynamicNode);
            gbDynamicMemory.Location = new Point(18, 120);
            gbDynamicMemory.Margin = new Padding(3, 2, 3, 2);
            gbDynamicMemory.Name = "gbDynamicMemory";
            gbDynamicMemory.Padding = new Padding(3, 2, 3, 2);
            gbDynamicMemory.Size = new Size(306, 90);
            gbDynamicMemory.TabIndex = 1;
            gbDynamicMemory.TabStop = false;
            gbDynamicMemory.Text = "Memoria dinámica (Alojamientos en el Heap)";
            // 
            // lblNodeData
            // 
            lblNodeData.AutoSize = true;
            lblNodeData.Location = new Point(18, 30);
            lblNodeData.Name = "lblNodeData";
            lblNodeData.Size = new Size(115, 15);
            lblNodeData.TabIndex = 0;
            lblNodeData.Text = "Datos del nodo (Int):";
            // 
            // txtNodeData
            // 
            txtNodeData.Location = new Point(172, 30);
            txtNodeData.Margin = new Padding(3, 2, 3, 2);
            txtNodeData.Name = "txtNodeData";
            txtNodeData.Size = new Size(88, 23);
            txtNodeData.TabIndex = 1;
            // 
            // btnAddDynamicNode
            // 
            btnAddDynamicNode.Location = new Point(172, 57);
            btnAddDynamicNode.Margin = new Padding(3, 2, 3, 2);
            btnAddDynamicNode.Name = "btnAddDynamicNode";
            btnAddDynamicNode.Size = new Size(88, 22);
            btnAddDynamicNode.TabIndex = 2;
            btnAddDynamicNode.Text = "Agregar Nodo";
            btnAddDynamicNode.UseVisualStyleBackColor = true;
            btnAddDynamicNode.Click += btnAddDynamicNode_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(350, 232);
            Controls.Add(gbDynamicMemory);
            Controls.Add(gbStaticMemory);
            Margin = new Padding(3, 2, 3, 2);
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Gestión de Memoria - Tarea 1.2";
            gbStaticMemory.ResumeLayout(false);
            gbStaticMemory.PerformLayout();
            gbDynamicMemory.ResumeLayout(false);
            gbDynamicMemory.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.GroupBox gbStaticMemory;
        private System.Windows.Forms.Label lblNewSize;
        private System.Windows.Forms.TextBox txtNewSize;
        private System.Windows.Forms.Button btnResizeArray;

        private System.Windows.Forms.GroupBox gbDynamicMemory;
        private System.Windows.Forms.Label lblNodeData;
        private System.Windows.Forms.TextBox txtNodeData;
        private System.Windows.Forms.Button btnAddDynamicNode;
    }
}