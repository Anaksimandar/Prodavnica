
namespace Prodavnica
{
    partial class Racun_baza_form
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
            this.dtpPocetniDatum = new System.Windows.Forms.DateTimePicker();
            this.dtpKrajnjiDatum = new System.Windows.Forms.DateTimePicker();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnPrikaz = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dtpPocetniDatum
            // 
            this.dtpPocetniDatum.Location = new System.Drawing.Point(16, 61);
            this.dtpPocetniDatum.Name = "dtpPocetniDatum";
            this.dtpPocetniDatum.Size = new System.Drawing.Size(200, 22);
            this.dtpPocetniDatum.TabIndex = 0;
            // 
            // dtpKrajnjiDatum
            // 
            this.dtpKrajnjiDatum.Location = new System.Drawing.Point(294, 61);
            this.dtpKrajnjiDatum.Name = "dtpKrajnjiDatum";
            this.dtpKrajnjiDatum.Size = new System.Drawing.Size(200, 22);
            this.dtpKrajnjiDatum.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnPrikaz);
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Controls.Add(this.dtpKrajnjiDatum);
            this.panel1.Controls.Add(this.dtpPocetniDatum);
            this.panel1.Location = new System.Drawing.Point(182, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(513, 550);
            this.panel1.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(240, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "do:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(157, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(185, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Prikazi racune za period od:";
            // 
            // btnPrikaz
            // 
            this.btnPrikaz.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrikaz.Location = new System.Drawing.Point(16, 468);
            this.btnPrikaz.Name = "btnPrikaz";
            this.btnPrikaz.Size = new System.Drawing.Size(478, 68);
            this.btnPrikaz.TabIndex = 3;
            this.btnPrikaz.Text = "Prikaži račune";
            this.btnPrikaz.UseVisualStyleBackColor = true;
            this.btnPrikaz.Click += new System.EventHandler(this.btnPrikaz_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(16, 129);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(478, 309);
            this.dataGridView1.TabIndex = 2;
            // 
            // Racun_baza_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(869, 578);
            this.Controls.Add(this.panel1);
            this.Name = "Racun_baza_form";
            this.Text = "racun_baza_form";
            this.Load += new System.EventHandler(this.racun_baza_form_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtpPocetniDatum;
        private System.Windows.Forms.DateTimePicker dtpKrajnjiDatum;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnPrikaz;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}