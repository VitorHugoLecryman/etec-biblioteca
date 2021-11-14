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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void num_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            MySqlCommand comando = new MySqlCommand();
           
            String sqlidautor;
            String sqlidgenero;
            String sqlidEditora;
            String sqltombo;
            String sqlidexemplar;
            String sqlinsertlivro;
            MySqlDataReader autor;


            string generoid ="";
            string editoraid= "";          
            string id_autor = "";
            int idexemplar = 0;
            int exemplar = 0;
            int nrtombo = 0;
            int tombo = 0;
            string status = "D";
            int RowAffect = 0;
            string qtd = txtQtd.Text;
            string dps = txtQtd.Text;
            

            MySqlConnection conexao = new MySqlConnection("Server = localhost; Database = bd_biblioteca; User ID = root;");


            sqlidexemplar = "select MAX(id_Exemplares) from tb_livros;";
            sqltombo = "select MAX(nr_Tombo) from tb_livros;";
            


            conexao.Open();          
            object autores = cmbauto.SelectedItem;
            sqlidautor = "SELECT * FROM tb_autor where ds_NomeAutor = " + "'" + autores + "'" + ";";
            comando.Connection = conexao;
            comando.CommandText = sqlidautor;
            autor = comando.ExecuteReader();

            while (autor.Read())
            {
                id_autor = autor.GetString(0);
            }
            
            conexao.Close();

            conexao.Open();
            comando.Connection = conexao;
            comando.CommandText = sqltombo;
            autor = comando.ExecuteReader();

            while (autor.Read())
            {
                nrtombo = autor.GetInt32(0);
            }
            tombo = nrtombo +  1;

            conexao.Close();

            conexao.Open();
            comando.Connection = conexao;
            comando.CommandText = sqlidexemplar;
            autor = comando.ExecuteReader();

            while (autor.Read())
            {
                idexemplar = autor.GetInt32(0);
            }
            exemplar = idexemplar + 1;
            conexao.Close();

            conexao.Open();
            object generos = cmbgenero.SelectedItem;
            sqlidgenero = "SELECT * FROM tb_genero where ds_genero = " + "'" + generos + "'" + ";";
            comando.Connection = conexao;
            comando.CommandText = sqlidgenero;
            autor = comando.ExecuteReader();

            while (autor.Read())
            {
                generoid = autor.GetString(0);
            }
            conexao.Close();

            conexao.Open();
            object editoras = cmbeditora.SelectedItem;
            sqlidEditora = "SELECT * FROM tb_editora where ds_nomeeditora = " + "'" + editoras + "'" + ";";
            comando.Connection = conexao;
            comando.CommandText = sqlidEditora;
            autor = comando.ExecuteReader();
            
            while (autor.Read())
            {
                editoraid = autor.GetString(0);
            }            
            conexao.Close();
                        
            sqlinsertlivro = "INSERT INTO tb_livros(nr_tombo,nr_isbn,ds_nomelivro,id_autorlivro,nr_anolivro,id_generolivro,id_editoralivro,id_exemplares,status_livro) values ('"+tombo+"','" + txtISBN.Text + "','" + txtNmLivro.Text + "','" + id_autor + "','" + txtAno.Text + "','" + generoid + "','" + editoraid + "','"+exemplar+"','" + status + "')";
            conexao.Open();
            comando.Connection = conexao;
            comando.CommandText = sqlinsertlivro;
            RowAffect = comando.ExecuteNonQuery();
            conexao.Close();

            conexao.Open();
            String sqlExemplar = ("INSERT INTO tb_exemplares(id_exemplares,qt_total,qt_disp) values ('" + exemplar + "','" + qtd + "','" + dps + "');");
            comando.Connection = conexao;
           
            comando.CommandText = sqlExemplar;
            RowAffect = comando.ExecuteNonQuery();
            conexao.Close();
            if (RowAffect == 1)
            {
                MessageBox.Show("Livro cadastrado com sucesso!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtNmLivro.Clear();
                
                txtISBN.Clear();
                txtAno.Clear();
                
                txtQtd.Clear();
                
            }
            else
            {
                MessageBox.Show("Cadastro não realizado!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            conexao.Close();
        }

        private void txtQtd_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if (!Char.IsDigit(ch) && ch != 8 && ch != 46)
            {
                e.Handled = true;
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            

        }

        private void button3_Click(object sender, EventArgs e)
        {
            int RowAffect = 0;
            MySqlConnection conexao = new MySqlConnection("Server = localhost; Database = bd_biblioteca; User ID = root;");
            MySqlCommand comando = new MySqlCommand();
            DataTable dt = new DataTable();

            using (conexao)
            {
                String cmd1 = "CREATE TEMPORARY TABLE temp_table AS select nr_tombo,id_exemplares from tb_livros;";
                MySqlCommand command1 = new MySqlCommand();
                MySqlCommand cmd = new MySqlCommand("SELECT * FROM temp_table;",conexao);


                conexao.Open();
                comando.Connection = conexao;
                comando.CommandText = cmd1;
                RowAffect = comando.ExecuteNonQuery();
                conexao.Close();

                
            }
            conexao.Open();
            string selectquery = "select * from bd_biblioteca.tb_autor order by ds_NomeAutor asc; ";
            MySqlCommand command = new MySqlCommand(selectquery, conexao);
            MySqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                cmbauto.Items.Add(reader.GetString("ds_nomeautor"));
            }
            conexao.Close();

            conexao.Open();
            string genero = "select * from bd_biblioteca.tb_genero order by ds_Genero asc;";
            MySqlCommand commando = new MySqlCommand(genero, conexao);
            MySqlDataReader leitor = commando.ExecuteReader();
            while (leitor.Read())
            {
                cmbgenero.Items.Add(leitor.GetString("ds_Genero"));
            }
            conexao.Close();

            conexao.Open();
            string editora = "select * from bd_biblioteca.tb_editora order by ds_NomeEditora asc";
            MySqlCommand make = new MySqlCommand(editora, conexao);
            MySqlDataReader leite = make.ExecuteReader();
            while (leite.Read())
            {
                cmbeditora.Items.Add(leite.GetString("ds_NomeEditora"));
            }
            conexao.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtQtd_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtExemplar_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtISBN_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNrTombo_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtAno_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtExemplar_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if (!Char.IsDigit(ch) && ch != 8 && ch != 46)
            {
                e.Handled = true;
            }
        }

        private void txtAno_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if (!Char.IsDigit(ch) && ch != 8 && ch != 46)
            {
                e.Handled = true;
            }
        }

        private void txtISBN_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if (!Char.IsDigit(ch) && ch != 8 && ch != 46)
            {
                e.Handled = true;
            }
        }

        private void txtNrTombo_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if (!Char.IsDigit(ch) && ch != 8 && ch != 46)
            {
                e.Handled = true;
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }
    }
}
