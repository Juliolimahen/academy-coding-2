using CalledManagement.EntitiesModel;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Configuration;
using System.Text;

namespace CalledManagement.EntitiesDAO
{
    class UserDAO
    {

        public bool Insert(User user)
        {
            var connectionString = ConfigurationManager.ConnectionStrings["CalledManagement.Properties.Settings.academycoding2ConnectionString"].ConnectionString;
            string qry = "INSERT INTO USUARIO (Descricao, Email, Senha, DataCadastro) VALUES ( @Descricao, @Email, @Senha, @DataCadastro)";
            using (var connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    var cmd = new SqlCommand(qry, connection);
                    cmd.Parameters.AddWithValue("@Descricao", user.Descripition);
                    cmd.Parameters.AddWithValue("@Senha", user.Password);
                    cmd.Parameters.AddWithValue("@Email", user.Email);
                    cmd.Parameters.AddWithValue("@DataCadastro", user.RegisterDate);

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
        public bool Change(User user)
        {
            var connectionString = ConfigurationManager.ConnectionStrings["CalledManagement.Properties.Settings.academycoding2ConnectionString"].ConnectionString;
            string qry = "UPDATE USUARIO SET Descricao = @Descricao, Email = @Email, Senha = @Senha, DataAlteracao = @DataAlteracao WHERE Id =@Id";

            using (var connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    var cmd = new SqlCommand(qry, connection);

                    cmd.Parameters.AddWithValue("@Id", user.Id);
                    cmd.Parameters.AddWithValue("@Descricao", user.Descripition);
                    cmd.Parameters.AddWithValue("@Email", user.Email);
                    cmd.Parameters.AddWithValue("@Senha", user.Password);
                    cmd.Parameters.AddWithValue("@DataAlteracao", user.UpdateDate);
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
            var qry = "delete from USUARIO where Id = @Id";
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

        public void ToListGrid(DataGridView dgvSec, string name)
        {
            //string de conexao
            var connectionString = ConfigurationManager.ConnectionStrings["CalledManagement.Properties.Settings.academycoding2ConnectionString"].ConnectionString;

            //Variaveis que armazenam os comandos SQL
            #region
            string QrySelect = "SELECT  Descricao, Email, DataCadastro, DataAlteracao ";
            string QryFrom = "FROM USUARIO ";
            string QryOrderBy = "ORDER BY Descricao ";
            string QryWhere = "WHERE Descricao ";
            string QryLike = "LIKE @Name ";
            #endregion

            StringBuilder qry = new StringBuilder();

            qry.Append(QrySelect);
            qry.Append(QryFrom);
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
                        qry.Append(QryWhere);
                        qry.Append(QryLike);
                        qry.Append(QryOrderBy);

                        cmd.CommandText = qry.ToString();
                        cmd.Parameters.AddWithValue("@Name", "%" + name + "%");
                        cmd.ExecuteNonQuery();
                    }

                    SqlDataReader rd = cmd.ExecuteReader();
                    DataTable dt = new DataTable();
                    dt.Load(rd);
                    dgvSec.DataSource = dt;
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
        public void ToListComboBoxID(ComboBox cbxSec)
        {
            var connectionString = ConfigurationManager.ConnectionStrings["CalledManagement.Properties.Settings.academycoding2ConnectionString"].ConnectionString;

            string qry = "SELECT Descricao, Id FROM USUARIO";

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
                    cbxSec.DisplayMember = "Descricao";
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

        public User SearchID(int ID)
        {
            User user = new User();

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
                    user.Id = int.Parse(rd["Id"].ToString());
                    user.Descripition = rd["Name"].ToString();
                    user.Password = rd["Descripition"].ToString();
                    user.Email = rd["PriorityId"].ToString();
                }
            }
            return user;
        }

        public bool VerificaLogin(TextBox descripition, TextBox password)
        {
            User user = new User();

            var connectionString = ConfigurationManager.ConnectionStrings["CalledManagement.Properties.Settings.academycoding2ConnectionString"].ConnectionString;
            string qry = "SELECT Descricao, Senha FROM USUARIO WHERE Descricao = @Descricao and Senha = @Senha";

            using (var connection = new SqlConnection(connectionString))
            {
                connection.Open();
                var cmd = new SqlCommand(qry, connection);
                cmd.Parameters.AddWithValue("@Descricao", SqlDbType.VarChar).Value = descripition.Text;
                cmd.Parameters.AddWithValue("@Senha", SqlDbType.VarChar).Value = password.Text;
                SqlDataReader rd = cmd.ExecuteReader();

                if (rd.HasRows)
                { return true; }
                else
                {
                    return false;
                }
            }
        }
    }
}
