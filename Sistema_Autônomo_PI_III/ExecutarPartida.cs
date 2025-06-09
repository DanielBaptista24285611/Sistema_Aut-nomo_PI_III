// Form1.cs
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using KingMeServer;

namespace Sistema_Autônomo_PI_III
{
    public partial class ExecutarPartida : Form
    {
        private Personagens formPersonagens;
        private Rodada rodadaAtual;
        private Timer timerAutomatizador;
        private List<string> personagensTabuleiro = new List<string>();
        private List<string> jogadores = new List<string>();
        private Dictionary<string, string> personagemParaJogador = new Dictionary<string, string>();
        private Dictionary<string, int> pontosJogador = new Dictionary<string, int>();
        private List<string> personagens = new List<string>()
{
    "A", "B", "C",  "D", "E", "G", "H", "K", "L",  "M", "Q", "R", "T"
  
};
        private int idPartidaAtual;
        public string NomeJogador { get; set; }


        public ExecutarPartida(Personagens formPersonagens, string idJogador, string senhaJogador, string nomeJogador)
        {
            InitializeComponent();
            lblversao.Text = Jogo.versao;

            rodadaAtual = new Rodada(1, "");
            this.formPersonagens = formPersonagens;

            txtIDjogador.Text = idJogador;
            txtSenhaJogador.Text = senhaJogador;
            NomeJogador = nomeJogador.Trim().ToUpper();

            AtualizarListasIniciais();
            InicializarTimer();
        }

        private bool TodosPersonagensForamColocados()
        {
            var normalizadosTabuleiro = personagensTabuleiro
                .Select(p => p.Trim().ToUpper())
                .ToList();

            return personagens.All(p => normalizadosTabuleiro.Contains(p.Trim().ToUpper()));
        }


        private void InicializarTimer()
        {
            timerAutomatizador = new Timer();
            timerAutomatizador.Interval = 3000;
            timerAutomatizador.Tick += AutomatizarEtapas;
            timerAutomatizador.Stop(); // Agora o timer só começa com o botão
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            AutomatizarEtapas();
        }

        private void AutomatizarEtapas()
        {
            throw new NotImplementedException();
        }

        private void AutomatizarEtapas(object sender, EventArgs e)
        {
            if (rodadaAtual == null) return;

            if (rodadaAtual.FaseAtual == FaseRodada.Promocao && personagensTabuleiro.Any())
            {
                foreach (var personagem in personagensTabuleiro.ToList())
                {
                    if (rodadaAtual.PromoverPersonagem(personagem))
                    {
                        personagensTabuleiro.Remove(personagem);
                        if (rodadaAtual.PersonagensPromovidos.Count >= 3)
                            break;
                    }
                }
                AtualizarStatusRodada();
            }
            else if (rodadaAtual.FaseAtual == FaseRodada.Votacao && jogadores.Any())
            {
                foreach (var jogador in jogadores)
                {
                    if (!rodadaAtual.JaVotou(jogador))
                    {
                        rodadaAtual.RegistrarVoto(jogador, true);
                    }
                }

                AtualizarStatusRodada();

                if (rodadaAtual.TodosVotaram(jogadores))
                {
                    timerAutomatizador.Stop(); // <--- Pare o timer ANTES da MessageBox

                    string resultado = rodadaAtual.ResultadoVotacao();
                    MessageBox.Show($"Resultado da votação: {resultado}", "Fim da Votação");

                    rodadaAtual.AvancarParaFase(FaseRodada.Concluida);
                }
            }   
        }


        private void AtualizarListasIniciais()
        {
            lstSetores.Items.Clear();
            foreach (var setor in Jogo.ListarSetores().Split('\n'))
            {
                if (!string.IsNullOrWhiteSpace(setor))
                    lstSetores.Items.Add(setor);
            }

            lstPersonagens.Items.Clear();
            foreach (var personagem in Jogo.ListarPersonagens().Split('\n'))
            {
                if (!string.IsNullOrWhiteSpace(personagem))
                    lstPersonagens.Items.Add(personagem);
            }
        }

            /*jogadores.Add(txtNomeJogador.Text);
            rodadaAtual = new Rodada(1, txtNomeJogador.Text);
            AtualizarStatusRodada();*/
        

        private void AtualizarStatusRodada()
        {
            lstVerificarVez.Items.Clear();
            lstVerificarVez.Items.Add(rodadaAtual.ToString());
        }
        private void btnIniciarJogo_Click(object sender, EventArgs e)
        {
            try
            {
                // Validate input
                if (!int.TryParse(txtIDjogador.Text, out int idJogador))
                {
                    MessageBox.Show("ID do jogador inválido!", "Erro");
                    return;
                }

                // 1. Start the match
                string retornoInicio = Jogo.Iniciar(idJogador, txtSenhaJogador.Text);
                lblIDjogadorVez.Text = retornoInicio;
                lblNomeJogadorVez.Text = NomeJogador; // Ensure this is properly initialized

                // 2. Check and display player's turn
                lstVerificarVez.Items.Clear();
                string retornoVez = Jogo.VerificarVez(idPartidaAtual);

                foreach (var vez in retornoVez.Split(new[] { '\r', '\n' }, StringSplitOptions.RemoveEmptyEntries))
                {
                    lstVerificarVez.Items.Add(vez);
                }
                NomeJogador = Text.Trim().ToUpper();
                if (!jogadores.Contains(NomeJogador))
                    jogadores.Add(NomeJogador);

                MessageBox.Show("Partida Iniciada com sucesso!", "Info");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao iniciar jogo: {ex.Message}", "Erro");
                // Consider logging the error
            }
            foreach (var jogador in jogadores)
            {
                if (!pontosJogador.ContainsKey(jogador))
                    pontosJogador[jogador] = 0;
            }

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
            {
                if (!string.IsNullOrWhiteSpace(vez))
                    lstVerificarVez.Items.Add(vez);
            }
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

            lstVerificarVez.Items.Clear();

            var linhas = resultado.Split(new[] { "\r\n", "\n" }, StringSplitOptions.RemoveEmptyEntries);

            if (!personagens.Contains(personagem))
            {
                MessageBox.Show("Esse personagem não é válido.");
                return;
            }

            if (personagensTabuleiro.Contains(personagem))
            {
                MessageBox.Show("Esse personagem já foi colocado no tabuleiro.");
                return;
            }
            if (!personagemParaJogador.ContainsKey(personagem))
            {
                personagemParaJogador[personagem] = idJogador.ToString();
            }


            // Adiciona cada linha separadamente
            foreach (var linha in linhas)
            {
                lstVerificarVez.Items.Add(linha.Trim());
            }

            personagensTabuleiro.Add(personagem);
        }

