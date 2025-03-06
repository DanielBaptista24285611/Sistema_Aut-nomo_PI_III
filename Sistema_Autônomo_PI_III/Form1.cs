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
        private void btnCriar_Click(object sender, EventArgs e)
        {
            Jogo.CriarPartida($"{txtNomePartida.Text}", $"{txtSenhaPartida.Text}", $"{txtNomeGrupo.Text}");

            lblInforma.Text = "Partida Criada!";
        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnListarPartidas_Click(object sender, EventArgs e)
        {
            string retorno = Jogo.ListarPartidas("T");
    

            retorno = retorno.Replace("\r","");
            retorno = retorno.Substring(0, retorno.Length - 1);
            string[] partidas = retorno.Split('\n');


            for(int i = 0; i < partidas.Length; i++)
            {
                listBox1.Items.Add(partidas[i]);

            }

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string partida = listBox1.ToString();
            string[] dadosPartida = partida.Split('\n');

            
        }

    }
}
