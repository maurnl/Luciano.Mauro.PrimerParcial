
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
            this.verListadoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nuevoViajeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.simularPasoDelTiempoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.unaHoraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.otroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pasajerosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verListadoToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.ventasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verListadoToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.informarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verListadoToolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.fechaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
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
            this.informarToolStripMenuItem,
            this.fechaToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1431, 33);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // viajesToolStripMenuItem
            // 
            this.viajesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.verListadoToolStripMenuItem,
            this.nuevoViajeToolStripMenuItem,
            this.simularPasoDelTiempoToolStripMenuItem});
            this.viajesToolStripMenuItem.Name = "viajesToolStripMenuItem";
            this.viajesToolStripMenuItem.Size = new System.Drawing.Size(49, 29);
            this.viajesToolStripMenuItem.Text = "Viajes";
            // 
            // verListadoToolStripMenuItem
            // 
            this.verListadoToolStripMenuItem.Name = "verListadoToolStripMenuItem";
            this.verListadoToolStripMenuItem.Size = new System.Drawing.Size(202, 22);
            this.verListadoToolStripMenuItem.Text = "Ver viajes";
            this.verListadoToolStripMenuItem.Click += new System.EventHandler(this.verListadoToolStripMenuItem_Click);
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
            this.pasajerosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.verListadoToolStripMenuItem1});
            this.pasajerosToolStripMenuItem.Name = "pasajerosToolStripMenuItem";
            this.pasajerosToolStripMenuItem.Size = new System.Drawing.Size(68, 29);
            this.pasajerosToolStripMenuItem.Text = "Pasajeros";
            // 
            // verListadoToolStripMenuItem1
            // 
            this.verListadoToolStripMenuItem1.Name = "verListadoToolStripMenuItem1";
            this.verListadoToolStripMenuItem1.Size = new System.Drawing.Size(142, 22);
            this.verListadoToolStripMenuItem1.Text = "Ver pasajeros";
            this.verListadoToolStripMenuItem1.Click += new System.EventHandler(this.verListadoToolStripMenuItem1_Click);
            // 
            // ventasToolStripMenuItem
            // 
            this.ventasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.verListadoToolStripMenuItem2});
            this.ventasToolStripMenuItem.Name = "ventasToolStripMenuItem";
            this.ventasToolStripMenuItem.Size = new System.Drawing.Size(53, 29);
            this.ventasToolStripMenuItem.Text = "Ventas";
            // 
            // verListadoToolStripMenuItem2
            // 
            this.verListadoToolStripMenuItem2.Name = "verListadoToolStripMenuItem2";
            this.verListadoToolStripMenuItem2.Size = new System.Drawing.Size(127, 22);
            this.verListadoToolStripMenuItem2.Text = "Ver ventas";
            this.verListadoToolStripMenuItem2.Click += new System.EventHandler(this.verListadoToolStripMenuItem2_Click);
            // 
            // informarToolStripMenuItem
            // 
            this.informarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.verListadoToolStripMenuItem3});
            this.informarToolStripMenuItem.Name = "informarToolStripMenuItem";
            this.informarToolStripMenuItem.Size = new System.Drawing.Size(67, 29);
            this.informarToolStripMenuItem.Text = "Historico";
            // 
            // verListadoToolStripMenuItem3
            // 
            this.verListadoToolStripMenuItem3.Name = "verListadoToolStripMenuItem3";
            this.verListadoToolStripMenuItem3.Size = new System.Drawing.Size(139, 22);
            this.verListadoToolStripMenuItem3.Text = "Ver historico";
            this.verListadoToolStripMenuItem3.Click += new System.EventHandler(this.verListadoToolStripMenuItem3_Click);
            // 
            // fechaToolStripMenuItem
            // 
            this.fechaToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.fechaToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlText;
            this.fechaToolStripMenuItem.Name = "fechaToolStripMenuItem";
            this.fechaToolStripMenuItem.Size = new System.Drawing.Size(71, 29);
            this.fechaToolStripMenuItem.Text = "fecha";
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(41, 29);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // lblBienvenido
            // 
            this.lblBienvenido.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblBienvenido.AutoSize = true;
            this.lblBienvenido.BackColor = System.Drawing.Color.Transparent;
            this.lblBienvenido.Font = new System.Drawing.Font("Harlow Solid Italic", 30F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lblBienvenido.Location = new System.Drawing.Point(0, 689);
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
            this.MinimumSize = new System.Drawing.Size(1300, 800);
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
        private System.Windows.Forms.ToolStripMenuItem fechaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verListadoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verListadoToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem verListadoToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem verListadoToolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
    }
}