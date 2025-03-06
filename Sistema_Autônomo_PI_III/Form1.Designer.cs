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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSenhaPartida = new System.Windows.Forms.TextBox();
            this.btnCriar = new System.Windows.Forms.Button();
            this.txtNomeGrupo = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtIdPartida = new System.Windows.Forms.TextBox();
            this.txtNomePartida = new System.Windows.Forms.TextBox();
            this.btnListarPartidas = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtNomeJogador = new System.Windows.Forms.TextBox();
            this.btnEntrar = new System.Windows.Forms.Button();
            this.btnListarJogadores = new System.Windows.Forms.Button();
            this.txtListarJogadores = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.lblInforma = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Nome da Partida";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Senha da Partida";
            // 
            // txtSenhaPartida
            // 
            this.txtSenhaPartida.Location = new System.Drawing.Point(31, 69);
            this.txtSenhaPartida.Name = "txtSenhaPartida";
            this.txtSenhaPartida.Size = new System.Drawing.Size(140, 20);
            this.txtSenhaPartida.TabIndex = 6;
            // 
            // btnCriar
            // 
            this.btnCriar.Location = new System.Drawing.Point(194, 19);
            this.btnCriar.Name = "btnCriar";
            this.btnCriar.Size = new System.Drawing.Size(99, 70);
            this.btnCriar.TabIndex = 7;
            this.btnCriar.Text = "Criar Partida";
            this.btnCriar.UseVisualStyleBackColor = true;
            this.btnCriar.Click += new System.EventHandler(this.btnCriar_Click);
            // 
            // txtNomeGrupo
            // 
            this.txtNomeGrupo.Location = new System.Drawing.Point(31, 123);
            this.txtNomeGrupo.Name = "txtNomeGrupo";
            this.txtNomeGrupo.Size = new System.Drawing.Size(140, 20);
            this.txtNomeGrupo.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(28, 162);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "Id da Partida";
            // 
            // txtIdPartida
            // 
            this.txtIdPartida.Location = new System.Drawing.Point(31, 178);
            this.txtIdPartida.Name = "txtIdPartida";
            this.txtIdPartida.Size = new System.Drawing.Size(140, 20);
            this.txtIdPartida.TabIndex = 14;
            // 
            // txtNomePartida
            // 
            this.txtNomePartida.Location = new System.Drawing.Point(31, 25);
            this.txtNomePartida.Name = "txtNomePartida";
            this.txtNomePartida.Size = new System.Drawing.Size(140, 20);
            this.txtNomePartida.TabIndex = 16;
            // 
            // btnListarPartidas
            // 
            this.btnListarPartidas.Location = new System.Drawing.Point(31, 214);
            this.btnListarPartidas.Name = "btnListarPartidas";
            this.btnListarPartidas.Size = new System.Drawing.Size(97, 22);
            this.btnListarPartidas.TabIndex = 17;
            this.btnListarPartidas.Text = "Listar Partidas";
            this.btnListarPartidas.UseVisualStyleBackColor = true;
            this.btnListarPartidas.Click += new System.EventHandler(this.btnListarPartidas_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 13);
            this.label3.TabIndex = 18;
            this.label3.Text = "Nome do Grupo";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(28, 376);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 13);
            this.label5.TabIndex = 20;
            this.label5.Text = "Nome do Jogador";
            // 
            // txtNomeJogador
            // 
            this.txtNomeJogador.Location = new System.Drawing.Point(31, 392);
            this.txtNomeJogador.Name = "txtNomeJogador";
            this.txtNomeJogador.Size = new System.Drawing.Size(140, 20);
            this.txtNomeJogador.TabIndex = 19;
            // 
            // btnEntrar
            // 
            this.btnEntrar.Location = new System.Drawing.Point(196, 381);
            this.btnEntrar.Name = "btnEntrar";
            this.btnEntrar.Size = new System.Drawing.Size(107, 31);
            this.btnEntrar.TabIndex = 21;
            this.btnEntrar.Text = "Entrar na Partida";
            this.btnEntrar.UseVisualStyleBackColor = true;
            // 
            // btnListarJogadores
            // 
            this.btnListarJogadores.Location = new System.Drawing.Point(31, 430);
            this.btnListarJogadores.Name = "btnListarJogadores";
            this.btnListarJogadores.Size = new System.Drawing.Size(94, 21);
            this.btnListarJogadores.TabIndex = 22;
            this.btnListarJogadores.Text = "Listar Jogadores";
            this.btnListarJogadores.UseVisualStyleBackColor = true;
            // 
            // txtListarJogadores
            // 
            this.txtListarJogadores.Location = new System.Drawing.Point(31, 457);
            this.txtListarJogadores.Multiline = true;
            this.txtListarJogadores.Name = "txtListarJogadores";
            this.txtListarJogadores.Size = new System.Drawing.Size(272, 78);
            this.txtListarJogadores.TabIndex = 23;
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::Sistema_Autônomo_PI_III.Properties.Resources.CaveleiroCavalo;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel1.ForeColor = System.Drawing.Color.Transparent;
            this.panel1.Location = new System.Drawing.Point(531, 124);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(254, 247);
            this.panel1.TabIndex = 24;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(31, 239);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(272, 134);
            this.listBox1.TabIndex = 25;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // lblInforma
            // 
            this.lblInforma.AutoSize = true;
            this.lblInforma.Location = new System.Drawing.Point(191, 92);
            this.lblInforma.Name = "lblInforma";
            this.lblInforma.Size = new System.Drawing.Size(0, 13);
            this.lblInforma.TabIndex = 26;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(887, 561);
            this.Controls.Add(this.lblInforma);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtListarJogadores);
            this.Controls.Add(this.btnListarJogadores);
            this.Controls.Add(this.btnEntrar);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtNomeJogador);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnListarPartidas);
            this.Controls.Add(this.txtNomePartida);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtIdPartida);
            this.Controls.Add(this.txtNomeGrupo);
            this.Controls.Add(this.btnCriar);
            this.Controls.Add(this.txtSenhaPartida);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Cavaleiros de Canterbury";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSenhaPartida;
        private System.Windows.Forms.Button btnCriar;
        private System.Windows.Forms.TextBox txtNomeGrupo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtIdPartida;
        private System.Windows.Forms.TextBox txtNomePartida;
        private System.Windows.Forms.Button btnListarPartidas;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtNomeJogador;
        private System.Windows.Forms.Button btnEntrar;
        private System.Windows.Forms.Button btnListarJogadores;
        private System.Windows.Forms.TextBox txtListarJogadores;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label lblInforma;
    }
}

