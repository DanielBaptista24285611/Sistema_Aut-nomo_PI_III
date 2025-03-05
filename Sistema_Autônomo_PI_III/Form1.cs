using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using KingMeServer;

namespace Sistema_Autônomo_PI_III
{
    public partial class Form1: Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnListarPartidas_Click(object sender, EventArgs e)
        {
            string retorno = Jogo.ListarPartidas("T");
            txtListarPartidas.Text = retorno;
        }
    }
}
