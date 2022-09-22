
namespace VistaParcial
{
    partial class FrmMain
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.cmbMenu = new System.Windows.Forms.ComboBox();
            this.btnListaVentas = new System.Windows.Forms.Button();
            this.btnListaPasajeros = new System.Windows.Forms.Button();
            this.btnAltaViaje = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtTitulo = new System.Windows.Forms.Label();
            this.dgvListado = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListado)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cmbMenu);
            this.panel1.Controls.Add(this.btnListaVentas);
            this.panel1.Controls.Add(this.btnListaPasajeros);
            this.panel1.Controls.Add(this.btnAltaViaje);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(15);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1179, 66);
            this.panel1.TabIndex = 0;
            // 
            // cmbMenu
            // 
            this.cmbMenu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbMenu.FormattingEnabled = true;
            this.cmbMenu.Location = new System.Drawing.Point(937, 20);
            this.cmbMenu.Name = "cmbMenu";
            this.cmbMenu.Size = new System.Drawing.Size(236, 23);
            this.cmbMenu.TabIndex = 3;
            // 
            // btnListaVentas
            // 
            this.btnListaVentas.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnListaVentas.Location = new System.Drawing.Point(406, 12);
            this.btnListaVentas.Name = "btnListaVentas";
            this.btnListaVentas.Size = new System.Drawing.Size(161, 39);
            this.btnListaVentas.TabIndex = 2;
            this.btnListaVentas.Text = "Listado de ventas";
            this.btnListaVentas.UseVisualStyleBackColor = true;
            // 
            // btnListaPasajeros
            // 
            this.btnListaPasajeros.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnListaPasajeros.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnListaPasajeros.Location = new System.Drawing.Point(207, 12);
            this.btnListaPasajeros.Name = "btnListaPasajeros";
            this.btnListaPasajeros.Size = new System.Drawing.Size(161, 39);
            this.btnListaPasajeros.TabIndex = 1;
            this.btnListaPasajeros.Text = "Listado de pasajeros";
            this.btnListaPasajeros.UseVisualStyleBackColor = true;
            // 
            // btnAltaViaje
            // 
            this.btnAltaViaje.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAltaViaje.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnAltaViaje.Location = new System.Drawing.Point(10, 12);
            this.btnAltaViaje.Name = "btnAltaViaje";
            this.btnAltaViaje.Size = new System.Drawing.Size(161, 39);
            this.btnAltaViaje.TabIndex = 0;
            this.btnAltaViaje.Text = "Nuevo viaje...";
            this.btnAltaViaje.UseVisualStyleBackColor = true;
            this.btnAltaViaje.Click += new System.EventHandler(this.btnAltaViaje_Click);
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.txtTitulo);
            this.panel2.Controls.Add(this.dgvListado);
            this.panel2.Location = new System.Drawing.Point(2, 72);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1174, 565);
            this.panel2.TabIndex = 1;
            // 
            // txtTitulo
            // 
            this.txtTitulo.AutoSize = true;
            this.txtTitulo.Location = new System.Drawing.Point(10, 8);
            this.txtTitulo.Name = "txtTitulo";
            this.txtTitulo.Size = new System.Drawing.Size(38, 15);
            this.txtTitulo.TabIndex = 1;
            this.txtTitulo.Text = "label1";
            // 
            // dgvListado
            // 
            this.dgvListado.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvListado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListado.Location = new System.Drawing.Point(3, 26);
            this.dgvListado.Name = "dgvListado";
            this.dgvListado.RowTemplate.Height = 25;
            this.dgvListado.Size = new System.Drawing.Size(1165, 541);
            this.dgvListado.TabIndex = 0;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1179, 649);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.MinimumSize = new System.Drawing.Size(1195, 650);
            this.Name = "FrmMain";
            this.Text = "FrmMain";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmMain_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmMain_FormClosed);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListado)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cmbMenu;
        private System.Windows.Forms.Button btnListaVentas;
        private System.Windows.Forms.Button btnListaPasajeros;
        private System.Windows.Forms.Button btnAltaViaje;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dgvListado;
        private System.Windows.Forms.Label txtTitulo;
    }
}