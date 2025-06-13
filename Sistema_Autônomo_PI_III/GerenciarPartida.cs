using KingMeServer;
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
    public partial class GerenciarPartida : Form
    {
        private int idPartidaAtual;
        private string[] dadosJogador;
        private string[] dadosPartida;
        private string partida;
        // ID → senha
        Dictionary<string, string> jogadoresLogados = new Dictionary<string, string>();



        public GerenciarPartida()
        {
            InitializeComponent();
            txtNomeGrupo.Text = "CavaleirosCanterbury";
            lblversao.Text = Jogo.versao;

            //Opções de filtro lista de partidas
            cboFiltroLista.Items.Add("Todas");
            cboFiltroLista.Items.Add("Aberta");
            cboFiltroLista.Items.Add("Jogando");
            cboFiltroLista.Items.Add("Encerradas");
            cboFiltroLista.SelectedIndex = 0;
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {

        }

        private void lblSenhaPartida_Click(object sender, EventArgs e)
        {

        }

        private void lblsenha_Click(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void btnCriar_Click(object sender, EventArgs e)
        {
            try
            {
                // Chama o método para criar a partida
                string retorno = Jogo.CriarPartida(
                    txtNomePartida.Text,
                    txtSenhaPartida.Text,
                    txtNomeGrupo.Text);

                // Verifica se houve erro
                if (retorno.StartsWith("ERRO") || retorno.Contains("erro"))
                {
                    lblInforma.Text = retorno;
                    txtIdPartida.Text = ""; // Limpa o ID em caso de erro
                }
                else
                {
                    // Atualiza o campo com o ID da partida criada
                    txtIdPartida.Text = retorno;
                    lblInforma.Text = "Partida Criada com Sucesso!";

                }
            }
            catch (Exception ex)
            {
                lblInforma.Text = $"Erro ao criar partida: {ex.Message}";
                txtIdPartida.Text = ""; // Limpa o ID em caso de erro
            }
        }

        private void btnListarPartidas_Click(object sender, EventArgs e)
        {
            lstPartidas.Items.Clear();

            string retorno = Jogo.ListarPartidas(cboFiltroLista.Text.Substring(0, 1)).Replace("\r", "").Trim();
            foreach (var partida in retorno.Split('\n'))
            {
                if (!string.IsNullOrWhiteSpace(partida))
                    lstPartidas.Items.Add(partida);
            }

            // Agora tenta selecionar a partida que tem o ID do txtIdPartida
            string idAlvo = txtIdPartida.Text.Trim();
            for (int i = 0; i < lstPartidas.Items.Count; i++)
            {
                string item = lstPartidas.Items[i].ToString();
                string[] dados = item.Split(',');

                if (dados.Length >= 1 && dados[0].Trim() == idAlvo)
                {
                    lstPartidas.SelectedIndex = i;
                    break;
                }
            }
        }


        private void btnEntrar_Click_1(object sender, EventArgs e)
        {
            if (VerificaEntrarPartida(txtNomeJogador.Text, txtSenhaPartida.Text, txtIdPartida.Text) != 0)
            {
                MessageBox.Show("Preencha todos os campos corretamente.");
                return;
            }

            idPartidaAtual = int.Parse(txtIdPartida.Text);
            string resposta = Jogo.Entrar(idPartidaAtual, txtNomeJogador.Text, txtSenhaPartida.Text);

            if (resposta.StartsWith("ERRO") || resposta.Contains("erro"))
            {
                lblInforma.Text = resposta;
                return;
            }

            // Aqui entra a mágica: pega ID e Senha
            string[] dadosJogador = resposta.Split(','); // Ex: "123,abc456"
            if (dadosJogador.Length < 2)
            {
                MessageBox.Show("Retorno inválido do servidor.");
                return;
            }

            string idJogador = dadosJogador[0];
            string senhaJogador = dadosJogador[1];

            lblInforma2.Text = "Entrou na Partida!";

            // Abre diretamente a tela de Personagens e depois Form1
            Personagens personagensForm = new Personagens();
            string nomeJogador = txtNomeJogador.Text;
            var form1 = new ExecutarPartida(personagensForm, idJogador, senhaJogador, nomeJogador,idPartidaAtual);
            form1.NomeJogador = txtNomeJogador.Text;
            form1.Show();
                
        }


        private void btnListarJogadores_Click(object sender, EventArgs e)
        {
            if (idPartidaAtual == 0) return;
            lstJogadores.Items.Clear();
            string retorno = Jogo.ListarJogadores(idPartidaAtual).Replace("\r", "");
            foreach (var jogador in retorno.Split('\n'))
            {
                if (!string.IsNullOrWhiteSpace(jogador))
                    lstJogadores.Items.Add(jogador);
            }


        }

        private int VerificaEntrarPartida(string nomeJogador, string senhaPartida, string idPartida)
        {
            if (string.IsNullOrWhiteSpace(idPartida)) return 1;
            if (string.IsNullOrWhiteSpace(senhaPartida)) return 2;
            if (string.IsNullOrWhiteSpace(nomeJogador)) return 3;
            return 0;
        }

        private void lblversao_Click(object sender, EventArgs e)
        {

        }

        private void lstPartidas_SelectedIndexChanged(object sender, EventArgs e)
        {
        
            if (lstPartidas.SelectedItem != null)
            {
                string itemSelecionado = lstPartidas.SelectedItem.ToString();
                string[] dados = itemSelecionado.Split(',');

                if (dados.Length > 0)
                {
                    txtIdPartida.Text = dados[0].Trim(); // ID da partida é o primeiro campo
                }
            }
        }

    }
}

