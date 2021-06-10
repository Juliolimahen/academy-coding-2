using CalledManagement.EntitiesDAO;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Configuration;

namespace CalledManagement.EntitiesDAO
{
    //Classe responsavel pela comunicação da entidade Called com o banco de dados 
    class CalledDAO
    {
        public bool Insert(Called called)
        {
            var connectionString = ConfigurationManager.ConnectionStrings["CalledManagement.Properties.Settings.academycoding2ConnectionString"].ConnectionString;
            string qry = "INSERT INTO CALLED (Name, Date, Descripition, Finished, PriorityId) VALUES (@Name, @Date, @Descripition, @Finished, @PriorityId)";

            using (var connection = new SqlConnection(connectionString))
            {

                try // Verifica se a operação com o banco irá ocorrer sem erros
                {
                    // Abre a conexão com o banco de dados.
                    connection.Open();
                    // Cria objeto cmd da classe SQLCommand passando os comandos SQL e a conexão como parametro
                    var cmd = new SqlCommand(qry, connection);

                    cmd.Parameters.AddWithValue("@Name", called.Name);
                    cmd.Parameters.AddWithValue("@Date", called.Date);
                    cmd.Parameters.AddWithValue("@Descripition", called.Descripition);
                    cmd.Parameters.AddWithValue("@Finished", called.Finished);
                    cmd.Parameters.AddWithValue("@PriorityId", called.PriorityId.Id);

                    // Método para executar comandos no BD
                    cmd.ExecuteNonQuery();

                    return true;
                    // Retorna true (verdadeiro) caso a inserção do registro seja realizado corretamente.

                }
                catch (Exception ex)
                {
                    // Caso ocorrra algum erro nos comandos abaixo do try será executado o catch exibindo uma mensagem de erro
                    MessageBox.Show("Erro ao salvar registro: " + ex.Message);
                    return false;
                }
                // O finally é sempre executado,
                finally
                {
                    //fecha a conexão com o banco
                    connection.Close();
                }
            }
        }
        public bool Change(Called called)
        {
            var connectionString = ConfigurationManager.ConnectionStrings["CalledManagement.Properties.Settings.academycoding2ConnectionString"].ConnectionString;
            string qry = "update CALLED set Name = @Name, Date = @Date, Descripition = @Descripition, Finished = @Finished, PriorityId = @PriorityId where Id = @Id";

            using (var connection = new SqlConnection(connectionString))
            {

                try // Verifica se a operação com o banco irá ocorrer sem erros
                {
                    // Abre a conexão com o banco de dados.
                    connection.Open();
                    // Esse objeto é responsável em executar os comandos SQL
                    var cmd = new SqlCommand(qry, connection);

                    

                    cmd.Parameters.AddWithValue("@Id", called.Id);
                    cmd.Parameters.AddWithValue("@Name", called.Name);
                    cmd.Parameters.AddWithValue("@Date", called.Date);
                    cmd.Parameters.AddWithValue("@Descripition", called.Descripition);
                    cmd.Parameters.AddWithValue("@Finished", called.Finished);
                    cmd.Parameters.AddWithValue("@PriorityId", called.PriorityId.Id);

                    // Retorna o comando SQL de INSERT no banco de dados
                    cmd.ExecuteNonQuery();

                    //teste
                    MessageBox.Show("Cadastro alterado com sucesso!");
                    // Retorna true (verdadeiro) caso a inserção do registro seja realizado corretamente.
                    return true;


                }
                // Caso ocorrra algum erro nos comandos abaixo do try será executado o catch(), disparado uma mensagem de erro
                catch (Exception ex)
                {
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
        public bool Delete(int ID)
        {
            var connectionString = ConfigurationManager.ConnectionStrings["CalledManagement.Properties.Settings.academycoding2ConnectionString"].ConnectionString;
            string qry = "delete from CALLED where Id = @Id";

            using (var connection = new SqlConnection(connectionString))
            {
                try
                {
                    //abre conexão
                    connection.Open();
                    var cmd = new SqlCommand(qry, connection);

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
                    connection.Close();
                }
            }
        }
        public void ListarGrid(DataGridView dgvSecCalled, string name)
        {
            var connectionString = ConfigurationManager.ConnectionStrings["CalledManagement.Properties.Settings.academycoding2ConnectionString"].ConnectionString;

            string qry = "" +
            #region
               "SELECT c.Id, c.Name, c.Date, c.Finished, c.Descripition,c.PriorityId, p.Name, p.Days, CAST(h.EndDate AS DATE), " +
               "SUM(DATEDIFF(minute, DateStarted, EndDate)) " +
               "FROM CALLED c " +
               "INNER JOIN PRIORITY p " +
               "ON c.PriorityId = p.Id " +
               "LEFT JOIN HOURWORKED h ON " +
               "c.Id = h.CalledId " +
               "group BY c.Id, c.Name, c.Date, c.Finished, " +
               "c.Descripition, c.PriorityId, p.Name, p.Days, CAST(h.EndDate AS DATE) " +
               "ORDER BY c.Finished, CAST(h.EndDate AS DATE), c.Date DESC, c.PriorityId DESC " +
            #endregion
               "";

            using (var connection = new SqlConnection(connectionString))
            {
                connection.Open();

                try
                {
                    var cmd = new SqlCommand(qry, connection);

                    // Pesquisa por nome Nome
                    if (name.Length > 0)
                    {
                        cmd.CommandText = "" +
                        #region
                           "SELECT c.Id, c.Name, c.Date, c.Finished, c.Descripition,c.PriorityId, p.Name, p.Days, CAST(h.EndDate AS DATE), " +
                           "SUM(DATEDIFF(minute, DateStarted, EndDate)) " +
                           "FROM CALLED c " +
                           "INNER JOIN PRIORITY p " +
                           "ON c.PriorityId = p.Id " +
                           "LEFT JOIN HOURWORKED h ON " +
                           "c.Id = h.CalledId " +
                           "WHERE c.Name LIKE @Name " +
                           "group BY c.Id, c.Name, c.Date, c.Finished, " +
                           "c.Descripition, c.PriorityId, p.Name, p.Days, CAST(h.EndDate AS DATE) " +
                           "ORDER BY c.Finished, CAST(h.EndDate AS DATE), c.Date DESC, c.PriorityId DESC" +
                        #endregion
                           "";
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
            var connectionString = ConfigurationManager.ConnectionStrings["CalledManagement.Properties.Settings.academycoding2ConnectionString"].ConnectionString;

            string qry = "SELECT Name, Id FROM CALLED";

            using (var connection = new SqlConnection(connectionString))
            {
                connection.Open();//abre conexão com o banco 
                try
                {
                    var cmd = new SqlCommand(qry, connection);

                    SqlDataReader rd = cmd.ExecuteReader();
                    DataTable dt = new DataTable();

                    dt.Load(rd);
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
                    connection.Close();
                }
            }
        }
        public void ListarComBoxID(ComboBox cbxRegID)
        {
            var connectionString = ConfigurationManager.ConnectionStrings["CalledManagement.Properties.Settings.academycoding2ConnectionString"].ConnectionString;

            string qry = "SELECT Name, Id FROM CALLED";

            using (var connection = new SqlConnection(connectionString))
            {

                try
                {
                    connection.Open();
                    var cmd = new SqlCommand(qry, connection);

                    SqlDataReader rd = cmd.ExecuteReader();
                    DataTable dt = new DataTable();

                    dt.Load(rd);
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
        public Called SearchID(int ID)
        {
            Called called = new Called();
            Priority priority = new Priority();
            called.PriorityId = priority;

            var connectionString = ConfigurationManager.ConnectionStrings["CalledManagement.Properties.Settings.academycoding2ConnectionString"].ConnectionString;
            string qry = "SELECT Id, Name, Date, Finished, Descripition, PriorityId FROM CALLED WHERE Id LIKE @Id";

            using (var connection = new SqlConnection(connectionString))
            {
                connection.Open();
                var cmd = new SqlCommand(qry, connection);
                cmd.Parameters.AddWithValue("@Id", ID);
                SqlDataReader rd = cmd.ExecuteReader();

                //percorre todas as linhas de DataReader
                while (rd.Read())
                {
                    //recuperar os campos
                    called.Id = int.Parse(rd["Id"].ToString());
                    called.Name = rd["Name"].ToString();
                    called.Date = Convert.ToDateTime(rd["Date"].ToString());
                    called.Finished = rd["Finished"].ToString();
                    called.Descripition = rd["Descripition"].ToString();
                    called.PriorityId.Id = int.Parse(rd["PriorityId"].ToString());
                }
            }
            return called;
        }
    }
}


