namespace SayiTahminOyunu
{
    partial class Form1
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
            this.lblTahminSayisi = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblTahmin = new System.Windows.Forms.Label();
            this.btnAsagi = new System.Windows.Forms.Button();
            this.btnYukari = new System.Windows.Forms.Button();
            this.btnBaslat = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTahminSayisi
            // 
            this.lblTahminSayisi.AutoSize = true;
            this.lblTahminSayisi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTahminSayisi.Location = new System.Drawing.Point(258, 18);
            this.lblTahminSayisi.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTahminSayisi.Name = "lblTahminSayisi";
            this.lblTahminSayisi.Size = new System.Drawing.Size(18, 20);
            this.lblTahminSayisi.TabIndex = 11;
            this.lblTahminSayisi.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(143, 18);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 20);
            this.label1.TabIndex = 10;
            this.label1.Text = "Tahmin Sayısı :";
            // 
            // lblTahmin
            // 
            this.lblTahmin.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblTahmin.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTahmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 35F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTahmin.Location = new System.Drawing.Point(11, 73);
            this.lblTahmin.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTahmin.Name = "lblTahmin";
            this.lblTahmin.Size = new System.Drawing.Size(125, 72);
            this.lblTahmin.TabIndex = 9;
            this.lblTahmin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnAsagi
            // 
            this.btnAsagi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAsagi.Location = new System.Drawing.Point(163, 111);
            this.btnAsagi.Margin = new System.Windows.Forms.Padding(2);
            this.btnAsagi.Name = "btnAsagi";
            this.btnAsagi.Size = new System.Drawing.Size(104, 34);
            this.btnAsagi.TabIndex = 8;
            this.btnAsagi.Text = "Aşağı";
            this.btnAsagi.UseVisualStyleBackColor = true;
            this.btnAsagi.Click += new System.EventHandler(this.btnAsagi_Click);
            // 
            // btnYukari
            // 
            this.btnYukari.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnYukari.Location = new System.Drawing.Point(163, 73);
            this.btnYukari.Margin = new System.Windows.Forms.Padding(2);
            this.btnYukari.Name = "btnYukari";
            this.btnYukari.Size = new System.Drawing.Size(104, 34);
            this.btnYukari.TabIndex = 7;
            this.btnYukari.Text = "Yukarı";
            this.btnYukari.UseVisualStyleBackColor = true;
            this.btnYukari.Click += new System.EventHandler(this.btnYukari_Click);
            // 
            // btnBaslat
            // 
            this.btnBaslat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnBaslat.Location = new System.Drawing.Point(11, 11);
            this.btnBaslat.Margin = new System.Windows.Forms.Padding(2);
            this.btnBaslat.Name = "btnBaslat";
            this.btnBaslat.Size = new System.Drawing.Size(125, 34);
            this.btnBaslat.TabIndex = 6;
            this.btnBaslat.Text = "Başlat";
            this.btnBaslat.UseVisualStyleBackColor = true;
            this.btnBaslat.Click += new System.EventHandler(this.btnBaslat_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(280, 158);
            this.Controls.Add(this.lblTahminSayisi);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblTahmin);
            this.Controls.Add(this.btnAsagi);
            this.Controls.Add(this.btnYukari);
            this.Controls.Add(this.btnBaslat);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTahminSayisi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblTahmin;
        private System.Windows.Forms.Button btnAsagi;
        private System.Windows.Forms.Button btnYukari;
        private System.Windows.Forms.Button btnBaslat;
    }
}

