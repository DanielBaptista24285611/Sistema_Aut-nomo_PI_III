using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_Autônomo_PI_III
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnLobby_Click(object sender, EventArgs e)
        {
            /*Personagens personagensForm = new Personagens(); // Cria uma instância de Personagens
            Form1 form1 = new Form1(personagensForm);
            form1.ShowDialog();*/

            GerenciarPartida Partida= new GerenciarPartida();
            Partida.ShowDialog();
            this.Hide();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCredito_Click(object sender, EventArgs e)
        {
            Credito creditoForm = new Credito(); // Cria uma instância de Credito
            creditoForm.ShowDialog(); // Exibe o formulário de crédito como um diálogo modal
        }
    }
}
