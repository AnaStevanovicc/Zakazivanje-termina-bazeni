namespace Zakazivanje_termina_bazeni
{
    partial class Login
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
            this.txt_name = new System.Windows.Forms.TextBox();
            this.txt_pass = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_ok = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btn_ok1 = new System.Windows.Forms.Button();
            this.txt_ime = new System.Windows.Forms.TextBox();
            this.txt_prezime = new System.Windows.Forms.TextBox();
            this.txt_email = new System.Windows.Forms.TextBox();
            this.txt_password = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txt_name
            // 
            this.txt_name.Location = new System.Drawing.Point(119, 114);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(136, 20);
            this.txt_name.TabIndex = 0;
            // 
            // txt_pass
            // 
            this.txt_pass.Location = new System.Drawing.Point(119, 157);
            this.txt_pass.Name = "txt_pass";
            this.txt_pass.Size = new System.Drawing.Size(136, 20);
            this.txt_pass.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 117);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "E-mail";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(44, 164);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Password";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(199, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(183, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Dobrodosli! Da biste nastavili unesite:";
            // 
            // btn_ok
            // 
            this.btn_ok.Location = new System.Drawing.Point(141, 229);
            this.btn_ok.Name = "btn_ok";
            this.btn_ok.Size = new System.Drawing.Size(75, 23);
            this.btn_ok.TabIndex = 5;
            this.btn_ok.Text = "Sign in";
            this.btn_ok.UseVisualStyleBackColor = true;
            this.btn_ok.Click += new System.EventHandler(this.btn_ok_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(338, 89);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(24, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Ime";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(338, 121);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Prezime";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(338, 147);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "E-mail";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(338, 173);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 13);
            this.label7.TabIndex = 9;
            this.label7.Text = "Password";
            // 
            // btn_ok1
            // 
            this.btn_ok1.Location = new System.Drawing.Point(430, 229);
            this.btn_ok1.Name = "btn_ok1";
            this.btn_ok1.Size = new System.Drawing.Size(75, 23);
            this.btn_ok1.TabIndex = 10;
            this.btn_ok1.Text = "Sign up";
            this.btn_ok1.UseVisualStyleBackColor = true;
            this.btn_ok1.Click += new System.EventHandler(this.btn_ok1_Click);
            // 
            // txt_ime
            // 
            this.txt_ime.Location = new System.Drawing.Point(406, 86);
            this.txt_ime.Name = "txt_ime";
            this.txt_ime.Size = new System.Drawing.Size(138, 20);
            this.txt_ime.TabIndex = 11;
            // 
            // txt_prezime
            // 
            this.txt_prezime.Location = new System.Drawing.Point(406, 118);
            this.txt_prezime.Name = "txt_prezime";
            this.txt_prezime.Size = new System.Drawing.Size(138, 20);
            this.txt_prezime.TabIndex = 12;
            // 
            // txt_email
            // 
            this.txt_email.Location = new System.Drawing.Point(406, 144);
            this.txt_email.Name = "txt_email";
            this.txt_email.Size = new System.Drawing.Size(138, 20);
            this.txt_email.TabIndex = 13;
            // 
            // txt_password
            // 
            this.txt_password.Location = new System.Drawing.Point(406, 170);
            this.txt_password.Name = "txt_password";
            this.txt_password.Size = new System.Drawing.Size(138, 20);
            this.txt_password.TabIndex = 14;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(606, 283);
            this.Controls.Add(this.txt_password);
            this.Controls.Add(this.txt_email);
            this.Controls.Add(this.txt_prezime);
            this.Controls.Add(this.txt_ime);
            this.Controls.Add(this.btn_ok1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btn_ok);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_pass);
            this.Controls.Add(this.txt_name);
            this.Name = "Login";
            this.Text = " ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_name;
        private System.Windows.Forms.TextBox txt_pass;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_ok;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btn_ok1;
        private System.Windows.Forms.TextBox txt_ime;
        private System.Windows.Forms.TextBox txt_prezime;
        private System.Windows.Forms.TextBox txt_email;
        private System.Windows.Forms.TextBox txt_password;
    }
}