
namespace Prodavnica
{
    partial class Form1
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
            this.btnRadSaRacunom = new System.Windows.Forms.Button();
            this.btnRadSaBazom = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnRadSaRacunom
            // 
            this.btnRadSaRacunom.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRadSaRacunom.Location = new System.Drawing.Point(144, 60);
            this.btnRadSaRacunom.Name = "btnRadSaRacunom";
            this.btnRadSaRacunom.Size = new System.Drawing.Size(502, 128);
            this.btnRadSaRacunom.TabIndex = 0;
            this.btnRadSaRacunom.Text = "Racun";
            this.btnRadSaRacunom.UseVisualStyleBackColor = true;
            this.btnRadSaRacunom.Click += new System.EventHandler(this.btnRadSaRacunom_Click);
            // 
            // btnRadSaBazom
            // 
            this.btnRadSaBazom.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRadSaBazom.Location = new System.Drawing.Point(144, 264);
            this.btnRadSaBazom.Name = "btnRadSaBazom";
            this.btnRadSaBazom.Size = new System.Drawing.Size(502, 128);
            this.btnRadSaBazom.TabIndex = 1;
            this.btnRadSaBazom.Text = "Izmena podataka";
            this.btnRadSaBazom.UseVisualStyleBackColor = true;
            this.btnRadSaBazom.Click += new System.EventHandler(this.btnRadSaBazom_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnRadSaBazom);
            this.Controls.Add(this.btnRadSaRacunom);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnRadSaRacunom;
        private System.Windows.Forms.Button btnRadSaBazom;
    }
}

