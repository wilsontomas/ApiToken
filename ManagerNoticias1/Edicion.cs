using ManagerNoticias1.Models;
using Newtonsoft.Json;
using NoticiasManager.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ManagerNoticias1
{
    public partial class Edicion : Form
    {
        public Edicion()
        {
            InitializeComponent();
        }
        public int Id { get; set; }
        private async void Edicion_Load(object sender, EventArgs e)
        {
            HttpClient cliente = new HttpClient();
            cliente.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("bearer", TokenStorage.Instance.token);

            var HttpRespuestaPais = await cliente.GetAsync("https://localhost:44394/api/Noticias/ObtenerPais");
            // var respuestaPais =JsonSerializer.Deserialize<List<Pais>>(await HttpRespuestaPais.Content.ReadAsStringAsync(), options);
            var respuestaPais = JsonConvert.DeserializeObject<List<Pais>>(await HttpRespuestaPais.Content.ReadAsStringAsync());
            PaisC.DisplayMember = "NombrePais";
            PaisC.ValueMember = "IdPais";
            PaisC.DataSource = respuestaPais;

            var HttpRespuestaCategoria = await cliente.GetAsync("https://localhost:44394/api/Noticias/ObtenerCategoria");
            // var respuestaPais =JsonSerializer.Deserialize<List<Pais>>(await HttpRespuestaPais.Content.ReadAsStringAsync(), options);
            var respuestaCategoria = JsonConvert.DeserializeObject<List<Categoria>>(await HttpRespuestaCategoria.Content.ReadAsStringAsync());
            CategoriaC.DisplayMember = "NombreCategoria";
            CategoriaC.ValueMember = "IdCategoria";
            CategoriaC.DataSource = respuestaCategoria;

            //cargamos los datos de edicion

            var HttprespuestaEdicion = await cliente.GetAsync("https://localhost:44394/api/Noticias/ObtenerNoticiaPorId?Id="+this.Id);
            var respuestaEdicion = JsonConvert.DeserializeObject<ArticulosNoticias>(await HttprespuestaEdicion.Content.ReadAsStringAsync());
            Articulo.Text = respuestaEdicion.Articulo;
            Titulo.Text = respuestaEdicion.Titulo;
          //  MessageBox.Show(this.Id.ToString()); ;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var noticias = new Noticias();
            this.Hide();
            noticias.ShowDialog();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(Titulo.Text) || !string.IsNullOrEmpty(Articulo.Text))
            {

                HttpClient cliente = new HttpClient();
                cliente.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("bearer", TokenStorage.Instance.token);
                var ArticuloModel1 = new ArticuloModel()
                {
                    IdNoticia = this.Id,
                    Titulo = Titulo.Text,
                    Articulo = Articulo.Text,
                    IdCategoria = int.Parse(CategoriaC.SelectedValue.ToString()),
                    IdPais = int.Parse(PaisC.SelectedValue.ToString())
                };

                var respuesta = await cliente.PostAsJsonAsync("https://localhost:44394/api/Noticias/EditarNoticia", ArticuloModel1);
                var result = await respuesta.Content.ReadAsStringAsync();
                MessageBox.Show(result);
                var noticias = new Noticias();
                this.Hide();
                noticias.ShowDialog();
               
            }
            else
            {
                MessageBox.Show("Los campos deben estar llenos");
            }
        }
    }
}
