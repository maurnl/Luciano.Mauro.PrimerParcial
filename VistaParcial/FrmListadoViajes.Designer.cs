
namespace VistaParcial
{
    partial class FrmListadoViajes
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
            this.chkFiltroUno = new System.Windows.Forms.CheckBox();
            this.chkFiltroDos = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.fuenteDeDatos)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.chkFiltroDos);
            this.panel1.Controls.Add(this.chkFiltroUno);
            this.panel1.Size = new System.Drawing.Size(1323, 66);
            this.panel1.Controls.SetChildIndex(this.btnAccionUno, 0);
            this.panel1.Controls.SetChildIndex(this.cboCombobox, 0);
            this.panel1.Controls.SetChildIndex(this.lblCombobox, 0);
            this.panel1.Controls.SetChildIndex(this.btnAccionDos, 0);
            this.panel1.Controls.SetChildIndex(this.btnReiniciarFiltros, 0);
            this.panel1.Controls.SetChildIndex(this.chkFiltroUno, 0);
            this.panel1.Controls.SetChildIndex(this.chkFiltroDos, 0);
            // 
            // cboCombobox
            // 
            this.cboCombobox.Location = new System.Drawing.Point(2402, 20);
            // 
            // btnAccionUno
            // 
            this.btnAccionUno.Click += new System.EventHandler(this.btnFiltroUno_Click);
            // 
            // lblCombobox
            // 
            this.lblCombobox.Location = new System.Drawing.Point(2316, 23);
            // 
            // btnAccionDos
            // 
            this.btnAccionDos.Click += new System.EventHandler(this.btnAccionDos_Click);
            // 
            // btnReiniciarFiltros
            // 
            this.btnReiniciarFiltros.Click += new System.EventHandler(this.btnReiniciarFiltros_Click);
            // 
            // chkFiltroUno
            // 
            this.chkFiltroUno.AutoSize = true;
            this.chkFiltroUno.Location = new System.Drawing.Point(561, 13);
            this.chkFiltroUno.Name = "chkFiltroUno";
            this.chkFiltroUno.Size = new System.Drawing.Size(179, 19);
            this.chkFiltroUno.TabIndex = 7;
            this.chkFiltroUno.Text = "Filtrar cruceros con gimnasio";
            this.chkFiltroUno.UseVisualStyleBackColor = true;
            this.chkFiltroUno.CheckedChanged += new System.EventHandler(this.chkFiltroUno_CheckedChanged);
            // 
            // chkFiltroDos
            // 
            this.chkFiltroDos.AutoSize = true;
            this.chkFiltroDos.Location = new System.Drawing.Point(561, 32);
            this.chkFiltroDos.Name = "chkFiltroDos";
            this.chkFiltroDos.Size = new System.Drawing.Size(167, 19);
            this.chkFiltroDos.TabIndex = 8;
            this.chkFiltroDos.Text = "Filtrar cruceros con piscina";
            this.chkFiltroDos.UseVisualStyleBackColor = true;
            this.chkFiltroDos.CheckedChanged += new System.EventHandler(this.chkFiltroDos_CheckedChanged);
            // 
            // FrmListadoViajes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1323, 702);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmListadoViajes";
            this.Text = "FrmListadoViajes";
            this.Load += new System.EventHandler(this.FrmListadoViajes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.fuenteDeDatos)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.CheckBox chkFiltroDos;
        private System.Windows.Forms.CheckBox chkFiltroUno;
    }
}