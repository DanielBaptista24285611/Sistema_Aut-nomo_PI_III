// Form1.cs - versão final otimizada com automação funcionando
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using KingMeServer;

namespace Sistema_Autônomo_PI_III
{
    public partial class Form1 : Form
    {
        private Personagens personagensForm;
        private Rodada rodadaAtual;
        private Timer timerAutomatizador;
        private List<string> personagensTabuleiro = new List<string>();
        private List<string> jogadores = new List<string>();
        private int idPartidaAtual;
        private string[] dadosPartida;
        private string partida;

        public Form1(Personagens formPersonagens)
        {
            InitializeComponent();
            lblversao.Text = Jogo.versao;
            txtNomeGrupo.Text = "CavaleirosCanterbury";
            rodadaAtual = new Rodada(1, "");
            personagensForm = formPersonagens;
            AtualizarListasIniciais();
            InicializarTimer();
        }

        private void InicializarTimer()
        {
            timerAutomatizador = new Timer();
            timerAutomatizador.Interval = 3000;
            timerAutomatizador.Tick += tmrAutomatizador_Tick;
        }

        private void tmrAutomatizador_Tick(object sender, EventArgs e)
        {
            AutomatizarEtapas();

        }

private void AutomatizarEtapas()
{
    if (rodadaAtual == null) return;

    if (rodadaAtual.FaseAtual == FaseRodada.Promocao && personagensTabuleiro.Any())
    {
        string personagem = personagensTabuleiro[0];
        if (rodadaAtual.PromoverPersonagem(personagem))
        {
            personagensTabuleiro.RemoveAt(0);
            AtualizarStatusRodada();
        }
    }
    else if (rodadaAtual.FaseAtual == FaseRodada.Votacao && jogadores.Any())
    {
        foreach (var jogador in jogadores)
            rodadaAtual.RegistrarVoto(jogador, true);

        AtualizarStatusRodada();

        if (rodadaAtual.TodosVotaram(jogadores))
        {
            string resultado = rodadaAtual.ResultadoVotacao();
            MessageBox.Show($"Resultado da votação: {resultado}", "Fim da Votação");
        }
    }
}



        private void AtualizarListasIniciais()
        {
            lstSetores.Items.Clear();
            foreach (var setor in Jogo.ListarSetores().Split('\n'))
                if (!string.IsNullOrWhiteSpace(setor))
                    lstSetores.Items.Add(setor);

            lstPersonagens.Items.Clear();
            foreach (var personagem in Jogo.ListarPersonagens().Split('\n'))
                if (!string.IsNullOrWhiteSpace(personagem))
                    lstPersonagens.Items.Add(personagem);
        }

        private void AtualizarStatusRodada()
        {
            lstVerificarVez.Items.Clear();
            lstVerificarVez.Items.Add(rodadaAtual.ToString());
        }

        private void btnCriar_Click(object sender, EventArgs e)
        {
            string retorno = Jogo.CriarPartida(txtNomePartida.Text, txtSenhaPartida.Text, txtNomeGrupo.Text);
            lblInforma.Text = retorno.StartsWith("ERRO") || retorno.Contains("erro") ? retorno : "Partida Criada!";
        }

        private void btnListarPartidas_Click(object sender, EventArgs e)
        {
            lstPartidas.Items.Clear();
            string retorno = Jogo.ListarPartidas("T").Replace("\r", "").Trim();
            foreach (var partida in retorno.Split('\n'))
                if (!string.IsNullOrWhiteSpace(partida))
                    lstPartidas.Items.Add(partida);
        }

        private void btnEntrar_Click(object sender, EventArgs e)
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

            var dadosJogador = resposta.Split(',');
            txtIDjogador.Text = dadosJogador[0];
            txtSenhaJogador.Text = dadosJogador[1];
            lblidJogador.Text = $"ID: {dadosJogador[0]}";
            lblsenha.Text = $"Senha: {dadosJogador[1]}";

            jogadores.Add(txtNomeJogador.Text);
            rodadaAtual = new Rodada(1, txtNomeJogador.Text);
            AtualizarStatusRodada();
        }

        private int VerificaEntrarPartida(string nomeJogador, string senhaPartida, string idPartida)
        {
            if (string.IsNullOrWhiteSpace(idPartida)) return 1;
            if (string.IsNullOrWhiteSpace(senhaPartida)) return 2;
            if (string.IsNullOrWhiteSpace(nomeJogador)) return 3;
            return 0;
        }

