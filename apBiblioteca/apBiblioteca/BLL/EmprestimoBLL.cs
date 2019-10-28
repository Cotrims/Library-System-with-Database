using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace apBiblioteca.BLL
{
    class EmprestimoBLL
    {

        DAL.EmprestimoDAL dal = null;

        public EmprestimoBLL()
        {

        }

        public List<Emprestimo> ListarEmprestimos()
        {
            try
            {
                dal = new DAL.EmprestimoDAL();
                return dal.SelectListEmprestimo();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public DataTable SelecionarEmprestimos()
        {
            DataTable dt = new DataTable();
            try
            {
                dal = new DAL.EmprestimoDAL();
                dt = dal.SelectEmprestimos();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return dt;
        }

        public Emprestimo SelecionarEmprestimoPorId(int id)
        {
            try
            {
                dal = new DAL.EmprestimoDAL();
                return dal.SelectEmprestimoByID(id);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public Emprestimo SelecionarEmprestimoPorIdLivro(int idLivro)
        {
            try
            {
                dal = new DAL.EmprestimoDAL();
                return dal.SelectEmprestimoByIdLivro(idLivro);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<Emprestimo> SelecionarEmprestimoPorIdLeitor(int idLeitor)
        {
            try
            {
                dal = new DAL.EmprestimoDAL();
                return dal.SelectEmprestimosByIdLeitor(idLeitor);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void IncluirEmprestimo(Emprestimo emprestimo)
        {
            try
            {
                DAL.LeitorDAL dalLe = new DAL.LeitorDAL();
                DAL.LivroDAL dalLi = new DAL.LivroDAL();
                dal = new DAL.EmprestimoDAL();

                if (dal.SelectEmprestimoByIdLivro(emprestimo.IdLivro) != null)
                    throw new Exception("Livro emprestado, emprestimo cancelado");

                if (dal.SelectEmprestimosByIdLeitor(emprestimo.IdLeitor).Count >= 5)
                    throw new Exception("Leitor ja atingiu o limite de livros, emprestimo cancelado");

                dal.InsertEmprestimo(emprestimo);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void AlterarEmprestimo(Emprestimo emprestimo)
        {
            try
            {
                dal = new DAL.EmprestimoDAL();
                dal.UpdateEmprestimo(emprestimo);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void ExcluirEmprestimo(Emprestimo emprestimo)
        {
            try
            {
                dal = new DAL.EmprestimoDAL();

                if (emprestimo.DataDevolucaoReal.CompareTo(DateTime.Now) > 0)
                    throw new Exception("Impossivel excluir emprestimo, livro nao devolvido!");

                dal.DeleteEmprestimo(emprestimo);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
