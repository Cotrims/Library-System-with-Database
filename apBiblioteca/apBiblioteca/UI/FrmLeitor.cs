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
    public partial class FrmLeitor : Form
    {
        public FrmLeitor()
        {
            InitializeComponent();
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            if (txtIdLeitor.Text == "")
                txtIdLeitor.Text = "0";

            Leitor leitor = new Leitor(0, "", "", "", "");

            try
            {
                if (txtNomeLeitor.Text == "" || txtTelefoneLeitor.Text == "" || txtEmailLeitor.Text == "" || txtEnderecoLeitor.Text == "")
                    throw new Exception("Digite todos os campos!");

                leitor.NomeLeitor = txtNomeLeitor.Text.Trim();
                leitor.TelefoneLeitor = txtTelefoneLeitor.Text.Trim();
                leitor.EmailLeitor = txtEmailLeitor.Text.Trim();
                leitor.EnderecoLeitor = txtEnderecoLeitor.Text.Trim();

                LeitorBLL leitorBLL = new LeitorBLL();
                leitorBLL.IncluirLeitor(leitor);
                leitor = leitorBLL.SelecionarLeitorPorNome(leitor.NomeLeitor);
                txtIdLeitor.Text = leitor.IdLeitor + "";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message.ToString());
            }
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {

            try
            {
                if (txtIdLeitor.Text == "" || txtNomeLeitor.Text == "" || txtTelefoneLeitor.Text == "" || txtEmailLeitor.Text == "" || txtEnderecoLeitor.Text == "")
                    throw new Exception("Digite todos os campos!");

                Leitor leitor = new Leitor(int.Parse(txtIdLeitor.Text), "", "", "", "");

                leitor.NomeLeitor = txtNomeLeitor.Text.Trim();
                leitor.TelefoneLeitor = txtTelefoneLeitor.Text.Trim();
                leitor.EmailLeitor = txtEmailLeitor.Text.Trim();
                leitor.EnderecoLeitor = txtEnderecoLeitor.Text.Trim();

                LeitorBLL leitorBLL = new LeitorBLL();
                leitorBLL.AlterarLeitor(leitor);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message.ToString());
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtIdLeitor.Text == "")
                    throw new Exception("Digite o id do Leitor antes de exclui-lo");

                Leitor leitor = new Leitor(int.Parse(txtIdLeitor.Text), "", "", "", "");

                LeitorBLL leitorBLL = new LeitorBLL();
                leitorBLL.ExcluirLeitor(leitor);
                btnLimpar.PerformClick();
                MessageBox.Show("Leitor excluido com sucesso");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message.ToString());
            }
        }

        private void btnExibir_Click(object sender, EventArgs e)
        {
            try
            {
                LeitorBLL leitorBLL = new LeitorBLL();
                dgvLeitor.DataSource = leitorBLL.SelecionarLeitor();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message.ToString());
            }
        }

        private void btnProcurar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtIdLeitor.Text == "")
                    throw new Exception("Digite o id antes de procurá-lo");

                Leitor leitor = new Leitor(int.Parse(txtIdLeitor.Text), "", "", "", "");

                LeitorBLL leitorBLL = new LeitorBLL();
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

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtIdLeitor.Text = "";
            txtIdLeitor.Text = "";
            txtNomeLeitor.Text = "";
            txtTelefoneLeitor.Text = "";
            txtEmailLeitor.Text = "";
            txtEnderecoLeitor.Text = "";
        }

        private void tabPage2_Enter(object sender, EventArgs e)
        {
            btnExibir.PerformClick();
        }
    }
}
