namespace Zakazivanje_termina_bazeni
{
    partial class Glavna
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.adminToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.korisnikToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.korisniciToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dgToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.proizvodiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zakazaniTerminiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lokacijaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tipKarteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.prodavnicaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.adminToolStripMenuItem,
            this.korisnikToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // adminToolStripMenuItem
            // 
            this.adminToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.korisniciToolStripMenuItem,
            this.zakazaniTerminiToolStripMenuItem});
            this.adminToolStripMenuItem.Name = "adminToolStripMenuItem";
            this.adminToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.adminToolStripMenuItem.Text = "Admin";
            // 
            // korisnikToolStripMenuItem
            // 
            this.korisnikToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dgToolStripMenuItem,
            this.proizvodiToolStripMenuItem});
            this.korisnikToolStripMenuItem.Name = "korisnikToolStripMenuItem";
            this.korisnikToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.korisnikToolStripMenuItem.Text = "Korisnik";
            // 
            // korisniciToolStripMenuItem
            // 
            this.korisniciToolStripMenuItem.Name = "korisniciToolStripMenuItem";
            this.korisniciToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.korisniciToolStripMenuItem.Text = "Korisnici";
            this.korisniciToolStripMenuItem.Click += new System.EventHandler(this.korisniciToolStripMenuItem_Click);
            // 
            // dgToolStripMenuItem
            // 
            this.dgToolStripMenuItem.Name = "dgToolStripMenuItem";
            this.dgToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.dgToolStripMenuItem.Text = "Zakazivanje termina";
            this.dgToolStripMenuItem.Click += new System.EventHandler(this.dgToolStripMenuItem_Click);
            // 
            // proizvodiToolStripMenuItem
            // 
            this.proizvodiToolStripMenuItem.Name = "proizvodiToolStripMenuItem";
            this.proizvodiToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.proizvodiToolStripMenuItem.Text = "Proizvodi";
            this.proizvodiToolStripMenuItem.Click += new System.EventHandler(this.proizvodiToolStripMenuItem_Click);
            // 
            // zakazaniTerminiToolStripMenuItem
            // 
            this.zakazaniTerminiToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lokacijaToolStripMenuItem,
            this.tipKarteToolStripMenuItem,
            this.prodavnicaToolStripMenuItem});
            this.zakazaniTerminiToolStripMenuItem.Name = "zakazaniTerminiToolStripMenuItem";
            this.zakazaniTerminiToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.zakazaniTerminiToolStripMenuItem.Text = "SIfarnik";
            // 
            // lokacijaToolStripMenuItem
            // 
            this.lokacijaToolStripMenuItem.Name = "lokacijaToolStripMenuItem";
            this.lokacijaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.lokacijaToolStripMenuItem.Text = "Lokacija";
            this.lokacijaToolStripMenuItem.Click += new System.EventHandler(this.lokacijaToolStripMenuItem_Click);
            // 
            // tipKarteToolStripMenuItem
            // 
            this.tipKarteToolStripMenuItem.Name = "tipKarteToolStripMenuItem";
            this.tipKarteToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.tipKarteToolStripMenuItem.Text = "Tip karte";
            this.tipKarteToolStripMenuItem.Click += new System.EventHandler(this.tipKarteToolStripMenuItem_Click);
            // 
            // prodavnicaToolStripMenuItem
            // 
            this.prodavnicaToolStripMenuItem.Name = "prodavnicaToolStripMenuItem";
            this.prodavnicaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.prodavnicaToolStripMenuItem.Text = "Prodavnica";
            this.prodavnicaToolStripMenuItem.Click += new System.EventHandler(this.prodavnicaToolStripMenuItem_Click);
            // 
            // Glavna
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Glavna";
            this.Text = "Glavna";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Glavna_FormClosed);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem adminToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem korisniciToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem korisnikToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zakazaniTerminiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dgToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem proizvodiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lokacijaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tipKarteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem prodavnicaToolStripMenuItem;
    }
}