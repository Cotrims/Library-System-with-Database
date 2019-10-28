using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace apBiblioteca.DAL
{
    class EmprestimoDAL
    {
        String _conexaoSQLServer = "";
        SqlConnection conexao = null;

        public EmprestimoDAL()
        {
            _conexaoSQLServer = "Data Source = regulus.cotuca.unicamp.br; Initial Catalog = BD19040; Persist Security Info = True; User ID = BD19040; Password=Cotrimpd19";
        }

        public List<Emprestimo> SelectListEmprestimo()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(_conexaoSQLServer))
                {
                    using (SqlCommand command = new SqlCommand("select * from BibEmprestimo", conn))
                    {
                        conn.Open();
                        List<Emprestimo> listaEmprestimo = new List<Emprestimo>();
                        using (SqlDataReader dr = command.ExecuteReader())
                        {
                            while (dr.Read())
                            {
                                Emprestimo emprestimo = new Emprestimo(
                                                  (int)dr["IdEmprestimo"],
                                                  (int)dr["idLivro"],
                                                  (int)dr["idLeitor"],
                                                  Convert.ToDateTime(dr["dataEmprestimo"]),
                                                  Convert.ToDateTime(dr["dataDevolucaoPrevista"]),
                                                  Convert.ToDateTime(dr["dataDevolucaoReal"])
                                    );
                                listaEmprestimo.Add(emprestimo);
                            }
                            return listaEmprestimo;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public DataTable SelectEmprestimos()
        {
            try
            {
                String sql = "Select * from BibEmprestimo";
                conexao = new SqlConnection(_conexaoSQLServer);
                SqlCommand cmd = new SqlCommand(sql, conexao);

                SqlDataAdapter da = new SqlDataAdapter();
                da.SelectCommand = cmd;
                DataTable dt = new DataTable();
                da.Fill(dt);

                return dt;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public Emprestimo SelectEmprestimoByID(int id)
        {
            try
            {
                String sql = "select * from BibEmprestimo where idEmprestimo = @id";
                conexao = new SqlConnection(_conexaoSQLServer);
                SqlCommand cmd = new SqlCommand(sql, conexao);
                cmd.Parameters.AddWithValue("@id", id);
                conexao.Open();
                SqlDataReader dr = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                Emprestimo emprestimo = null;
                if (dr.Read())
                {
                    emprestimo = new Emprestimo((int)dr["idEmprestimo"],
                                                    (int)dr["idLivro"],
                                                    (int)dr["idLeitor"],
                                                    Convert.ToDateTime(dr["dataEmprestimo"]),
                                                    Convert.ToDateTime(dr["dataDevolucaoPrevista"]),
                                                    Convert.ToDateTime(dr["dataDevolucaoReal"]));
                }

                return emprestimo;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    
        public Emprestimo SelectEmprestimoByIdLivro(int idLivro)
        {
            try
            {
                String sql = "select * from BibEmprestimo where idLivro = @idLivro";
                conexao = new SqlConnection(_conexaoSQLServer);
                SqlCommand cmd = new SqlCommand(sql, conexao);
                cmd.Parameters.AddWithValue("@idLivro", idLivro);
                conexao.Open();
                SqlDataReader dr = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                Emprestimo emprestimo = null;

                if (dr.Read())
                {
                    emprestimo = new Emprestimo((int)dr["idEmprestimo"],
                                                    (int)dr["idLivro"],
                                                    (int)dr["idLeitor"],
                                                    Convert.ToDateTime(dr["dataEmprestimo"]),
                                                    Convert.ToDateTime(dr["dataDevolucaoPrevista"]),
                                                    Convert.ToDateTime(dr["dataDevolucaoReal"]));
                }

                return emprestimo;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<Emprestimo> SelectEmprestimosByIdLeitor(int idLeitor)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(_conexaoSQLServer))
                {
                    using (SqlCommand cmd = new SqlCommand("Select * from BibEmprestimo where idLeitor = @idLeitor", conn))
                    {
                        conn.Open();
                        List<Emprestimo> listaEmprestimo = new List<Emprestimo>();
                        cmd.Parameters.AddWithValue("@idLeitor", idLeitor);
                        using (SqlDataReader dr = cmd.ExecuteReader())
                        {
                            while (dr.Read())
                            {
                                Emprestimo emprestimo = new Emprestimo((int)dr["idEmprestimo"],
                                                    (int)dr["idLivro"],
                                                    (int)dr["idLeitor"],
                                                    Convert.ToDateTime(dr["dataEmprestimo"]),
                                                    Convert.ToDateTime(dr["dataDevolucaoPrevista"]),
                                                    Convert.ToDateTime(dr["dataDevolucaoReal"]));

                                listaEmprestimo.Add(emprestimo);
                            }
                            return listaEmprestimo;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        //Inclui um novo Emprestimo
        public void InsertEmprestimo(Emprestimo qualEmprestimo)
        {
            try
            {
                String sql = "insert into BibEmprestimo " +
                             "values(@idLivro, @idLeitor, @dataEmp, @dataDevPrev, @dataDevRel)";

                conexao = new SqlConnection(_conexaoSQLServer);
                SqlCommand cmd = new SqlCommand(sql, conexao);
                cmd.Parameters.AddWithValue("@idLivro", qualEmprestimo.IdLivro);
                cmd.Parameters.AddWithValue("@idLeitor", qualEmprestimo.IdLeitor);
                cmd.Parameters.AddWithValue("@dataEmp", qualEmprestimo.DataEmprestimo);
                cmd.Parameters.AddWithValue("@dataDevPrev", qualEmprestimo.DataDevolucaoPrevista);
                cmd.Parameters.AddWithValue("@dataDevRel", qualEmprestimo.DataDevolucaoReal);
                conexao.Open();
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                conexao.Close();
            }
        }

        //Alterar Emprestimo
        public void UpdateEmprestimo(Emprestimo qualEmprestimo)
        {
            try
            {
                String sql = "update BibEmprestimo set " +
                    "idLivro = @idLivro," +
                    "idLeitor = @telefone," +
                    "dataEmprestimo = @dataEmp " +
                    "dataDevolucaoPrevista = @dataDevPrev " +
                    "dataDevolucaoReal = @dataDevRel" +
                    "where idEmprestimo = @id";

                conexao = new SqlConnection(_conexaoSQLServer);
                SqlCommand cmd = new SqlCommand(sql, conexao);
                cmd.Parameters.AddWithValue("@id", qualEmprestimo.IdEmprestimo);
                cmd.Parameters.AddWithValue("@idLivro", qualEmprestimo.IdLivro);
                cmd.Parameters.AddWithValue("@idLeitor", qualEmprestimo.IdLeitor);
                cmd.Parameters.AddWithValue("@dataEmp", qualEmprestimo.DataEmprestimo);
                cmd.Parameters.AddWithValue("@dataDevPrev", qualEmprestimo.DataDevolucaoPrevista);
                cmd.Parameters.AddWithValue("@dataDevReal", qualEmprestimo.DataDevolucaoReal);
                conexao.Open();
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                conexao.Close();
            }
        }

        //Excluir Emprestimo
        public void DeleteEmprestimo(Emprestimo qualEmprestimo)
        {
            try
            {
                String sql = "delete from BibEmprestimo " +
                             "where idEmprestimo=@id";

                conexao = new SqlConnection(_conexaoSQLServer);
                SqlCommand cmd = new SqlCommand(sql, conexao);
                cmd.Parameters.AddWithValue("@id", qualEmprestimo.IdEmprestimo);
                conexao.Open();
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                conexao.Close();
            }
        }
    }
}
