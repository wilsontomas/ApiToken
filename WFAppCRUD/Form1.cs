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

namespace WFAppCRUD
{
    public partial class Form1 : Form
    {
        SqlConnection conexion = new SqlConnection("Data Source=DESKTOP-V32QJTJ\\SQLEXPRESS;Initial Catalog=Noticias;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try {
                /*  conexion.Open();
                  SqlCommand comando = new SqlCommand("InsertarNoticia", conexion);
                  comando.CommandType = CommandType.StoredProcedure;
                  comando.Parameters.AddWithValue("@Titulo",Titulo.Text);
                  comando.Parameters.AddWithValue("@Articulo",Articulo.Text);
                  comando.Parameters.AddWithValue("@CategoriaId",Categoria.SelectedItem);
                  comando.Parameters.AddWithValue("@PaisId",Pais.SelectedItem);
                  comando.ExecuteNonQuery();
                  conexion.Close();*/
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
