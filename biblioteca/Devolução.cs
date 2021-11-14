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
    public partial class Devolução : Form
    {
        MySqlCommand comando = new MySqlCommand();
        public Devolução()
        {
            InitializeComponent();
        }

        private void btbEmprestar_Click(object sender, EventArgs e)
        {
            MySqlConnection conexao = new MySqlConnection("Server = localhost; Database = bd_biblioteca; User ID = root;");
            MySqlDataReader autor;

            
            


            int daysneg = 0;
            int days = 0;
            string userid = "";
            string idlivro = "";
            decimal dias = 0;
            string idregistro = "";
            string multa = "";
            string idexemplar = "";
            decimal multaint = 0;
            decimal valortt = 0;
            string qtd = "";
            decimal qtdint = 0;

            conexao.Open();
            String sqlIdUser = "SELECT id_usuario from TB_USUARIOS WHERE NR_RM_RA  = " + "'" + txtRmDevol.Text + "'" + ";";

            comando.Connection = conexao;
            comando.CommandText = sqlIdUser;
            autor = comando.ExecuteReader();

            while (autor.Read())
            {
                userid = autor.GetString(0);
            }
            conexao.Close();

            conexao.Open();
            String exemplarid = "SELECT id_exemplares from tb_livros WHERE nr_tombo  = " + "'" + txtlivrodevol.Text + "'" + ";";
            comando.Connection = conexao;
            comando.CommandText = exemplarid;
            autor = comando.ExecuteReader();

            while (autor.Read())
            {
                idexemplar = autor.GetString(0);
            }

            conexao.Close();


            conexao.Open();
            String sqlIdLivro = "SELECT id_livro from tb_livros WHERE nr_tombo  = " + "'" + txtlivrodevol.Text + "'" + ";"; ;
            comando.Connection = conexao;
            comando.CommandText = sqlIdLivro;
            autor = comando.ExecuteReader();

            while (autor.Read())
            {
                idlivro = autor.GetString(0);
            }
            conexao.Close();

            conexao.Open();
            String sqlIdRegistro = "SELECT id_registro from tb_emp_devol WHERE id_livro  = " + "'" + idlivro + "'" + ";";
            comando.Connection = conexao;
            comando.CommandText = sqlIdRegistro;
            autor = comando.ExecuteReader();

            while (autor.Read())
            {
                idregistro = autor.GetString(0);
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

                
           
            conexao.Close();

            conexao.Open();
            String sqldias = "select (datediff(current_date(), dt_Emprest)-15) as QTD_DIAS from tb_emp_devol where id_usuario = " + "'" + userid + "'" + "";
          
            comando.Connection = conexao;
            comando.CommandText = sqldias;
            autor = comando.ExecuteReader();

            while (autor.Read())
            {
                dias = autor.GetDecimal(0);
            }
            conexao.Close();
            

            if (userid == "" || qtd == "" || dias == 0)
            {
                MessageBox.Show("Este registro não existe", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            if (dias <= 15)
            {

                DialogResult Result = MessageBox.Show("Deseja realizar esta devolução ?","Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (Result == DialogResult.Yes)
                {

                    conexao.Open();
                    int RowAffect = 0;

                    String SQL = "INSERT INTO tb_cobrança (id_registro,vl_valorcobrado,qt_Qtdias) VALUES ('" + idregistro + "','" + 0 + "','" + days + "')";


                    comando.Connection = conexao;
                    comando.CommandText = SQL;

                    RowAffect = comando.ExecuteNonQuery();
                    if (RowAffect == 1)
                    {

                        MessageBox.Show("Devolução realizada com sucesso", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        String sqlUpdate = "update tb_emp_devol set dt_devol = current_date() where id_Usuario = " + userid + " and id_livro =" + idlivro + ";";
                        comando.Connection = conexao;
                        comando.CommandText = sqlUpdate;
                        RowAffect = comando.ExecuteNonQuery();
                        conexao.Close();

                        conexao.Open();
                        String sql = "Update tb_livros set Status_Livro ='D' where id_exemplares = " + idexemplar + "";
                        comando.Connection = conexao;
                        comando.CommandText = sql;
                        RowAffect = comando.ExecuteNonQuery();
                        conexao.Close();

                        conexao.Open();
                        int vai = 0;
                        String sqlqtd = "update tb_exemplares set QT_DISP = QT_DISP +1 where id_exemplares = " + idexemplar + ";";
                        comando.Connection = conexao;
                        comando.CommandText = sqlqtd;
                        vai = comando.ExecuteNonQuery();
                        conexao.Close();



                    }

                    else
                    {
                        MessageBox.Show("Devolução não realizada!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    conexao.Close();
                }
                else if (Result == DialogResult.No)
                {
                    MessageBox.Show("Retorne o livro no período que ainda lhe resta.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }



            if (dias > 15)
            {
                conexao.Open();
                String sqlmulta = "select vl_multa from tb_vrmulta WHERE(ISNULL(dt_final) or dt_final= '0000-00-00')";
                comando.Connection = conexao;
                comando.CommandText = sqlmulta;
                autor = comando.ExecuteReader();

                while (autor.Read())
                {
                    multa = autor.GetString(0);
                }

                multaint = Convert.ToDecimal(multa);
                conexao.Close();

                valortt = dias * multaint;
                string valor = Convert.ToString(valortt);



                DialogResult Result = MessageBox.Show("Multado por atraso pela devolução,Pague: R$" + valor.Replace(",", "."), "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                if (Result == DialogResult.Yes)
                {
                    int RowAffect = 0;
                    conexao.Open();

                    String SQL = "INSERT INTO tb_cobrança(id_registro,qt_Qtdias, vl_valorcobrado) VALUES ('" + idregistro + "','" + dias + "','" + valor.Replace(",", ".") + "');";

                    comando.Connection = conexao;

                    comando.CommandText = SQL;

                    RowAffect = comando.ExecuteNonQuery();
                    if (RowAffect == 1)
                    {
                        MessageBox.Show("Devolução realizada com sucesso", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        String sql = "Update tb_livros set Status_Livro ='D' where id_exemplares = " + idexemplar + "";
                        comando.Connection = conexao;
                        comando.CommandText = sql;
                        RowAffect = comando.ExecuteNonQuery();
                        conexao.Close();
                        conexao.Open();
                        int vai = 0;
                        String sqlqtd = "update tb_exemplares set QT_DISP = QT_DISP +1 where id_exemplares = " + idexemplar + ";";
                        comando.Connection = conexao;
                        comando.CommandText = sqlqtd;
                        vai = comando.ExecuteNonQuery();
                        conexao.Close();
                    }

                    else
                    {
                        MessageBox.Show("Devolução não realizada!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    conexao.Close();

                    conexao.Open();
                    String sqlUpdate = "Update tb_emp_devol set dt_devol = current_date() where id_registro = " + idregistro + ";";
                    comando.Connection = conexao;
                    comando.CommandText = sqlUpdate;
                    RowAffect = comando.ExecuteNonQuery();
                    conexao.Close();

                }
                else if (Result == DialogResult.No)
                {
                    MessageBox.Show("Por favor pague a multa o mais cedo possível", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Devolução_Load(object sender, EventArgs e)
        {

        }
    }
}
