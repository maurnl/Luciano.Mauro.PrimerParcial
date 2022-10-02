
namespace VistaParcial
{
    partial class FrmListadoPasajeros
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
            this.txtFiltro = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cboFiltro = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.fuenteDeDatos)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.cboFiltro);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtFiltro);
            this.panel1.Size = new System.Drawing.Size(1277, 66);
            this.panel1.Controls.SetChildIndex(this.txtFiltro, 0);
            this.panel1.Controls.SetChildIndex(this.label1, 0);
            this.panel1.Controls.SetChildIndex(this.cboFiltro, 0);
            this.panel1.Controls.SetChildIndex(this.label2, 0);
            this.panel1.Controls.SetChildIndex(this.btnAccionUno, 0);
            this.panel1.Controls.SetChildIndex(this.cboCombobox, 0);
            this.panel1.Controls.SetChildIndex(this.lblCombobox, 0);
            this.panel1.Controls.SetChildIndex(this.btnAccionDos, 0);
            this.panel1.Controls.SetChildIndex(this.btnReiniciarFiltros, 0);
            // 
            // cboCombobox
            // 
            this.cboCombobox.Location = new System.Drawing.Point(961, 20);
            this.cboCombobox.SelectionChangeCommitted += new System.EventHandler(this.cboCombobox_SelectionChangeCommitted);
            // 
            // btnAccionUno
            // 
            this.btnAccionUno.Click += new System.EventHandler(this.btnAccionUno_Click);
            // 
            // lblCombobox
            // 
            this.lblCombobox.Location = new System.Drawing.Point(875, 23);
            // 
            // btnAccionDos
            // 
            this.btnAccionDos.Click += new System.EventHandler(this.btnAccionDos_Click);
            // 
            // txtFiltro
            // 
            this.txtFiltro.Location = new System.Drawing.Point(635, 37);
            this.txtFiltro.Name = "txtFiltro";
            this.txtFiltro.Size = new System.Drawing.Size(176, 23);
            this.txtFiltro.TabIndex = 7;
            this.txtFiltro.TextChanged += new System.EventHandler(this.txtFiltro_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(552, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 15);
            this.label1.TabIndex = 8;
            this.label1.Text = "Ingrese valor:";
            // 
            // cboFiltro
            // 
            this.cboFiltro.Location = new System.Drawing.Point(635, 7);
            this.cboFiltro.Name = "cboFiltro";
            this.cboFiltro.Size = new System.Drawing.Size(121, 23);
            this.cboFiltro.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(552, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "Filtrar por:";
            // 
            // FrmListadoPasajeros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1277, 668);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmListadoPasajeros";
            this.Text = "FrmListadoPasajeros";
            this.Load += new System.EventHandler(this.FrmListadoPasajeros_Load);
            ((System.ComponentModel.ISupportInitialize)(this.fuenteDeDatos)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtFiltro;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cboFiltro;
    }
}