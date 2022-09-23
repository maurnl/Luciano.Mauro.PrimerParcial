
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
            this.panel1.Size = new System.Drawing.Size(1186, 66);
            this.panel1.Controls.SetChildIndex(this.btnFiltroUno, 0);
            this.panel1.Controls.SetChildIndex(this.cboCombobox, 0);
            this.panel1.Controls.SetChildIndex(this.lblCombobox, 0);
            this.panel1.Controls.SetChildIndex(this.btnFiltroDos, 0);
            this.panel1.Controls.SetChildIndex(this.btnReiniciarFiltros, 0);
            this.panel1.Controls.SetChildIndex(this.chkFiltroUno, 0);
            this.panel1.Controls.SetChildIndex(this.chkFiltroDos, 0);
            // 
            // cboCombobox
            // 
            this.cboCombobox.Size = new System.Drawing.Size(250, 23);
            // 
            // btnFiltroUno
            // 
            this.btnFiltroUno.Location = new System.Drawing.Point(18, 12);
            this.btnFiltroUno.Click += new System.EventHandler(this.btnFiltroUno_Click);
            // 
            // chkFiltroUno
            // 
            this.chkFiltroUno.AutoSize = true;
            this.chkFiltroUno.Location = new System.Drawing.Point(561, 13);
            this.chkFiltroUno.Name = "chkFiltroUno";
            this.chkFiltroUno.Size = new System.Drawing.Size(83, 19);
            this.chkFiltroUno.TabIndex = 7;
            this.chkFiltroUno.Text = "checkBox1";
            this.chkFiltroUno.UseVisualStyleBackColor = true;
            this.chkFiltroUno.CheckedChanged += new System.EventHandler(this.chkFiltroUno_CheckedChanged);
            // 
            // chkFiltroDos
            // 
            this.chkFiltroDos.AutoSize = true;
            this.chkFiltroDos.Location = new System.Drawing.Point(561, 32);
            this.chkFiltroDos.Name = "chkFiltroDos";
            this.chkFiltroDos.Size = new System.Drawing.Size(83, 19);
            this.chkFiltroDos.TabIndex = 8;
            this.chkFiltroDos.Text = "checkBox2";
            this.chkFiltroDos.UseVisualStyleBackColor = true;
            this.chkFiltroDos.CheckedChanged += new System.EventHandler(this.chkFiltroDos_CheckedChanged);
            // 
            // FrmListadoViajes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1186, 611);
            this.Name = "FrmListadoViajes";
            this.Text = "FrmListadoViajes";
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