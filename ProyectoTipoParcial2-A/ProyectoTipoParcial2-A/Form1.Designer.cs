namespace ProyectoTipoParcial2_A
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mantenimientoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mantenimientoDeClubesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.planificaciónDePartidosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultaPartidosPorEquipoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mantenimientoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mantenimientoToolStripMenuItem
            // 
            this.mantenimientoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mantenimientoDeClubesToolStripMenuItem,
            this.planificaciónDePartidosToolStripMenuItem,
            this.consultaPartidosPorEquipoToolStripMenuItem});
            this.mantenimientoToolStripMenuItem.Name = "mantenimientoToolStripMenuItem";
            this.mantenimientoToolStripMenuItem.Size = new System.Drawing.Size(101, 20);
            this.mantenimientoToolStripMenuItem.Text = "Mantenimiento";
            // 
            // mantenimientoDeClubesToolStripMenuItem
            // 
            this.mantenimientoDeClubesToolStripMenuItem.Name = "mantenimientoDeClubesToolStripMenuItem";
            this.mantenimientoDeClubesToolStripMenuItem.Size = new System.Drawing.Size(211, 22);
            this.mantenimientoDeClubesToolStripMenuItem.Text = "Mantenimiento de Clubes";
            this.mantenimientoDeClubesToolStripMenuItem.Click += new System.EventHandler(this.mantenimientoDeClubesToolStripMenuItem_Click);
            // 
            // planificaciónDePartidosToolStripMenuItem
            // 
            this.planificaciónDePartidosToolStripMenuItem.Name = "planificaciónDePartidosToolStripMenuItem";
            this.planificaciónDePartidosToolStripMenuItem.Size = new System.Drawing.Size(211, 22);
            this.planificaciónDePartidosToolStripMenuItem.Text = "Planificación de partidos";
            this.planificaciónDePartidosToolStripMenuItem.Click += new System.EventHandler(this.planificaciónDePartidosToolStripMenuItem_Click);
            // 
            // consultaPartidosPorEquipoToolStripMenuItem
            // 
            this.consultaPartidosPorEquipoToolStripMenuItem.Name = "consultaPartidosPorEquipoToolStripMenuItem";
            this.consultaPartidosPorEquipoToolStripMenuItem.Size = new System.Drawing.Size(228, 22);
            this.consultaPartidosPorEquipoToolStripMenuItem.Text = "Consulta partidos por Equipo";
            this.consultaPartidosPorEquipoToolStripMenuItem.Click += new System.EventHandler(this.consultaPartidosPorEquipoToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mantenimientoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mantenimientoDeClubesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem planificaciónDePartidosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultaPartidosPorEquipoToolStripMenuItem;
    }
}

