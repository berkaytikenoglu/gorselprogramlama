using GorselProgramlama.Odev1.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GorselProgramlama.Odev1
{
    public partial class Odev1mainForm : Form
    {
        public Odev1mainForm()
        {
            InitializeComponent();
        }

        private void btn_siirekle_Click(object sender, EventArgs e)
        {
            if (tbox_bestelenmetarih.Text == "" || tbox_satirsayisi.Text == "" || tbox_siiradi.Text == "" || tbox_siiribesteleyen.Text == "" || tbox_yazar.Text == "")
            {

                MessageBox.Show("Boşluk Bırakmayınız");
                return;
            }
     
            if(tbox_bestelenmetarih.Text.Length != 4)
            {
                MessageBox.Show("Yılı doğru yazınız (2005) gibi");

                return;
            }
                BestelenenSiirler siir = new BestelenenSiirler();

            siir.yazar = tbox_yazar.Text;
            siir.siirAdi = tbox_siiradi.Text;
            siir.satirSayisi = Int64.Parse(tbox_satirsayisi.Text);
            siir.besteleyenkisi = tbox_siiribesteleyen.Text;
            siir.bestelenmetarih = Int64.Parse(tbox_bestelenmetarih.Text);

            listbox_siirkutu.Items.Clear();

            listbox_siirkutu.Items.Add(siir.yazar);
            listbox_siirkutu.Items.Add(siir.siirAdi);
            listbox_siirkutu.Items.Add(siir.satirSayisi);
            listbox_siirkutu.Items.Add(siir.besteleyenkisi);
            listbox_siirkutu.Items.Add(siir.yazar);
            listbox_siirkutu.Items.Add(siir.Aciklama());

        }

        private void tbox_bestelenmetarih_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Eğer basılan tuş sayı değilse ve backspace tuşu değilse, olayı engelle
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
