
namespace VistaParcial
{
    partial class FrmPrincipalContenedor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPrincipalContenedor));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.viajesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nuevoViajeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.simularPasoDelTiempoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.unaHoraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.otroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pasajerosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ventasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.informarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblBienvenido = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.LightSlateGray;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viajesToolStripMenuItem,
            this.pasajerosToolStripMenuItem,
            this.ventasToolStripMenuItem,
            this.informarToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1431, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // viajesToolStripMenuItem
            // 
            this.viajesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nuevoViajeToolStripMenuItem,
            this.simularPasoDelTiempoToolStripMenuItem});
            this.viajesToolStripMenuItem.Name = "viajesToolStripMenuItem";
            this.viajesToolStripMenuItem.Size = new System.Drawing.Size(49, 20);
            this.viajesToolStripMenuItem.Text = "Viajes";
            this.viajesToolStripMenuItem.Click += new System.EventHandler(this.viajesToolStripMenuItem_Click);
            // 
            // nuevoViajeToolStripMenuItem
            // 
            this.nuevoViajeToolStripMenuItem.Name = "nuevoViajeToolStripMenuItem";
            this.nuevoViajeToolStripMenuItem.Size = new System.Drawing.Size(202, 22);
            this.nuevoViajeToolStripMenuItem.Text = "Nuevo viaje...";
            this.nuevoViajeToolStripMenuItem.Click += new System.EventHandler(this.nuevoViajeToolStripMenuItem_Click);
            // 
            // simularPasoDelTiempoToolStripMenuItem
            // 
            this.simularPasoDelTiempoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.unaHoraToolStripMenuItem,
            this.otroToolStripMenuItem});
            this.simularPasoDelTiempoToolStripMenuItem.Name = "simularPasoDelTiempoToolStripMenuItem";
            this.simularPasoDelTiempoToolStripMenuItem.Size = new System.Drawing.Size(202, 22);
            this.simularPasoDelTiempoToolStripMenuItem.Text = "Simular paso del tiempo";
            // 
            // unaHoraToolStripMenuItem
            // 
            this.unaHoraToolStripMenuItem.Name = "unaHoraToolStripMenuItem";
            this.unaHoraToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.unaHoraToolStripMenuItem.Text = "Avanzar 5 dias";
            this.unaHoraToolStripMenuItem.Click += new System.EventHandler(this.unaHoraToolStripMenuItem_Click);
            // 
            // otroToolStripMenuItem
            // 
            this.otroToolStripMenuItem.Name = "otroToolStripMenuItem";
            this.otroToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.otroToolStripMenuItem.Text = "Otro...";
            this.otroToolStripMenuItem.Click += new System.EventHandler(this.otroToolStripMenuItem_Click);
            // 
            // pasajerosToolStripMenuItem
            // 
            this.pasajerosToolStripMenuItem.Name = "pasajerosToolStripMenuItem";
            this.pasajerosToolStripMenuItem.Size = new System.Drawing.Size(68, 20);
            this.pasajerosToolStripMenuItem.Text = "Pasajeros";
            this.pasajerosToolStripMenuItem.Click += new System.EventHandler(this.pasajerosToolStripMenuItem_Click);
            // 
            // ventasToolStripMenuItem
            // 
            this.ventasToolStripMenuItem.Name = "ventasToolStripMenuItem";
            this.ventasToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.ventasToolStripMenuItem.Text = "Ventas";
            this.ventasToolStripMenuItem.Click += new System.EventHandler(this.ventasToolStripMenuItem_Click);
            // 
            // informarToolStripMenuItem
            // 
            this.informarToolStripMenuItem.Name = "informarToolStripMenuItem";
            this.informarToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.informarToolStripMenuItem.Text = "Informar";
            this.informarToolStripMenuItem.Click += new System.EventHandler(this.informarToolStripMenuItem_Click);
            // 
            // lblBienvenido
            // 
            this.lblBienvenido.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblBienvenido.AutoSize = true;
            this.lblBienvenido.BackColor = System.Drawing.Color.Transparent;
            this.lblBienvenido.Font = new System.Drawing.Font("Harlow Solid Italic", 30F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lblBienvenido.Location = new System.Drawing.Point(0, 702);
            this.lblBienvenido.Name = "lblBienvenido";
            this.lblBienvenido.Size = new System.Drawing.Size(121, 51);
            this.lblBienvenido.TabIndex = 1;
            this.lblBienvenido.Text = "label1";
            // 
            // FrmPrincipalContenedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(1431, 773);
            this.Controls.Add(this.lblBienvenido);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmPrincipalContenedor";
            this.Text = "FrmPrincipalContenedor";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmPrincipalContenedor_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmPrincipalContenedor_FormClosed);
            this.Load += new System.EventHandler(this.FrmPrincipalContenedor_Load);
            this.Resize += new System.EventHandler(this.FrmPrincipalContenedor_Resize);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem viajesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pasajerosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ventasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nuevoViajeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem simularPasoDelTiempoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem unaHoraToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem otroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem informarToolStripMenuItem;
        private System.Windows.Forms.Label lblBienvenido;
    }
}