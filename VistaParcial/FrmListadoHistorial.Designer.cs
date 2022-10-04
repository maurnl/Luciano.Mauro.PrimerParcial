
namespace VistaParcial
{
    partial class FrmListadoHistorial
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
            this.btnGanancias = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.fuenteDeDatos)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnGanancias);
            this.panel1.Size = new System.Drawing.Size(1317, 65);
            this.panel1.Controls.SetChildIndex(this.btnAccionUno, 0);
            this.panel1.Controls.SetChildIndex(this.cboCombobox, 0);
            this.panel1.Controls.SetChildIndex(this.lblCombobox, 0);
            this.panel1.Controls.SetChildIndex(this.btnAccionDos, 0);
            this.panel1.Controls.SetChildIndex(this.btnReiniciarFiltros, 0);
            this.panel1.Controls.SetChildIndex(this.btnGanancias, 0);
            // 
            // cboCombobox
            // 
            this.cboCombobox.Location = new System.Drawing.Point(2399, 20);
            // 
            // btnAccionUno
            // 
            this.btnAccionUno.Click += new System.EventHandler(this.btnAccionUno_Click);
            // 
            // lblCombobox
            // 
            this.lblCombobox.Location = new System.Drawing.Point(2313, 23);
            // 
            // btnAccionDos
            // 
            this.btnAccionDos.Click += new System.EventHandler(this.btnAccionDos_Click);
            // 
            // btnReiniciarFiltros
            // 
            this.btnReiniciarFiltros.Click += new System.EventHandler(this.btnReiniciarFiltros_Click);
            // 
            // btnGanancias
            // 
            this.btnGanancias.BackColor = System.Drawing.Color.SlateGray;
            this.btnGanancias.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGanancias.Location = new System.Drawing.Point(571, 7);
            this.btnGanancias.Name = "btnGanancias";
            this.btnGanancias.Size = new System.Drawing.Size(161, 48);
            this.btnGanancias.TabIndex = 7;
            this.btnGanancias.Text = "button1";
            this.btnGanancias.UseVisualStyleBackColor = false;
            this.btnGanancias.Click += new System.EventHandler(this.btnGanancias_Click);
            // 
            // FrmListadoHistorial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1317, 666);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmListadoHistorial";
            this.Text = "FrmListadoHistorial";
            this.Load += new System.EventHandler(this.FrmListadoHistorial_Load);
            ((System.ComponentModel.ISupportInitialize)(this.fuenteDeDatos)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnGanancias;
    }
}