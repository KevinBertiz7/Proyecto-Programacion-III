namespace Presentacion
{
    partial class FmrAlquiler
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtKmRecepcion = new System.Windows.Forms.TextBox();
            this.KmRep = new System.Windows.Forms.Label();
            this.listaVehiculos = new System.Windows.Forms.ListBox();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.FechaR = new System.Windows.Forms.Label();
            this.txtValorKm = new System.Windows.Forms.TextBox();
            this.Valor = new System.Windows.Forms.Label();
            this.listaClientes = new System.Windows.Forms.ListBox();
            this.txtPlaca = new System.Windows.Forms.TextBox();
            this.placa = new System.Windows.Forms.Label();
            this.txtIdCliente = new System.Windows.Forms.TextBox();
            this.idCliente = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.txtFecha = new System.Windows.Forms.TextBox();
            this.txtCondicion = new System.Windows.Forms.TextBox();
            this.grillaAlquileres = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.textAlquiler = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtKmEntrega = new System.Windows.Forms.TextBox();
            this.KmEn = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.fechaEn = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grillaAlquileres)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(28, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(847, 396);
            this.tabControl1.TabIndex = 5;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(839, 370);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Proceso de alquiler";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtKmRecepcion);
            this.groupBox2.Controls.Add(this.KmRep);
            this.groupBox2.Controls.Add(this.listaVehiculos);
            this.groupBox2.Controls.Add(this.dateTimePicker2);
            this.groupBox2.Controls.Add(this.FechaR);
            this.groupBox2.Controls.Add(this.txtValorKm);
            this.groupBox2.Controls.Add(this.Valor);
            this.groupBox2.Controls.Add(this.listaClientes);
            this.groupBox2.Controls.Add(this.txtPlaca);
            this.groupBox2.Controls.Add(this.placa);
            this.groupBox2.Controls.Add(this.txtIdCliente);
            this.groupBox2.Controls.Add(this.idCliente);
            this.groupBox2.Location = new System.Drawing.Point(85, 19);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(684, 257);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // txtKmRecepcion
            // 
            this.txtKmRecepcion.Location = new System.Drawing.Point(118, 127);
            this.txtKmRecepcion.Name = "txtKmRecepcion";
            this.txtKmRecepcion.Size = new System.Drawing.Size(100, 20);
            this.txtKmRecepcion.TabIndex = 32;
            // 
            // KmRep
            // 
            this.KmRep.AutoSize = true;
            this.KmRep.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KmRep.Location = new System.Drawing.Point(19, 130);
            this.KmRep.Name = "KmRep";
            this.KmRep.Size = new System.Drawing.Size(93, 13);
            this.KmRep.TabIndex = 31;
            this.KmRep.Text = "Km. Recepcion";
            // 
            // listaVehiculos
            // 
            this.listaVehiculos.FormattingEnabled = true;
            this.listaVehiculos.Location = new System.Drawing.Point(472, 38);
            this.listaVehiculos.Name = "listaVehiculos";
            this.listaVehiculos.Size = new System.Drawing.Size(185, 160);
            this.listaVehiculos.TabIndex = 21;
            this.listaVehiculos.SelectedIndexChanged += new System.EventHandler(this.listaVehiculos_SelectedIndexChanged);
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker2.Location = new System.Drawing.Point(118, 95);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(100, 20);
            this.dateTimePicker2.TabIndex = 20;
            this.dateTimePicker2.ValueChanged += new System.EventHandler(this.dateTimePicker2_ValueChanged);
            // 
            // FechaR
            // 
            this.FechaR.AutoSize = true;
            this.FechaR.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FechaR.Location = new System.Drawing.Point(47, 99);
            this.FechaR.Name = "FechaR";
            this.FechaR.Size = new System.Drawing.Size(59, 13);
            this.FechaR.TabIndex = 13;
            this.FechaR.Text = "Fecha R.";
            // 
            // txtValorKm
            // 
            this.txtValorKm.Location = new System.Drawing.Point(118, 153);
            this.txtValorKm.Name = "txtValorKm";
            this.txtValorKm.Size = new System.Drawing.Size(100, 20);
            this.txtValorKm.TabIndex = 12;
            this.txtValorKm.TextChanged += new System.EventHandler(this.txtValorKm_TextChanged);
            // 
            // Valor
            // 
            this.Valor.AutoSize = true;
            this.Valor.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Valor.Location = new System.Drawing.Point(54, 156);
            this.Valor.Name = "Valor";
            this.Valor.Size = new System.Drawing.Size(57, 13);
            this.Valor.TabIndex = 11;
            this.Valor.Text = "Valor Km";
            // 
            // listaClientes
            // 
            this.listaClientes.FormattingEnabled = true;
            this.listaClientes.Location = new System.Drawing.Point(246, 38);
            this.listaClientes.Name = "listaClientes";
            this.listaClientes.Size = new System.Drawing.Size(185, 160);
            this.listaClientes.TabIndex = 6;
            this.listaClientes.SelectedIndexChanged += new System.EventHandler(this.listaClientes_SelectedIndexChanged_1);
            // 
            // txtPlaca
            // 
            this.txtPlaca.Location = new System.Drawing.Point(114, 64);
            this.txtPlaca.Name = "txtPlaca";
            this.txtPlaca.Size = new System.Drawing.Size(100, 20);
            this.txtPlaca.TabIndex = 5;
            // 
            // placa
            // 
            this.placa.AutoSize = true;
            this.placa.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.placa.Location = new System.Drawing.Point(68, 67);
            this.placa.Name = "placa";
            this.placa.Size = new System.Drawing.Size(39, 13);
            this.placa.TabIndex = 4;
            this.placa.Text = "Placa";
            // 
            // txtIdCliente
            // 
            this.txtIdCliente.Location = new System.Drawing.Point(114, 35);
            this.txtIdCliente.Name = "txtIdCliente";
            this.txtIdCliente.Size = new System.Drawing.Size(100, 20);
            this.txtIdCliente.TabIndex = 3;
            // 
            // idCliente
            // 
            this.idCliente.AutoSize = true;
            this.idCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idCliente.Location = new System.Drawing.Point(47, 38);
            this.idCliente.Name = "idCliente";
            this.idCliente.Size = new System.Drawing.Size(61, 13);
            this.idCliente.TabIndex = 2;
            this.idCliente.Text = "Id Cliente";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnSalir);
            this.groupBox1.Controls.Add(this.btnGuardar);
            this.groupBox1.Location = new System.Drawing.Point(169, 282);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(437, 67);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(251, 19);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(77, 29);
            this.btnSalir.TabIndex = 2;
            this.btnSalir.Text = "&Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(70, 19);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(74, 29);
            this.btnGuardar.TabIndex = 0;
            this.btnGuardar.Text = "&Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.label2);
            this.tabPage3.Controls.Add(this.txtFecha);
            this.tabPage3.Controls.Add(this.txtCondicion);
            this.tabPage3.Controls.Add(this.grillaAlquileres);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(839, 370);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Consulta general ";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // txtFecha
            // 
            this.txtFecha.Location = new System.Drawing.Point(527, 19);
            this.txtFecha.Name = "txtFecha";
            this.txtFecha.Size = new System.Drawing.Size(153, 20);
            this.txtFecha.TabIndex = 3;
            this.txtFecha.TextChanged += new System.EventHandler(this.txtFecha_TextChanged);
            // 
            // txtCondicion
            // 
            this.txtCondicion.Location = new System.Drawing.Point(344, 16);
            this.txtCondicion.Name = "txtCondicion";
            this.txtCondicion.Size = new System.Drawing.Size(110, 20);
            this.txtCondicion.TabIndex = 2;
            this.txtCondicion.TextChanged += new System.EventHandler(this.txtCondicion_TextChanged);
            // 
            // grillaAlquileres
            // 
            this.grillaAlquileres.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grillaAlquileres.Location = new System.Drawing.Point(20, 58);
            this.grillaAlquileres.Name = "grillaAlquileres";
            this.grillaAlquileres.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grillaAlquileres.Size = new System.Drawing.Size(802, 263);
            this.grillaAlquileres.TabIndex = 1;
            this.grillaAlquileres.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grillaClientes_CellContentClick);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.panel2);
            this.tabPage2.Controls.Add(this.panel1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(839, 370);
            this.tabPage2.TabIndex = 3;
            this.tabPage2.Text = "Proceso de entrega";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnActualizar);
            this.panel2.Location = new System.Drawing.Point(242, 270);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(328, 49);
            this.panel2.TabIndex = 1;
            // 
            // btnActualizar
            // 
            this.btnActualizar.Location = new System.Drawing.Point(134, 13);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(61, 23);
            this.btnActualizar.TabIndex = 5;
            this.btnActualizar.Text = "&Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.textAlquiler);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtKmEntrega);
            this.panel1.Controls.Add(this.KmEn);
            this.panel1.Controls.Add(this.dateTimePicker1);
            this.panel1.Controls.Add(this.fechaEn);
            this.panel1.Location = new System.Drawing.Point(78, 53);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(607, 199);
            this.panel1.TabIndex = 0;
            // 
            // textAlquiler
            // 
            this.textAlquiler.Location = new System.Drawing.Point(283, 66);
            this.textAlquiler.Name = "textAlquiler";
            this.textAlquiler.Size = new System.Drawing.Size(100, 20);
            this.textAlquiler.TabIndex = 36;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(209, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 35;
            this.label1.Text = "Id Alquiler";
            // 
            // txtKmEntrega
            // 
            this.txtKmEntrega.Location = new System.Drawing.Point(283, 118);
            this.txtKmEntrega.Name = "txtKmEntrega";
            this.txtKmEntrega.Size = new System.Drawing.Size(100, 20);
            this.txtKmEntrega.TabIndex = 34;
            // 
            // KmEn
            // 
            this.KmEn.AutoSize = true;
            this.KmEn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KmEn.Location = new System.Drawing.Point(201, 121);
            this.KmEn.Name = "KmEn";
            this.KmEn.Size = new System.Drawing.Size(76, 13);
            this.KmEn.TabIndex = 33;
            this.KmEn.Text = "Km. Entrega";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(283, 92);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(100, 20);
            this.dateTimePicker1.TabIndex = 31;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // fechaEn
            // 
            this.fechaEn.AutoSize = true;
            this.fechaEn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fechaEn.Location = new System.Drawing.Point(219, 98);
            this.fechaEn.Name = "fechaEn";
            this.fechaEn.Size = new System.Drawing.Size(58, 13);
            this.fechaEn.TabIndex = 26;
            this.fechaEn.Text = "Fecha E.";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(275, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Buscar Id";
            // 
            // FmrAlquiler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(916, 457);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FmrAlquiler";
            this.Text = "FmrAlquiler";
            this.Load += new System.EventHandler(this.FmrAlquiler_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grillaAlquileres)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListBox listaClientes;
        private System.Windows.Forms.TextBox txtPlaca;
        private System.Windows.Forms.Label placa;
        private System.Windows.Forms.TextBox txtIdCliente;
        private System.Windows.Forms.Label idCliente;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TextBox txtValorKm;
        private System.Windows.Forms.Label Valor;
        private System.Windows.Forms.TextBox txtCondicion;
        private System.Windows.Forms.DataGridView grillaAlquileres;
        private System.Windows.Forms.Label FechaR;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label fechaEn;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.ListBox listaVehiculos;
        private System.Windows.Forms.TextBox txtKmRecepcion;
        private System.Windows.Forms.Label KmRep;
        private System.Windows.Forms.TextBox txtKmEntrega;
        private System.Windows.Forms.Label KmEn;
        private System.Windows.Forms.TextBox textAlquiler;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtFecha;
        private System.Windows.Forms.Label label2;
    }
}