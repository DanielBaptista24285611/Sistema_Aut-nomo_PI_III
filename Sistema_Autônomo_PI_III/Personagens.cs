using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_Autônomo_PI_III
{
    public partial class Personagens : Form
    {
        public Dictionary<int, Point> setores;
       // public string jpeg;

        public Personagens()
        {
            InitializeComponent();
            /*tabuleiro largura 490, altura 743
            set0 = 106
            set1 = 212
            set2 = 318
            set3 = 424
            set4 = 530
            set5 = 636
            set10 = 742
            */

            // passando os valores que corresponde a cada setor
            setores = new Dictionary<int, Point>
            {
                { 0, new Point(106, 100) },
                { 1, new Point(212, 100) },
                { 2, new Point(318, 100) },
                { 3, new Point(424, 100) },
                { 4, new Point(530, 100) },
                { 5, new Point(636, 100) },
                { 10, new Point(742, 100) },
            };
        }

      

        //metodo para criar e posicionar os jogadores
        private void CriarJogador(int setor, string nomeJogador)
        {
            // verifica se o setor existe no dicionário
            if (setores.ContainsKey(setor))
            {
                // cria um novo PictureBox para representar o jogador
                PictureBox jogadorPictureBox = new PictureBox
                {
                    Size = new Size(37, 63), // Ajuste o tamanho do PictureBox conforme necessário
                    Location = setores[setor], // Posiciona o jogador no setor correto
                    BackgroundImage = Image.FromFile(Application.StartupPath + @"\Imagens\Carta B.jpeg"), // Cor de fundo do PictureBox para representar o jogador
                    Name = nomeJogador 
                };

                // Adiciona o PictureBox no Formulário
                this.Controls.Add(jogadorPictureBox);
            }
        }

        private void Personagens_Load(object sender, EventArgs e)
        {


        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2A_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2D_Click(object sender, EventArgs e)
        {

        }
    }
}
