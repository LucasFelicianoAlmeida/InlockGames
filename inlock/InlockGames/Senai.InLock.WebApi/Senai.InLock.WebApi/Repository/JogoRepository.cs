using Senai.InLock.WebApi.Domain;
using Senai.InLock.WebApi.Interface;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace Senai.InLock.WebApi.Repository
{
    public class JogoRepository : IJogoRepository
    {
        string stringConexao = "Data Source=DESKTOP-JCJB5FC; initial catalog=InlockGames_Manhã; integrated security=true;";

        public void Atualizar(int id, JogoDomain jogoAtualizado)
        {
            using(SqlConnection con = new SqlConnection(stringConexao))
            {
                string queryUpdate = "UPDATE JOGO " +
                    "SET TituloJogo = @TITULOJOGO, Descricao = @Descricao, DataLan = @DATALAN, Valor = @VALOR, IdEstudio = @IDESTUDIO " +
                    "WHERE idJogo = @ID;";

                using(SqlCommand cmd = new SqlCommand(queryUpdate,con))
                {
                    cmd.Parameters.AddWithValue("@ID", id);
                    cmd.Parameters.AddWithValue("@TITULOJOGO", jogoAtualizado.TituloJogo);
                    cmd.Parameters.AddWithValue("@DESCRICAO", jogoAtualizado.Descricao);
                    cmd.Parameters.AddWithValue("@DATALAN", jogoAtualizado.DataLan);
                    cmd.Parameters.AddWithValue("@VALOR", jogoAtualizado.Valor);
                    cmd.Parameters.AddWithValue("@IDESTUDIO", jogoAtualizado.IdEstudio);

                    // Abre a conexão com o banco de dados
                    con.Open();

                    // Executa o comando
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public JogoDomain BuscarPorId(int id)
        {
            using(SqlConnection con = new SqlConnection(stringConexao))
            {
                string querySelectById = "SELECT idJogo, TituloJogo, Descricao, DataLan, Valor, IdEstudio FROM Jogo "
                    + "WHERE IdJogo = @ID";

                con.Open();

                SqlDataReader rdr;

                using(SqlCommand cmd = new SqlCommand(querySelectById, con))
                {
                    cmd.Parameters.AddWithValue("@ID", id);

                    rdr = cmd.ExecuteReader();

                    if(rdr.Read())
                    {
                        JogoDomain jogo = new JogoDomain
                        {
                            TituloJogo = rdr["TituloJogo"].ToString(),
                            Descricao = rdr["Descricao"].ToString(),
                            DataLan = Convert.ToDateTime(rdr["DataLan"]),
                            Valor = Convert.ToDecimal(rdr["Valor"]),
                            IdEstudio = Convert.ToInt32(rdr["idEstudio"])
                        };
                        return jogo;

                    }
                    return null;
                }

               
            }
        }

        public void Cadastrar(JogoDomain novoJogo)
        {
            using (SqlConnection con = new SqlConnection(stringConexao))
            {
                string queryAdd = "INSERT INTO Jogo (TituloJogo, Descricao, DataLan, Valor, idEstudio) VALUES (@TITULOJOGO,@DESCRICAO,@DATALAN,@VALOR,@IDESTUDIO)";


                using (SqlCommand cmd = new SqlCommand(queryAdd, con))
                {
                    cmd.Parameters.AddWithValue("@TITULOJOGO", novoJogo.TituloJogo);
                    cmd.Parameters.AddWithValue("@DESCRICAO", novoJogo.Descricao);
                    cmd.Parameters.AddWithValue("@DATALAN", novoJogo.DataLan);
                    cmd.Parameters.AddWithValue("@VALOR", novoJogo.Valor);
                    cmd.Parameters.AddWithValue("@IDESTUDIO", novoJogo.IdEstudio);

                    con.Open();

                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void Deletar(int id)
        {
                // Declara a conexão passando a string de conexão
                using (SqlConnection con = new SqlConnection(stringConexao))
                {
                    // Declara a query que será executada passando o valor como parâmetro
                    string queryDelete = "DELETE FROM Jogo WHERE idJogo = @ID";

                    // Declara o comando passando a query e a conexão
                    using (SqlCommand cmd = new SqlCommand(queryDelete, con))
                    {
                        // Passa o valor do parâmetro
                        cmd.Parameters.AddWithValue("@ID", id);

                        // Abre a conexão com o banco de dados
                        con.Open();

                        // Executa o comando
                        cmd.ExecuteNonQuery();
                    }
                }
        }

        public List<JogoDomain> Listar()
        {
            List<JogoDomain> jogos = new List<JogoDomain>();

            using (SqlConnection con = new SqlConnection(stringConexao))
            {
                string querySelectAll = "SELECT idJogo, TituloJogo, Descricao, DataLan, Valor, idEstudio FROM Jogo ";
                    

                con.Open();

                SqlDataReader rdr;

                using (SqlCommand cmd = new SqlCommand(querySelectAll, con))
                {
                    rdr = cmd.ExecuteReader();

                    while(rdr.Read())
                    {
                        JogoDomain jogo = new JogoDomain()
                        {
                            IdJogo = Convert.ToInt32(rdr["idJogo"]),
                            TituloJogo = rdr["TituloJogo"].ToString(),
                            Descricao = rdr["Descricao"].ToString(),
                            DataLan = Convert.ToDateTime(rdr["DataLan"]),
                            Valor = Convert.ToDecimal(rdr["Valor"]),
                            IdEstudio = Convert.ToInt32(rdr["idEstudio"])
      

                        };
                        jogos.Add(jogo);
                    
                    }
                }
            }
                    return jogos;
            
        }
    }
}
