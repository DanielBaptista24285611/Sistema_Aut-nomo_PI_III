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

        private Dictionary<string, Image> imagemCarta = new Dictionary<string, Image>();

        private void CarregarCarta()
        {
            imagemCarta["A"]= Properties.Resources.Carta_A;
            imagemCarta["B"] = Properties.Resources.Carta_B;
           // imagemCarta["C"] = Properties.Resources.Carta_C;
            imagemCarta["D"] = Properties.Resources.Carta_D;
            imagemCarta["E"] = Properties.Resources.Carta_E;
            imagemCarta["G"] = Properties.Resources.Carta_G;
            //imagemCarta["H"] = Properties.Resources.Carta_H;
            imagemCarta["K"] = Properties.Resources.Carta_K;
            //imagemCarta["L"] = Properties.Resources.Carta_L;
            imagemCarta["M"] = Properties.Resources.Carta_M;
            imagemCarta["Q"] = Properties.Resources.Carta_Q;
            imagemCarta["R"] = Properties.Resources.Carta_R;
            imagemCarta["T"] = Properties.Resources.Carta_T;
        }

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

            CarregarCarta();
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
            if (!int.TryParse(txtIDjogador.Text, out int idJogador))
            {
                MessageBox.Show("ID do jogador inválido!", "Erro");
                return;
            }

            string retornoInicio = Jogo.Iniciar(idJogador, txtSenhaJogador.Text);
            lblIDjogadorVez.Text = retornoInicio;
            lblNomeJogadorVez.Text = NomeJogador;

            if (retornoInicio.StartsWith("ERRO:"))
            {
                lblErro.Text = retornoInicio;
            }
            else
            {
                lblErro.Text = "";
            }
            
        }

        private void btnExibirCartas_Click(object sender, EventArgs e)
        {
            int idJogador = int.Parse(txtIDjogador.Text);
            string  retorno= Jogo.ListarCartas(idJogador, txtSenhaJogador.Text);

            if(retorno.StartsWith("ERRO:"))
            {
                lblCartas.Text = retorno;
                return;
            }
            else
            {
                Dictionary<char, string> personagens = new Dictionary<char, string>()
            {
                {'A', "Adilson"},
                {'B', "Beatriz"},
                {'C', "Claro"},
                {'D', "Douglas"},
                {'E', "Eduardo"},
                {'G', "Guilherme"},
                {'H', "Heredia"},
                {'K', "Kelly"},
                {'L', "Leonardo"},
                {'M', "Mario"},
                {'Q', "Quintas"},
                {'R', "Ranulfo"},
                {'T', "Toshio"}
            };

                List<string> nomesConvertidos = new List<string>();

                foreach (char inicial in retorno)
                {
                    if (personagens.ContainsKey(inicial))
                    {
                        nomesConvertidos.Add(personagens[inicial]);
                    }
                }

                lblCartas.Text = "Minhas cartas:\n" + string.Join("\n", nomesConvertidos);

            }

        }

        private void btnVerificarVez_Click(object sender, EventArgs e)
        {
            if (idPartidaAtual == 0) return;
            lstVerificarVez.Items.Clear();
            string retorno = Jogo.VerificarVez(idPartidaAtual).Trim();
            string[] vezJogador = retorno.Split(',');
            string[] linhas = retorno.Split(new[] { "\r\n", "\n", "\r" }, StringSplitOptions.RemoveEmptyEntries);

            lblIDjogadorVez.Text = vezJogador[0].Trim();
            lblNomeJogadorVez.Text = vezJogador[1].Trim();

            string estadoTabuleiro = string.Join("\n", linhas.Skip(1));

            // Obtém a lista de jogadores
            string retorno2 = Jogo.ListarJogadores(idPartidaAtual).Trim();
            string[] jogadores = retorno2.Split('\n'); // Divide os jogadores por linha

            // Percorre os jogadores para encontrar o nome do jogador que tem a vez
            string nomeJogadorVez = "";
            int pontuacaoJogadorVez = 0;

            foreach (string jogador in jogadores)
            {
                string[] dadosJogador = jogador.Split(',');

                if (dadosJogador.Length >= 3 && dadosJogador[0].Trim() == vezJogador[0].Trim())
                {
                    nomeJogadorVez = dadosJogador[1].Trim();
                    pontuacaoJogadorVez = int.Parse(dadosJogador[2].Trim());

                    break;
                }
            }
            //AtualizarTabuleiro(estadoTabuleiro);

        }

        private void btnColocarPersonagem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtSetor.Text) || string.IsNullOrEmpty(txtPersonagem.Text))
            {
                MessageBox.Show("Informe o Setor e o Personagem.");
                return;
            }

            // Converte o ID do jogador para inteiro
            int jogador1;
            if (!int.TryParse(txtIDjogador.Text, out jogador1))
            {
                MessageBox.Show("O ID do jogador deve ser um número válido.");
                return;
            }

            string senha = txtSenhaJogador.Text; // Obtém a senha do jogador

            // Obtém os setores disponíveis
            string setoresStr = Jogo.ListarSetores().Replace("\r", "");
            string[] setores = setoresStr.Split(new string[] { "\n" }, StringSplitOptions.RemoveEmptyEntries);

            // Obtém os personagens disponíveis
            string personagensStr = Jogo.ListarPersonagens().Replace("\r", "");
            string[] personagens = personagensStr.Split(new string[] { "\n" }, StringSplitOptions.RemoveEmptyEntries);

            // Criar uma lista apenas com os IDs dos setores
            List<int> idsSetores = new List<int>();
            foreach (string setor in setores)
            {
                string[] partes = setor.Split(',');
                if (partes.Length > 1 && int.TryParse(partes[0], out int idSetor))
                {
                    idsSetores.Add(idSetor);
                }
            }

            // Converter txtSetor.Text para número
            int setorSelecionado;
            if (!int.TryParse(txtSetor.Text, out setorSelecionado) || !idsSetores.Contains(setorSelecionado))
            {
                MessageBox.Show("O setor digitado não é válido.");
                return;
            }

            // Pegar apenas a primeira letra do personagem digitado
            string personagemSelecionado = txtPersonagem.Text.Trim();
            if (string.IsNullOrEmpty(personagemSelecionado))
            {
                MessageBox.Show("O personagem digitado não pode estar vazio.");
                return;
            }

            personagemSelecionado = personagemSelecionado.Substring(0, 1).ToUpper(); // Apenas a primeira letra

            // Verificar se essa letra está na lista de personagens
            bool personagemValido = personagens.Any(p => p.StartsWith(personagemSelecionado, StringComparison.OrdinalIgnoreCase));

            if (!personagemValido)
            {
                MessageBox.Show("O personagem digitado não é válido.");
                return;
            }

            // Chama o método para posicionar o personagem
            string resultado = Jogo.ColocarPersonagem(jogador1, senha, setorSelecionado, personagemSelecionado);

            lstVerificarVez.Items.Add(resultado);

            // Atualiza a ListBox lstVerificarVez com o personagem e setor escolhidos
            lstVerificarVez.Items.Clear();
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