
namespace Prodavnica
{
    partial class Rad_Sa_Bazom
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
            this.btnRacun = new System.Windows.Forms.Button();
            this.btnProizvod = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnRacun
            // 
            this.btnRacun.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRacun.Location = new System.Drawing.Point(200, 99);
            this.btnRacun.Name = "btnRacun";
            this.btnRacun.Size = new System.Drawing.Size(351, 100);
            this.btnRacun.TabIndex = 0;
            this.btnRacun.Text = "Racun";
            this.btnRacun.UseVisualStyleBackColor = true;
            this.btnRacun.Click += new System.EventHandler(this.btnRacun_Click);
            // 
            // btnProizvod
            // 
            this.btnProizvod.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProizvod.Location = new System.Drawing.Point(200, 237);
            this.btnProizvod.Name = "btnProizvod";
            this.btnProizvod.Size = new System.Drawing.Size(351, 100);
            this.btnProizvod.TabIndex = 1;
            this.btnProizvod.Text = "Proizvod";
            this.btnProizvod.UseVisualStyleBackColor = true;
            this.btnProizvod.Click += new System.EventHandler(this.btnProizvod_Click);
            // 
            // Rad_Sa_Bazom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnProizvod);
            this.Controls.Add(this.btnRacun);
            this.Name = "Rad_Sa_Bazom";
            this.Text = "Rad_Sa_Bazom";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnRacun;
        private System.Windows.Forms.Button btnProizvod;
    }
}