namespace ProyectoU
{
    partial class frmInventario
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNombreRepuesto = new System.Windows.Forms.TextBox();
            this.inventarioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.carClinicBDDataSet = new ProyectoU.CarClinicBDDataSet();
            this.txtPrecioRepuesto = new System.Windows.Forms.TextBox();
            this.txtStockRepuesto = new System.Windows.Forms.TextBox();
            this.btnGuardarRepuesto = new System.Windows.Forms.Button();
            this.btnNuevoRepuesto = new System.Windows.Forms.Button();
            this.dgvInventario = new System.Windows.Forms.DataGridView();
            this.repuestoIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreRepuestoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stockDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.inventarioTableAdapter = new ProyectoU.CarClinicBDDataSetTableAdapters.InventarioTableAdapter();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.inventarioBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.carClinicBDDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInventario)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre Repuesto:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Precio:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Stock (Cantidad):";
            // 
            // txtNombreRepuesto
            // 
            this.txtNombreRepuesto.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.inventarioBindingSource, "NombreRepuesto", true));
            this.txtNombreRepuesto.Location = new System.Drawing.Point(147, 33);
            this.txtNombreRepuesto.Name = "txtNombreRepuesto";
            this.txtNombreRepuesto.Size = new System.Drawing.Size(236, 22);
            this.txtNombreRepuesto.TabIndex = 3;
            // 
            // inventarioBindingSource
            // 
            this.inventarioBindingSource.DataMember = "Inventario";
            this.inventarioBindingSource.DataSource = this.carClinicBDDataSet;
            // 
            // carClinicBDDataSet
            // 
            this.carClinicBDDataSet.DataSetName = "CarClinicBDDataSet";
            this.carClinicBDDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txtPrecioRepuesto
            // 
            this.txtPrecioRepuesto.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.inventarioBindingSource, "Precio", true));
            this.txtPrecioRepuesto.Location = new System.Drawing.Point(147, 81);
            this.txtPrecioRepuesto.Name = "txtPrecioRepuesto";
            this.txtPrecioRepuesto.Size = new System.Drawing.Size(236, 22);
            this.txtPrecioRepuesto.TabIndex = 4;
            // 
            // txtStockRepuesto
            // 
            this.txtStockRepuesto.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.inventarioBindingSource, "Stock", true));
            this.txtStockRepuesto.Location = new System.Drawing.Point(147, 124);
            this.txtStockRepuesto.Name = "txtStockRepuesto";
            this.txtStockRepuesto.Size = new System.Drawing.Size(236, 22);
            this.txtStockRepuesto.TabIndex = 5;
            // 
            // btnGuardarRepuesto
            // 
            this.btnGuardarRepuesto.Location = new System.Drawing.Point(231, 220);
            this.btnGuardarRepuesto.Name = "btnGuardarRepuesto";
            this.btnGuardarRepuesto.Size = new System.Drawing.Size(122, 41);
            this.btnGuardarRepuesto.TabIndex = 6;
            this.btnGuardarRepuesto.Text = "Guardar";
            this.btnGuardarRepuesto.UseVisualStyleBackColor = true;
            this.btnGuardarRepuesto.Click += new System.EventHandler(this.btnGuardarRepuesto_Click);
            // 
            // btnNuevoRepuesto
            // 
            this.btnNuevoRepuesto.Location = new System.Drawing.Point(67, 220);
            this.btnNuevoRepuesto.Name = "btnNuevoRepuesto";
            this.btnNuevoRepuesto.Size = new System.Drawing.Size(122, 41);
            this.btnNuevoRepuesto.TabIndex = 7;
            this.btnNuevoRepuesto.Text = "Nuevo";
            this.btnNuevoRepuesto.UseVisualStyleBackColor = true;
            this.btnNuevoRepuesto.Click += new System.EventHandler(this.btnNuevoRepuesto_Click);
            // 
            // dgvInventario
            // 
            this.dgvInventario.AutoGenerateColumns = false;
            this.dgvInventario.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvInventario.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            this.dgvInventario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInventario.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.repuestoIDDataGridViewTextBoxColumn,
            this.nombreRepuestoDataGridViewTextBoxColumn,
            this.precioDataGridViewTextBoxColumn,
            this.stockDataGridViewTextBoxColumn});
            this.dgvInventario.DataSource = this.inventarioBindingSource;
            this.dgvInventario.Location = new System.Drawing.Point(67, 290);
            this.dgvInventario.Name = "dgvInventario";
            this.dgvInventario.RowHeadersWidth = 51;
            this.dgvInventario.RowTemplate.Height = 24;
            this.dgvInventario.Size = new System.Drawing.Size(1404, 130);
            this.dgvInventario.TabIndex = 8;
            // 
            // repuestoIDDataGridViewTextBoxColumn
            // 
            this.repuestoIDDataGridViewTextBoxColumn.DataPropertyName = "RepuestoID";
            this.repuestoIDDataGridViewTextBoxColumn.HeaderText = "RepuestoID";
            this.repuestoIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.repuestoIDDataGridViewTextBoxColumn.Name = "repuestoIDDataGridViewTextBoxColumn";
            this.repuestoIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nombreRepuestoDataGridViewTextBoxColumn
            // 
            this.nombreRepuestoDataGridViewTextBoxColumn.DataPropertyName = "NombreRepuesto";
            this.nombreRepuestoDataGridViewTextBoxColumn.HeaderText = "NombreRepuesto";
            this.nombreRepuestoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nombreRepuestoDataGridViewTextBoxColumn.Name = "nombreRepuestoDataGridViewTextBoxColumn";
            // 
            // precioDataGridViewTextBoxColumn
            // 
            this.precioDataGridViewTextBoxColumn.DataPropertyName = "Precio";
            this.precioDataGridViewTextBoxColumn.HeaderText = "Precio";
            this.precioDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.precioDataGridViewTextBoxColumn.Name = "precioDataGridViewTextBoxColumn";
            // 
            // stockDataGridViewTextBoxColumn
            // 
            this.stockDataGridViewTextBoxColumn.DataPropertyName = "Stock";
            this.stockDataGridViewTextBoxColumn.HeaderText = "Stock";
            this.stockDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.stockDataGridViewTextBoxColumn.Name = "stockDataGridViewTextBoxColumn";
            // 
            // inventarioTableAdapter
            // 
            this.inventarioTableAdapter.ClearBeforeFill = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtNombreRepuesto);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtPrecioRepuesto);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtStockRepuesto);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(67, 31);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(437, 170);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos inventario";
            // 
            // frmInventario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1905, 1042);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgvInventario);
            this.Controls.Add(this.btnNuevoRepuesto);
            this.Controls.Add(this.btnGuardarRepuesto);
            this.Name = "frmInventario";
            this.Text = "frmInventario";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmInventario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.inventarioBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.carClinicBDDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInventario)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNombreRepuesto;
        private System.Windows.Forms.TextBox txtPrecioRepuesto;
        private System.Windows.Forms.TextBox txtStockRepuesto;
        private System.Windows.Forms.Button btnGuardarRepuesto;
        private System.Windows.Forms.Button btnNuevoRepuesto;
        private System.Windows.Forms.DataGridView dgvInventario;
        private CarClinicBDDataSet carClinicBDDataSet;
        private System.Windows.Forms.BindingSource inventarioBindingSource;
        private CarClinicBDDataSetTableAdapters.InventarioTableAdapter inventarioTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn repuestoIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreRepuestoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn precioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stockDataGridViewTextBoxColumn;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}