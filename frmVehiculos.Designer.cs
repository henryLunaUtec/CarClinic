namespace ProyectoU
{
    partial class frmVehiculos
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
            this.cmbClientes = new System.Windows.Forms.ComboBox();
            this.clientesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.carClinicBDDataSet = new ProyectoU.CarClinicBDDataSet();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtPlaca = new System.Windows.Forms.TextBox();
            this.vehiculosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.txtMarca = new System.Windows.Forms.TextBox();
            this.txtModelo = new System.Windows.Forms.TextBox();
            this.txtAno = new System.Windows.Forms.TextBox();
            this.btnGuardarVehiculo = new System.Windows.Forms.Button();
            this.dgvVehiculos = new System.Windows.Forms.DataGridView();
            this.vehiculoIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.placaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mArcaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.modeloDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.anoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clienteIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clientesTableAdapter = new ProyectoU.CarClinicBDDataSetTableAdapters.ClientesTableAdapter();
            this.vehiculosTableAdapter = new ProyectoU.CarClinicBDDataSetTableAdapters.VehiculosTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.clientesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.carClinicBDDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vehiculosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVehiculos)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(70, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cliente:";
            // 
            // cmbClientes
            // 
            this.cmbClientes.DataSource = this.clientesBindingSource;
            this.cmbClientes.DisplayMember = "Nombre";
            this.cmbClientes.FormattingEnabled = true;
            this.cmbClientes.Location = new System.Drawing.Point(140, 37);
            this.cmbClientes.Name = "cmbClientes";
            this.cmbClientes.Size = new System.Drawing.Size(121, 24);
            this.cmbClientes.TabIndex = 1;
            this.cmbClientes.ValueMember = "ClienteID";
            this.cmbClientes.SelectedIndexChanged += new System.EventHandler(this.cmbClientes_SelectedIndexChanged);
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(70, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Placa:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(70, 161);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Marca:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(70, 214);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 16);
            this.label4.TabIndex = 4;
            this.label4.Text = "Modelo:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(70, 261);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 16);
            this.label5.TabIndex = 5;
            this.label5.Text = "Año:";
            // 
            // txtPlaca
            // 
            this.txtPlaca.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vehiculosBindingSource, "Placa", true));
            this.txtPlaca.Location = new System.Drawing.Point(140, 102);
            this.txtPlaca.Name = "txtPlaca";
            this.txtPlaca.Size = new System.Drawing.Size(121, 22);
            this.txtPlaca.TabIndex = 6;
            // 
            // vehiculosBindingSource
            // 
            this.vehiculosBindingSource.DataMember = "Vehiculos";
            this.vehiculosBindingSource.DataSource = this.carClinicBDDataSet;
            // 
            // txtMarca
            // 
            this.txtMarca.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vehiculosBindingSource, "MArca", true));
            this.txtMarca.Location = new System.Drawing.Point(140, 161);
            this.txtMarca.Name = "txtMarca";
            this.txtMarca.Size = new System.Drawing.Size(121, 22);
            this.txtMarca.TabIndex = 7;
            // 
            // txtModelo
            // 
            this.txtModelo.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vehiculosBindingSource, "Modelo", true));
            this.txtModelo.Location = new System.Drawing.Point(140, 214);
            this.txtModelo.Name = "txtModelo";
            this.txtModelo.Size = new System.Drawing.Size(121, 22);
            this.txtModelo.TabIndex = 8;
            // 
            // txtAno
            // 
            this.txtAno.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vehiculosBindingSource, "Ano", true));
            this.txtAno.Location = new System.Drawing.Point(140, 258);
            this.txtAno.Name = "txtAno";
            this.txtAno.Size = new System.Drawing.Size(121, 22);
            this.txtAno.TabIndex = 9;
            // 
            // btnGuardarVehiculo
            // 
            this.btnGuardarVehiculo.Location = new System.Drawing.Point(320, 37);
            this.btnGuardarVehiculo.Name = "btnGuardarVehiculo";
            this.btnGuardarVehiculo.Size = new System.Drawing.Size(157, 47);
            this.btnGuardarVehiculo.TabIndex = 10;
            this.btnGuardarVehiculo.Text = "Guardar Vehículo";
            this.btnGuardarVehiculo.UseVisualStyleBackColor = true;
            this.btnGuardarVehiculo.Click += new System.EventHandler(this.btnGuardarVehiculo_Click);
            // 
            // dgvVehiculos
            // 
            this.dgvVehiculos.AutoGenerateColumns = false;
            this.dgvVehiculos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVehiculos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.vehiculoIDDataGridViewTextBoxColumn,
            this.placaDataGridViewTextBoxColumn,
            this.mArcaDataGridViewTextBoxColumn,
            this.modeloDataGridViewTextBoxColumn,
            this.anoDataGridViewTextBoxColumn,
            this.clienteIDDataGridViewTextBoxColumn});
            this.dgvVehiculos.DataSource = this.vehiculosBindingSource;
            this.dgvVehiculos.Location = new System.Drawing.Point(73, 307);
            this.dgvVehiculos.Name = "dgvVehiculos";
            this.dgvVehiculos.RowHeadersWidth = 51;
            this.dgvVehiculos.RowTemplate.Height = 24;
            this.dgvVehiculos.Size = new System.Drawing.Size(798, 119);
            this.dgvVehiculos.TabIndex = 11;
            // 
            // vehiculoIDDataGridViewTextBoxColumn
            // 
            this.vehiculoIDDataGridViewTextBoxColumn.DataPropertyName = "VehiculoID";
            this.vehiculoIDDataGridViewTextBoxColumn.HeaderText = "VehiculoID";
            this.vehiculoIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.vehiculoIDDataGridViewTextBoxColumn.Name = "vehiculoIDDataGridViewTextBoxColumn";
            this.vehiculoIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.vehiculoIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // placaDataGridViewTextBoxColumn
            // 
            this.placaDataGridViewTextBoxColumn.DataPropertyName = "Placa";
            this.placaDataGridViewTextBoxColumn.HeaderText = "Placa";
            this.placaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.placaDataGridViewTextBoxColumn.Name = "placaDataGridViewTextBoxColumn";
            this.placaDataGridViewTextBoxColumn.Width = 125;
            // 
            // mArcaDataGridViewTextBoxColumn
            // 
            this.mArcaDataGridViewTextBoxColumn.DataPropertyName = "MArca";
            this.mArcaDataGridViewTextBoxColumn.HeaderText = "MArca";
            this.mArcaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.mArcaDataGridViewTextBoxColumn.Name = "mArcaDataGridViewTextBoxColumn";
            this.mArcaDataGridViewTextBoxColumn.Width = 125;
            // 
            // modeloDataGridViewTextBoxColumn
            // 
            this.modeloDataGridViewTextBoxColumn.DataPropertyName = "Modelo";
            this.modeloDataGridViewTextBoxColumn.HeaderText = "Modelo";
            this.modeloDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.modeloDataGridViewTextBoxColumn.Name = "modeloDataGridViewTextBoxColumn";
            this.modeloDataGridViewTextBoxColumn.Width = 125;
            // 
            // anoDataGridViewTextBoxColumn
            // 
            this.anoDataGridViewTextBoxColumn.DataPropertyName = "Ano";
            this.anoDataGridViewTextBoxColumn.HeaderText = "Ano";
            this.anoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.anoDataGridViewTextBoxColumn.Name = "anoDataGridViewTextBoxColumn";
            this.anoDataGridViewTextBoxColumn.Width = 125;
            // 
            // clienteIDDataGridViewTextBoxColumn
            // 
            this.clienteIDDataGridViewTextBoxColumn.DataPropertyName = "ClienteID";
            this.clienteIDDataGridViewTextBoxColumn.HeaderText = "ClienteID";
            this.clienteIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.clienteIDDataGridViewTextBoxColumn.Name = "clienteIDDataGridViewTextBoxColumn";
            this.clienteIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // clientesTableAdapter
            // 
            this.clientesTableAdapter.ClearBeforeFill = true;
            // 
            // vehiculosTableAdapter
            // 
            this.vehiculosTableAdapter.ClearBeforeFill = true;
            // 
            // frmVehiculos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(937, 450);
            this.Controls.Add(this.dgvVehiculos);
            this.Controls.Add(this.btnGuardarVehiculo);
            this.Controls.Add(this.txtAno);
            this.Controls.Add(this.txtModelo);
            this.Controls.Add(this.txtMarca);
            this.Controls.Add(this.txtPlaca);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbClientes);
            this.Controls.Add(this.label1);
            this.Name = "frmVehiculos";
            this.Text = "frmVehiculos";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmVehiculos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.clientesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.carClinicBDDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vehiculosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVehiculos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbClientes;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtPlaca;
        private System.Windows.Forms.TextBox txtMarca;
        private System.Windows.Forms.TextBox txtModelo;
        private System.Windows.Forms.TextBox txtAno;
        private System.Windows.Forms.Button btnGuardarVehiculo;
        private System.Windows.Forms.DataGridView dgvVehiculos;
        private CarClinicBDDataSet carClinicBDDataSet;
        private System.Windows.Forms.BindingSource clientesBindingSource;
        private CarClinicBDDataSetTableAdapters.ClientesTableAdapter clientesTableAdapter;
        private System.Windows.Forms.BindingSource vehiculosBindingSource;
        private CarClinicBDDataSetTableAdapters.VehiculosTableAdapter vehiculosTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn vehiculoIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn placaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mArcaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn modeloDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn anoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn clienteIDDataGridViewTextBoxColumn;
    }
}