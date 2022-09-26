
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
            this.btnReiniciarFiltros = new System.Windows.Forms.Button();
            this.btnAccionDos = new System.Windows.Forms.Button();
            this.lblCombobox = new System.Windows.Forms.Label();
            this.cboCombobox = new System.Windows.Forms.ComboBox();
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
            this.panel1.Controls.Add(this.lblCombobox);
            this.panel1.Controls.Add(this.cboCombobox);
            this.panel1.Controls.Add(this.btnAccionUno);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(15);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1179, 66);
            this.panel1.TabIndex = 0;
            // 
            // btnReiniciarFiltros
            // 
            this.btnReiniciarFiltros.Location = new System.Drawing.Point(382, 12);
            this.btnReiniciarFiltros.Name = "btnReiniciarFiltros";
            this.btnReiniciarFiltros.Size = new System.Drawing.Size(161, 39);
            this.btnReiniciarFiltros.TabIndex = 6;
            this.btnReiniciarFiltros.Text = "Eliminar filtros";
            this.btnReiniciarFiltros.UseVisualStyleBackColor = true;
            this.btnReiniciarFiltros.Click += new System.EventHandler(this.btnReiniciarFiltros_Click);
            // 
            // btnAccionDos
            // 
            this.btnAccionDos.Location = new System.Drawing.Point(196, 12);
            this.btnAccionDos.Name = "btnAccionDos";
            this.btnAccionDos.Size = new System.Drawing.Size(161, 39);
            this.btnAccionDos.TabIndex = 5;
            this.btnAccionDos.Text = "Boton 2";
            this.btnAccionDos.UseVisualStyleBackColor = true;
            // 
            // lblCombobox
            // 
            this.lblCombobox.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblCombobox.AutoSize = true;
            this.lblCombobox.Location = new System.Drawing.Point(777, 24);
            this.lblCombobox.Name = "lblCombobox";
            this.lblCombobox.Size = new System.Drawing.Size(80, 15);
            this.lblCombobox.TabIndex = 4;
            this.lblCombobox.Text = "Ordenar por...";
            // 
            // cboCombobox
            // 
            this.cboCombobox.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.cboCombobox.FormattingEnabled = true;
            this.cboCombobox.Location = new System.Drawing.Point(863, 21);
            this.cboCombobox.Name = "cboCombobox";
            this.cboCombobox.Size = new System.Drawing.Size(236, 23);
            this.cboCombobox.TabIndex = 3;
            // 
            // btnAccionUno
            // 
            this.btnAccionUno.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnAccionUno.Location = new System.Drawing.Point(10, 12);
            this.btnAccionUno.Name = "btnAccionUno";
            this.btnAccionUno.Size = new System.Drawing.Size(161, 39);
            this.btnAccionUno.TabIndex = 0;
            this.btnAccionUno.Text = "Boton 1";
            this.btnAccionUno.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.lblError);
            this.panel2.Controls.Add(this.dgvListado);
            this.panel2.Location = new System.Drawing.Point(2, 72);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1174, 565);
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
            this.dgvListado.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvListado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListado.Location = new System.Drawing.Point(3, 26);
            this.dgvListado.Name = "dgvListado";
            this.dgvListado.RowTemplate.Height = 25;
            this.dgvListado.Size = new System.Drawing.Size(1165, 495);
            this.dgvListado.TabIndex = 0;
            // 
            // FrmListadoBase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1179, 649);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.MinimumSize = new System.Drawing.Size(1195, 350);
            this.Name = "FrmListadoBase";
            this.Text = "9";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListado)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        protected System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        protected System.Windows.Forms.DataGridView dgvListado;
        protected System.Windows.Forms.ComboBox cboCombobox;
        protected System.Windows.Forms.Button btnAccionUno;
        protected System.Windows.Forms.Label lblError;
        protected System.Windows.Forms.Label lblCombobox;
        protected System.Windows.Forms.Button btnAccionDos;
        protected System.Windows.Forms.Button btnReiniciarFiltros;
    }
}