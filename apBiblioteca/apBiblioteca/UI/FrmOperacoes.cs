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
    public partial class FrmOperacoes : Form
    {
        LeitorBLL leitorBLL = new LeitorBLL();
        LivroBLL livroBLL = new LivroBLL();
        EmprestimoBLL emprestimoBLL = new EmprestimoBLL();

        public FrmOperacoes()
        {
            InitializeComponent();
        }

        private void btnProcurar_Click(object sender, EventArgs e)
        { 
            try
            {
                if (txtIdLeitor.Text == "")
                    throw new Exception("Digite o código do autor antes de procura-lo");

                Leitor leitor = new Leitor(int.Parse(txtIdLeitor.Text), "", "", "", "");
                leitor = leitorBLL.SelecionarLeitorPorId(leitor.IdLeitor);

                txtIdLeitor.Text = leitor.IdLeitor.ToString();
                txtNomeLeitor.Text = leitor.NomeLeitor;
                txtTelefoneLeitor.Text = leitor.TelefoneLeitor;
                txtEmailLeitor.Text = leitor.EmailLeitor;
                txtEnderecoLeitor.Text = leitor.EnderecoLeitor;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message.ToString());
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtIdLivro.Text == "")
                    throw new Exception("Digite o código do livro antes de procura-lo");

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

        private void FrmOperacoes_Load(object sender, EventArgs e)
        {
            txtEmprestimo.Text = DateTime.Now.ToShortDateString();
            txtDevolucao.Text = DateTime.Now.AddDays(15).ToShortDateString();
        }

        private void btnEmprestimo_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtIdLeitor.Text == "" || txtIdLivro.Text == "")
                    throw new Exception("Escolha o livro E o leitor antes de realizar um empréstimo");

                Emprestimo emprestimo = new Emprestimo(0, 0, 0, DateTime.Now, DateTime.Now, DateTime.Now);

                emprestimo.IdLivro = int.Parse(txtIdLivro.Text);
                emprestimo.IdLeitor = int.Parse(txtIdLeitor.Text);
                emprestimo.DataEmprestimo = Convert.ToDateTime(txtEmprestimo.Text);
                emprestimo.DataDevolucaoPrevista = DateTime.Now.AddDays(15);
                emprestimo.DataDevolucaoReal = new DateTime(1990, 01, 01);

                emprestimoBLL.IncluirEmprestimo(emprestimo);

                MessageBox.Show("Emprestimo realizado com sucesso!", "Aviso", MessageBoxButtons.OK);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message.ToString());
            }
            finally
            {
                txtIdLivro.Text = "";
                txtCodigoLivro.Text = "";
                txtTituloLivro.Text = "";
                txtAutorLivro.Text = "";
            }
        }

        private void cbLivros_SelectedIndexChanged(object sender, EventArgs e)
        {
            int id = int.Parse(cbLivros.Items[cbLivros.SelectedIndex].ToString().Substring(0,3).Trim());

            try
            {
                Livro livro = livroBLL.SelecionarLivroPorId(id);

                txtIdLivroDev.Text = livro.IdLivro.ToString();
                txtCodLivroDev.Text = livro.CodigoLivro;
                txtTituloLivroDev.Text = livro.TituloLivro;
                txtAutorLivroDev.Text = livro.AutorLivro;
            }
            catch(Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message.ToString());
            }
        }

        private void btnDevolucao_Click(object sender, EventArgs e)
        {
            try
            {
                if (cbLivros.SelectedIndex < 0)
                    throw new Exception("Escolha um livro para devolver");

                int id = int.Parse(cbLivros.Items[cbLivros.SelectedIndex].ToString().Substring(0, 3).Trim());

                Emprestimo emprestimo = emprestimoBLL.SelecionarEmprestimoPorIdLivro(id);
                emprestimo.DataDevolucaoReal = DateTime.Now;
                emprestimoBLL.ExcluirEmprestimo(emprestimo);

                MessageBox.Show("Devolução feita com sucesso!", "Aviso", MessageBoxButtons.OK);

                btnListar.PerformClick();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message.ToString());
            }
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtIdLeitor.Text == "")
                    throw new Exception("Selecione um leitor primeiro");

                Leitor leitor = leitorBLL.SelecionarLeitorPorId(int.Parse(txtIdLeitor.Text));

                List<Emprestimo> emprestimos = emprestimoBLL.SelecionarEmprestimoPorIdLeitor(leitor.IdLeitor);

                if (emprestimos.Count <= 0)
                    MessageBox.Show("O leitor atual não possui pendências");

                Livro livro;
                string item;

                cbLivros.Text = "Livros pendentes";
                cbLivros.Items.Clear();

                for (byte i = 0; i < emprestimos.Count; i++)
                {
                    livro = livroBLL.SelecionarLivroPorId(emprestimos[i].IdLivro);
                    item = livro.IdLivro.ToString().PadRight(3, ' ') + " " + livro.TituloLivro.Trim();
                    cbLivros.Items.Add(item);
                }

                txtIdLivroDev.Text = "";
                txtCodLivroDev.Text = "";
                txtTituloLivroDev.Text = "";
                txtAutorLivroDev.Text = "";
            }
            catch(Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message.ToString());
            }
        }

        private void tpDevolucao_Enter(object sender, EventArgs e)
        {
            btnListar.PerformClick();
        }

        private void lsbLivros_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if(lsbLivros.SelectedIndex > 0)
                {
                    int id = int.Parse(lsbLivros.Items[lsbLivros.SelectedIndex].ToString().Substring(0, 3).Trim());

                    Livro livro = livroBLL.SelecionarLivroPorId(id);

                    txtIdLivro.Text = livro.IdLivro.ToString();
                    txtCodigoLivro.Text = livro.CodigoLivro;
                    txtAutorLivro.Text = livro.AutorLivro;
                    txtTituloLivro.Text = livro.TituloLivro;

                    lsbLivros.Visible = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message.ToString());
            }
        }

        private void lsbLeitores_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if(lsbLeitores.SelectedIndex > 0)
                {
                    int id = int.Parse(lsbLeitores.Items[lsbLeitores.SelectedIndex].ToString().Substring(0, 3).Trim());

                    Leitor leitor = leitorBLL.SelecionarLeitorPorId(id);

                    txtIdLeitor.Text = leitor.IdLeitor.ToString();
                    txtNomeLeitor.Text = leitor.NomeLeitor;
                    txtTelefoneLeitor.Text = leitor.TelefoneLeitor;
                    txtEmailLeitor.Text = leitor.EmailLeitor;
                    txtEnderecoLeitor.Text = leitor.EnderecoLeitor;

                    lsbLeitores.Visible = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message.ToString());
            }
        }

        private void btnListarLeitores_Click(object sender, EventArgs e)
        {
            lsbLeitores.Visible = true;
            try
            {
                List<Leitor> listaLeitor = leitorBLL.ListarLeitores();

                lsbLeitores.Items.Clear();
                lsbLeitores.Items.Add("ID  Nome");

                for(short i = 0; i < listaLeitor.Count; i++)
                    lsbLeitores.Items.Add(listaLeitor[i].IdLeitor.ToString().PadRight(3, ' ') + ' ' + listaLeitor[i].NomeLeitor);
            }
            catch(Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message.ToString());
            }
        }

        private void btnListarLivros_Click(object sender, EventArgs e)
        {
            lsbLivros.Visible = true;
            try
            {
                List<Livro> listaLivro = livroBLL.ListarLivros();

                lsbLivros.Items.Clear();
                lsbLivros.Items.Add("ID  Título");

                for (short i = 0; i < listaLivro.Count; i++)
                    lsbLivros.Items.Add(listaLivro[i].IdLivro.ToString().PadRight(3, ' ') + ' ' + listaLivro[i].TituloLivro);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message.ToString());
            }
        }
    }
}
