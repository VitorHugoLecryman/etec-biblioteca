
namespace biblioteca
{
    partial class Form8
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form8));
            this.txtnomealuno = new System.Windows.Forms.TextBox();
            this.txtRMaluno = new System.Windows.Forms.TextBox();
            this.lblRMaluno = new System.Windows.Forms.Label();
            this.lblnomealuno = new System.Windows.Forms.Label();
            this.nivellbl = new System.Windows.Forms.Label();
            this.rbdAluno = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.RDBFUNF = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // txtnomealuno
            // 
            this.txtnomealuno.Location = new System.Drawing.Point(202, 31);
            this.txtnomealuno.Name = "txtnomealuno";
            this.txtnomealuno.Size = new System.Drawing.Size(151, 20);
            this.txtnomealuno.TabIndex = 47;
            this.txtnomealuno.TextChanged += new System.EventHandler(this.txtnomealuno_TextChanged);
            // 
            // txtRMaluno
            // 
            this.txtRMaluno.Location = new System.Drawing.Point(202, 75);
            this.txtRMaluno.Name = "txtRMaluno";
            this.txtRMaluno.Size = new System.Drawing.Size(151, 20);
            this.txtRMaluno.TabIndex = 46;
            this.txtRMaluno.TextChanged += new System.EventHandler(this.txtRMaluno_TextChanged);
            // 
            // lblRMaluno
            // 
            this.lblRMaluno.AutoSize = true;
            this.lblRMaluno.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRMaluno.Location = new System.Drawing.Point(32, 72);
            this.lblRMaluno.Name = "lblRMaluno";
            this.lblRMaluno.Size = new System.Drawing.Size(136, 22);
            this.lblRMaluno.TabIndex = 45;
            this.lblRMaluno.Text = "RM do Usuário:";
            this.lblRMaluno.Click += new System.EventHandler(this.lblRMaluno_Click);
            // 
            // lblnomealuno
            // 
            this.lblnomealuno.AutoSize = true;
            this.lblnomealuno.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnomealuno.Location = new System.Drawing.Point(32, 29);
            this.lblnomealuno.Name = "lblnomealuno";
            this.lblnomealuno.Size = new System.Drawing.Size(164, 22);
            this.lblnomealuno.TabIndex = 44;
            this.lblnomealuno.Text = "Nome do Usuário: ";
            this.lblnomealuno.Click += new System.EventHandler(this.lblnomealuno_Click);
            // 
            // nivellbl
            // 
            this.nivellbl.AutoSize = true;
            this.nivellbl.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nivellbl.Location = new System.Drawing.Point(32, 113);
            this.nivellbl.Name = "nivellbl";
            this.nivellbl.Size = new System.Drawing.Size(138, 22);
            this.nivellbl.TabIndex = 50;
            this.nivellbl.Text = "Mostra usuário:";
            this.nivellbl.Click += new System.EventHandler(this.nivellbl_Click);
            // 
            // rbdAluno
            // 
            this.rbdAluno.AutoSize = true;
            this.rbdAluno.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbdAluno.Location = new System.Drawing.Point(202, 116);
            this.rbdAluno.Name = "rbdAluno";
            this.rbdAluno.Size = new System.Drawing.Size(58, 20);
            this.rbdAluno.TabIndex = 48;
            this.rbdAluno.TabStop = true;
            this.rbdAluno.Text = "Aluno";
            this.rbdAluno.UseVisualStyleBackColor = true;
            this.rbdAluno.CheckedChanged += new System.EventHandler(this.rbdAluno_CheckedChanged);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.BackgroundImage = global::biblioteca.Properties.Resources.check_checkbox_checkmark_confirm_success_yes_icon_1320196711226060446_512;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button1.Location = new System.Drawing.Point(140, 178);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(78, 63);
            this.button1.TabIndex = 51;
            this.button1.Text = "Confirmar";
            this.button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // RDBFUNF
            // 
            this.RDBFUNF.AutoSize = true;
            this.RDBFUNF.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RDBFUNF.Location = new System.Drawing.Point(266, 116);
            this.RDBFUNF.Name = "RDBFUNF";
            this.RDBFUNF.Size = new System.Drawing.Size(90, 20);
            this.RDBFUNF.TabIndex = 52;
            this.RDBFUNF.TabStop = true;
            this.RDBFUNF.Text = "Funcionario";
            this.RDBFUNF.UseVisualStyleBackColor = true;
            this.RDBFUNF.CheckedChanged += new System.EventHandler(this.RDBFUNF_CheckedChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Crimson;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(367, 26);
            this.panel1.TabIndex = 53;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Crimson;
            this.panel2.Location = new System.Drawing.Point(0, 242);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(367, 31);
            this.panel2.TabIndex = 54;
            // 
            // Form8
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(365, 265);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.RDBFUNF);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.nivellbl);
            this.Controls.Add(this.rbdAluno);
            this.Controls.Add(this.txtnomealuno);
            this.Controls.Add(this.txtRMaluno);
            this.Controls.Add(this.lblRMaluno);
            this.Controls.Add(this.lblnomealuno);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form8";
            this.Text = "Cadastro Usuário";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtnomealuno;
        private System.Windows.Forms.TextBox txtRMaluno;
        private System.Windows.Forms.Label lblRMaluno;
        private System.Windows.Forms.Label lblnomealuno;
        private System.Windows.Forms.Label nivellbl;
        private System.Windows.Forms.RadioButton rbdAluno;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RadioButton RDBFUNF;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
    }
}