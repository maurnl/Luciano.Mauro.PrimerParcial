
namespace VistaParcial
{
    partial class FrmListadoVentas
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
            ((System.ComponentModel.ISupportInitialize)(this.fuenteDeDatos)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Size = new System.Drawing.Size(1317, 65);
            // 
            // cboCombobox
            // 
            this.cboCombobox.Location = new System.Drawing.Point(2096, 20);
            this.cboCombobox.SelectionChangeCommitted += new System.EventHandler(this.cboCombobox_SelectionChangeCommitted);
            // 
            // btnAccionUno
            // 
            this.btnAccionUno.Click += new System.EventHandler(this.btnAccionUno_Click);
            // 
            // lblCombobox
            // 
            this.lblCombobox.Location = new System.Drawing.Point(2010, 23);
            // 
            // btnAccionDos
            // 
            this.btnAccionDos.Click += new System.EventHandler(this.btnAccionDos_Click);
            // 
            // FrmListadoVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1317, 666);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmListadoVentas";
            this.Text = " ";
            this.Load += new System.EventHandler(this.FrmListadoVentas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.fuenteDeDatos)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
    }
}