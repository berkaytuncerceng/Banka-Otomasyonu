namespace BankaOtomasyon
{
    partial class MusteriEkle
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
            this.txtAd = new System.Windows.Forms.TextBox();
            this.txtSoyad = new System.Windows.Forms.TextBox();
            this.btnEkle = new System.Windows.Forms.Button();
            this.cmbTur = new System.Windows.Forms.ComboBox();
            this.txtMusteriNo = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Yu Gothic UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label1.Location = new System.Drawing.Point(27, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Adı:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Yu Gothic UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label2.Location = new System.Drawing.Point(27, 137);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "Soyadı:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Yu Gothic UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label3.Location = new System.Drawing.Point(27, 182);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 23);
            this.label3.TabIndex = 2;
            this.label3.Text = "Hesap Türü:";
            // 
            // txtAd
            // 
            this.txtAd.Location = new System.Drawing.Point(191, 98);
            this.txtAd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(177, 22);
            this.txtAd.TabIndex = 3;
            // 
            // txtSoyad
            // 
            this.txtSoyad.Location = new System.Drawing.Point(191, 139);
            this.txtSoyad.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSoyad.Name = "txtSoyad";
            this.txtSoyad.Size = new System.Drawing.Size(177, 22);
            this.txtSoyad.TabIndex = 4;
            // 
            // btnEkle
            // 
            this.btnEkle.BackColor = System.Drawing.Color.Silver;
            this.btnEkle.Font = new System.Drawing.Font("Yu Gothic UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnEkle.ForeColor = System.Drawing.SystemColors.WindowText;
            this.btnEkle.Location = new System.Drawing.Point(191, 220);
            this.btnEkle.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(177, 38);
            this.btnEkle.TabIndex = 6;
            this.btnEkle.Text = "Müşteri Ekle";
            this.btnEkle.UseVisualStyleBackColor = false;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // cmbTur
            // 
            this.cmbTur.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTur.FormattingEnabled = true;
            this.cmbTur.Items.AddRange(new object[] {
            "Ticari",
            "Bireysel"});
            this.cmbTur.Location = new System.Drawing.Point(191, 182);
            this.cmbTur.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbTur.Name = "cmbTur";
            this.cmbTur.Size = new System.Drawing.Size(177, 24);
            this.cmbTur.TabIndex = 5;
            // 
            // txtMusteriNo
            // 
            this.txtMusteriNo.Location = new System.Drawing.Point(191, 54);
            this.txtMusteriNo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtMusteriNo.Name = "txtMusteriNo";
            this.txtMusteriNo.Size = new System.Drawing.Size(177, 22);
            this.txtMusteriNo.TabIndex = 1;
            this.txtMusteriNo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMusteriNo_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Yu Gothic UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label4.Location = new System.Drawing.Point(27, 52);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(152, 23);
            this.label4.TabIndex = 12;
            this.label4.Text = "Müşteri Numarası:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(16, 289);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(827, 266);
            this.dataGridView1.TabIndex = 14;
            // 
            // MusteriEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(856, 568);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtMusteriNo);
            this.Controls.Add(this.cmbTur);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.txtSoyad);
            this.Controls.Add(this.txtAd);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "MusteriEkle";
            this.Text = "MÜŞTERİ EKLEME";
            this.Load += new System.EventHandler(this.MusteriEkle_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox txtAd;
        public System.Windows.Forms.TextBox txtSoyad;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.TextBox txtMusteriNo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbTur;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}