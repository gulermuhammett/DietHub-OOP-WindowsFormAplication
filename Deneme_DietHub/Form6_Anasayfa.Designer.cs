namespace Deneme_DietHub
{
    partial class Form6_Anasayfa
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
            this.btnHedefler = new System.Windows.Forms.Button();
            this.btnSuTakibi = new System.Windows.Forms.Button();
            this.btnVucutAnalizi = new System.Windows.Forms.Button();
            this.btnKaloriTakibi = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnHedefler
            // 
            this.btnHedefler.Location = new System.Drawing.Point(60, 271);
            this.btnHedefler.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnHedefler.Name = "btnHedefler";
            this.btnHedefler.Size = new System.Drawing.Size(168, 46);
            this.btnHedefler.TabIndex = 11;
            this.btnHedefler.Text = "Raporlar";
            this.btnHedefler.UseVisualStyleBackColor = true;
            this.btnHedefler.Click += new System.EventHandler(this.btnHedefler_Click);
            // 
            // btnSuTakibi
            // 
            this.btnSuTakibi.Location = new System.Drawing.Point(60, 208);
            this.btnSuTakibi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSuTakibi.Name = "btnSuTakibi";
            this.btnSuTakibi.Size = new System.Drawing.Size(168, 46);
            this.btnSuTakibi.TabIndex = 8;
            this.btnSuTakibi.Text = "Su Takibi";
            this.btnSuTakibi.UseVisualStyleBackColor = true;
            this.btnSuTakibi.Click += new System.EventHandler(this.btnSuTakibi_Click);
            // 
            // btnVucutAnalizi
            // 
            this.btnVucutAnalizi.Location = new System.Drawing.Point(60, 151);
            this.btnVucutAnalizi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnVucutAnalizi.Name = "btnVucutAnalizi";
            this.btnVucutAnalizi.Size = new System.Drawing.Size(168, 46);
            this.btnVucutAnalizi.TabIndex = 7;
            this.btnVucutAnalizi.Text = "Vücut Analizi";
            this.btnVucutAnalizi.UseVisualStyleBackColor = true;
            this.btnVucutAnalizi.Click += new System.EventHandler(this.btnVucutAnalizi_Click);
            // 
            // btnKaloriTakibi
            // 
            this.btnKaloriTakibi.Location = new System.Drawing.Point(60, 94);
            this.btnKaloriTakibi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnKaloriTakibi.Name = "btnKaloriTakibi";
            this.btnKaloriTakibi.Size = new System.Drawing.Size(168, 46);
            this.btnKaloriTakibi.TabIndex = 6;
            this.btnKaloriTakibi.Text = "Kalori Takibi";
            this.btnKaloriTakibi.UseVisualStyleBackColor = true;
            this.btnKaloriTakibi.Click += new System.EventHandler(this.btnKaloriTakibi_Click);
            // 
            // Form6_Anasayfa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(332, 454);
            this.Controls.Add(this.btnHedefler);
            this.Controls.Add(this.btnSuTakibi);
            this.Controls.Add(this.btnVucutAnalizi);
            this.Controls.Add(this.btnKaloriTakibi);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form6_Anasayfa";
            this.Text = "Form6_Anasayfa";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnHedefler;
        private System.Windows.Forms.Button btnSuTakibi;
        private System.Windows.Forms.Button btnVucutAnalizi;
        private System.Windows.Forms.Button btnKaloriTakibi;
    }
}