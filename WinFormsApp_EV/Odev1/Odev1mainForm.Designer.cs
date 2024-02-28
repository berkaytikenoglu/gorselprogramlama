namespace GorselProgramlama.Odev1
{
    partial class Odev1mainForm
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
            label_yazar = new Label();
            label_siiradi = new Label();
            label_siirsatirsayisi = new Label();
            label_besteleyen = new Label();
            label_bestenemetarih = new Label();
            tbox_yazar = new TextBox();
            tbox_siiradi = new TextBox();
            tbox_satirsayisi = new TextBox();
            tbox_siiribesteleyen = new TextBox();
            tbox_bestelenmetarih = new TextBox();
            btn_siirekle = new Button();
            listbox_siirkutu = new ListBox();
            SuspendLayout();
            // 
            // label_yazar
            // 
            label_yazar.AutoSize = true;
            label_yazar.Location = new Point(51, 51);
            label_yazar.Name = "label_yazar";
            label_yazar.Size = new Size(53, 15);
            label_yazar.TabIndex = 0;
            label_yazar.Text = "Şiir Yazar";
            // 
            // label_siiradi
            // 
            label_siiradi.AutoSize = true;
            label_siiradi.Location = new Point(51, 86);
            label_siiradi.Name = "label_siiradi";
            label_siiradi.Size = new Size(44, 15);
            label_siiradi.TabIndex = 1;
            label_siiradi.Text = "Şiir Adı";
            // 
            // label_siirsatirsayisi
            // 
            label_siirsatirsayisi.AutoSize = true;
            label_siirsatirsayisi.Location = new Point(51, 115);
            label_siirsatirsayisi.Name = "label_siirsatirsayisi";
            label_siirsatirsayisi.Size = new Size(62, 15);
            label_siirsatirsayisi.TabIndex = 1;
            label_siirsatirsayisi.Text = "Satır Sayısı";
            // 
            // label_besteleyen
            // 
            label_besteleyen.AutoSize = true;
            label_besteleyen.Location = new Point(51, 144);
            label_besteleyen.Name = "label_besteleyen";
            label_besteleyen.Size = new Size(85, 15);
            label_besteleyen.TabIndex = 1;
            label_besteleyen.Text = "Şiiri Besteleyen";
            // 
            // label_bestenemetarih
            // 
            label_bestenemetarih.AutoSize = true;
            label_bestenemetarih.Location = new Point(51, 173);
            label_bestenemetarih.Name = "label_bestenemetarih";
            label_bestenemetarih.Size = new Size(99, 15);
            label_bestenemetarih.TabIndex = 1;
            label_bestenemetarih.Text = "Bestelendiği Tarih";
            // 
            // tbox_yazar
            // 
            tbox_yazar.Location = new Point(198, 48);
            tbox_yazar.Name = "tbox_yazar";
            tbox_yazar.Size = new Size(100, 23);
            tbox_yazar.TabIndex = 1;
            // 
            // tbox_siiradi
            // 
            tbox_siiradi.Location = new Point(198, 83);
            tbox_siiradi.Name = "tbox_siiradi";
            tbox_siiradi.Size = new Size(100, 23);
            tbox_siiradi.TabIndex = 2;
            // 
            // tbox_satirsayisi
            // 
            tbox_satirsayisi.Location = new Point(198, 112);
            tbox_satirsayisi.Name = "tbox_satirsayisi";
            tbox_satirsayisi.Size = new Size(100, 23);
            tbox_satirsayisi.TabIndex = 3;
            tbox_satirsayisi.KeyPress += tbox_bestelenmetarih_KeyPress;
            // 
            // tbox_siiribesteleyen
            // 
            tbox_siiribesteleyen.Location = new Point(198, 141);
            tbox_siiribesteleyen.Name = "tbox_siiribesteleyen";
            tbox_siiribesteleyen.Size = new Size(100, 23);
            tbox_siiribesteleyen.TabIndex = 4;
            // 
            // tbox_bestelenmetarih
            // 
            tbox_bestelenmetarih.Location = new Point(198, 170);
            tbox_bestelenmetarih.Name = "tbox_bestelenmetarih";
            tbox_bestelenmetarih.Size = new Size(100, 23);
            tbox_bestelenmetarih.TabIndex = 5;
            tbox_bestelenmetarih.KeyPress += tbox_bestelenmetarih_KeyPress;
            // 
            // btn_siirekle
            // 
            btn_siirekle.Location = new Point(51, 227);
            btn_siirekle.Name = "btn_siirekle";
            btn_siirekle.Size = new Size(286, 74);
            btn_siirekle.TabIndex = 6;
            btn_siirekle.Text = "Şiiri Ekle";
            btn_siirekle.UseVisualStyleBackColor = true;
            btn_siirekle.Click += btn_siirekle_Click;
            // 
            // listbox_siirkutu
            // 
            listbox_siirkutu.FormattingEnabled = true;
            listbox_siirkutu.ItemHeight = 15;
            listbox_siirkutu.Location = new Point(35, 317);
            listbox_siirkutu.Name = "listbox_siirkutu";
            listbox_siirkutu.Size = new Size(521, 109);
            listbox_siirkutu.TabIndex = 4;
            // 
            // Odev1mainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(800, 450);
            Controls.Add(listbox_siirkutu);
            Controls.Add(btn_siirekle);
            Controls.Add(tbox_bestelenmetarih);
            Controls.Add(tbox_siiribesteleyen);
            Controls.Add(tbox_satirsayisi);
            Controls.Add(tbox_siiradi);
            Controls.Add(tbox_yazar);
            Controls.Add(label_bestenemetarih);
            Controls.Add(label_besteleyen);
            Controls.Add(label_siirsatirsayisi);
            Controls.Add(label_siiradi);
            Controls.Add(label_yazar);
            Name = "Odev1mainForm";
            Text = "mainForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label_yazar;
        private Label label_siiradi;
        private Label label_siirsatirsayisi;
        private Label label_besteleyen;
        private Label label_bestenemetarih;
        private TextBox tbox_yazar;
        private TextBox tbox_siiradi;
        private TextBox tbox_satirsayisi;
        private TextBox tbox_siiribesteleyen;
        private TextBox tbox_bestelenmetarih;
        private Button btn_siirekle;
        private ListBox listbox_siirkutu;
    }
}