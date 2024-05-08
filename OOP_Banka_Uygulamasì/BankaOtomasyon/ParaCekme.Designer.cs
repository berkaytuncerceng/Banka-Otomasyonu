namespace BankaOtomasyon
{
    partial class ParaCekme
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
            this.btnParaCek = new System.Windows.Forms.Button();
            this.TxtPara = new System.Windows.Forms.TextBox();
            this.txtHesapNo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnParaCek
            // 
            this.btnParaCek.BackColor = System.Drawing.Color.Silver;
            this.btnParaCek.Font = new System.Drawing.Font("Yu Gothic UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnParaCek.ForeColor = System.Drawing.SystemColors.WindowText;
            this.btnParaCek.Location = new System.Drawing.Point(28, 266);
            this.btnParaCek.Margin = new System.Windows.Forms.Padding(4);
            this.btnParaCek.Name = "btnParaCek";
            this.btnParaCek.Size = new System.Drawing.Size(237, 45);
            this.btnParaCek.TabIndex = 11;
            this.btnParaCek.Text = "Para Çekme";
            this.btnParaCek.UseVisualStyleBackColor = false;
            this.btnParaCek.Click += new System.EventHandler(this.btnParaCek_Click);
            // 
            // TxtPara
            // 
            this.TxtPara.Location = new System.Drawing.Point(171, 156);
            this.TxtPara.Margin = new System.Windows.Forms.Padding(4);
            this.TxtPara.Name = "TxtPara";
            this.TxtPara.Size = new System.Drawing.Size(123, 22);
            this.TxtPara.TabIndex = 10;
            this.TxtPara.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtHesapNo_KeyPress);
            // 
            // txtHesapNo
            // 
            this.txtHesapNo.Location = new System.Drawing.Point(171, 96);
            this.txtHesapNo.Margin = new System.Windows.Forms.Padding(4);
            this.txtHesapNo.Name = "txtHesapNo";
            this.txtHesapNo.Size = new System.Drawing.Size(123, 22);
            this.txtHesapNo.TabIndex = 9;
            this.txtHesapNo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtHesapNo_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Yu Gothic UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(12, 156);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 23);
            this.label1.TabIndex = 15;
            this.label1.Text = "Çekilecek Tutar:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Yu Gothic UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(12, 96);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 23);
            this.label4.TabIndex = 14;
            this.label4.Text = "Hesap No:";
            // 
            // ParaCekme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(307, 399);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnParaCek);
            this.Controls.Add(this.TxtPara);
            this.Controls.Add(this.txtHesapNo);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ParaCekme";
            this.Text = "PARA ÇEKME";
            this.Load += new System.EventHandler(this.ParaCekme_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnParaCek;
        private System.Windows.Forms.TextBox TxtPara;
        private System.Windows.Forms.TextBox txtHesapNo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
    }
}