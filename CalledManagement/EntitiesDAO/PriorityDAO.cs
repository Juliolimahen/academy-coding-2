using CalledManagement.EntitiesDAO;
using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace CalledManagement.EntitiesDAO
{
    class PriorityDAO
    {
        public bool Insert(Priority priority)
        {
            var connectionString = ConfigurationManager.ConnectionStrings["CalledManagement.Properties.Settings.academycoding2ConnectionString"].ConnectionString;
            string qry= "insert into PRIORITY (Name, Days) values (@Name, @Days)";
            using (var connection = new SqlConnection(connectionString))
            {
                try 
                {
                    connection.Open();
                    var cmd = new SqlCommand(qry, connection);
                    cmd.Parameters.AddWithValue("@Name", priority.Name);
                    cmd.Parameters.AddWithValue("@Days", priority.Days);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Cadastro Salvo com sucesso!");
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
            string qry = "update USER set Name = @Name, Days = @Days where Id = @Id";

            using (var connection = new SqlConnection(connectionString))
            {
                try 
                {
                    connection.Open();
                    var cmd = new SqlCommand(qry, connection);

                    cmd.Parameters.AddWithValue("@Id", priority.Id);
                    cmd.Parameters.AddWithValue("@Name", priority.Name);
                    cmd.Parameters.AddWithValue("@Days", priority.Days);
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Cadastro alterado com sucesso!");

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
        public void ToListComboBox(ComboBox cbxRegPriority)
        {
            var connectionString = ConfigurationManager.ConnectionStrings["CalledManagement.Properties.Settings.academycoding2ConnectionString"].ConnectionString;
            string qry = "SELECT Name, Id FROM PRIORITY ORDER BY Days DESC";
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