        private void btnListarJogadores_Click(object sender, EventArgs e)
        {
            if (idPartidaAtual == 0) return;
            lstJogadores.Items.Clear();
            string retorno = Jogo.ListarJogadores(idPartidaAtual).Replace("\r", "");
            foreach (var jogador in retorno.Split('\n'))
                if (!string.IsNullOrWhiteSpace(jogador))
                    lstJogadores.Items.Add(jogador);
        }

        private void btnIniciarJogo_Click(object sender, EventArgs e)
        {
            int idJogador = int.Parse(txtIDjogador.Text);
            string retorno = Jogo.Iniciar(idJogador, txtSenhaJogador.Text);
            lblIDjogadorVez.Text = retorno;
            lblNomeJogadorVez.Text = txtNomeJogador.Text;
            MessageBox.Show("Partida Iniciada!", "Info");
        }

        private void btnExibirCartas_Click(object sender, EventArgs e)
        {
            int idJogador = int.Parse(txtIDjogador.Text);
            lblCartas.Text = Jogo.ListarCartas(idJogador, txtSenhaJogador.Text);
        }

        private void btnVerificarVez_Click(object sender, EventArgs e)
        {
            if (idPartidaAtual == 0) return;
            lstVerificarVez.Items.Clear();
            string retorno = Jogo.VerificarVez(idPartidaAtual).Replace("\r", "");
            foreach (var vez in retorno.Split('\n'))
                if (!string.IsNullOrWhiteSpace(vez))
                    lstVerificarVez.Items.Add(vez);
        }

        private void btnColocarPersonagem_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtSetor.Text, out int setorSelecionado))
            {
                MessageBox.Show("Setor inválido.");
                return;
            }

            if (string.IsNullOrEmpty(txtPersonagem.Text))
            {
                MessageBox.Show("Informe o personagem.");
                return;
            }

            string personagem = txtPersonagem.Text.Substring(0, 1).ToUpper();
            int idJogador = int.Parse(txtIDjogador.Text);
            string senha = txtSenhaJogador.Text;

            string resultado = Jogo.ColocarPersonagem(idJogador, senha, setorSelecionado, personagem);
            MessageBox.Show(resultado);
            personagensTabuleiro.Add(personagem);
        }

        private void btnPromover_Click(object sender, EventArgs e)
        {
            string personagem = txtPersonagem.Text;
            if (rodadaAtual.PodePromover() && rodadaAtual.PromoverPersonagem(personagem))
            {
                MessageBox.Show($"{personagem} promovido com sucesso!");
                AtualizarStatusRodada();
            }
            else
            {
                MessageBox.Show("Não é possível promover.");
            }
        }

        private void btnConfirmarVoto_Click(object sender, EventArgs e)
        {
            string voto = txtVoto.Text.Trim().ToUpper();
            if (voto != "S" && voto != "N")
            {
                MessageBox.Show("Digite S para Sim ou N para Não.");
                return;
            }

            bool votoSim = voto == "S";
            string jogador = txtNomeJogador.Text;

            if (rodadaAtual.RegistrarVoto(jogador, votoSim))
            {
                MessageBox.Show($"Voto '{voto}' registrado!");
                AtualizarStatusRodada();

                if (rodadaAtual.TodosVotaram(jogadores))
                {
                    string resultado = rodadaAtual.ResultadoVotacao();
                    MessageBox.Show($"Resultado: {resultado}");
                }
            }
            else
            {
                MessageBox.Show("Você já votou.");
            }
        }

        private void btnIniciarAutomacao_Click(object sender, EventArgs e)
        {
            if (!timerAutomatizador.Enabled)
            {
                timerAutomatizador.Start();
                btnIniciarAutomacao.BackColor = Color.LightBlue;
                MessageBox.Show("Automação iniciada!", "Info");
            }
            else
            {
                timerAutomatizador.Stop();
                btnIniciarAutomacao.BackColor = SystemColors.Control;
                MessageBox.Show("Automação parada!", "Info");
            }
        }

        private void lstPartidas_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstPartidas.SelectedItem != null)
            {
                partida = lstPartidas.SelectedItem.ToString();
                dadosPartida = partida.Split(',');
                idPartidaAtual = int.Parse(dadosPartida[0]);
                lblInforma.Text = idPartidaAtual.ToString();
                txtIdPartida.Text = idPartidaAtual.ToString();
            }
        }

        private void btnVoltar_Click(object sender, EventArgs e) => Close();

        private void btnPersonagens_Click(object sender, EventArgs e)
        {
            Personagens personagemForm = new Personagens();
            personagemForm.ShowDialog();
        }

        private void lstJogadores_SelectedIndexChanged(object sender, EventArgs e) { }
        private void lstVerificarVez_SelectedIndexChanged(object sender, EventArgs e) { }
    }
}
