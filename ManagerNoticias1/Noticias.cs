using NoticiasManager.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ManagerNoticias1
{
    public partial class Noticias : Form
    {
        public Noticias()
        {
            InitializeComponent();
        }

        private void Noticias_Load(object sender, EventArgs e)
        {
            MessageBox.Show(TokenStorage.Instance.token);
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
