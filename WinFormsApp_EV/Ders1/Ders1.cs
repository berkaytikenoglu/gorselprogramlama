using GorselProgramlama.Ders1.Models;

namespace WinFormsApp_EV
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
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

        private void btn_kusekle_Click(object sender, EventArgs e)
        {


            if (tbox_kustur.Text == "" || tbox_kusayak.Text == "" || tbox_kusrenk.Text == "" || tbox_kusisim.Text == "")
            {
                MessageBox.Show("Eksik parametreler var!");
                return;
            }


            Kuslar kus = new Kuslar();
            kus.Tur = tbox_kustur.Text;
            kus.Ayak = tbox_kusayak.Text;

            //Papa�an kal�t�m yolu ile ku�lardan t�retildi.
            Papagan papagan  = new Papagan();



            papagan.Renk = tbox_kusrenk.Text;
            papagan.Isim = tbox_kusisim.Text;

            listbox_kuslar.Items.Clear();

            listbox_kuslar.Items.Add("***KU�LAR ***");

            listbox_kuslar.Items.Add("T�r: " + kus.Tur);
            listbox_kuslar.Items.Add("Ses: " + papagan.sescikar());
            listbox_kuslar.Items.Add("Ayak: " + kus.Ayak);
            listbox_kuslar.Items.Add("Renk: " + papagan.Renk);
            listbox_kuslar.Items.Add("�sim: " + papagan.Isim);

        }
    }
}
