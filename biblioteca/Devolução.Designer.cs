
namespace biblioteca
{
    partial class Devolução
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Devolução));
            this.txtRmDevol = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btbEmprestar = new System.Windows.Forms.Button();
            this.txtlivrodevol = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // txtRmDevol
            // 
            this.txtRmDevol.Location = new System.Drawing.Point(239, 71);
            this.txtRmDevol.Name = "txtRmDevol";
            this.txtRmDevol.Size = new System.Drawing.Size(128, 20);
            this.txtRmDevol.TabIndex = 21;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(51, 71);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 22);
            this.label5.TabIndex = 20;
            this.label5.Text = "RM:";
            // 
            // btbEmprestar
            // 
            this.btbEmprestar.Location = new System.Drawing.Point(55, 123);
            this.btbEmprestar.Name = "btbEmprestar";
            this.btbEmprestar.Size = new System.Drawing.Size(75, 23);
            this.btbEmprestar.TabIndex = 19;
            this.btbEmprestar.Text = "Confirmar";
            this.btbEmprestar.UseVisualStyleBackColor = true;
            this.btbEmprestar.Click += new System.EventHandler(this.btbEmprestar_Click);
            // 
            // txtlivrodevol
            // 
            this.txtlivrodevol.Location = new System.Drawing.Point(239, 37);
            this.txtlivrodevol.Name = "txtlivrodevol";
            this.txtlivrodevol.Size = new System.Drawing.Size(128, 20);
            this.txtlivrodevol.TabIndex = 18;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(51, 37);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(170, 22);
            this.label4.TabIndex = 17;
            this.label4.Text = "Numero do tombo:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(292, 123);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 22;
            this.button1.Text = "Finalizar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Crimson;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(380, 25);
            this.panel1.TabIndex = 23;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Crimson;
            this.panel2.Location = new System.Drawing.Point(0, 182);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(380, 25);
            this.panel2.TabIndex = 24;
            // 
            // Devolução
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(379, 201);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtRmDevol);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btbEmprestar);
            this.Controls.Add(this.txtlivrodevol);
            this.Controls.Add(this.label4);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Devolução";
            this.Text = "Devolução";
            this.Load += new System.EventHandler(this.Devolução_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtRmDevol;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btbEmprestar;
        private System.Windows.Forms.TextBox txtlivrodevol;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
    }
}