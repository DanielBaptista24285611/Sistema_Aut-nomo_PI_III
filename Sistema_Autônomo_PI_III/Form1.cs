// Form1.cs
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
        private Personagens personagensForm;
        private Rodada rodadaAtual;

        public Form1(Personagens formPersonagens)
        {
            InitializeComponent();
            lblversao.Text = Jogo.versao;
            txtNomeGrupo.Text = "CavaleirosCanterbury";

            this.personagensForm = formPersonagens;

            string setores = Jogo.ListarSetores();
            string[] listaSetores = setores.Split('\n');
            lstSetores.Items.Clear();
            foreach (var setor in listaSetores)
            {
                lstSetores.Items.Add(setor);
            }

            string Personagens = Jogo.ListarPersonagens();
            string[] listaPersonagens = Personagens.Split('\n');
            lstPersonagens.Items.Clear();
            foreach (var Personagem in listaPersonagens)
            {
                lstPersonagens.Items.Add(Personagem);
            }
        }

        int idPartidaAtual;
        string[] dadosPartida;
        string partida;

        void btnCriar_Click(object sender, EventArgs e)
        {
            string partida = Jogo.CriarPartida($"{txtNomePartida.Text}", $"{txtSenhaPartida.Text}", "CavaleirosCanterbury");
            if (partida.StartsWith("ERRO") || partida.Contains("erro"))
            {
                lblInforma.Text = partida;
                return;
            }
            lblInforma.Text = "Partida Criada!";
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
            idPartidaAtual = Convert.ToInt32(dadosPartida[0]);
            string retorno = Jogo.ListarJogadores(idPartidaAtual);
            retorno = retorno.Replace("\r", "");
            string[] jogadores = retorno.Split('\n');
            lstJogadores.Items.Clear();
            for (int i = 0; i < jogadores.Length; i++)
            {
                lstJogadores.Items.Add(jogadores[i]);
            }
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            string nomeJogador = txtNomeJogador.Text;
            string senhaPartida = txtSenhaPartida.Text;
            rodadaAtual = new Rodada(1, nomeJogador);
            AtualizarStatusRodada();

            int verificarEntrada = VerificaEntrarPartida(nomeJogador, senhaPartida, txtIdPartida.Text);
            string verificar = Convert.ToString(verificarEntrada);

            if (verificar.StartsWith("ERRO") || verificar.Contains("erro"))
            {
                lblInforma.Text = verificar;
                return;
            }

            string jogador = Jogo.Entrar(idPartidaAtual, nomeJogador, senhaPartida);
            string[] dadosJogador = jogador.Split(',');

            if (dadosJogador.Length == 2)
            {
                lblidJogador.Text = $"ID do Jogador: {dadosJogador[0]}";
                lblsenha.Text = $"Senha: {dadosJogador[1]}";
                txtIDjogador.Text = dadosJogador[0];
                txtSenhaJogador.Text = dadosJogador[1];
            }
            else if (jogador.StartsWith("ERRO") || jogador.Contains("erro"))
            {
                lblInforma.Text = jogador;
                return;
            }
        }

        private void AtualizarStatusRodada()
        {
            if (rodadaAtual != null)
            {
                lstVerificarVez.Items.Clear();
                lstVerificarVez.Items.Add(rodadaAtual.ToString());
            }
        }

        private void lstPartidas_SelectedIndexChanged(object sender, EventArgs e)
        {
            partida = lstPartidas.SelectedItem.ToString();
            dadosPartida = partida.Split(',');
            idPartidaAtual = Convert.ToInt32(dadosPartida[0]);
            lblInforma.Text = idPartidaAtual.ToString();
            txtIdPartida.Text = lblInforma.Text;
        }

        private void btnExibirCartas_Click(object sender, EventArgs e)
        {
            int idJogador = Int32.Parse(txtIDjogador.Text);
            lblCartas.Text = Jogo.ListarCartas(idJogador, txtSenhaJogador.Text);
        }

        private void btnVerificarVez_Click(object sender, EventArgs e)
        {
            idPartidaAtual = Convert.ToInt32(dadosPartida[0]);
            string retorno = Jogo.VerificarVez(idPartidaAtual);
            retorno = retorno.Replace("\r", "");
            string[] verificar = retorno.Split('\n');
            lstVerificarVez.Items.Clear();
            for (int i = 0; i < verificar.Length; i++)
            {
                lstVerificarVez.Items.Add(verificar[i]);
            }
        }

        public int VerificaEntrarPartida(string nomeJogador, string senhaPartida, string idPartida)
        {
            if (string.IsNullOrWhiteSpace(idPartida)) return 1;
            if (string.IsNullOrWhiteSpace(senhaPartida)) return 2;
            if (string.IsNullOrWhiteSpace(nomeJogador)) return 3;
            return 0;
        }

        private void btnIniciarJogo_Click(object sender, EventArgs e)
        {
            int idJogador = Int32.Parse(txtIDjogador.Text);
            string retorno = Jogo.Iniciar(idJogador, txtSenhaJogador.Text);
            lblIDjogadorVez.Text = retorno;
            lblNomeJogadorVez.Text = $" {txtNomeJogador.Text}";
            MessageBox.Show("Partida Iniciada!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private Dictionary<string, string> mapaPersonagens = new Dictionary<string, string>
        {
            { "A", "Carta A.jpeg" }, { "B", "Carta B.jpeg" }, { "D", "Carta D.jpeg" },
            { "E", "Carta E.jpeg" }, { "G", "Carta G.jpeg" }, { "I", "Carta I.jpeg" },
            { "K", "Carta K.jpeg" }, { "M", "Carta M.jpeg" }, { "Q", "Carta Q.jpeg" }
        };

        private void CriarJogador(int setor, string nomeJogador, string imagemPersonagem)
        {
            if (personagensForm.setores.TryGetValue(setor, out Point posicao))
            {
                PictureBox jogadorPictureBox = new PictureBox
                {
                    Size = new Size(37, 63),
                    Location = posicao,
                    BackgroundImage = Image.FromFile("Imagens/" + imagemPersonagem),
                    BackgroundImageLayout = ImageLayout.Stretch,
                    Name = nomeJogador
                };
                this.Controls.Add(jogadorPictureBox);
            }
        }

        private void btnColocarPersonagem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtSetor.Text) || string.IsNullOrEmpty(txtPersonagem.Text))
            {
                MessageBox.Show("Informe o Setor e o Personagem.");
                return;
            }

            if (!int.TryParse(txtIDjogador.Text, out int jogador1))
            {
                MessageBox.Show("O ID do jogador deve ser um número válido.");
                return;
            }

            string senha = txtSenhaJogador.Text;
            string setoresStr = Jogo.ListarSetores().Replace("\r", "");
            string[] setores = setoresStr.Split(new string[] { "\n" }, StringSplitOptions.RemoveEmptyEntries);
            string personagensStr = Jogo.ListarPersonagens().Replace("\r", "");
            string[] personagens = personagensStr.Split(new string[] { "\n" }, StringSplitOptions.RemoveEmptyEntries);

            List<int> idsSetores = new List<int>();
            foreach (string setor in setores)
            {
                string[] partes = setor.Split(',');
                if (partes.Length > 1 && int.TryParse(partes[0], out int idSetor))
                {
                    idsSetores.Add(idSetor);
                }
            }

            if (!int.TryParse(txtSetor.Text, out int setorSelecionado) || !idsSetores.Contains(setorSelecionado))
            {
                MessageBox.Show("O setor digitado não é válido.");
                return;
            }

            string personagemSelecionado = txtPersonagem.Text.Trim();
            if (string.IsNullOrEmpty(personagemSelecionado))
            {
                MessageBox.Show("O personagem digitado não pode estar vazio.");
                return;
            }

            personagemSelecionado = personagemSelecionado.Substring(0, 1).ToUpper();
            bool personagemValido = personagens.Any(p => p.StartsWith(personagemSelecionado, StringComparison.OrdinalIgnoreCase));

            if (!personagemValido)
            {
                MessageBox.Show("O personagem digitado não é válido.");
                return;
            }

            string resultado = Jogo.ColocarPersonagem(jogador1, senha, setorSelecionado, personagemSelecionado);
            MessageBox.Show(resultado);

            // Mostrar graficamente o personagem no tabuleiro
            if (mapaPersonagens.TryGetValue(personagemSelecionado, out string imagem))
            {
                CriarJogador(setorSelecionado, txtNomeJogador.Text, imagem);
            }
            else
            {
                MessageBox.Show("Imagem do personagem não encontrada no dicionário.");
            }

            lstVerificarVez.Items.Clear();
        }


        private void btnPersonagens_Click(object sender, EventArgs e)
        {
            Personagens personagem = new Personagens();
            personagem.ShowDialog();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnPromover_Click(object sender, EventArgs e)
        {
            string nomePersonagem = txtPersonagem.Text;

            if (rodadaAtual.PodePromover())
            {
                bool sucesso = rodadaAtual.PromoverPersonagem(nomePersonagem);
                if (sucesso)
                {
                    MessageBox.Show($"{nomePersonagem} promovido com sucesso!");
                    if (rodadaAtual.FaseAtual == FaseRodada.Votacao)
                    {
                        MessageBox.Show("Hora de votar!");
                    }
                    AtualizarStatusRodada();
                }
                else
                {
                    MessageBox.Show("Não foi possível promover esse personagem.");
                }
            }
            else
            {
                MessageBox.Show("Já foram promovidos 3 personagens. Vá para a votação.");
            }
        }

        private void btnConfirmarVoto_Click(object sender, EventArgs e)
        {
            if (rodadaAtual.FaseAtual != FaseRodada.Votacao)
            {
                MessageBox.Show("Ainda não estamos na fase de votação.");
                return;
            }

            string votoTexto = txtVoto.Text.Trim().ToUpper();

            if (votoTexto != "S" && votoTexto != "N")
            {
                MessageBox.Show("Digite S para sim ou N para não.");
                return;
            }

            bool votoSim = votoTexto == "S";
            string nomeJogador = txtNomeJogador.Text;

            bool sucesso = rodadaAtual.RegistrarVoto(nomeJogador, votoSim);

            if (sucesso)
            {
                MessageBox.Show($"Voto '{votoTexto}' registrado com sucesso!");

                List<string> todosJogadores = lstJogadores.Items.Cast<string>()
                    .Select(j => j.Split(',')[1].Trim()) // Ajuste conforme formato
                    .ToList();

                int votosFeitos = rodadaAtual.ObterTotalVotos();
                int votosTotais = todosJogadores.Count;

                lblVotosRestantes.Text = $"Votos restantes: {votosTotais - votosFeitos}";

                if (rodadaAtual.TodosVotaram(todosJogadores))
                {
                    string resultado = rodadaAtual.ResultadoVotacao();
                    MessageBox.Show($"Resultado da votação: {resultado}");
                }

                txtVoto.Clear();
            }
            else
            {
                MessageBox.Show("Você já votou nessa rodada.");
            }
        }



        private void lstJogadores_SelectedIndexChanged(object sender, EventArgs e) { }
        private void lstVerificarVez_SelectedIndexChanged(object sender, EventArgs e) { }
    }
}
