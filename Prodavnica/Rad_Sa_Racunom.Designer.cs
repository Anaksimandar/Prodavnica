
namespace Prodavnica
{
    partial class Rad_Sa_Racunom
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
            this.lbProizvodi = new System.Windows.Forms.ListBox();
            this.cbKategorija = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnDodajnaRacun = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.tbNazivProizvoda = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnProizvodKategorija = new System.Windows.Forms.Button();
            this.btnProizvodNaziv = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbProizvodi
            // 
            this.lbProizvodi.FormattingEnabled = true;
            this.lbProizvodi.ItemHeight = 16;
            this.lbProizvodi.Location = new System.Drawing.Point(80, 172);
            this.lbProizvodi.Name = "lbProizvodi";
            this.lbProizvodi.Size = new System.Drawing.Size(342, 228);
            this.lbProizvodi.TabIndex = 0;
            this.lbProizvodi.MouseClick += new System.Windows.Forms.MouseEventHandler(this.lbProizvodi_MouseClick);
            // 
            // cbKategorija
            // 
            this.cbKategorija.FormattingEnabled = true;
            this.cbKategorija.Location = new System.Drawing.Point(80, 47);
            this.cbKategorija.Name = "cbKategorija";
            this.cbKategorija.Size = new System.Drawing.Size(168, 24);
            this.cbKategorija.TabIndex = 1;
            this.cbKategorija.SelectedIndexChanged += new System.EventHandler(this.cbKategorija_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(125, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Kategorije:";
            // 
            // btnDodajnaRacun
            // 
            this.btnDodajnaRacun.Location = new System.Drawing.Point(80, 444);
            this.btnDodajnaRacun.Name = "btnDodajnaRacun";
            this.btnDodajnaRacun.Size = new System.Drawing.Size(342, 48);
            this.btnDodajnaRacun.TabIndex = 6;
            this.btnDodajnaRacun.Text = "Dodaj na račun";
            this.btnDodajnaRacun.UseVisualStyleBackColor = true;
            this.btnDodajnaRacun.Click += new System.EventHandler(this.btnDodajnaRacun_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(182, 152);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "Prozivodi";
            // 
            // tbNazivProizvoda
            // 
            this.tbNazivProizvoda.Location = new System.Drawing.Point(254, 49);
            this.tbNazivProizvoda.Name = "tbNazivProizvoda";
            this.tbNazivProizvoda.Size = new System.Drawing.Size(168, 22);
            this.tbNazivProizvoda.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(280, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 17);
            this.label3.TabIndex = 9;
            this.label3.Text = "Naziv proizvoda:";
            // 
            // btnProizvodKategorija
            // 
            this.btnProizvodKategorija.Location = new System.Drawing.Point(80, 91);
            this.btnProizvodKategorija.Name = "btnProizvodKategorija";
            this.btnProizvodKategorija.Size = new System.Drawing.Size(168, 48);
            this.btnProizvodKategorija.TabIndex = 10;
            this.btnProizvodKategorija.Text = "Pretraži";
            this.btnProizvodKategorija.UseVisualStyleBackColor = true;
            this.btnProizvodKategorija.Click += new System.EventHandler(this.btnProizvodKategorija_Click);
            // 
            // btnProizvodNaziv
            // 
            this.btnProizvodNaziv.Location = new System.Drawing.Point(254, 91);
            this.btnProizvodNaziv.Name = "btnProizvodNaziv";
            this.btnProizvodNaziv.Size = new System.Drawing.Size(168, 48);
            this.btnProizvodNaziv.TabIndex = 12;
            this.btnProizvodNaziv.Text = "Pretraži";
            this.btnProizvodNaziv.UseVisualStyleBackColor = true;
            this.btnProizvodNaziv.Click += new System.EventHandler(this.btnProizvodNaziv_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.btnProizvodNaziv);
            this.panel1.Controls.Add(this.lbProizvodi);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnProizvodKategorija);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.btnDodajnaRacun);
            this.panel1.Controls.Add(this.cbKategorija);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.tbNazivProizvoda);
            this.panel1.Location = new System.Drawing.Point(0, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(494, 566);
            this.panel1.TabIndex = 13;
            // 
            // Rad_Sa_Racunom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(495, 562);
            this.Controls.Add(this.panel1);
            this.Name = "Rad_Sa_Racunom";
            this.Text = "Rad_Sa_Racunom";
            this.Load += new System.EventHandler(this.Rad_Sa_Racunom_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lbProizvodi;
        private System.Windows.Forms.ComboBox cbKategorija;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnDodajnaRacun;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbNazivProizvoda;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnProizvodKategorija;
        private System.Windows.Forms.Button btnProizvodNaziv;
        private System.Windows.Forms.Panel panel1;
    }
}