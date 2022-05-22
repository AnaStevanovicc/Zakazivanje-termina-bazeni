namespace Zakazivanje_termina_bazeni
{
    partial class Zakazivanje
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
            this.label1 = new System.Windows.Forms.Label();
            this.cmb_korisnik = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cmb_lokacija = new System.Windows.Forms.ComboBox();
            this.cmb_bazen = new System.Windows.Forms.ComboBox();
            this.cmb_termin = new System.Windows.Forms.ComboBox();
            this.cmb_tip_karte = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Datum = new System.Windows.Forms.DateTimePicker();
            this.btn_insert = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(52, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Korisnik";
            // 
            // cmb_korisnik
            // 
            this.cmb_korisnik.FormattingEnabled = true;
            this.cmb_korisnik.Location = new System.Drawing.Point(105, 38);
            this.cmb_korisnik.Name = "cmb_korisnik";
            this.cmb_korisnik.Size = new System.Drawing.Size(121, 21);
            this.cmb_korisnik.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(52, 124);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Lokacija";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(232, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Bazen";
            // 
            // cmb_lokacija
            // 
            this.cmb_lokacija.FormattingEnabled = true;
            this.cmb_lokacija.Location = new System.Drawing.Point(105, 116);
            this.cmb_lokacija.Name = "cmb_lokacija";
            this.cmb_lokacija.Size = new System.Drawing.Size(121, 21);
            this.cmb_lokacija.TabIndex = 4;
            this.cmb_lokacija.SelectedValueChanged += new System.EventHandler(this.cmb_lokacija_SelectedValueChanged);
            // 
            // cmb_bazen
            // 
            this.cmb_bazen.FormattingEnabled = true;
            this.cmb_bazen.Location = new System.Drawing.Point(275, 116);
            this.cmb_bazen.Name = "cmb_bazen";
            this.cmb_bazen.Size = new System.Drawing.Size(121, 21);
            this.cmb_bazen.TabIndex = 5;
            // 
            // cmb_termin
            // 
            this.cmb_termin.FormattingEnabled = true;
            this.cmb_termin.Location = new System.Drawing.Point(275, 77);
            this.cmb_termin.Name = "cmb_termin";
            this.cmb_termin.Size = new System.Drawing.Size(121, 21);
            this.cmb_termin.TabIndex = 9;
            // 
            // cmb_tip_karte
            // 
            this.cmb_tip_karte.FormattingEnabled = true;
            this.cmb_tip_karte.Location = new System.Drawing.Point(105, 77);
            this.cmb_tip_karte.Name = "cmb_tip_karte";
            this.cmb_tip_karte.Size = new System.Drawing.Size(121, 21);
            this.cmb_tip_karte.TabIndex = 8;
            this.cmb_tip_karte.SelectedValueChanged += new System.EventHandler(this.cmb_tip_karte_SelectedValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(232, 80);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Termin";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(52, 85);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Tip karte";
            // 
            // Datum
            // 
            this.Datum.Location = new System.Drawing.Point(55, 157);
            this.Datum.Name = "Datum";
            this.Datum.Size = new System.Drawing.Size(200, 20);
            this.Datum.TabIndex = 10;
            // 
            // btn_insert
            // 
            this.btn_insert.Location = new System.Drawing.Point(469, 97);
            this.btn_insert.Name = "btn_insert";
            this.btn_insert.Size = new System.Drawing.Size(75, 23);
            this.btn_insert.TabIndex = 11;
            this.btn_insert.Text = "dodaj";
            this.btn_insert.UseVisualStyleBackColor = true;
            this.btn_insert.Click += new System.EventHandler(this.btn_insert_Click);
            // 
            // Zakazivanje
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(582, 322);
            this.Controls.Add(this.btn_insert);
            this.Controls.Add(this.Datum);
            this.Controls.Add(this.cmb_termin);
            this.Controls.Add(this.cmb_tip_karte);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cmb_bazen);
            this.Controls.Add(this.cmb_lokacija);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmb_korisnik);
            this.Controls.Add(this.label1);
            this.Name = "Zakazivanje";
            this.Text = "Zakazivanje";
            this.Load += new System.EventHandler(this.Zakazivanje_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmb_korisnik;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmb_lokacija;
        private System.Windows.Forms.ComboBox cmb_bazen;
        private System.Windows.Forms.ComboBox cmb_termin;
        private System.Windows.Forms.ComboBox cmb_tip_karte;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker Datum;
        private System.Windows.Forms.Button btn_insert;
    }
}