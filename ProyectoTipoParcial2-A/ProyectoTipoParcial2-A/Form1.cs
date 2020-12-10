using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoTipoParcial2_A
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void mantenimientoDeClubesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MantenimientoClubes m = new MantenimientoClubes();
            m.ShowDialog();
        }

        private void planificaciónDePartidosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PlanificacionPartidos p = new PlanificacionPartidos();
            p.ShowDialog();
        }

        private void consultaPartidosPorEquipoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConsultaEquipo c = new ConsultaEquipo();
            c.ShowDialog();
        }
    }
}
