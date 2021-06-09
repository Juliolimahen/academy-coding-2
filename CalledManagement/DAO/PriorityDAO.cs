using CalledManagement.Entities;
using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace CalledManagement.DAO
{
    class PriorityDAO
    {
        public bool Insert(Priority priority)
        {
            var connectionString = ConfigurationManager.ConnectionStrings["CalledManagement.Properties.Settings.academycoding2ConnectionString"].ConnectionString;
            var qry= "insert into PRIORITY (Name, Days) values (@Name, @Days)";

            using (var connection = new SqlConnection(connectionString))
            {
                try 
                {
                    connection.Open();
                    var cmd = new SqlCommand(qry, connection);
                    cmd.Parameters.AddWithValue("@Name", priority.Name);
                    cmd.Parameters.AddWithValue("@Days", priority.Days);
                    cmd.ExecuteNonQuery();

                    //teste...
                    MessageBox.Show("Cadastro salvo com sucesso!");
                    return true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao salvar registro: " + ex.Message);
                    return false;
                }
                finally
                { 
                    connection.Close();
                }
            }
        }
        public bool Change(Priority priority)
        {
            var connectionString = ConfigurationManager.ConnectionStrings["CalledManagement.Properties.Settings.academycoding2ConnectionString"].ConnectionString;
            var qry = "update USER set Name = @Name, Days = @Days where Id = @Id";

            using (var connection = new SqlConnection(connectionString))
            {
                try // Verifica se a operação com o banco irá ocorre irá ocorresem erros
                {
                    // Abre a conexão com o banco de dados.
                    connection.Open();
                    var cmd = new SqlCommand(qry, connection);

                    // Esse objeto é responsável em executar os comandos SQL
                    cmd.Parameters.AddWithValue("@Id", priority.Id);
                    cmd.Parameters.AddWithValue("@Name", priority.Name);
                    cmd.Parameters.AddWithValue("@Days", priority.Days);

                    // Retorna o comando SQL de INSERT no banco de dados
                    cmd.ExecuteNonQuery();

                    //teste
                    MessageBox.Show("Cadastro Excluido com sucesso!");
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
                    connection.Close();
                }
            }
        }
        public bool Delete(int ID)
        {
            var connectionString = ConfigurationManager.ConnectionStrings["CalledManagement.Properties.Settings.academycoding2ConnectionString"].ConnectionString;
            var qry = "delete from PRIORITY where Id = @Id";
            using (var connection = new SqlConnection(connectionString))
            {
                try
                {
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
        public void ListarComboBox(ComboBox cbxRegPriority)
        {
            var connectionString = ConfigurationManager.ConnectionStrings["CalledManagement.Properties.Settings.academycoding2ConnectionString"].ConnectionString;
            var qry = "SELECT Name, Id FROM PRIORITY ORDER BY Days DESC";
            using (var connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    var cmd = new SqlCommand(qry, connection);
                    SqlDataReader adp = cmd.ExecuteReader();
                    DataTable dt = new DataTable();

                    dt.Load(adp);
                    cbxRegPriority.DisplayMember = "Name";
                    cbxRegPriority.ValueMember = "Id";
                    cbxRegPriority.DataSource = dt;
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
    }
}
