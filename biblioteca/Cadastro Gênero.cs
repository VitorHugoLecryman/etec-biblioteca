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
    public partial class Form9 : Form
    {
        public Form9()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int RowAffect = 0;

            MySqlCommand comando = new MySqlCommand();
            String SQL;
            MySqlConnection conexao = new MySqlConnection("Server = localhost; Database = bd_biblioteca; User ID = root;");

            
                
                SQL = "INSERT INTO tb_genero (ds_genero) VALUES ('" + txtGenero.Text + "')";
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
        }

        private void txtGenero_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblnomealuno_Click(object sender, EventArgs e)
        {

        }
    }
}
