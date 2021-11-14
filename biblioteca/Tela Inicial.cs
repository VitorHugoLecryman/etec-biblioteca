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
    public partial class LoginSenhaForm1 : Form
    {

        public LoginSenhaForm1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void entrarbtn_Click(object sender, EventArgs e)
        {
            String nome = "";
            String senha = "";
            String Tipo = "";
            
            
            MySqlDataReader dr;
            MySqlDataReader de;
            MySqlCommand comando = new MySqlCommand();


            MySqlConnection conexao = new MySqlConnection("Server = localhost; Database = bd_biblioteca; User ID = root;");

            String SQL;
            SQL = "SELECT * FROM tb_Usuarios WHERE (ds_nome,ds_senha) = ('" + txtlogin.Text + "','" + txtsenha.Text + "')";
            String SQL1 = "SELECT ds_tipousuario FROM tb_Usuarios WHERE ds_nome = ('" + txtlogin.Text + "')";//;
            String SQL2 = "SELECT ds_tipousuario FROM tb_Usuarios WHERE ds_senha = ('" + txtsenha.Text + "')";//;





            conexao.Open();
            comando.Connection = conexao;
            comando.CommandText = SQL;

            dr = comando.ExecuteReader();

            while (dr.Read())
            {
                //O método GetString recebe do banco, dados do Tipo String
                nome = dr.GetString(0);
                senha = dr.GetString(1);
            }
            conexao.Close();

            conexao.Open();
            comando.Connection = conexao;
            comando.CommandText = SQL1;

            de = comando.ExecuteReader();

            while (de.Read())
            {
                
                Tipo = de.GetString(0);
               
            }
            conexao.Close();

           

            if (nome.ToString() == "" && senha.ToString() == "")
            {
                MessageBox.Show("Login Incorreto!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtlogin.Clear();
                txtsenha.Clear();
                txtlogin.Focus();
                //Se houver o registro no banco de dados, será executado o código abaixo
            }
            if (Tipo.ToString() == "A")
            {
                labellogin.Visible = false;
                labelsenha.Visible = false;
                txtlogin.Visible = false;
                txtsenha.Visible = false;
                btncadastrar.Visible = false;

                btnentrar.Visible = false;
                menuStrip1.Visible = true;
                panel1.Visible = false;

            }
            else 
            {
                MessageBox.Show("Login Incorreto!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtlogin.Clear();
                txtsenha.Clear();
                txtlogin.Focus();
            }
            //btnAlterar.Enabled = true;

            //Fechando a conexão
            conexao.Close();

        }

        private void livroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            groupBox1.Visible = true;
            
        }

       

        private void adcalunobtn_Click(object sender, EventArgs e)
        {
            var newForm = new Form8();
            newForm.Show();
        }
        private void RAfuncionariotxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void adcfuncionariosbtn_Click(object sender, EventArgs e)
        {
            
        }

        private void btncadastrar_Click(object sender, EventArgs e)
        {

        }

        private void btncadastrar_Click_1(object sender, EventArgs e)
        {
            var newForm = new Form2();
            newForm.Show();
        }

        private void cadastrarAlunoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            gbpUsuarios.Visible = true;

        }

        private void encerrarbtn_Click(object sender, EventArgs e)
        {
            txtFill.Clear();
            dataGridView1.Columns.Clear();
            gbpUsuarios.Visible = false;
        }

        private void cadastrarProfessorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            gpbGênero.Visible = true;
        }

        private void encerrar3btn_Click(object sender, EventArgs e)
        {
            gpbGênero.Visible = false;
        }

        private void priAnoradio_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void cmbboxperiodo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void empréstimoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var newForm = new Empréstimos();
            newForm.Show();
        }

        private void devoluçãoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var newForm = new Form5();
            newForm.Show();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }


       

        private void generoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            gpbGênero.Visible = true;
        }

        private void gpbautor_Enter(object sender, EventArgs e)
        {

        }

        private void editoraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GroupEditora.Visible = true;
        }

        private void autorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            gpbAutor1.Visible = true;
        }

        

        

        

        private void multaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            groupBox2.Visible = true;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            int RowAffect = 0;
            String sql = "insert into tb_vrmulta (dt_inicio,vl_multa) VALUES (current_date(),'" + txtmulta.Text + "')";
            String sql2 = "update tb_vrmulta set dt_final = current_date() where(ISNULL(dt_final) or dt_final = '0000-00-00');";
            MySqlCommand comando = new MySqlCommand();
            MySqlConnection conexao = new MySqlConnection("Server = localhost; Database = bd_biblioteca; User ID = root;");
            conexao.Open();
            comando.Connection = conexao;
            comando.CommandText = sql2;
            RowAffect = comando.ExecuteNonQuery();
            conexao.Close();

            conexao.Open();
            comando.Connection = conexao;
            comando.CommandText = sql;
            RowAffect = comando.ExecuteNonQuery();
            conexao.Close();

            if (RowAffect == 1)
            {
                MessageBox.Show("Multa Alterada com sucesso!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
            }
            else
            {
                MessageBox.Show("Multa não alterada!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            conexao.Close();
        }

       

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {


        }

        private void button9_Click(object sender, EventArgs e)
        {
            String Aluno = "A";
            DataTable dt = new DataTable();
            MySqlConnection conexao = new MySqlConnection("Server = localhost; Database = bd_biblioteca; User ID = root;");

            using (conexao)
            {
                MySqlCommand cmd = new MySqlCommand("select ds_TipoUsuario as \"ID Usuario\", nr_RM_RA as \"Nº Usuario\", ds_Nome as \"Nome\" from tb_usuarios where ds_TipoUsuario = '" + Aluno + "'", conexao);
                conexao.Open();
                MySqlDataReader reader = cmd.ExecuteReader();
                dt.Load(reader);
                if (dt.Rows.Count > 0)
                {
                    dataGridView1.DataSource = dt;
                }
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {

            DataTable dt = new DataTable();
            MySqlConnection conexao = new MySqlConnection("Server = localhost; Database = bd_biblioteca; User ID = root;");

            using (conexao)
            {
                if (rbdAluno.Checked)
                {
                    String Usuario = "L";
                    MySqlCommand cmd = new MySqlCommand("select ds_TipoUsuario as \"Tipo de Usuario\", nr_RM_RA as \"RM do Usuário\", ds_Nome as \"Nome\" from tb_usuarios where ds_TipoUsuario = '" + Usuario + "'", conexao);
                    conexao.Open();
                    MySqlDataReader reader = cmd.ExecuteReader();
                    dt.Load(reader);
                    if (dt.Rows.Count > 0)
                    {
                        dataGridView1.DataSource = dt;
                    }
                }
                if (rdbFuncionario.Checked)
                {
                    String Usuario = "F";
                    MySqlCommand cmd = new MySqlCommand("select ds_TipoUsuario as \"Tipo de Usuario\", nr_RM_RA as \"Nº Usuario\", ds_Nome as \"Nome\" from tb_usuarios where ds_TipoUsuario = '" + Usuario + "'", conexao);
                    conexao.Open();
                    MySqlDataReader reader = cmd.ExecuteReader();
                    dt.Load(reader);
                    if (dt.Rows.Count > 0)
                    {
                        dataGridView1.DataSource = dt;
                    }
                }

                if (rdbAdm.Checked)
                {
                    String Usuario = "A";
                    MySqlCommand cmd = new MySqlCommand("select ds_TipoUsuario as \"Tipo de Usuario\", nr_RM_RA as \"Nº Usuario\", ds_Nome as \"Nome\" from tb_usuarios where ds_TipoUsuario = '" + Usuario + "'", conexao);
                    conexao.Open();
                    MySqlDataReader reader = cmd.ExecuteReader();
                    dt.Load(reader);
                    if (dt.Rows.Count > 0)
                    {
                        dataGridView1.DataSource = dt;
                    }
                }

                if (rdbTodos.Checked)
                {

                    MySqlCommand cmd = new MySqlCommand("select ds_TipoUsuario as \"Tipo de Usuario\", nr_RM_RA as \"Nº Usuario\", ds_Nome as \"Nome\" from tb_usuarios order by ds_Nome asc", conexao);
                    conexao.Open();
                    MySqlDataReader reader = cmd.ExecuteReader();
                    dt.Load(reader);
                    if (dt.Rows.Count > 0)
                    {
                        dataGridView1.DataSource = dt;
                    }
                }
            }
        }

        private void button9_Click_1(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            MySqlConnection conexao = new MySqlConnection("Server = localhost; Database = bd_biblioteca; User ID = root;");
            if (rdbNome.Checked)
            {
                String Usuario = txtFill.Text;
                MySqlCommand cmd = new MySqlCommand("select ds_TipoUsuario as \"Tipo de Usuario\", nr_RM_RA as \"RM do Usuario\", ds_Nome as \"Nome\" from tb_usuarios where ds_Nome like '" + Usuario + "%'", conexao);
                conexao.Open();
                MySqlDataReader reader = cmd.ExecuteReader();
                dt.Load(reader);
                if (dt.Rows.Count > 0)
                {
                    dataGridView1.DataSource = dt;
                }
            }
            if (rdbRM.Checked)
            {
                String Usuario = txtFill.Text;
                MySqlCommand cmd = new MySqlCommand("select ds_TipoUsuario as \"Tipo de Usuario\", nr_RM_RA as \"RM do Usuario\", ds_Nome as \"Nome\" from tb_usuarios where nr_RM_RA like '" + Usuario + "%'", conexao);
                conexao.Open();
                MySqlDataReader reader = cmd.ExecuteReader();
                dt.Load(reader);
                if (dt.Rows.Count > 0)
                {
                    dataGridView1.DataSource = dt;
                }
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            MySqlConnection conexao = new MySqlConnection("Server = localhost; Database = bd_biblioteca; User ID = root;");

            using (conexao)
            {                                         
                    MySqlCommand cmd = new MySqlCommand("select ds_Genero as \"Gêneros\" from tb_genero order by ds_genero ASC;", conexao);
                    conexao.Open();
                    MySqlDataReader reader = cmd.ExecuteReader();
                    dt.Load(reader);
                    if (dt.Rows.Count > 0)
                    {
                        dataGridView2.DataSource = dt;
                    }
                }
            }

        private void button13_Click(object sender, EventArgs e)
        {
            gpbGênero.Visible = false;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            MySqlConnection conexao = new MySqlConnection("Server = localhost; Database = bd_biblioteca; User ID = root;");

            
                String Usuario = txtTipo.Text;
                MySqlCommand cmd = new MySqlCommand("select ds_Genero as \"Gêneros\" from tb_genero where ds_genero like '" + Usuario + "%'", conexao);
                conexao.Open();
                MySqlDataReader reader = cmd.ExecuteReader();
                dt.Load(reader);

                if (dt.Rows.Count > 0)
                {
                    dataGridView2.DataSource = dt;
                }
                    
        }

        private void button14_Click(object sender, EventArgs e)
        {
            var newForm = new Form9();
            newForm.Show();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            GroupEditora.Visible = false;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            MySqlConnection conexao = new MySqlConnection("Server = localhost; Database = bd_biblioteca; User ID = root;");

            using (conexao)
            {
                MySqlCommand cmd = new MySqlCommand("select ds_NomeEditora as \"Editoras\" from tb_editora order by ds_NomeEditora ASC;", conexao);
                conexao.Open();
                MySqlDataReader reader = cmd.ExecuteReader();
                dt.Load(reader);
                if (dt.Rows.Count > 0)
                {
                    dataGridView3.DataSource = dt;
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            MySqlConnection conexao = new MySqlConnection("Server = localhost; Database = bd_biblioteca; User ID = root;");

            
                String Usuario = txtEditora1.Text;
                MySqlCommand cmd = new MySqlCommand("select ds_NomeEditora as \"Editoras\" from tb_editora where ds_NomeEditora like '" + Usuario + "%'", conexao);
                conexao.Open();
                MySqlDataReader reader = cmd.ExecuteReader();
                dt.Load(reader);

                if (dt.Rows.Count > 0)
                {
                    dataGridView3.DataSource = dt;
                }
            
        }

        private void button16_Click(object sender, EventArgs e)
        {
            var newForm = new Form1();
            newForm.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            MySqlConnection conexao = new MySqlConnection("Server = localhost; Database = bd_biblioteca; User ID = root;");

            using (conexao)
            {
                MySqlCommand cmd = new MySqlCommand("select ds_NomeAutor as \"Autores\" from tb_autor order by ds_NomeAutor ASC;", conexao);
                conexao.Open();
                MySqlDataReader reader = cmd.ExecuteReader();
                dt.Load(reader);
                if (dt.Rows.Count > 0)
                {
                    dataGridView4.DataSource = dt;
                }
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            MySqlConnection conexao = new MySqlConnection("Server = localhost; Database = bd_biblioteca; User ID = root;");

            
                String Usuario = TxtAutor1.Text;
                MySqlCommand cmd = new MySqlCommand("select ds_NomeAutor as \"Autores\" from tb_autor where ds_Nomeautor like '" + Usuario + "%'", conexao);
                conexao.Open();
                MySqlDataReader reader = cmd.ExecuteReader();
                dt.Load(reader);

                if (dt.Rows.Count > 0)
                {
                    dataGridView4.DataSource = dt;
                }
                     
        }

        private void button17_Click(object sender, EventArgs e)
        {
            TxtAutor1.Clear();
            dataGridView4.Columns.Clear();
            gpbAutor1.Visible = false;
        }

        private void button18_Click(object sender, EventArgs e)
        {
            var newForm = new Form4();
            newForm.Show();
        }

        private void button19_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            MySqlConnection conexao = new MySqlConnection("Server = localhost; Database = bd_biblioteca; User ID = root;");

            using (conexao)
            {
                MySqlCommand cmd = new MySqlCommand(
                    @"select  
                    LI.nr_Tombo as 'Nº Tombo',
                    LI.ds_NomeLivro as 'Nome do Livro',
                    LI.nr_AnoLivro as 'Ano do Livro',
                    
                    LI.Status_Livro as 'Status do Livro',
                    AU.ds_NomeAutor as 'Nome do Autor',    
                    GE.ds_Genero as 'Gênero',
                    ED.ds_NomeEditora 'Editora'
                    
                  from tb_livros as LI
                  inner join tb_autor as AU ON (AU.id_Autor = LI.id_AutorLivro)
                  inner join tb_genero as GE on (GE.id_Genero = LI.id_GeneroLivro) 
                  inner join tb_editora as ED on (ED.id_Editora = LI.id_EditoraLivro)
                 
                
                ORDER BY LI.ds_NomeLivro;", conexao);
                conexao.Open();
                MySqlDataReader reader = cmd.ExecuteReader();
                dt.Load(reader);
                if (dt.Rows.Count > 0)
                {
                    dataGridView5.DataSource = dt;
                }
            }
        }

        private void button20_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            MySqlConnection conexao = new MySqlConnection("Server = localhost; Database = bd_biblioteca; User ID = root;");

            if (rdbTombo.Checked)
            {
                String Usuario = txtLivro.Text;
                MySqlCommand cmd = new MySqlCommand("select LI.nr_Tombo as 'Nº Tombo',LI.ds_NomeLivro as 'Nome do Livro', LI.nr_AnoLivro as 'Ano do Livro',LI.Status_Livro as 'Status do Livro', AU.ds_NomeAutor as 'Nome do Autor', GE.ds_Genero as 'Gênero', ED.ds_NomeEditora as 'Editora' from tb_livros as LI inner join tb_autor as AU ON (AU.id_Autor = LI.id_AutorLivro) inner join tb_genero as GE on (GE.id_Genero = LI.id_GeneroLivro) inner join tb_editora as ED on (ED.id_Editora = LI.id_EditoraLivro) where LI.nr_tombo like'" + Usuario + "%' ORDER BY LI.ds_NomeLivro ASC;", conexao);
                conexao.Open();
                MySqlDataReader reader = cmd.ExecuteReader();
                dt.Load(reader);

                if (dt.Rows.Count > 0)
                {
                    dataGridView5.Columns.Clear();
                    dataGridView5.DataSource = dt;
                }
            }

            if (rdbNome3.Checked)
            {
                String Usuario = txtLivro.Text;
                MySqlCommand cmd = new MySqlCommand("select LI.nr_Tombo as 'Nº Tombo',LI.ds_NomeLivro as 'Nome do Livro', LI.nr_AnoLivro as 'Ano do Livro',LI.Status_Livro as 'Status do Livro', AU.ds_NomeAutor as 'Nome do Autor', GE.ds_Genero as 'Gênero', ED.ds_NomeEditora as 'Editora' from tb_livros as LI inner join tb_autor as AU ON (AU.id_Autor = LI.id_AutorLivro) inner join tb_genero as GE on (GE.id_Genero = LI.id_GeneroLivro) inner join tb_editora as ED on (ED.id_Editora = LI.id_EditoraLivro) where LI.ds_nomelivro like'" + Usuario + "%' ORDER BY LI.ds_NomeLivro ASC;", conexao);
                conexao.Open();
                MySqlDataReader reader = cmd.ExecuteReader();
                dt.Load(reader);

                if (dt.Rows.Count > 0)
                {
                    dataGridView5.Columns.Clear();
                    dataGridView5.DataSource = dt;
                }

            }

            if (rdbAutor3.Checked)
            {
                String Usuario = txtLivro.Text;
                MySqlCommand cmd = new MySqlCommand("select LI.nr_Tombo as 'Nº Tombo',LI.ds_NomeLivro as 'Nome do Livro', LI.nr_AnoLivro as 'Ano do Livro',LI.Status_Livro as 'Status do Livro', AU.ds_NomeAutor as 'Nome do Autor', GE.ds_Genero as 'Gênero', ED.ds_NomeEditora as 'Editora' from tb_livros as LI inner join tb_autor as AU ON (AU.id_Autor = LI.id_AutorLivro) inner join tb_genero as GE on (GE.id_Genero = LI.id_GeneroLivro) inner join tb_editora as ED on (ED.id_Editora = LI.id_EditoraLivro) where AU.ds_nomeautor like'" + Usuario + "%' ORDER BY LI.ds_NomeLivro ASC;", conexao);
                conexao.Open();
                MySqlDataReader reader = cmd.ExecuteReader();
                dt.Load(reader);

                if (dt.Rows.Count > 0)
                {
                    dataGridView5.Columns.Clear();
                    dataGridView5.DataSource = dt;
                }

            }

            if (rdbGenero.Checked)
            {
                String Usuario = txtLivro.Text;
                MySqlCommand cmd = new MySqlCommand("select LI.nr_Tombo as 'Nº Tombo',LI.ds_NomeLivro as 'Nome do Livro', LI.nr_AnoLivro as 'Ano do Livro',LI.Status_Livro as 'Status do Livro', AU.ds_NomeAutor as 'Nome do Autor', GE.ds_Genero as 'Gênero', ED.ds_NomeEditora as 'Editora' from tb_livros as LI inner join tb_autor as AU ON (AU.id_Autor = LI.id_AutorLivro) inner join tb_genero as GE on (GE.id_Genero = LI.id_GeneroLivro) inner join tb_editora as ED on (ED.id_Editora = LI.id_EditoraLivro) where GE.ds_genero like'" + Usuario + "%' ORDER BY LI.ds_NomeLivro ASC;", conexao);
                conexao.Open();
                MySqlDataReader reader = cmd.ExecuteReader();
                dt.Load(reader);

                if (dt.Rows.Count > 0)
                {
                    dataGridView5.Columns.Clear();
                    dataGridView5.DataSource = dt;
                }

            }

            if (radioButton5.Checked)
            {
                String Usuario = txtLivro.Text;
                MySqlCommand cmd = new MySqlCommand("select LI.nr_Tombo as 'Nº Tombo',LI.ds_NomeLivro as 'Nome do Livro', LI.nr_AnoLivro as 'Ano do Livro',LI.Status_Livro as 'Status do Livro', AU.ds_NomeAutor as 'Nome do Autor', GE.ds_Genero as 'Gênero', ED.ds_NomeEditora as 'Editora' from tb_livros as LI inner join tb_autor as AU ON (AU.id_Autor = LI.id_AutorLivro) inner join tb_genero as GE on (GE.id_Genero = LI.id_GeneroLivro) inner join tb_editora as ED on (ED.id_Editora = LI.id_EditoraLivro) where ED.ds_NomeEditora like'" + Usuario + "%' ORDER BY LI.ds_NomeLivro ASC;", conexao);
                conexao.Open();
                MySqlDataReader reader = cmd.ExecuteReader();
                dt.Load(reader);

                if (dt.Rows.Count > 0)
                {
                    dataGridView5.Columns.Clear();
                    dataGridView5.DataSource = dt;
                }

            }
        }

        private void button22_Click(object sender, EventArgs e)
        {
            var newForm = new Form3();
            newForm.Show();
        }

        private void button21_Click(object sender, EventArgs e)
        {
            groupBox1.Visible = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            MySqlConnection conexao = new MySqlConnection("Server = localhost; Database = bd_biblioteca; User ID = root;");

            using (conexao)
            {
                MySqlCommand cmd = new MySqlCommand("select * from tb_vrmulta");
                conexao.Open();
                MySqlDataReader reader = cmd.ExecuteReader();
                dt.Load(reader);
                if (dt.Rows.Count > 0)
                {
                    dataGridView8.DataSource = dt;
                }
            }
        }

        private void button29_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            MySqlConnection conexao = new MySqlConnection("Server = localhost; Database = bd_biblioteca; User ID = root;");

            using (conexao)
            {
                MySqlCommand cmd = new MySqlCommand("select dt_inicio as 'Data Inicial',dt_final 'Data Final',vl_multa 'Valor da multa' from tb_vrmulta",conexao);
                conexao.Open();
                MySqlDataReader reader = cmd.ExecuteReader();
                dt.Load(reader);
                if (dt.Rows.Count > 0)
                {
                    dataGridView8.DataSource = dt;
                }
            }
        }

        private void button26_Click(object sender, EventArgs e)
        {
            int RowAffect = 0;
            String sql = "insert into tb_vrmulta (dt_inicio,vl_multa) VALUES (current_date(),'" + txtmulta.Text + "')";
            String sql2 = "update tb_vrmulta set dt_final = current_date() where(ISNULL(dt_final) or dt_final = '0000-00-00');";
            MySqlCommand comando = new MySqlCommand();
            MySqlConnection conexao = new MySqlConnection("Server = localhost; Database = bd_biblioteca; User ID = root;");
            conexao.Open();
            comando.Connection = conexao;
            comando.CommandText = sql2;
            RowAffect = comando.ExecuteNonQuery();
            conexao.Close();

            conexao.Open();
            comando.Connection = conexao;
            comando.CommandText = sql;
            RowAffect = comando.ExecuteNonQuery();
            conexao.Close();

            if (RowAffect == 1)
            {
                MessageBox.Show("Multa Alterada com sucesso!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                MessageBox.Show("Multa não alterada!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            conexao.Close();
        }

        private void button7_Click_1(object sender, EventArgs e)
        {
            label15.Visible = true;
            txtmulta.Visible = true;
            button26.Visible = true;

        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            groupBox2.Visible = false;
        }

        private void sobreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var newForm = new AboutBox1();
            newForm.Show();

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button27_Click(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
    }
    


