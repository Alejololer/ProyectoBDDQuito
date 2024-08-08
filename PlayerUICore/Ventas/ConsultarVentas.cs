using DataAccess;
using DataAccess.Entities;
using Domain;
using PlayerUI.Pacientes;
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

namespace PlayerUI.Pedidos
{
    public partial class ConsultarVentas : Form
    {
        SqlConnection coneccion = new SqlConnection("Data Source=MSI;Initial Catalog=MarujaQuito;User ID=sa;Password=P@ssw0rd");
        public ConsultarVentas()
        {
            InitializeComponent();
            llenarDGV();
        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void ConsultarPedido_Load(object sender, EventArgs e)
        {

        }

        

        private void llenarDGV()
        {
            string consulta = "Select * from centralized_sales";
            SqlDataAdapter adapter = new SqlDataAdapter(consulta, coneccion);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dataGridView1.DataSource = dt;
            dataGridView1.Columns[0].HeaderText = "ID Producto";
            dataGridView1.Columns[0].Width = 50;
            dataGridView1.Columns[1].HeaderText = "Nombre";
            dataGridView1.Columns[1].Width = 100;
            dataGridView1.Columns[2].HeaderText = "Total Unidades Vendidas";
            dataGridView1.Columns[2].Width = 100;
            dataGridView1.Columns[3].HeaderText = "Total Ventas";
            dataGridView1.Columns[3].Width = 150;
        }

        
    }
}
