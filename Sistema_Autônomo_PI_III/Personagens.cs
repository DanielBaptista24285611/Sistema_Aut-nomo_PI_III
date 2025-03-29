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
         public string jpeg;
        //private Dictionary<string, PictureBox> personagens;
        //private PictureBox[] setores;


        public Personagens()
        {
            //PictureBox[] pictureBoxes = new PictureBox[7];
            //setores = pictureBoxes;
            InitializeComponent();
            //tabuleiro largura 490, altura 743
            int set0 = 106;
            int set1 = 212;
            int set2 = 318;
            int set3 = 424;
            int set4 = 530;
            int set5 = 636;
            int set10 = 742;
            
            //this.Text = "Tabuleiro - Cavaleiros de Canterbury";
            //this.Size = new Size(800, 600);

            //InicializarSetores();
            //InicializarPersonagens();

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
        /*
        private void InicializarPersonagens()
        {
            personagens = new Dictionary<string, PictureBox>();
            string[] nomes = { "A", "B", "C", "D", "E", "G", "I", "K", "M", "Q", "R", "T", "V", "Z" };

            for (int i = 0; i < nomes.Length; i++)
            {
                PictureBox personagem = new PictureBox()
                {
                    BorderStyle = BorderStyle.FixedSingle,
                    Size = new Size(50, 70),
                    Location = new Point(50, 50 + i * 50),
                    Tag = nomes[i],
                    BackColor = Color.Beige
                };
                personagem.Click += Personagem_Click;
                this.Controls.Add(personagem);
                personagens[nomes[i]] = personagem;
            }
        }

        private void InicializarSetores()
        {
            for (int i = 0; i < 7; i++)
            {
                setores[i] = new PictureBox()
                {
                    BorderStyle = BorderStyle.FixedSingle,
                    Size = new Size(200, 80),
                    Location = new Point(300, 50 + i * 85),
                    BackColor = Color.LightGray
                };
                this.Controls.Add(setores[i]);
            }
        }

        private void Personagem_Click(object sender, EventArgs e)
        {
            PictureBox personagem = sender as PictureBox;
            if (personagem != null)
            {
                int setorIndex = new Random().Next(0, 7);
                personagem.Location = setores[setorIndex].Location;
            }
        }

        [STAThread]
        public static void Main()
        {
            Application.EnableVisualStyles();
            Application.Run(new Tabuleiro());
        }
    }
}
*/


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

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
