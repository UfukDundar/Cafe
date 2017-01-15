using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cafe
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Masalar[] masalar = new Masalar[15];

        private void Form1_Load(object sender, EventArgs e)
        {
            lstSiparis.Items.Add("Ürün Adı \t\t\t Adet \t Fiyat\t");

            int no = 0;
            for (int i = 0; i <= 5; i++)
            {
                for (int j = 0; j <= 3; j++)
                {
                    Button buton = new Button();
                    buton.BackColor = Color.Blue;
                    buton.Width = 40;
                    buton.Height = 40;
                    no++;
                    buton.Text = Convert.ToString(no);
                    buton.Left = 10 + (buton.Width) * (j);
                    buton.Top = 20 + (buton.Height) * (i);
                    buton.Click += buton_click;
                    grpMasalar.Controls.Add(buton);
                }
            }
            grpSiparis.Visible = false;
            lstSiparis.Visible = false;
            groupBox1.Visible = false;
        }
        private void buton_click(object sender, EventArgs e)
        {
            Button secbuton = sender as Button;
            secbuton.BackColor = Color.Red;
            grpSiparis.Enabled = true;
            lblMasaNo.Text = secbuton.Text;
            grpSiparis.Visible = true;

        }

        private void btnSiparisEkle_Click(object sender, EventArgs e)
        {
            Masalar m = new Masalar();
            m.masaNo = int.Parse(lblMasaNo.Text);
            Siparis sp = new Siparis();
            if (cmBoxYemek.SelectedItem != null)
            {
                sp.isim = cmBoxYemek.SelectedItem.ToString();
                sp.adet = Convert.ToInt32(numYemekMiktar.Value);
                m.siparisler.Add(sp);
                txtToplamTutar.Text = sp.tutar.ToString();
            }

            sp = new Siparis();
            if (cmBoxIcecek.SelectedItem != null)
            {
                sp.isim = cmBoxIcecek.SelectedItem.ToString();
                sp.adet = Convert.ToInt32(numIcecekMiktar.Value);
                m.siparisler.Add(sp);
            }

            lstSiparis.Visible = true;
            groupBox1.Visible = true;

        }
    }
}
