namespace WinFormsApp_EV
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label_renk = new Label();
            label_kat = new Label();
            label_fiyat = new Label();
            label_yakit = new Label();
            btn_evolustur = new Button();
            groupb_ogrencibilgileri = new GroupBox();
            label_sinavortalama = new Label();
            tbox_sinav3 = new TextBox();
            tbox_ders = new TextBox();
            tbox_sinav1 = new TextBox();
            tbox_ogrenciadi = new TextBox();
            tbox_sinav2 = new TextBox();
            tbox_ogrencisoyad = new TextBox();
            label_sinav1 = new Label();
            label_sinav2 = new Label();
            label_ogrenciad = new Label();
            label_sinav3 = new Label();
            label_ogrendisoyad = new Label();
            label_ogrenciders = new Label();
            btn_ogrenciolustur = new Button();
            listbox_ogrenci = new ListBox();
            groupb_ogrencibilgileri.SuspendLayout();
            SuspendLayout();
            // 
            // label_renk
            // 
            label_renk.AutoSize = true;
            label_renk.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label_renk.Location = new Point(27, 34);
            label_renk.Name = "label_renk";
            label_renk.Size = new Size(61, 25);
            label_renk.TabIndex = 0;
            label_renk.Text = "RENK";
            // 
            // label_kat
            // 
            label_kat.AutoSize = true;
            label_kat.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label_kat.Location = new Point(27, 74);
            label_kat.Name = "label_kat";
            label_kat.Size = new Size(47, 25);
            label_kat.TabIndex = 0;
            label_kat.Text = "KAT";
            // 
            // label_fiyat
            // 
            label_fiyat.AutoSize = true;
            label_fiyat.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label_fiyat.Location = new Point(27, 116);
            label_fiyat.Name = "label_fiyat";
            label_fiyat.Size = new Size(62, 25);
            label_fiyat.TabIndex = 0;
            label_fiyat.Text = "FİYAT";
            // 
            // label_yakit
            // 
            label_yakit.AutoSize = true;
            label_yakit.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label_yakit.Location = new Point(27, 166);
            label_yakit.Name = "label_yakit";
            label_yakit.Size = new Size(65, 25);
            label_yakit.TabIndex = 0;
            label_yakit.Text = "YAKIT";
            // 
            // btn_evolustur
            // 
            btn_evolustur.Location = new Point(12, 552);
            btn_evolustur.Name = "btn_evolustur";
            btn_evolustur.Size = new Size(250, 50);
            btn_evolustur.TabIndex = 1;
            btn_evolustur.Text = "Ev Oluştur";
            btn_evolustur.UseVisualStyleBackColor = true;
            btn_evolustur.Click += btn_evolustur_Click;
            // 
            // groupb_ogrencibilgileri
            // 
            groupb_ogrencibilgileri.BackColor = SystemColors.ActiveCaption;
            groupb_ogrencibilgileri.Controls.Add(label_sinavortalama);
            groupb_ogrencibilgileri.Controls.Add(tbox_sinav3);
            groupb_ogrencibilgileri.Controls.Add(tbox_ders);
            groupb_ogrencibilgileri.Controls.Add(tbox_sinav1);
            groupb_ogrencibilgileri.Controls.Add(tbox_ogrenciadi);
            groupb_ogrencibilgileri.Controls.Add(tbox_sinav2);
            groupb_ogrencibilgileri.Controls.Add(tbox_ogrencisoyad);
            groupb_ogrencibilgileri.Controls.Add(label_sinav1);
            groupb_ogrencibilgileri.Controls.Add(label_sinav2);
            groupb_ogrencibilgileri.Controls.Add(label_ogrenciad);
            groupb_ogrencibilgileri.Controls.Add(label_sinav3);
            groupb_ogrencibilgileri.Controls.Add(label_ogrendisoyad);
            groupb_ogrencibilgileri.Controls.Add(label_ogrenciders);
            groupb_ogrencibilgileri.Location = new Point(251, 21);
            groupb_ogrencibilgileri.Name = "groupb_ogrencibilgileri";
            groupb_ogrencibilgileri.Size = new Size(605, 202);
            groupb_ogrencibilgileri.TabIndex = 2;
            groupb_ogrencibilgileri.TabStop = false;
            groupb_ogrencibilgileri.Text = "Öğrenci Bilgileri";
            // 
            // label_sinavortalama
            // 
            label_sinavortalama.AutoSize = true;
            label_sinavortalama.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label_sinavortalama.Location = new Point(372, 165);
            label_sinavortalama.Name = "label_sinavortalama";
            label_sinavortalama.Size = new Size(151, 25);
            label_sinavortalama.TabIndex = 2;
            label_sinavortalama.Text = "Not Ortalaması:";
            // 
            // tbox_sinav3
            // 
            tbox_sinav3.Location = new Point(438, 114);
            tbox_sinav3.Name = "tbox_sinav3";
            tbox_sinav3.Size = new Size(130, 23);
            tbox_sinav3.TabIndex = 6;
            tbox_sinav3.KeyPress += tbox_sinav1_KeyPress;
            // 
            // tbox_ders
            // 
            tbox_ders.Location = new Point(154, 114);
            tbox_ders.Name = "tbox_ders";
            tbox_ders.Size = new Size(130, 23);
            tbox_ders.TabIndex = 3;
            // 
            // tbox_sinav1
            // 
            tbox_sinav1.Location = new Point(438, 55);
            tbox_sinav1.Name = "tbox_sinav1";
            tbox_sinav1.Size = new Size(130, 23);
            tbox_sinav1.TabIndex = 4;
            tbox_sinav1.KeyPress += tbox_sinav1_KeyPress;
            // 
            // tbox_ogrenciadi
            // 
            tbox_ogrenciadi.Location = new Point(154, 55);
            tbox_ogrenciadi.Name = "tbox_ogrenciadi";
            tbox_ogrenciadi.Size = new Size(130, 23);
            tbox_ogrenciadi.TabIndex = 1;
            // 
            // tbox_sinav2
            // 
            tbox_sinav2.Location = new Point(438, 85);
            tbox_sinav2.Name = "tbox_sinav2";
            tbox_sinav2.Size = new Size(130, 23);
            tbox_sinav2.TabIndex = 5;
            tbox_sinav2.KeyPress += tbox_sinav1_KeyPress;
            // 
            // tbox_ogrencisoyad
            // 
            tbox_ogrencisoyad.Location = new Point(154, 85);
            tbox_ogrencisoyad.Name = "tbox_ogrencisoyad";
            tbox_ogrencisoyad.Size = new Size(130, 23);
            tbox_ogrencisoyad.TabIndex = 2;
            // 
            // label_sinav1
            // 
            label_sinav1.AutoSize = true;
            label_sinav1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label_sinav1.Location = new Point(372, 55);
            label_sinav1.Name = "label_sinav1";
            label_sinav1.Size = new Size(60, 25);
            label_sinav1.TabIndex = 0;
            label_sinav1.Text = "Sınav";
            // 
            // label_sinav2
            // 
            label_sinav2.AutoSize = true;
            label_sinav2.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label_sinav2.Location = new Point(372, 83);
            label_sinav2.Name = "label_sinav2";
            label_sinav2.Size = new Size(60, 25);
            label_sinav2.TabIndex = 0;
            label_sinav2.Text = "Sınav";
            // 
            // label_ogrenciad
            // 
            label_ogrenciad.AutoSize = true;
            label_ogrenciad.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label_ogrenciad.Location = new Point(6, 55);
            label_ogrenciad.Name = "label_ogrenciad";
            label_ogrenciad.Size = new Size(112, 25);
            label_ogrenciad.TabIndex = 0;
            label_ogrenciad.Text = "Öğrenci Ad";
            // 
            // label_sinav3
            // 
            label_sinav3.AutoSize = true;
            label_sinav3.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label_sinav3.Location = new Point(372, 112);
            label_sinav3.Name = "label_sinav3";
            label_sinav3.Size = new Size(60, 25);
            label_sinav3.TabIndex = 0;
            label_sinav3.Text = "Sınav";
            // 
            // label_ogrendisoyad
            // 
            label_ogrendisoyad.AutoSize = true;
            label_ogrendisoyad.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label_ogrendisoyad.Location = new Point(6, 80);
            label_ogrendisoyad.Name = "label_ogrendisoyad";
            label_ogrendisoyad.Size = new Size(142, 25);
            label_ogrendisoyad.TabIndex = 0;
            label_ogrendisoyad.Text = "Öğrenci Soyad";
            // 
            // label_ogrenciders
            // 
            label_ogrenciders.AutoSize = true;
            label_ogrenciders.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label_ogrenciders.Location = new Point(6, 105);
            label_ogrenciders.Name = "label_ogrenciders";
            label_ogrenciders.Size = new Size(52, 25);
            label_ogrenciders.TabIndex = 0;
            label_ogrenciders.Text = "Ders";
            // 
            // btn_ogrenciolustur
            // 
            btn_ogrenciolustur.Location = new Point(606, 552);
            btn_ogrenciolustur.Name = "btn_ogrenciolustur";
            btn_ogrenciolustur.Size = new Size(250, 50);
            btn_ogrenciolustur.TabIndex = 1;
            btn_ogrenciolustur.Text = "Öğrenci Oluştur";
            btn_ogrenciolustur.UseVisualStyleBackColor = true;
            btn_ogrenciolustur.Click += btn_ogrenciolustur_Click;
            // 
            // listbox_ogrenci
            // 
            listbox_ogrenci.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            listbox_ogrenci.FormattingEnabled = true;
            listbox_ogrenci.ItemHeight = 30;
            listbox_ogrenci.Location = new Point(251, 243);
            listbox_ogrenci.Name = "listbox_ogrenci";
            listbox_ogrenci.Size = new Size(594, 274);
            listbox_ogrenci.TabIndex = 3;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(868, 614);
            Controls.Add(listbox_ogrenci);
            Controls.Add(groupb_ogrencibilgileri);
            Controls.Add(btn_ogrenciolustur);
            Controls.Add(btn_evolustur);
            Controls.Add(label_yakit);
            Controls.Add(label_fiyat);
            Controls.Add(label_kat);
            Controls.Add(label_renk);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Görsel Programlama Ders 1";
            groupb_ogrencibilgileri.ResumeLayout(false);
            groupb_ogrencibilgileri.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label_renk;
        private Label label_kat;
        private Label label_fiyat;
        private Label label_yakit;
        private Button btn_evolustur;
        private GroupBox groupb_ogrencibilgileri;
        private Label label_ogrenciad;
        private Label label_ogrendisoyad;
        private Label label_ogrenciders;
        private TextBox tbox_ders;
        private TextBox tbox_ogrenciadi;
        private TextBox tbox_ogrencisoyad;
        private Button btn_ogrenciolustur;
        private ListBox listbox_ogrenci;
        private TextBox tbox_sinav3;
        private TextBox tbox_sinav1;
        private TextBox tbox_sinav2;
        private Label label_sinav1;
        private Label label_sinav2;
        private Label label_sinav3;
        private Label label_sinavortalama;
    }
}
