using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;


namespace AuE_Solucoes
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string server = "localhost";
        string port = "3306";
        string userId = "root";
        string database = "AUE_SOFTWARE";
        string password = "";

        public void LimpaFormulario()
        {
            txtNome.Text = "";
            cmbSexo.Text = "";
            mkData.Text = "";
            txtCidade.Text = "";
            txtCodContato.Text = "";
        }

        public void Busca()
        {
            string strConection = "server= " + server + ";port = " + port + "; userId = " + userId + "; database = " + database + "; password=" + password;
            MySqlConnection objcon = new MySqlConnection(strConection);
            objcon.Open();
            MySqlCommand objCmd = new MySqlCommand("SELECT NOME, SEXO, DATA_ , CIDADE, CODCONTATO FROM tb_aue_software where CODCONTATO = ?", objcon);
            objCmd.Parameters.Clear();
            objCmd.Parameters.Add("@CODCONTATO", MySqlDbType.Int32).Value = txtCodContato.Text;
            objCmd.CommandType = CommandType.Text;

            LimpaFormulario();

            MySqlDataReader dr;
            dr = objCmd.ExecuteReader();
            dr.Read();

            txtNome.Text = dr.GetString(0);
            cmbSexo.Text = dr.GetString(1);
            mkData.Text = dr.GetString(2);
            txtCidade.Text = dr.GetString(3);
            txtCodContato.Text = dr.GetString(4);
            objcon.Close();
        }

        private void BtnAltera_Click(object sender, EventArgs e)
        {

            ToolTip toolTip1 = new ToolTip();

            // Set up the delays for the ToolTip.
            toolTip1.AutoPopDelay = 5000;
            toolTip1.InitialDelay = 1000;
            toolTip1.ReshowDelay = 500;
            // Force the ToolTip text to be displayed whether or not the form is active.
            toolTip1.ShowAlways = true;

            // Set up the ToolTip text for the Button and Checkbox.
            toolTip1.SetToolTip(btnAltera, "Para fazer uma alteração é necessário fazer uma busca antes para modificar os dados.");


            try
            {
         
                string strConection = "server= " + server + ";port = " + port + "; userId = " + userId + "; database = " + database + "; password=" + password;
                MySqlConnection objcon = new MySqlConnection(strConection);
                objcon.Open();
                MySqlCommand objCmd = new MySqlCommand("UPDATE TB_AUE_SOFTWARE set NOME = ?, SEXO = ?, DATA_ = ?, CIDADE = ? where CODCONTATO = ?", objcon);
                objCmd.Parameters.Clear();

                string message = "Você quer mesmo Alterar o contato " + txtNome.Text + "?";
                string caption = "Confirmar a alterção:";
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                DialogResult result;
                result = MessageBox.Show(message, caption, buttons);
                if (result == System.Windows.Forms.DialogResult.No)
                {
                    return;
                }

                objCmd.Parameters.Add("@NOME", MySqlDbType.VarChar, 39).Value = txtNome.Text;
                objCmd.Parameters.Add("@SEXO", MySqlDbType.VarChar, 39).Value = cmbSexo.Text;
                objCmd.Parameters.Add("@DATA_", MySqlDbType.VarChar, 39).Value = DateTime.Parse(mkData.Text).ToString("yyyy-MM-dd");
                objCmd.Parameters.Add("@CIDADE", MySqlDbType.VarChar, 39).Value = txtCidade.Text;
                objCmd.Parameters.Add("@CODCONTATO", MySqlDbType.Int32).Value = txtCodContato.Text;

                objCmd.ExecuteNonQuery();
                objcon.Close();
            }

            catch (Exception)
            {
                MessageBox.Show("Erro");
            }
            finally
            {
                LimpaFormulario();
            }
            

        }
        private void BtnBusca_Click(object sender, EventArgs e)
        {
            try
            {
                Busca();
            }

            catch (Exception)
            {
                MessageBox.Show("O contato não existe no banco de dados");
            }
        }

        private void BtnExclui_Click(object sender, EventArgs e)
        {
            try
            {
                Busca();
                string message = "Você quer mesmo excluir o contato " + txtNome.Text + "?";
                string caption = "Confirmar a exclusão:";
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                DialogResult result;

                // Displays the MessageBox.
                result = MessageBox.Show(message, caption, buttons);
                if (result == System.Windows.Forms.DialogResult.No)
                {
                    return;
                }
                 string strConection = "server= " + server + ";port = " + port + "; userId = " + userId + "; database = " + database + "; password=" + password;
                 MySqlConnection objcon = new MySqlConnection(strConection);
                 objcon.Open();
                 MySqlCommand objCmd = new MySqlCommand("DELETE FROM TB_AUE_SOFTWARE WHERE CODCONTATO = ?", objcon);
                 objCmd.Parameters.Clear();
                 objCmd.Parameters.Add("@CODCONTATO", MySqlDbType.Int32).Value = txtCodContato.Text;
                 objCmd.CommandType = CommandType.Text;
                 objCmd.ExecuteNonQuery();
                 MessageBox.Show("Contato " + txtNome.Text + " excluído do banco de dados.");
                 objcon.Close();
                 LimpaFormulario();
            }

            catch (Exception)
            {
                MessageBox.Show("O contato não existe no banco de dados");
            }  
        }

        private void BtnInclui_Click(object sender, EventArgs e)
        {
            try
            {
                string strConection = "server= " + server + ";port = " + port + "; userId = " + userId + "; database = " + database + "; password=" + password;
                MySqlConnection objcon = new MySqlConnection(strConection);
                objcon.Open();
                MySqlCommand objCmd = new MySqlCommand("insert into TB_AUE_SOFTWARE(NOME ,SEXO, DATA_, CIDADE, CODCONTATO) values(?, ?, ?, ?,'null')", objcon);
                objCmd.Parameters.Add("@NOME", MySqlDbType.VarChar, 39).Value = txtNome.Text;
                objCmd.Parameters.Add("@SEXO", MySqlDbType.VarChar, 39).Value = cmbSexo.Text;
                objCmd.Parameters.Add("@DATA_", MySqlDbType.VarChar, 39).Value = DateTime.Parse(mkData.Text).ToString("yyyy-MM-dd");
                objCmd.Parameters.Add("@CIDADE", MySqlDbType.VarChar, 39).Value = txtCidade.Text;
                objCmd.ExecuteNonQuery();
                MessageBox.Show("Contato incluído do banco de dados.");
                objcon.Close();
                LimpaFormulario();
            }

            catch (Exception erro)
            {
                MessageBox.Show("Não deu certo" + erro);
            }
        }

        private void btnLimpaFormulario_Click(object sender, EventArgs e)
        {
            LimpaFormulario();
        }

        private void mkData_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            mkData.Mask = "00/00/0000";
        }

        private void button1_Click_1(object sender, EventArgs e)

        {
            try
            {
                string strConection = "server= " + server + ";port = " + port + "; userId = " + userId + "; database = " + database + "; password=" + password;
                MySqlConnection objcon = new MySqlConnection(strConection);
                string query = "select CIDADE, count(CODCONTATO) as'quantidade de contatos por cidade' from tb_aue_software group by CIDADE";
                DataTable dados = new DataTable();
                MySqlDataAdapter adaptador = new MySqlDataAdapter(query, strConection);
                objcon.Open();
                adaptador.Fill(dados);
                dgvContatosPorCidade.Rows.Clear();
                foreach (DataRow linha in dados.Rows)
                {
                    dgvContatosPorCidade.Rows.Add(linha.ItemArray);
                }
            }

            catch (Exception erro)
            {
                MessageBox.Show("Não deu certo" + erro);
            }

            try
            {
                string strConection = "server= " + server + ";port = " + port + "; userId = " + userId + "; database = " + database + "; password=" + password;
                MySqlConnection objcon = new MySqlConnection(strConection);
                string query = "select CIDADE, DATE_FORMAT(Data_, '%m-%Y') as 'mês e ano', COUNT(CODCONTATO) as 'contatos por mês'from tb_aue_software GROUP BY  CIDADE, monthname(Data_), year(data_) order by DATA_";
                DataTable dados = new DataTable();
                MySqlDataAdapter adaptador = new MySqlDataAdapter(query, strConection);
                objcon.Open();
                adaptador.Fill(dados);
                dgvContatosPorMes.Rows.Clear();                
                foreach (DataRow linha in dados.Rows)
                {
                    dgvContatosPorMes.Rows.Add(linha.ItemArray);
                }
            }

            catch (Exception erro)
            {
                MessageBox.Show("Não deu certo" + erro);
            }

            try
            {
                string strConection = "server= " + server + ";port = " + port + "; userId = " + userId + "; database = " + database + "; password=" + password;
                MySqlConnection objcon = new MySqlConnection(strConection);
                string query = "select count(CODCONTATO) as 'quantidade total de contatos' from tb_aue_software";

                DataTable dados = new DataTable();
                MySqlDataAdapter adaptador = new MySqlDataAdapter(query, strConection);
                objcon.Open();
                adaptador.Fill(dados);
                dgvTotalContatos.Rows.Clear();
                foreach (DataRow linha in dados.Rows)
                {
                    dgvTotalContatos.Rows.Add(linha.ItemArray);

                }
            }

            catch (Exception erro)
            {
                MessageBox.Show("Não deu certo" + erro);
            }
        }

        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {

        }
    }
}
