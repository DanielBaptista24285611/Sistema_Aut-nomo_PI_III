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
        int idPartidaAtual; //declara de maneira global idPartidaAtual
        string[] dadosPartida; //declara de maneira global dadosPartida
        string partida;
        int idJogador;
        string senhaJogador;

        void btnCriar_Click(object sender, EventArgs e)
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

            lstPartidas.Items.Clear();
            for (int i = 0; i < partidas.Length; i++)
            {
                lstPartidas.Items.Add(partidas[i]);

            }

        }

        private void btnListarJogadores_Click(object sender, EventArgs e)
        {
            idPartidaAtual = Convert.ToInt32(dadosPartida[0]); // converte o id da partida

            string retorno = Jogo.ListarJogadores(idPartidaAtual);  //cria uma string para receber o id
            retorno = retorno.Replace("\r", "");  // cria espaço entre cada jogador
            string[] jogadores = retorno.Split('\n');

            lstJogadores.Items.Clear();  //limpa os itens anteriores da listbox
            for (int i = 0; i < jogadores.Length; i++)
            {
                lstJogadores.Items.Add(jogadores[i]); //adiciona cada jogador
            }
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            string nomeJogador = txtNomeJogador.Text;
            string senhaPartida = txtSenhaPartida.Text;

            switch (VerificaEntrarPartida(nomeJogador, senhaPartida, txtIdPartida.Text))
            {
                case 0:
                    break;
                case 1:
                    MessageBox.Show("Informe o ID da partida!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                case 2:
                    MessageBox.Show("Informe a senha da partida!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                case 3:
                    MessageBox.Show("Preencha o nome de jogador!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;   
            }

            string jogador = Jogo.Entrar(idPartidaAtual, nomeJogador, senhaPartida);
            string[] dadosJogador = jogador.Split(',');

            if (dadosJogador.Length == 2)
            {
                lblidJogador.Text = $"ID do Jogador: {dadosJogador[0]}";   // Primeiro valor (ID) no lblIdJogador
                lblsenha.Text = $"Senha: {dadosJogador[1]}";        // Segundo valor (senha) no lblSenha
                txtIDjogador.Text = dadosJogador[0];    // Preenche a textbox com o id do jogador
                txtSenhaJogador.Text = dadosJogador[1]; // Preenche a textbox com a senha do jogador
            }
            else
            {
                MessageBox.Show("Erro: Partida não encontrada!.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error); // Exibe mensagem de erro em caso de problema
            }
        }
        private void lstPartidas_SelectedIndexChanged(object sender, EventArgs e)
        {
            partida = lstPartidas.SelectedItem.ToString();
            dadosPartida = partida.Split(',');

            idPartidaAtual = Convert.ToInt32(dadosPartida[0]); //idPartida convertido
            lblInforma.Text = idPartidaAtual.ToString(); //passa para o lblInforma o idPartida
            txtIdPartida.Text = lblInforma.Text;  //passa para o txtIdPartida o que está em lblInforma
        }

        private void btnExibirCartas_Click(object sender, EventArgs e)
        {
            idJogador = Int32.Parse(txtIDjogador.Text);


            lblCartas.Text = Jogo.ListarCartas(idJogador, senhaJogador);
        }

        private void lstJogadores_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lstVerificarVez_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        public int VerificaEntrarPartida(string nomeJogador, string senhaPartida, string idPartida)
        {
            if (string.IsNullOrWhiteSpace(idPartida))
                return 1;

            if (string.IsNullOrWhiteSpace(senhaPartida))
                return 2;

            if (string.IsNullOrWhiteSpace(nomeJogador))
                return 3;

            return 0;
        }

        private void btnVerificarVez_Click(object sender, EventArgs e)
        {
            string dados = Jogo.VerificarVez(idPartidaAtual);

            string[] dadosSeparados = dados.Split(',');

            lstVerificarVez.Text = dadosSeparados[0];
        }

        private void btnIniciarJogo_Click(object sender, EventArgs e)
        {
            Jogo.Iniciar(idJogador, txtSenhaJogador.Text);
            MessageBox.Show("Partida Iniciada!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
