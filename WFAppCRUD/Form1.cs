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
using WFAppCRUD.Models;

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
                conexion.Open();
                  SqlCommand comando = new SqlCommand("InsertarNoticia", conexion);
                  comando.CommandType = CommandType.StoredProcedure;
                  comando.Parameters.AddWithValue("@Titulo",Titulo.Text);
                  comando.Parameters.AddWithValue("@Articulo",Articulo.Text);
                  comando.Parameters.AddWithValue("@CategoriaId",(int)Categoria.SelectedValue);
                  comando.Parameters.AddWithValue("@PaisId",(int)Pais.SelectedValue);
                  comando.ExecuteNonQuery();
                  conexion.Close();
               // MessageBox.Show(Pais.SelectedValue.ToString());



                //cargamos las noticias
                conexion.Open();
                SqlCommand comando3 = new SqlCommand("ObtenerNoticiasModel", conexion);
                comando3.CommandType = CommandType.StoredProcedure;
                var listaNoticias = new List<ArticuloNoticias>();
                var resultado2 = comando3.ExecuteReader();

                while (resultado2.Read())
                {
                    listaNoticias.Add(new Models.ArticuloNoticias { IdNoticias = resultado2.GetInt32(0), Titulo = resultado2.GetString(1), Articulo = resultado2.GetString(2), NombreCategoria = resultado2.GetString(4), NombrePais = resultado2.GetString(5) });
                }
                conexion.Close();
                dataGrid.DataSource = listaNoticias;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load_1(object sender, EventArgs e)
        {
            //cargamos los paises
            conexion.Open();
            SqlCommand comando1 = new SqlCommand("ObtenerPais", conexion);
            comando1.CommandType = CommandType.StoredProcedure;
            var listaPais = new List<Pais>();
            var resultado = comando1.ExecuteReader();

            while (resultado.Read()) {
                listaPais.Add(new Models.Pais { IdPais=resultado.GetInt32(0), NombrePais=resultado.GetString(1) });
            }
            conexion.Close();
            Pais.DisplayMember = "NombrePais";
            Pais.ValueMember = "IdPais";
            Pais.DataSource = listaPais;

            //cargamos las categorias
            conexion.Open();
            SqlCommand comando2 = new SqlCommand("ObtenerCategoria", conexion);
            comando2.CommandType = CommandType.StoredProcedure;
            var listaCategoria = new List<Categoria>();
            var resultado1 = comando2.ExecuteReader();

            while (resultado1.Read())
            {
                listaCategoria.Add(new Models.Categoria { IdCategoria = resultado1.GetInt32(0), NombreCategoria = resultado1.GetString(1) });
            }
            conexion.Close();
            Categoria.DisplayMember = "NombreCategoria";
            Categoria.ValueMember = "IdCategoria";
            Categoria.DataSource = listaCategoria;

            //cargamos las noticias
            conexion.Open();
            SqlCommand comando3 = new SqlCommand("ObtenerNoticiasModel", conexion);
            comando3.CommandType = CommandType.StoredProcedure;
            var listaNoticias = new List<ArticuloNoticias>();
            var resultado2 = comando3.ExecuteReader();

            while (resultado2.Read())
            {
                listaNoticias.Add(new Models.ArticuloNoticias { IdNoticias = resultado2.GetInt32(0), Titulo = resultado2.GetString(1), Articulo=resultado2.GetString(2),NombreCategoria=resultado2.GetString(4), NombrePais=resultado2.GetString(5) });
            }
            conexion.Close();
            dataGrid.DataSource = listaNoticias;
        }
    }
}
