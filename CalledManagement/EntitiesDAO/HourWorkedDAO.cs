using CalledManagement.EntitiesDAO;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalledManagement.EntitiesDAO
{
    //Classe responsavel pela comunicação da entidade HourWorked com o banco de dados 
    class HourWorkedDAO
    {
        public bool Insert(HourWorked hourworked)
        {
            var connectionString = ConfigurationManager.ConnectionStrings["CalledManagement.Properties.Settings.academycoding2ConnectionString"].ConnectionString;
            var qry = "INSERT INTO HOURWORKED (CalledId, DateInserted, DateStarted, EndDate ) VALUES (@CalledId, @DateInserted, @DateStarted, @EndDate )";

            using (var connection = new SqlConnection(connectionString))
            {
                try // Verifica se a operação com o banco irá ocorre irá ocorresem erros
                {
                    //abre conexao
                    connection.Open();
                    // Cria objeto cmd da classe SqlCommand passando os comandos SQL e a conexão com o Banco de Dados
                    var cmd = new SqlCommand(qry, connection);

                    // O objetro cmd recebe os parâmetros com os valores dos campos
                    cmd.Parameters.AddWithValue("@CalledId", hourworked.CalledId.Id);
                    cmd.Parameters.AddWithValue("@DateInserted", hourworked.DateInserted);
                    cmd.Parameters.AddWithValue("@DateStarted", hourworked.DateStarted);
                    cmd.Parameters.AddWithValue("@EndDate", hourworked.EndDate);

                    // Retorna o comando SQL de INSERT no banco de dados. 
                    cmd.ExecuteNonQuery();

                    //teste...
                    MessageBox.Show("Cadastro salvo com sucesso!");

                    return true;
                    // Retorna true (verdadeiro) caso a inserção do registro seja realizado corretamente.
                }
                catch (Exception ex)
                {
                    // Caso ocorrra algum erro nos comandos abaixo do try será executado o catch(), disparado uma mensagem de erro para
                    MessageBox.Show("Erro ao salvar registro: " + ex.Message);
                    return false;
                }
                // O finally é sempre executado,
                finally
                {
                    // fechando a conexão com o banco de dados.
                    connection.Close();
                }
            }
        }
        public bool Change(HourWorked hourworked)
        {
            var connectionString = ConfigurationManager.ConnectionStrings["CalledManagement.Properties.Settings.academycoding2ConnectionString"].ConnectionString;
            string qry = "UPDATE HOURWORKED set CalledId = @CalledId, DateStarted = @DateStarted, EndDate = @EndDate, DateChange = @DateChange where Id = @Id";
            
            using (var connection = new SqlConnection(connectionString))
            {
                try // Verifica se a operação com o banco irá ocorre irá ocorresem erros
                {
                    //Abre a conexão com o banco de dados.
                    connection.Open();
                    // Cria objeto cmd da classe SqlCommand passando os comandos SQL e a conexão com o Banco de Dados
                    var cmd = new SqlCommand(qry, connection);

                    // Esse objeto é responsável em executar os comandos SQL
                    cmd.Parameters.AddWithValue("@Id", hourworked.Id);
                    cmd.Parameters.AddWithValue("@CalledId", hourworked.CalledId.Id);
                    cmd.Parameters.AddWithValue("@DateStarted", hourworked.DateStarted);
                    cmd.Parameters.AddWithValue("@EndDate", hourworked.EndDate);
                    cmd.Parameters.AddWithValue("@DateChange", hourworked.DateChange);

                    // O objetro cmd recebe os parâmetros com os valores dos campos Ex.: @nome, @logradouro, @numero, etc.
                    cmd.ExecuteNonQuery();

                    //teste
                    MessageBox.Show("Cadastro alterado com sucesso!");

                    // Retorna o comando SQL de INSERT no banco de dados. (Sem Retorno de dados)
                    return true;
                    // Retorna true (verdadeiro) caso a inserção do registro seja realizado corretamente.
                }
                catch (Exception ex)
                {
                    // Caso ocorrra algum erro nos comandos abaixo do try será executado o catch(), disparado uma mensagem de erro
                    MessageBox.Show("Erro ao salvar registro: " + ex.Message);
                    return false;
                }
                // O finally é sempre executado
                finally
                {
                    // fechando a conexão com o banco de dados.
                    connection.Close();
                }
            }
        }
        public bool Delete(int ID)
        {
            var connectionString = ConfigurationManager.ConnectionStrings["CalledManagement.Properties.Settings.academycoding2ConnectionString"].ConnectionString;
            string qry = "delete from HOURWORKED where calledId = @Id";
            using (var connection = new SqlConnection(connectionString))
            {
                try
                {
                    //abre conexão
                    connection.Open();
                    // Cria objeto cmd da classe SqlCommand passando os comandos SQL e a conexão com o Banco de Dados
                    var cmd = new SqlCommand(qry, connection);
                    // Esse objeto é responsável em executar os comandos SQL
                    cmd.Parameters.AddWithValue("@Id", ID);
                    cmd.ExecuteNonQuery();
                    //teste
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
                    connection.Close();
                }
            }
        }
        public void ListarGrid(DataGridView dgvSecHours, string name)
        {
            var connectionString = ConfigurationManager.ConnectionStrings["CalledManagement.Properties.Settings.academycoding2ConnectionString"].ConnectionString;
            //var qry = ""+
            #region
            string QrySelect = "SELECT H.Id, H.CalledId, C.Name, H.DateInserted, H.DateStarted, H.EndDate, H.DateChange ";
            string QryFrom = "FROM HOURWORKED AS H ";
            string QryJoin = "INNER JOIN CALLED AS C ";
            string QryOn = "ON H.CalledId = C.Id ";
            string QryOrderBy=  "ORDER BY H.DateInserted DESC ";
            string qryLike = "WHERE C.Name LIKE @Name ";
            #endregion

            StringBuilder qry = new StringBuilder();

            qry.Append(QrySelect);
            qry.Append(QryFrom);
            qry.Append(QryJoin);
            qry.Append(QryOn);
            qry.Append(QryOrderBy);

            using (var connection = new SqlConnection(connectionString))
            {
                try
                {
                    //Abre conexão
                    connection.Open();
                    // Cria objeto cmd da classe SqlCommand passando os comandos SQL e a conexão com o Banco de Dados

                    var cmd = new SqlCommand(qry.ToString(), connection);

                    //Busca por nome
                    if (name.Length > 0)
                    {
                       /* qry.Append(QrySelect);
                        qry.Append(QryFrom);
                        qry.Append(QryJoin);
                        qry.Append(QryOn);
                        qry.Append(qryLike);
                        qry.Append(QryOrderBy);*/

                        cmd.CommandText = ""+ 
                        
                        #region
                        "SELECT H.Id, H.CalledId, C.Name, H.DateInserted, H.DateStarted, H.EndDate, H.DateChange " +
                        "FROM HOURWORKED AS H " +
                        "INNER JOIN CALLED AS C " +
                        "ON H.CalledId = C.Id " +
                        "WHERE C.Name LIKE @Name " +
                        "ORDER BY H.DateInserted DESC " +
                        "";
                        #endregion
                        
                        cmd.Parameters.AddWithValue("@Name", "%" +name+ "%");
                        cmd.ExecuteNonQuery();
                    }

                    SqlDataReader rd = cmd.ExecuteReader();
                    DataTable dt = new DataTable();
                    dt.Load(rd);
                    dgvSecHours.DataSource = dt;
                }

                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao Listar registros: " + ex.Message);
                }

                finally
                {
                    connection.Close();
                }
            }
        }
        public void ListarComBoxID(ComboBox cbxRegID)
        {
            var connectionString = ConfigurationManager.ConnectionStrings["CalledManagement.Properties.Settings.academycoding2ConnectionString"].ConnectionString;
            var qry = "SELECT Id FROM HOURWORKED ORDER BY Id ASC";

            using (var connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    // Cria objeto cmd da classe SqlCommand passando os comandos SQL e a conexão com o Banco de Dados
                    var cmd = new SqlCommand(qry, connection);

                    SqlDataReader dr = cmd.ExecuteReader();
                    DataTable dt = new DataTable();

                    dt.Load(dr);
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
                    connection.Close();
                }
            }
        }
        public HourWorked SearchID(int ID)
        {
            HourWorked hourworked = new HourWorked();
            Called called = new Called();
            hourworked.CalledId = called;

            var connectionString = ConfigurationManager.ConnectionStrings["CalledManagement.Properties.Settings.academycoding2ConnectionString"].ConnectionString;
            var qry = "SELECT Id, CalledId, DateInserted, DateStarted, EndDate, DateChange " +
                    "FROM HOURWORKED WHERE Id LIKE @Id";
            using (var connection = new SqlConnection(connectionString))
            {
                //Abre conexão
                connection.Open();
                // Cria objeto cmd da classe SqlCommand passando os comandos SQL e a conexão com o Banco de Dados
                var cmd = new SqlCommand(qry, connection);

                cmd.Parameters.AddWithValue("@Id", ID);
                SqlDataReader reader = cmd.ExecuteReader();
                //percorre todas linhas de DataReader
                while (reader.Read())
                {
                    //recuperar os campos
                    hourworked.Id = int.Parse(reader["Id"].ToString());
                    hourworked.CalledId.Id = int.Parse(reader["CalledId"].ToString());
                    hourworked.DateStarted = Convert.ToDateTime(reader["DateStarted"].ToString());
                    hourworked.EndDate = Convert.ToDateTime(reader["EndDate"].ToString());
                }
                return hourworked;
            }
        }
    }
}