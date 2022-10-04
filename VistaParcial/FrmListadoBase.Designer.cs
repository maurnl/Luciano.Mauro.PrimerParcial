
namespace VistaParcial
{
    partial class FrmListadoBase
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
            this.btnAyuda = new System.Windows.Forms.Button();
            this.btnReiniciarFiltros = new System.Windows.Forms.Button();
            this.btnAccionDos = new System.Windows.Forms.Button();
            this.btnAccionUno = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblError = new System.Windows.Forms.Label();
            this.dgvListado = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListado)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnReiniciarFiltros);
            this.panel1.Controls.Add(this.btnAccionDos);
            this.panel1.Controls.Add(this.btnAccionUno);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(15);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1250, 65);
            this.panel1.TabIndex = 0;
            // 
            // btnAyuda
            // 
            this.btnAyuda.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnAyuda.Location = new System.Drawing.Point(10, 582);
            this.btnAyuda.Name = "btnAyuda";
            this.btnAyuda.Size = new System.Drawing.Size(25, 25);
            this.btnAyuda.TabIndex = 2;
            this.btnAyuda.Text = "button2";
            this.btnAyuda.UseVisualStyleBackColor = true;
            this.btnAyuda.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnReiniciarFiltros
            // 
            this.btnReiniciarFiltros.BackColor = System.Drawing.Color.SlateGray;
            this.btnReiniciarFiltros.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReiniciarFiltros.Location = new System.Drawing.Point(385, 7);
            this.btnReiniciarFiltros.Name = "btnReiniciarFiltros";
            this.btnReiniciarFiltros.Size = new System.Drawing.Size(161, 48);
            this.btnReiniciarFiltros.TabIndex = 6;
            this.btnReiniciarFiltros.Text = "Eliminar filtros";
            this.btnReiniciarFiltros.UseVisualStyleBackColor = false;
            this.btnReiniciarFiltros.Click += new System.EventHandler(this.btnReiniciarFiltros_Click);
            // 
            // btnAccionDos
            // 
            this.btnAccionDos.BackColor = System.Drawing.Color.SlateGray;
            this.btnAccionDos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAccionDos.Location = new System.Drawing.Point(198, 7);
            this.btnAccionDos.Name = "btnAccionDos";
            this.btnAccionDos.Size = new System.Drawing.Size(161, 48);
            this.btnAccionDos.TabIndex = 5;
            this.btnAccionDos.Text = "Boton 2";
            this.btnAccionDos.UseVisualStyleBackColor = false;
            // 
            // btnAccionUno
            // 
            this.btnAccionUno.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnAccionUno.BackColor = System.Drawing.Color.SlateGray;
            this.btnAccionUno.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAccionUno.Location = new System.Drawing.Point(12, 7);
            this.btnAccionUno.Name = "btnAccionUno";
            this.btnAccionUno.Size = new System.Drawing.Size(161, 48);
            this.btnAccionUno.TabIndex = 0;
            this.btnAccionUno.Text = "Boton 1";
            this.btnAccionUno.UseVisualStyleBackColor = false;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.btnAyuda);
            this.panel2.Controls.Add(this.lblError);
            this.panel2.Controls.Add(this.dgvListado);
            this.panel2.Location = new System.Drawing.Point(2, 72);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1245, 610);
            this.panel2.TabIndex = 1;
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.Location = new System.Drawing.Point(10, 8);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(38, 15);
            this.lblError.TabIndex = 1;
            this.lblError.Text = "label1";
            // 
            // dgvListado
            // 
            this.dgvListado.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgvListado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListado.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvListado.Location = new System.Drawing.Point(0, 0);
            this.dgvListado.Name = "dgvListado";
            this.dgvListado.RowTemplate.Height = 25;
            this.dgvListado.Size = new System.Drawing.Size(1245, 610);
            this.dgvListado.TabIndex = 0;
            // 
            // FrmListadoBase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1250, 694);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.MinimumSize = new System.Drawing.Size(1195, 350);
            this.Name = "FrmListadoBase";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "9";
            this.Load += new System.EventHandler(this.FrmListadoBase_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListado)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        protected System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        protected System.Windows.Forms.DataGridView dgvListado;
        protected System.Windows.Forms.Button btnAccionUno;
        protected System.Windows.Forms.Label lblError;
        protected System.Windows.Forms.Button btnAccionDos;
        protected System.Windows.Forms.Button btnReiniciarFiltros;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnAyuda;
    }
}