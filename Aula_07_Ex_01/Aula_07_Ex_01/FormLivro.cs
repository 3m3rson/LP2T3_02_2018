using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aula_07_Ex_01
{
    public partial class FormLivro : Form
    {
        private bool editavel = true;
        private bool salvar = true;
        private Livro livro;

        public FormLivro()
        {
            InitializeComponent();
        }

        public FormLivro(bool editavel, Livro l)
        {
            this.editavel = editavel;
            salvar = false;
            this.livro = l;
            InitializeComponent();

            txtAutor.Text = l.Autor;
            txtNumero.Text = l.Codigo.ToString();
            txtTitulo.Text = l.Titulo;

        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            IDatabase bd = new BDMySql();
            if (salvar)
            {
                bd.Save(new Livro(0,txtTitulo.Text, txtAutor.Text));
                Dispose();
            }else if (editavel)
            {
                bd.Update(new Livro(long.Parse(txtNumero.Text), txtTitulo.Text, txtAutor.Text));
                Dispose();
            }
            else
            {

            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Dispose();
        }
    }
}
