namespace ProyectoU
{
    partial class frmOrdenes
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
            this.cmbClienteOrden = new System.Windows.Forms.ComboBox();
            this.clientesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.carClinicBDDataSet = new ProyectoU.CarClinicBDDataSet();
            this.cmbVehiculoOrden = new System.Windows.Forms.ComboBox();
            this.vehiculosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.dtpFechaOrden = new System.Windows.Forms.DateTimePicker();
            this.ordenesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label4 = new System.Windows.Forms.Label();
            this.txtDescripcionProblema = new System.Windows.Forms.TextBox();
            this.btnCrearOrden = new System.Windows.Forms.Button();
            this.dgvOrdenes = new System.Windows.Forms.DataGridView();
            this.ordenIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripcionProblemaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estadoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vehiculoIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clientesTableAdapter = new ProyectoU.CarClinicBDDataSetTableAdapters.ClientesTableAdapter();
            this.vehiculosTableAdapter = new ProyectoU.CarClinicBDDataSetTableAdapters.VehiculosTableAdapter();
            this.ordenesTableAdapter = new ProyectoU.CarClinicBDDataSetTableAdapters.OrdenesTableAdapter();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnAgregarRepuesto = new System.Windows.Forms.Button();
            this.numCantidad = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbRepuestos = new System.Windows.Forms.ComboBox();
            this.inventarioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label5 = new System.Windows.Forms.Label();
            this.dgvDetalles = new System.Windows.Forms.DataGridView();
            this.detalleIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ordenIDDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.repuestoIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantidadUsadaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precioUnitarioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.detalleOrdenBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.inventarioTableAdapter = new ProyectoU.CarClinicBDDataSetTableAdapters.InventarioTableAdapter();
            this.detalleOrdenTableAdapter = new ProyectoU.CarClinicBDDataSetTableAdapters.DetalleOrdenTableAdapter();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.clientesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.carClinicBDDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vehiculosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordenesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrdenes)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numCantidad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventarioBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalles)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.detalleOrdenBindingSource)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cliente:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Vehículo:";
            // 
            // cmbClienteOrden
            // 
            this.cmbClienteOrden.DataSource = this.clientesBindingSource;
            this.cmbClienteOrden.DisplayMember = "Nombre";
            this.cmbClienteOrden.FormattingEnabled = true;
            this.cmbClienteOrden.Location = new System.Drawing.Point(86, 34);
            this.cmbClienteOrden.Name = "cmbClienteOrden";
            this.cmbClienteOrden.Size = new System.Drawing.Size(255, 24);
            this.cmbClienteOrden.TabIndex = 2;
            this.cmbClienteOrden.ValueMember = "ClienteID";
            this.cmbClienteOrden.SelectedIndexChanged += new System.EventHandler(this.cmbClienteOrden_SelectedIndexChanged);
            // 
            // clientesBindingSource
            // 
            this.clientesBindingSource.DataMember = "Clientes";
            this.clientesBindingSource.DataSource = this.carClinicBDDataSet;
            // 
            // carClinicBDDataSet
            // 
            this.carClinicBDDataSet.DataSetName = "CarClinicBDDataSet";
            this.carClinicBDDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cmbVehiculoOrden
            // 
            this.cmbVehiculoOrden.DataSource = this.vehiculosBindingSource;
            this.cmbVehiculoOrden.DisplayMember = "Placa";
            this.cmbVehiculoOrden.FormattingEnabled = true;
            this.cmbVehiculoOrden.Location = new System.Drawing.Point(86, 78);
            this.cmbVehiculoOrden.Name = "cmbVehiculoOrden";
            this.cmbVehiculoOrden.Size = new System.Drawing.Size(255, 24);
            this.cmbVehiculoOrden.TabIndex = 3;
            this.cmbVehiculoOrden.ValueMember = "VehiculoID";
            // 
            // vehiculosBindingSource
            // 
            this.vehiculosBindingSource.DataMember = "Vehiculos";
            this.vehiculosBindingSource.DataSource = this.carClinicBDDataSet;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 132);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Fecha:";
            // 
            // dtpFechaOrden
            // 
            this.dtpFechaOrden.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.ordenesBindingSource, "Fecha", true));
            this.dtpFechaOrden.Location = new System.Drawing.Point(86, 127);
            this.dtpFechaOrden.Name = "dtpFechaOrden";
            this.dtpFechaOrden.Size = new System.Drawing.Size(255, 22);
            this.dtpFechaOrden.TabIndex = 5;
            // 
            // ordenesBindingSource
            // 
            this.ordenesBindingSource.DataMember = "Ordenes";
            this.ordenesBindingSource.DataSource = this.carClinicBDDataSet;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(377, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(144, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "Descripción Problema:";
            // 
            // txtDescripcionProblema
            // 
            this.txtDescripcionProblema.Location = new System.Drawing.Point(380, 40);
            this.txtDescripcionProblema.Multiline = true;
            this.txtDescripcionProblema.Name = "txtDescripcionProblema";
            this.txtDescripcionProblema.Size = new System.Drawing.Size(421, 108);
            this.txtDescripcionProblema.TabIndex = 7;
            // 
            // btnCrearOrden
            // 
            this.btnCrearOrden.Location = new System.Drawing.Point(928, 84);
            this.btnCrearOrden.Name = "btnCrearOrden";
            this.btnCrearOrden.Size = new System.Drawing.Size(132, 43);
            this.btnCrearOrden.TabIndex = 8;
            this.btnCrearOrden.Text = "Crear Orden";
            this.btnCrearOrden.UseVisualStyleBackColor = true;
            this.btnCrearOrden.Click += new System.EventHandler(this.btnCrearOrden_Click);
            // 
            // dgvOrdenes
            // 
            this.dgvOrdenes.AutoGenerateColumns = false;
            this.dgvOrdenes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvOrdenes.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            this.dgvOrdenes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOrdenes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ordenIDDataGridViewTextBoxColumn,
            this.fechaDataGridViewTextBoxColumn,
            this.descripcionProblemaDataGridViewTextBoxColumn,
            this.estadoDataGridViewTextBoxColumn,
            this.vehiculoIDDataGridViewTextBoxColumn});
            this.dgvOrdenes.DataSource = this.ordenesBindingSource;
            this.dgvOrdenes.Location = new System.Drawing.Point(70, 219);
            this.dgvOrdenes.Name = "dgvOrdenes";
            this.dgvOrdenes.RowHeadersWidth = 51;
            this.dgvOrdenes.RowTemplate.Height = 24;
            this.dgvOrdenes.Size = new System.Drawing.Size(1368, 157);
            this.dgvOrdenes.TabIndex = 9;
            this.dgvOrdenes.SelectionChanged += new System.EventHandler(this.dgvOrdenes_SelectionChanged);
            // 
            // ordenIDDataGridViewTextBoxColumn
            // 
            this.ordenIDDataGridViewTextBoxColumn.DataPropertyName = "OrdenID";
            this.ordenIDDataGridViewTextBoxColumn.HeaderText = "OrdenID";
            this.ordenIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ordenIDDataGridViewTextBoxColumn.Name = "ordenIDDataGridViewTextBoxColumn";
            this.ordenIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fechaDataGridViewTextBoxColumn
            // 
            this.fechaDataGridViewTextBoxColumn.DataPropertyName = "Fecha";
            this.fechaDataGridViewTextBoxColumn.HeaderText = "Fecha";
            this.fechaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.fechaDataGridViewTextBoxColumn.Name = "fechaDataGridViewTextBoxColumn";
            // 
            // descripcionProblemaDataGridViewTextBoxColumn
            // 
            this.descripcionProblemaDataGridViewTextBoxColumn.DataPropertyName = "DescripcionProblema";
            this.descripcionProblemaDataGridViewTextBoxColumn.HeaderText = "DescripcionProblema";
            this.descripcionProblemaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.descripcionProblemaDataGridViewTextBoxColumn.Name = "descripcionProblemaDataGridViewTextBoxColumn";
            // 
            // estadoDataGridViewTextBoxColumn
            // 
            this.estadoDataGridViewTextBoxColumn.DataPropertyName = "Estado";
            this.estadoDataGridViewTextBoxColumn.HeaderText = "Estado";
            this.estadoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.estadoDataGridViewTextBoxColumn.Name = "estadoDataGridViewTextBoxColumn";
            // 
            // vehiculoIDDataGridViewTextBoxColumn
            // 
            this.vehiculoIDDataGridViewTextBoxColumn.DataPropertyName = "VehiculoID";
            this.vehiculoIDDataGridViewTextBoxColumn.HeaderText = "VehiculoID";
            this.vehiculoIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.vehiculoIDDataGridViewTextBoxColumn.Name = "vehiculoIDDataGridViewTextBoxColumn";
            // 
            // clientesTableAdapter
            // 
            this.clientesTableAdapter.ClearBeforeFill = true;
            // 
            // vehiculosTableAdapter
            // 
            this.vehiculosTableAdapter.ClearBeforeFill = true;
            // 
            // ordenesTableAdapter
            // 
            this.ordenesTableAdapter.ClearBeforeFill = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.numCantidad);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.cmbRepuestos);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Location = new System.Drawing.Point(70, 405);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(378, 139);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Detalle de la orden";
            // 
            // btnAgregarRepuesto
            // 
            this.btnAgregarRepuesto.Location = new System.Drawing.Point(476, 447);
            this.btnAgregarRepuesto.Name = "btnAgregarRepuesto";
            this.btnAgregarRepuesto.Size = new System.Drawing.Size(158, 44);
            this.btnAgregarRepuesto.TabIndex = 4;
            this.btnAgregarRepuesto.Text = "Agregar Repuesto";
            this.btnAgregarRepuesto.UseVisualStyleBackColor = true;
            this.btnAgregarRepuesto.Click += new System.EventHandler(this.btnAgregarRepuesto_Click);
            // 
            // numCantidad
            // 
            this.numCantidad.Location = new System.Drawing.Point(107, 89);
            this.numCantidad.Name = "numCantidad";
            this.numCantidad.Size = new System.Drawing.Size(215, 22);
            this.numCantidad.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 91);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 16);
            this.label6.TabIndex = 2;
            this.label6.Text = "Cantidad:";
            // 
            // cmbRepuestos
            // 
            this.cmbRepuestos.DataSource = this.inventarioBindingSource;
            this.cmbRepuestos.DisplayMember = "NombreRepuesto";
            this.cmbRepuestos.FormattingEnabled = true;
            this.cmbRepuestos.Location = new System.Drawing.Point(107, 38);
            this.cmbRepuestos.Name = "cmbRepuestos";
            this.cmbRepuestos.Size = new System.Drawing.Size(215, 24);
            this.cmbRepuestos.TabIndex = 1;
            this.cmbRepuestos.ValueMember = "RepuestoID";
            // 
            // inventarioBindingSource
            // 
            this.inventarioBindingSource.DataMember = "Inventario";
            this.inventarioBindingSource.DataSource = this.carClinicBDDataSet;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 42);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 16);
            this.label5.TabIndex = 0;
            this.label5.Text = "Repuesto:";
            // 
            // dgvDetalles
            // 
            this.dgvDetalles.AutoGenerateColumns = false;
            this.dgvDetalles.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDetalles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDetalles.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.detalleIDDataGridViewTextBoxColumn,
            this.ordenIDDataGridViewTextBoxColumn1,
            this.repuestoIDDataGridViewTextBoxColumn,
            this.cantidadUsadaDataGridViewTextBoxColumn,
            this.precioUnitarioDataGridViewTextBoxColumn});
            this.dgvDetalles.DataSource = this.detalleOrdenBindingSource;
            this.dgvDetalles.Location = new System.Drawing.Point(70, 582);
            this.dgvDetalles.Name = "dgvDetalles";
            this.dgvDetalles.RowHeadersWidth = 51;
            this.dgvDetalles.RowTemplate.Height = 24;
            this.dgvDetalles.Size = new System.Drawing.Size(1368, 162);
            this.dgvDetalles.TabIndex = 11;
            // 
            // detalleIDDataGridViewTextBoxColumn
            // 
            this.detalleIDDataGridViewTextBoxColumn.DataPropertyName = "DetalleID";
            this.detalleIDDataGridViewTextBoxColumn.HeaderText = "DetalleID";
            this.detalleIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.detalleIDDataGridViewTextBoxColumn.Name = "detalleIDDataGridViewTextBoxColumn";
            this.detalleIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ordenIDDataGridViewTextBoxColumn1
            // 
            this.ordenIDDataGridViewTextBoxColumn1.DataPropertyName = "OrdenID";
            this.ordenIDDataGridViewTextBoxColumn1.HeaderText = "OrdenID";
            this.ordenIDDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.ordenIDDataGridViewTextBoxColumn1.Name = "ordenIDDataGridViewTextBoxColumn1";
            // 
            // repuestoIDDataGridViewTextBoxColumn
            // 
            this.repuestoIDDataGridViewTextBoxColumn.DataPropertyName = "RepuestoID";
            this.repuestoIDDataGridViewTextBoxColumn.HeaderText = "RepuestoID";
            this.repuestoIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.repuestoIDDataGridViewTextBoxColumn.Name = "repuestoIDDataGridViewTextBoxColumn";
            // 
            // cantidadUsadaDataGridViewTextBoxColumn
            // 
            this.cantidadUsadaDataGridViewTextBoxColumn.DataPropertyName = "CantidadUsada";
            this.cantidadUsadaDataGridViewTextBoxColumn.HeaderText = "CantidadUsada";
            this.cantidadUsadaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.cantidadUsadaDataGridViewTextBoxColumn.Name = "cantidadUsadaDataGridViewTextBoxColumn";
            // 
            // precioUnitarioDataGridViewTextBoxColumn
            // 
            this.precioUnitarioDataGridViewTextBoxColumn.DataPropertyName = "PrecioUnitario";
            this.precioUnitarioDataGridViewTextBoxColumn.HeaderText = "PrecioUnitario";
            this.precioUnitarioDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.precioUnitarioDataGridViewTextBoxColumn.Name = "precioUnitarioDataGridViewTextBoxColumn";
            // 
            // detalleOrdenBindingSource
            // 
            this.detalleOrdenBindingSource.DataMember = "DetalleOrden";
            this.detalleOrdenBindingSource.DataSource = this.carClinicBDDataSet;
            // 
            // inventarioTableAdapter
            // 
            this.inventarioTableAdapter.ClearBeforeFill = true;
            // 
            // detalleOrdenTableAdapter
            // 
            this.detalleOrdenTableAdapter.ClearBeforeFill = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cmbClienteOrden);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.cmbVehiculoOrden);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.dtpFechaOrden);
            this.groupBox2.Controls.Add(this.txtDescripcionProblema);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(70, 25);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(822, 171);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Detalles del vehiculo";
            // 
            // frmOrdenes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1505, 818);
            this.Controls.Add(this.btnAgregarRepuesto);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.dgvDetalles);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgvOrdenes);
            this.Controls.Add(this.btnCrearOrden);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmOrdenes";
            this.Text = "frmOrdenes";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmOrdenes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.clientesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.carClinicBDDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vehiculosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordenesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrdenes)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numCantidad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventarioBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalles)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.detalleOrdenBindingSource)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbClienteOrden;
        private System.Windows.Forms.ComboBox cmbVehiculoOrden;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtpFechaOrden;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtDescripcionProblema;
        private System.Windows.Forms.Button btnCrearOrden;
        private System.Windows.Forms.DataGridView dgvOrdenes;
        private CarClinicBDDataSet carClinicBDDataSet;
        private System.Windows.Forms.BindingSource clientesBindingSource;
        private CarClinicBDDataSetTableAdapters.ClientesTableAdapter clientesTableAdapter;
        private System.Windows.Forms.BindingSource vehiculosBindingSource;
        private CarClinicBDDataSetTableAdapters.VehiculosTableAdapter vehiculosTableAdapter;
        private System.Windows.Forms.BindingSource ordenesBindingSource;
        private CarClinicBDDataSetTableAdapters.OrdenesTableAdapter ordenesTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn ordenIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcionProblemaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn estadoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vehiculoIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbRepuestos;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnAgregarRepuesto;
        private System.Windows.Forms.NumericUpDown numCantidad;
        private System.Windows.Forms.DataGridView dgvDetalles;
        private System.Windows.Forms.BindingSource inventarioBindingSource;
        private CarClinicBDDataSetTableAdapters.InventarioTableAdapter inventarioTableAdapter;
        private System.Windows.Forms.BindingSource detalleOrdenBindingSource;
        private CarClinicBDDataSetTableAdapters.DetalleOrdenTableAdapter detalleOrdenTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn detalleIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ordenIDDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn repuestoIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantidadUsadaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn precioUnitarioDataGridViewTextBoxColumn;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}