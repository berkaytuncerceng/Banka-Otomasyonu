namespace BankaOtomasyon
{
    partial class HesapAc
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
            this.txtMusteriNo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnHesapAc = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnYenile = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtMusteriNo
            // 
            this.txtMusteriNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtMusteriNo.Location = new System.Drawing.Point(197, 27);
            this.txtMusteriNo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtMusteriNo.Name = "txtMusteriNo";
            this.txtMusteriNo.Size = new System.Drawing.Size(205, 30);
            this.txtMusteriNo.TabIndex = 0;
            this.txtMusteriNo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMusteriNo_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Yu Gothic UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(12, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Müşteri Numarası:";
            // 
            // btnHesapAc
            // 
            this.btnHesapAc.BackColor = System.Drawing.Color.Silver;
            this.btnHesapAc.Font = new System.Drawing.Font("Yu Gothic UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnHesapAc.ForeColor = System.Drawing.SystemColors.WindowText;
            this.btnHesapAc.Location = new System.Drawing.Point(17, 73);
            this.btnHesapAc.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnHesapAc.Name = "btnHesapAc";
            this.btnHesapAc.Size = new System.Drawing.Size(236, 42);
            this.btnHesapAc.TabIndex = 2;
            this.btnHesapAc.Text = "Hesap Aç";
            this.btnHesapAc.UseVisualStyleBackColor = false;
            this.btnHesapAc.Click += new System.EventHandler(this.btnHesapAc_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 190);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(851, 325);
            this.dataGridView1.TabIndex = 3;
            // 
            // btnYenile
            // 
            this.btnYenile.BackColor = System.Drawing.Color.Silver;
            this.btnYenile.Font = new System.Drawing.Font("Yu Gothic UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnYenile.ForeColor = System.Drawing.SystemColors.WindowText;
            this.btnYenile.Location = new System.Drawing.Point(289, 73);
            this.btnYenile.Margin = new System.Windows.Forms.Padding(4);
            this.btnYenile.Name = "btnYenile";
            this.btnYenile.Size = new System.Drawing.Size(253, 42);
            this.btnYenile.TabIndex = 4;
            this.btnYenile.Text = "Kayıt Defteri Güncelle";
            this.btnYenile.UseVisualStyleBackColor = false;
            this.btnYenile.Click += new System.EventHandler(this.btnYenile_Click);
            // 
            // HesapAc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(875, 515);
            this.Controls.Add(this.btnYenile);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnHesapAc);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtMusteriNo);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "HesapAc";
            this.Text = "HESAP AÇMA";
            this.Load += new System.EventHandler(this.HesapAc_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtMusteriNo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnHesapAc;
        private System.Windows.Forms.Button btnYenile;
        public System.Windows.Forms.DataGridView dataGridView1;
    }
}