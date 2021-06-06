using CalledManagement.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;

namespace CalledManagement.DAO
{
    //Classe responsavel pela comunicação da entidade Called com o banco de dados 
    class CalledDAO
    {
        public bool Insert(Called called, DataGridView dgvSecCalled)
        {
            //string strConn = @"server=TI-NET-PC\SQLEXPRESS; DataBase=academycoding2; Trusted_Connection = True";

            //SqlConnection conn = new SqlConnection(strConn);


            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "insert into CALLED (Name, Date, Descripition, Finished, PriorityId) values (@Name, @Date, @Descripition, @Finished, @PriorityId)";

            {
                try // Verifica se a operação com o banco irá ocorre irá ocorresem erros
                {
                    //SqlCommand cmd = new SqlCommand(strConn);

                    //conn.Open(); 

                    ToConnection toconnection = new ToConnection();
                    // Abre a conexão com o banco de dados.
                    toconnection.ToConnect();

                    // Esse objeto é responsável em executar os comandos SQL
                    cmd.Parameters.AddWithValue("@Name", called.Name);
                    cmd.Parameters.AddWithValue("@Date", called.Date);
                    cmd.Parameters.AddWithValue("@Descripition", called.Descripition);
                    cmd.Parameters.AddWithValue("@Finished", called.Finished);
                    cmd.Parameters.AddWithValue("@PriorityId", called.PriorityId.Id);

                    cmd.Connection = toconnection.ToConnect();

                    // Retorna o comando SQL de INSERT no banco de dados. 
                    cmd.ExecuteNonQuery();

                    //teste...
                    MessageBox.Show("Cadastro salvo com sucesso!");
                    dgvSecCalled.Refresh();
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
                // O finally é sempre executado,
                finally
                {
                    ToConnection toconection = new ToConnection();
                    // fechando a conexão com o banco de dados.
                    toconection.ToDisconnect();
                }
            }
        }

        public bool Change(Called called)
        {
            //string strConn = @"server=TI-NET-PC\SQLEXPRESS; DataBase=academycoding2; Trusted_Connection = True";

            //SqlConnection conn = new SqlConnection(strConn);

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "update CALLED set Name = @Name, Date = @Date, Descripition = @Descripition, Finished = @Finished, PriorityId = @PriorityId where Id = @Id";
            {
                try // Verifica se a operação com o banco irá ocorre irá ocorresem erros
                {
                    //SqlCommand cmd = new SqlCommand(strConn);

                    //conn.Open(); 

                    ToConnection toconnection = new ToConnection();
                    // Abre a conexão com o banco de dados.
                    toconnection.ToConnect();

                    // Esse objeto é responsável em executar os comandos SQL

                    cmd.Parameters.AddWithValue("@Id", called.Id);
                    cmd.Parameters.AddWithValue("@Name", called.Name);
                    cmd.Parameters.AddWithValue("@Date", called.Date);
                    cmd.Parameters.AddWithValue("@Descripition", called.Descripition);
                    cmd.Parameters.AddWithValue("@Finished", called.Finished);
                    cmd.Parameters.AddWithValue("@PriorityId", called.PriorityId.Id);

                    // O objetro cmd recebe os parâmetros com os valores dos campos 
                    cmd.Connection = toconnection.ToConnect();

                    cmd.ExecuteNonQuery();
                    // Retorna o comando SQL de INSERT no banco de dados
                    //teste
                    MessageBox.Show("Cadastro alterado com sucesso!");
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
                    ToConnection toconection = new ToConnection();// fechando a conexão com o banco de dados.
                    toconection.ToDisconnect();// O finally é sempre executado,
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

                    MessageBox.Show("Cadastro Excluido com sucesso!");

                    return true;

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao exluir registro: " + ex.Message);
                    return false;
                }
                finally
                {
                    ToConnection toconection = new ToConnection();
                    toconection.ToDisconnect();
                }
            }
        }

        public void ListarGrid(DataGridView dgvSecCalled, string name)
        {
            var connectionString = ConfigurationManager.ConnectionStrings["CalledManagement.Properties.Settings.academycoding2ConnectionString"].ConnectionString;

            string listQuery = "SELECT c.Id, c.Name, c.Date, c.Finished, c.Descripition,c.PriorityId, p.Name, p.Days, " +
               "SUM(DATEDIFF(minute, DateStarted, EndDate)) " +
               "FROM CALLED c " +
               "INNER JOIN PRIORITY p " +
               "ON c.PriorityId = p.Id " +
               "LEFT JOIN HOURWORKED h ON " +
               "c.Id = h.CalledId " +
               "group BY c.Id, c.Name, c.Date, c.Finished, " +
               "c.Descripition, c.PriorityId, p.Name, p.Days " +
               "ORDER BY c.Finished, c.Date DESC, c.PriorityId DESC ";

            using (var connection = new SqlConnection(connectionString))
            {
                connection.Open();

                try
                {
                    //SqlCommand cmd = new SqlCommand(listQuery);
                    var cmd = new SqlCommand(listQuery, connection);

                    // Pesquisa por nome Nome
                    if (name.Length > 0)
                    {
                        cmd.CommandText = "" +
                           "SELECT c.Id, c.Name, c.Date, c.Finished, c.Descripition,c.PriorityId, p.Name, p.Days, " +
                           "SUM(DATEDIFF(minute, DateStarted, EndDate)) " +
                           "FROM CALLED c " +
                           "INNER JOIN PRIORITY p " +
                           "ON c.PriorityId = p.Id " +
                           "LEFT JOIN HOURWORKED h ON " +
                           "c.Id = h.CalledId " +
                           "WHERE c.Name LIKE @Name " +
                           "group BY c.Id, c.Name, c.Date, c.Finished, " +
                           "c.Descripition, c.PriorityId, p.Name, p.Days " +
                           "ORDER BY c.Finished, c.Date DESC, c.PriorityId DESC ";

                        cmd.Parameters.AddWithValue("@Name", "%" + name + "%");

                        cmd.ExecuteNonQuery();
                    }

                    SqlDataReader rd = cmd.ExecuteReader();
                    DataTable dt = new DataTable();
                    dt.Load(rd);
                    dgvSecCalled.DataSource = dt;
                }

                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao Listas registros: " + ex.Message);
                }
                finally
                {
                    connection.Close();
                }
            }
        }
        public void ListarComboBox(ComboBox cbxSec)
        {
            SqlCommand cmd = new SqlCommand();
            ToConnection toconnection = new ToConnection();

            try
            {
                cmd.Connection = toconnection.ToConnect();
                cmd.CommandText = "SELECT Name, Id FROM CALLED ORDER BY Date ASC";

                SqlDataReader adp = cmd.ExecuteReader();
                DataTable dt = new DataTable();

                dt.Load(adp);
                cbxSec.Text = "Selecione um chamado";
                cbxSec.DisplayMember = "Name";
                cbxSec.ValueMember = "Id";
                cbxSec.DataSource = dt;
            }

            catch (Exception ex)
            {
                MessageBox.Show("Erro ao Listas registros: " + ex.Message);
            }
            finally
            {
                ToConnection toconection = new ToConnection();
                toconection.ToDisconnect();
            }
        }
        public void ListarComBoxID(ComboBox cbxRegID)
        {
            SqlCommand cmd = new SqlCommand();
            ToConnection toconnection = new ToConnection();

            try
            {
                cmd.Connection = toconnection.ToConnect();
                cmd.CommandText = "SELECT Id FROM CALLED ORDER BY Id ASC";

                SqlDataReader adp = cmd.ExecuteReader();
                DataTable dt = new DataTable();

                dt.Load(adp);
                cbxRegID.Text = "Selecione um id";
                cbxRegID.DisplayMember = "Id";
                cbxRegID.ValueMember = "Id";
                cbxRegID.DataSource = dt;
            }

            catch (Exception ex)
            {
                MessageBox.Show("Erro ao Listas registros: " + ex.Message);
            }

            finally
            {
                ToConnection toconection = new ToConnection();
                toconection.ToDisconnect();
            }
        }

        public Called SearchID(int ID)
        {
            Called called = new Called();
            Priority priority = new Priority();
            called.PriorityId = priority;

            SqlCommand cmd = new SqlCommand();
            ToConnection toconnection = new ToConnection();

            cmd.Connection = toconnection.ToConnect();
            cmd.CommandText = "SELECT Id, Name, Date, Finished, Descripition, PriorityId FROM CALLED WHERE Id LIKE @Id";
            cmd.Parameters.AddWithValue("@Id", ID);
            cmd.Connection = toconnection.ToConnect();
            SqlDataReader reader = cmd.ExecuteReader();

            //percorre todas as linhas de DataReader
            while (reader.Read())
            {
                //recuperar os campos
                called.Id = int.Parse(reader["Id"].ToString());
                called.Name = reader["Name"].ToString();
                called.Date = Convert.ToDateTime(reader["Date"].ToString());
                called.Finished = reader["Finished"].ToString();
                called.Descripition = reader["Descripition"].ToString();
                called.PriorityId.Id = int.Parse(reader["PriorityId"].ToString());
            }

            return called;
        }
    }
}


