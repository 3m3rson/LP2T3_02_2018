using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aula_06_Ex_01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnArea_Click(object sender, EventArgs e)
        {
            double l = 0, c = 0;
            double.TryParse(txtLargura.Text,out l);
            double.TryParse(txtComprimento.Text, out c);
            lbAreaValor.Text = (l * c).ToString(); 
        }

        private void btnPreco_Click(object sender, EventArgs e)
        {
            double l = 0, c = 0, p = 0;

            double.TryParse(txtLargura.Text, out l);
            double.TryParse(txtComprimento.Text, out c);
            double.TryParse(txtPreco.Text, out p);

            lbTotalValor.Text = (c * l * p).ToString("C");

            if (l == 0 || c == 0 || p == 0)
                MessageBox.Show("Digite valores para todos os campos editáveis");

        }
    }
}
