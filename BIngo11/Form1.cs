using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bingo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btIniciar_Click(object sender, EventArgs e)
        {
            decimal qtd = numQtd.Value;
            DialogResult r = MessageBox.Show($"Deseja iniciar o bingo com {qtd} cartelas?",
                "Bingo", MessageBoxButtons.YesNo);
            if (r == DialogResult.Yes)
            {
                FrmSorteador f = new FrmSorteador(this, (int)qtd);
                f.Show();
                this.Hide();
            }

        }
    }
}