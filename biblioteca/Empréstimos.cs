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
    public partial class Empréstimos : Form
    {
        MySqlCommand comando = new MySqlCommand();
        public Empréstimos()
        {
            InitializeComponent();
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btbConfirmar_Click(object sender, EventArgs e)
        {
            
            String sqlrmveri;
            String sqlCountLivroaluno;
            String sqlIdUser;
            MySqlDataReader autor;

            string nome = "";
            string user = "";
            string userid = "";
            string contadorlivro = "";
            int count = 0;
            MySqlConnection conexao = new MySqlConnection("Server = localhost; Database = bd_biblioteca; User ID = root;");

            sqlrmveri = "SELECT ds_TipoUsuario from TB_USUARIOS WHERE NR_RM_RA  = " + "'" + txtrm.Text + "'" + ";";
            sqlIdUser = "SELECT id_usuario from TB_USUARIOS WHERE NR_RM_RA  = " + "'" + txtrm.Text + "'" + ";";
            

            conexao.Open();
            comando.Connection = conexao;
            comando.CommandText = sqlrmveri;
            autor = comando.ExecuteReader();

            while (autor.Read())
            {
                user = autor.GetString(0);
            }
            conexao.Close();

            conexao.Open();
            comando.Connection = conexao;
            comando.CommandText = sqlIdUser;
            autor = comando.ExecuteReader();

            while (autor.Read())
            {
                userid = autor.GetString(0);
            }
            conexao.Close();

            conexao.Open();
            String sql = "SELECT ds_nome from TB_USUARIOS WHERE NR_RM_RA = " + "'" + txtrm.Text + "'" + "; ";
            comando.Connection = conexao;
            comando.CommandText = sql;
            autor = comando.ExecuteReader();

            while (autor.Read())
            {
                nome = autor.GetString(0);
            }
            conexao.Close();

            conexao.Open();
            sqlCountLivroaluno = "SELECT COUNT(id_livro) FROM tb_emp_devol where id_usuario = '" + userid + "' and Isnull(dt_Devol)";
            comando.Connection = conexao;
            comando.CommandText = sqlCountLivroaluno;
            autor = comando.ExecuteReader();

            while (autor.Read())
            {
                contadorlivro = autor.GetString(0);
            }
            conexao.Close();

            count = int.Parse(contadorlivro);

            if (user == "L")
            {
                if (count < 1)
                {
                    
                    GrpbDadosUser.Visible = true;
                    txtUser.Text = "Aluno";
                    txtUserRm.Text = txtrm.Text;
                    txtNome.Text = nome;
                    label4.Visible = true;
                    txtlivroempres.Visible = true;
                    btbEmprestar.Visible = true;
                    button1.Visible = true;
                    
                    txtrm.Visible = true;
                    labellogin.Visible = true;
                    btbConfirmar.Visible = false;
                    txtrm.Visible = false;
                    labellogin.Visible = false;
                }
                else if (count >= 1)
                {
                    MessageBox.Show("Este usuario já está com: " + count + " livro.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }

            if (user == "F" ) 
            {
                if (count < 2)
                {
                    
                    GrpbDadosUser.Visible = true;
                    txtUser.Text = "Professor";
                    txtUserRm.Text = txtrm.Text;
                    txtNome.Text = nome;
                    label4.Visible = true;
                    txtlivroempres.Visible = true;
                    btbEmprestar.Visible = true;
                    button1.Visible = true;
                   
                    txtrm.Visible = true;
                    labellogin.Visible = true;
                    btbConfirmar.Visible = false;
                    txtrm.Visible = false;
                    labellogin.Visible = false;
                }

            
                else if (count >= 2)
                {
                    MessageBox.Show("Este usuario já está com: " + count + " livro.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
            if (user == "A")
            {
                if (count < 2)
                {
                    
                    GrpbDadosUser.Visible = true;
                    txtUser.Text = "Administrador";
                    txtUserRm.Text = txtrm.Text;
                    txtNome.Text = nome;
                    label4.Visible = true;
                    txtlivroempres.Visible = true;
                    btbEmprestar.Visible = true;
                    button1.Visible = true;
                    
                    txtrm.Visible = true;
                    labellogin.Visible = true;
                    btbConfirmar.Visible = false;
                    txtrm.Visible = false;
                    labellogin.Visible = false;
                }
                else if (count >= 2)
                {
                    MessageBox.Show("Este usuario já está com: " + count + " livro.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }


        }

        private void btbEmprestar_Click(object sender, EventArgs e)
        {
            int RowAffect = 0;
            string userid = "";
            string idlivro = "";
            string idexemplar = "";
            string qtd = "";
            decimal qtdint = 0;
            string contadorlivro = "";

            MySqlConnection conexao = new MySqlConnection("Server = localhost; Database = bd_biblioteca; User ID = root;");
            MySqlDataReader autor;

            String sqlrmveri = "SELECT ds_TipoUsuario from TB_USUARIOS WHERE NR_RM_RA  = " + "'" + txtrm.Text + "'" + ";";
            String sqlIdUser = "SELECT id_usuario from TB_USUARIOS WHERE NR_RM_RA  = " + "'" + txtrm.Text + "'" + ";";
            String sqlIdLivro = "SELECT id_livro from tb_livros WHERE nr_tombo  = " + "'" + txtlivroempres.Text + "'" + ";";
            String exemplarid = "SELECT id_exemplares from tb_livros WHERE nr_tombo  = " + "'" + txtlivroempres.Text + "'" + ";";





            conexao.Open();
            comando.Connection = conexao;
            comando.CommandText = sqlIdUser;
            autor = comando.ExecuteReader();

            while (autor.Read())
            {
                userid = autor.GetString(0);
            }
            conexao.Close();


            conexao.Open();
           
            comando.Connection = conexao;
            comando.CommandText = exemplarid;
            autor = comando.ExecuteReader();

            while (autor.Read())
            {
                idexemplar = autor.GetString(0);
            }

            conexao.Close();

            conexao.Open();
            comando.Connection = conexao;
            comando.CommandText = sqlIdLivro;
            autor = comando.ExecuteReader();

            while (autor.Read())
            {
                idlivro = autor.GetString(0);
            }
            conexao.Close();

            conexao.Open();
            String exemplar = "select qt_disp from tb_exemplares where id_exemplares =" + "'" + idexemplar + "'" + ";";
            comando.Connection = conexao;
            comando.CommandText = exemplar;
            autor = comando.ExecuteReader();

            while (autor.Read())
            {
                qtd = autor.GetString(0);
            }

            qtdint = decimal.Parse(qtd);

            conexao.Close();
            conexao.Open();
            String sqlCountLivroaluno = "SELECT COUNT(id_livro) FROM tb_emp_devol where id_usuario = '" + userid + "' and Isnull(dt_Devol)";
            comando.Connection = conexao;
            comando.CommandText = sqlCountLivroaluno;
            autor = comando.ExecuteReader();

            while (autor.Read())
            {
                contadorlivro = autor.GetString(0);
            }
            conexao.Close();
            int count;
            count = int.Parse(contadorlivro);

            conexao.Open();
            string user = "";
            comando.Connection = conexao;
            comando.CommandText = sqlrmveri;
            autor = comando.ExecuteReader();

            while (autor.Read())
            {
                user = autor.GetString(0);
            }
            conexao.Close();




            if (user == "L")
            {
                if (count < 1)
                {



                    if (qtdint >= 1)
                    {
                        conexao.Open();
                        String sqlempres = "Insert into tb_emp_devol(id_livro,id_usuario,dt_emprest) values('" + idlivro + "','" + userid + "',current_date());";
                        comando.Connection = conexao;
                        comando.CommandText = sqlempres;
                        int num = -1;
                        RowAffect = comando.ExecuteNonQuery();

                        if (RowAffect == 1)
                        {
                            MessageBox.Show("Emprestimo realizado com sucesso", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            String sqlqtd = "update tb_exemplares set QT_DISP = QT_DISP " + num + " where id_exemplares = " + idexemplar + ";";
                            comando.Connection = conexao;
                            comando.CommandText = sqlqtd;
                            RowAffect = comando.ExecuteNonQuery();
                            conexao.Close();
                            if (qtdint == 1)
                            {

                                conexao.Open();
                                String sql = "Update tb_livros set Status_Livro ='I' where id_exemplares = " + idexemplar + "";
                                comando.Connection = conexao;
                                comando.CommandText = sql;
                                RowAffect = comando.ExecuteNonQuery();
                                conexao.Close();
                            }
                        }

                        else
                        {
                            MessageBox.Show("Emprestimo não realizado!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        conexao.Close();
                    }
                    else
                    {
                        MessageBox.Show("Este livro não está disponível!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }

                }
                else if (count >= 1)
                {
                    MessageBox.Show("Este usuario já está com: " + count + " livro.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }

            if (user == "F")
            {
                if (count < 2)
                {

                    if (qtdint >= 1)
                    {
                        conexao.Open();
                        String sqlempres = "Insert into tb_emp_devol(id_livro,id_usuario,dt_emprest) values('" + idlivro + "','" + userid + "',current_date());";
                        comando.Connection = conexao;
                        comando.CommandText = sqlempres;
                        int num = -1;
                        RowAffect = comando.ExecuteNonQuery();

                        if (RowAffect == 1)
                        {
                            MessageBox.Show("Emprestimo realizado com sucesso", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            String sqlqtd = "update tb_exemplares set QT_DISP = QT_DISP " + num + " where id_exemplares = " + idexemplar + ";";
                            comando.Connection = conexao;
                            comando.CommandText = sqlqtd;
                            RowAffect = comando.ExecuteNonQuery();
                            conexao.Close();
                            if (qtdint == 1)
                            {

                                conexao.Open();
                                String sql = "Update tb_livros set Status_Livro ='I' where id_exemplares = " + idexemplar + "";
                                comando.Connection = conexao;
                                comando.CommandText = sql;
                                RowAffect = comando.ExecuteNonQuery();
                                conexao.Close();
                            }
                        }

                        else
                        {
                            MessageBox.Show("Emprestimo não realizado!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        conexao.Close();
                    }
                    else
                    {
                        MessageBox.Show("Este livro não está disponível!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }

                }
                else if (count >= 2)
                {
                    MessageBox.Show("Este usuario já está com: " + count + " livro.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }

            if (user == "A")
            {
                if (count < 2)
                {



                    if (qtdint >= 1)
                    {
                        conexao.Open();
                        String sqlempres = "Insert into tb_emp_devol(id_livro,id_usuario,dt_emprest) values('" + idlivro + "','" + userid + "',current_date());";
                        comando.Connection = conexao;
                        comando.CommandText = sqlempres;
                        int num = -1;
                        RowAffect = comando.ExecuteNonQuery();

                        if (RowAffect == 1)
                        {
                            MessageBox.Show("Emprestimo realizado com sucesso", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            String sqlqtd = "update tb_exemplares set QT_DISP = QT_DISP " + num + " where id_exemplares = " + idexemplar + ";";
                            comando.Connection = conexao;
                            comando.CommandText = sqlqtd;
                            RowAffect = comando.ExecuteNonQuery();
                            conexao.Close();
                            if (qtdint == 1)
                            {

                                conexao.Open();
                                String sql = "Update tb_livros set Status_Livro ='I' where id_exemplares = " + idexemplar + "";
                                comando.Connection = conexao;
                                comando.CommandText = sql;
                                RowAffect = comando.ExecuteNonQuery();
                                conexao.Close();
                            }
                        }

                        else
                        {
                            MessageBox.Show("Emprestimo não realizado!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        conexao.Close();
                    }
                    else
                    {
                        MessageBox.Show("Este livro não está disponível!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }

                }
                else if (count >= 2)
                {
                    MessageBox.Show("Este usuario já está com: " + count + " livro.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtrm_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if (!Char.IsDigit(ch) && ch != 8 && ch != 46)
            {
                e.Handled = true;
            }
        }

        private void txtRmEmpre_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if (!Char.IsDigit(ch) && ch != 8 && ch != 46)
            {
                e.Handled = true;
            }
        }

        private void txtlivroempres_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if (!Char.IsDigit(ch) && ch != 8 && ch != 46)
            {
                e.Handled = true;
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
                    }
    }
}
