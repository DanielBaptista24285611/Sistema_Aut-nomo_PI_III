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
    public partial class IniciarPartida : Form
    {
        public IniciarPartida()
        {
            Form1 form = new Form1();
            InitializeComponent();
           // btnEn
        }

        
        int idPartidaAtual; //declara de maneira global idPartidaAtual
        string[] dadosPartida; //declara de maneira global dadosPartida
        private void btnExibirCartas_Click(object sender, EventArgs e)
        {
            int idJogador = Int32.Parse(txtIDjogador.Text);

            lblCartas.Text = Jogo.ListarCartas(idJogador, txtSenhaJogador.Text);
        }
        private void btnIniciarJogo_Click(object sender, EventArgs e)
        {
            int idJogador = Int32.Parse(txtIDjogador.Text);
            string retorno;
            retorno = Jogo.Iniciar(idJogador, txtSenhaJogador.Text);
            lblIDjogadorVez.Text = retorno;
          //  lblNomeJogadorVez.Text = $" {txtNomeJogador.Text}";
            MessageBox.Show("Partida Iniciada!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnVerificarVez_Click(object sender, EventArgs e)
        {
            idPartidaAtual = Convert.ToInt32(dadosPartida[0]); // converte o id da partida

            string retorno = Jogo.VerificarVez(idPartidaAtual);  //cria uma string para receber o id
            retorno = retorno.Replace("\r", "");  // cria espaço entre cada verificaçao
            string[] verificar = retorno.Split('\n');

            lstVerificarVez.Items.Clear();  //limpa os itens anteriores da listbox
            for (int i = 0; i < verificar.Length; i++)
            {
                lstVerificarVez.Items.Add(verificar[i]); //Verifica a vez do jogador
            }

        }

        private void btnPersonagens_Click(object sender, EventArgs e)
        {
            Personagens personagem = new Personagens();
            personagem.ShowDialog();
        }
    }
}
