using CalledManagement.Entities;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalledManagement.DAO
{
    class CalledDAO
    {

        public bool Insert(Called called)
        {
            //string strConn = @"server=TI-NET-PC\SQLEXPRESS; DataBase=academycoding2; Trusted_Connection = True";

            //SqlConnection conn = new SqlConnection(strConn);

            //sql = sql + ;

            // Variavel sql que armazena código SQL para inserir o registro

            //using (FbConnection conn = new FbConnection(conStr))
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "insert into CALLED (Name, Date, Descripition, Status) values (@Name, @Date, @Descripition, @Status)";
            // Cria objeto conn da classe FbConnection passando por parâmetro a string de conexão chamada conStr
            {
                try // Verifica se a operação com o banco irá ocorre irá ocorresem erros
                {
                    //SqlCommand cmd = new SqlCommand(strConn);

                    //conn.Open(); // Abre a conexão com o banco de dados.

                    ToConnection toconnection = new ToConnection();

                    //string query = "select * from dbo.alunos";
                    // Cria objeto cmd da classe FbCommand passando os comandos SQL e a conexão com o Banco de Dados
                    // Esse objeto é responsável em executar os comandos SQL
                    cmd.Parameters.AddWithValue("@Name", called.Name);
                    cmd.Parameters.AddWithValue("@Date", called.Date);
                    cmd.Parameters.AddWithValue("@Descripition", called.Descripition);
                    cmd.Parameters.AddWithValue("@Status", called.Status);

                    cmd.Connection = toconnection.ToConnect();
                    // O objetro cmd recebe os parâmetros com os valores dos campos Ex.: @nome, @logradouro, @numero, etc.
                    cmd.ExecuteNonQuery();
                    // Retorna o comando SQL de INSERT no banco de dados. (Sem Retorno de dados)
                    return true;
                    // Retorna true (verdadeiro) caso a inserção do registro seja realizado corretamente.
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao salvar registro: " + ex.Message);
                    return false;
                    // Caso ocorrra algum erro nos comandos abaixo do try será executado o catch(), disparado uma mensagem de erro para
                    // Informando "Erro ao salvar registro" + o erro recebido do banco de dados
                }
                finally
                {
                    MessageBox.Show("Cadastro salvo com sucesso!");
                    ToConnection toconection = new ToConnection();
                    toconection.ToDisconnect();
                    // O finally é sempre executado,
                    // fechando a conexão com o banco de dados.
                }
            }
        }

        public bool Change(Called called)
        {
            //string strConn = @"server=TI-NET-PC\SQLEXPRESS; DataBase=academycoding2; Trusted_Connection = True";

            //SqlConnection conn = new SqlConnection(strConn);

            //sql = sql + ;

            // Variavel sql que armazena código SQL para inserir o registro

            //using (FbConnection conn = new FbConnection(conStr))
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "update CALLED set Name = @Name, Date = @Date, Descripition = @Descripition, Status = @Status  where Id = @Id";
            // Cria objeto conn da classe FbConnection passando por parâmetro a string de conexão chamada conStr
            {
                try // Verifica se a operação com o banco irá ocorre irá ocorresem erros
                {
                    //SqlCommand cmd = new SqlCommand(strConn);

                    //conn.Open(); // Abre a conexão com o banco de dados.

                    ToConnection toconnection = new ToConnection();
                    toconnection.ToConnect();

                    //string query = "select * from dbo.alunos";
                    // Cria objeto cmd da classe FbCommand passando os comandos SQL e a conexão com o Banco de Dados
                    // Esse objeto é responsável em executar os comandos SQL
                    cmd.Parameters.AddWithValue("@Id", called.Id);
                    cmd.Parameters.AddWithValue("@Name", called.Name);
                    cmd.Parameters.AddWithValue("@Date", called.Date);
                    cmd.Parameters.AddWithValue("@Descripition", called.Descripition);
                    cmd.Parameters.AddWithValue("@Status", called.Status);

                    cmd.Connection = toconnection.ToConnect();
                    // O objetro cmd recebe os parâmetros com os valores dos campos Ex.: @nome, @logradouro, @numero, etc.
                    cmd.ExecuteNonQuery();
                    // Retorna o comando SQL de INSERT no banco de dados. (Sem Retorno de dados)
                    return true;
                    // Retorna true (verdadeiro) caso a inserção do registro seja realizado corretamente.
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao salvar registro: " + ex.Message);
                    return false;
                    // Caso ocorrra algum erro nos comandos abaixo do try será executado o catch(), disparado uma mensagem de erro para
                    // Informando "Erro ao salvar registro" + o erro recebido do banco de dados
                }
                finally
                {
                    MessageBox.Show("Cadastro alterado com sucesso!");
                    ToConnection toconection = new ToConnection();
                    toconection.ToDisconnect();
                    // O finally é sempre executado,
                    // fechando a conexão com o banco de dados.
                }
            }
        }

        public bool Delete(int ID)
        {
            {
                try
                {
                    //abre conexão
                    SqlCommand cmd = new SqlCommand();
                    ToConnection toconnection = new ToConnection();
                    cmd.Connection = toconnection.ToConnect();

                    cmd.CommandText = "delete from CALLED where Id = @Id";

                    cmd.Parameters.AddWithValue("@Id", ID);

                    cmd.ExecuteNonQuery();

                    return true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao exluir registro: " + ex.Message);
                    return false;
                }
                finally
                {
                    MessageBox.Show("Cadastro Excluido com sucesso!");
                    ToConnection toconection = new ToConnection();
                    toconection.ToDisconnect();
                }
            }
        }
        public Called SearchID(int ID)
        {
            Called called = new Called();
            SqlCommand cmd = new SqlCommand();

            {
                //conn.Open();
                ToConnection toconnection = new ToConnection();
                toconnection.ToConnect();

                cmd.CommandText = "SELECT Id, Name, Date, Status, Descripition FROM CALLED WHERE Id = '@ID'";
                cmd.Parameters.AddWithValue("@Id", ID);
                SqlDataReader reader = cmd.ExecuteReader();

                //percorre todas as linhas de DataReader
                while (reader.Read())
                {
                    //recuperar os campos
                    called.Id = int.Parse(reader["Id"].ToString());
                    called.Name = reader["Name"].ToString();
                    called.Date = Convert.ToDateTime(reader["Date"].ToString());
                    called.Status = reader["Status"].ToString();
                    called.Descripition = reader["Descripition"].ToString();
                }
                //conn.Close();
                ToConnection toconection = new ToConnection();
                toconection.ToDisconnect();
            }
            return called;
        }

        public List<Called> SearchName(string nome)
        {
            List<Called> lista = new List<Called>();


            SqlCommand cmd = new SqlCommand();

            {
                //conn.Open();
                ToConnection toconnection = new ToConnection();
                toconnection.ToConnect();
                cmd.CommandText = "SELECT Id, Name, Date, Status, Descripition FROM CALLED WHERE Name LIKE '@Name' ORDER BY Name";
                cmd.Parameters.AddWithValue("@Name", "%" + nome + "%");
                SqlDataReader reader = cmd.ExecuteReader();

                //percorre todas as linhas do DataReader
                while (reader.Read())
                {
                    //Recupera Campos
                    Called called = new Called();
                    called.Id = int.Parse(reader["Id"].ToString());
                    called.Name = reader["Name"].ToString();
                    called.Date = Convert.ToDateTime(reader["Date"].ToString());
                    called.Status = reader["Status"].ToString();
                    called.Descripition = reader["Descripition"].ToString();

                    lista.Add(called);
                }
            }
            return lista;

        }
        /*
            public DataSet SearchReport(string nomeinicial, string nomefinal)
            {
                DataSet ds = new DataSet("Cliente");
                SqlDataAdapter da = new SqlDataAdapter();

                SqlCommand cmd = new SqlCommand();
                {
                    ToConnection toconnection = new ToConnection();
                    toconnection.ToConnect();

                    StringBuilder sql = new StringBuilder();

                    sql.Append("SELECT ID, NOME ,LOGRADOURO, NUMERO FROM CLIENTE ");
                    sql.Append("WHERE NOME BETWEEN @NOMEINI AND @NOMEFIM ");
                    conn.Open();
                    SqlCommand cmd = new SqlCommand(sql.ToString());
                    cmd.Parameters.AddWithValue("@NOMEINI", nomeinicial);
                    cmd.Parameters.AddWithValue("@NOMEFIM", nomefinal);

                    da.SelectCommand = cmd;
                    da.Fill(ds);
                    conn.Close();
                }
                return ds;

            }*/
    }
}

