using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace apBiblioteca.UI
{
    public partial class FrmPrincipal : Form
    {
        FrmLivro frmLivro = null;
        FrmLeitor frmLeitor = null;
        FrmOperacoes frmOperacoes = null;
        FrmRelatorio frmRelatorio = null;

        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void relatórioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmRelatorio = new FrmRelatorio();
            frmRelatorio.Show();
        }

        private void livrosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmLivro = new FrmLivro();
            frmLivro.Show();
        }

        private void leitoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmLeitor = new FrmLeitor();
            frmLeitor.Show();
        }

        private void operaçõesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmOperacoes = new FrmOperacoes();
            frmOperacoes.Show();
        }

        private void sairToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {

        }
    }
}
