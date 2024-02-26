using WinFormsApp_EV.Models;

namespace WinFormsApp_EV
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            //tbox_sinav1.KeyPress += tbox_sinav1;
        }

        private void btn_evolustur_Click(object sender, EventArgs e)
        {
            Ev ev = new Ev("KIRMIZI", "5", 1000000, "K�m�r");

            label_fiyat.Text = "F�YAT : " + ev.FIYAT.ToString();
            label_kat.Text = "KAT : " + ev.KAT.ToString();
            label_renk.Text = "RENK : " + ev.RENK.ToString();
            label_yakit.Text = "YAKIT : " + ev.YAKIT.ToString();

        }

        private void btn_ogrenciolustur_Click(object sender, EventArgs e)
        {

            if (
                tbox_ogrenciadi.Text == ""
                || tbox_ogrencisoyad.Text == ""
                || tbox_ders.Text == ""
                || tbox_sinav1.Text == ""
                || tbox_sinav2.Text == ""
                || tbox_sinav3.Text == ""
                )
            {
                MessageBox.Show("Eksik parametreler var!");
                return;
            }

            Ogrenci ogrenci = new Ogrenci(tbox_ogrenciadi.Text, tbox_ogrencisoyad.Text, tbox_ders.Text);

            double sinav1 = Convert.ToDouble(tbox_sinav1.Text);
            double sinav2 = Convert.ToDouble(tbox_sinav2.Text);
            double sinav3 = Convert.ToDouble(tbox_sinav3.Text);


            Notlar not = new Notlar(sinav1, sinav2, sinav3);

            label_sinavortalama.Text = "NOT ORTALAMASI: " + not.ortalama.ToString();

            listbox_ogrenci.Items.Clear();

            listbox_ogrenci.Items.Add("***��RENC� B�LG�LER�");

            listbox_ogrenci.Items.Add("Ad�: " + ogrenci.Ad);
            listbox_ogrenci.Items.Add("Soyad: " + ogrenci.Soyad);
            listbox_ogrenci.Items.Add("Ders: " + ogrenci.Ders);

            listbox_ogrenci.Items.Add("***NOT B�LG�LER�");
            listbox_ogrenci.Items.Add("1.SINAV: " + not.Sinav1 + " 2.SINAV: " + not.Sinav2 + " 3.SINAV: " + not.Sinav3 + " ORTALAMA:" + not.ortalama);

        }

        private void tbox_sinav1_KeyPress(object sender, KeyPressEventArgs e)
        {
            // E�er bas�lan tu� say� de�ilse ve backspace tu�u de�ilse, olay� engelle
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
