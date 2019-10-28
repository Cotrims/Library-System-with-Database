using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace apBiblioteca.BLL
{
    class LivroBLL
    {

        DAL.LivroDAL dal = null;

        public LivroBLL()
        {

        }

        public List<Livro> ListarLivros()
        {
            try
            {
                dal = new DAL.LivroDAL();
                return dal.SelectListLivros();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public DataTable SelecionarLivros()
        {
            DataTable dt = new DataTable();
            try
            {
                dal = new DAL.LivroDAL();
                dt = dal.SelectLivros();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return dt;
        }

        public Livro SelecionarLivroPorId(int id)
        {
            try
            {
                dal = new DAL.LivroDAL();
                return dal.SelectLivroByID(id);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public Livro SelecionarLivroPorCodigo(string codigo)
        {
            try
            {
                dal = new DAL.LivroDAL();
                return dal.SelectLivroByCodigo(codigo);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void IncluirLivro(Livro livro)
        {
            try
            {
                dal = new DAL.LivroDAL();
                dal.InsertLivro(livro);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void AlterarLivro(Livro livro)
        {
            try
            {
                dal = new DAL.LivroDAL();
                dal.UpdateLivro(livro);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void ExcluirLivro(Livro livro)
        {
            try
            {
                DAL.EmprestimoDAL dalEm = new DAL.EmprestimoDAL();

                if (dalEm.SelectEmprestimoByIdLivro(livro.IdLivro) != null)
                    throw new Exception("O livro esta emprestado, nao e possivel excluir");

                dal = new DAL.LivroDAL();
                dal.DeleteLivro(livro);

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
