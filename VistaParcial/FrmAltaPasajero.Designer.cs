
namespace VistaParcial
{
    partial class FrmAltaPasajero
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAltaPasajero));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cboGenero = new System.Windows.Forms.ComboBox();
            this.lblErrorBusqueda = new System.Windows.Forms.Label();
            this.btnBuscarPasajero = new System.Windows.Forms.Button();
            this.btnRegistrarPasajero = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpFechaNacimiento = new System.Windows.Forms.DateTimePicker();
            this.cboTipoPasajero = new System.Windows.Forms.ComboBox();
            this.txtDni = new System.Windows.Forms.TextBox();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnEliminarPasajero = new System.Windows.Forms.Button();
            this.lstPasajeros = new System.Windows.Forms.ListBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnAyuda = new System.Windows.Forms.Button();
            this.lblLugaresPremiumDisponible = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnRegistrarVenta = new System.Windows.Forms.Button();
            this.lblPesoDisponible = new System.Windows.Forms.Label();
            this.lblLugaresTuristaDisponibles = new System.Windows.Forms.Label();
            this.gpbEquipajes = new System.Windows.Forms.GroupBox();
            this.lblError = new System.Windows.Forms.Label();
            this.btnRegistrarEquipaje = new System.Windows.Forms.Button();
            this.chkEsDeMano = new System.Windows.Forms.CheckBox();
            this.label9 = new System.Windows.Forms.Label();
            this.lstEquipajes = new System.Windows.Forms.ListBox();
            this.nudPeso = new System.Windows.Forms.NumericUpDown();
            this.tableLayoutPanel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.gpbEquipajes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudPeso)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tableLayoutPanel1.BackgroundImage")));
            this.tableLayoutPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35.84906F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 64.15094F));
            this.tableLayoutPanel1.Controls.Add(this.groupBox1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.groupBox2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.groupBox3, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.gpbEquipajes, 1, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 12);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 73.5119F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 26.48809F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(778, 653);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.cboGenero);
            this.groupBox1.Controls.Add(this.lblErrorBusqueda);
            this.groupBox1.Controls.Add(this.btnBuscarPasajero);
            this.groupBox1.Controls.Add(this.btnRegistrarPasajero);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.dtpFechaNacimiento);
            this.groupBox1.Controls.Add(this.cboTipoPasajero);
            this.groupBox1.Controls.Add(this.txtDni);
            this.groupBox1.Controls.Add(this.txtApellido);
            this.groupBox1.Controls.Add(this.txtNombre);
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(272, 474);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos del pasajero";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label5.Location = new System.Drawing.Point(28, 104);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 15);
            this.label5.TabIndex = 19;
            this.label5.Text = "Genero:";
            // 
            // cboGenero
            // 
            this.cboGenero.FormattingEnabled = true;
            this.cboGenero.Location = new System.Drawing.Point(28, 122);
            this.cboGenero.Name = "cboGenero";
            this.cboGenero.Size = new System.Drawing.Size(213, 23);
            this.cboGenero.TabIndex = 18;
            // 
            // lblErrorBusqueda
            // 
            this.lblErrorBusqueda.AutoSize = true;
            this.lblErrorBusqueda.Location = new System.Drawing.Point(44, 23);
            this.lblErrorBusqueda.Name = "lblErrorBusqueda";
            this.lblErrorBusqueda.Size = new System.Drawing.Size(38, 15);
            this.lblErrorBusqueda.TabIndex = 17;
            this.lblErrorBusqueda.Text = "label7";
            // 
            // btnBuscarPasajero
            // 
            this.btnBuscarPasajero.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnBuscarPasajero.BackgroundImage")));
            this.btnBuscarPasajero.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBuscarPasajero.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnBuscarPasajero.Location = new System.Drawing.Point(216, 60);
            this.btnBuscarPasajero.Name = "btnBuscarPasajero";
            this.btnBuscarPasajero.Size = new System.Drawing.Size(25, 23);
            this.btnBuscarPasajero.TabIndex = 16;
            this.btnBuscarPasajero.UseVisualStyleBackColor = true;
            this.btnBuscarPasajero.Click += new System.EventHandler(this.btnBuscarPasajero_Click);
            // 
            // btnRegistrarPasajero
            // 
            this.btnRegistrarPasajero.Location = new System.Drawing.Point(52, 402);
            this.btnRegistrarPasajero.Name = "btnRegistrarPasajero";
            this.btnRegistrarPasajero.Size = new System.Drawing.Size(168, 42);
            this.btnRegistrarPasajero.TabIndex = 14;
            this.btnRegistrarPasajero.Text = "Registrar pasajero";
            this.btnRegistrarPasajero.UseVisualStyleBackColor = true;
            this.btnRegistrarPasajero.Click += new System.EventHandler(this.btnRegistrarPasajero_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label6.Location = new System.Drawing.Point(29, 328);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(96, 15);
            this.label6.TabIndex = 13;
            this.label6.Text = "Tipo de pasajero:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label4.Location = new System.Drawing.Point(29, 43);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 15);
            this.label4.TabIndex = 10;
            this.label4.Text = "DNI:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label3.Location = new System.Drawing.Point(29, 265);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 15);
            this.label3.TabIndex = 9;
            this.label3.Text = "Fecha de nacimiento:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label2.Location = new System.Drawing.Point(29, 207);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 15);
            this.label2.TabIndex = 8;
            this.label2.Text = "Apellido:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Location = new System.Drawing.Point(29, 148);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 15);
            this.label1.TabIndex = 7;
            this.label1.Text = "Nombre:";
            // 
            // dtpFechaNacimiento
            // 
            this.dtpFechaNacimiento.Location = new System.Drawing.Point(29, 283);
            this.dtpFechaNacimiento.Name = "dtpFechaNacimiento";
            this.dtpFechaNacimiento.Size = new System.Drawing.Size(212, 23);
            this.dtpFechaNacimiento.TabIndex = 6;
            // 
            // cboTipoPasajero
            // 
            this.cboTipoPasajero.FormattingEnabled = true;
            this.cboTipoPasajero.Location = new System.Drawing.Point(29, 346);
            this.cboTipoPasajero.Name = "cboTipoPasajero";
            this.cboTipoPasajero.Size = new System.Drawing.Size(212, 23);
            this.cboTipoPasajero.TabIndex = 5;
            // 
            // txtDni
            // 
            this.txtDni.Location = new System.Drawing.Point(29, 61);
            this.txtDni.Name = "txtDni";
            this.txtDni.Size = new System.Drawing.Size(157, 23);
            this.txtDni.TabIndex = 2;
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(29, 225);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(212, 23);
            this.txtApellido.TabIndex = 1;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(29, 166);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(212, 23);
            this.txtNombre.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox2.Controls.Add(this.btnEliminarPasajero);
            this.groupBox2.Controls.Add(this.lstPasajeros);
            this.groupBox2.Location = new System.Drawing.Point(281, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(494, 474);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Pasajeros registrados";
            // 
            // btnEliminarPasajero
            // 
            this.btnEliminarPasajero.Location = new System.Drawing.Point(173, 402);
            this.btnEliminarPasajero.Name = "btnEliminarPasajero";
            this.btnEliminarPasajero.Size = new System.Drawing.Size(168, 42);
            this.btnEliminarPasajero.TabIndex = 1;
            this.btnEliminarPasajero.Text = "Eliminar pasajero";
            this.btnEliminarPasajero.UseVisualStyleBackColor = true;
            this.btnEliminarPasajero.Click += new System.EventHandler(this.btnEliminarPasajero_Click);
            // 
            // lstPasajeros
            // 
            this.lstPasajeros.FormattingEnabled = true;
            this.lstPasajeros.ItemHeight = 15;
            this.lstPasajeros.Location = new System.Drawing.Point(26, 35);
            this.lstPasajeros.Name = "lstPasajeros";
            this.lstPasajeros.Size = new System.Drawing.Size(439, 334);
            this.lstPasajeros.TabIndex = 0;
            this.lstPasajeros.SelectedIndexChanged += new System.EventHandler(this.lstPasajeros_SelectedIndexChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnAyuda);
            this.groupBox3.Controls.Add(this.lblLugaresPremiumDisponible);
            this.groupBox3.Controls.Add(this.btnCancelar);
            this.groupBox3.Controls.Add(this.btnRegistrarVenta);
            this.groupBox3.Controls.Add(this.lblPesoDisponible);
            this.groupBox3.Controls.Add(this.lblLugaresTuristaDisponibles);
            this.groupBox3.Location = new System.Drawing.Point(3, 483);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(272, 167);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Datos del crucero";
            // 
            // btnAyuda
            // 
            this.btnAyuda.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnAyuda.Location = new System.Drawing.Point(0, 127);
            this.btnAyuda.Name = "btnAyuda";
            this.btnAyuda.Size = new System.Drawing.Size(40, 40);
            this.btnAyuda.TabIndex = 5;
            this.btnAyuda.UseVisualStyleBackColor = true;
            this.btnAyuda.Click += new System.EventHandler(this.btnAyuda_Click);
            // 
            // lblLugaresPremiumDisponible
            // 
            this.lblLugaresPremiumDisponible.AutoSize = true;
            this.lblLugaresPremiumDisponible.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblLugaresPremiumDisponible.Location = new System.Drawing.Point(21, 47);
            this.lblLugaresPremiumDisponible.Name = "lblLugaresPremiumDisponible";
            this.lblLugaresPremiumDisponible.Size = new System.Drawing.Size(38, 15);
            this.lblLugaresPremiumDisponible.TabIndex = 4;
            this.lblLugaresPremiumDisponible.Text = "label7";
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(52, 119);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(160, 37);
            this.btnCancelar.TabIndex = 3;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnRegistrarVenta
            // 
            this.btnRegistrarVenta.Location = new System.Drawing.Point(52, 70);
            this.btnRegistrarVenta.Name = "btnRegistrarVenta";
            this.btnRegistrarVenta.Size = new System.Drawing.Size(160, 37);
            this.btnRegistrarVenta.TabIndex = 2;
            this.btnRegistrarVenta.Text = "Registrar nueva venta";
            this.btnRegistrarVenta.UseVisualStyleBackColor = true;
            this.btnRegistrarVenta.Click += new System.EventHandler(this.btnRegistrarVenta_Click);
            // 
            // lblPesoDisponible
            // 
            this.lblPesoDisponible.AutoSize = true;
            this.lblPesoDisponible.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblPesoDisponible.Location = new System.Drawing.Point(21, 17);
            this.lblPesoDisponible.Name = "lblPesoDisponible";
            this.lblPesoDisponible.Size = new System.Drawing.Size(38, 15);
            this.lblPesoDisponible.TabIndex = 1;
            this.lblPesoDisponible.Text = "label8";
            // 
            // lblLugaresTuristaDisponibles
            // 
            this.lblLugaresTuristaDisponibles.AutoSize = true;
            this.lblLugaresTuristaDisponibles.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblLugaresTuristaDisponibles.Location = new System.Drawing.Point(21, 32);
            this.lblLugaresTuristaDisponibles.Name = "lblLugaresTuristaDisponibles";
            this.lblLugaresTuristaDisponibles.Size = new System.Drawing.Size(38, 15);
            this.lblLugaresTuristaDisponibles.TabIndex = 0;
            this.lblLugaresTuristaDisponibles.Text = "label7";
            // 
            // gpbEquipajes
            // 
            this.gpbEquipajes.Controls.Add(this.lblError);
            this.gpbEquipajes.Controls.Add(this.btnRegistrarEquipaje);
            this.gpbEquipajes.Controls.Add(this.chkEsDeMano);
            this.gpbEquipajes.Controls.Add(this.label9);
            this.gpbEquipajes.Controls.Add(this.lstEquipajes);
            this.gpbEquipajes.Controls.Add(this.nudPeso);
            this.gpbEquipajes.Location = new System.Drawing.Point(281, 483);
            this.gpbEquipajes.Name = "gpbEquipajes";
            this.gpbEquipajes.Size = new System.Drawing.Size(494, 167);
            this.gpbEquipajes.TabIndex = 3;
            this.gpbEquipajes.TabStop = false;
            this.gpbEquipajes.Text = "Equipajes del pasajero";
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblError.Location = new System.Drawing.Point(39, 101);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(38, 15);
            this.lblError.TabIndex = 8;
            this.lblError.Text = "label7";
            // 
            // btnRegistrarEquipaje
            // 
            this.btnRegistrarEquipaje.Location = new System.Drawing.Point(61, 119);
            this.btnRegistrarEquipaje.Name = "btnRegistrarEquipaje";
            this.btnRegistrarEquipaje.Size = new System.Drawing.Size(146, 37);
            this.btnRegistrarEquipaje.TabIndex = 7;
            this.btnRegistrarEquipaje.Text = "Registrar equipaje";
            this.btnRegistrarEquipaje.UseVisualStyleBackColor = true;
            this.btnRegistrarEquipaje.Click += new System.EventHandler(this.btnRegistrarEquipaje_Click);
            // 
            // chkEsDeMano
            // 
            this.chkEsDeMano.AutoSize = true;
            this.chkEsDeMano.Location = new System.Drawing.Point(72, 80);
            this.chkEsDeMano.Name = "chkEsDeMano";
            this.chkEsDeMano.Size = new System.Drawing.Size(135, 19);
            this.chkEsDeMano.TabIndex = 6;
            this.chkEsDeMano.Text = "Es equipaje de mano";
            this.chkEsDeMano.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(72, 19);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(35, 15);
            this.label9.TabIndex = 4;
            this.label9.Text = "Peso:";
            // 
            // lstEquipajes
            // 
            this.lstEquipajes.FormattingEnabled = true;
            this.lstEquipajes.ItemHeight = 15;
            this.lstEquipajes.Location = new System.Drawing.Point(285, 17);
            this.lstEquipajes.Name = "lstEquipajes";
            this.lstEquipajes.Size = new System.Drawing.Size(203, 139);
            this.lstEquipajes.TabIndex = 1;
            // 
            // nudPeso
            // 
            this.nudPeso.Location = new System.Drawing.Point(73, 37);
            this.nudPeso.Name = "nudPeso";
            this.nudPeso.Size = new System.Drawing.Size(120, 23);
            this.nudPeso.TabIndex = 0;
            // 
            // FrmAltaPasajero
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(802, 677);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "FrmAltaPasajero";
            this.Text = "FrmAltaPasajero";
            this.Load += new System.EventHandler(this.FrmAltaPasajero_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.gpbEquipajes.ResumeLayout(false);
            this.gpbEquipajes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudPeso)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox gpbEquipajes;
        private System.Windows.Forms.DateTimePicker dtpFechaNacimiento;
        private System.Windows.Forms.ComboBox cboTipoPasajero;
        private System.Windows.Forms.TextBox txtDni;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnRegistrarPasajero;
        private System.Windows.Forms.Button btnEliminarPasajero;
        private System.Windows.Forms.ListBox lstPasajeros;
        private System.Windows.Forms.Label lblPesoDisponible;
        private System.Windows.Forms.Label lblLugaresTuristaDisponibles;
        private System.Windows.Forms.Button btnRegistrarEquipaje;
        private System.Windows.Forms.CheckBox chkEsDeMano;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ListBox lstEquipajes;
        private System.Windows.Forms.NumericUpDown nudPeso;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnRegistrarVenta;
        private System.Windows.Forms.Label lblError;
        private System.Windows.Forms.Label lblLugaresPremiumDisponible;
        private System.Windows.Forms.Button btnBuscarPasajero;
        private System.Windows.Forms.Label lblErrorBusqueda;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cboGenero;
        private System.Windows.Forms.Button btnAyuda;
    }
}