
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
            this.lblCombobox = new System.Windows.Forms.Label();
            this.cboCombobox = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.fuenteDeDatos)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cboCombobox);
            this.panel1.Controls.Add(this.lblCombobox);
            this.panel1.Size = new System.Drawing.Size(1292, 65);
            this.panel1.Controls.SetChildIndex(this.btnAccionUno, 0);
            this.panel1.Controls.SetChildIndex(this.btnAccionDos, 0);
            this.panel1.Controls.SetChildIndex(this.btnReiniciarFiltros, 0);
            this.panel1.Controls.SetChildIndex(this.lblCombobox, 0);
            this.panel1.Controls.SetChildIndex(this.cboCombobox, 0);
            // 
            // btnAccionUno
            // 
            this.btnAccionUno.Click += new System.EventHandler(this.btnAccionUno_Click);
            // 
            // btnAccionDos
            // 
            this.btnAccionDos.Click += new System.EventHandler(this.btnAccionDos_Click);
            // 
            // lblCombobox
            // 
            this.lblCombobox.AutoSize = true;
            this.lblCombobox.Location = new System.Drawing.Point(777, 24);
            this.lblCombobox.Name = "lblCombobox";
            this.lblCombobox.Size = new System.Drawing.Size(157, 15);
            this.lblCombobox.TabIndex = 7;
            this.lblCombobox.Text = "Mostrando ventas del viaje...";
            // 
            // cboCombobox
            // 
            this.cboCombobox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cboCombobox.FormattingEnabled = true;
            this.cboCombobox.Location = new System.Drawing.Point(940, 21);
            this.cboCombobox.Name = "cboCombobox";
            this.cboCombobox.Size = new System.Drawing.Size(306, 23);
            this.cboCombobox.TabIndex = 8;
            this.cboCombobox.SelectionChangeCommitted += new System.EventHandler(this.cboCombobox_SelectionChangeCommitted);
            // 
            // FrmListadoVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1292, 666);
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

        private System.Windows.Forms.ComboBox cboCombobox;
        private System.Windows.Forms.Label lblCombobox;
    }
}