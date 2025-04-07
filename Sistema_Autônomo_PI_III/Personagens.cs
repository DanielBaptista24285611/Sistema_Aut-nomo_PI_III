using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Sistema_Autônomo_PI_III
{
    public partial class Personagens : Form
    {
        public Dictionary<int, Point> setores;

        public Personagens()
        {
            InitializeComponent();

            setores = new Dictionary<int, Point>
            {
                { 0, new Point(106, 100) },
                { 1, new Point(212, 100) },
                { 2, new Point(318, 100) },
                { 3, new Point(424, 100) },
                { 4, new Point(530, 100) },
                { 5, new Point(636, 100) },
                { 10, new Point(742, 100) }
            };
        }

        private void CriarJogador(int setor, string nomeJogador)
        {
            if (setores.TryGetValue(setor, out Point posicao))
            {
                PictureBox jogadorPictureBox = new PictureBox
                {
                    Size = new Size(37, 63),
                    Location = posicao,
                    BackgroundImage = Image.FromFile(Application.StartupPath + @"\Imagens\Carta B.jpeg"),
                    BackgroundImageLayout = ImageLayout.Stretch,
                    Name = nomeJogador
                };
                this.Controls.Add(jogadorPictureBox);
            }
        }

        private void Personagens_Load(object sender, EventArgs e) { }
        private void pictureBox1_Click(object sender, EventArgs e) { }
        private void pictureBox2A_Click(object sender, EventArgs e) { }
        private void pictureBox2D_Click(object sender, EventArgs e) { }
        private void panel1_Paint(object sender, PaintEventArgs e) { }
    }
}
