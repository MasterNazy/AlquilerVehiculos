namespace AlquilerVehiculos
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.txtMarca = new System.Windows.Forms.TextBox();
            this.txtModelo = new System.Windows.Forms.TextBox();
            this.txtAño = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.txtLicencia = new System.Windows.Forms.TextBox();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblMarca = new System.Windows.Forms.Label();
            this.lblModelo = new System.Windows.Forms.Label();
            this.lblAño = new System.Windows.Forms.Label();
            this.lblDisponible = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblApellido = new System.Windows.Forms.Label();
            this.lblLicencia = new System.Windows.Forms.Label();
            this.lblTelefono = new System.Windows.Forms.Label();
            this.chkDisponible = new System.Windows.Forms.CheckBox();
            this.btnGuardarCliente = new System.Windows.Forms.Button();
            this.btnGuardarVehiculo = new System.Windows.Forms.Button();
            this.Salir = new System.Windows.Forms.Button();
            this.alquilerVehiculosDBDataSet = new AlquilerVehiculos.AlquilerVehiculosDBDataSet();
            this.vehiculosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vehiculosTableAdapter = new AlquilerVehiculos.AlquilerVehiculosDBDataSetTableAdapters.VehiculosTableAdapter();
            this.btnAbrirVehiculos = new System.Windows.Forms.Button();
            this.btnAbrirClientes = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.alquilerVehiculosDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vehiculosBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // txtMarca
            // 
            this.txtMarca.Location = new System.Drawing.Point(149, 67);
            this.txtMarca.Name = "txtMarca";
            this.txtMarca.Size = new System.Drawing.Size(80, 20);
            this.txtMarca.TabIndex = 0;
            // 
            // txtModelo
            // 
            this.txtModelo.Location = new System.Drawing.Point(152, 115);
            this.txtModelo.Name = "txtModelo";
            this.txtModelo.Size = new System.Drawing.Size(76, 20);
            this.txtModelo.TabIndex = 1;
            // 
            // txtAño
            // 
            this.txtAño.Location = new System.Drawing.Point(153, 167);
            this.txtAño.Name = "txtAño";
            this.txtAño.Size = new System.Drawing.Size(75, 20);
            this.txtAño.TabIndex = 2;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(440, 64);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(76, 20);
            this.txtNombre.TabIndex = 3;
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(445, 109);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(70, 20);
            this.txtApellido.TabIndex = 4;
            // 
            // txtLicencia
            // 
            this.txtLicencia.Location = new System.Drawing.Point(444, 167);
            this.txtLicencia.Name = "txtLicencia";
            this.txtLicencia.Size = new System.Drawing.Size(71, 20);
            this.txtLicencia.TabIndex = 5;
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(436, 226);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(79, 20);
            this.txtTelefono.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(101, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "VEHÍCULOS";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(391, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "CLIENTES";
            // 
            // lblMarca
            // 
            this.lblMarca.AutoSize = true;
            this.lblMarca.Location = new System.Drawing.Point(64, 70);
            this.lblMarca.Name = "lblMarca";
            this.lblMarca.Size = new System.Drawing.Size(45, 13);
            this.lblMarca.TabIndex = 9;
            this.lblMarca.Text = "MARCA";
            // 
            // lblModelo
            // 
            this.lblModelo.AutoSize = true;
            this.lblModelo.Location = new System.Drawing.Point(62, 120);
            this.lblModelo.Name = "lblModelo";
            this.lblModelo.Size = new System.Drawing.Size(53, 13);
            this.lblModelo.TabIndex = 10;
            this.lblModelo.Text = "MODELO";
            // 
            // lblAño
            // 
            this.lblAño.AutoSize = true;
            this.lblAño.Location = new System.Drawing.Point(62, 173);
            this.lblAño.Name = "lblAño";
            this.lblAño.Size = new System.Drawing.Size(30, 13);
            this.lblAño.TabIndex = 11;
            this.lblAño.Text = "AÑO";
            // 
            // lblDisponible
            // 
            this.lblDisponible.AutoSize = true;
            this.lblDisponible.Location = new System.Drawing.Point(62, 233);
            this.lblDisponible.Name = "lblDisponible";
            this.lblDisponible.Size = new System.Drawing.Size(71, 13);
            this.lblDisponible.TabIndex = 12;
            this.lblDisponible.Text = "DISPONIBLE";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(357, 69);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(54, 13);
            this.lblNombre.TabIndex = 13;
            this.lblNombre.Text = "NOMBRE";
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Location = new System.Drawing.Point(355, 112);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(59, 13);
            this.lblApellido.TabIndex = 14;
            this.lblApellido.Text = "APELLIDO";
            // 
            // lblLicencia
            // 
            this.lblLicencia.AutoSize = true;
            this.lblLicencia.Location = new System.Drawing.Point(353, 164);
            this.lblLicencia.Name = "lblLicencia";
            this.lblLicencia.Size = new System.Drawing.Size(55, 13);
            this.lblLicencia.TabIndex = 15;
            this.lblLicencia.Text = "LICENCIA";
            // 
            // lblTelefono
            // 
            this.lblTelefono.AutoSize = true;
            this.lblTelefono.Location = new System.Drawing.Point(349, 224);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Size = new System.Drawing.Size(64, 13);
            this.lblTelefono.TabIndex = 16;
            this.lblTelefono.Text = "TELEFONO";
            // 
            // chkDisponible
            // 
            this.chkDisponible.AutoSize = true;
            this.chkDisponible.Location = new System.Drawing.Point(158, 237);
            this.chkDisponible.Name = "chkDisponible";
            this.chkDisponible.Size = new System.Drawing.Size(15, 14);
            this.chkDisponible.TabIndex = 17;
            this.chkDisponible.UseVisualStyleBackColor = true;
            // 
            // btnGuardarCliente
            // 
            this.btnGuardarCliente.Location = new System.Drawing.Point(640, 134);
            this.btnGuardarCliente.Name = "btnGuardarCliente";
            this.btnGuardarCliente.Size = new System.Drawing.Size(88, 43);
            this.btnGuardarCliente.TabIndex = 18;
            this.btnGuardarCliente.Text = "GUARDAR CLIENTE";
            this.btnGuardarCliente.UseVisualStyleBackColor = true;
            this.btnGuardarCliente.Click += new System.EventHandler(this.btnGuardarCliente_Click);
            // 
            // btnGuardarVehiculo
            // 
            this.btnGuardarVehiculo.Location = new System.Drawing.Point(640, 64);
            this.btnGuardarVehiculo.Name = "btnGuardarVehiculo";
            this.btnGuardarVehiculo.Size = new System.Drawing.Size(82, 37);
            this.btnGuardarVehiculo.TabIndex = 19;
            this.btnGuardarVehiculo.Text = "GUARDAR VEHÍCULO";
            this.btnGuardarVehiculo.UseVisualStyleBackColor = true;
            this.btnGuardarVehiculo.Click += new System.EventHandler(this.btnGuardarVehiculo_Click);
            // 
            // Salir
            // 
            this.Salir.Location = new System.Drawing.Point(633, 210);
            this.Salir.Name = "Salir";
            this.Salir.Size = new System.Drawing.Size(89, 35);
            this.Salir.TabIndex = 20;
            this.Salir.Text = "Salir";
            this.Salir.UseVisualStyleBackColor = true;
            this.Salir.Click += new System.EventHandler(this.Salir_Click);
            // 
            // alquilerVehiculosDBDataSet
            // 
            this.alquilerVehiculosDBDataSet.DataSetName = "AlquilerVehiculosDBDataSet";
            this.alquilerVehiculosDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // vehiculosBindingSource
            // 
            this.vehiculosBindingSource.DataMember = "Vehiculos";
            this.vehiculosBindingSource.DataSource = this.alquilerVehiculosDBDataSet;
            // 
            // vehiculosTableAdapter
            // 
            this.vehiculosTableAdapter.ClearBeforeFill = true;
            // 
            // btnAbrirVehiculos
            // 
            this.btnAbrirVehiculos.Location = new System.Drawing.Point(103, 318);
            this.btnAbrirVehiculos.Name = "btnAbrirVehiculos";
            this.btnAbrirVehiculos.Size = new System.Drawing.Size(94, 57);
            this.btnAbrirVehiculos.TabIndex = 21;
            this.btnAbrirVehiculos.Text = "ABRIR VEHICULOS";
            this.btnAbrirVehiculos.UseVisualStyleBackColor = true;
            this.btnAbrirVehiculos.Click += new System.EventHandler(this.btnAbrirVehiculos_Click);
            // 
            // btnAbrirClientes
            // 
            this.btnAbrirClientes.Location = new System.Drawing.Point(335, 315);
            this.btnAbrirClientes.Name = "btnAbrirClientes";
            this.btnAbrirClientes.Size = new System.Drawing.Size(97, 51);
            this.btnAbrirClientes.TabIndex = 22;
            this.btnAbrirClientes.Text = "ABRIR CLIENTES";
            this.btnAbrirClientes.UseVisualStyleBackColor = true;
            this.btnAbrirClientes.Click += new System.EventHandler(this.btnAbrirClientes_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(512, 317);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(92, 49);
            this.button1.TabIndex = 23;
            this.button1.Text = "ABRIR ALQUILERES";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(778, 404);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnAbrirClientes);
            this.Controls.Add(this.btnAbrirVehiculos);
            this.Controls.Add(this.Salir);
            this.Controls.Add(this.btnGuardarVehiculo);
            this.Controls.Add(this.btnGuardarCliente);
            this.Controls.Add(this.chkDisponible);
            this.Controls.Add(this.lblTelefono);
            this.Controls.Add(this.lblLicencia);
            this.Controls.Add(this.lblApellido);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.lblDisponible);
            this.Controls.Add(this.lblAño);
            this.Controls.Add(this.lblModelo);
            this.Controls.Add(this.lblMarca);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtTelefono);
            this.Controls.Add(this.txtLicencia);
            this.Controls.Add(this.txtApellido);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.txtAño);
            this.Controls.Add(this.txtModelo);
            this.Controls.Add(this.txtMarca);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.alquilerVehiculosDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vehiculosBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtMarca;
        private System.Windows.Forms.TextBox txtModelo;
        private System.Windows.Forms.TextBox txtAño;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.TextBox txtLicencia;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblMarca;
        private System.Windows.Forms.Label lblModelo;
        private System.Windows.Forms.Label lblAño;
        private System.Windows.Forms.Label lblDisponible;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.Label lblLicencia;
        private System.Windows.Forms.Label lblTelefono;
        private System.Windows.Forms.CheckBox chkDisponible;
        private System.Windows.Forms.Button btnGuardarCliente;
        private System.Windows.Forms.Button btnGuardarVehiculo;
        private System.Windows.Forms.Button Salir;
        private AlquilerVehiculosDBDataSet alquilerVehiculosDBDataSet;
        private System.Windows.Forms.BindingSource vehiculosBindingSource;
        private AlquilerVehiculosDBDataSetTableAdapters.VehiculosTableAdapter vehiculosTableAdapter;
        private System.Windows.Forms.Button btnAbrirVehiculos;
        private System.Windows.Forms.Button btnAbrirClientes;
        private System.Windows.Forms.Button button1;
    }
}

