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
    public partial class ConsultaEquipo : Form
    {
        private SqlConnection conexion = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["conexionbd"].ConnectionString);

        public ConsultaEquipo()
        {
            InitializeComponent();
        }

        private void ConsultaEquipo_Load(object sender, EventArgs e)
        {
            CargarComboBox1();
        }

        private void CargarComboBox1()
        {
            conexion.Open();

            string sql = "select codigo,nombre from clubes";
            SqlCommand comando = new SqlCommand(sql, conexion);

            SqlDataAdapter adaptador1 = new SqlDataAdapter();
            adaptador1.SelectCommand = comando;
            DataTable tabla1 = new DataTable();
            adaptador1.Fill(tabla1);

            conexion.Close();

            comboBox1.DataSource = tabla1;
            comboBox1.DisplayMember = "nombre";
            comboBox1.ValueMember = "codigo";            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            conexion.Open();

            string sql = "select  fecha, clu1.nombre as nombrelocal,clu2.nombre as nombrevisita  from partidos as part" +
                "               join clubes as clu1 on clu1.codigo = part.codigoclub1   " +
                "               join clubes as clu2 on clu2.codigo = part.codigoclub2   " +
                "               where part.codigoclub1 = @codigoclub or part.codigoclub2 = @codigoclub";
            SqlCommand comando = new SqlCommand(sql, conexion);

            comando.Parameters.Add("@codigoclub", SqlDbType.Int).Value = comboBox1.SelectedValue;

            SqlDataReader registros = comando.ExecuteReader();

            dataGridView1.Rows.Clear();
            while (registros.Read())
            {
                dataGridView1.Rows.Add(registros["nombrelocal"].ToString(), registros["nombrevisita"].ToString(), registros["fecha"].ToString());
            }

            registros.Close();
            conexion.Close();
        }
    }
}
