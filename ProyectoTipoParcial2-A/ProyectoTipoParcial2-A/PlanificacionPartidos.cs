using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoTipoParcial2_A
{
    public partial class PlanificacionPartidos : Form
    {
        private SqlConnection conexion = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["conexionbd"].ConnectionString);

        public PlanificacionPartidos()
        {
            InitializeComponent();
        }

        private void PlanificacionPartidos_Load(object sender, EventArgs e)
        {
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.CustomFormat = "dd/MM/yyyy HH:mm:ss";

            CargarComboBox1();
            CargarComboBox2();

            CargarDataGridView();
        }

        private void CargarDataGridView()
        {
            conexion.Open();

            string sql = "select  fecha, clu1.nombre as nombrelocal, clu2.nombre as nombrevisita  from partidos as part" +
                "              join clubes as clu1 on clu1.codigo = part.codigoclub1  " +
                "              join clubes as clu2 on clu2.codigo = part.codigoclub2";
            SqlCommand comando = new SqlCommand(sql, conexion);

            SqlDataReader registros = comando.ExecuteReader();

            dataGridView1.Rows.Clear();
            while (registros.Read())
            {
                dataGridView1.Rows.Add(registros["nombrelocal"].ToString(), registros["nombrevisita"].ToString(), registros["fecha"].ToString());
            }

            registros.Close();
            conexion.Close();
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

        private void CargarComboBox2()
        {
            conexion.Open();

            string sql = "select codigo,nombre from clubes";
            SqlCommand comando = new SqlCommand(sql, conexion);

            SqlDataAdapter adaptador1 = new SqlDataAdapter();
            adaptador1.SelectCommand = comando;
            DataTable tabla1 = new DataTable();
            adaptador1.Fill(tabla1);

            conexion.Close();

            comboBox2.DataSource = tabla1;
            comboBox2.DisplayMember = "nombre";
            comboBox2.ValueMember = "codigo";            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text==comboBox2.Text)
            {
                MessageBox.Show("No se puede planificar que un club juegue contra sigo mismo");
            }
            else
            {
                conexion.Open();

                string sql = "insert into partidos(fecha,codigoclub1,codigoclub2) values (@fecha,@codigoclub1,@codigoclub2)";
                SqlCommand comando = new SqlCommand(sql, conexion);

                comando.Parameters.Add("@fecha", SqlDbType.DateTime).Value = dateTimePicker1.Value;
                comando.Parameters.Add("@codigoclub1", SqlDbType.Int).Value = comboBox1.SelectedValue;
                comando.Parameters.Add("@codigoclub2", SqlDbType.Int).Value = comboBox2.SelectedValue;

                comando.ExecuteNonQuery();

                comboBox1.SelectedIndex = 0;
                comboBox2.SelectedIndex = 0;

                conexion.Close();

                CargarDataGridView();

                MessageBox.Show("Se planifico el partido con los clubes seleccionados y la fecha elegida");
            }
        }
    }
}
