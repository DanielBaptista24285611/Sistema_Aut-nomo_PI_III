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
        private int idPartidaAtual; //declara de maneira global idPartidaAtual
        private string[] dadosPartida; //declara de maneira global dadosPartida
        private string partida;
        private void btnCriar_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrWhiteSpace(txtSenhaPartida.Text))//exibe o erro caso o txtSenhaPartida seje nulo
            {
                lblInforma.Text = "ERRO: Senha está vazia!";
            }
            else if (string.IsNullOrWhiteSpace(txtNomeGrupo.Text)) //exibe o erro caso o txtNomeGrupo seje nulo
            {
                lblInforma.Text = "ERRO: Digite o nome do Grupo!";
            }
            else if (txtNomeGrupo.Text.Length > 20)   //exibe o erro caso o txtNomeGrupo passe de 20 caracters
            {
                lblInforma.Text = "ERRO: Nome do Grupo passa de 20 Caracters!";
            }
            else
            {
                string partida = Jogo.CriarPartida($"{txtNomePartida.Text}", $"{txtSenhaPartida.Text}", $"{txtNomeGrupo.Text}");
                lblInforma.Text= "Partida Criada!";
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
       
        public void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            partida = listBox1.SelectedItem.ToString();
            dadosPartida = partida.Split(',');

            idPartidaAtual = Convert.ToInt32(dadosPartida[0]); //idPartida convertido
            lblInforma.Text = idPartidaAtual.ToString(); //passa para o lblInforma o idPartida
            txtIdPartida.Text = lblInforma.Text;  //passa para o txtIdPartida o que está em lblInforma
        }

        private void btnListarJogadores_Click(object sender, EventArgs e)
        {
            idPartidaAtual = Convert.ToInt32(dadosPartida[0]); // converte o id da partida

            string retorno = Jogo.ListarJogadores(idPartidaAtual);  //cria uma string para receber o id
            retorno = retorno.Replace("\r", "");  // cria espaço entre cada jogador
            string[] jogadores = retorno.Split('\n');

            listBox2.Items.Clear();  //limpa os itens anteriores da listBox2 
            for (int i = 0; i < jogadores.Length; i++)
            {
                listBox2.Items.Add(jogadores[i]); //adiciona cada jogador
            }
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            
            string partida = listBox1.SelectedItem.ToString();
            dadosPartida = partida.Split(',');
            

            if (dadosPartida.Length == 0 || string.IsNullOrWhiteSpace(dadosPartida[0])) // exibe o erro de dados vazios ou incorretos
            {
                MessageBox.Show("Os dados da partida estão vazios ou incorretos.");
                return;
            }
            
             idPartidaAtual = Convert.ToInt32(dadosPartida[0]);
         

            string nomeJogador = txtNomeJogador.Text;
            string senhaPartida = txtSenhaPartida.Text;

            string jogador = Jogo.Entrar(idPartidaAtual, nomeJogador, senhaPartida);
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
