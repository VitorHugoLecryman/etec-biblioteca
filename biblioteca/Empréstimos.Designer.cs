
namespace biblioteca
{
    partial class Empréstimos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Empréstimos));
            this.txtrm = new System.Windows.Forms.TextBox();
            this.labellogin = new System.Windows.Forms.Label();
            this.btbConfirmar = new System.Windows.Forms.Button();
            this.GrpbDadosUser = new System.Windows.Forms.GroupBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtUserRm = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtlivroempres = new System.Windows.Forms.TextBox();
            this.btbEmprestar = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.GrpbDadosUser.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtrm
            // 
            this.txtrm.Location = new System.Drawing.Point(314, 352);
            this.txtrm.Name = "txtrm";
            this.txtrm.Size = new System.Drawing.Size(128, 20);
            this.txtrm.TabIndex = 8;
            this.txtrm.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtrm_KeyPress);
            // 
            // labellogin
            // 
            this.labellogin.AutoSize = true;
            this.labellogin.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labellogin.Location = new System.Drawing.Point(248, 349);
            this.labellogin.Name = "labellogin";
            this.labellogin.Size = new System.Drawing.Size(42, 22);
            this.labellogin.TabIndex = 7;
            this.labellogin.Text = "RM:";
            // 
            // btbConfirmar
            // 
            this.btbConfirmar.Location = new System.Drawing.Point(333, 391);
            this.btbConfirmar.Name = "btbConfirmar";
            this.btbConfirmar.Size = new System.Drawing.Size(75, 23);
            this.btbConfirmar.TabIndex = 10;
            this.btbConfirmar.Text = "Confirmar";
            this.btbConfirmar.UseVisualStyleBackColor = true;
            this.btbConfirmar.Click += new System.EventHandler(this.btbConfirmar_Click);
            // 
            // GrpbDadosUser
            // 
            this.GrpbDadosUser.Controls.Add(this.txtNome);
            this.GrpbDadosUser.Controls.Add(this.label3);
            this.GrpbDadosUser.Controls.Add(this.txtUserRm);
            this.GrpbDadosUser.Controls.Add(this.label2);
            this.GrpbDadosUser.Controls.Add(this.txtUser);
            this.GrpbDadosUser.Controls.Add(this.label1);
            this.GrpbDadosUser.Location = new System.Drawing.Point(588, 147);
            this.GrpbDadosUser.Name = "GrpbDadosUser";
            this.GrpbDadosUser.Size = new System.Drawing.Size(200, 178);
            this.GrpbDadosUser.TabIndex = 11;
            this.GrpbDadosUser.TabStop = false;
            this.GrpbDadosUser.Text = "Dados:";
            this.GrpbDadosUser.Visible = false;
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(95, 72);
            this.txtNome.Name = "txtNome";
            this.txtNome.ReadOnly = true;
            this.txtNome.Size = new System.Drawing.Size(84, 20);
            this.txtNome.TabIndex = 17;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 22);
            this.label3.TabIndex = 16;
            this.label3.Text = "Nome:";
            // 
            // txtUserRm
            // 
            this.txtUserRm.Location = new System.Drawing.Point(95, 114);
            this.txtUserRm.Name = "txtUserRm";
            this.txtUserRm.ReadOnly = true;
            this.txtUserRm.Size = new System.Drawing.Size(84, 20);
            this.txtUserRm.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 22);
            this.label2.TabIndex = 14;
            this.label2.Text = "RM:";
            // 
            // txtUser
            // 
            this.txtUser.Location = new System.Drawing.Point(95, 30);
            this.txtUser.Name = "txtUser";
            this.txtUser.ReadOnly = true;
            this.txtUser.Size = new System.Drawing.Size(84, 20);
            this.txtUser.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 22);
            this.label1.TabIndex = 12;
            this.label1.Text = "Usuário:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(138, 180);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(170, 22);
            this.label4.TabIndex = 12;
            this.label4.Text = "Numero do tombo:";
            this.label4.Visible = false;
            // 
            // txtlivroempres
            // 
            this.txtlivroempres.Location = new System.Drawing.Point(314, 182);
            this.txtlivroempres.Name = "txtlivroempres";
            this.txtlivroempres.Size = new System.Drawing.Size(128, 20);
            this.txtlivroempres.TabIndex = 13;
            this.txtlivroempres.Visible = false;
            this.txtlivroempres.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtlivroempres_KeyPress);
            // 
            // btbEmprestar
            // 
            this.btbEmprestar.Location = new System.Drawing.Point(333, 245);
            this.btbEmprestar.Name = "btbEmprestar";
            this.btbEmprestar.Size = new System.Drawing.Size(75, 23);
            this.btbEmprestar.TabIndex = 14;
            this.btbEmprestar.Text = "Confirmar";
            this.btbEmprestar.UseVisualStyleBackColor = true;
            this.btbEmprestar.Visible = false;
            this.btbEmprestar.Click += new System.EventHandler(this.btbEmprestar_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(333, 302);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 17;
            this.button1.Text = "Finalizar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Visible = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Crimson;
            this.panel1.Location = new System.Drawing.Point(-2, -2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(811, 33);
            this.panel1.TabIndex = 18;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::biblioteca.Properties.Resources.MicrosoftTeams_image_removebg_preview__1___1_;
            this.pictureBox1.Location = new System.Drawing.Point(164, 37);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(428, 84);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Crimson;
            this.panel2.Location = new System.Drawing.Point(-2, 420);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(811, 33);
            this.panel2.TabIndex = 19;
            // 
            // Empréstimos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(807, 450);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btbEmprestar);
            this.Controls.Add(this.txtlivroempres);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.GrpbDadosUser);
            this.Controls.Add(this.btbConfirmar);
            this.Controls.Add(this.txtrm);
            this.Controls.Add(this.labellogin);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Empréstimos";
            this.Text = "Empréstimo";
            this.GrpbDadosUser.ResumeLayout(false);
            this.GrpbDadosUser.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtrm;
        private System.Windows.Forms.Label labellogin;
        private System.Windows.Forms.Button btbConfirmar;
        private System.Windows.Forms.GroupBox GrpbDadosUser;
        private System.Windows.Forms.TextBox txtUserRm;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtlivroempres;
        private System.Windows.Forms.Button btbEmprestar;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
    }
}