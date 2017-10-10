namespace FaturaUygulama
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
            this.cmbFaturaTip = new System.Windows.Forms.ComboBox();
            this.lblFaturaSec = new System.Windows.Forms.Label();
            this.lblilk = new System.Windows.Forms.Label();
            this.lblSon = new System.Windows.Forms.Label();
            this.lblFark = new System.Windows.Forms.Label();
            this.lblEndeks2 = new System.Windows.Forms.Label();
            this.lblEndeks1 = new System.Windows.Forms.Label();
            this.lblMiktar = new System.Windows.Forms.Label();
            this.btnHesapla = new System.Windows.Forms.Button();
            this.lblTutar = new System.Windows.Forms.Label();
            this.lblTutarC = new System.Windows.Forms.Label();
            this.lblTarih = new System.Windows.Forms.Label();
            this.lblTarihC = new System.Windows.Forms.Label();
            this.lblAdsoyad = new System.Windows.Forms.Label();
            this.lblIsım = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cmbFaturaTip
            // 
            this.cmbFaturaTip.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbFaturaTip.FormattingEnabled = true;
            this.cmbFaturaTip.Location = new System.Drawing.Point(228, 108);
            this.cmbFaturaTip.Name = "cmbFaturaTip";
            this.cmbFaturaTip.Size = new System.Drawing.Size(256, 24);
            this.cmbFaturaTip.TabIndex = 0;
            this.cmbFaturaTip.SelectedIndexChanged += new System.EventHandler(this.cmbFaturaTip_SelectedIndexChanged_1);
            // 
            // lblFaturaSec
            // 
            this.lblFaturaSec.AutoSize = true;
            this.lblFaturaSec.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFaturaSec.Location = new System.Drawing.Point(109, 108);
            this.lblFaturaSec.Name = "lblFaturaSec";
            this.lblFaturaSec.Size = new System.Drawing.Size(87, 16);
            this.lblFaturaSec.TabIndex = 1;
            this.lblFaturaSec.Text = "Fatura Türü";
            // 
            // lblilk
            // 
            this.lblilk.AutoSize = true;
            this.lblilk.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblilk.Location = new System.Drawing.Point(109, 143);
            this.lblilk.Name = "lblilk";
            this.lblilk.Size = new System.Drawing.Size(88, 16);
            this.lblilk.TabIndex = 1;
            this.lblilk.Text = "İlk Endeks :";
            // 
            // lblSon
            // 
            this.lblSon.AutoSize = true;
            this.lblSon.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSon.Location = new System.Drawing.Point(109, 180);
            this.lblSon.Name = "lblSon";
            this.lblSon.Size = new System.Drawing.Size(99, 16);
            this.lblSon.TabIndex = 1;
            this.lblSon.Text = "Son Endeks :";
            // 
            // lblFark
            // 
            this.lblFark.AutoSize = true;
            this.lblFark.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFark.Location = new System.Drawing.Point(109, 218);
            this.lblFark.Name = "lblFark";
            this.lblFark.Size = new System.Drawing.Size(124, 16);
            this.lblFark.TabIndex = 1;
            this.lblFark.Text = "Kullanim Miktari :";
            // 
            // lblEndeks2
            // 
            this.lblEndeks2.AutoSize = true;
            this.lblEndeks2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEndeks2.Location = new System.Drawing.Point(249, 180);
            this.lblEndeks2.Name = "lblEndeks2";
            this.lblEndeks2.Size = new System.Drawing.Size(0, 16);
            this.lblEndeks2.TabIndex = 1;
            // 
            // lblEndeks1
            // 
            this.lblEndeks1.AutoSize = true;
            this.lblEndeks1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEndeks1.Location = new System.Drawing.Point(249, 143);
            this.lblEndeks1.Name = "lblEndeks1";
            this.lblEndeks1.Size = new System.Drawing.Size(0, 16);
            this.lblEndeks1.TabIndex = 1;
            // 
            // lblMiktar
            // 
            this.lblMiktar.AutoSize = true;
            this.lblMiktar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMiktar.Location = new System.Drawing.Point(249, 218);
            this.lblMiktar.Name = "lblMiktar";
            this.lblMiktar.Size = new System.Drawing.Size(0, 16);
            this.lblMiktar.TabIndex = 1;
            // 
            // btnHesapla
            // 
            this.btnHesapla.BackColor = System.Drawing.Color.Red;
            this.btnHesapla.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHesapla.ForeColor = System.Drawing.Color.Cornsilk;
            this.btnHesapla.Location = new System.Drawing.Point(238, 273);
            this.btnHesapla.Name = "btnHesapla";
            this.btnHesapla.Size = new System.Drawing.Size(154, 82);
            this.btnHesapla.TabIndex = 2;
            this.btnHesapla.Text = "Hesapla";
            this.btnHesapla.UseVisualStyleBackColor = false;
            this.btnHesapla.Click += new System.EventHandler(this.btnHesapla_Click);
            // 
            // lblTutar
            // 
            this.lblTutar.AutoSize = true;
            this.lblTutar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTutar.Location = new System.Drawing.Point(234, 377);
            this.lblTutar.Name = "lblTutar";
            this.lblTutar.Size = new System.Drawing.Size(127, 16);
            this.lblTutar.TabIndex = 1;
            this.lblTutar.Text = "Ödenecek Tutar :";
            // 
            // lblTutarC
            // 
            this.lblTutarC.AutoSize = true;
            this.lblTutarC.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTutarC.ForeColor = System.Drawing.Color.Red;
            this.lblTutarC.Location = new System.Drawing.Point(375, 377);
            this.lblTutarC.Name = "lblTutarC";
            this.lblTutarC.Size = new System.Drawing.Size(16, 16);
            this.lblTutarC.TabIndex = 1;
            this.lblTutarC.Text = "0";
            // 
            // lblTarih
            // 
            this.lblTarih.AutoSize = true;
            this.lblTarih.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTarih.ForeColor = System.Drawing.Color.DarkGreen;
            this.lblTarih.Location = new System.Drawing.Point(531, 250);
            this.lblTarih.Name = "lblTarih";
            this.lblTarih.Size = new System.Drawing.Size(56, 16);
            this.lblTarih.TabIndex = 3;
            this.lblTarih.Text = "Tarih : ";
            // 
            // lblTarihC
            // 
            this.lblTarihC.AutoSize = true;
            this.lblTarihC.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTarihC.ForeColor = System.Drawing.Color.DarkGreen;
            this.lblTarihC.Location = new System.Drawing.Point(497, 274);
            this.lblTarihC.Name = "lblTarihC";
            this.lblTarihC.Size = new System.Drawing.Size(0, 16);
            this.lblTarihC.TabIndex = 3;
            // 
            // lblAdsoyad
            // 
            this.lblAdsoyad.AutoSize = true;
            this.lblAdsoyad.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdsoyad.ForeColor = System.Drawing.Color.DarkGreen;
            this.lblAdsoyad.Location = new System.Drawing.Point(284, 22);
            this.lblAdsoyad.Name = "lblAdsoyad";
            this.lblAdsoyad.Size = new System.Drawing.Size(0, 18);
            this.lblAdsoyad.TabIndex = 4;
            // 
            // lblIsım
            // 
            this.lblIsım.AutoSize = true;
            this.lblIsım.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIsım.ForeColor = System.Drawing.Color.DarkGreen;
            this.lblIsım.Location = new System.Drawing.Point(144, 22);
            this.lblIsım.Name = "lblIsım";
            this.lblIsım.Size = new System.Drawing.Size(86, 20);
            this.lblIsım.TabIndex = 5;
            this.lblIsım.Text = "Ad Soyad :";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HighlightText;
            this.ClientSize = new System.Drawing.Size(687, 437);
            this.Controls.Add(this.lblAdsoyad);
            this.Controls.Add(this.lblIsım);
            this.Controls.Add(this.lblTarihC);
            this.Controls.Add(this.lblTarih);
            this.Controls.Add(this.btnHesapla);
            this.Controls.Add(this.lblEndeks1);
            this.Controls.Add(this.lblMiktar);
            this.Controls.Add(this.lblEndeks2);
            this.Controls.Add(this.lblTutarC);
            this.Controls.Add(this.lblTutar);
            this.Controls.Add(this.lblFark);
            this.Controls.Add(this.lblSon);
            this.Controls.Add(this.lblilk);
            this.Controls.Add(this.lblFaturaSec);
            this.Controls.Add(this.cmbFaturaTip);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbFaturaTip;
        private System.Windows.Forms.Label lblFaturaSec;
        private System.Windows.Forms.Label lblilk;
        private System.Windows.Forms.Label lblSon;
        private System.Windows.Forms.Label lblFark;
        private System.Windows.Forms.Label lblEndeks2;
        private System.Windows.Forms.Label lblEndeks1;
        private System.Windows.Forms.Label lblMiktar;
        private System.Windows.Forms.Button btnHesapla;
        private System.Windows.Forms.Label lblTutar;
        private System.Windows.Forms.Label lblTutarC;
        private System.Windows.Forms.Label lblTarih;
        private System.Windows.Forms.Label lblTarihC;
        private System.Windows.Forms.Label lblAdsoyad;
        private System.Windows.Forms.Label lblIsım;
    }
}

