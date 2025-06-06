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
    public partial class Credito : Form
    {
        public Credito()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu(); // Cria uma instância do formulário Menu
            menu.Show(); // Exibe o formulário Menu
        }
    }
}
