using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace apBiblioteca.DAL
{
    class LivroDAL
    {
        String _conexaoSQLServer = "";
        SqlConnection conexao = null;


        public LivroDAL()
        {
            _conexaoSQLServer = "Data Source = regulus.cotuca.unicamp.br; Initial Catalog = BD19040; Persist Security Info = True; User ID = BD19040; Password=Cotrimpd19";
        }

        /* Retorna uma Lista de Livros, ou seja, um objeto da 
           classe List<Livro> com os livros selecionados
        */
        public List<Livro> SelectListLivros()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(_conexaoSQLServer))
                {
                    using (SqlCommand command = new SqlCommand("select * from BibLivro", conn))
                    {
                        conn.Open();
                        List<Livro> listaLivros = new List<Livro>();
                        using (SqlDataReader dr = command.ExecuteReader())
                        {
                            while (dr.Read())
                            {
                                Livro livro = new Livro(
                                                  (int)dr["idLivro"],
                                                  dr["codigoLivro"] + "",
                                                  dr["tituloLivro"] + "",
                                                  dr["autorLivro"] + ""
                                    );
                                listaLivros.Add(livro);
                            }
                            return listaLivros;
                        }
                    }
                }    
            }
            catch(Exception ex)
            {
                throw ex;
            }           
        }

        //Retorna uma lista de livros 
        public DataTable SelectLivros()
        {
            try {

                String sql = "select * from BibLivro";
                conexao = new SqlConnection(_conexaoSQLServer);
                SqlCommand cmd = new SqlCommand(sql, conexao);
                
                SqlDataAdapter da = new SqlDataAdapter();
                da.SelectCommand = cmd;
                DataTable dt = new DataTable();
                da.Fill(dt);

                return dt ;
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

        //Retorna um Livro selecionado pelo idLivro
        public Livro SelectLivroByID(int id)
        {
            try
            {
                String sql = "select * from BibLivro where idLivro = @id";
                conexao = new SqlConnection(_conexaoSQLServer);
                SqlCommand cmd = new SqlCommand(sql, conexao);
                cmd.Parameters.AddWithValue("@id", id);
                conexao.Open();
                SqlDataReader dr;
                dr = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                Livro livro = null;
                if (dr.Read())
                {
                    livro = new Livro(Convert.ToInt32(dr["idLivro"]),
                                       dr["codigoLivro"].ToString(),
                                       dr["tituloLivro"].ToString(),
                                       dr["autorLivro"].ToString()
                                       );
                }

                return livro;
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

        //Retorna um livro pelo codigo
        public Livro SelectLivroByCodigo(string codigo)
        {
            try
            {
                String sql = "select * from BibLivro where codigoLivro = @codigo";
                conexao = new SqlConnection(_conexaoSQLServer);
                SqlCommand cmd = new SqlCommand(sql, conexao);
                cmd.Parameters.AddWithValue("@codigo", codigo);
                conexao.Open();
                SqlDataReader dr = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                Livro livro = null;
                if (dr.Read())
                {
                    livro = new Livro(Convert.ToInt32(dr["idLivro"]),
                                       dr["codigoLivro"].ToString(),
                                       dr["tituloLivro"].ToString(),
                                       dr["autorLivro"].ToString()
                                       );
                }

                return livro;
            }
            catch (Exception ex)
            {
                throw ex;
            }            
        }
        
        //Inclui um novo livro
        public void InsertLivro(Livro qualLivro)
        {
            try
            {
                String sql = "insert into BibLivro " +
                             "values(@codigo, @titulo, @autor)";

                conexao = new SqlConnection(_conexaoSQLServer);
                SqlCommand cmd = new SqlCommand(sql, conexao);
                cmd.Parameters.AddWithValue("@codigo", qualLivro.CodigoLivro);
                cmd.Parameters.AddWithValue("@titulo", qualLivro.TituloLivro);
                cmd.Parameters.AddWithValue("@autor", qualLivro.AutorLivro);
                conexao.Open();
                cmd.ExecuteNonQuery();
            }
            catch(Exception ex)
            {
                throw ex;
            }
            finally
            {
                conexao.Close();
            }
        }

        //Alterar livro
        public void UpdateLivro(Livro qualLivro)
        {
            try
            {
                String sql = "update BibLivro set " +
                    "codigoLivro = @codigo," +
                    "tituloLivro = @titulo," +
                    "autorLivro = @autor " +
                    "where idLivro = @id";

                conexao = new SqlConnection(_conexaoSQLServer);
                SqlCommand cmd = new SqlCommand(sql, conexao);
                cmd.Parameters.AddWithValue("@id", qualLivro.IdLivro);
                cmd.Parameters.AddWithValue("@codigo", qualLivro.CodigoLivro);
                cmd.Parameters.AddWithValue("@titulo", qualLivro.TituloLivro);
                cmd.Parameters.AddWithValue("@autor", qualLivro.AutorLivro);
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

        //Excluir livro
        public void DeleteLivro (Livro qualLivro)
        {
            try
            {
                String sql = "delete from BibLivro " +
                             "where idLivro=@id";
                             
                conexao = new SqlConnection(_conexaoSQLServer);
                SqlCommand cmd = new SqlCommand(sql, conexao);
                cmd.Parameters.AddWithValue("@id", qualLivro.IdLivro);
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
