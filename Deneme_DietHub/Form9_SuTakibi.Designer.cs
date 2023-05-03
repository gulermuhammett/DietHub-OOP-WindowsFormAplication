namespace Deneme_DietHub
{
    partial class Form9_SuTakibi
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtKilo = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lblHedefSu = new System.Windows.Forms.Label();
            this.btnHesapla = new System.Windows.Forms.Button();
            this.pcGeri = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblBardakSu = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pcGeri)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Su Takibi";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(15, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(489, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Güncel kilonuzu girerek günlük tüketmeniz gereken su miktarını hesaplayabilirsini" +
    "z";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(18, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Kilonuz :";
            // 
            // txtKilo
            // 
            this.txtKilo.Location = new System.Drawing.Point(94, 93);
            this.txtKilo.Name = "txtKilo";
            this.txtKilo.Size = new System.Drawing.Size(100, 22);
            this.txtKilo.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(18, 148);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(130, 16);
            this.label4.TabIndex = 4;
            this.label4.Text = "Günlük Hedef Su :";
            // 
            // lblHedefSu
            // 
            this.lblHedefSu.AutoSize = true;
            this.lblHedefSu.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblHedefSu.Location = new System.Drawing.Point(155, 147);
            this.lblHedefSu.Name = "lblHedefSu";
            this.lblHedefSu.Size = new System.Drawing.Size(15, 16);
            this.lblHedefSu.TabIndex = 5;
            this.lblHedefSu.Text = "0";
            // 
            // btnHesapla
            // 
            this.btnHesapla.Location = new System.Drawing.Point(229, 90);
            this.btnHesapla.Name = "btnHesapla";
            this.btnHesapla.Size = new System.Drawing.Size(87, 28);
            this.btnHesapla.TabIndex = 6;
            this.btnHesapla.Text = "Hesapla";
            this.btnHesapla.UseVisualStyleBackColor = true;
            this.btnHesapla.Click += new System.EventHandler(this.btnHesapla_Click);
            // 
            // pcGeri
            // 
            this.pcGeri.Image = global::Deneme_DietHub.Properties.Resources.geripng;
            this.pcGeri.Location = new System.Drawing.Point(12, 301);
            this.pcGeri.Name = "pcGeri";
            this.pcGeri.Size = new System.Drawing.Size(80, 80);
            this.pcGeri.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcGeri.TabIndex = 7;
            this.pcGeri.TabStop = false;
            this.pcGeri.Click += new System.EventHandler(this.pcGeri_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(21, 196);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(246, 16);
            this.label6.TabIndex = 8;
            this.label6.Text = "Bir bardak su 200 ml olarak belirlenmiştir";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(24, 248);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(202, 16);
            this.label7.TabIndex = 9;
            this.label7.Text = "İçilmesi gereken bardak su :";
            // 
            // lblBardakSu
            // 
            this.lblBardakSu.AutoSize = true;
            this.lblBardakSu.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblBardakSu.Location = new System.Drawing.Point(232, 248);
            this.lblBardakSu.Name = "lblBardakSu";
            this.lblBardakSu.Size = new System.Drawing.Size(15, 16);
            this.lblBardakSu.TabIndex = 10;
            this.lblBardakSu.Text = "0";
            // 
            // Form9_SuTakibi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(568, 393);
            this.Controls.Add(this.lblBardakSu);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.pcGeri);
            this.Controls.Add(this.btnHesapla);
            this.Controls.Add(this.lblHedefSu);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtKilo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form9_SuTakibi";
            this.Text = "Form9_SuTakibi";
            ((System.ComponentModel.ISupportInitialize)(this.pcGeri)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtKilo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblHedefSu;
        private System.Windows.Forms.Button btnHesapla;
        private System.Windows.Forms.PictureBox pcGeri;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblBardakSu;
    }
}