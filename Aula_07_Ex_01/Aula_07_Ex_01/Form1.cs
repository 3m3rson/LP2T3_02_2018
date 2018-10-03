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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            FormLivro form = new FormLivro();
            form.StartPosition = FormStartPosition.CenterParent;
            form.ShowDialog(this);
            Fill("");
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dgvAcervo.CurrentCell != null)
            {
                int row = dgvAcervo.CurrentCell.RowIndex;
                IDatabase bd = new BDDicionario();

                Livro result = bd.Read(long.Parse(dgvAcervo.Rows[row].Cells[0].Value.ToString()));
                FormLivro form = new FormLivro(true, result);

                form.StartPosition = FormStartPosition.CenterParent;
                form.ShowDialog(this);
                Fill("");
            }
        }

        private void btnVisualizar_Click(object sender, EventArgs e)
        {

        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            if (dgvAcervo.CurrentCell != null)
            {
                DialogResult result = MessageBox.Show("Deseja mesmo remover o livro.", "Remoção de livro do acervo.", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    int row = dgvAcervo.CurrentCell.RowIndex;
                    IDatabase bd = new BDDicionario();
                    bd.Delete(long.Parse(dgvAcervo.Rows[row].Cells[0].Value.ToString()));
                    Fill("");
                }
            }else
            {
                MessageBox.Show("Por favor, selecione uma linha para remover", "Nenhuma linha selecionada!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void Fill(string filtro)
        {
            IDatabase bd = new BDDicionario();
            List<Livro> list = bd.ListAll();

            dgvAcervo.Rows.Clear();
            foreach (Livro sundfeld in list)
                if(filtro == "" || sundfeld.Autor.ToUpper().Contains(filtro.ToUpper()) || sundfeld.Titulo.ToUpper().Contains(filtro.ToUpper()))
                    dgvAcervo.Rows.Add(sundfeld.Codigo, sundfeld.Titulo, sundfeld.Autor);
        }


        private void txtFiltrar_KeyDown(object sender, KeyEventArgs e)
        {
            Fill(txtFiltrar.Text);
        }

    }
}
