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
using System.Text.Json;
namespace ManagerNoticias1
{
    public partial class Clave : Form
    {
        public Clave()
        {
            InitializeComponent();
        }

        private async void Ingresar_Click(object sender, EventArgs e)
        {
           if(await Login(Usuario.Text, clavetxt.Text))
            {
                this.Hide();
                Noticias noticias = new Noticias();
                noticias.ShowDialog();
            }
        }

        public async Task<bool> Login(string user, string clave1)
        {
            var cliente = new HttpClient();
            //var data = new { nombre = user, clave = clave1 };
            var persona = new Datos() { nombre=user,clave=clave1 };
            var formContent = new FormUrlEncodedContent(new[]
            {
                new KeyValuePair<string, string>("nombre", user),
                new KeyValuePair<string, string>("clave", clave1)
            });
            //HttpContent contenido = new StringContent(data.ToString(),System.Text.Encoding.UTF8,"Application/json");
            var HttpRespuestaToken = await cliente.PostAsync("https://localhost:44394/api/Cuenta/Autenticar", formContent);
            try
            {
                var respuestaToken = JsonSerializer.Deserialize<Token>(await HttpRespuestaToken.Content.ReadAsStringAsync());
                TokenStorage.Instance.token = respuestaToken.token;
                return true;
            }catch(Exception ex)
            {
                Mensaje.Text = "CREDENCIALES INVALIDAS";
               // MessageBox.Show(ex.Message);
                return false;
            }
            
         
        }
    }
}
