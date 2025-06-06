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
            this.label6 = new System.Windows.Forms.Label();
            this.lblversao = new System.Windows.Forms.Label();
            this.lblNomeJogador = new System.Windows.Forms.Label();
            this.txtIDjogador = new System.Windows.Forms.TextBox();
            this.lblSenhaJogador = new System.Windows.Forms.Label();
            this.txtSenhaJogador = new System.Windows.Forms.TextBox();
            this.lblCartas = new System.Windows.Forms.Label();
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
            this.btnIniciarJogo = new System.Windows.Forms.Button();
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
            this.lblversao.Location = new System.Drawing.Point(1127, 665);
            this.lblversao.Name = "lblversao";
            this.lblversao.Size = new System.Drawing.Size(51, 16);
            this.lblversao.TabIndex = 30;
            this.lblversao.Text = "Versão";
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
            // lstVerificarVez
            // 
            this.lstVerificarVez.FormattingEnabled = true;
            this.lstVerificarVez.ItemHeight = 16;
            this.lstVerificarVez.Location = new System.Drawing.Point(455, 215);
            this.lstVerificarVez.Margin = new System.Windows.Forms.Padding(4);
            this.lstVerificarVez.Name = "lstVerificarVez";
            this.lstVerificarVez.Size = new System.Drawing.Size(299, 388);
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
            this.btnColocarPersonagem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnColocarPersonagem.Name = "btnColocarPersonagem";
            this.btnColocarPersonagem.Size = new System.Drawing.Size(109, 86);
            this.btnColocarPersonagem.TabIndex = 50;
            this.btnColocarPersonagem.Text = "Colocar Personagem";
            this.btnColocarPersonagem.UseVisualStyleBackColor = true;
            this.btnColocarPersonagem.Click += new System.EventHandler(this.btnColocarPersonagem_Click);
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
            this.label3.Location = new System.Drawing.Point(747, 101);
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(789, 233);
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
            // btnExibirUltimaVotacao
            // 
            this.btnExibirUltimaVotacao.Location = new System.Drawing.Point(777, 322);
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
            this.btnHistorico.Size = new System.Drawing.Size(139, 46);
            this.btnHistorico.TabIndex = 61;
            this.btnHistorico.Text = "Histórico";
            this.btnHistorico.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(807, 596);
            this.checkBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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
            this.lstSetores.Location = new System.Drawing.Point(1043, 65);
            this.lstSetores.Margin = new System.Windows.Forms.Padding(4);
            this.lstSetores.Name = "lstSetores";
            this.lstSetores.Size = new System.Drawing.Size(169, 196);
            this.lstSetores.TabIndex = 64;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(1055, 286);
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
            this.lstPersonagens.Location = new System.Drawing.Point(1043, 322);
            this.lstPersonagens.Margin = new System.Windows.Forms.Padding(4);
            this.lstPersonagens.Name = "lstPersonagens";
            this.lstPersonagens.Size = new System.Drawing.Size(169, 228);
            this.lstPersonagens.TabIndex = 66;
            // 
            // btnPersonagens
            // 
            this.btnPersonagens.Location = new System.Drawing.Point(933, 638);
            this.btnPersonagens.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnPersonagens.Name = "btnPersonagens";
            this.btnPersonagens.Size = new System.Drawing.Size(139, 44);
            this.btnPersonagens.TabIndex = 67;
            this.btnPersonagens.Text = "Ver Personagens";
            this.btnPersonagens.UseVisualStyleBackColor = true;
            this.btnPersonagens.Click += new System.EventHandler(this.btnPersonagens_Click);
            // 
            // btnVoltar
            // 
            this.btnVoltar.Location = new System.Drawing.Point(837, 638);
            this.btnVoltar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(75, 46);
            this.btnVoltar.TabIndex = 68;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseVisualStyleBackColor = true;
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
            this.tmrVerificarVez.Interval = 5000;
            // 
            // tmrGeral
            // 
            this.tmrGeral.Interval = 5000;
            // 
            // btnIniciarAutomacao
            // 
            this.btnIniciarAutomacao.Location = new System.Drawing.Point(921, 196);
            this.btnIniciarAutomacao.Name = "btnIniciarAutomacao";
            this.btnIniciarAutomacao.Size = new System.Drawing.Size(90, 45);
            this.btnIniciarAutomacao.TabIndex = 70;
            this.btnIniciarAutomacao.Text = "automaçao";
            this.btnIniciarAutomacao.UseVisualStyleBackColor = true;
            this.btnIniciarAutomacao.Click += new System.EventHandler(this.btnIniciarAutomacao_Click);
            // 
            // btnPromover
            // 
            this.btnPromover.Location = new System.Drawing.Point(792, 169);
            this.btnPromover.Name = "btnPromover";
            this.btnPromover.Size = new System.Drawing.Size(75, 32);
            this.btnPromover.TabIndex = 71;
            this.btnPromover.Text = "promover";
            this.btnPromover.UseVisualStyleBackColor = true;
            this.btnPromover.Click += new System.EventHandler(this.btnPromover_Click);
            // 
            // btnConfirmarVoto
            // 
            this.btnConfirmarVoto.Location = new System.Drawing.Point(917, 269);
            this.btnConfirmarVoto.Name = "btnConfirmarVoto";
            this.btnConfirmarVoto.Size = new System.Drawing.Size(75, 39);
            this.btnConfirmarVoto.TabIndex = 72;
            this.btnConfirmarVoto.Text = "Confirmar";
            this.btnConfirmarVoto.UseVisualStyleBackColor = true;
            this.btnConfirmarVoto.Click += new System.EventHandler(this.btnConfirmarVoto_Click);
            // 
            // tmrAutomatizador
            // 
            this.tmrAutomatizador.Enabled = true;
            this.tmrAutomatizador.Interval = 5000;
            // 
            // btnIniciarJogo
            // 
            this.btnIniciarJogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(234)))), ((int)(((byte)(174)))));
            this.btnIniciarJogo.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIniciarJogo.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btnIniciarJogo.Location = new System.Drawing.Point(44, 53);
            this.btnIniciarJogo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnIniciarJogo.Name = "btnIniciarJogo";
            this.btnIniciarJogo.Size = new System.Drawing.Size(312, 47);
            this.btnIniciarJogo.TabIndex = 73;
            this.btnIniciarJogo.Text = "🎮Iniciar Jogo";
            this.btnIniciarJogo.UseVisualStyleBackColor = false;
            this.btnIniciarJogo.Click += new System.EventHandler(this.btnIniciarJogo_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1224, 700);
            this.Controls.Add(this.btnIniciarJogo);
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
            this.Controls.Add(this.lblCartas);
            this.Controls.Add(this.txtSenhaJogador);
            this.Controls.Add(this.lblSenhaJogador);
            this.Controls.Add(this.txtIDjogador);
            this.Controls.Add(this.lblNomeJogador);
            this.Controls.Add(this.lblversao);
            this.Controls.Add(this.label6);
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
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblversao;
        private System.Windows.Forms.Label lblNomeJogador;
        private System.Windows.Forms.TextBox txtIDjogador;
        private System.Windows.Forms.Label lblSenhaJogador;
        private System.Windows.Forms.TextBox txtSenhaJogador;
        private System.Windows.Forms.Label lblCartas;
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
        private System.Windows.Forms.Button btnIniciarJogo;
    }
}

