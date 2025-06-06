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

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close(); // Fecha o formulário de crédito
        }

        private void Credito_Load(object sender, EventArgs e)
        {

        }
    }
}
