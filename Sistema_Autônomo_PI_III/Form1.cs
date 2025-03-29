using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using KingMeServer;

namespace Sistema_Autônomo_PI_III
{
    public partial class Form1 : Form
    {
        private Personagens personagensForm;

        public Form1(Personagens formPersonagens)
        {
            InitializeComponent();
            lblversao.Text = Jogo.versao;
            txtNomeGrupo.Text = "CavaleirosCanterbury";

            this.personagensForm = formPersonagens;


            string setores = Jogo.ListarSetores();
            string[] listaSetores = setores.Split('\n'); // Supondo que os setores estão separados por quebras de linha.

            lstSetores.Items.Clear();  // Limpa os itens anteriores.
            foreach (var setor in listaSetores)
            {
                lstSetores.Items.Add(setor);  // Adiciona cada setor na ListBox.
            }

            string Personagens = Jogo.ListarPersonagens();
            string[] listaPersonagens = Personagens.Split('\n'); // Supondo que os personagens estão separados por quebras de linha.

            lstPersonagens.Items.Clear();  // Limpa os itens anteriores.
            foreach (var Personagem in listaPersonagens)
            {
                lstPersonagens.Items.Add(Personagem);  // Adiciona cada setor na ListBox.
            }
        }

        int idPartidaAtual; //declara de maneira global idPartidaAtual
        string[] dadosPartida; //declara de maneira global dadosPartida
        string partida;
        //private string carateres;

        void btnCriar_Click(object sender, EventArgs e)
        {

            string partida = Jogo.CriarPartida($"{txtNomePartida.Text}", $"{txtSenhaPartida.Text}", "CavaleirosCanterbury");


            if (partida.StartsWith("ERRO") || partida.Contains("erro"))  // Verifica se o retorno contém erro
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

            int verificarEntrada = VerificaEntrarPartida(nomeJogador, senhaPartida, txtIdPartida.Text);
            string verificar = Convert.ToString(verificarEntrada);

            if (verificar.StartsWith("ERRO") || verificar.Contains("erro"))  // Verifica se o retorno contém erro
            {
                lblInforma.Text = verificar;
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
            else if (jogador.StartsWith("ERRO") || jogador.Contains("erro"))  // Verifica se o retorno contém erro
            {
                lblInforma.Text = jogador;
                return;
            }
            {
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
            int idJogador = Int32.Parse(txtIDjogador.Text);

            lblCartas.Text = Jogo.ListarCartas(idJogador, txtSenhaJogador.Text);
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


        private void btnIniciarJogo_Click(object sender, EventArgs e)
        {
            int idJogador = Int32.Parse(txtIDjogador.Text);
            string retorno;
            retorno = Jogo.Iniciar(idJogador, txtSenhaJogador.Text);
            lblIDjogadorVez.Text = retorno;
            lblNomeJogadorVez.Text = $" {txtNomeJogador.Text}";
            MessageBox.Show("Partida Iniciada!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private Dictionary<string, string> mapaPersonagens = new Dictionary<string, string>
{
    { "A", "Carta A.jpeg" },
    { "B", "Carta B.jpeg" },
    { "D", "Carta D.jpeg" },
    { "E", "Carta E.jpeg" },
    { "G", "Carta G.jpeg" },
    { "I", "Carta I.jpeg" },
    { "K", "Carta K.jpeg" },
    { "M", "Carta M.jpeg" },
    { "Q", "Carta Q.jpeg" }

};

        private void btnVerificarVez_Click(object sender, EventArgs e)
        {
            idPartidaAtual = Convert.ToInt32(dadosPartida[0]); // converte o id da partida

            string retorno = Jogo.VerificarVez(idPartidaAtual);  //cria uma string para receber o id
            retorno = retorno.Replace("\r", "");  // cria espaço entre cada verificaçao
            string[] verificar = retorno.Split('\n');

            lstVerificarVez.Items.Clear();  //limpa os itens anteriores da listbox
            for (int i = 0; i < verificar.Length; i++)
            {
                lstVerificarVez.Items.Add(verificar[i]); //Verifica a vez do jogador

            }
        }

        private void CriarJogador(int setor, string nomeJogador, string imagemPersonagem)
        {

            if (personagensForm.setores.TryGetValue(setor, out Point posicao))  // Obtém a posição do setor
            {
                PictureBox jogadorPictureBox = new PictureBox
                {
                    Size = new Size(37, 63),  // Define o tamanho da imagem
                    Location = posicao,  // Posição correta do jogador
                    BackgroundImage = Image.FromFile("Imagens/" + imagemPersonagem), // Carrega a imagem
                    BackgroundImageLayout = ImageLayout.Stretch,  // Ajusta o tamanho
                    Name = nomeJogador
                };

                // Adiciona ao formulário
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

            // Atualiza a ListBox lstVerificarVez com o personagem e setor escolhidos
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
    }
}