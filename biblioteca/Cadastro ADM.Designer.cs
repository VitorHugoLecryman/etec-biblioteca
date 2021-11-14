
namespace biblioteca
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.txtNomeAdm = new System.Windows.Forms.TextBox();
            this.txtSenhaAdm = new System.Windows.Forms.TextBox();
            this.txtRmAdm = new System.Windows.Forms.TextBox();
            this.lblRMaluno = new System.Windows.Forms.Label();
            this.lblnome = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // txtNomeAdm
            // 
            this.txtNomeAdm.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomeAdm.ForeColor = System.Drawing.Color.Black;
            this.txtNomeAdm.Location = new System.Drawing.Point(96, 47);
            this.txtNomeAdm.Name = "txtNomeAdm";
            this.txtNomeAdm.Size = new System.Drawing.Size(100, 21);
            this.txtNomeAdm.TabIndex = 49;
            // 
            // txtSenhaAdm
            // 
            this.txtSenhaAdm.Location = new System.Drawing.Point(96, 90);
            this.txtSenhaAdm.Name = "txtSenhaAdm";
            this.txtSenhaAdm.PasswordChar = '*';
            this.txtSenhaAdm.Size = new System.Drawing.Size(100, 20);
            this.txtSenhaAdm.TabIndex = 48;
            // 
            // txtRmAdm
            // 
            this.txtRmAdm.Location = new System.Drawing.Point(96, 141);
            this.txtRmAdm.Name = "txtRmAdm";
            this.txtRmAdm.Size = new System.Drawing.Size(100, 20);
            this.txtRmAdm.TabIndex = 47;
            // 
            // lblRMaluno
            // 
            this.lblRMaluno.AutoSize = true;
            this.lblRMaluno.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRMaluno.ForeColor = System.Drawing.Color.Black;
            this.lblRMaluno.Location = new System.Drawing.Point(21, 141);
            this.lblRMaluno.Name = "lblRMaluno";
            this.lblRMaluno.Size = new System.Drawing.Size(38, 20);
            this.lblRMaluno.TabIndex = 45;
            this.lblRMaluno.Text = "RM:";
            // 
            // lblnome
            // 
            this.lblnome.AutoSize = true;
            this.lblnome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnome.ForeColor = System.Drawing.Color.Black;
            this.lblnome.Location = new System.Drawing.Point(22, 47);
            this.lblnome.Name = "lblnome";
            this.lblnome.Size = new System.Drawing.Size(59, 20);
            this.lblnome.TabIndex = 44;
            this.lblnome.Text = "Nome: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(21, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 20);
            this.label1.TabIndex = 50;
            this.label1.Text = "Senha:";
            // 
            // button1
            // 
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(96, 205);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 27);
            this.button1.TabIndex = 51;
            this.button1.Text = "Confirmar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Crimson;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(259, 41);
            this.panel1.TabIndex = 52;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(257, 257);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNomeAdm);
            this.Controls.Add(this.txtSenhaAdm);
            this.Controls.Add(this.txtRmAdm);
            this.Controls.Add(this.lblRMaluno);
            this.Controls.Add(this.lblnome);
            this.ForeColor = System.Drawing.Color.Cyan;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form2";
            this.Text = "Cadastro";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNomeAdm;
        private System.Windows.Forms.TextBox txtSenhaAdm;
        private System.Windows.Forms.TextBox txtRmAdm;
        private System.Windows.Forms.Label lblRMaluno;
        private System.Windows.Forms.Label lblnome;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel1;
    }
}