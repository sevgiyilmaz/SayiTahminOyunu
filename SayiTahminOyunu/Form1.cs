using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SayiTahminOyunu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int altlimit = 0, ustlimit = 100, tahminsayisi = 0, tahmin = 0;
        private void btnBaslat_Click(object sender, EventArgs e)
        {
            altlimit = 0;
            ustlimit = 100;
            tahmin = 0;
            tahminsayisi = 0;
            tahmin = (altlimit + ustlimit) / 2;
            lblTahminSayisi.Text = (++tahminsayisi).ToString();
            lblTahmin.Text = tahmin.ToString();
        }

        private void btnYukari_Click(object sender, EventArgs e)
        {

            if (tahminsayisi < 7)
            {
                altlimit = tahmin;
                tahmin = (altlimit + ustlimit) / 2;
                lblTahminSayisi.Text = (++tahminsayisi).ToString();
                lblTahmin.Text = tahmin.ToString();
            }
            else
            {
                btnYukari.Enabled = false;
                btnAsagi.Enabled = false;
            }
        }
        private void btnAsagi_Click(object sender, EventArgs e)
        {
            if (tahminsayisi < 7)
            {
                ustlimit = tahmin;
                tahmin = (altlimit + ustlimit) / 2;
                lblTahminSayisi.Text = (++tahminsayisi).ToString();
                lblTahmin.Text = tahmin.ToString();
            }
            else
            {
                btnAsagi.Enabled = false;
                btnYukari.Enabled = false;
            }

        }
    }
}
