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
    //Classe responsavel pela comunicação da entidade HourWorked com o banco de dados 
    class HourWorkedDAO
    {
        public bool Insert(HourWorked hourworked)
        {
            //string strConn = @"server=TI-NET-PC\SQLEXPRESS; DataBase=academycoding2; Trusted_Connection = True";

            // Cria objeto cmd da classe SqlCommand passando os comandos SQL e a conexão com o Banco de Dados
            SqlCommand cmd = new SqlCommand();

            cmd.CommandText = "insert into HOURWORKED (CalledId, DateInserted, DateStarted, EndDate, Manual) values (@CalledId, @DateInserted, @DateStarted, @EndDate, @Manual)";

            {
                try // Verifica se a operação com o banco irá ocorre irá ocorresem erros
                {
                    ToConnection toconnection = new ToConnection();

                    cmd.Parameters.AddWithValue("@CalledId", hourworked.CalledId.Id);
                    cmd.Parameters.AddWithValue("@DateInserted", hourworked.DateInserted);
                    cmd.Parameters.AddWithValue("@DateStarted", hourworked.DateStarted);
                    cmd.Parameters.AddWithValue("@EndDate", hourworked.EndDate);
                    cmd.Parameters.AddWithValue("@Manual", hourworked.Manual);
                    //cmd.Parameters.AddWithValue("@DateChange", hourworked.DateChange);

                    cmd.Connection = toconnection.ToConnect();
                    // O objetro cmd recebe os parâmetros com os valores dos campos

                    cmd.ExecuteNonQuery();

                    //teste...
                    MessageBox.Show("Cadastro salvo com sucesso!");

                    // Retorna o comando SQL de INSERT no banco de dados. 
                    return true;
                    // Retorna true (verdadeiro) caso a inserção do registro seja realizado corretamente.
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao salvar registro: " + ex.Message);
                    return false;
                    // Caso ocorrra algum erro nos comandos abaixo do try será executado o catch(), disparado uma mensagem de erro para

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
        public bool Change(HourWorked hourworked)
        {
            //string strConn = @"server=TI-NET-PC\SQLEXPRESS; DataBase=academycoding2; Trusted_Connection = True";

            //SqlConnection conn = new SqlConnection(strConn);

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "update HOURWORKED set CalledId = @CalledId, DateStarted = @DateStarted, EndDate = @EndDate, DateChange = @DateChange where Id = @Id";
            {
                try // Verifica se a operação com o banco irá ocorre irá ocorresem erros
                {
                    //SqlCommand cmd = new SqlCommand(strConn);

                    //conn.Open(); // Abre a conexão com o banco de dados.

                    ToConnection toconnection = new ToConnection();
                    toconnection.ToConnect();

                    // Esse objeto é responsável em executar os comandos SQL
                    cmd.Parameters.AddWithValue("@Id", hourworked.Id);
                    cmd.Parameters.AddWithValue("@CalledId", hourworked.CalledId.Id);
                    //cmd.Parameters.AddWithValue("@DateInserted", hourworked.DateInserted);
                    cmd.Parameters.AddWithValue("@DateStarted", hourworked.DateStarted);
                    cmd.Parameters.AddWithValue("@EndDate", hourworked.EndDate);
                    cmd.Parameters.AddWithValue("@DateChange", hourworked.DateChange);
                    //cmd.Parameters.AddWithValue("@Manual", hourworked.Manual);

                    cmd.Connection = toconnection.ToConnect();
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
                    MessageBox.Show("Erro ao salvar registro: " + ex.Message);
                    return false;
                    // Caso ocorrra algum erro nos comandos abaixo do try será executado o catch(), disparado uma mensagem de erro para
                    // Informando "Erro ao salvar registro" + o erro recebido do banco de dados
                }
                // O finally é sempre executado,
                finally
                { 
                    // fechando a conexão com o banco de dados.
                    ToConnection toconection = new ToConnection();
                    toconection.ToDisconnect();
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


                    cmd.CommandText = "delete from HOURWORKED where calledId = @Id";
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
                    ToConnection toconection = new ToConnection();
                    toconection.ToDisconnect();
                }
            }
        }
        public void ListarGrid(DataGridView dgvSecHours, string name)
        {
            SqlCommand cmd = new SqlCommand();
            ToConnection toconnection = new ToConnection();

            try
            {
                cmd.Connection = toconnection.ToConnect();
                cmd.CommandText = "" +
                    "SELECT H.Id, H.CalledId, C.Name, H.DateInserted, H.DateStarted, H.EndDate, H.DateChange, H.Manual " +
                    "FROM HOURWORKED AS H " +
                    "INNER JOIN CALLED AS C " +
                    "ON H.CalledId = C.Id ORDER BY H.DateInserted DESC";

                if (name.Length > 0)
                {
                    cmd.CommandText = "SELECT CalledId, DateInserted, DateStarted, EndDate, DateChange, Manual FROM HOURWORKED WHERE Name LIKE @Name";
                    cmd.Parameters.AddWithValue("@Name", "%" + name + "%");

                    cmd.ExecuteNonQuery();
                }

                SqlDataReader rd = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(rd);
                dgvSecHours.DataSource = dt;
                dgvSecHours.Refresh();
            }

            catch (Exception ex)
            {
                MessageBox.Show("Erro ao Listar registros: " + ex.Message);
            }

            finally {
                toconnection.ToDisconnect();
            }
        }
        public void ListarComBoxID(ComboBox cbxRegID)
        {
            SqlCommand cmd = new SqlCommand();
            ToConnection toconnection = new ToConnection();

            try
            {
                cmd.Connection = toconnection.ToConnect();
                cmd.CommandText = "SELECT Id FROM HOURWORKED ORDER BY Id ASC";

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
        public HourWorked SearchID(int ID)
        {
            HourWorked hourworked = new HourWorked();
            Called called = new Called();
            hourworked.CalledId = called;

            SqlCommand cmd = new SqlCommand();
            ToConnection toconnection = new ToConnection();

            cmd.Connection = toconnection.ToConnect();
            cmd.CommandText = "SELECT Id, CalledId, DateInserted, DateStarted, EndDate, DateChange, " +
                "Manual FROM HOURWORKED WHERE Id LIKE @Id";
            cmd.Parameters.AddWithValue("@Id", ID);
            cmd.Connection = toconnection.ToConnect();
            SqlDataReader reader = cmd.ExecuteReader();

            //percorre todas linhas de DataReader
            while (reader.Read())
            {
                //recuperar os campos
                hourworked.Id = int.Parse(reader["Id"].ToString());
                hourworked.CalledId.Id = int.Parse(reader["CalledId"].ToString());
                hourworked.DateStarted = Convert.ToDateTime(reader["DateStarted"].ToString());
                hourworked.EndDate = Convert.ToDateTime(reader["EndDate"].ToString());
                //hourworked.Manual = Convert.ToChar(reader["Manual"].ToString());
            }

            return hourworked;
        }
    }
}
