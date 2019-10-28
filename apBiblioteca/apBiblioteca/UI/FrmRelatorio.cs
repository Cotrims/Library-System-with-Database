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
    public partial class FrmRelatorio : Form
    {
        EmprestimoBLL emprestimoBLL = new EmprestimoBLL();
        LeitorBLL leitorBLL = new LeitorBLL();
        LivroBLL livroBLL = new LivroBLL();

        public FrmRelatorio()
        {
            InitializeComponent();
        }

        private void FrmRelatorio_Load(object sender, EventArgs e)
        {
            try
            {
                List<Emprestimo> listaEmprestimo = emprestimoBLL.ListarEmprestimos();
                Livro livroAtual = null;
                Leitor leitorAtual = null;

                dgvRelatorio.RowCount = listaEmprestimo.Count;

                for(short i = 0; i < listaEmprestimo.Count; i++)
                {
                    livroAtual = livroBLL.SelecionarLivroPorId(listaEmprestimo[i].IdLivro);
                    leitorAtual = leitorBLL.SelecionarLeitorPorId(listaEmprestimo[i].IdLeitor);

                    dgvRelatorio[0, i].Value = livroAtual.IdLivro;
                    dgvRelatorio[1, i].Value = livroAtual.TituloLivro;
                    dgvRelatorio[2, i].Value = leitorAtual.IdLeitor;
                    dgvRelatorio[3, i].Value = leitorAtual.NomeLeitor;

                    if (listaEmprestimo[i].DataDevolucaoPrevista.CompareTo(DateTime.Now) < 0)
                        dgvRelatorio[4, i].Value = "Sim";

                    if (listaEmprestimo[i].DataDevolucaoPrevista.CompareTo(DateTime.Now) > 0)
                        dgvRelatorio[4, i].Value = "Não";
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message.ToString());
            }
        }
    }
}
