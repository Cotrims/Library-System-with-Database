using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace apBiblioteca.DAL
{
    class LeitorDAL
    {
        String _conexaoSQLServer = "";
        SqlConnection conexao = null;

        public LeitorDAL()
        {
            _conexaoSQLServer = "Data Source = regulus.cotuca.unicamp.br; Initial Catalog = BD19040; Persist Security Info = True; User ID = BD19040; Password=Cotrimpd19";
        }

        public List<Leitor> SelectListLeitor()
        {
            try
            {
                using(SqlConnection conn = new SqlConnection(_conexaoSQLServer))
                {
                    using(SqlCommand cmd = new SqlCommand("Select * from BibLeitor", conn))
                    {
                        conn.Open();
                        List<Leitor> listaLeitor = new List<Leitor>();
                        using(SqlDataReader dr = cmd.ExecuteReader())
                        {
                            while(dr.Read())
                            {
                                Leitor leitor = new Leitor((int)dr["idLeitor"],
                                                    dr["nomeLeitor"] + "",
                                                    dr["telefoneLeitor"] + "",
                                                    dr["emailLeitor"] + "",
                                                    dr["enderecoLeitor"] + "");

                                listaLeitor.Add(leitor);
                            }
                            return listaLeitor;
                        }
                    }
                }
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

        public DataTable SelectLeitores()
        {
            try
            {
                String sql = "Select * from BibLeitor";
                conexao = new SqlConnection(_conexaoSQLServer);
                SqlCommand cmd = new SqlCommand(sql, conexao);

                SqlDataAdapter da = new SqlDataAdapter();
                da.SelectCommand = cmd;
                DataTable dt = new DataTable();
                da.Fill(dt);

                return dt;
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

        public Leitor SelectLeitorByID(int id)
        {
            try
            {
                String sql = "select * from BibLeitor where idLeitor = @id";
                conexao = new SqlConnection(_conexaoSQLServer);
                SqlCommand cmd = new SqlCommand(sql, conexao);
                cmd.Parameters.AddWithValue("@id", id);
                conexao.Open();
                SqlDataReader dr = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                Leitor leitor = null;
                if (dr.Read())
                {
                    leitor = new Leitor((int)dr["idLeitor"],
                                                    dr["nomeLeitor"] + "",
                                                    dr["telefoneLeitor"] + "",
                                                    dr["emailLeitor"] + "",
                                                    dr["enderecoLeitor"] + "");
                }

                return leitor;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        //Retorna um Leitor pelo nome
        public Leitor SelectLeitorByNome(string nome)
        {
            try
            {
                String sql = "select * from BibLeitor where nomeLeitor = @nome";
                conexao = new SqlConnection(_conexaoSQLServer);
                SqlCommand cmd = new SqlCommand(sql, conexao);
                cmd.Parameters.AddWithValue("@nome", nome);
                conexao.Open();
                SqlDataReader dr = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                Leitor leitor = null;
                if (dr.Read())
                {
                    leitor = new Leitor((int)dr["idLeitor"],
                                                    dr["nomeLeitor"] + "",
                                                    dr["telefoneLeitor"] + "",
                                                    dr["emailLeitor"] + "",
                                                    dr["enderecoLeitor"] + "");
                }

                return leitor;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        //Inclui um novo Leitor
        public void InsertLeitor(Leitor qualLeitor)
        {
            try
            {
                String sql = "insert into BibLeitor " +
                             "values(@nome, @telefone, @email, @endereco)";

                conexao = new SqlConnection(_conexaoSQLServer);
                SqlCommand cmd = new SqlCommand(sql, conexao);
                cmd.Parameters.AddWithValue("@nome", qualLeitor.NomeLeitor);
                cmd.Parameters.AddWithValue("@telefone", qualLeitor.TelefoneLeitor);
                cmd.Parameters.AddWithValue("@email", qualLeitor.EmailLeitor);
                cmd.Parameters.AddWithValue("@endereco", qualLeitor.EnderecoLeitor);
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

        //Alterar Leitor
        public void UpdateLeitor(Leitor qualLeitor)
        {
            try
            {
                String sql = "update BibLeitor set " +
                    "nomeLeitor = @nome," +
                    "telefoneLeitor = @telefone," +
                    "emailLeitor = @email, " +
                    "enderecoLeitor = @endereco " +
                    "where IdLeitor = @id";

                conexao = new SqlConnection(_conexaoSQLServer);
                SqlCommand cmd = new SqlCommand(sql, conexao);
                cmd.Parameters.AddWithValue("@nome", qualLeitor.NomeLeitor.Trim());
                cmd.Parameters.AddWithValue("@telefone", qualLeitor.TelefoneLeitor);
                cmd.Parameters.AddWithValue("@email", qualLeitor.EmailLeitor);
                cmd.Parameters.AddWithValue("@endereco", qualLeitor.EnderecoLeitor);
                cmd.Parameters.AddWithValue("@id", qualLeitor.IdLeitor);
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

        //Excluir Leitor
        public void DeleteLeitor(Leitor qualLeitor)
        {
            try
            {
                String sql = "delete from BibLeitor " +
                             "where idLeitor=@id";

                conexao = new SqlConnection(_conexaoSQLServer);
                SqlCommand cmd = new SqlCommand(sql, conexao);
                cmd.Parameters.AddWithValue("@id", qualLeitor.IdLeitor);
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
