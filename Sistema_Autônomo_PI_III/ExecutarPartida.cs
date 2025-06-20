// ExecutarPartida.cs
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
        private int rodadaAtual = 1;
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
            imagemCarta["A"] = Properties.Resources.Carta_A;
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
        private int idJogadorAtual;
        private string senhaJogador;

        public string NomeJogador { get; set; }


        public ExecutarPartida(Personagens formPersonagens, string idJogador, string senhaJogador, string nomeJogador, int idPartida)
        {
            InitializeComponent();
            this.formPersonagens = formPersonagens;

            this.idJogadorAtual = int.Parse(idJogador); // <-- Agora sim
            this.senhaJogador = senhaJogador;           // <-- ESSENCIAL
            this.idPartidaAtual = idPartida;
            this.NomeJogador = nomeJogador.Trim().ToUpper();

            txtIDjogador.Text = idJogador;
            txtSenhaJogador.Text = senhaJogador;

            CarregarCarta();
            AtualizarListasIniciais();
            tmrVerificarVez.Interval = 3000;
            tmrVerificarVez.Enabled = true;
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

        private void btnIniciarJogo_Click(object sender, EventArgs e)
        {

            string retornoInicio = Jogo.Iniciar(idJogadorAtual, senhaJogador);
            tmrVerificarVez.Enabled = true;

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
            tmrVerificarVez.Enabled = true;

        }

        private void btnExibirCartas_Click(object sender, EventArgs e)
        {

            string retorno = Jogo.ListarCartas(idJogadorAtual, senhaJogador);

            if (retorno.StartsWith("ERRO:"))
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
               // {'C', "Claro"},
                {'D', "Douglas"},
                {'E', "Eduardo"},
                {'G', "Guilherme"},
                //{'H', "Heredia"},
                {'K', "Kelly"},
               // {'L', "Leonardo"},
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
            string retorno = Jogo.VerificarVez(idPartidaAtual).Trim();
            string[] vezJogador = retorno.Split(',');
            string[] linhas = retorno.Split(new[] { "\r\n", "\n", "\r" }, StringSplitOptions.RemoveEmptyEntries);

            lblIDjogadorVez.Text = vezJogador[0].Trim();

            string estadoTabuleiro = string.Join("\n", linhas.Skip(1));

            // Obtém a lista de jogadores
            string retorno2 = Jogo.ListarJogadores(idPartidaAtual).Trim();
            string[] jogadores = retorno2.Split('\n'); // Divide os jogadores por linha

            foreach (string jogador in jogadores)
            {
                string[] dadosJogador = jogador.Split(',');
                if (dadosJogador.Length >= 2 && dadosJogador[0].Trim() == vezJogador[0].Trim())
                {
                    lblNomeJogadorVez.Text = dadosJogador[1].Trim(); // Pega o Nome do jogador correspondente
                    break; // Sai do loop assim que encontrar
                }
            }
            AtualizarRodada(estadoTabuleiro);

        }

        private void btnColocarPersonagem_Click(object sender, EventArgs e)
        {
            string estadoAtual = Jogo.ColocarPersonagem(idJogadorAtual, senhaJogador,
               Convert.ToInt32(txtSetor.Text), txtPersonagem.Text);

            AtualizarRodada(estadoAtual);
        }

        private void AtualizarRodada(string estadoTabuleiro)
        {
            string[] linhas = estadoTabuleiro.Split(new[] { "\r\n", "\n", "\r" }, StringSplitOptions.RemoveEmptyEntries);
            Controls.OfType<PictureBox>().ToList().ForEach(p => Controls.Remove(p));

            foreach (string linha in linhas)
            {
                string[] partes = linha.Split(',');
                if (partes.Length != 2) continue;

                int setor = int.Parse(partes[0].Trim());
                string carta = partes[1].Trim();

                PosicionarCarta(setor, carta);
            }

        }

        private void PosicionarCarta(int setor, string carta)
        {
            Dictionary<int, Point> posicoesSetores = new Dictionary<int, Point>
    {
        { 0, new Point(410, 520) },
        { 1, new Point(410, 440) },
        { 2, new Point(410, 360) },
        { 3, new Point(410, 280) },
        { 4, new Point(410, 200) },
        { 5, new Point(410, 120) },
        { 10, new Point(500, 51) }
    };

            // Verifica se o setor existe
            if (!posicoesSetores.ContainsKey(setor))
            {
                Console.WriteLine($"Setor {setor} não encontrado no dicionário.");
                return;
            }

            // Conta quantas cartas já estão no setor
            int cartasNoSetor = Controls.OfType<PictureBox>().Count(p => p.Tag != null && (int)p.Tag == setor);

            // Obtém a imagem da carta usando a função ObterImagemDaCarta
            Image imagemCarta = ObterImagemDaCarta(carta);
            if (imagemCarta == null)
            {
                Console.WriteLine($"Carta '{carta}' não encontrada no dicionário de imagens.");
                return;
            }

            // Define transparência na imagem
            Bitmap bitmapImagemCarta = new Bitmap(imagemCarta);
            bitmapImagemCarta.MakeTransparent();

            // Cria a PictureBox da carta
            PictureBox cartaImg = new PictureBox
            {
                Size = new Size(50, 80),
                Location = new Point(
                    posicoesSetores[setor].X + (cartasNoSetor * 55),
                    posicoesSetores[setor].Y
                ),
                BackgroundImage = bitmapImagemCarta,
                BackgroundImageLayout = ImageLayout.Stretch,
                Tag = setor,
                BackColor = Color.Transparent
            };

            // Adiciona ao formulário
            Controls.Add(cartaImg);
            cartaImg.BringToFront();

            Console.WriteLine($"Carta '{carta}' posicionada no setor {setor}, posição {cartasNoSetor + 1}.");
        }

        private Image ObterImagemDaCarta(string carta)
        {
            return imagemCarta.ContainsKey(carta) ? imagemCarta[carta] : null;
        }


        private void btnPromover_Click(object sender, EventArgs e)
        {
            string personagem = txtPersonagem.Text;
            Jogo.Promover(idJogadorAtual, senhaJogador, personagem);

            // Obtém o ID do jogador que tem a vez
            string retorno = Jogo.VerificarVez(idPartidaAtual).Trim();
            string[] vez = retorno.Split(',');
            string[] linhas = retorno.Split(new[] { "\r\n", "\n", "\r" }, StringSplitOptions.RemoveEmptyEntries);

            string estadoTabuleiro = string.Join("\n", linhas.Skip(1));

            AtualizarRodada(estadoTabuleiro);
        }

        private bool JogadorDaVez()
        {
            return txtIDjogador.Text == lblIDjogadorVez.Text;
        }
        private (string[] dadosVez, bool partidaIniciada) VerificarVezCompleto()
        {
            try
            {
                string retorno = Jogo.VerificarVez(idPartidaAtual).Trim();

                if (string.IsNullOrEmpty(retorno)) return (null, false);

                string[] linhas = retorno.Split(new[] { "\r\n", "\n", "\r" }, StringSplitOptions.RemoveEmptyEntries);
                if (linhas.Length == 0) return (null, false);

                string[] vez = linhas[0].Split(',');

                // Atualiza minhas cartas sempre que verifica a vez
                if (JogadorDaVez())
                {
                    AtualizarMinhasCartas();
                }

                bool iniciada = vez.Length > 1 && vez[1].Trim().Equals("J");
                return (vez, iniciada);
            }
            catch
            {
                return (null, false);
            }
        }

        private string EstadoAtualTabuleiro()
        {
            string retorno = Jogo.VerificarVez(idPartidaAtual).Trim();
            string[] vez = retorno.Split(',');
            string[] linhas = retorno.Split(new[] { "\r\n", "\n", "\r" }, StringSplitOptions.RemoveEmptyEntries);


            string estadoTabuleiro = string.Join("\n", linhas.Skip(1));

            return estadoTabuleiro;
        }

        List<string> personagensColocados = new List<string>();

        Dictionary<int, List<string>> setores = new Dictionary<int, List<string>>()
        {
            { 1, new List<string>() },
            { 2, new List<string>() },
            { 3, new List<string>() },
            { 4, new List<string>() },
            { 5, new List<string>() },
            { 10, new List<string>()}
        };

        Random random = new Random();
        private static readonly Dictionary<string, int> rankingPersonagens = new Dictionary<string, int>
        {
            {"A", 7},  // Adilson - mais valioso
            {"B", 6},  // Beatriz
            {"C", 5},  // Claro
            {"D", 4},  // Douglas
            {"E", 3},  // Eduardo
            {"G", 2},  // Guilherme
            {"H", 1},  // Heredia - menos valioso
            {"K", 5},  // Kelly
            {"L", 4},  // Leonardo
            {"M", 3},  // Mario
            {"Q", 2},  // Quintas
            {"R", 1},  // Ranulfo
            {"T", 6}   // Toshio
        };

        private List<string> minhasCartas = new List<string>();
        private List<string> personagensJogo = new List<string>();

        private bool VerificarCartaNoSetor10()
        {
            try
            {
                // Primeiro sincroniza com o estado real do servidor
                string estadoTabuleiro = EstadoAtualTabuleiro();
                var linhas = estadoTabuleiro.Split(new[] { "\r\n", "\n", "\r" }, StringSplitOptions.RemoveEmptyEntries);

                foreach (string linha in linhas)
                {
                    var partes = linha.Split(',');
                    if (partes.Length == 2 && int.TryParse(partes[0].Trim(), out int setor) && setor == 10)
                    {
                        string carta = partes[1].Trim();
                        lstLog.Items.Add($"REI: {carta} no setor 10"); // Changed to lstLog
                        Console.WriteLine($"Carta {carta} chegou ao KingsMe");
                        return true;
                    }
                }
                return false;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro ao verificar setor 10: {ex.Message}");
                return false;
            }
        }
        private bool PartidaFoiIniciada()
        {
            try
            {
                string retorno = Jogo.VerificarVez(idPartidaAtual);
                if (string.IsNullOrEmpty(retorno)) return false;

                // Verifica múltiplos indicadores de partida iniciada
                return retorno.Contains(",J,") ||  // Formato do servidor
                       retorno.Contains("Jogando") ||
                       !retorno.Contains("Aguardando");
            }
            catch
            {
                return false;
            }
        }
        private void AtualizarMinhasCartas()
        {
            try
            {
                string retorno = Jogo.ListarCartas(idJogadorAtual, senhaJogador);

                if (retorno.StartsWith("ERRO:"))
                {
                    Console.WriteLine($"Erro ao listar cartas: {retorno}");
                    return;
                }

                minhasCartas.Clear();
                foreach (char c in retorno.Trim())
                {
                    minhasCartas.Add(c.ToString());
                }

                // Remove cartas que já estão no tabuleiro
                var cartasDisponiveis = minhasCartas.Except(personagensColocados).ToList();

                // Ordena as cartas disponíveis pelo ranking
                minhasCartas = cartasDisponiveis.OrderByDescending(c => rankingPersonagens.ContainsKey(c) ? rankingPersonagens[c] : 0).ToList();


                Console.WriteLine($"Cartas disponíveis: {string.Join(",", minhasCartas)}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro em AtualizarMinhasCartas: {ex.Message}");
            }
        }
        private bool reiEleito = false;
        private void tmrVerificaVez_Tick(object sender, EventArgs e)
        {
            tmrVerificarVez.Enabled = false;
            try
            {
                if (!JogadorConectado()) return;

                // Atualiza primeiro o estado do jogo
                var (dadosVez, partidaIniciada) = VerificarVezCompleto();

                // Atualiza o tabuleiro visual
                SincronizarEstadoTabuleiro();

                // Verifica se a partida está em andamento
                if (!partidaIniciada)
                {
                    tmrVerificarVez.Enabled = true;
                    return;
                }

                if (dadosVez != null && dadosVez.Length >= 4)
                {
                    char faseAtual = dadosVez[3][0];
                    string idJogadorVez = dadosVez[0];

                    // Atualiza quem tem a vez
                    lblIDjogadorVez.Text = idJogadorVez;

                    // Verifica se houve reinício (setor 10 vazio após coroação)
                    if (reiEleito && (!setores.ContainsKey(10) || setores[10].Count == 0))
                    {
                        reiEleito = false;
                        votacaoConcluida = false;
                        ReiniciarRodada();
                        tmrVerificarVez.Enabled = true;
                        return;
                    }

                    // Processa cada fase do jogo de acordo com a estratégia
                    if (JogadorDaVez())
                    {
                        switch (faseAtual)
                        {
                            case 'S': // Setup
                                if (personagensColocados.Count < 13) // Ainda há personagens para colocar
                                {
                                    ProcessarSetup();
                                }
                                break;

                            case 'P': // Promoção
                                AtualizarMinhasCartas();
                                ProcessarPromocao();
                                break;

                            case 'V': // Votação

                                AtualizarMinhasCartas();
                                ProcessarVotacao();

                                break;
                        }

                        // Verifica se o jogo terminou
                        VerificarFimDeJogo();
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro no timer: {ex.Message}");
            }
            finally
            {
                tmrVerificarVez.Enabled = true;
            }
        }

        private string EscolherVotoEstrategico(string cartaRei)
        {
            if (!JogadorConectado()) return "N";

            // 1. Verifica se a carta é do jogador
            bool ehMinhaCarta = minhasCartas.Contains(cartaRei);

            // 2. Obtém o valor da carta
            int valorCarta = rankingPersonagens.ContainsKey(cartaRei) ? rankingPersonagens[cartaRei] : 0;

            // 3. Estratégia básica:
            if (ehMinhaCarta)
            {
                return "S"; // Sempre vota a favor das próprias cartas
            }
            else if (valorCarta >= 6) // Cartas muito valiosas
            {
                return "N"; // Vota contra para evitar que outros ganhem pontos
            }
            else // Cartas medianas ou fracas
            {
                // Chance 70% de votar Sim para cartas medianas/fracas
                return random.Next(100) < 70 ? "S" : "N";
            }
        }
        // Métodos auxiliares
        private int ObterNumeroJogadores()
        {
            try
            {
                string retorno = Jogo.ListarJogadores(idPartidaAtual);
                return retorno.Split('\n').Length - 1; // Ajuste conforme formato real
            }
            catch
            {
                return 4; // Default seguro
            }
        }
        private int ObterMeusVotosNao(int numJogadores)
        {
            switch (numJogadores)
            {
                case 3: return 4;
                case 4: return 3;
                case 5:
                case 6: return 2;
                default: return 2;
            }
        }
        // Estratégias específicas por número de jogadores
        private string EstrategiaPara3Jogadores(string cartaRei, bool ehMinhaCarta, int valorCarta, int meusVotosNao)
        {
            // Com 3 jogadores, cada um tem muito poder de veto (4 "Não")
            if (ehMinhaCarta)
            {
                // Se for minha carta, sempre voto "Sim" e guardo votos "Não"
                return "S";
            }

            // Para cartas muito valiosas (A, B, T) - tentar bloquear
            if (valorCarta >= 6 && meusVotosNao > 2)
            {
                return "N";
            }

            // Para cartas medianas, economizar votos
            return "S";
        }
        private string EstrategiaPara4Jogadores(string cartaRei, bool ehMinhaCarta, int valorCarta, int meusVotosNao)
        {
            // Com 4 jogadores, o equilíbrio é mais delicado (3 "Não" cada)
            if (ehMinhaCarta)
            {
                return "S"; // Sempre apoie suas próprias cartas
            }

            // Cartas muito boas: use "Não" se tiver votos suficientes
            if (valorCarta >= 6 && meusVotosNao > 1)
            {
                return "N";
            }

            // Cartas ruins: deixe passar para eliminar personagens fracos
            if (valorCarta <= 2)
            {
                return "S";
            }

            // Padrão: economize votos para cartas realmente perigosas
            return new Random().NextDouble() > 0.7 ? "N" : "S";
        }
        private string EstrategiaPara5Jogadores(string cartaRei, bool ehMinhaCarta, int valorCarta, int meusVotosNao)
        {
            // Com 5 jogadores, cada um tem apenas 2 "Não" (e 2 sobram)
            if (ehMinhaCarta)
            {
                return "S";
            }

            // Só vale a pena votar "Não" em cartas extremamente valiosas
            if (valorCarta >= 7 && meusVotosNao > 0)
            {
                return "N";
            }

            // Para cartas medianas/fracas, deixe passar
            return "S";
        }
        private string EstrategiaPara6Jogadores(string cartaRei, bool ehMinhaCarta, int valorCarta, int meusVotosNao)
        {
            // Com 6 jogadores, cada um tem apenas 2 "Não"
            if (ehMinhaCarta)
            {
                return "S";
            }

            // Só use "Não" se for absolutamente necessário
            if (valorCarta >= 7 && meusVotosNao == 2)
            {
                return "N";
            }

            // Economize votos para o final do jogo
            return "S";
        }
        private void VerificarFimDeJogo()
        {
            try
            {
                string estado = Jogo.VerificarVez(idPartidaAtual);
                if (estado.Contains(",E,"))
                {
                    tmrVerificarVez.Enabled = false;
                    string[] partes = estado.Split(',');

                    if (partes.Length > 4)
                    {
                        lstLog.Items.Add($"=== FIM DE JOGO ==="); // Changed to lstLog
                        lstLog.Items.Add($"Vencedor: {partes[4]}"); // Changed to lstLog
                    }
                    else
                    {
                        lstLog.Items.Add("=== FIM DE JOGO ==="); // Changed to lstLog
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro ao verificar fim de jogo: {ex.Message}");
            }
        }
        private void ReiniciarRodada()
        {
            try
            {
                // Limpa o estado local
                personagensColocados.Clear();
                setores = new Dictionary<int, List<string>>()
                {
                    {1, new List<string>()},
                    {2, new List<string>()},
                    {3, new List<string>()},
                    {4, new List<string>()},
                    {5, new List<string>()},
                    {10, new List<string>()}
                };

                // Limpa o tabuleiro visual
                var cartas = Controls.OfType<PictureBox>().Where(p => p.Tag != null).ToList();
                foreach (var carta in cartas)
                {
                    Controls.Remove(carta);
                    carta.Dispose();
                }

                // Reseta variáveis de votação
                votacaoConcluida = false;
                reiEleito = false;
                ultimaCartaRei = "";

                // Atualiza a interface
                rodadaAtual++;
                lstLog.Items.Add($"Rodada: {rodadaAtual}"); // Changed to lstLog
                lstLog.Items.Add("=== NOVA RODADA INICIADA ==="); // Changed to lstLog
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro ao reiniciar rodada: {ex.Message}");
            }
        }
        private void SincronizarEstadoTabuleiro(bool forcarAtualizacao = false)
        {
            try
            {
                // Inicializa os setores se não existirem
                for (int i = 1; i <= 5; i++)
                {
                    if (!setores.ContainsKey(i))
                    {
                        setores[i] = new List<string>();
                    }
                }
                if (!setores.ContainsKey(10))
                {
                    setores[10] = new List<string>();
                }

                // Restante do método...
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro ao sincronizar tabuleiro: {ex.Message}");
            }
        }

        private bool EstadosSaoIguais(Dictionary<int, List<string>> estado1, Dictionary<int, List<string>> estado2)
        {
            // Comparação simplificada sem usar DictionaryEqual
            if (estado1.Keys.Count != estado2.Keys.Count) return false;

            foreach (var kvp in estado1)
            {
                if (!estado2.ContainsKey(kvp.Key)) return false;
                if (!estado2[kvp.Key].SequenceEqual(kvp.Value)) return false;
            }

            return true;
        }
        private void ProcessarNovaRodada()
        {
            // 1. Limpar estado visual
            Controls.OfType<PictureBox>().ToList().ForEach(p => Controls.Remove(p));

            // 2. Reiniciar estruturas de dados
            personagensColocados.Clear();
            setores = new Dictionary<int, List<string>>()
    {
        {1, new List<string>()},
        {2, new List<string>()},
        {3, new List<string>()},
        {4, new List<string>()},
        {5, new List<string>()},
        {10, new List<string>()}
    };

            // 3. Sincronizar com servidor
            SincronizarEstadoTabuleiro();

            // 4. Processar primeiro movimento
            ProcessarSetup();
        }
        private void ProcessarSetup()
        {
            try
            {
                if (!JogadorDaVez()) return;

                AtualizarMinhasCartas();
                SincronizarEstadoTabuleiro();

                // Verifica se todos os personagens já foram colocados
                if (personagensColocados.Count >= 13) // Total de personagens no jogo
                {
                    lstLog.Items.Add("Todos os personagens já foram posicionados."); // Changed to lstLog
                    return;
                }

                string personagem = EscolherMelhorPersonagemDisponivel();
                if (personagem == null)
                {
                    lstLog.Items.Add("Todos os personagens já foram posicionados no tabuleiro."); // Changed to lstLog
                    return;
                }

                int setor = EscolherMelhorSetorSetup();
                if (setor == -1)
                {
                    // Se não há setores disponíveis, verifica se é um erro de sincronização
                    SincronizarEstadoTabuleiro(true); // Força atualização

                    setor = EscolherMelhorSetorSetup(); // Tenta novamente

                    if (setor == -1)
                    {
                        lstLog.Items.Add("ERRO: Todos os setores de setup estão cheios. Verifique o jogo."); // Changed to lstLog
                        return;
                    }
                }

                PosicionarPersonagem(idJogadorAtual, senhaJogador, personagem, setor);
                lstLog.Items.Add($"Posicionado: {personagem} no setor {setor}"); // Changed to lstLog
                personagensColocados.Add(personagem);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro no ProcessarSetup: {ex.Message}");
            }
        }
        private int EscolherMelhorSetorSetup()
        {
            // Garante que os setores existam no dicionário
            for (int i = 1; i <= 4; i++)
            {
                if (!setores.ContainsKey(i))
                {
                    setores[i] = new List<string>();
                }
            }

            var setoresDisponiveis = setores
                .Where(kv => kv.Key >= 1 && kv.Key <= 4)  // Apenas setores 1-4 no setup
                .Where(kv => kv.Value.Count < 4)          // Com espaço disponível (máx 4 cartas)
                .OrderBy(kv => kv.Value.Count)            // Preferir setores menos ocupados
                .ThenBy(kv => kv.Key)                     // Em caso de empate, escolher o menor número
                .Select(kv => kv.Key)
                .ToList();

            return setoresDisponiveis.Any() ? setoresDisponiveis.First() : -1;
            // Retorna -1 se nenhum setor disponível
        }
        private void AtualizarTabuleiroVisual()
        {
            if (InvokeRequired)
            {
                Invoke(new Action(AtualizarTabuleiroVisual));
                return;
            }

            // Remove apenas as PictureBox de cartas
            var cartas = Controls.OfType<PictureBox>().Where(p => p.Tag != null).ToList();
            foreach (var carta in cartas)
            {
                Controls.Remove(carta);
                carta.Dispose();
            }

            // Recria todas as cartas baseadas no estado atual
            foreach (var setor in setores)
            {
                foreach (var carta in setor.Value)
                {
                    PosicionarCarta(setor.Key, carta);
                }
            }
        }

        private void ProcessarPromocao()
        {
            try
            {
                if (!JogadorDaVez()) return;

                AtualizarMinhasCartas();
                SincronizarEstadoTabuleiro();

                // Prioridade 1: Promover para o KingsMe se possível
                if (setores.ContainsKey(5) && setores[5].Count > 0 &&
                    (!setores.ContainsKey(10) || setores[10].Count == 0))
                {
                    // Escolhe o melhor personagem no setor 5
                    var melhorPersonagem = setores[5]
    .OrderByDescending(p => rankingPersonagens.ContainsKey(p) ? rankingPersonagens[p] : 0)
    .FirstOrDefault();


                    if (melhorPersonagem != null)
                    {
                        string resultado = Jogo.Promover(idJogadorAtual, senhaJogador, melhorPersonagem);

                        if (!resultado.StartsWith("ERRO:"))
                        {
                            lstLog.Items.Add($"Promovido estrategicamente para KingsMe: {melhorPersonagem}"); // Changed to lstLog
                            return;
                        }
                    }
                }

                // Prioridade 2: Promover personagens valiosos em setores inferiores
                for (int setorAtual = 1; setorAtual <= 4; setorAtual++)
                {
                    if (setores.ContainsKey(setorAtual) && setores[setorAtual].Count > 0)
                    {
                        int setorDestino = setorAtual + 1;

                        // Verifica se o setor de destino tem espaço
                        if (!setores.ContainsKey(setorDestino) || setores[setorDestino].Count < 4)
                        {
                            // Escolhe o melhor personagem neste setor
                            var melhorPersonagem = setores[setorAtual]
    .OrderByDescending(p => rankingPersonagens.ContainsKey(p) ? rankingPersonagens[p] : 0)
    .FirstOrDefault();


                            if (melhorPersonagem != null)
                            {
                                string resultado = Jogo.Promover(idJogadorAtual, senhaJogador, melhorPersonagem);

                                if (!resultado.StartsWith("ERRO:"))
                                {
                                    lstLog.Items.Add($"Promovido estrategicamente: {melhorPersonagem} (Setor {setorAtual}->{setorDestino})"); // Changed to lstLog
                                    return;
                                }
                            }
                        }
                    }
                }

                lstLog.Items.Add("Nenhuma promoção estratégica possível no momento."); // Changed to lstLog
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro em ProcessarPromocao: {ex.Message}");
            }
        }
        private bool votacaoEmAndamento = false;
        private string ultimaCartaRei = "";
        private bool votacaoConcluida = false;
        private void ProcessarVotacao()
        {
            try
            {
                if (!JogadorDaVez()) return;

                SincronizarEstadoTabuleiro();

                // Verifica se há uma nova carta no KingsMe (setor 10)
                if (setores.ContainsKey(10) && setores[10].Count > 0)
                {
                    string cartaReiAtual = setores[10][0];

                    // Resetar estado se é uma nova votação
                    if (cartaReiAtual != ultimaCartaRei)
                    {
                        votacaoConcluida = false;
                        ultimaCartaRei = cartaReiAtual;
                        lstLog.Items.Add($"Nova votação iniciada para: {cartaReiAtual}"); // Changed to lstLog
                    }

                    if (!votacaoConcluida)
                    {
                        string voto = EscolherVotoEstrategico(cartaReiAtual);

                        string resultado = Jogo.Votar(idJogadorAtual, senhaJogador, voto);

                        if (!resultado.StartsWith("ERRO:"))
                        {
                            votacaoConcluida = true;
                            lstLog.Items.Add($"Voto registrado: {voto} para {cartaReiAtual}"); // Changed to lstLog

                            if (voto == "S")
                            {
                                reiEleito = true;
                            }
                        }
                        else
                        {
                            lstLog.Items.Add($"Erro ao votar: {resultado}"); // Changed to lstLog
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro em ProcessarVotacao: {ex.Message}");
            }
        }
        private bool JogadorConectado()
        {
            return idPartidaAtual > 0 && idJogadorAtual > 0 && !string.IsNullOrWhiteSpace(senhaJogador);
        }

        private void PromoverPersonagens()
        {
            try
            {
                // Primeiro sincroniza com o estado real do servidor
                SincronizarEstadoTabuleiro();

                int idJogador = Convert.ToInt32(txtIDjogador.Text);
                string senha = txtSenhaJogador.Text;

                // Lista de prioridade: tenta promover para o KingsMe primeiro
                if (setores.ContainsKey(5) && setores[5].Count > 0 &&
                    (!setores.ContainsKey(10) || setores[10].Count == 0))
                {
                    string personagem = setores[5][0];
                    string resultado = Jogo.Promover(idJogador, senha, personagem);

                    if (!resultado.StartsWith("ERRO:"))
                    {
                        lstLog.Items.Add($"Promovido para KingsMe: {personagem}"); // Changed to lstLog
                        return;
                    }
                }

                // Se não conseguiu promover para KingsMe, tenta promover nos outros setores
                for (int setorAtual = 1; setorAtual <= 4; setorAtual++)
                {
                    if (setores.ContainsKey(setorAtual) && setores[setorAtual].Count > 0)
                    {
                        int setorDestino = setorAtual + 1;

                        // Verifica se o setor de destino tem espaço
                        if (!setores.ContainsKey(setorDestino))
                            setores[setorDestino] = new List<string>();

                        if (setores[setorDestino].Count < 4)
                        {
                            string personagem = setores[setorAtual][0];
                            string resultado = Jogo.Promover(idJogador, senha, personagem);

                            if (!resultado.StartsWith("ERRO:"))
                            {
                                lstLog.Items.Add($"Promovido: {personagem} (Setor {setorAtual} -> {setorDestino})"); // Changed to lstLog
                                return;
                            }
                        }
                    }
                }

                lstLog.Items.Add("Nenhuma promoção possível no momento."); // Changed to lstLog
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro em PromoverPersonagens: {ex.Message}");
            }
        }
        private string SortearPersonagemDisponivel()
        {
            try
            {
                string retorno = Jogo.ListarPersonagens();
                if (retorno.StartsWith("ERRO:"))
                {
                    Console.WriteLine($"Erro ao listar personagens: {retorno}");
                    return null;
                }

                retorno = retorno.Replace("\r", "").Trim();
                string[] todos = retorno.Split('\n');

                // Obter personagens já no tabuleiro diretamente do estado atual
                var estadoTabuleiro = EstadoAtualTabuleiro();
                var personagensNoTabuleiro = ObterPersonagensNoTabuleiro(estadoTabuleiro);

                // Debug: Mostrar personagens disponíveis
                Console.WriteLine("Todos os personagens: " + string.Join(",", todos));
                Console.WriteLine("Personagens no tabuleiro: " + string.Join(",", personagensNoTabuleiro));

                List<string> disponiveis = todos
                    .Where(p => !string.IsNullOrWhiteSpace(p))
                    .Select(p => p.Trim())
                    .Where(p => !personagensNoTabuleiro.Contains(p))
                    .ToList();

                // Debug: Mostrar personagens disponíveis após filtro
                Console.WriteLine("Personagens disponíveis: " + string.Join(",", disponiveis));

                if (disponiveis.Count == 0)
                {
                    Console.WriteLine("Nenhum personagem disponível para posicionar.");
                    return null;
                }

                // Seleção verdadeiramente aleatória
                int index = random.Next(disponiveis.Count);
                string selecionado = disponiveis[index];
                Console.WriteLine($"Personagem selecionado aleatoriamente: {selecionado}");

                return selecionado;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro em SortearPersonagemDisponivel: {ex.Message}");
                return null;
            }
        }

        // Método auxiliar para extrair personagens do tabuleiro
        private HashSet<string> ObterPersonagensNoTabuleiro(string estadoTabuleiro)
        {
            var personagens = new HashSet<string>();
            string[] linhas = estadoTabuleiro.Split(new[] { "\r\n", "\n", "\r" }, StringSplitOptions.RemoveEmptyEntries);

            foreach (string linha in linhas)
            {
                string[] partes = linha.Split(',');
                if (partes.Length == 2)
                {
                    personagens.Add(partes[1].Trim());
                }
            }

            return personagens;
        }

        private int SortearSetorDisponivel()
        {
            // Durante a fase de setup, só permitir setores 1-4
            var setoresValidos = setores
                .Where(kv => kv.Key >= 1 && kv.Key <= 4)  // Apenas setores 1-4
                .Where(kv => kv.Value.Count < 4)          // Com espaço disponível
                .Select(kv => kv.Key)
                .ToList();

            if (setoresValidos.Count == 0)
                return -1;

            return setoresValidos[random.Next(setoresValidos.Count)];
        }

        private void PosicionarPersonagem(int idJogador, string senha, string personagem, int setor)
        {
            try
            {
                if (setor < 1 || setor > 4)
                {
                    Console.WriteLine($"Setor {setor} inválido para fase de setup.");
                    return;
                }

                // Verifica se o setor tem espaço
                if (setores.ContainsKey(setor) && setores[setor].Count >= 4)
                {
                    Console.WriteLine($"Setor {setor} já está cheio.");
                    return;
                }

                if (string.IsNullOrWhiteSpace(personagem))
                {
                    personagem = EscolherMelhorPersonagemDisponivel();
                    if (personagem == null)
                    {
                        Console.WriteLine("Nenhum personagem disponível para posicionar.");
                        return;
                    }
                }

                string inicial = personagem.Substring(0, 1);
                string estadoAtual = Jogo.ColocarPersonagem(idJogador, senha, setor, inicial);

                if (estadoAtual.StartsWith("ERRO:"))
                {
                    Console.WriteLine($"Erro ao posicionar: {estadoAtual}");

                    // Tenta o próximo personagem disponível
                    string proximoPersonagem = EscolherMelhorPersonagemDisponivel();
                    if (proximoPersonagem != null && proximoPersonagem != personagem)
                    {
                        PosicionarPersonagem(idJogador, senha, proximoPersonagem, setor);
                    }
                    return;
                }

                // Atualiza as estruturas locais
                personagensColocados.Add(personagem);
                if (!setores.ContainsKey(setor))
                {
                    setores[setor] = new List<string>();
                }
                setores[setor].Add(personagem);

                lstLog.Items.Add($"Posicionado: {personagem} no setor {setor}"); // Changed to lstLog
                AtualizarRodada(estadoAtual);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro em PosicionarPersonagem: {ex.Message}");
            }
        }

        private void SincronizarEstadoTabuleiro()
        {
            try
            {
                string estadoTabuleiro = EstadoAtualTabuleiro();
                var novoEstado = new Dictionary<int, List<string>>();
                var linhas = estadoTabuleiro.Split(new[] { "\r\n", "\n", "\r" }, StringSplitOptions.RemoveEmptyEntries);

                personagensColocados.Clear();

                foreach (string linha in linhas)
                {
                    var partes = linha.Split(',');
                    if (partes.Length == 2 && int.TryParse(partes[0].Trim(), out int setor))
                    {
                        string personagem = partes[1].Trim();

                        if (!novoEstado.ContainsKey(setor))
                            novoEstado[setor] = new List<string>();

                        novoEstado[setor].Add(personagem);
                        personagensColocados.Add(personagem);
                    }
                }

                setores = novoEstado;
                AtualizarTabuleiroVisual();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro ao sincronizar tabuleiro: {ex.Message}");
            }
        }
        private string EscolherMelhorPersonagemDisponivel()
        {
            try
            {
                // Primeiro verifica nas cartas do jogador
                var cartasDisponiveis = minhasCartas
                    .Except(personagensColocados)
                    .OrderByDescending(c => rankingPersonagens.ContainsKey(c) ? rankingPersonagens[c] : 0).ToList();


                if (cartasDisponiveis.Count > 0)
                {
                    return cartasDisponiveis.First();
                }

                // Se não tiver mais cartas nas mãos, verifica todas as cartas do jogo
                var todasCartas = rankingPersonagens.Keys.ToList();
                var todasDisponiveis = todasCartas
                    .Except(personagensColocados)
                    .OrderByDescending(c => rankingPersonagens.ContainsKey(c) ? rankingPersonagens[c] : 0).ToList();

                return todasDisponiveis.FirstOrDefault();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro em EscolherMelhorPersonagemDisponivel: {ex.Message}");
                return null;
            }
        }

        private void Lobby_Load(object sender, EventArgs e)
        {

        }

        private void lblCartas_Click(object sender, EventArgs e)
        {

        }


        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }



        private void lstJogadores_SelectedIndexChanged(object sender, EventArgs e) { }
        private void lstVerificarVez_SelectedIndexChanged(object sender, EventArgs e) { }

        private void txtIDjogador_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtSetor_TextChanged(object sender, EventArgs e)
        {

        }
    }
}