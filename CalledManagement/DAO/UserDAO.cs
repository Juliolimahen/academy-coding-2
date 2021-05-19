using CalledManagement.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalledManagement.DAO
{
    class UserDAO
    {
        public bool Insert(User user)
        {
            //string strConn = @"server=TI-NET-PC\SQLEXPRESS; DataBase=academycoding2; Trusted_Connection = True";

            //SqlConnection conn = new SqlConnection(strConn);


            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "insert into USER (Name, Date, Descripition, Finished) values (@Name, @Date, @Descripition, @Finished)";

            {
                try // Verifica se a operação com o banco irá ocorre irá ocorresem erros
                {
                    //SqlCommand cmd = new SqlCommand(strConn);

                    //conn.Open(); 

                    ToConnection toconnection = new ToConnection();
                    // Abre a conexão com o banco de dados.
                    toconnection.ToConnect();

                    // Esse objeto é responsável em executar os comandos SQL
                    cmd.Parameters.AddWithValue("@Name", user.Name);
                    cmd.Parameters.AddWithValue("@Date", user.DateTimeRegister);
                    cmd.Parameters.AddWithValue("@Descripition", user.Login);
                    cmd.Parameters.AddWithValue("@Finished", user.Password);

                    cmd.Connection = toconnection.ToConnect();

                    // Retorna o comando SQL de INSERT no banco de dados. 
                    cmd.ExecuteNonQuery();

                    //teste...
                    MessageBox.Show("Cadastro salvo com sucesso!");
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

        public bool Change(User user)
        {
            //string strConn = @"server=TI-NET-PC\SQLEXPRESS; DataBase=academycoding2; Trusted_Connection = True";

            //SqlConnection conn = new SqlConnection(strConn);

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "update USER set Name = @Name, Date = @Date, Descripition = @Descripition, Finished = @Finished  where Id = @Id";
            {
                try // Verifica se a operação com o banco irá ocorre irá ocorresem erros
                {
                    //SqlCommand cmd = new SqlCommand(strConn);

                    //conn.Open(); 

                    ToConnection toconnection = new ToConnection();
                    // Abre a conexão com o banco de dados.
                    toconnection.ToConnect();

                    // Esse objeto é responsável em executar os comandos SQL
                    cmd.Parameters.AddWithValue("@Id", user.Id);
                    cmd.Parameters.AddWithValue("@Name", user.Name);
                    cmd.Parameters.AddWithValue("@DateTimeRegister", user.DateTimeRegister);
                    cmd.Parameters.AddWithValue("@Login", user.Login);
                    cmd.Parameters.AddWithValue("@Password", user.Password);
                    cmd.Parameters.AddWithValue("@Occupation", user.Occupation);
                    cmd.Parameters.AddWithValue("@AccessLevel", user.AccessLevel);

                    

                    // O objetro cmd recebe os parâmetros com os valores dos campos 
                    cmd.Connection = toconnection.ToConnect();

                    cmd.ExecuteNonQuery();
                    // Retorna o comando SQL de INSERT no banco de dados
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

                    cmd.CommandText = "delete from user where Id = @Id";

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

        public void ListarGrid(DataGridView dgvSec, string name)
        {
            SqlCommand cmd = new SqlCommand();
            ToConnection toconnection = new ToConnection();

            try
            {
                cmd.Connection = toconnection.ToConnect();
                cmd.CommandText = "SELECT Id, Name, Date, Finished, Descripition FROM user ORDER BY Date DESC";

                if (name.Length > 0)
                {
                    cmd.CommandText = "SELECT Id, Name, Date, Finished, Descripition FROM user WHERE Name LIKE @Name";

                    cmd.Parameters.AddWithValue("@Name", "%" + name + "%");

                    cmd.ExecuteNonQuery();
                }
                // cmd.Parameters.AddWithValue("@Name", "%" + Name + "%");

                SqlDataAdapter adp = new SqlDataAdapter(cmd);
                DataTable db = new DataTable();
                adp.Fill(db);
                dgvSec.DataSource = db;
            }

            catch (Exception ex)
            {

                MessageBox.Show("Erro ao Listas registros: " + ex.Message);
            }
        }
        public void SearchGrid(DataGridView dgvSec, string name)
        {


            try
            {
                SqlCommand cmd = new SqlCommand();
                ToConnection toconnection = new ToConnection();
                cmd.Connection = toconnection.ToConnect();



                cmd.CommandText = "SELECT Id, Name, Date, Finished, Descripition FROM user WHERE Name LIKE '@Name'";

                cmd.Parameters.AddWithValue("@Name", "%" + name + "%");

                cmd.ExecuteNonQuery();



                SqlDataAdapter adp = new SqlDataAdapter(cmd);
                DataTable db = new DataTable();
                adp.Fill(db);
                dgvSec.DataSource = db;
            }

            catch (Exception ex)
            {

                MessageBox.Show("Erro ao Listar registros: " + ex.Message);
            }
        }
        //Corrigir...
        /*
        public user SearchID(int ID)
        {
            user user = new user();

            SqlCommand cmd = new SqlCommand();
            ToConnection toconnection = new ToConnection();
            {
                cmd.Connection = toconnection.ToConnect();

                cmd.CommandText = "SELECT Id, Name, Date, Finished, Descripition FROM user WHERE Name LIKE '@Id'";
                cmd.Parameters.AddWithValue("@Id", ID);
                cmd.Connection = toconnection.ToConnect();
                SqlDataReader reader = cmd.ExecuteReader();

                //percorre todas as linhas de DataReader
                while (reader.Read())
                {
                    //recuperar os campos
                    user.Id = int.Parse(reader["Id"].ToString());
                    user.Name = reader["Name"].ToString();
                    user.Date = Convert.ToDateTime(reader["Date"].ToString());
                    user.Finished = reader["Finished"].ToString();
                    user.Descripition = reader["Descripition"].ToString();
                }
                toconnection.ToDisconnect();
            }
            return user;
        }
        public List<user> SearchName(string Name)
        {
            List<user> lista = new List<user>();
            {
                //conn.Open();
                ToConnection toconnection = new ToConnection();
                toconnection.ToConnect();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "SELECT Id, Name, Date, Finished, Descripition FROM user WHERE Name LIKE '@Name'";
                cmd.Parameters.AddWithValue("@Name", "%" + Name + "%");
                cmd.Connection = toconnection.ToConnect();
                SqlDataReader reader = cmd.ExecuteReader();

                //percorre todas as linhas do DataReader
                while (reader.Read())
                {
                    //Recupera Campos
                    user user = new user();
                    user.Id = int.Parse(reader["Id"].ToString());
                    user.Name = reader["Name"].ToString();
                    user.Date = Convert.ToDateTime(reader["Date"].ToString());
                    user.Finished = reader["Finished"].ToString();
                    user.Descripition = reader["Descripition"].ToString();

                    lista.Add(user);
                }
            }
            return lista;

        }*/
    }
}
