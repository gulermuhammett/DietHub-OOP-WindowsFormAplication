namespace Deneme_DietHub
{
    partial class Form4_Hedef
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
            this.btnKiloVermek = new System.Windows.Forms.Button();
            this.btnKiloKoruma = new System.Windows.Forms.Button();
            this.btnKiloAlmak = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pcGeri = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pcGeri)).BeginInit();
            this.SuspendLayout();
            // 
            // btnKiloVermek
            // 
            this.btnKiloVermek.Location = new System.Drawing.Point(183, 218);
            this.btnKiloVermek.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnKiloVermek.Name = "btnKiloVermek";
            this.btnKiloVermek.Size = new System.Drawing.Size(259, 52);
            this.btnKiloVermek.TabIndex = 8;
            this.btnKiloVermek.Text = "Kilo Vermek İstiyorum";
            this.btnKiloVermek.UseVisualStyleBackColor = true;
            this.btnKiloVermek.Click += new System.EventHandler(this.btnKiloVermek_Click);
            // 
            // btnKiloKoruma
            // 
            this.btnKiloKoruma.Location = new System.Drawing.Point(183, 155);
            this.btnKiloKoruma.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnKiloKoruma.Name = "btnKiloKoruma";
            this.btnKiloKoruma.Size = new System.Drawing.Size(259, 52);
            this.btnKiloKoruma.TabIndex = 7;
            this.btnKiloKoruma.Text = "Kilomu Korumak İstiyorum";
            this.btnKiloKoruma.UseVisualStyleBackColor = true;
            this.btnKiloKoruma.Click += new System.EventHandler(this.btnKiloKoruma_Click);
            // 
            // btnKiloAlmak
            // 
            this.btnKiloAlmak.Location = new System.Drawing.Point(183, 96);
            this.btnKiloAlmak.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnKiloAlmak.Name = "btnKiloAlmak";
            this.btnKiloAlmak.Size = new System.Drawing.Size(259, 52);
            this.btnKiloAlmak.TabIndex = 6;
            this.btnKiloAlmak.Text = "Kilo Almak İstiyorum";
            this.btnKiloAlmak.UseVisualStyleBackColor = true;
            this.btnKiloAlmak.Click += new System.EventHandler(this.btnKiloAlmak_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(220, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(183, 32);
            this.label1.TabIndex = 5;
            this.label1.Text = "Hedefin Ne?";
            // 
            // pcGeri
            // 
            this.pcGeri.Image = global::Deneme_DietHub.Properties.Resources.geripng;
            this.pcGeri.Location = new System.Drawing.Point(12, 332);
            this.pcGeri.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pcGeri.Name = "pcGeri";
            this.pcGeri.Size = new System.Drawing.Size(80, 80);
            this.pcGeri.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcGeri.TabIndex = 9;
            this.pcGeri.TabStop = false;
            this.pcGeri.Click += new System.EventHandler(this.pcGeri_Click);
            // 
            // Form4_Hedef
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(636, 423);
            this.Controls.Add(this.pcGeri);
            this.Controls.Add(this.btnKiloVermek);
            this.Controls.Add(this.btnKiloKoruma);
            this.Controls.Add(this.btnKiloAlmak);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form4_Hedef";
            this.Text = "Form4_Hedef";
            ((System.ComponentModel.ISupportInitialize)(this.pcGeri)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pcGeri;
        private System.Windows.Forms.Button btnKiloVermek;
        private System.Windows.Forms.Button btnKiloKoruma;
        private System.Windows.Forms.Button btnKiloAlmak;
        private System.Windows.Forms.Label label1;
    }
}