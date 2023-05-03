namespace Deneme_DietHub
{
    partial class Form5_Aktivite
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
            this.btnCokHareketli = new System.Windows.Forms.Button();
            this.btnAktif = new System.Windows.Forms.Button();
            this.btnAzHareketli = new System.Windows.Forms.Button();
            this.btnPekHareketliDegil = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pcGeri = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pcGeri)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCokHareketli
            // 
            this.btnCokHareketli.Location = new System.Drawing.Point(185, 388);
            this.btnCokHareketli.Name = "btnCokHareketli";
            this.btnCokHareketli.Size = new System.Drawing.Size(457, 91);
            this.btnCokHareketli.TabIndex = 10;
            this.btnCokHareketli.Text = "Çok Hareketli";
            this.btnCokHareketli.UseVisualStyleBackColor = true;
            this.btnCokHareketli.Click += new System.EventHandler(this.btnCokHareketli_Click);
            // 
            // btnAktif
            // 
            this.btnAktif.Location = new System.Drawing.Point(185, 291);
            this.btnAktif.Name = "btnAktif";
            this.btnAktif.Size = new System.Drawing.Size(457, 91);
            this.btnAktif.TabIndex = 9;
            this.btnAktif.Text = "Aktif";
            this.btnAktif.UseVisualStyleBackColor = true;
            this.btnAktif.Click += new System.EventHandler(this.btnAktif_Click);
            // 
            // btnAzHareketli
            // 
            this.btnAzHareketli.Location = new System.Drawing.Point(185, 194);
            this.btnAzHareketli.Name = "btnAzHareketli";
            this.btnAzHareketli.Size = new System.Drawing.Size(457, 91);
            this.btnAzHareketli.TabIndex = 8;
            this.btnAzHareketli.Text = "Az Hareketli";
            this.btnAzHareketli.UseVisualStyleBackColor = true;
            this.btnAzHareketli.Click += new System.EventHandler(this.btnAzHareketli_Click);
            // 
            // btnPekHareketliDegil
            // 
            this.btnPekHareketliDegil.Location = new System.Drawing.Point(185, 97);
            this.btnPekHareketliDegil.Name = "btnPekHareketliDegil";
            this.btnPekHareketliDegil.Size = new System.Drawing.Size(457, 91);
            this.btnPekHareketliDegil.TabIndex = 7;
            this.btnPekHareketliDegil.Text = "Pek Hareketli Değil";
            this.btnPekHareketliDegil.UseVisualStyleBackColor = true;
            this.btnPekHareketliDegil.Click += new System.EventHandler(this.btnPekHareketliDegil_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(312, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(216, 32);
            this.label1.TabIndex = 6;
            this.label1.Text = "Aktivite Düzeyi";
            // 
            // pcGeri
            // 
            this.pcGeri.Image = global::Deneme_DietHub.Properties.Resources.geripng;
            this.pcGeri.Location = new System.Drawing.Point(21, 516);
            this.pcGeri.Name = "pcGeri";
            this.pcGeri.Size = new System.Drawing.Size(80, 80);
            this.pcGeri.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcGeri.TabIndex = 11;
            this.pcGeri.TabStop = false;
            this.pcGeri.Click += new System.EventHandler(this.pcGeri_Click);
            // 
            // Form5_Aktivite
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(797, 616);
            this.Controls.Add(this.pcGeri);
            this.Controls.Add(this.btnCokHareketli);
            this.Controls.Add(this.btnAktif);
            this.Controls.Add(this.btnAzHareketli);
            this.Controls.Add(this.btnPekHareketliDegil);
            this.Controls.Add(this.label1);
            this.Name = "Form5_Aktivite";
            this.Text = "Form5_Aktivite";
            ((System.ComponentModel.ISupportInitialize)(this.pcGeri)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pcGeri;
        private System.Windows.Forms.Button btnCokHareketli;
        private System.Windows.Forms.Button btnAktif;
        private System.Windows.Forms.Button btnAzHareketli;
        private System.Windows.Forms.Button btnPekHareketliDegil;
        private System.Windows.Forms.Label label1;
    }
}