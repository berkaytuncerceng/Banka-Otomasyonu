namespace BankaOtomasyon
{
    partial class frmHavale
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
            this.txtGonderenHesap = new System.Windows.Forms.TextBox();
            this.txtAlanHesap = new System.Windows.Forms.TextBox();
            this.txtPara = new System.Windows.Forms.TextBox();
            this.btnGonder = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btnIptal = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtGonderenHesap
            // 
            this.txtGonderenHesap.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtGonderenHesap.Location = new System.Drawing.Point(224, 63);
            this.txtGonderenHesap.Margin = new System.Windows.Forms.Padding(4);
            this.txtGonderenHesap.Name = "txtGonderenHesap";
            this.txtGonderenHesap.Size = new System.Drawing.Size(185, 26);
            this.txtGonderenHesap.TabIndex = 3;
            this.txtGonderenHesap.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtGonderenHesap_KeyPress);
            // 
            // txtAlanHesap
            // 
            this.txtAlanHesap.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtAlanHesap.Location = new System.Drawing.Point(224, 108);
            this.txtAlanHesap.Margin = new System.Windows.Forms.Padding(4);
            this.txtAlanHesap.Name = "txtAlanHesap";
            this.txtAlanHesap.Size = new System.Drawing.Size(185, 26);
            this.txtAlanHesap.TabIndex = 4;
            this.txtAlanHesap.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAlanHesap_KeyPress);
            // 
            // txtPara
            // 
            this.txtPara.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtPara.Location = new System.Drawing.Point(224, 160);
            this.txtPara.Margin = new System.Windows.Forms.Padding(4);
            this.txtPara.Name = "txtPara";
            this.txtPara.Size = new System.Drawing.Size(185, 26);
            this.txtPara.TabIndex = 5;
            this.txtPara.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAlanHesap_KeyPress);
            // 
            // btnGonder
            // 
            this.btnGonder.BackColor = System.Drawing.Color.Silver;
            this.btnGonder.Font = new System.Drawing.Font("Yu Gothic UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGonder.ForeColor = System.Drawing.SystemColors.WindowText;
            this.btnGonder.Location = new System.Drawing.Point(224, 202);
            this.btnGonder.Margin = new System.Windows.Forms.Padding(4);
            this.btnGonder.Name = "btnGonder";
            this.btnGonder.Size = new System.Drawing.Size(185, 49);
            this.btnGonder.TabIndex = 6;
            this.btnGonder.Text = "Parayı Gönder";
            this.btnGonder.UseVisualStyleBackColor = false;
            this.btnGonder.Click += new System.EventHandler(this.btnGonder_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Yu Gothic UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(12, 160);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(117, 25);
            this.label6.TabIndex = 14;
            this.label6.Text = "Havale Tutarı:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Yu Gothic UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(12, 108);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(134, 25);
            this.label7.TabIndex = 13;
            this.label7.Text = "Alıcı Hesap No:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Yu Gothic UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(9, 64);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(183, 25);
            this.label8.TabIndex = 12;
            this.label8.Text = " Gönderen Hesap No:";
            // 
            // btnIptal
            // 
            this.btnIptal.BackColor = System.Drawing.Color.Silver;
            this.btnIptal.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.btnIptal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIptal.Font = new System.Drawing.Font("Yu Gothic UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnIptal.Location = new System.Drawing.Point(224, 257);
            this.btnIptal.Name = "btnIptal";
            this.btnIptal.Size = new System.Drawing.Size(185, 37);
            this.btnIptal.TabIndex = 15;
            this.btnIptal.Text = "İptal";
            this.btnIptal.UseVisualStyleBackColor = false;
            this.btnIptal.Click += new System.EventHandler(this.btnIptal_Click);
            // 
            // frmHavale
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(452, 381);
            this.Controls.Add(this.btnIptal);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btnGonder);
            this.Controls.Add(this.txtPara);
            this.Controls.Add(this.txtAlanHesap);
            this.Controls.Add(this.txtGonderenHesap);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmHavale";
            this.Text = "HAVALE";
            this.Load += new System.EventHandler(this.frmHavale_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtGonderenHesap;
        private System.Windows.Forms.TextBox txtAlanHesap;
        private System.Windows.Forms.TextBox txtPara;
        private System.Windows.Forms.Button btnGonder;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnIptal;
    }
}