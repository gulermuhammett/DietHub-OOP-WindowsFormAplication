namespace Deneme_DietHub.Resources
{
    partial class Form7_Raporlar
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnOgunSil = new System.Windows.Forms.Button();
            this.btnOgunGuncelle = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(8, 23);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(451, 185);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_CellMouseClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnOgunSil);
            this.groupBox1.Controls.Add(this.btnOgunGuncelle);
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Location = new System.Drawing.Point(17, 16);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(483, 441);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // btnOgunSil
            // 
            this.btnOgunSil.Location = new System.Drawing.Point(148, 229);
            this.btnOgunSil.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnOgunSil.Name = "btnOgunSil";
            this.btnOgunSil.Size = new System.Drawing.Size(117, 38);
            this.btnOgunSil.TabIndex = 15;
            this.btnOgunSil.Text = "Sil";
            this.btnOgunSil.UseVisualStyleBackColor = true;
            // 
            // btnOgunGuncelle
            // 
            this.btnOgunGuncelle.Location = new System.Drawing.Point(8, 229);
            this.btnOgunGuncelle.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnOgunGuncelle.Name = "btnOgunGuncelle";
            this.btnOgunGuncelle.Size = new System.Drawing.Size(117, 38);
            this.btnOgunGuncelle.TabIndex = 14;
            this.btnOgunGuncelle.Text = "Güncelle";
            this.btnOgunGuncelle.UseVisualStyleBackColor = true;
            this.btnOgunGuncelle.Click += new System.EventHandler(this.btnOgunGuncelle_Click);
            // 
            // Form7_Raporlar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(697, 559);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form7_Raporlar";
            this.Text = "Form7_Raporlar";
            this.Load += new System.EventHandler(this.Form7_Raporlar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnOgunSil;
        private System.Windows.Forms.Button btnOgunGuncelle;
    }
}