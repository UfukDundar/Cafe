namespace Cafe
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
            this.grpMasalar = new System.Windows.Forms.GroupBox();
            this.grpSiparis = new System.Windows.Forms.GroupBox();
            this.cmBoxYemek = new System.Windows.Forms.ComboBox();
            this.cmBoxIcecek = new System.Windows.Forms.ComboBox();
            this.numYemekMiktar = new System.Windows.Forms.NumericUpDown();
            this.numIcecekMiktar = new System.Windows.Forms.NumericUpDown();
            this.btnSiparisEkle = new System.Windows.Forms.Button();
            this.lstSiparis = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblMasaNo = new System.Windows.Forms.Label();
            this.btnOde = new System.Windows.Forms.Button();
            this.rbtnTl = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.txtToplamTutar = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.grpSiparis.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numYemekMiktar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numIcecekMiktar)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpMasalar
            // 
            this.grpMasalar.Location = new System.Drawing.Point(12, 12);
            this.grpMasalar.Name = "grpMasalar";
            this.grpMasalar.Size = new System.Drawing.Size(361, 218);
            this.grpMasalar.TabIndex = 0;
            this.grpMasalar.TabStop = false;
            this.grpMasalar.Text = "groupBox1";
            // 
            // grpSiparis
            // 
            this.grpSiparis.Controls.Add(this.label4);
            this.grpSiparis.Controls.Add(this.label3);
            this.grpSiparis.Controls.Add(this.label2);
            this.grpSiparis.Controls.Add(this.label1);
            this.grpSiparis.Controls.Add(this.btnSiparisEkle);
            this.grpSiparis.Controls.Add(this.numIcecekMiktar);
            this.grpSiparis.Controls.Add(this.numYemekMiktar);
            this.grpSiparis.Controls.Add(this.cmBoxIcecek);
            this.grpSiparis.Controls.Add(this.cmBoxYemek);
            this.grpSiparis.Location = new System.Drawing.Point(12, 283);
            this.grpSiparis.Name = "grpSiparis";
            this.grpSiparis.Size = new System.Drawing.Size(361, 218);
            this.grpSiparis.TabIndex = 1;
            this.grpSiparis.TabStop = false;
            this.grpSiparis.Text = "groupBox2";
            // 
            // cmBoxYemek
            // 
            this.cmBoxYemek.FormattingEnabled = true;
            this.cmBoxYemek.Items.AddRange(new object[] {
            "Kuru Fasulye",
            "Tavuklu Pilav",
            "Pizza ",
            "Hamburger",
            "Tost"});
            this.cmBoxYemek.Location = new System.Drawing.Point(22, 47);
            this.cmBoxYemek.Name = "cmBoxYemek";
            this.cmBoxYemek.Size = new System.Drawing.Size(121, 24);
            this.cmBoxYemek.TabIndex = 0;
            // 
            // cmBoxIcecek
            // 
            this.cmBoxIcecek.FormattingEnabled = true;
            this.cmBoxIcecek.Items.AddRange(new object[] {
            "Cola",
            "Fanta",
            "Çay",
            "Su",
            "Kahve"});
            this.cmBoxIcecek.Location = new System.Drawing.Point(22, 102);
            this.cmBoxIcecek.Name = "cmBoxIcecek";
            this.cmBoxIcecek.Size = new System.Drawing.Size(121, 24);
            this.cmBoxIcecek.TabIndex = 1;
            // 
            // numYemekMiktar
            // 
            this.numYemekMiktar.Location = new System.Drawing.Point(204, 48);
            this.numYemekMiktar.Name = "numYemekMiktar";
            this.numYemekMiktar.Size = new System.Drawing.Size(120, 22);
            this.numYemekMiktar.TabIndex = 2;
            this.numYemekMiktar.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // numIcecekMiktar
            // 
            this.numIcecekMiktar.Location = new System.Drawing.Point(204, 102);
            this.numIcecekMiktar.Name = "numIcecekMiktar";
            this.numIcecekMiktar.Size = new System.Drawing.Size(120, 22);
            this.numIcecekMiktar.TabIndex = 3;
            this.numIcecekMiktar.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btnSiparisEkle
            // 
            this.btnSiparisEkle.Location = new System.Drawing.Point(143, 166);
            this.btnSiparisEkle.Name = "btnSiparisEkle";
            this.btnSiparisEkle.Size = new System.Drawing.Size(75, 23);
            this.btnSiparisEkle.TabIndex = 4;
            this.btnSiparisEkle.Text = "Ekle";
            this.btnSiparisEkle.UseVisualStyleBackColor = true;
            this.btnSiparisEkle.Click += new System.EventHandler(this.btnSiparisEkle_Click);
            // 
            // lstSiparis
            // 
            this.lstSiparis.FormattingEnabled = true;
            this.lstSiparis.ItemHeight = 16;
            this.lstSiparis.Location = new System.Drawing.Point(490, 32);
            this.lstSiparis.Name = "lstSiparis";
            this.lstSiparis.Size = new System.Drawing.Size(342, 244);
            this.lstSiparis.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Yiyecek Türü";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "İçecek Türü";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(204, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Adet";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(207, 79);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "Adet";
            // 
            // lblMasaNo
            // 
            this.lblMasaNo.AutoSize = true;
            this.lblMasaNo.Location = new System.Drawing.Point(509, 9);
            this.lblMasaNo.Name = "lblMasaNo";
            this.lblMasaNo.Size = new System.Drawing.Size(68, 17);
            this.lblMasaNo.TabIndex = 8;
            this.lblMasaNo.Text = "Masa No:";
            // 
            // btnOde
            // 
            this.btnOde.Location = new System.Drawing.Point(0, 65);
            this.btnOde.Name = "btnOde";
            this.btnOde.Size = new System.Drawing.Size(342, 23);
            this.btnOde.TabIndex = 12;
            this.btnOde.Text = "Ödeme Yap";
            this.btnOde.UseVisualStyleBackColor = true;
            // 
            // rbtnTl
            // 
            this.rbtnTl.AutoSize = true;
            this.rbtnTl.Location = new System.Drawing.Point(22, 18);
            this.rbtnTl.Name = "rbtnTl";
            this.rbtnTl.Size = new System.Drawing.Size(37, 21);
            this.rbtnTl.TabIndex = 13;
            this.rbtnTl.TabStop = true;
            this.rbtnTl.Text = "₺";
            this.rbtnTl.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(138, 18);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(37, 21);
            this.radioButton2.TabIndex = 14;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "$";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(254, 19);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(37, 21);
            this.radioButton3.TabIndex = 15;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "€";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // txtToplamTutar
            // 
            this.txtToplamTutar.Location = new System.Drawing.Point(242, 42);
            this.txtToplamTutar.Name = "txtToplamTutar";
            this.txtToplamTutar.Size = new System.Drawing.Size(100, 22);
            this.txtToplamTutar.TabIndex = 16;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(135, 45);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 17);
            this.label5.TabIndex = 17;
            this.label5.Text = "Toplam Tutar";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnOde);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.rbtnTl);
            this.groupBox1.Controls.Add(this.txtToplamTutar);
            this.groupBox1.Controls.Add(this.radioButton2);
            this.groupBox1.Controls.Add(this.radioButton3);
            this.groupBox1.Location = new System.Drawing.Point(490, 282);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(370, 114);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(872, 513);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblMasaNo);
            this.Controls.Add(this.lstSiparis);
            this.Controls.Add(this.grpSiparis);
            this.Controls.Add(this.grpMasalar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grpSiparis.ResumeLayout(false);
            this.grpSiparis.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numYemekMiktar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numIcecekMiktar)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpMasalar;
        private System.Windows.Forms.GroupBox grpSiparis;
        private System.Windows.Forms.Button btnSiparisEkle;
        private System.Windows.Forms.NumericUpDown numIcecekMiktar;
        private System.Windows.Forms.NumericUpDown numYemekMiktar;
        private System.Windows.Forms.ComboBox cmBoxIcecek;
        private System.Windows.Forms.ComboBox cmBoxYemek;
        private System.Windows.Forms.ListBox lstSiparis;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblMasaNo;
        private System.Windows.Forms.Button btnOde;
        private System.Windows.Forms.RadioButton rbtnTl;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.TextBox txtToplamTutar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}

