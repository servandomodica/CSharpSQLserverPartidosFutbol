using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoTipoParcial2_A
{
    public partial class MantenimientoClubes : Form
    {
        //private SqlConnection conexion = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["conexionbd"].ConnectionString);

        private SqlConnection conexion = new SqlConnection("Data Source=SAM; Initial Catalog=bd1; Integrated security=True");

        public MantenimientoClubes()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            conexion.Open();

            string sql = "insert into clubes(nombre) values (@nombre)";
            SqlCommand comando = new SqlCommand(sql, conexion);

            comando.Parameters.Add("@nombre", SqlDbType.VarChar).Value = textBox1.Text;

            comando.ExecuteNonQuery();

            conexion.Close();

            textBox1.Text = "";

            MostrarClubes();

            MessageBox.Show("El club fue cargado");
        }

        private void MostrarClubes()
        {
            conexion.Open();

            string sql = "select codigo,nombre from clubes";
            SqlCommand comando = new SqlCommand(sql, conexion);

            SqlDataReader registros = comando.ExecuteReader();

            dataGridView1.Rows.Clear();
            while (registros.Read())
            {
                dataGridView1.Rows.Add(registros["codigo"].ToString(), registros["nombre"].ToString());
            }

            registros.Close();
            conexion.Close();
        }

        private void MantenimientoClubes_Load(object sender, EventArgs e)
        {
            MostrarClubes();
        }
    }
}
