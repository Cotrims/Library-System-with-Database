using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using apBiblioteca.BLL;

namespace apBiblioteca.UI
{
    public partial class FrmLivro : Form
    {
        public FrmLivro()
        {
            InitializeComponent();
        }

        private void btnExibir_Click_1(object sender, EventArgs e)
        {
            try
            {
                LivroBLL livroBLL = new LivroBLL();
                dgvLivro.DataSource = livroBLL.SelecionarLivros();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message.ToString());
            }
        }

        private void btnNovo_Click_1(object sender, EventArgs e)
        {
            Livro livro = new Livro(0, "", "", "");

            try
            {
                if (txtCodigoLivro.Text == "" || txtTituloLivro.Text == "" || txtAutorLivro.Text == "")
                    throw new Exception("Preencha todos os campos!");

                livro.CodigoLivro = txtCodigoLivro.Text;
                livro.TituloLivro = txtTituloLivro.Text;
                livro.AutorLivro = txtAutorLivro.Text;

                LivroBLL livroBLL = new LivroBLL();
                livroBLL.IncluirLivro(livro);
                livro = livroBLL.SelecionarLivroPorCodigo(livro.CodigoLivro);
                txtIdLivro.Text = livro.IdLivro + "";
            }
            catch(Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message.ToString());
            }
        }

        private void btnAlterar_Click_1(object sender, EventArgs e)
        {
            Livro livro = new Livro(0, "", "", "");

            try
            {
                if(txtIdLivro.Text == "" || txtCodigoLivro.Text == "" || txtTituloLivro.Text == "" || txtAutorLivro.Text == "")
                    throw new Exception("Preencha todos os campos!");

                livro.IdLivro = int.Parse(txtIdLivro.Text);
                livro.CodigoLivro = txtCodigoLivro.Text;
                livro.TituloLivro = txtTituloLivro.Text;
                livro.AutorLivro = txtAutorLivro.Text;

                LivroBLL livroBLL = new LivroBLL();
                livroBLL.AlterarLivro(livro);
            }
            catch(Exception ex)
            {
                MessageBox.Show("Erro " + ex.Message.ToString());
            }
        }

        private void btnExcluir_Click_1(object sender, EventArgs e)
        {
            try
            {
                if(txtIdLivro.Text == "")
                    throw new Exception("Digite o id do livro antes de exclui-lo");

                Livro livro = new Livro(Convert.ToInt32(txtIdLivro.Text), "", "", "");

                LivroBLL livrobll = new LivroBLL();
                livrobll.ExcluirLivro(livro);
                btnLimpar.PerformClick();
                MessageBox.Show("Livro excluido com sucesso");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message.ToString());
            }
        }

        private void btnProcurar_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (txtIdLivro.Text == "")
                    throw new Exception("Digite o id antes de procurá-lo");

                int id = Convert.ToInt32(txtIdLivro.Text);
                Livro livro = new Livro(id, "", "", "");

                BLL.LivroBLL bll = new LivroBLL();
                livro = bll.SelecionarLivroPorId(id);
                txtCodigoLivro.Text = livro.CodigoLivro;
                txtTituloLivro.Text = livro.TituloLivro;
                txtAutorLivro.Text = livro.AutorLivro;
            }
            catch (Exception ex)
            {
                MessageBox.Show(" Erro : " + ex.Message.ToString());
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtIdLivro.Text = "";
            txtCodigoLivro.Text = "";
            txtTituloLivro.Text = "";
            txtAutorLivro.Text = "";
        }

        private void tabPage2_Enter(object sender, EventArgs e)
        {
            btnExibir.PerformClick();
        }
    }
}
