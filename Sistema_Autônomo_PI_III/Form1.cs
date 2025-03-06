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
        }
        private void btnCriar_Click(object sender, EventArgs e)
        {
            string partida = Jogo.CriarPartida($"{txtNomePartida.Text}", $"{txtSenhaPartida.Text}", $"{txtNomeGrupo.Text}");

            lblInforma.Text = "Partida Criada!";
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


            for (int i = 0; i < partidas.Length; i++)
            {
                listBox1.Items.Add(partidas[i]);

            }

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string partida = listBox1.ToString();
            string[] dadosPartida = partida.Split('\n');


        }

        private void btnListarJogadores_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem == null)
            {
                MessageBox.Show("Por favor, selecione uma partida.");
                return;
            }

            string partida = listBox1.SelectedItem.ToString();
            string[] dadosPartida = partida.Split('\n');

            int idPartida = Convert.ToInt32(dadosPartida[0]);

            string retornoJ = Jogo.ListarJogadores(idPartida);
            retornoJ = retornoJ.Replace("\r", "");
            string[] jogadores = retornoJ.Split('\n');

            listBox2.Items.Clear(); 
            foreach (string jogador in jogadores)
            {
                listBox2.Items.Add(jogador);
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

            if (string.IsNullOrEmpty(jogador))
            {
                MessageBox.Show("Erro ao entrar na partida. Verifique suas credenciais.");
            }
            else
            {
                MessageBox.Show($"Jogador {jogador} entrou na partida com sucesso.");
            }
        }
    }
}
