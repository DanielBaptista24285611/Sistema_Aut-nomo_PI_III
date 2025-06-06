namespace Sistema_Autônomo_PI_III
{
    partial class GerenciarPartida
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.lblInforma = new System.Windows.Forms.Label();
            this.lstPartidas = new System.Windows.Forms.ListBox();
            this.btnListarPartidas = new System.Windows.Forms.Button();
            this.txtIdPartida = new System.Windows.Forms.TextBox();
            this.btnCriar = new System.Windows.Forms.Button();
            this.txtNomeGrupo = new System.Windows.Forms.TextBox();
            this.lblNomeGrupo = new System.Windows.Forms.Label();
            this.lblSenhaPartida = new System.Windows.Forms.Label();
            this.txtSenhaPartida = new System.Windows.Forms.TextBox();
            this.txtNomePartida = new System.Windows.Forms.TextBox();
            this.lblNomePartida = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.lblInforma2 = new System.Windows.Forms.Label();
            this.lstJogadores = new System.Windows.Forms.ListBox();
            this.btnListarJogadores = new System.Windows.Forms.Button();
            this.btnEntrar = new System.Windows.Forms.Button();
            this.txtNomeJogador = new System.Windows.Forms.TextBox();
            this.lblNome = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(45, 81);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(655, 563);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.White;
            this.tabPage1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabPage1.Controls.Add(this.lblInforma);
            this.tabPage1.Controls.Add(this.lstPartidas);
            this.tabPage1.Controls.Add(this.btnListarPartidas);
            this.tabPage1.Controls.Add(this.txtIdPartida);
            this.tabPage1.Controls.Add(this.btnCriar);
            this.tabPage1.Controls.Add(this.txtNomeGrupo);
            this.tabPage1.Controls.Add(this.lblNomeGrupo);
            this.tabPage1.Controls.Add(this.lblSenhaPartida);
            this.tabPage1.Controls.Add(this.txtSenhaPartida);
            this.tabPage1.Controls.Add(this.txtNomePartida);
            this.tabPage1.Controls.Add(this.lblNomePartida);
            this.tabPage1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage1.Location = new System.Drawing.Point(4, 26);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Size = new System.Drawing.Size(647, 533);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = " 🏰Criar Partida";
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // lblInforma
            // 
            this.lblInforma.AutoSize = true;
            this.lblInforma.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInforma.ForeColor = System.Drawing.Color.Goldenrod;
            this.lblInforma.Location = new System.Drawing.Point(295, 437);
            this.lblInforma.Name = "lblInforma";
            this.lblInforma.Size = new System.Drawing.Size(112, 23);
            this.lblInforma.TabIndex = 45;
            this.lblInforma.Text = "Criar Partida";
            // 
            // lstPartidas
            // 
            this.lstPartidas.BackColor = System.Drawing.Color.AntiqueWhite;
            this.lstPartidas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lstPartidas.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstPartidas.FormattingEnabled = true;
            this.lstPartidas.ItemHeight = 23;
            this.lstPartidas.Location = new System.Drawing.Point(299, 125);
            this.lstPartidas.Margin = new System.Windows.Forms.Padding(4);
            this.lstPartidas.Name = "lstPartidas";
            this.lstPartidas.Size = new System.Drawing.Size(311, 278);
            this.lstPartidas.TabIndex = 44;
            this.lstPartidas.Tag = "";
            // 
            // btnListarPartidas
            // 
            this.btnListarPartidas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(207)))), ((int)(((byte)(128)))));
            this.btnListarPartidas.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnListarPartidas.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btnListarPartidas.Location = new System.Drawing.Point(438, 17);
            this.btnListarPartidas.Margin = new System.Windows.Forms.Padding(4);
            this.btnListarPartidas.Name = "btnListarPartidas";
            this.btnListarPartidas.Size = new System.Drawing.Size(172, 58);
            this.btnListarPartidas.TabIndex = 29;
            this.btnListarPartidas.Text = "🔄️Listar Partidas";
            this.btnListarPartidas.UseVisualStyleBackColor = false;
            this.btnListarPartidas.Click += new System.EventHandler(this.btnListarPartidas_Click);
            // 
            // txtIdPartida
            // 
            this.txtIdPartida.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(234)))), ((int)(((byte)(174)))));
            this.txtIdPartida.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtIdPartida.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdPartida.Location = new System.Drawing.Point(20, 461);
            this.txtIdPartida.Margin = new System.Windows.Forms.Padding(4);
            this.txtIdPartida.Name = "txtIdPartida";
            this.txtIdPartida.Size = new System.Drawing.Size(240, 30);
            this.txtIdPartida.TabIndex = 28;
            this.txtIdPartida.Text = "ID Partida Criada";
            this.txtIdPartida.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnCriar
            // 
            this.btnCriar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(207)))), ((int)(((byte)(128)))));
            this.btnCriar.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCriar.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btnCriar.Location = new System.Drawing.Point(20, 361);
            this.btnCriar.Margin = new System.Windows.Forms.Padding(4);
            this.btnCriar.Name = "btnCriar";
            this.btnCriar.Size = new System.Drawing.Size(240, 61);
            this.btnCriar.TabIndex = 22;
            this.btnCriar.Text = "🏰Criar Partida";
            this.btnCriar.UseVisualStyleBackColor = false;
            this.btnCriar.Click += new System.EventHandler(this.btnCriar_Click);
            // 
            // txtNomeGrupo
            // 
            this.txtNomeGrupo.BackColor = System.Drawing.Color.AntiqueWhite;
            this.txtNomeGrupo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNomeGrupo.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomeGrupo.ForeColor = System.Drawing.Color.Black;
            this.txtNomeGrupo.Location = new System.Drawing.Point(20, 287);
            this.txtNomeGrupo.Margin = new System.Windows.Forms.Padding(4);
            this.txtNomeGrupo.Name = "txtNomeGrupo";
            this.txtNomeGrupo.Size = new System.Drawing.Size(240, 30);
            this.txtNomeGrupo.TabIndex = 21;
            // 
            // lblNomeGrupo
            // 
            this.lblNomeGrupo.AutoSize = true;
            this.lblNomeGrupo.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomeGrupo.ForeColor = System.Drawing.Color.Goldenrod;
            this.lblNomeGrupo.Location = new System.Drawing.Point(16, 236);
            this.lblNomeGrupo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNomeGrupo.Name = "lblNomeGrupo";
            this.lblNomeGrupo.Size = new System.Drawing.Size(139, 23);
            this.lblNomeGrupo.TabIndex = 20;
            this.lblNomeGrupo.Text = "Nome do Grupo";
            // 
            // lblSenhaPartida
            // 
            this.lblSenhaPartida.AutoSize = true;
            this.lblSenhaPartida.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSenhaPartida.ForeColor = System.Drawing.Color.Goldenrod;
            this.lblSenhaPartida.Location = new System.Drawing.Point(16, 125);
            this.lblSenhaPartida.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSenhaPartida.Name = "lblSenhaPartida";
            this.lblSenhaPartida.Size = new System.Drawing.Size(146, 23);
            this.lblSenhaPartida.TabIndex = 19;
            this.lblSenhaPartida.Text = "Senha da Partida";
            this.lblSenhaPartida.Click += new System.EventHandler(this.lblSenhaPartida_Click);
            // 
            // txtSenhaPartida
            // 
            this.txtSenhaPartida.BackColor = System.Drawing.Color.AntiqueWhite;
            this.txtSenhaPartida.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSenhaPartida.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSenhaPartida.Location = new System.Drawing.Point(20, 177);
            this.txtSenhaPartida.Margin = new System.Windows.Forms.Padding(4);
            this.txtSenhaPartida.Name = "txtSenhaPartida";
            this.txtSenhaPartida.Size = new System.Drawing.Size(237, 30);
            this.txtSenhaPartida.TabIndex = 18;
            // 
            // txtNomePartida
            // 
            this.txtNomePartida.BackColor = System.Drawing.Color.AntiqueWhite;
            this.txtNomePartida.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNomePartida.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomePartida.Location = new System.Drawing.Point(20, 69);
            this.txtNomePartida.Margin = new System.Windows.Forms.Padding(4);
            this.txtNomePartida.Name = "txtNomePartida";
            this.txtNomePartida.Size = new System.Drawing.Size(237, 30);
            this.txtNomePartida.TabIndex = 17;
            // 
            // lblNomePartida
            // 
            this.lblNomePartida.AutoSize = true;
            this.lblNomePartida.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomePartida.ForeColor = System.Drawing.Color.Goldenrod;
            this.lblNomePartida.Location = new System.Drawing.Point(16, 17);
            this.lblNomePartida.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNomePartida.Name = "lblNomePartida";
            this.lblNomePartida.Size = new System.Drawing.Size(146, 23);
            this.lblNomePartida.TabIndex = 4;
            this.lblNomePartida.Text = "Nome da Partida";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.White;
            this.tabPage2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabPage2.Controls.Add(this.lblInforma2);
            this.tabPage2.Controls.Add(this.lstJogadores);
            this.tabPage2.Controls.Add(this.btnListarJogadores);
            this.tabPage2.Controls.Add(this.btnEntrar);
            this.tabPage2.Controls.Add(this.txtNomeJogador);
            this.tabPage2.Controls.Add(this.lblNome);
            this.tabPage2.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage2.Location = new System.Drawing.Point(4, 26);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Size = new System.Drawing.Size(647, 533);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "⚔️Entrar em Partida";
            // 
            // lblInforma2
            // 
            this.lblInforma2.AutoSize = true;
            this.lblInforma2.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInforma2.ForeColor = System.Drawing.Color.Goldenrod;
            this.lblInforma2.Location = new System.Drawing.Point(323, 157);
            this.lblInforma2.Name = "lblInforma2";
            this.lblInforma2.Size = new System.Drawing.Size(122, 23);
            this.lblInforma2.TabIndex = 47;
            this.lblInforma2.Text = "Entrar Partida";
            // 
            // lstJogadores
            // 
            this.lstJogadores.BackColor = System.Drawing.Color.AntiqueWhite;
            this.lstJogadores.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstJogadores.FormattingEnabled = true;
            this.lstJogadores.ItemHeight = 23;
            this.lstJogadores.Location = new System.Drawing.Point(63, 224);
            this.lstJogadores.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lstJogadores.Name = "lstJogadores";
            this.lstJogadores.Size = new System.Drawing.Size(515, 257);
            this.lstJogadores.TabIndex = 45;
            // 
            // btnListarJogadores
            // 
            this.btnListarJogadores.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(207)))), ((int)(((byte)(128)))));
            this.btnListarJogadores.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnListarJogadores.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btnListarJogadores.Location = new System.Drawing.Point(422, 81);
            this.btnListarJogadores.Margin = new System.Windows.Forms.Padding(4);
            this.btnListarJogadores.Name = "btnListarJogadores";
            this.btnListarJogadores.Size = new System.Drawing.Size(193, 57);
            this.btnListarJogadores.TabIndex = 44;
            this.btnListarJogadores.Text = "🔄️Listar Jogadores";
            this.btnListarJogadores.UseVisualStyleBackColor = false;
            this.btnListarJogadores.Click += new System.EventHandler(this.btnListarJogadores_Click);
            // 
            // btnEntrar
            // 
            this.btnEntrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(207)))), ((int)(((byte)(128)))));
            this.btnEntrar.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEntrar.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btnEntrar.Location = new System.Drawing.Point(54, 121);
            this.btnEntrar.Margin = new System.Windows.Forms.Padding(4);
            this.btnEntrar.Name = "btnEntrar";
            this.btnEntrar.Size = new System.Drawing.Size(214, 59);
            this.btnEntrar.TabIndex = 43;
            this.btnEntrar.Text = "⚔️Entrar na Partida";
            this.btnEntrar.UseVisualStyleBackColor = false;
            this.btnEntrar.Click += new System.EventHandler(this.btnEntrar_Click_1);
            // 
            // txtNomeJogador
            // 
            this.txtNomeJogador.BackColor = System.Drawing.Color.AntiqueWhite;
            this.txtNomeJogador.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNomeJogador.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomeJogador.Location = new System.Drawing.Point(43, 65);
            this.txtNomeJogador.Margin = new System.Windows.Forms.Padding(4);
            this.txtNomeJogador.Name = "txtNomeJogador";
            this.txtNomeJogador.Size = new System.Drawing.Size(246, 30);
            this.txtNomeJogador.TabIndex = 22;
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.ForeColor = System.Drawing.Color.Goldenrod;
            this.lblNome.Location = new System.Drawing.Point(39, 21);
            this.lblNome.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(155, 23);
            this.lblNome.TabIndex = 21;
            this.lblNome.Text = "Nome do Jogador";
            // 
            // GerenciarPartida
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AntiqueWhite;
            this.ClientSize = new System.Drawing.Size(748, 736);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "GerenciarPartida";
            this.Text = "GerenciarPartida";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label lblNomePartida;
        private System.Windows.Forms.TextBox txtNomePartida;
        private System.Windows.Forms.TextBox txtSenhaPartida;
        private System.Windows.Forms.Label lblSenhaPartida;
        private System.Windows.Forms.Label lblNomeGrupo;
        private System.Windows.Forms.TextBox txtNomeGrupo;
        private System.Windows.Forms.Button btnCriar;
        private System.Windows.Forms.Button btnListarPartidas;
        private System.Windows.Forms.ListBox lstPartidas;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.TextBox txtNomeJogador;
        private System.Windows.Forms.Button btnEntrar;
        private System.Windows.Forms.Button btnListarJogadores;
        private System.Windows.Forms.ListBox lstJogadores;
        private System.Windows.Forms.TextBox txtIdPartida;
        private System.Windows.Forms.Label lblInforma;
        private System.Windows.Forms.Label lblInforma2;
    }
}