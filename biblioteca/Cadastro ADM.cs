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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int RowAffect = 0;
            MySqlCommand comando = new MySqlCommand();
            String SQL;
            string tipoUsuario = "A";
            MySqlConnection conexao = new MySqlConnection("Server = localhost; Database = bd_biblioteca; User ID = root;");
            SQL = "INSERT INTO tb_Usuarios (ds_nome, ds_senha,nr_RM_RA,ds_tipousuario) VALUES ('" + txtNomeAdm.Text + "','" + txtSenhaAdm.Text + "','" + txtRmAdm.Text + "','" + tipoUsuario+ "')";
            conexao.Open();
            comando.Connection = conexao;
            comando.CommandText = SQL;
            RowAffect = comando.ExecuteNonQuery();
            if (RowAffect == 1)
            {
                MessageBox.Show("Cadastro realizado com sucesso!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtNomeAdm.Text = "";
                txtSenhaAdm.Text = "";
                txtRmAdm.Text = "";
                txtNomeAdm.Focus();
            }
            else
            {
                MessageBox.Show("Cadastro não realizado!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            conexao.Close();
        }
    }
}
