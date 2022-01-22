using CalledManagement.EntitiesDAO;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Configuration;
using System.Text;

namespace CalledManagement.EntitiesDAO
{
    //Classe responsavel pela comunicação da entidade Called com o banco de dados 
    class CalledDAO
    {
        public bool Insert(Called called)
        {
            //String de conexao
            var connectionString = ConfigurationManager.ConnectionStrings["CalledManagement.Properties.Settings.academycoding2ConnectionString"].ConnectionString;
            //Variavel que armazena comando sql
            string qry = "INSERT INTO CALLED (Name, Date, Descripition, Finished, PriorityId) VALUES (@Name, @Date, @Descripition, @Finished, @PriorityId)";
            // Cria objeto connection da classe Sql Connection passando por parâmetro a string de conexão
            using (var connection = new SqlConnection(connectionString))
            {

                try // Verifica se a operação com o banco irá ocorrer sem erros
                {
                    // Abre a conexão com o banco de dados.
                    connection.Open();
                    // Cria objeto cmd da classe SQLCommand passando os comandos SQL e a conexão como parametro e executar o SQL
                    var cmd = new SqlCommand(qry, connection);

                    cmd.Parameters.AddWithValue("@Name", called.Name);
                    cmd.Parameters.AddWithValue("@Date", called.Date);
                    cmd.Parameters.AddWithValue("@Descripition", called.Descripition);
                    cmd.Parameters.AddWithValue("@Finished", called.Finished);
                    cmd.Parameters.AddWithValue("@PriorityId", called.PriorityId.Id);

                    // Método para executar comandos no BD
                    cmd.ExecuteNonQuery();
                    // Retorna true (verdadeiro) caso a inserção do registro seja realizado corretamente.
                    return true;
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
            string qry = "UPDATE CALLED SET Name = @Name, Date = @Date, Descripition = @Descripition, Finished = @Finished, PriorityId = @PriorityId WHERE Id = @Id";

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
            string qry = "DELETE FROM CALLED where Id = @Id";

            using (var connection = new SqlConnection(connectionString))
            {
                try
                {
                    //abre conexão
                    connection.Open();
                    var cmd = new SqlCommand(qry, connection);

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
                    connection.Close();
                }
            }
        }
        public void ToListGrid(DataGridView dgvSecCalled, string name)
        {
            //string de conexao
            var connectionString = ConfigurationManager.ConnectionStrings["CalledManagement.Properties.Settings.academycoding2ConnectionString"].ConnectionString;

            //Variaveis que armazenam os comandos SQL
            #region
            string QrySelect = "SELECT C.Id, C.Name, C.Date, C.Finished, C.Descripition, C.PriorityId, P.Name, P.Days, CAST(H.DateInserted AS DATE), " +
            "SUM(DATEDIFF(minute, DateStarted, EndDate)) ";
            string QryFrom = "FROM CALLED C ";
            string QryInnerJoin = "INNER JOIN PRIORITY P ON C.PriorityId = P.Id ";
            string QryLeftJoin = "LEFT JOIN HOURWORKED H ON C.Id = H.CalledId ";
            string QryGroupBy = "group BY C.Id, C.Name, C.Date, C.Finished, C.Descripition, C.PriorityId, P.Name, P.Days, CAST(H.DateInserted AS DATE) ";
            string QryOrderBy = "ORDER BY C.Finished, CAST(H.DateInserted AS DATE), C.Date DESC, C.PriorityId DESC ";
            string QryWhere = "WHERE c.Name ";
            string QryLike = "LIKE @Name ";
            #endregion

            StringBuilder qry = new StringBuilder();

            qry.Append(QrySelect);
            qry.Append(QryFrom);
            qry.Append(QryInnerJoin);
            qry.Append(QryLeftJoin);
            qry.Append(QryGroupBy);
            qry.Append(QryOrderBy);

            using (var connection = new SqlConnection(connectionString))
            {
                connection.Open();

                try
                {
                    var cmd = new SqlCommand(qry.ToString(), connection);

                    // Pesquisa por nome Nome
                    if (name.Length > 0)
                    {
                        qry.Clear();
                        qry.Append(QrySelect);
                        qry.Append(QryFrom);
                        qry.Append(QryInnerJoin);
                        qry.Append(QryLeftJoin);
                        qry.Append(QryWhere);
                        qry.Append(QryLike);
                        qry.Append(QryGroupBy);
                        qry.Append(QryOrderBy);

                        cmd.CommandText = qry.ToString();
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
        public void ToListComboBox(ComboBox cbxSec)
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
        public void ToListComBoxID(ComboBox cbxRegID)
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


