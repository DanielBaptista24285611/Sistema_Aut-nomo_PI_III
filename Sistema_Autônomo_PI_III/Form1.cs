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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            lblversao.Text= Jogo.versao;
        }
        private int idPartidaAtual;
        private void btnCriar_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrWhiteSpace(txtSenhaPartida.Text))
            {
                lblInforma.Text = "ERRO: Senha está vazia!";
            }
            else if (string.IsNullOrWhiteSpace(txtNomeGrupo.Text))
            {
                lblInforma.Text = "ERRO: Digite o nome do Grupo!";
            }
            else if (txtNomeGrupo.Text.Length > 20)
            {
                lblInforma.Text = "ERRO: Nome do Grupo passa de 20 Caracters!";
            }
            else
            {
                string partida = Jogo.CriarPartida($"{txtNomePartida.Text}", $"{txtSenhaPartida.Text}", $"{txtNomeGrupo.Text}");

                lblInforma.Text = "Partida Criada!";
            }
        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnListarPartidas_Click(object sender, EventArgs e)
        {
            string retorno = Jogo.ListarPartidas("T");


            retorno = retorno.Replace("\r", "");
            retorno = retorno.Substring(0, retorno.Length - 1);
            string[] partidas = retorno.Split('\n');

            listBox1.Items.Clear();
            for (int i = 0; i < partidas.Length; i++)
            {
                listBox1.Items.Add(partidas[i]);

            }

        }
        private string[] DadosPartida;
        public void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string partida = listBox1.SelectedItem.ToString();
            DadosPartida = partida.Split(',');

             idPartidaAtual = Convert.ToInt32(DadosPartida[0]);
            lblInforma.Text= idPartidaAtual.ToString();
           // label6.Text = idPartidaAtual.ToString();
            txtIdPartida.Text= lblInforma.Text;


        }

        private void btnListarJogadores_Click(object sender, EventArgs e)
        {
            idPartidaAtual = Convert.ToInt32(DadosPartida[0]);

            string retorno = Jogo.ListarJogadores(idPartidaAtual);
            retorno = retorno.Replace("\r", "");
            string[] jogadores = retorno.Split('\n');

            listBox2.Items.Clear();
            for (int i = 0; i < jogadores.Length; i++)
            {
                listBox2.Items.Add(jogadores[i]);
            }
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem == null)
            {
                MessageBox.Show("Por favor, selecione uma partida.");
                return;
            }

            string partida = listBox1.SelectedItem.ToString();
            string[] dadosPartida = partida.Split(',');
            

            if (dadosPartida.Length == 0 || string.IsNullOrWhiteSpace(dadosPartida[0]))
            {
                MessageBox.Show("Os dados da partida estão vazios ou incorretos.");
                return;
            }
            
            int idPartida = Convert.ToInt32(dadosPartida[0]);
         

            string nomeJogador = txtNomeJogador.Text;
            string senhaPartida = txtSenhaPartida.Text;

            string jogador = Jogo.Entrar(idPartida, nomeJogador, senhaPartida);
            string[] dadosJogador = jogador.Split(',');

            if (dadosJogador.Length == 2)
            {
                lblidJogador.Text = $"ID do Jogador: {dadosJogador[0]}";   // Primeiro valor (ID) no lblIdJogador
                lblsenha.Text = $"Senha: {dadosJogador[1]}";        // Segundo valor (senha) no lblSenha
            }
            else
            {
                lblerro.Text = "Erro: Retorno inesperado de 'Jogo.Entrar'."; // Exibe mensagem de erro em caso de problema
            }
        }

    }
}
