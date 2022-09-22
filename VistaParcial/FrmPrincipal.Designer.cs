
namespace VistaParcial
{
    partial class FrmPrincipal
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
            this.btnListadoViajes = new System.Windows.Forms.Button();
            this.btnListadoPasajeros = new System.Windows.Forms.Button();
            this.btnListadoVentas = new System.Windows.Forms.Button();
            this.btnAltaViaje = new System.Windows.Forms.Button();
            this.btnAltaPasajero = new System.Windows.Forms.Button();
            this.lblError = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnListadoViajes
            // 
            this.btnListadoViajes.Location = new System.Drawing.Point(44, 82);
            this.btnListadoViajes.Name = "btnListadoViajes";
            this.btnListadoViajes.Size = new System.Drawing.Size(133, 125);
            this.btnListadoViajes.TabIndex = 0;
            this.btnListadoViajes.Text = "Listado viajes";
            this.btnListadoViajes.UseVisualStyleBackColor = true;
            this.btnListadoViajes.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnListadoPasajeros
            // 
            this.btnListadoPasajeros.Location = new System.Drawing.Point(238, 82);
            this.btnListadoPasajeros.Name = "btnListadoPasajeros";
            this.btnListadoPasajeros.Size = new System.Drawing.Size(133, 125);
            this.btnListadoPasajeros.TabIndex = 1;
            this.btnListadoPasajeros.Text = "Listado pasajeros";
            this.btnListadoPasajeros.UseVisualStyleBackColor = true;
            // 
            // btnListadoVentas
            // 
            this.btnListadoVentas.Location = new System.Drawing.Point(437, 82);
            this.btnListadoVentas.Name = "btnListadoVentas";
            this.btnListadoVentas.Size = new System.Drawing.Size(133, 125);
            this.btnListadoVentas.TabIndex = 2;
            this.btnListadoVentas.Text = "Listado ventas";
            this.btnListadoVentas.UseVisualStyleBackColor = true;
            // 
            // btnAltaViaje
            // 
            this.btnAltaViaje.Location = new System.Drawing.Point(44, 300);
            this.btnAltaViaje.Name = "btnAltaViaje";
            this.btnAltaViaje.Size = new System.Drawing.Size(133, 125);
            this.btnAltaViaje.TabIndex = 3;
            this.btnAltaViaje.Text = "Alta viaje";
            this.btnAltaViaje.UseVisualStyleBackColor = true;
            this.btnAltaViaje.Click += new System.EventHandler(this.btnAltaViaje_Click);
            // 
            // btnAltaPasajero
            // 
            this.btnAltaPasajero.Location = new System.Drawing.Point(238, 300);
            this.btnAltaPasajero.Name = "btnAltaPasajero";
            this.btnAltaPasajero.Size = new System.Drawing.Size(133, 125);
            this.btnAltaPasajero.TabIndex = 4;
            this.btnAltaPasajero.Text = "Alta pasajero";
            this.btnAltaPasajero.UseVisualStyleBackColor = true;
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblError.Location = new System.Drawing.Point(114, 243);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(63, 25);
            this.lblError.TabIndex = 5;
            this.lblError.Text = "label1";
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(614, 573);
            this.Controls.Add(this.lblError);
            this.Controls.Add(this.btnAltaPasajero);
            this.Controls.Add(this.btnAltaViaje);
            this.Controls.Add(this.btnListadoVentas);
            this.Controls.Add(this.btnListadoPasajeros);
            this.Controls.Add(this.btnListadoViajes);
            this.Name = "FrmPrincipal";
            this.Text = "FrmPrincipal";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmPrincipal_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmPrincipal_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnListadoViajes;
        private System.Windows.Forms.Button btnListadoPasajeros;
        private System.Windows.Forms.Button btnListadoVentas;
        private System.Windows.Forms.Button btnAltaViaje;
        private System.Windows.Forms.Button btnAltaPasajero;
        private System.Windows.Forms.Label lblError;
    }
}