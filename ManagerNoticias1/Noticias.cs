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
using ApiJWT.Models;

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
            MessageBox.Show(TokenStorage.Instance.token);
            HttpClient cliente = new HttpClient();
            cliente.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("bearer",TokenStorage.Instance.token);
           // cliente.DefaultRequestHeaders.Add("Access-Control-Allow-Origin", "http://localhost:3000");
            var HttpRespuestaPais = await cliente.GetAsync("https://localhost:44394/api/Noticias/ObtenerPais");
            var respuestaPais =JsonSerializer.Deserialize<List<Pais>>(await HttpRespuestaPais.Content.ReadAsStringAsync()).ToList();
            Pais.DataSource = respuestaPais;
            foreach(var item in respuestaPais)
            {
                MessageBox.Show(item.NombrePais);
            }
            
        }

        private void salir_Click(object sender, EventArgs e)
        {
            TokenStorage.Instance.token = "";
            this.Hide();
            Clave form1 = new Clave();
            form1.ShowDialog();
        }
    }
}