        private void btnPromover_Click(object sender, EventArgs e)
        {
            string personagem = txtPersonagem.Text;

            if (!TodosPersonagensForamColocados())
            {
                MessageBox.Show("Você só pode promover após todos os personagens estarem no tabuleiro.");
                return;
            }

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
        private void CalcularPontos(string jogador)
        {
            // Simples: quanto mais próximo do setor 5, mais pontos
            string setoresTexto = Jogo.ListarSetores();
            int pontos = 0;

            foreach (var linha in setoresTexto.Split('\n'))
            {
                for (int setor = 1; setor <= 5; setor++)
                {
                    if (linha.StartsWith($"Setor {setor}:"))
                    {
                        string personagens = linha.Substring($"Setor {setor}:".Length).Trim();
                        foreach (string p in personagens.Split(','))
                        {
                            string personagem = p.Trim();
                            if (!string.IsNullOrWhiteSpace(personagem) && personagemParaJogador.ContainsKey(personagem))
                            {
                                string dono = personagemParaJogador[personagem];
                                if (!pontosJogador.ContainsKey(dono))
                                    pontosJogador[dono] = 0;

                                pontosJogador[dono] += setor; // exemplo: Setor 3 = +3 pontos
                            }
                        }
                    }
                }
            }

            // Mostrar o placar
            string mensagem = "Placar Atual:\n\n";
            foreach (var par in pontosJogador.OrderByDescending(p => p.Value))
            {
                mensagem += $"{par.Key}: {par.Value} pontos\n";
            }

            MessageBox.Show(mensagem);
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
            string jogador = NomeJogador; // Nome do jogador que está votando

            if (rodadaAtual.TodosVotaram(jogadores))
            {
                string resultado = rodadaAtual.ResultadoVotacao();

                MessageBox.Show($"Resultado: {resultado}");

                if (resultado == "REPROVADO")
                {
                    // Recupera personagem do setor 5
                    string setoresTexto = Jogo.ListarSetores();
                    string personagemRejeitado = null;

                    foreach (var linha in setoresTexto.Split('\n'))
                    {
                        if (linha.StartsWith("Setor 5:"))
                        {
                            string conteudo = linha.Substring("Setor 5:".Length).Trim();
                            if (!string.IsNullOrWhiteSpace(conteudo))
                            {
                                personagemRejeitado = conteudo.Split(',').First().Trim(); // Só pega o primeiro
                                break;
                            }
                        }
                    }

                    if (personagemRejeitado != null)
                    {
                        personagensTabuleiro.Remove(personagemRejeitado);
                        MessageBox.Show($"O personagem {personagemRejeitado} foi rejeitado como rei e voltará para a fase de promoção.");

                        rodadaAtual.AvancarParaFase(FaseRodada.Promocao);
                    }
                    else
                    {
                        MessageBox.Show("Nenhum personagem encontrado no setor 5 para rejeição.");
                    }
                }
                else if (resultado == "APROVADO")
                {
                    // Recompensar jogadores
                    MessageBox.Show("O personagem foi coroado rei! Todos ganham pontos!");

                    foreach (string player in jogadores)
                    {
                         CalcularPontos(player); // Função que você pode implementar baseado nos setores
                       
                    }

                    rodadaAtual.AvancarParaFase(FaseRodada.Concluida);
                }

                AtualizarStatusRodada();
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

        private void btnHistorico_Click(object sender, EventArgs e)
        {
            lstVerificarVez.Items.Clear();
            lstVerificarVez.Items.Add("Histórico da partida:");

            string historico = Jogo.ConsultarHistorico(idPartidaAtual, checkBox1.Checked, false);
           

            if (string.IsNullOrWhiteSpace(historico) || historico.Contains("ERRO"))
            {
                lstVerificarVez.Items.Add("Nenhuma jogada realizada ainda.");
            }
            else
            {
                foreach (var linha in historico.Split(new[] { "\r\n", "\n" }, StringSplitOptions.RemoveEmptyEntries))
                {
                    lstVerificarVez.Items.Add(linha);
                }
            }
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnPersonagens_Click(object sender, EventArgs e)
        {
            Personagens personagemForm = new Personagens();
            personagemForm.ShowDialog();
        }

        private void lstJogadores_SelectedIndexChanged(object sender, EventArgs e) { }
        private void lstVerificarVez_SelectedIndexChanged(object sender, EventArgs e) { }

        private void txtIDjogador_TextChanged(object sender, EventArgs e)
        {

        }
    }
}