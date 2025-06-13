using System;

namespace Sistema_Autônomo_PI_III
{
    partial class ExecutarPartida
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ExecutarPartida));
            this.label6 = new System.Windows.Forms.Label();
            this.lblversao = new System.Windows.Forms.Label();
            this.lblNomeJogador = new System.Windows.Forms.Label();
            this.txtIDjogador = new System.Windows.Forms.TextBox();
            this.lblSenhaJogador = new System.Windows.Forms.Label();
            this.txtSenhaJogador = new System.Windows.Forms.TextBox();
            this.lblCartas = new System.Windows.Forms.Label();
            this.btnExibirCartas = new System.Windows.Forms.Button();
            this.lblIDjogadorVez = new System.Windows.Forms.Label();
            this.lblNomeJogadorVez = new System.Windows.Forms.Label();
            this.btnColocarPersonagem = new System.Windows.Forms.Button();
            this.txtSetor = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPersonagem = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lstSetores = new System.Windows.Forms.ListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.lstPersonagens = new System.Windows.Forms.ListBox();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.lblVotosRestantes = new System.Windows.Forms.Label();
            this.tmrVerificarVez = new System.Windows.Forms.Timer(this.components);
            this.tmrGeral = new System.Windows.Forms.Timer(this.components);
            this.btnPromover = new System.Windows.Forms.Button();
            this.tmrAutomatizador = new System.Windows.Forms.Timer(this.components);
            this.btnIniciarJogo = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnVerificarVez = new System.Windows.Forms.Button();
            this.lblErro = new System.Windows.Forms.Label();
            this.lstLog = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(356, 158);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 16);
            this.label6.TabIndex = 28;
            // 
            // lblversao
            // 
            this.lblversao.AutoSize = true;
            this.lblversao.BackColor = System.Drawing.Color.AntiqueWhite;
            this.lblversao.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblversao.Location = new System.Drawing.Point(1283, 657);
            this.lblversao.Name = "lblversao";
            this.lblversao.Size = new System.Drawing.Size(62, 23);
            this.lblversao.TabIndex = 30;
            this.lblversao.Text = "Versão";
            // 
            // lblNomeJogador
            // 
            this.lblNomeJogador.AutoSize = true;
            this.lblNomeJogador.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomeJogador.ForeColor = System.Drawing.Color.Goldenrod;
            this.lblNomeJogador.Location = new System.Drawing.Point(7, 20);
            this.lblNomeJogador.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNomeJogador.Name = "lblNomeJogador";
            this.lblNomeJogador.Size = new System.Drawing.Size(96, 23);
            this.lblNomeJogador.TabIndex = 33;
            this.lblNomeJogador.Text = "ID jogador";
            // 
            // txtIDjogador
            // 
            this.txtIDjogador.BackColor = System.Drawing.Color.AntiqueWhite;
            this.txtIDjogador.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtIDjogador.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIDjogador.ForeColor = System.Drawing.Color.Black;
            this.txtIDjogador.Location = new System.Drawing.Point(4, 49);
            this.txtIDjogador.Margin = new System.Windows.Forms.Padding(4);
            this.txtIDjogador.Name = "txtIDjogador";
            this.txtIDjogador.Size = new System.Drawing.Size(322, 30);
            this.txtIDjogador.TabIndex = 34;
            this.txtIDjogador.TextChanged += new System.EventHandler(this.txtIDjogador_TextChanged);
            // 
            // lblSenhaJogador
            // 
            this.lblSenhaJogador.AutoSize = true;
            this.lblSenhaJogador.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSenhaJogador.ForeColor = System.Drawing.Color.Goldenrod;
            this.lblSenhaJogador.Location = new System.Drawing.Point(7, 89);
            this.lblSenhaJogador.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSenhaJogador.Name = "lblSenhaJogador";
            this.lblSenhaJogador.Size = new System.Drawing.Size(58, 23);
            this.lblSenhaJogador.TabIndex = 35;
            this.lblSenhaJogador.Text = "Senha";
            // 
            // txtSenhaJogador
            // 
            this.txtSenhaJogador.BackColor = System.Drawing.Color.AntiqueWhite;
            this.txtSenhaJogador.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSenhaJogador.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSenhaJogador.Location = new System.Drawing.Point(4, 122);
            this.txtSenhaJogador.Margin = new System.Windows.Forms.Padding(4);
            this.txtSenhaJogador.Name = "txtSenhaJogador";
            this.txtSenhaJogador.Size = new System.Drawing.Size(322, 30);
            this.txtSenhaJogador.TabIndex = 36;
            // 
            // lblCartas
            // 
            this.lblCartas.AutoSize = true;
            this.lblCartas.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCartas.ForeColor = System.Drawing.Color.Goldenrod;
            this.lblCartas.Location = new System.Drawing.Point(992, 29);
            this.lblCartas.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCartas.Name = "lblCartas";
            this.lblCartas.Size = new System.Drawing.Size(122, 23);
            this.lblCartas.TabIndex = 40;
            this.lblCartas.Text = "Minhas Cartas";
            // 
            // btnExibirCartas
            // 
            this.btnExibirCartas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(207)))), ((int)(((byte)(128)))));
            this.btnExibirCartas.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExibirCartas.ForeColor = System.Drawing.Color.Black;
            this.btnExibirCartas.Location = new System.Drawing.Point(854, 15);
            this.btnExibirCartas.Margin = new System.Windows.Forms.Padding(4);
            this.btnExibirCartas.Name = "btnExibirCartas";
            this.btnExibirCartas.Size = new System.Drawing.Size(112, 75);
            this.btnExibirCartas.TabIndex = 45;
            this.btnExibirCartas.Text = "🃏Exibir Cartas";
            this.btnExibirCartas.UseVisualStyleBackColor = false;
            this.btnExibirCartas.Click += new System.EventHandler(this.btnExibirCartas_Click);
            // 
            // lblIDjogadorVez
            // 
            this.lblIDjogadorVez.AutoSize = true;
            this.lblIDjogadorVez.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIDjogadorVez.ForeColor = System.Drawing.Color.Goldenrod;
            this.lblIDjogadorVez.Location = new System.Drawing.Point(9, 351);
            this.lblIDjogadorVez.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblIDjogadorVez.Name = "lblIDjogadorVez";
            this.lblIDjogadorVez.Size = new System.Drawing.Size(131, 23);
            this.lblIDjogadorVez.TabIndex = 46;
            this.lblIDjogadorVez.Text = "ID Jogador Vez";
            // 
            // lblNomeJogadorVez
            // 
            this.lblNomeJogadorVez.AutoSize = true;
            this.lblNomeJogadorVez.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomeJogadorVez.ForeColor = System.Drawing.Color.Goldenrod;
            this.lblNomeJogadorVez.Location = new System.Drawing.Point(2, 303);
            this.lblNomeJogadorVez.Name = "lblNomeJogadorVez";
            this.lblNomeJogadorVez.Size = new System.Drawing.Size(138, 23);
            this.lblNomeJogadorVez.TabIndex = 49;
            this.lblNomeJogadorVez.Text = " Jogador da Vez";
            // 
            // btnColocarPersonagem
            // 
            this.btnColocarPersonagem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(207)))), ((int)(((byte)(128)))));
            this.btnColocarPersonagem.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnColocarPersonagem.ForeColor = System.Drawing.Color.Black;
            this.btnColocarPersonagem.Location = new System.Drawing.Point(143, 496);
            this.btnColocarPersonagem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnColocarPersonagem.Name = "btnColocarPersonagem";
            this.btnColocarPersonagem.Size = new System.Drawing.Size(183, 64);
            this.btnColocarPersonagem.TabIndex = 50;
            this.btnColocarPersonagem.Text = "Colocar Personagem";
            this.btnColocarPersonagem.UseVisualStyleBackColor = false;
            this.btnColocarPersonagem.Click += new System.EventHandler(this.btnColocarPersonagem_Click);
            // 
            // txtSetor
            // 
            this.txtSetor.BackColor = System.Drawing.Color.AntiqueWhite;
            this.txtSetor.Location = new System.Drawing.Point(181, 325);
            this.txtSetor.Margin = new System.Windows.Forms.Padding(4);
            this.txtSetor.Name = "txtSetor";
            this.txtSetor.Size = new System.Drawing.Size(145, 30);
            this.txtSetor.TabIndex = 51;
            this.txtSetor.TextChanged += new System.EventHandler(this.txtSetor_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Goldenrod;
            this.label2.Location = new System.Drawing.Point(229, 278);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 23);
            this.label2.TabIndex = 52;
            this.label2.Text = "Setor";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Goldenrod;
            this.label3.Location = new System.Drawing.Point(197, 382);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 23);
            this.label3.TabIndex = 53;
            this.label3.Text = "Personagem";
            // 
            // txtPersonagem
            // 
            this.txtPersonagem.BackColor = System.Drawing.Color.AntiqueWhite;
            this.txtPersonagem.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPersonagem.Location = new System.Drawing.Point(181, 429);
            this.txtPersonagem.Margin = new System.Windows.Forms.Padding(4);
            this.txtPersonagem.Name = "txtPersonagem";
            this.txtPersonagem.Size = new System.Drawing.Size(145, 30);
            this.txtPersonagem.TabIndex = 54;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Goldenrod;
            this.label4.Location = new System.Drawing.Point(1225, 3);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 23);
            this.label4.TabIndex = 63;
            this.label4.Text = "Setores";
            // 
            // lstSetores
            // 
            this.lstSetores.BackColor = System.Drawing.Color.AntiqueWhite;
            this.lstSetores.FormattingEnabled = true;
            this.lstSetores.ItemHeight = 23;
            this.lstSetores.Location = new System.Drawing.Point(1168, 29);
            this.lstSetores.Margin = new System.Windows.Forms.Padding(4);
            this.lstSetores.Name = "lstSetores";
            this.lstSetores.Size = new System.Drawing.Size(177, 234);
            this.lstSetores.TabIndex = 64;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Goldenrod;
            this.label5.Location = new System.Drawing.Point(1206, 278);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(108, 23);
            this.label5.TabIndex = 65;
            this.label5.Text = "Personagens";
            // 
            // lstPersonagens
            // 
            this.lstPersonagens.BackColor = System.Drawing.Color.AntiqueWhite;
            this.lstPersonagens.FormattingEnabled = true;
            this.lstPersonagens.ItemHeight = 23;
            this.lstPersonagens.Location = new System.Drawing.Point(1168, 325);
            this.lstPersonagens.Margin = new System.Windows.Forms.Padding(4);
            this.lstPersonagens.Name = "lstPersonagens";
            this.lstPersonagens.Size = new System.Drawing.Size(177, 303);
            this.lstPersonagens.TabIndex = 66;
            // 
            // btnVoltar
            // 
            this.btnVoltar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(207)))), ((int)(((byte)(128)))));
            this.btnVoltar.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVoltar.ForeColor = System.Drawing.Color.Black;
            this.btnVoltar.Location = new System.Drawing.Point(933, 596);
            this.btnVoltar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(126, 45);
            this.btnVoltar.TabIndex = 68;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseVisualStyleBackColor = false;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // lblVotosRestantes
            // 
            this.lblVotosRestantes.AutoSize = true;
            this.lblVotosRestantes.Location = new System.Drawing.Point(788, 292);
            this.lblVotosRestantes.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblVotosRestantes.Name = "lblVotosRestantes";
            this.lblVotosRestantes.Size = new System.Drawing.Size(0, 16);
            this.lblVotosRestantes.TabIndex = 69;
            // 
            // tmrVerificarVez
            // 
            this.tmrVerificarVez.Enabled = true;
            this.tmrVerificarVez.Interval = 5000;
            this.tmrVerificarVez.Tick += new System.EventHandler(this.tmrVerificaVez_Tick);
            // 
            // tmrGeral
            // 
            this.tmrGeral.Interval = 5000;
            // 
            // btnPromover
            // 
            this.btnPromover.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(207)))), ((int)(((byte)(128)))));
            this.btnPromover.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPromover.ForeColor = System.Drawing.Color.Black;
            this.btnPromover.Location = new System.Drawing.Point(143, 581);
            this.btnPromover.Name = "btnPromover";
            this.btnPromover.Size = new System.Drawing.Size(183, 74);
            this.btnPromover.TabIndex = 71;
            this.btnPromover.Text = "Promover";
            this.btnPromover.UseVisualStyleBackColor = false;
            this.btnPromover.Click += new System.EventHandler(this.btnPromover_Click);
            // 
            // tmrAutomatizador
            // 
            this.tmrAutomatizador.Interval = 5000;
            // 
            // btnIniciarJogo
            // 
            this.btnIniciarJogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(234)))), ((int)(((byte)(174)))));
            this.btnIniciarJogo.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIniciarJogo.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btnIniciarJogo.Location = new System.Drawing.Point(67, 168);
            this.btnIniciarJogo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnIniciarJogo.Name = "btnIniciarJogo";
            this.btnIniciarJogo.Size = new System.Drawing.Size(191, 47);
            this.btnIniciarJogo.TabIndex = 73;
            this.btnIniciarJogo.Text = "🎮Iniciar Jogo";
            this.btnIniciarJogo.UseVisualStyleBackColor = false;
            this.btnIniciarJogo.Click += new System.EventHandler(this.btnIniciarJogo_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Location = new System.Drawing.Point(26, -4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1374, 734);
            this.tabControl1.TabIndex = 74;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.lstLog);
            this.tabPage1.Controls.Add(this.pictureBox1);
            this.tabPage1.Controls.Add(this.btnVerificarVez);
            this.tabPage1.Controls.Add(this.lblErro);
            this.tabPage1.Controls.Add(this.btnIniciarJogo);
            this.tabPage1.Controls.Add(this.btnVoltar);
            this.tabPage1.Controls.Add(this.lblNomeJogador);
            this.tabPage1.Controls.Add(this.lstPersonagens);
            this.tabPage1.Controls.Add(this.lblversao);
            this.tabPage1.Controls.Add(this.btnPromover);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.txtIDjogador);
            this.tabPage1.Controls.Add(this.lstSetores);
            this.tabPage1.Controls.Add(this.lblSenhaJogador);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.txtSenhaJogador);
            this.tabPage1.Controls.Add(this.btnExibirCartas);
            this.tabPage1.Controls.Add(this.lblCartas);
            this.tabPage1.Controls.Add(this.lblNomeJogadorVez);
            this.tabPage1.Controls.Add(this.lblIDjogadorVez);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.btnColocarPersonagem);
            this.tabPage1.Controls.Add(this.txtSetor);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.txtPersonagem);
            this.tabPage1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage1.ForeColor = System.Drawing.Color.Goldenrod;
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1366, 705);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Sistema_Autônomo_PI_III.Properties.Resources.Tabuleiro;
            this.pictureBox1.Location = new System.Drawing.Point(400, 15);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(433, 685);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 79;
            this.pictureBox1.TabStop = false;
            // 
            // btnVerificarVez
            // 
            this.btnVerificarVez.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(207)))), ((int)(((byte)(128)))));
            this.btnVerificarVez.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVerificarVez.ForeColor = System.Drawing.Color.Black;
            this.btnVerificarVez.Location = new System.Drawing.Point(6, 239);
            this.btnVerificarVez.Name = "btnVerificarVez";
            this.btnVerificarVez.Size = new System.Drawing.Size(147, 48);
            this.btnVerificarVez.TabIndex = 76;
            this.btnVerificarVez.Text = "Verificar Vez";
            this.btnVerificarVez.UseVisualStyleBackColor = false;
            this.btnVerificarVez.Click += new System.EventHandler(this.btnVerificarVez_Click);
            // 
            // lblErro
            // 
            this.lblErro.AutoSize = true;
            this.lblErro.BackColor = System.Drawing.Color.Transparent;
            this.lblErro.Location = new System.Drawing.Point(258, 20);
            this.lblErro.Name = "lblErro";
            this.lblErro.Size = new System.Drawing.Size(0, 23);
            this.lblErro.TabIndex = 75;
            // 
            // lstLog
            // 
            this.lstLog.BackColor = System.Drawing.Color.AntiqueWhite;
            this.lstLog.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lstLog.FormattingEnabled = true;
            this.lstLog.ItemHeight = 23;
            this.lstLog.Location = new System.Drawing.Point(854, 155);
            this.lstLog.Name = "lstLog";
            this.lstLog.Size = new System.Drawing.Size(281, 393);
            this.lstLog.TabIndex = 81;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(885, 122);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 23);
            this.label1.TabIndex = 82;
            this.label1.Text = "Movimentação:";
            // 
            // ExecutarPartida
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AntiqueWhite;
            this.ClientSize = new System.Drawing.Size(1428, 739);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.lblVotosRestantes);
            this.Controls.Add(this.label6);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ExecutarPartida";
            this.Text = "Cavaleiros de Canterbury";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        #endregion
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblversao;
        private System.Windows.Forms.Label lblNomeJogador;
        private System.Windows.Forms.TextBox txtIDjogador;
        private System.Windows.Forms.Label lblSenhaJogador;
        private System.Windows.Forms.TextBox txtSenhaJogador;
        private System.Windows.Forms.Label lblCartas;
        private System.Windows.Forms.Button btnExibirCartas;
        private System.Windows.Forms.Label lblIDjogadorVez;
        private System.Windows.Forms.Label lblNomeJogadorVez;
        private System.Windows.Forms.Button btnColocarPersonagem;
        private System.Windows.Forms.TextBox txtSetor;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPersonagem;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox lstSetores;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListBox lstPersonagens;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.Label lblVotosRestantes;
        private System.Windows.Forms.Timer tmrVerificarVez;
        private System.Windows.Forms.Timer tmrGeral;
        private System.Windows.Forms.Button btnPromover;
        private System.Windows.Forms.Timer tmrAutomatizador;
        private System.Windows.Forms.Button btnIniciarJogo;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label lblErro;
        private System.Windows.Forms.Button btnVerificarVez;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ListBox lstLog;
        private System.Windows.Forms.Label label1;
    }
}

