
namespace VistaParcial
{
    partial class FrmInfoPasajero
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
            this.ptbFoto = new System.Windows.Forms.PictureBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblDni = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.lstEquipajes = new System.Windows.Forms.ListBox();
            this.lblGenero = new System.Windows.Forms.Label();
            this.lblEdad = new System.Windows.Forms.Label();
            this.lblCantidadViajes = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ptbFoto)).BeginInit();
            this.SuspendLayout();
            // 
            // ptbFoto
            // 
            this.ptbFoto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ptbFoto.Location = new System.Drawing.Point(12, 12);
            this.ptbFoto.Name = "ptbFoto";
            this.ptbFoto.Size = new System.Drawing.Size(147, 142);
            this.ptbFoto.TabIndex = 0;
            this.ptbFoto.TabStop = false;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(12, 190);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(38, 15);
            this.lblNombre.TabIndex = 1;
            this.lblNombre.Text = "label1";
            // 
            // lblDni
            // 
            this.lblDni.AutoSize = true;
            this.lblDni.Location = new System.Drawing.Point(12, 166);
            this.lblDni.Name = "lblDni";
            this.lblDni.Size = new System.Drawing.Size(38, 15);
            this.lblDni.TabIndex = 2;
            this.lblDni.Text = "label2";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(171, 399);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(183, 41);
            this.button1.TabIndex = 3;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lstEquipajes
            // 
            this.lstEquipajes.FormattingEnabled = true;
            this.lstEquipajes.ItemHeight = 15;
            this.lstEquipajes.Location = new System.Drawing.Point(12, 225);
            this.lstEquipajes.Name = "lstEquipajes";
            this.lstEquipajes.Size = new System.Drawing.Size(236, 109);
            this.lstEquipajes.TabIndex = 4;
            // 
            // lblGenero
            // 
            this.lblGenero.AutoSize = true;
            this.lblGenero.Location = new System.Drawing.Point(171, 13);
            this.lblGenero.Name = "lblGenero";
            this.lblGenero.Size = new System.Drawing.Size(38, 15);
            this.lblGenero.TabIndex = 5;
            this.lblGenero.Text = "label1";
            // 
            // lblEdad
            // 
            this.lblEdad.AutoSize = true;
            this.lblEdad.Location = new System.Drawing.Point(171, 32);
            this.lblEdad.Name = "lblEdad";
            this.lblEdad.Size = new System.Drawing.Size(38, 15);
            this.lblEdad.TabIndex = 6;
            this.lblEdad.Text = "label1";
            // 
            // lblCantidadViajes
            // 
            this.lblCantidadViajes.AutoSize = true;
            this.lblCantidadViajes.Location = new System.Drawing.Point(171, 57);
            this.lblCantidadViajes.Name = "lblCantidadViajes";
            this.lblCantidadViajes.Size = new System.Drawing.Size(38, 15);
            this.lblCantidadViajes.TabIndex = 7;
            this.lblCantidadViajes.Text = "label1";
            // 
            // FrmInfoPasajero
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(553, 464);
            this.Controls.Add(this.lblCantidadViajes);
            this.Controls.Add(this.lblEdad);
            this.Controls.Add(this.lblGenero);
            this.Controls.Add(this.lstEquipajes);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblDni);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.ptbFoto);
            this.Name = "FrmInfoPasajero";
            this.Text = "FrmInfoPasajero";
            this.Load += new System.EventHandler(this.FrmInfoPasajero_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ptbFoto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox ptbFoto;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblDni;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox lstEquipajes;
        private System.Windows.Forms.Label lblGenero;
        private System.Windows.Forms.Label lblEdad;
        private System.Windows.Forms.Label lblCantidadViajes;
    }
}