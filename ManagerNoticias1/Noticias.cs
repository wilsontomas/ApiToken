using NoticiasManager.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Http.Headers;
using System.Text.Json;
using Newtonsoft.Json;
using ManagerNoticias1.Models;

namespace ManagerNoticias1
{
    public partial class Noticias : Form
    {
        public Noticias()
        {
            InitializeComponent();
        }

        private async void Noticias_Load(object sender, EventArgs e)
        {
            //MessageBox.Show(TokenStorage.Instance.token);
            HttpClient cliente = new HttpClient();
            cliente.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("bearer",TokenStorage.Instance.token);
          
            var HttpRespuestaPais = await cliente.GetAsync("https://localhost:44394/api/Noticias/ObtenerPais");
           // var respuestaPais =JsonSerializer.Deserialize<List<Pais>>(await HttpRespuestaPais.Content.ReadAsStringAsync(), options);
            var respuestaPais = JsonConvert.DeserializeObject<List<Pais>>(await HttpRespuestaPais.Content.ReadAsStringAsync());
            Pais.DisplayMember = "NombrePais";
            Pais.ValueMember = "IdPais";
            Pais.DataSource = respuestaPais;
            
            var HttpRespuestaCategoria = await cliente.GetAsync("https://localhost:44394/api/Noticias/ObtenerCategoria");
           // var respuestaPais =JsonSerializer.Deserialize<List<Pais>>(await HttpRespuestaPais.Content.ReadAsStringAsync(), options);
            var respuestaCategoria = JsonConvert.DeserializeObject<List<Categoria>>(await HttpRespuestaCategoria.Content.ReadAsStringAsync());
            Categoria.DisplayMember = "NombreCategoria";
            Categoria.ValueMember = "IdCategoria";
            Categoria.DataSource = respuestaCategoria;

            var HttpRespuestaNoticias = await cliente.GetAsync("https://localhost:44394/api/Noticias/ObtenerNoticias");
            // var respuestaPais =JsonSerializer.Deserialize<List<Pais>>(await HttpRespuestaPais.Content.ReadAsStringAsync(), options);
            var respuestaNoticias = JsonConvert.DeserializeObject<List<ArticulosNoticias>>(await HttpRespuestaNoticias.Content.ReadAsStringAsync());
            
            DataGrid.DataSource = respuestaNoticias;




        }

        private void salir_Click(object sender, EventArgs e)
        {
            TokenStorage.Instance.token = "";
            this.Hide();
            Clave form1 = new Clave();
            form1.ShowDialog();
        }

        private async void Guardar_Click(object sender, EventArgs e)
        {
           
            if (!string.IsNullOrEmpty(Titulo.Text) || !string.IsNullOrEmpty(Articulo.Text))
            {

                 HttpClient cliente = new HttpClient();
                 cliente.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("bearer", TokenStorage.Instance.token);
                     // var parametros = new  { Titulo=Titulo.Text, Articulo=Articulo.Text, CategoriaId= (int)Categoria.SelectedValue, PaisId=(int)Pais.SelectedValue };
                     var ArticuloModel1 = new ArticuloModel() {
                         Titulo = Titulo.Text, 
                         Articulo = Articulo.Text,
                         IdCategoria = int.Parse(Categoria.SelectedValue.ToString()),
                         IdPais = int.Parse(Pais.SelectedValue.ToString()) };

                 var respuesta =  await cliente.PostAsJsonAsync("https://localhost:44394/api/Noticias/InsertarNoticia", ArticuloModel1);
                     var result = await respuesta.Content.ReadAsStringAsync();
                     MessageBox.Show(result);
                //recargamos
                var HttpRespuestaNoticias = await cliente.GetAsync("https://localhost:44394/api/Noticias/ObtenerNoticias");
                var respuestaNoticias = JsonConvert.DeserializeObject<List<ArticulosNoticias>>(await HttpRespuestaNoticias.Content.ReadAsStringAsync());

                DataGrid.DataSource = respuestaNoticias;
                //MessageBox.Show(Categoria.SelectedValue.ToString());
                // MessageBox.Show(Pais.SelectedValue.ToString());
            }
                else
                {
                    MessageBox.Show("Los campos deben estar llenos");
                }
            }
    }
}
