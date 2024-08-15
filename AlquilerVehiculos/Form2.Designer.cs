namespace AlquilerVehiculos
{
    partial class FormVehiculos
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
            this.dgvVehiculos = new System.Windows.Forms.DataGridView();
            this.vehiculoidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.marcaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.modeloDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.añoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.disponibleDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.vehiculosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.alquilerVehiculosDBDataSet = new AlquilerVehiculos.AlquilerVehiculosDBDataSet();
            this.label3 = new System.Windows.Forms.Label();
            this.btnEliminarVehiculo = new System.Windows.Forms.Button();
            this.vehiculosTableAdapter = new AlquilerVehiculos.AlquilerVehiculosDBDataSetTableAdapters.VehiculosTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVehiculos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vehiculosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.alquilerVehiculosDBDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvVehiculos
            // 
            this.dgvVehiculos.AutoGenerateColumns = false;
            this.dgvVehiculos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVehiculos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.vehiculoidDataGridViewTextBoxColumn,
            this.marcaDataGridViewTextBoxColumn,
            this.modeloDataGridViewTextBoxColumn,
            this.añoDataGridViewTextBoxColumn,
            this.disponibleDataGridViewCheckBoxColumn});
            this.dgvVehiculos.DataSource = this.vehiculosBindingSource;
            this.dgvVehiculos.Location = new System.Drawing.Point(70, 82);
            this.dgvVehiculos.Name = "dgvVehiculos";
            this.dgvVehiculos.Size = new System.Drawing.Size(242, 178);
            this.dgvVehiculos.TabIndex = 24;
            // 
            // vehiculoidDataGridViewTextBoxColumn
            // 
            this.vehiculoidDataGridViewTextBoxColumn.DataPropertyName = "vehiculo_id";
            this.vehiculoidDataGridViewTextBoxColumn.HeaderText = "vehiculo_id";
            this.vehiculoidDataGridViewTextBoxColumn.Name = "vehiculoidDataGridViewTextBoxColumn";
            this.vehiculoidDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // marcaDataGridViewTextBoxColumn
            // 
            this.marcaDataGridViewTextBoxColumn.DataPropertyName = "marca";
            this.marcaDataGridViewTextBoxColumn.HeaderText = "marca";
            this.marcaDataGridViewTextBoxColumn.Name = "marcaDataGridViewTextBoxColumn";
            // 
            // modeloDataGridViewTextBoxColumn
            // 
            this.modeloDataGridViewTextBoxColumn.DataPropertyName = "modelo";
            this.modeloDataGridViewTextBoxColumn.HeaderText = "modelo";
            this.modeloDataGridViewTextBoxColumn.Name = "modeloDataGridViewTextBoxColumn";
            // 
            // añoDataGridViewTextBoxColumn
            // 
            this.añoDataGridViewTextBoxColumn.DataPropertyName = "año";
            this.añoDataGridViewTextBoxColumn.HeaderText = "año";
            this.añoDataGridViewTextBoxColumn.Name = "añoDataGridViewTextBoxColumn";
            // 
            // disponibleDataGridViewCheckBoxColumn
            // 
            this.disponibleDataGridViewCheckBoxColumn.DataPropertyName = "disponible";
            this.disponibleDataGridViewCheckBoxColumn.HeaderText = "disponible";
            this.disponibleDataGridViewCheckBoxColumn.Name = "disponibleDataGridViewCheckBoxColumn";
            // 
            // vehiculosBindingSource
            // 
            this.vehiculosBindingSource.DataMember = "Vehiculos";
            this.vehiculosBindingSource.DataSource = this.alquilerVehiculosDBDataSet;
            // 
            // alquilerVehiculosDBDataSet
            // 
            this.alquilerVehiculosDBDataSet.DataSetName = "AlquilerVehiculosDBDataSet";
            this.alquilerVehiculosDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(117, 37);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 13);
            this.label3.TabIndex = 26;
            this.label3.Text = "DATOS DE VEHICULOS";
            // 
            // btnEliminarVehiculo
            // 
            this.btnEliminarVehiculo.Location = new System.Drawing.Point(70, 299);
            this.btnEliminarVehiculo.Name = "btnEliminarVehiculo";
            this.btnEliminarVehiculo.Size = new System.Drawing.Size(99, 37);
            this.btnEliminarVehiculo.TabIndex = 28;
            this.btnEliminarVehiculo.Text = "ELIMINAR VEHICULO";
            this.btnEliminarVehiculo.UseVisualStyleBackColor = true;
            this.btnEliminarVehiculo.Click += new System.EventHandler(this.btnEliminarVehiculo_Click_1);
            // 
            // vehiculosTableAdapter
            // 
            this.vehiculosTableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(348, 298);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(93, 37);
            this.button1.TabIndex = 29;
            this.button1.Text = "REGRESAR";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FormVehiculos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(534, 357);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnEliminarVehiculo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dgvVehiculos);
            this.Name = "FormVehiculos";
            this.Text = "VEHICULOS";
            this.Load += new System.EventHandler(this.FormVehiculos_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.dgvVehiculos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vehiculosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.alquilerVehiculosDBDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvVehiculos;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnEliminarVehiculo;
        private AlquilerVehiculosDBDataSet alquilerVehiculosDBDataSet;
        private System.Windows.Forms.BindingSource vehiculosBindingSource;
        private AlquilerVehiculosDBDataSetTableAdapters.VehiculosTableAdapter vehiculosTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn vehiculoidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn marcaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn modeloDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn añoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn disponibleDataGridViewCheckBoxColumn;
        private System.Windows.Forms.Button button1;
    }
}