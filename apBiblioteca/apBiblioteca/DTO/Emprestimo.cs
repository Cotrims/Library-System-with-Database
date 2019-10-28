using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace apBiblioteca
{
    class Emprestimo
    {

        int idEmprestimo;
        int idLivro;
        int idLeitor;
        DateTime dataEmprestimo;
        DateTime dataDevolucaoPrevista;
        DateTime dataDevolucaoReal;

        public Emprestimo(int id, int idLivro, int idLeitor, DateTime dataEmp, DateTime dataDevPre, DateTime dataDevRel)
        {
            IdEmprestimo = id;
            IdLivro = idLivro;
            IdLeitor = idLeitor;
            DataEmprestimo = dataEmp;
            DataDevolucaoPrevista = dataDevPre;
            DataDevolucaoReal = dataDevRel;
        }

        public int IdEmprestimo
        {
            get { return idEmprestimo; }
            set { idEmprestimo = value; }
        }

        public int IdLivro
        {
            get { return idLivro; }
            set { idLivro = value; }
        }

        public int IdLeitor
        {
            get { return idLeitor ; }
            set { idLeitor = value; }
        }

        public DateTime DataEmprestimo
        {
            get { return dataEmprestimo; }
            set { dataEmprestimo = value; }
        }

        public DateTime DataDevolucaoPrevista
        {
            get { return dataDevolucaoPrevista; }
            set { dataDevolucaoPrevista = value; }
        }

        public DateTime DataDevolucaoReal
        {
            get { return dataDevolucaoReal; }
            set { dataDevolucaoReal = value; }
        }
    }
}
