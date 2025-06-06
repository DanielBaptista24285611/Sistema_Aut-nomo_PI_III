using System;

namespace Sistema_Autônomo_PI_III
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lblNomePartida = new System.Windows.Forms.Label();
            this.lblSenhaPartida = new System.Windows.Forms.Label();
            this.txtSenhaPartida = new System.Windows.Forms.TextBox();
            this.btnCriar = new System.Windows.Forms.Button();
            this.txtNomeGrupo = new System.Windows.Forms.TextBox();
            this.lblIdPartida = new System.Windows.Forms.Label();
            this.txtIdPartida = new System.Windows.Forms.TextBox();
            this.txtNomePartida = new System.Windows.Forms.TextBox();
            this.btnListarPartidas = new System.Windows.Forms.Button();
            this.lblNomeGrupo = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.txtNomeJogador = new System.Windows.Forms.TextBox();
            this.btnEntrar = new System.Windows.Forms.Button();
            this.btnListarJogadores = new System.Windows.Forms.Button();
            this.lblInforma = new System.Windows.Forms.Label();
            this.lstJogadores = new System.Windows.Forms.ListBox();
            this.label6 = new System.Windows.Forms.Label();
            this.lblidJogador = new System.Windows.Forms.Label();
            this.lblversao = new System.Windows.Forms.Label();
            this.btnIniciarJogo = new System.Windows.Forms.Button();
            this.lblNomeJogador = new System.Windows.Forms.Label();
            this.txtIDjogador = new System.Windows.Forms.TextBox();
            this.lblSenhaJogador = new System.Windows.Forms.Label();
            this.txtSenhaJogador = new System.Windows.Forms.TextBox();
            this.lblCartas = new System.Windows.Forms.Label();
            this.lblsenha = new System.Windows.Forms.Label();
            this.lstPartidas = new System.Windows.Forms.ListBox();
            this.lstVerificarVez = new System.Windows.Forms.ListBox();
            this.btnExibirCartas = new System.Windows.Forms.Button();
            this.lblIDjogadorVez = new System.Windows.Forms.Label();
            this.lblNomeJogadorVez = new System.Windows.Forms.Label();
            this.btnColocarPersonagem = new System.Windows.Forms.Button();
            this.txtSetor = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPersonagem = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtVoto = new System.Windows.Forms.TextBox();
            this.btnExibirUltimaVotacao = new System.Windows.Forms.Button();
            this.btnVerificarVezETabuleiro = new System.Windows.Forms.Button();
            this.btnHistorico = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lstSetores = new System.Windows.Forms.ListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.lstPersonagens = new System.Windows.Forms.ListBox();
            this.btnPersonagens = new System.Windows.Forms.Button();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.lblVotosRestantes = new System.Windows.Forms.Label();
            this.tmrVerificarVez = new System.Windows.Forms.Timer(this.components);
            this.tmrGeral = new System.Windows.Forms.Timer(this.components);
            this.btnIniciarAutomacao = new System.Windows.Forms.Button();
            this.btnPromover = new System.Windows.Forms.Button();
            this.btnConfirmarVoto = new System.Windows.Forms.Button();
            this.tmrAutomatizador = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // lblNomePartida
            // 
            this.lblNomePartida.AutoSize = true;
            this.lblNomePartida.Location = new System.Drawing.Point(42, 14);
            this.lblNomePartida.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNomePartida.Name = "lblNomePartida";
            this.lblNomePartida.Size = new System.Drawing.Size(127, 20);
            this.lblNomePartida.TabIndex = 3;
            this.lblNomePartida.Text = "Nome da Partida";
            // 
            // lblSenhaPartida
            // 
            this.lblSenhaPartida.AutoSize = true;
            this.lblSenhaPartida.Location = new System.Drawing.Point(42, 81);
            this.lblSenhaPartida.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSenhaPartida.Name = "lblSenhaPartida";
            this.lblSenhaPartida.Size = new System.Drawing.Size(132, 20);
            this.lblSenhaPartida.TabIndex = 5;
            this.lblSenhaPartida.Text = "Senha da Partida";
            // 
            // txtSenhaPartida
            // 
            this.txtSenhaPartida.Location = new System.Drawing.Point(46, 106);
            this.txtSenhaPartida.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtSenhaPartida.Name = "txtSenhaPartida";
            this.txtSenhaPartida.Size = new System.Drawing.Size(208, 26);
            this.txtSenhaPartida.TabIndex = 6;
            // 
            // btnCriar
            // 
            this.btnCriar.Location = new System.Drawing.Point(291, 29);
            this.btnCriar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCriar.Name = "btnCriar";
            this.btnCriar.Size = new System.Drawing.Size(148, 108);
            this.btnCriar.TabIndex = 7;
            this.btnCriar.Text = "Criar Partida";
            this.btnCriar.UseVisualStyleBackColor = true;
            this.btnCriar.Click += new System.EventHandler(this.btnCriar_Click);
            // 
            // txtNomeGrupo
            // 
            this.txtNomeGrupo.Location = new System.Drawing.Point(46, 189);
            this.txtNomeGrupo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtNomeGrupo.Name = "txtNomeGrupo";
            this.txtNomeGrupo.Size = new System.Drawing.Size(208, 26);
            this.txtNomeGrupo.TabIndex = 12;
            // 
            // lblIdPartida
            // 
            this.lblIdPartida.AutoSize = true;
            this.lblIdPartida.Location = new System.Drawing.Point(42, 249);
            this.lblIdPartida.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblIdPartida.Name = "lblIdPartida";
            this.lblIdPartida.Size = new System.Drawing.Size(99, 20);
            this.lblIdPartida.TabIndex = 15;
            this.lblIdPartida.Text = "Id da Partida";
            // 
            // txtIdPartida
            // 
            this.txtIdPartida.Location = new System.Drawing.Point(46, 274);
            this.txtIdPartida.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtIdPartida.Name = "txtIdPartida";
            this.txtIdPartida.Size = new System.Drawing.Size(208, 26);
            this.txtIdPartida.TabIndex = 14;
            // 
            // txtNomePartida
            // 
            this.txtNomePartida.Location = new System.Drawing.Point(46, 39);
            this.txtNomePartida.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtNomePartida.Name = "txtNomePartida";
            this.txtNomePartida.Size = new System.Drawing.Size(208, 26);
            this.txtNomePartida.TabIndex = 16;
            // 
            // btnListarPartidas
            // 
            this.btnListarPartidas.Location = new System.Drawing.Point(46, 329);
            this.btnListarPartidas.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnListarPartidas.Name = "btnListarPartidas";
            this.btnListarPartidas.Size = new System.Drawing.Size(145, 34);
            this.btnListarPartidas.TabIndex = 17;
            this.btnListarPartidas.Text = "Listar Partidas";
            this.btnListarPartidas.UseVisualStyleBackColor = true;
            this.btnListarPartidas.Click += new System.EventHandler(this.btnListarPartidas_Click);
            // 
            // lblNomeGrupo
            // 
            this.lblNomeGrupo.AutoSize = true;
            this.lblNomeGrupo.Location = new System.Drawing.Point(42, 165);
            this.lblNomeGrupo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNomeGrupo.Name = "lblNomeGrupo";
            this.lblNomeGrupo.Size = new System.Drawing.Size(122, 20);
            this.lblNomeGrupo.TabIndex = 18;
            this.lblNomeGrupo.Text = "Nome do Grupo";
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(42, 579);
            this.lblNome.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(135, 20);
            this.lblNome.TabIndex = 20;
            this.lblNome.Text = "Nome do Jogador";
            // 
            // txtNomeJogador
            // 
            this.txtNomeJogador.Location = new System.Drawing.Point(46, 602);
            this.txtNomeJogador.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtNomeJogador.Name = "txtNomeJogador";
            this.txtNomeJogador.Size = new System.Drawing.Size(208, 26);
            this.txtNomeJogador.TabIndex = 19;
            // 
            // btnEntrar
            // 
            this.btnEntrar.Location = new System.Drawing.Point(294, 586);
            this.btnEntrar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnEntrar.Name = "btnEntrar";
            this.btnEntrar.Size = new System.Drawing.Size(161, 48);
            this.btnEntrar.TabIndex = 21;
            this.btnEntrar.Text = "Entrar na Partida";
            this.btnEntrar.UseVisualStyleBackColor = true;
            this.btnEntrar.Click += new System.EventHandler(this.btnEntrar_Click);
            // 
            // btnListarJogadores
            // 
            this.btnListarJogadores.Location = new System.Drawing.Point(51, 672);
            this.btnListarJogadores.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnListarJogadores.Name = "btnListarJogadores";
            this.btnListarJogadores.Size = new System.Drawing.Size(141, 32);
            this.btnListarJogadores.TabIndex = 22;
            this.btnListarJogadores.Text = "Listar Jogadores";
            this.btnListarJogadores.UseVisualStyleBackColor = true;
            this.btnListarJogadores.Click += new System.EventHandler(this.btnListarJogadores_Click);
            // 
            // lblInforma
            // 
            this.lblInforma.AutoSize = true;
            this.lblInforma.Location = new System.Drawing.Point(289, 165);
            this.lblInforma.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblInforma.Name = "lblInforma";
            this.lblInforma.Size = new System.Drawing.Size(130, 20);
            this.lblInforma.TabIndex = 26;
            this.lblInforma.Text = "ID Partida Criada";
            // 
            // lstJogadores
            // 
            this.lstJogadores.FormattingEnabled = true;
            this.lstJogadores.ItemHeight = 20;
            this.lstJogadores.Location = new System.Drawing.Point(45, 725);
            this.lstJogadores.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lstJogadores.Name = "lstJogadores";
            this.lstJogadores.Size = new System.Drawing.Size(408, 144);
            this.lstJogadores.TabIndex = 27;
            this.lstJogadores.SelectedIndexChanged += new System.EventHandler(this.lstJogadores_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(400, 198);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 20);
            this.label6.TabIndex = 28;
            // 
            // lblidJogador
            // 
            this.lblidJogador.AutoSize = true;
            this.lblidJogador.Location = new System.Drawing.Point(66, 635);
            this.lblidJogador.Name = "lblidJogador";
            this.lblidJogador.Size = new System.Drawing.Size(130, 20);
            this.lblidJogador.TabIndex = 29;
            this.lblidJogador.Text = "id jogador obtido ";
            // 
            // lblversao
            // 
            this.lblversao.AutoSize = true;
            this.lblversao.Location = new System.Drawing.Point(1268, 831);
            this.lblversao.Name = "lblversao";
            this.lblversao.Size = new System.Drawing.Size(60, 20);
            this.lblversao.TabIndex = 30;
            this.lblversao.Text = "Versão";
            // 
            // btnIniciarJogo
            // 
            this.btnIniciarJogo.Location = new System.Drawing.Point(501, 14);
            this.btnIniciarJogo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnIniciarJogo.Name = "btnIniciarJogo";
            this.btnIniciarJogo.Size = new System.Drawing.Size(84, 59);
            this.btnIniciarJogo.TabIndex = 32;
            this.btnIniciarJogo.Text = "Iniciar Jogo";
            this.btnIniciarJogo.UseVisualStyleBackColor = true;
            this.btnIniciarJogo.Click += new System.EventHandler(this.btnIniciarJogo_Click);
            // 
            // lblNomeJogador
            // 
            this.lblNomeJogador.AutoSize = true;
            this.lblNomeJogador.Location = new System.Drawing.Point(507, 94);
            this.lblNomeJogador.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNomeJogador.Name = "lblNomeJogador";
            this.lblNomeJogador.Size = new System.Drawing.Size(83, 20);
            this.lblNomeJogador.TabIndex = 33;
            this.lblNomeJogador.Text = "ID jogador";
            // 
            // txtIDjogador
            // 
            this.txtIDjogador.Location = new System.Drawing.Point(510, 119);
            this.txtIDjogador.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtIDjogador.Name = "txtIDjogador";
            this.txtIDjogador.Size = new System.Drawing.Size(187, 26);
            this.txtIDjogador.TabIndex = 34;
            // 
            // lblSenhaJogador
            // 
            this.lblSenhaJogador.AutoSize = true;
            this.lblSenhaJogador.Location = new System.Drawing.Point(507, 165);
            this.lblSenhaJogador.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSenhaJogador.Name = "lblSenhaJogador";
            this.lblSenhaJogador.Size = new System.Drawing.Size(56, 20);
            this.lblSenhaJogador.TabIndex = 35;
            this.lblSenhaJogador.Text = "Senha";
            // 
            // txtSenhaJogador
            // 
            this.txtSenhaJogador.Location = new System.Drawing.Point(510, 192);
            this.txtSenhaJogador.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtSenhaJogador.Name = "txtSenhaJogador";
            this.txtSenhaJogador.Size = new System.Drawing.Size(187, 26);
            this.txtSenhaJogador.TabIndex = 36;
            // 
            // lblCartas
            // 
            this.lblCartas.AutoSize = true;
            this.lblCartas.Location = new System.Drawing.Point(663, 782);
            this.lblCartas.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCartas.Name = "lblCartas";
            this.lblCartas.Size = new System.Drawing.Size(111, 20);
            this.lblCartas.TabIndex = 40;
            this.lblCartas.Text = "Minhas Cartas";
            // 
            // lblsenha
            // 
            this.lblsenha.AutoSize = true;
            this.lblsenha.Location = new System.Drawing.Point(348, 639);
            this.lblsenha.Name = "lblsenha";
            this.lblsenha.Size = new System.Drawing.Size(56, 20);
            this.lblsenha.TabIndex = 41;
            this.lblsenha.Text = "Senha";
            // 
            // lstPartidas
            // 
            this.lstPartidas.FormattingEnabled = true;
            this.lstPartidas.ItemHeight = 20;
            this.lstPartidas.Location = new System.Drawing.Point(45, 386);
            this.lstPartidas.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lstPartidas.Name = "lstPartidas";
            this.lstPartidas.Size = new System.Drawing.Size(408, 164);
            this.lstPartidas.TabIndex = 43;
            this.lstPartidas.Tag = "";
            this.lstPartidas.SelectedIndexChanged += new System.EventHandler(this.lstPartidas_SelectedIndexChanged);
            // 
            // lstVerificarVez
            // 
            this.lstVerificarVez.FormattingEnabled = true;
            this.lstVerificarVez.ItemHeight = 20;
            this.lstVerificarVez.Location = new System.Drawing.Point(512, 269);
            this.lstVerificarVez.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lstVerificarVez.Name = "lstVerificarVez";
            this.lstVerificarVez.Size = new System.Drawing.Size(336, 484);
            this.lstVerificarVez.TabIndex = 44;
            this.lstVerificarVez.SelectedIndexChanged += new System.EventHandler(this.lstVerificarVez_SelectedIndexChanged);
            // 
            // btnExibirCartas
            // 
            this.btnExibirCartas.Location = new System.Drawing.Point(510, 775);
            this.btnExibirCartas.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnExibirCartas.Name = "btnExibirCartas";
            this.btnExibirCartas.Size = new System.Drawing.Size(144, 35);
            this.btnExibirCartas.TabIndex = 45;
            this.btnExibirCartas.Text = "Exibir Cartas";
            this.btnExibirCartas.UseVisualStyleBackColor = true;
            this.btnExibirCartas.Click += new System.EventHandler(this.btnExibirCartas_Click);
            // 
            // lblIDjogadorVez
            // 
            this.lblIDjogadorVez.AutoSize = true;
            this.lblIDjogadorVez.Location = new System.Drawing.Point(606, 72);
            this.lblIDjogadorVez.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblIDjogadorVez.Name = "lblIDjogadorVez";
            this.lblIDjogadorVez.Size = new System.Drawing.Size(120, 20);
            this.lblIDjogadorVez.TabIndex = 46;
            this.lblIDjogadorVez.Text = "ID Jogador Vez";
            // 
            // lblNomeJogadorVez
            // 
            this.lblNomeJogadorVez.AutoSize = true;
            this.lblNomeJogadorVez.Location = new System.Drawing.Point(606, 29);
            this.lblNomeJogadorVez.Name = "lblNomeJogadorVez";
            this.lblNomeJogadorVez.Size = new System.Drawing.Size(125, 20);
            this.lblNomeJogadorVez.TabIndex = 49;
            this.lblNomeJogadorVez.Text = " Jogador da Vez";
            // 
            // btnColocarPersonagem
            // 
            this.btnColocarPersonagem.Location = new System.Drawing.Point(1008, 66);
            this.btnColocarPersonagem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnColocarPersonagem.Name = "btnColocarPersonagem";
            this.btnColocarPersonagem.Size = new System.Drawing.Size(123, 108);
            this.btnColocarPersonagem.TabIndex = 50;
            this.btnColocarPersonagem.Text = "Colocar Personagem";
            this.btnColocarPersonagem.UseVisualStyleBackColor = true;
            this.btnColocarPersonagem.Click += new System.EventHandler(this.btnColocarPersonagem_Click);
            // 
            // txtSetor
            // 
            this.txtSetor.Location = new System.Drawing.Point(843, 78);
            this.txtSetor.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtSetor.Name = "txtSetor";
            this.txtSetor.Size = new System.Drawing.Size(140, 26);
            this.txtSetor.TabIndex = 51;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(849, 46);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 20);
            this.label2.TabIndex = 52;
            this.label2.Text = "Setor";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(840, 126);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 20);
            this.label3.TabIndex = 53;
            this.label3.Text = "Personagem";
            // 
            // txtPersonagem
            // 
            this.txtPersonagem.Location = new System.Drawing.Point(843, 161);
            this.txtPersonagem.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtPersonagem.Name = "txtPersonagem";
            this.txtPersonagem.Size = new System.Drawing.Size(140, 26);
            this.txtPersonagem.TabIndex = 54;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(888, 291);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 20);
            this.label1.TabIndex = 56;
            this.label1.Text = "Voto (S/N)";
            // 
            // txtVoto
            // 
            this.txtVoto.Location = new System.Drawing.Point(882, 329);
            this.txtVoto.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtVoto.Name = "txtVoto";
            this.txtVoto.Size = new System.Drawing.Size(84, 26);
            this.txtVoto.TabIndex = 57;
            // 
            // btnExibirUltimaVotacao
            // 
            this.btnExibirUltimaVotacao.Location = new System.Drawing.Point(874, 402);
            this.btnExibirUltimaVotacao.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnExibirUltimaVotacao.Name = "btnExibirUltimaVotacao";
            this.btnExibirUltimaVotacao.Size = new System.Drawing.Size(210, 65);
            this.btnExibirUltimaVotacao.TabIndex = 59;
            this.btnExibirUltimaVotacao.Text = "Exibir Última Votação";
            this.btnExibirUltimaVotacao.UseVisualStyleBackColor = true;
            // 
            // btnVerificarVezETabuleiro
            // 
            this.btnVerificarVezETabuleiro.Location = new System.Drawing.Point(874, 512);
            this.btnVerificarVezETabuleiro.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnVerificarVezETabuleiro.Name = "btnVerificarVezETabuleiro";
            this.btnVerificarVezETabuleiro.Size = new System.Drawing.Size(210, 65);
            this.btnVerificarVezETabuleiro.TabIndex = 60;
            this.btnVerificarVezETabuleiro.Text = "Verificar Vez + Tabuleiro";
            this.btnVerificarVezETabuleiro.UseVisualStyleBackColor = true;
            // 
            // btnHistorico
            // 
            this.btnHistorico.Location = new System.Drawing.Point(886, 661);
            this.btnHistorico.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnHistorico.Name = "btnHistorico";
            this.btnHistorico.Size = new System.Drawing.Size(156, 58);
            this.btnHistorico.TabIndex = 61;
            this.btnHistorico.Text = "Histórico";
            this.btnHistorico.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(908, 745);
            this.checkBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(106, 24);
            this.checkBox1.TabIndex = 62;
            this.checkBox1.Text = "Formatado";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(1187, 46);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 20);
            this.label4.TabIndex = 63;
            this.label4.Text = "Setores";
            // 
            // lstSetores
            // 
            this.lstSetores.FormattingEnabled = true;
            this.lstSetores.ItemHeight = 20;
            this.lstSetores.Location = new System.Drawing.Point(1173, 81);
            this.lstSetores.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lstSetores.Name = "lstSetores";
            this.lstSetores.Size = new System.Drawing.Size(190, 244);
            this.lstSetores.TabIndex = 64;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(1187, 358);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(103, 20);
            this.label5.TabIndex = 65;
            this.label5.Text = "Personagens";
            // 
            // lstPersonagens
            // 
            this.lstPersonagens.FormattingEnabled = true;
            this.lstPersonagens.ItemHeight = 20;
            this.lstPersonagens.Location = new System.Drawing.Point(1173, 402);
            this.lstPersonagens.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lstPersonagens.Name = "lstPersonagens";
            this.lstPersonagens.Size = new System.Drawing.Size(190, 284);
            this.lstPersonagens.TabIndex = 66;
            // 
            // btnPersonagens
            // 
            this.btnPersonagens.Location = new System.Drawing.Point(1050, 798);
            this.btnPersonagens.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnPersonagens.Name = "btnPersonagens";
            this.btnPersonagens.Size = new System.Drawing.Size(156, 55);
            this.btnPersonagens.TabIndex = 67;
            this.btnPersonagens.Text = "Ver Personagens";
            this.btnPersonagens.UseVisualStyleBackColor = true;
            this.btnPersonagens.Click += new System.EventHandler(this.btnPersonagens_Click);
            // 
            // btnVoltar
            // 
            this.btnVoltar.Location = new System.Drawing.Point(942, 798);
            this.btnVoltar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(84, 58);
            this.btnVoltar.TabIndex = 68;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // lblVotosRestantes
            // 
            this.lblVotosRestantes.AutoSize = true;
            this.lblVotosRestantes.Location = new System.Drawing.Point(886, 365);
            this.lblVotosRestantes.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblVotosRestantes.Name = "lblVotosRestantes";
            this.lblVotosRestantes.Size = new System.Drawing.Size(0, 20);
            this.lblVotosRestantes.TabIndex = 69;
            // 
            // tmrVerificarVez
            // 
            this.tmrVerificarVez.Interval = 5000;
            // 
            // tmrGeral
            // 
            this.tmrGeral.Interval = 5000;
            // 
            // btnIniciarAutomacao
            // 
            this.btnIniciarAutomacao.Location = new System.Drawing.Point(1036, 245);
            this.btnIniciarAutomacao.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnIniciarAutomacao.Name = "btnIniciarAutomacao";
            this.btnIniciarAutomacao.Size = new System.Drawing.Size(101, 56);
            this.btnIniciarAutomacao.TabIndex = 70;
            this.btnIniciarAutomacao.Text = "automaçao";
            this.btnIniciarAutomacao.UseVisualStyleBackColor = true;
            this.btnIniciarAutomacao.Click += new System.EventHandler(this.btnIniciarAutomacao_Click);
            // 
            // btnPromover
            // 
            this.btnPromover.Location = new System.Drawing.Point(891, 211);
            this.btnPromover.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnPromover.Name = "btnPromover";
            this.btnPromover.Size = new System.Drawing.Size(84, 40);
            this.btnPromover.TabIndex = 71;
            this.btnPromover.Text = "promover";
            this.btnPromover.UseVisualStyleBackColor = true;
            this.btnPromover.Click += new System.EventHandler(this.btnPromover_Click);
            // 
            // btnConfirmarVoto
            // 
            this.btnConfirmarVoto.Location = new System.Drawing.Point(1032, 336);
            this.btnConfirmarVoto.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnConfirmarVoto.Name = "btnConfirmarVoto";
            this.btnConfirmarVoto.Size = new System.Drawing.Size(84, 49);
            this.btnConfirmarVoto.TabIndex = 72;
            this.btnConfirmarVoto.Text = "Confirmar";
            this.btnConfirmarVoto.UseVisualStyleBackColor = true;
            this.btnConfirmarVoto.Click += new System.EventHandler(this.btnConfirmarVoto_Click);
            // 
            // tmrAutomatizador
            // 
            this.tmrAutomatizador.Enabled = true;
            this.tmrAutomatizador.Interval = 5000;
          //  this.tmrAutomatizador.Tick += new System.EventHandler(this.tmrAutomatizador_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1377, 875);
            this.Controls.Add(this.btnConfirmarVoto);
            this.Controls.Add(this.btnPromover);
            this.Controls.Add(this.btnIniciarAutomacao);
            this.Controls.Add(this.lblVotosRestantes);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.btnPersonagens);
            this.Controls.Add(this.lstPersonagens);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lstSetores);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.btnHistorico);
            this.Controls.Add(this.btnVerificarVezETabuleiro);
            this.Controls.Add(this.btnExibirUltimaVotacao);
            this.Controls.Add(this.txtVoto);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPersonagem);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtSetor);
            this.Controls.Add(this.btnColocarPersonagem);
            this.Controls.Add(this.lblNomeJogadorVez);
            this.Controls.Add(this.lblIDjogadorVez);
            this.Controls.Add(this.btnExibirCartas);
            this.Controls.Add(this.lstVerificarVez);
            this.Controls.Add(this.lstPartidas);
            this.Controls.Add(this.lblsenha);
            this.Controls.Add(this.lblCartas);
            this.Controls.Add(this.txtSenhaJogador);
            this.Controls.Add(this.lblSenhaJogador);
            this.Controls.Add(this.txtIDjogador);
            this.Controls.Add(this.lblNomeJogador);
            this.Controls.Add(this.btnIniciarJogo);
            this.Controls.Add(this.lblversao);
            this.Controls.Add(this.lblidJogador);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lstJogadores);
            this.Controls.Add(this.lblInforma);
            this.Controls.Add(this.btnListarJogadores);
            this.Controls.Add(this.btnEntrar);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.txtNomeJogador);
            this.Controls.Add(this.lblNomeGrupo);
            this.Controls.Add(this.btnListarPartidas);
            this.Controls.Add(this.txtNomePartida);
            this.Controls.Add(this.lblIdPartida);
            this.Controls.Add(this.txtIdPartida);
            this.Controls.Add(this.txtNomeGrupo);
            this.Controls.Add(this.btnCriar);
            this.Controls.Add(this.txtSenhaPartida);
            this.Controls.Add(this.lblSenhaPartida);
            this.Controls.Add(this.lblNomePartida);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Cavaleiros de Canterbury";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        #endregion
        private System.Windows.Forms.Label lblNomePartida;
        private System.Windows.Forms.Label lblSenhaPartida;
        private System.Windows.Forms.TextBox txtSenhaPartida;
        private System.Windows.Forms.Button btnCriar;
        private System.Windows.Forms.TextBox txtNomeGrupo;
        private System.Windows.Forms.Label lblIdPartida;
        private System.Windows.Forms.TextBox txtIdPartida;
        private System.Windows.Forms.TextBox txtNomePartida;
        private System.Windows.Forms.Button btnListarPartidas;
        private System.Windows.Forms.Label lblNomeGrupo;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.TextBox txtNomeJogador;
        private System.Windows.Forms.Button btnEntrar;
        private System.Windows.Forms.Button btnListarJogadores;
        private System.Windows.Forms.Label lblInforma;
        private System.Windows.Forms.ListBox lstJogadores;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblidJogador;
        private System.Windows.Forms.Label lblversao;
        private System.Windows.Forms.Button btnIniciarJogo;
        private System.Windows.Forms.Label lblNomeJogador;
        private System.Windows.Forms.TextBox txtIDjogador;
        private System.Windows.Forms.Label lblSenhaJogador;
        private System.Windows.Forms.TextBox txtSenhaJogador;
        private System.Windows.Forms.Label lblCartas;
        private System.Windows.Forms.Label lblsenha;
        private System.Windows.Forms.ListBox lstPartidas;
        private System.Windows.Forms.ListBox lstVerificarVez;
        private System.Windows.Forms.Button btnExibirCartas;
        private System.Windows.Forms.Label lblIDjogadorVez;
        private System.Windows.Forms.Label lblNomeJogadorVez;
        private System.Windows.Forms.Button btnColocarPersonagem;
        private System.Windows.Forms.TextBox txtSetor;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPersonagem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtVoto;
        private System.Windows.Forms.Button btnExibirUltimaVotacao;
        private System.Windows.Forms.Button btnVerificarVezETabuleiro;
        private System.Windows.Forms.Button btnHistorico;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox lstSetores;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListBox lstPersonagens;
        private System.Windows.Forms.Button btnPersonagens;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.Label lblVotosRestantes;
        private System.Windows.Forms.Timer tmrVerificarVez;
        private System.Windows.Forms.Timer tmrGeral;
        private System.Windows.Forms.Button btnIniciarAutomacao;
        private System.Windows.Forms.Button btnPromover;
        private System.Windows.Forms.Button btnConfirmarVoto;
        private System.Windows.Forms.Timer tmrAutomatizador;
    }
}

