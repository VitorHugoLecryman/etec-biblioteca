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
namespace biblioteca
{
    public partial class Form8 : Form
    {
        public Form8()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int RowAffect = 0;
            
            MySqlCommand comando = new MySqlCommand();
            String SQL;
            String SQL1;

            string nome = txtnomealuno.Text;
            string RA = txtRMaluno.Text;
            MySqlConnection conexao = new MySqlConnection("Server = localhost; Database = bd_biblioteca; User ID = root;");

            if (rbdAluno.Checked)
            {
                string tipoUsuario = "L";
                SQL = "INSERT INTO tb_Usuarios (ds_nome,nr_RM_RA,ds_tipousuario) VALUES ('" + txtnomealuno.Text + "','" + txtRMaluno.Text + "','" + tipoUsuario + "')";
                conexao.Open();
                comando.Connection = conexao;
                comando.CommandText = SQL;
                RowAffect = comando.ExecuteNonQuery();
                if (RowAffect == 1)
                {
                    DialogResult Result = MessageBox.Show("Cadastro realizado com sucesso.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    if (Result == DialogResult.OK)
                    {
                        this.Close();
                    }
                }
                else
                {
                    MessageBox.Show("Cadastro não realizado!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                conexao.Close();

            }
                if (RDBFUNF.Checked)
                {
                    string Usuario = "F";
                    SQL = "INSERT INTO tb_Usuarios (ds_nome,nr_RM_RA,ds_tipousuario) VALUES ('" + txtnomealuno.Text + "','" + txtRMaluno.Text + "','" + Usuario + "')";
                    conexao.Open();
                    comando.Connection = conexao;
                    comando.CommandText = SQL;
                    RowAffect = comando.ExecuteNonQuery();
                    if (RowAffect == 1)
                    {
                        DialogResult Result = MessageBox.Show("Cadastro realizado com sucesso.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        if (Result == DialogResult.OK)
                        {
                            this.Close();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Cadastro não realizado!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    conexao.Close();
                }
            
        }

        private void rdbFuncionario_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void RDBFUNF_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void nivellbl_Click(object sender, EventArgs e)
        {

        }

        private void rbdAluno_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void txtnomealuno_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtRMaluno_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblRMaluno_Click(object sender, EventArgs e)
        {

        }

        private void lblnomealuno_Click(object sender, EventArgs e)
        {

        }
    }
}
    
