namespace Deneme_DietHub
{
    partial class Form10_Admin
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
            this.btnEkle = new System.Windows.Forms.Button();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtBesinAdi = new System.Windows.Forms.TextBox();
            this.txtGram = new System.Windows.Forms.TextBox();
            this.txtKalori = new System.Windows.Forms.TextBox();
            this.txtKarbonhidrat = new System.Windows.Forms.TextBox();
            this.txtYag = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtProtein = new System.Windows.Forms.TextBox();
            this.cmbOlcuBirimi = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cbKategori = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(848, 278);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_CellMouseClick);
            // 
            // btnEkle
            // 
            this.btnEkle.Location = new System.Drawing.Point(731, 342);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(106, 46);
            this.btnEkle.TabIndex = 1;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.Location = new System.Drawing.Point(731, 419);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(106, 46);
            this.btnGuncelle.TabIndex = 2;
            this.btnGuncelle.Text = "Güncelle";
            this.btnGuncelle.UseVisualStyleBackColor = true;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // btnSil
            // 
            this.btnSil.Location = new System.Drawing.Point(731, 506);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(106, 46);
            this.btnSil.TabIndex = 3;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 320);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Besin Adı";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 357);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Ölçü Birimi";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 397);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Gram";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 439);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "Kalori";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 476);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 16);
            this.label5.TabIndex = 8;
            this.label5.Text = "Karbonhidrat";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 515);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(32, 16);
            this.label6.TabIndex = 9;
            this.label6.Text = "Yağ";
            // 
            // txtBesinAdi
            // 
            this.txtBesinAdi.Location = new System.Drawing.Point(111, 313);
            this.txtBesinAdi.Name = "txtBesinAdi";
            this.txtBesinAdi.Size = new System.Drawing.Size(137, 22);
            this.txtBesinAdi.TabIndex = 10;
            // 
            // txtGram
            // 
            this.txtGram.Location = new System.Drawing.Point(111, 390);
            this.txtGram.Name = "txtGram";
            this.txtGram.Size = new System.Drawing.Size(137, 22);
            this.txtGram.TabIndex = 12;
            // 
            // txtKalori
            // 
            this.txtKalori.Location = new System.Drawing.Point(111, 432);
            this.txtKalori.Name = "txtKalori";
            this.txtKalori.Size = new System.Drawing.Size(137, 22);
            this.txtKalori.TabIndex = 13;
            // 
            // txtKarbonhidrat
            // 
            this.txtKarbonhidrat.Location = new System.Drawing.Point(111, 469);
            this.txtKarbonhidrat.Name = "txtKarbonhidrat";
            this.txtKarbonhidrat.Size = new System.Drawing.Size(137, 22);
            this.txtKarbonhidrat.TabIndex = 14;
            // 
            // txtYag
            // 
            this.txtYag.Location = new System.Drawing.Point(111, 508);
            this.txtYag.Name = "txtYag";
            this.txtYag.Size = new System.Drawing.Size(137, 22);
            this.txtYag.TabIndex = 15;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 559);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 16);
            this.label7.TabIndex = 16;
            this.label7.Text = "Protein";
            // 
            // txtProtein
            // 
            this.txtProtein.Location = new System.Drawing.Point(111, 552);
            this.txtProtein.Name = "txtProtein";
            this.txtProtein.Size = new System.Drawing.Size(137, 22);
            this.txtProtein.TabIndex = 17;
            // 
            // cmbOlcuBirimi
            // 
            this.cmbOlcuBirimi.FormattingEnabled = true;
            this.cmbOlcuBirimi.Location = new System.Drawing.Point(111, 354);
            this.cmbOlcuBirimi.Name = "cmbOlcuBirimi";
            this.cmbOlcuBirimi.Size = new System.Drawing.Size(137, 24);
            this.cmbOlcuBirimi.TabIndex = 18;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(9, 605);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(57, 16);
            this.label8.TabIndex = 19;
            this.label8.Text = "Kategori";
            // 
            // cbKategori
            // 
            this.cbKategori.FormattingEnabled = true;
            this.cbKategori.Items.AddRange(new object[] {
            "Tahıl ve Ekmek Ürünleri,",
            "Süt ve Süt Ürünleri,",
            "Meyveler,",
            "Balıklar,",
            "Beyaz Et Ürünleri,",
            "Kahvaltı Ürünleri,",
            "Et Ürünleri"});
            this.cbKategori.Location = new System.Drawing.Point(111, 602);
            this.cbKategori.Name = "cbKategori";
            this.cbKategori.Size = new System.Drawing.Size(137, 24);
            this.cbKategori.TabIndex = 20;
            this.cbKategori.SelectedIndexChanged += new System.EventHandler(this.cbKategori_SelectedIndexChanged);
            // 
            // Form10_Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(880, 649);
            this.Controls.Add(this.cbKategori);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.cmbOlcuBirimi);
            this.Controls.Add(this.txtProtein);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtYag);
            this.Controls.Add(this.txtKarbonhidrat);
            this.Controls.Add(this.txtKalori);
            this.Controls.Add(this.txtGram);
            this.Controls.Add(this.txtBesinAdi);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnGuncelle);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form10_Admin";
            this.Text = "Form10_Admin";
            this.Load += new System.EventHandler(this.Form10_Admin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtBesinAdi;
        private System.Windows.Forms.TextBox txtGram;
        private System.Windows.Forms.TextBox txtKalori;
        private System.Windows.Forms.TextBox txtKarbonhidrat;
        private System.Windows.Forms.TextBox txtYag;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtProtein;
        private System.Windows.Forms.ComboBox cmbOlcuBirimi;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cbKategori;
    }
}