namespace BankaOtomasyon
{
    partial class HesapSil
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
            this.txtHesapNo = new System.Windows.Forms.TextBox();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnİptal = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.btnYenile = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(0, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(315, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "Silmek İstediğiniz Hesap Numarası:";
            // 
            // txtHesapNo
            // 
            this.txtHesapNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtHesapNo.Location = new System.Drawing.Point(324, 29);
            this.txtHesapNo.Name = "txtHesapNo";
            this.txtHesapNo.Size = new System.Drawing.Size(262, 26);
            this.txtHesapNo.TabIndex = 1;
            this.txtHesapNo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtHesapNo_KeyPress);
            // 
            // btnSil
            // 
            this.btnSil.BackColor = System.Drawing.Color.Silver;
            this.btnSil.Font = new System.Drawing.Font("Yu Gothic UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSil.ForeColor = System.Drawing.SystemColors.WindowText;
            this.btnSil.Location = new System.Drawing.Point(324, 61);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(144, 38);
            this.btnSil.TabIndex = 2;
            this.btnSil.Text = "Hesabı Sil";
            this.btnSil.UseVisualStyleBackColor = false;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnİptal
            // 
            this.btnİptal.BackColor = System.Drawing.Color.Silver;
            this.btnİptal.Font = new System.Drawing.Font("Yu Gothic UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnİptal.Location = new System.Drawing.Point(473, 61);
            this.btnİptal.Name = "btnİptal";
            this.btnİptal.Size = new System.Drawing.Size(113, 38);
            this.btnİptal.TabIndex = 6;
            this.btnİptal.Text = "İptal";
            this.btnİptal.UseVisualStyleBackColor = false;
            this.btnİptal.Click += new System.EventHandler(this.btnİptal_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(-9, 232);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(856, 280);
            this.dataGridView1.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(0, 196);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 25);
            this.label2.TabIndex = 9;
            // 
            // btnYenile
            // 
            this.btnYenile.BackColor = System.Drawing.Color.Silver;
            this.btnYenile.Font = new System.Drawing.Font("Yu Gothic UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnYenile.ForeColor = System.Drawing.SystemColors.WindowText;
            this.btnYenile.Location = new System.Drawing.Point(324, 106);
            this.btnYenile.Margin = new System.Windows.Forms.Padding(4);
            this.btnYenile.Name = "btnYenile";
            this.btnYenile.Size = new System.Drawing.Size(262, 51);
            this.btnYenile.TabIndex = 7;
            this.btnYenile.Text = "Kayıt Defteri Güncelle";
            this.btnYenile.UseVisualStyleBackColor = false;
            this.btnYenile.Click += new System.EventHandler(this.btnYenile_Click);
            // 
            // HesapSil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(843, 507);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnYenile);
            this.Controls.Add(this.btnİptal);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.txtHesapNo);
            this.Controls.Add(this.label1);
            this.Name = "HesapSil";
            this.Text = "HESAP SİLME";
            this.Load += new System.EventHandler(this.HesapSil_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtHesapNo;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnİptal;
        public System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnYenile;
    }
}