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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            string userid = "";
            dataGridView1.Columns.Clear();
            MySqlConnection conexao = new MySqlConnection("Server = localhost; Database = bd_biblioteca; User ID = root;");
            MySqlCommand comando = new MySqlCommand();
            MySqlDataReader autor;
            DataTable dt = new DataTable();

            conexao.Open();
            String sqlIdUser = "SELECT id_usuario from TB_USUARIOS WHERE NR_RM_RA  = " + "'" + txtRm.Text + "'" + ";";

            comando.Connection = conexao;
            comando.CommandText = sqlIdUser;
            autor = comando.ExecuteReader();

            while (autor.Read())
            {
                userid = autor.GetString(0);
            }
            conexao.Close();
            using (conexao)
            {


                MySqlCommand cmd = new MySqlCommand("select LI.nr_Tombo as 'Nº Tombo',AU.nr_rm_ra as 'RM do Usuairo',MO.dt_Emprest as 'Data de Empréstimo',MO.dt_devol as 'Data de devolução' from tb_emp_devol as MO inner join tb_livros as LI on (LI.id_livro = MO.id_livro)inner join tb_usuarios as AU on (AU.id_usuario = MO.id_usuario) where AU.nr_RM_RA = "+txtRm.Text+" and Isnull(dt_Devol); ", conexao);
                if (txtRm.Text == "")
                {
                    MessageBox.Show("Preencha o campo necessário.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    conexao.Open();
                    MySqlDataReader reader = cmd.ExecuteReader();
                    dt.Load(reader);
                    if (dt.Rows.Count > 0)
                    {
                        
                        dataGridView1.DataSource = dt;
                    }

                }

            }

            conexao.Open();
            
            string contador = "";
            int count = 0;
            String sqlCountLivroaluno = "SELECT COUNT(id_livro) FROM tb_emp_devol where id_usuario = '" + userid + "' and Isnull(dt_Devol)";
            comando.Connection = conexao;
            comando.CommandText = sqlCountLivroaluno;
            autor = comando.ExecuteReader();

            while (autor.Read())
            {
                contador = autor.GetString(0);
            }
            conexao.Close();
            count = int.Parse(contador);

            if (count >=1)
            {
                button1.Visible = true;
            }
            
        }

        private void Form5_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var newForm = new Devolução();
            newForm.Show();
        }

        private void lblnomealuno_Click(object sender, EventArgs e)
        {

        }
    }
}
