using CalledManagement.Entities;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace CalledManagement.DAO
{
    class PriorityDAO
    {
        public bool Insert(Priority priority)
        {

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "insert into PRIORITY (Name, Days) values (@Name, @Days)";

            {
                try // Verifica se a operação com o banco irá ocorre irá ocorresem erros
                {
                    //SqlCommand cmd = new SqlCommand(strConn);

                    //conn.Open(); 

                    ToConnection toconnection = new ToConnection();
                    // Abre a conexão com o banco de dados.
                    toconnection.ToConnect();

                    // Esse objeto é responsável em executar os comandos SQL
                    cmd.Parameters.AddWithValue("@Name", priority.Name);
                    cmd.Parameters.AddWithValue("@Days", priority.Days);

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
                    
                }
                finally
                {
                    ToConnection toconection = new ToConnection();
                    // fechando a conexão com o banco de dados.
                    toconection.ToDisconnect();

                }
            }
        }

        public bool Change(Priority priority)
        {
            //string strConn = @"server=TI-NET-PC\SQLEXPRESS; DataBase=academycoding2; Trusted_Connection = True";

            //SqlConnection conn = new SqlConnection(strConn);

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "update USER set Name = @Name, Days = @Days where Id = @Id";
            {
                try // Verifica se a operação com o banco irá ocorre irá ocorresem erros
                {
                    //SqlCommand cmd = new SqlCommand(strConn);

                    //conn.Open(); 

                    ToConnection toconnection = new ToConnection();
                    // Abre a conexão com o banco de dados.
                    toconnection.ToConnect();

                    // Esse objeto é responsável em executar os comandos SQL
                    cmd.Parameters.AddWithValue("@Id", priority.Id);
                    cmd.Parameters.AddWithValue("@Name", priority.Name);
                    cmd.Parameters.AddWithValue("@Days", priority.Days);

                    // O objetro cmd recebe os parâmetros com os valores dos campos 
                    cmd.Connection = toconnection.ToConnect();
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
                    cmd.CommandText = "delete from PRIORITY where Id = @Id";
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
        public void ListarComboBox(ComboBox cbxRegPriority)
        {
            SqlCommand cmd = new SqlCommand();
            ToConnection toconnection = new ToConnection();

            try
            {
                cmd.Connection = toconnection.ToConnect();
                cmd.CommandText = "SELECT Name, Id FROM PRIORITY ORDER BY Days DESC";

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
        }

    }
}
