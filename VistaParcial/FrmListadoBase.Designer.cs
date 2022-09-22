
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
            this.btnFiltroDos = new System.Windows.Forms.Button();
            this.lblOrden = new System.Windows.Forms.Label();
            this.cboOrden = new System.Windows.Forms.ComboBox();
            this.btnFiltroUno = new System.Windows.Forms.Button();
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
            this.panel1.Controls.Add(this.btnReiniciarFiltros);
            this.panel1.Controls.Add(this.btnFiltroDos);
            this.panel1.Controls.Add(this.lblOrden);
            this.panel1.Controls.Add(this.cboOrden);
            this.panel1.Controls.Add(this.btnFiltroUno);
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
            // 
            // btnFiltroDos
            // 
            this.btnFiltroDos.Location = new System.Drawing.Point(196, 12);
            this.btnFiltroDos.Name = "btnFiltroDos";
            this.btnFiltroDos.Size = new System.Drawing.Size(161, 39);
            this.btnFiltroDos.TabIndex = 5;
            this.btnFiltroDos.Text = "Filtrar 2";
            this.btnFiltroDos.UseVisualStyleBackColor = true;
            // 
            // lblOrden
            // 
            this.lblOrden.AutoSize = true;
            this.lblOrden.Location = new System.Drawing.Point(848, 24);
            this.lblOrden.Name = "lblOrden";
            this.lblOrden.Size = new System.Drawing.Size(80, 15);
            this.lblOrden.TabIndex = 4;
            this.lblOrden.Text = "Ordenar por...";
            // 
            // cboOrden
            // 
            this.cboOrden.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cboOrden.FormattingEnabled = true;
            this.cboOrden.Location = new System.Drawing.Point(934, 21);
            this.cboOrden.Name = "cboOrden";
            this.cboOrden.Size = new System.Drawing.Size(236, 23);
            this.cboOrden.TabIndex = 3;
            // 
            // btnFiltroUno
            // 
            this.btnFiltroUno.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnFiltroUno.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnFiltroUno.Location = new System.Drawing.Point(10, 12);
            this.btnFiltroUno.Name = "btnFiltroUno";
            this.btnFiltroUno.Size = new System.Drawing.Size(161, 39);
            this.btnFiltroUno.TabIndex = 0;
            this.btnFiltroUno.Text = "Filtrar 1";
            this.btnFiltroUno.UseVisualStyleBackColor = true;
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
            // FrmListadoBase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1179, 649);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.MinimumSize = new System.Drawing.Size(1195, 650);
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

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cboOrden;
        private System.Windows.Forms.Button btnFiltroUno;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dgvListado;
        private System.Windows.Forms.Label txtTitulo;
        private System.Windows.Forms.Label lblOrden;
        private System.Windows.Forms.Button btnFiltroDos;
        private System.Windows.Forms.Button btnReiniciarFiltros;
    }
}