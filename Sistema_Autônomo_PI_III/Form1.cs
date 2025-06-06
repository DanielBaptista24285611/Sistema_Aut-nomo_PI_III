// Form1.cs
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
        public string NomeJogador { get; set; }


        public Form1(Personagens formPersonagens, string idJogador, string senhaJogador)
        {
            InitializeComponent();
            lblversao.Text = Jogo.versao;

            rodadaAtual = new Rodada(1, "");
            this.personagensForm = formPersonagens;

            txtIDjogador.Text = idJogador;
            txtSenhaJogador.Text = senhaJogador;

            AtualizarListasIniciais();
            InicializarTimer();
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
                    rodadaAtual.RegistrarVoto(jogador, true);
                }

                AtualizarStatusRodada();

                if (rodadaAtual.TodosVotaram(jogadores))
                {
                    string resultado = rodadaAtual.ResultadoVotacao();
                    MessageBox.Show($"Resultado da votação: {resultado}", "Fim da Votação");
                    timerAutomatizador.Stop();
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
                // 1. Validações iniciais
                if (string.IsNullOrEmpty(txtIDjogador.Text) || string.IsNullOrEmpty(txtSenhaJogador.Text))
                {
                    MessageBox.Show("Preencha ID e senha do jogador.", "Erro");
                    return;
                }

                // 2. Verifica se a partida existe e tem jogadores suficientes
                if (idPartidaAtual == 0)
                {
                    MessageBox.Show("Nenhuma partida selecionada.", "Erro");
                    return;
                }

                string listaJogadores = Jogo.ListarJogadores(idPartidaAtual).Replace("\r", "").Trim();
                if (string.IsNullOrEmpty(listaJogadores) || listaJogadores.Contains("ERRO"))
                {
                    MessageBox.Show("Partida não encontrada ou inválida.", "Erro");
                    return;
                }

                string[] jogadores = listaJogadores.Split('\n');
                if (jogadores.Length < 2)
                {
                    MessageBox.Show("A partida precisa de pelo menos 2 jogadores.", "Aviso");
                    return;
                }

                // 3. Inicia a partida
                int idJogador = int.Parse(txtIDjogador.Text);
                string retornoInicio = Jogo.Iniciar(idJogador, txtSenhaJogador.Text);

                if (retornoInicio.StartsWith("ERRO"))
                {
                    MessageBox.Show($"Falha ao iniciar: {retornoInicio}", "Erro");
                    return;
                }

                // 4. Atualiza a interface
                lblIDjogadorVez.Text = retornoInicio;
                lblNomeJogadorVez.Text = NomeJogador;

                // 5. Atualiza a lista de turnos
                lstVerificarVez.Items.Clear();
                string retornoVez = Jogo.VerificarVez(idPartidaAtual).Replace("\r", "");
                foreach (var vez in retornoVez.Split('\n'))
                {
                    if (!string.IsNullOrWhiteSpace(vez))
                        lstVerificarVez.Items.Add(vez);
                }

                MessageBox.Show("Partida iniciada!", "Sucesso");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro crítico: {ex.Message}", "Erro");
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
            string jogador = NomeJogador; // Nome do jogador que está votando

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

        private void btnIniciarAutomacao_Click(object sender, EventArgs e)
        {
            if (!timerAutomatizador.Enabled)
            {
                timerAutomatizador.Start();
                btnIniciarAutomacao.BackColor = Color.LightBlue; // azul claro
                MessageBox.Show("Automação iniciada!", "Info");
            }
            else
            {
                timerAutomatizador.Stop();
                btnIniciarAutomacao.BackColor = SystemColors.Control; // cor padrão
                MessageBox.Show("Automação parada!", "Info");
            }
        }

        private void txtNomePartida_TextChanged(object sender, EventArgs e)
        {

        }

        
    }
}