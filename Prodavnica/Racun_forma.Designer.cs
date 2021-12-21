
namespace Prodavnica
{
    partial class Racun_forma
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblUkupno = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnUkloni = new System.Windows.Forms.Button();
            this.btnSacuvaj = new System.Windows.Forms.Button();
            this.lbProizvodinaRacunu = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel1.Controls.Add(this.lblUkupno);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.btnUkloni);
            this.panel1.Controls.Add(this.btnSacuvaj);
            this.panel1.Controls.Add(this.lbProizvodinaRacunu);
            this.panel1.Location = new System.Drawing.Point(12, 74);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(436, 466);
            this.panel1.TabIndex = 0;
            // 
            // lblUkupno
            // 
            this.lblUkupno.AutoSize = true;
            this.lblUkupno.Location = new System.Drawing.Point(335, 346);
            this.lblUkupno.Name = "lblUkupno";
            this.lblUkupno.Size = new System.Drawing.Size(16, 17);
            this.lblUkupno.TabIndex = 4;
            this.lblUkupno.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(252, 346);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Ukupno:";
            // 
            // btnUkloni
            // 
            this.btnUkloni.BackColor = System.Drawing.SystemColors.Control;
            this.btnUkloni.Location = new System.Drawing.Point(245, 389);
            this.btnUkloni.Name = "btnUkloni";
            this.btnUkloni.Size = new System.Drawing.Size(169, 54);
            this.btnUkloni.TabIndex = 2;
            this.btnUkloni.Text = "Ukloni";
            this.btnUkloni.UseVisualStyleBackColor = false;
            this.btnUkloni.Click += new System.EventHandler(this.btnUkloni_Click);
            // 
            // btnSacuvaj
            // 
            this.btnSacuvaj.BackColor = System.Drawing.SystemColors.Control;
            this.btnSacuvaj.Location = new System.Drawing.Point(18, 389);
            this.btnSacuvaj.Name = "btnSacuvaj";
            this.btnSacuvaj.Size = new System.Drawing.Size(169, 54);
            this.btnSacuvaj.TabIndex = 1;
            this.btnSacuvaj.Text = "Sacuvaj";
            this.btnSacuvaj.UseVisualStyleBackColor = false;
            this.btnSacuvaj.Click += new System.EventHandler(this.btnSacuvaj_Click);
            // 
            // lbProizvodinaRacunu
            // 
            this.lbProizvodinaRacunu.FormattingEnabled = true;
            this.lbProizvodinaRacunu.ItemHeight = 16;
            this.lbProizvodinaRacunu.Location = new System.Drawing.Point(18, 19);
            this.lbProizvodinaRacunu.Name = "lbProizvodinaRacunu";
            this.lbProizvodinaRacunu.Size = new System.Drawing.Size(396, 308);
            this.lbProizvodinaRacunu.TabIndex = 0;
            this.lbProizvodinaRacunu.MouseClick += new System.Windows.Forms.MouseEventHandler(this.lbProizvodinaRacunu_MouseClick);
            this.lbProizvodinaRacunu.SelectedIndexChanged += new System.EventHandler(this.lbProizvodinaRacunu_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(193, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Račun";
            // 
            // Racun_forma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(460, 587);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Name = "Racun_forma";
            this.Text = "Racun_forma";
            this.Load += new System.EventHandler(this.Racun_forma_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnUkloni;
        private System.Windows.Forms.Button btnSacuvaj;
        private System.Windows.Forms.ListBox lbProizvodinaRacunu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblUkupno;
        private System.Windows.Forms.Label label2;
    }
}