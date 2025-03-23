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
            this.btnVerificarVez = new System.Windows.Forms.Button();
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
            this.btnPromover = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtVoto = new System.Windows.Forms.TextBox();
            this.btnVotar = new System.Windows.Forms.Button();
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
            this.SuspendLayout();
            // 
            // lblNomePartida
            // 
            this.lblNomePartida.AutoSize = true;
            this.lblNomePartida.Location = new System.Drawing.Point(37, 11);
            this.lblNomePartida.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNomePartida.Name = "lblNomePartida";
            this.lblNomePartida.Size = new System.Drawing.Size(109, 16);
            this.lblNomePartida.TabIndex = 3;
            this.lblNomePartida.Text = "Nome da Partida";
            // 
            // lblSenhaPartida
            // 
            this.lblSenhaPartida.AutoSize = true;
            this.lblSenhaPartida.Location = new System.Drawing.Point(37, 65);
            this.lblSenhaPartida.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSenhaPartida.Name = "lblSenhaPartida";
            this.lblSenhaPartida.Size = new System.Drawing.Size(111, 16);
            this.lblSenhaPartida.TabIndex = 5;
            this.lblSenhaPartida.Text = "Senha da Partida";
            // 
            // txtSenhaPartida
            // 
            this.txtSenhaPartida.Location = new System.Drawing.Point(41, 85);
            this.txtSenhaPartida.Margin = new System.Windows.Forms.Padding(4);
            this.txtSenhaPartida.Name = "txtSenhaPartida";
            this.txtSenhaPartida.Size = new System.Drawing.Size(185, 22);
            this.txtSenhaPartida.TabIndex = 6;
            // 
            // btnCriar
            // 
            this.btnCriar.Location = new System.Drawing.Point(259, 23);
            this.btnCriar.Margin = new System.Windows.Forms.Padding(4);
            this.btnCriar.Name = "btnCriar";
            this.btnCriar.Size = new System.Drawing.Size(132, 86);
            this.btnCriar.TabIndex = 7;
            this.btnCriar.Text = "Criar Partida";
            this.btnCriar.UseVisualStyleBackColor = true;
            this.btnCriar.Click += new System.EventHandler(this.btnCriar_Click);
            // 
            // txtNomeGrupo
            // 
            this.txtNomeGrupo.Location = new System.Drawing.Point(41, 151);
            this.txtNomeGrupo.Margin = new System.Windows.Forms.Padding(4);
            this.txtNomeGrupo.Name = "txtNomeGrupo";
            this.txtNomeGrupo.Size = new System.Drawing.Size(185, 22);
            this.txtNomeGrupo.TabIndex = 12;
            // 
            // lblIdPartida
            // 
            this.lblIdPartida.AutoSize = true;
            this.lblIdPartida.Location = new System.Drawing.Point(37, 199);
            this.lblIdPartida.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblIdPartida.Name = "lblIdPartida";
            this.lblIdPartida.Size = new System.Drawing.Size(83, 16);
            this.lblIdPartida.TabIndex = 15;
            this.lblIdPartida.Text = "Id da Partida";
            // 
            // txtIdPartida
            // 
            this.txtIdPartida.Location = new System.Drawing.Point(41, 219);
            this.txtIdPartida.Margin = new System.Windows.Forms.Padding(4);
            this.txtIdPartida.Name = "txtIdPartida";
            this.txtIdPartida.Size = new System.Drawing.Size(185, 22);
            this.txtIdPartida.TabIndex = 14;
            // 
            // txtNomePartida
            // 
            this.txtNomePartida.Location = new System.Drawing.Point(41, 31);
            this.txtNomePartida.Margin = new System.Windows.Forms.Padding(4);
            this.txtNomePartida.Name = "txtNomePartida";
            this.txtNomePartida.Size = new System.Drawing.Size(185, 22);
            this.txtNomePartida.TabIndex = 16;
            // 
            // btnListarPartidas
            // 
            this.btnListarPartidas.Location = new System.Drawing.Point(41, 263);
            this.btnListarPartidas.Margin = new System.Windows.Forms.Padding(4);
            this.btnListarPartidas.Name = "btnListarPartidas";
            this.btnListarPartidas.Size = new System.Drawing.Size(129, 27);
            this.btnListarPartidas.TabIndex = 17;
            this.btnListarPartidas.Text = "Listar Partidas";
            this.btnListarPartidas.UseVisualStyleBackColor = true;
            this.btnListarPartidas.Click += new System.EventHandler(this.btnListarPartidas_Click);
            // 
            // lblNomeGrupo
            // 
            this.lblNomeGrupo.AutoSize = true;
            this.lblNomeGrupo.Location = new System.Drawing.Point(37, 132);
            this.lblNomeGrupo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNomeGrupo.Name = "lblNomeGrupo";
            this.lblNomeGrupo.Size = new System.Drawing.Size(103, 16);
            this.lblNomeGrupo.TabIndex = 18;
            this.lblNomeGrupo.Text = "Nome do Grupo";
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(37, 463);
            this.lblNome.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(117, 16);
            this.lblNome.TabIndex = 20;
            this.lblNome.Text = "Nome do Jogador";
            // 
            // txtNomeJogador
            // 
            this.txtNomeJogador.Location = new System.Drawing.Point(41, 482);
            this.txtNomeJogador.Margin = new System.Windows.Forms.Padding(4);
            this.txtNomeJogador.Name = "txtNomeJogador";
            this.txtNomeJogador.Size = new System.Drawing.Size(185, 22);
            this.txtNomeJogador.TabIndex = 19;
            // 
            // btnEntrar
            // 
            this.btnEntrar.Location = new System.Drawing.Point(261, 469);
            this.btnEntrar.Margin = new System.Windows.Forms.Padding(4);
            this.btnEntrar.Name = "btnEntrar";
            this.btnEntrar.Size = new System.Drawing.Size(143, 38);
            this.btnEntrar.TabIndex = 21;
            this.btnEntrar.Text = "Entrar na Partida";
            this.btnEntrar.UseVisualStyleBackColor = true;
            this.btnEntrar.Click += new System.EventHandler(this.btnEntrar_Click);
            // 
            // btnListarJogadores
            // 
            this.btnListarJogadores.Location = new System.Drawing.Point(45, 538);
            this.btnListarJogadores.Margin = new System.Windows.Forms.Padding(4);
            this.btnListarJogadores.Name = "btnListarJogadores";
            this.btnListarJogadores.Size = new System.Drawing.Size(125, 26);
            this.btnListarJogadores.TabIndex = 22;
            this.btnListarJogadores.Text = "Listar Jogadores";
            this.btnListarJogadores.UseVisualStyleBackColor = true;
            this.btnListarJogadores.Click += new System.EventHandler(this.btnListarJogadores_Click);
            // 
            // lblInforma
            // 
            this.lblInforma.AutoSize = true;
            this.lblInforma.Location = new System.Drawing.Point(257, 132);
            this.lblInforma.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblInforma.Name = "lblInforma";
            this.lblInforma.Size = new System.Drawing.Size(109, 16);
            this.lblInforma.TabIndex = 26;
            this.lblInforma.Text = "ID Partida Criada";
            // 
            // lstJogadores
            // 
            this.lstJogadores.FormattingEnabled = true;
            this.lstJogadores.ItemHeight = 16;
            this.lstJogadores.Location = new System.Drawing.Point(40, 580);
            this.lstJogadores.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lstJogadores.Name = "lstJogadores";
            this.lstJogadores.Size = new System.Drawing.Size(363, 116);
            this.lstJogadores.TabIndex = 27;
            this.lstJogadores.SelectedIndexChanged += new System.EventHandler(this.lstJogadores_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(356, 158);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 16);
            this.label6.TabIndex = 28;
            // 
            // lblidJogador
            // 
            this.lblidJogador.AutoSize = true;
            this.lblidJogador.Location = new System.Drawing.Point(59, 508);
            this.lblidJogador.Name = "lblidJogador";
            this.lblidJogador.Size = new System.Drawing.Size(112, 16);
            this.lblidJogador.TabIndex = 29;
            this.lblidJogador.Text = "id jogador obtido ";
            // 
            // lblversao
            // 
            this.lblversao.AutoSize = true;
            this.lblversao.Location = new System.Drawing.Point(1127, 665);
            this.lblversao.Name = "lblversao";
            this.lblversao.Size = new System.Drawing.Size(51, 16);
            this.lblversao.TabIndex = 30;
            this.lblversao.Text = "Versão";
            // 
            // btnIniciarJogo
            // 
            this.btnIniciarJogo.Location = new System.Drawing.Point(445, 11);
            this.btnIniciarJogo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnIniciarJogo.Name = "btnIniciarJogo";
            this.btnIniciarJogo.Size = new System.Drawing.Size(75, 47);
            this.btnIniciarJogo.TabIndex = 32;
            this.btnIniciarJogo.Text = "Iniciar Jogo";
            this.btnIniciarJogo.UseVisualStyleBackColor = true;
            this.btnIniciarJogo.Click += new System.EventHandler(this.btnIniciarJogo_Click);
            // 
            // lblNomeJogador
            // 
            this.lblNomeJogador.AutoSize = true;
            this.lblNomeJogador.Location = new System.Drawing.Point(451, 75);
            this.lblNomeJogador.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNomeJogador.Name = "lblNomeJogador";
            this.lblNomeJogador.Size = new System.Drawing.Size(70, 16);
            this.lblNomeJogador.TabIndex = 33;
            this.lblNomeJogador.Text = "ID jogador";
            // 
            // txtIDjogador
            // 
            this.txtIDjogador.Location = new System.Drawing.Point(453, 95);
            this.txtIDjogador.Margin = new System.Windows.Forms.Padding(4);
            this.txtIDjogador.Name = "txtIDjogador";
            this.txtIDjogador.Size = new System.Drawing.Size(167, 22);
            this.txtIDjogador.TabIndex = 34;
            // 
            // lblSenhaJogador
            // 
            this.lblSenhaJogador.AutoSize = true;
            this.lblSenhaJogador.Location = new System.Drawing.Point(451, 132);
            this.lblSenhaJogador.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSenhaJogador.Name = "lblSenhaJogador";
            this.lblSenhaJogador.Size = new System.Drawing.Size(46, 16);
            this.lblSenhaJogador.TabIndex = 35;
            this.lblSenhaJogador.Text = "Senha";
            // 
            // txtSenhaJogador
            // 
            this.txtSenhaJogador.Location = new System.Drawing.Point(453, 154);
            this.txtSenhaJogador.Margin = new System.Windows.Forms.Padding(4);
            this.txtSenhaJogador.Name = "txtSenhaJogador";
            this.txtSenhaJogador.Size = new System.Drawing.Size(167, 22);
            this.txtSenhaJogador.TabIndex = 36;
            // 
            // btnVerificarVez
            // 
            this.btnVerificarVez.Location = new System.Drawing.Point(453, 219);
            this.btnVerificarVez.Margin = new System.Windows.Forms.Padding(4);
            this.btnVerificarVez.Name = "btnVerificarVez";
            this.btnVerificarVez.Size = new System.Drawing.Size(168, 30);
            this.btnVerificarVez.TabIndex = 37;
            this.btnVerificarVez.Text = "Verificar Vez";
            this.btnVerificarVez.UseVisualStyleBackColor = true;
            this.btnVerificarVez.Click += new System.EventHandler(this.btnVerificarVez_Click);
            // 
            // lblCartas
            // 
            this.lblCartas.AutoSize = true;
            this.lblCartas.Location = new System.Drawing.Point(589, 626);
            this.lblCartas.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCartas.Name = "lblCartas";
            this.lblCartas.Size = new System.Drawing.Size(92, 16);
            this.lblCartas.TabIndex = 40;
            this.lblCartas.Text = "Minhas Cartas";
            // 
            // lblsenha
            // 
            this.lblsenha.AutoSize = true;
            this.lblsenha.Location = new System.Drawing.Point(309, 511);
            this.lblsenha.Name = "lblsenha";
            this.lblsenha.Size = new System.Drawing.Size(46, 16);
            this.lblsenha.TabIndex = 41;
            this.lblsenha.Text = "Senha";
            // 
            // lstPartidas
            // 
            this.lstPartidas.FormattingEnabled = true;
            this.lstPartidas.ItemHeight = 16;
            this.lstPartidas.Location = new System.Drawing.Point(40, 309);
            this.lstPartidas.Margin = new System.Windows.Forms.Padding(4);
            this.lstPartidas.Name = "lstPartidas";
            this.lstPartidas.Size = new System.Drawing.Size(363, 132);
            this.lstPartidas.TabIndex = 43;
            this.lstPartidas.Tag = "";
            this.lstPartidas.SelectedIndexChanged += new System.EventHandler(this.lstPartidas_SelectedIndexChanged);
            // 
            // lstVerificarVez
            // 
            this.lstVerificarVez.FormattingEnabled = true;
            this.lstVerificarVez.ItemHeight = 16;
            this.lstVerificarVez.Location = new System.Drawing.Point(455, 263);
            this.lstVerificarVez.Margin = new System.Windows.Forms.Padding(4);
            this.lstVerificarVez.Name = "lstVerificarVez";
            this.lstVerificarVez.Size = new System.Drawing.Size(299, 340);
            this.lstVerificarVez.TabIndex = 44;
            this.lstVerificarVez.SelectedIndexChanged += new System.EventHandler(this.lstVerificarVez_SelectedIndexChanged);
            // 
            // btnExibirCartas
            // 
            this.btnExibirCartas.Location = new System.Drawing.Point(453, 620);
            this.btnExibirCartas.Margin = new System.Windows.Forms.Padding(4);
            this.btnExibirCartas.Name = "btnExibirCartas";
            this.btnExibirCartas.Size = new System.Drawing.Size(128, 28);
            this.btnExibirCartas.TabIndex = 45;
            this.btnExibirCartas.Text = "Exibir Cartas";
            this.btnExibirCartas.UseVisualStyleBackColor = true;
            this.btnExibirCartas.Click += new System.EventHandler(this.btnExibirCartas_Click);
            // 
            // lblIDjogadorVez
            // 
            this.lblIDjogadorVez.AutoSize = true;
            this.lblIDjogadorVez.Location = new System.Drawing.Point(539, 58);
            this.lblIDjogadorVez.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblIDjogadorVez.Name = "lblIDjogadorVez";
            this.lblIDjogadorVez.Size = new System.Drawing.Size(100, 16);
            this.lblIDjogadorVez.TabIndex = 46;
            this.lblIDjogadorVez.Text = "ID Jogador Vez";
            // 
            // lblNomeJogadorVez
            // 
            this.lblNomeJogadorVez.AutoSize = true;
            this.lblNomeJogadorVez.Location = new System.Drawing.Point(539, 23);
            this.lblNomeJogadorVez.Name = "lblNomeJogadorVez";
            this.lblNomeJogadorVez.Size = new System.Drawing.Size(106, 16);
            this.lblNomeJogadorVez.TabIndex = 49;
            this.lblNomeJogadorVez.Text = " Jogador da Vez";
            // 
            // btnColocarPersonagem
            // 
            this.btnColocarPersonagem.Location = new System.Drawing.Point(896, 53);
            this.btnColocarPersonagem.Name = "btnColocarPersonagem";
            this.btnColocarPersonagem.Size = new System.Drawing.Size(109, 86);
            this.btnColocarPersonagem.TabIndex = 50;
            this.btnColocarPersonagem.Text = "Colocar Personagem";
            this.btnColocarPersonagem.UseVisualStyleBackColor = true;
            // 
            // txtSetor
            // 
            this.txtSetor.Location = new System.Drawing.Point(749, 62);
            this.txtSetor.Margin = new System.Windows.Forms.Padding(4);
            this.txtSetor.Name = "txtSetor";
            this.txtSetor.Size = new System.Drawing.Size(125, 22);
            this.txtSetor.TabIndex = 51;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(755, 37);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 16);
            this.label2.TabIndex = 52;
            this.label2.Text = "Setor";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(746, 101);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 16);
            this.label3.TabIndex = 53;
            this.label3.Text = "Personagem";
            // 
            // txtPersonagem
            // 
            this.txtPersonagem.Location = new System.Drawing.Point(749, 129);
            this.txtPersonagem.Margin = new System.Windows.Forms.Padding(4);
            this.txtPersonagem.Name = "txtPersonagem";
            this.txtPersonagem.Size = new System.Drawing.Size(125, 22);
            this.txtPersonagem.TabIndex = 54;
            // 
            // btnPromover
            // 
            this.btnPromover.Location = new System.Drawing.Point(758, 176);
            this.btnPromover.Margin = new System.Windows.Forms.Padding(4);
            this.btnPromover.Name = "btnPromover";
            this.btnPromover.Size = new System.Drawing.Size(104, 30);
            this.btnPromover.TabIndex = 55;
            this.btnPromover.Text = "Promover";
            this.btnPromover.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(790, 233);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 16);
            this.label1.TabIndex = 56;
            this.label1.Text = "Voto (S/N)";
            // 
            // txtVoto
            // 
            this.txtVoto.Location = new System.Drawing.Point(784, 263);
            this.txtVoto.Margin = new System.Windows.Forms.Padding(4);
            this.txtVoto.Name = "txtVoto";
            this.txtVoto.Size = new System.Drawing.Size(75, 22);
            this.txtVoto.TabIndex = 57;
            // 
            // btnVotar
            // 
            this.btnVotar.Location = new System.Drawing.Point(896, 257);
            this.btnVotar.Margin = new System.Windows.Forms.Padding(4);
            this.btnVotar.Name = "btnVotar";
            this.btnVotar.Size = new System.Drawing.Size(68, 28);
            this.btnVotar.TabIndex = 58;
            this.btnVotar.Text = "Votar";
            this.btnVotar.UseVisualStyleBackColor = true;
            // 
            // btnExibirUltimaVotacao
            // 
            this.btnExibirUltimaVotacao.Location = new System.Drawing.Point(777, 323);
            this.btnExibirUltimaVotacao.Margin = new System.Windows.Forms.Padding(4);
            this.btnExibirUltimaVotacao.Name = "btnExibirUltimaVotacao";
            this.btnExibirUltimaVotacao.Size = new System.Drawing.Size(187, 52);
            this.btnExibirUltimaVotacao.TabIndex = 59;
            this.btnExibirUltimaVotacao.Text = "Exibir Última Votação";
            this.btnExibirUltimaVotacao.UseVisualStyleBackColor = true;
            // 
            // btnVerificarVezETabuleiro
            // 
            this.btnVerificarVezETabuleiro.Location = new System.Drawing.Point(777, 410);
            this.btnVerificarVezETabuleiro.Margin = new System.Windows.Forms.Padding(4);
            this.btnVerificarVezETabuleiro.Name = "btnVerificarVezETabuleiro";
            this.btnVerificarVezETabuleiro.Size = new System.Drawing.Size(187, 52);
            this.btnVerificarVezETabuleiro.TabIndex = 60;
            this.btnVerificarVezETabuleiro.Text = "Verificar Vez + Tabuleiro";
            this.btnVerificarVezETabuleiro.UseVisualStyleBackColor = true;
            // 
            // btnHistorico
            // 
            this.btnHistorico.Location = new System.Drawing.Point(788, 529);
            this.btnHistorico.Margin = new System.Windows.Forms.Padding(4);
            this.btnHistorico.Name = "btnHistorico";
            this.btnHistorico.Size = new System.Drawing.Size(139, 45);
            this.btnHistorico.TabIndex = 61;
            this.btnHistorico.Text = "Histórico";
            this.btnHistorico.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(807, 596);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(95, 20);
            this.checkBox1.TabIndex = 62;
            this.checkBox1.Text = "Formatado";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(1055, 37);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 16);
            this.label4.TabIndex = 63;
            this.label4.Text = "Setores";
            // 
            // lstSetores
            // 
            this.lstSetores.FormattingEnabled = true;
            this.lstSetores.ItemHeight = 16;
            this.lstSetores.Location = new System.Drawing.Point(1042, 65);
            this.lstSetores.Margin = new System.Windows.Forms.Padding(4);
            this.lstSetores.Name = "lstSetores";
            this.lstSetores.Size = new System.Drawing.Size(169, 196);
            this.lstSetores.TabIndex = 64;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(1055, 285);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 16);
            this.label5.TabIndex = 65;
            this.label5.Text = "Personagens";
            // 
            // lstPersonagens
            // 
            this.lstPersonagens.FormattingEnabled = true;
            this.lstPersonagens.ItemHeight = 16;
            this.lstPersonagens.Location = new System.Drawing.Point(1042, 323);
            this.lstPersonagens.Margin = new System.Windows.Forms.Padding(4);
            this.lstPersonagens.Name = "lstPersonagens";
            this.lstPersonagens.Size = new System.Drawing.Size(169, 228);
            this.lstPersonagens.TabIndex = 66;
            // 
            // btnPersonagens
            // 
            this.btnPersonagens.Location = new System.Drawing.Point(933, 637);
            this.btnPersonagens.Name = "btnPersonagens";
            this.btnPersonagens.Size = new System.Drawing.Size(138, 44);
            this.btnPersonagens.TabIndex = 67;
            this.btnPersonagens.Text = "Ver Personagens";
            this.btnPersonagens.UseVisualStyleBackColor = true;
            this.btnPersonagens.Click += new System.EventHandler(this.btnPersonagens_Click);
            // 
            // btnVoltar
            // 
            this.btnVoltar.Location = new System.Drawing.Point(838, 637);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(75, 46);
            this.btnVoltar.TabIndex = 68;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1224, 700);
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
            this.Controls.Add(this.btnVotar);
            this.Controls.Add(this.txtVoto);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnPromover);
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
            this.Controls.Add(this.btnVerificarVez);
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
            this.Margin = new System.Windows.Forms.Padding(4);
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
        private System.Windows.Forms.Button btnVerificarVez;
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
        private System.Windows.Forms.Button btnPromover;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtVoto;
        private System.Windows.Forms.Button btnVotar;
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
    }
}

