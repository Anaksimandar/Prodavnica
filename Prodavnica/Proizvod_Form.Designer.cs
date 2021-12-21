
namespace Prodavnica
{
    partial class Proizvod_Form
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnPrikaziProizvode = new System.Windows.Forms.Button();
            this.tbNaziv = new System.Windows.Forms.TextBox();
            this.tbCena = new System.Windows.Forms.TextBox();
            this.tbKolicina = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbKategorija = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnDodajProizvod = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.tbIdProizvoda = new System.Windows.Forms.TextBox();
            this.btnSacuvajIzmene = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(410, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(661, 352);
            this.dataGridView1.TabIndex = 0;
            // 
            // btnPrikaziProizvode
            // 
            this.btnPrikaziProizvode.Location = new System.Drawing.Point(776, 380);
            this.btnPrikaziProizvode.Name = "btnPrikaziProizvode";
            this.btnPrikaziProizvode.Size = new System.Drawing.Size(295, 72);
            this.btnPrikaziProizvode.TabIndex = 1;
            this.btnPrikaziProizvode.Text = "Prikaz proizvoda";
            this.btnPrikaziProizvode.UseVisualStyleBackColor = true;
            this.btnPrikaziProizvode.Click += new System.EventHandler(this.btnPrikaziProizvode_Click);
            // 
            // tbNaziv
            // 
            this.tbNaziv.Location = new System.Drawing.Point(158, 120);
            this.tbNaziv.Name = "tbNaziv";
            this.tbNaziv.Size = new System.Drawing.Size(159, 22);
            this.tbNaziv.TabIndex = 2;
            // 
            // tbCena
            // 
            this.tbCena.Location = new System.Drawing.Point(158, 166);
            this.tbCena.Name = "tbCena";
            this.tbCena.Size = new System.Drawing.Size(159, 22);
            this.tbCena.TabIndex = 3;
            // 
            // tbKolicina
            // 
            this.tbKolicina.Location = new System.Drawing.Point(158, 215);
            this.tbKolicina.Name = "tbKolicina";
            this.tbKolicina.Size = new System.Drawing.Size(159, 22);
            this.tbKolicina.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(74, 123);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Naziv:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(76, 169);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Cena:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(76, 218);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Kolicina:";
            // 
            // cbKategorija
            // 
            this.cbKategorija.FormattingEnabled = true;
            this.cbKategorija.Location = new System.Drawing.Point(158, 257);
            this.cbKategorija.Name = "cbKategorija";
            this.cbKategorija.Size = new System.Drawing.Size(159, 24);
            this.cbKategorija.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(76, 260);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "Kategorija:";
            // 
            // btnDodajProizvod
            // 
            this.btnDodajProizvod.Location = new System.Drawing.Point(79, 302);
            this.btnDodajProizvod.Name = "btnDodajProizvod";
            this.btnDodajProizvod.Size = new System.Drawing.Size(238, 62);
            this.btnDodajProizvod.TabIndex = 10;
            this.btnDodajProizvod.Text = "Dodaj proizvod";
            this.btnDodajProizvod.UseVisualStyleBackColor = true;
            this.btnDodajProizvod.Click += new System.EventHandler(this.btnDodajProizvod_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(74, 84);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(25, 17);
            this.label5.TabIndex = 12;
            this.label5.Text = "ID:";
            // 
            // tbIdProizvoda
            // 
            this.tbIdProizvoda.Location = new System.Drawing.Point(158, 81);
            this.tbIdProizvoda.Name = "tbIdProizvoda";
            this.tbIdProizvoda.Size = new System.Drawing.Size(159, 22);
            this.tbIdProizvoda.TabIndex = 11;
            // 
            // btnSacuvajIzmene
            // 
            this.btnSacuvajIzmene.Location = new System.Drawing.Point(410, 380);
            this.btnSacuvajIzmene.Name = "btnSacuvajIzmene";
            this.btnSacuvajIzmene.Size = new System.Drawing.Size(308, 72);
            this.btnSacuvajIzmene.TabIndex = 13;
            this.btnSacuvajIzmene.Text = "Sacuvaj izmene";
            this.btnSacuvajIzmene.UseVisualStyleBackColor = true;
            this.btnSacuvajIzmene.Click += new System.EventHandler(this.btnSacuvajIzmene_Click);
            // 
            // Proizvod_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1121, 537);
            this.Controls.Add(this.btnSacuvajIzmene);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbIdProizvoda);
            this.Controls.Add(this.btnDodajProizvod);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbKategorija);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbKolicina);
            this.Controls.Add(this.tbCena);
            this.Controls.Add(this.tbNaziv);
            this.Controls.Add(this.btnPrikaziProizvode);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Proizvod_Form";
            this.Text = "Proizvod_Form";
            this.Load += new System.EventHandler(this.Proizvod_Form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnPrikaziProizvode;
        private System.Windows.Forms.TextBox tbNaziv;
        private System.Windows.Forms.TextBox tbCena;
        private System.Windows.Forms.TextBox tbKolicina;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbKategorija;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnDodajProizvod;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbIdProizvoda;
        private System.Windows.Forms.Button btnSacuvajIzmene;
    }
}