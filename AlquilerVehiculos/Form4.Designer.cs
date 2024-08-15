namespace AlquilerVehiculos
{
    partial class FormAlquileres
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
            this.dgvAlquileres = new System.Windows.Forms.DataGridView();
            this.alquilerVehiculosDBDataSet = new AlquilerVehiculos.AlquilerVehiculosDBDataSet();
            this.alquilerVehiculosDBDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.alquileresBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.alquileresTableAdapter = new AlquilerVehiculos.AlquilerVehiculosDBDataSetTableAdapters.AlquileresTableAdapter();
            this.alquileridDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vehiculoidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clienteidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechainicioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechafinDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cbClientes = new System.Windows.Forms.ComboBox();
            this.cbVehiculos = new System.Windows.Forms.ComboBox();
            this.clientesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.clientesTableAdapter = new AlquilerVehiculos.AlquilerVehiculosDBDataSetTableAdapters.ClientesTableAdapter();
            this.vehiculosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vehiculosTableAdapter = new AlquilerVehiculos.AlquilerVehiculosDBDataSetTableAdapters.VehiculosTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.dtpFechaInicio = new System.Windows.Forms.DateTimePicker();
            this.dtpFechaFin = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlquileres)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.alquilerVehiculosDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.alquilerVehiculosDBDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.alquileresBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vehiculosBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvAlquileres
            // 
            this.dgvAlquileres.AutoGenerateColumns = false;
            this.dgvAlquileres.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAlquileres.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.alquileridDataGridViewTextBoxColumn,
            this.vehiculoidDataGridViewTextBoxColumn,
            this.clienteidDataGridViewTextBoxColumn,
            this.fechainicioDataGridViewTextBoxColumn,
            this.fechafinDataGridViewTextBoxColumn});
            this.dgvAlquileres.DataSource = this.alquileresBindingSource;
            this.dgvAlquileres.Location = new System.Drawing.Point(12, 12);
            this.dgvAlquileres.Name = "dgvAlquileres";
            this.dgvAlquileres.Size = new System.Drawing.Size(545, 165);
            this.dgvAlquileres.TabIndex = 0;
            // 
            // alquilerVehiculosDBDataSet
            // 
            this.alquilerVehiculosDBDataSet.DataSetName = "AlquilerVehiculosDBDataSet";
            this.alquilerVehiculosDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // alquilerVehiculosDBDataSetBindingSource
            // 
            this.alquilerVehiculosDBDataSetBindingSource.DataSource = this.alquilerVehiculosDBDataSet;
            this.alquilerVehiculosDBDataSetBindingSource.Position = 0;
            // 
            // alquileresBindingSource
            // 
            this.alquileresBindingSource.DataMember = "Alquileres";
            this.alquileresBindingSource.DataSource = this.alquilerVehiculosDBDataSetBindingSource;
            // 
            // alquileresTableAdapter
            // 
            this.alquileresTableAdapter.ClearBeforeFill = true;
            // 
            // alquileridDataGridViewTextBoxColumn
            // 
            this.alquileridDataGridViewTextBoxColumn.DataPropertyName = "alquiler_id";
            this.alquileridDataGridViewTextBoxColumn.HeaderText = "alquiler_id";
            this.alquileridDataGridViewTextBoxColumn.Name = "alquileridDataGridViewTextBoxColumn";
            this.alquileridDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // vehiculoidDataGridViewTextBoxColumn
            // 
            this.vehiculoidDataGridViewTextBoxColumn.DataPropertyName = "vehiculo_id";
            this.vehiculoidDataGridViewTextBoxColumn.HeaderText = "vehiculo_id";
            this.vehiculoidDataGridViewTextBoxColumn.Name = "vehiculoidDataGridViewTextBoxColumn";
            // 
            // clienteidDataGridViewTextBoxColumn
            // 
            this.clienteidDataGridViewTextBoxColumn.DataPropertyName = "cliente_id";
            this.clienteidDataGridViewTextBoxColumn.HeaderText = "cliente_id";
            this.clienteidDataGridViewTextBoxColumn.Name = "clienteidDataGridViewTextBoxColumn";
            // 
            // fechainicioDataGridViewTextBoxColumn
            // 
            this.fechainicioDataGridViewTextBoxColumn.DataPropertyName = "fecha_inicio";
            this.fechainicioDataGridViewTextBoxColumn.HeaderText = "fecha_inicio";
            this.fechainicioDataGridViewTextBoxColumn.Name = "fechainicioDataGridViewTextBoxColumn";
            // 
            // fechafinDataGridViewTextBoxColumn
            // 
            this.fechafinDataGridViewTextBoxColumn.DataPropertyName = "fecha_fin";
            this.fechafinDataGridViewTextBoxColumn.HeaderText = "fecha_fin";
            this.fechafinDataGridViewTextBoxColumn.Name = "fechafinDataGridViewTextBoxColumn";
            // 
            // cbClientes
            // 
            this.cbClientes.DataSource = this.clientesBindingSource;
            this.cbClientes.DisplayMember = "nombre";
            this.cbClientes.FormattingEnabled = true;
            this.cbClientes.Location = new System.Drawing.Point(37, 183);
            this.cbClientes.Name = "cbClientes";
            this.cbClientes.Size = new System.Drawing.Size(211, 21);
            this.cbClientes.TabIndex = 1;
            this.cbClientes.ValueMember = "apellido";
            // 
            // cbVehiculos
            // 
            this.cbVehiculos.DataSource = this.vehiculosBindingSource;
            this.cbVehiculos.DisplayMember = "marca";
            this.cbVehiculos.FormattingEnabled = true;
            this.cbVehiculos.Location = new System.Drawing.Point(338, 183);
            this.cbVehiculos.Name = "cbVehiculos";
            this.cbVehiculos.Size = new System.Drawing.Size(219, 21);
            this.cbVehiculos.TabIndex = 2;
            this.cbVehiculos.ValueMember = "modelo";
            // 
            // clientesBindingSource
            // 
            this.clientesBindingSource.DataMember = "Clientes";
            this.clientesBindingSource.DataSource = this.alquilerVehiculosDBDataSetBindingSource;
            // 
            // clientesTableAdapter
            // 
            this.clientesTableAdapter.ClearBeforeFill = true;
            // 
            // vehiculosBindingSource
            // 
            this.vehiculosBindingSource.DataMember = "Vehiculos";
            this.vehiculosBindingSource.DataSource = this.alquilerVehiculosDBDataSetBindingSource;
            // 
            // vehiculosTableAdapter
            // 
            this.vehiculosTableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(511, 280);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(85, 43);
            this.button1.TabIndex = 3;
            this.button1.Text = "REGRESAR";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(49, 328);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(124, 39);
            this.button2.TabIndex = 4;
            this.button2.Text = "GUARDAR ALQUILER";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(262, 328);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(116, 39);
            this.button3.TabIndex = 5;
            this.button3.Text = "ELIMINAR ALQUILER";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // dtpFechaInicio
            // 
            this.dtpFechaInicio.Location = new System.Drawing.Point(199, 245);
            this.dtpFechaInicio.Name = "dtpFechaInicio";
            this.dtpFechaInicio.Size = new System.Drawing.Size(216, 20);
            this.dtpFechaInicio.TabIndex = 6;
            // 
            // dtpFechaFin
            // 
            this.dtpFechaFin.Location = new System.Drawing.Point(199, 289);
            this.dtpFechaFin.Name = "dtpFechaFin";
            this.dtpFechaFin.Size = new System.Drawing.Size(214, 20);
            this.dtpFechaFin.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 245);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(169, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "FECHA DE INICIO DE ALQUILER";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 293);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "FECHA FIN DE ALQUILER";
            // 
            // FormAlquileres
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(676, 427);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtpFechaFin);
            this.Controls.Add(this.dtpFechaInicio);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cbVehiculos);
            this.Controls.Add(this.cbClientes);
            this.Controls.Add(this.dgvAlquileres);
            this.Name = "FormAlquileres";
            this.Text = "Form4";
            this.Load += new System.EventHandler(this.Form4_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlquileres)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.alquilerVehiculosDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.alquilerVehiculosDBDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.alquileresBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vehiculosBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvAlquileres;
        private System.Windows.Forms.BindingSource alquilerVehiculosDBDataSetBindingSource;
        private AlquilerVehiculosDBDataSet alquilerVehiculosDBDataSet;
        private System.Windows.Forms.BindingSource alquileresBindingSource;
        private AlquilerVehiculosDBDataSetTableAdapters.AlquileresTableAdapter alquileresTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn alquileridDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vehiculoidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn clienteidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechainicioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechafinDataGridViewTextBoxColumn;
        private System.Windows.Forms.ComboBox cbClientes;
        private System.Windows.Forms.ComboBox cbVehiculos;
        private System.Windows.Forms.BindingSource clientesBindingSource;
        private AlquilerVehiculosDBDataSetTableAdapters.ClientesTableAdapter clientesTableAdapter;
        private System.Windows.Forms.BindingSource vehiculosBindingSource;
        private AlquilerVehiculosDBDataSetTableAdapters.VehiculosTableAdapter vehiculosTableAdapter;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DateTimePicker dtpFechaInicio;
        private System.Windows.Forms.DateTimePicker dtpFechaFin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}