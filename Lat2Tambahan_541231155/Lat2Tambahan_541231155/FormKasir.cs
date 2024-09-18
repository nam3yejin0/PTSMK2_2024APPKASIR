using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lat2Tambahan_541231155
{
    public partial class FormKasir : Form
    {
        public FormKasir()
        {
            InitializeComponent();
        }

        private void FormKasir_Load(object sender, EventArgs e)
        {
            cbfud.Items.Add("Nasi Uduk");
            cbfud.Items.Add("Nasi Kucing");
            cbfud.Items.Add("Nasi Lele");
            cbfud.Items.Add("Nasi Ayam");
            cbdrink.Items.Add("Kopi");
            cbdrink.Items.Add("Es Teh");
            cbdrink.Items.Add("Es Jeruk");
            cbdrink.Items.Add("Air Mineral");
        }

        private void cbfud_SelectedIndexChanged(object sender, EventArgs e)
        {
            int pilih;

            pilih = cbfud.SelectedIndex;
            switch (pilih)
            {
                case 0:
                    txtfudp.Text = "15000";
                    Total();
                    break;
                case 1:
                    txtfudp.Text = "16000";
                    Total();
                    break;
                case 2:
                    txtfudp.Text = "20000";
                    Total();
                    break;
                case 3:
                    txtfudp.Text = "18000";
                    Total();
                    break;
                default:
                    txtfudp.Text = "0";
                    break;

            }
        }

        private void cbdrink_SelectedIndexChanged(object sender, EventArgs e)
        {
            int pilih;

            pilih = cbdrink.SelectedIndex;
            switch (pilih)
            {
                case 0:
                    txtdrinkp.Text = "15000";
                    Total();
                    break;
                case 1:
                    txtdrinkp.Text = "5000";
                    Total();
                    break;
                case 2:
                    txtdrinkp.Text = "80000";
                    Total();
                    break;
                case 3:
                    txtdrinkp.Text = "4000";
                    Total();
                    break;
                default:
                    txtdrinkp.Text = "0";
                    break;

            }
        }

        private void txtpay_TextChanged(object sender, EventArgs e)
        {
            if (txtpay.Text == "" || txtpay.Text == " ")
            {
                txtpay.Text = "0";
            }
            else
            {
                int a = Convert.ToInt32(txtpay.Text);
                int b = Convert.ToInt32(txtsum.Text);
                int kembali = 0;
                kembali = a - b;
                txtsisa.Text = Convert.ToString(kembali);
            }
        }

        private void txtsum_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!Char.IsDigit(ch) && ch != 8)
            {
                e.Handled = true;
            }
        }

        private void btnp_Click(object sender, EventArgs e)
        {
            MessageBox.Show("=======================" +
                "\n\tWarung ApaCoba" +
                "\n\tKasir: " + txtkasir.Text +
                "\nPesan: " +
                "\n" + cbfud.Text + "\tRp." + txtfudp.Text +
                "\n" + cbdrink.Text + "\tRp." + txtdrinkp.Text +
                "\n=======================" +
                "\nTotal\t\t: Rp. " + txtsum.Text +
                "\nBayar\t\t: Rp. " + txtpay.Text +
                "\nKembali\t\t: Rp. " + txtsisa.Text);
        }

        private void btncl_Click(object sender, EventArgs e)
        {
            cbfud.Text = "";
            cbdrink.Text = "";
            txtfudp.Text = "0";
            txtdrinkp.Text = "0";
            txtsum.Text = "0";
            txtpay.Text = "0";
            txtsisa.Text = "0";
            txtkasir.Clear();
        }

        public void Total()
        {
            int total, pfud, pdrink = 0;
            pfud = Convert.ToInt32(txtfudp.Text);
            pdrink = Convert.ToInt32(txtdrinkp.Text);
            total = pfud + pdrink;
            txtsum.Text = Convert.ToString(total);
        }

        private void txtfudp_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void txtSatuanMakanan_ValueChanged(object sender, EventArgs e)
        {
            UpdateSubtotalMakanan();
        }


        private void UpdateSubtotalMakanan()
        {
            int hargaMakanan = Convert.ToInt32(txtfudp.Text);
            int jumlahMakanan = (int)txtSatuanMakanan.Value;
            int subtotalMakanan = hargaMakanan * jumlahMakanan;
            txtSubTotalMakanan.Text = subtotalMakanan.ToString();
            CalculateTotal();
        }

        private void UpdateSubtotalMinuman()
        {
            int hargaMinuman = Convert.ToInt32(txtdrinkp.Text);
            int jumlahMinuman = (int)txtSatuanMinuman.Value;
            int subtotalMinuman = hargaMinuman * jumlahMinuman;
            txtSubTotalMinuman.Text = subtotalMinuman.ToString();
            CalculateTotal();
        }

        private void CalculateTotal()
        {
            int subtotalMakanan = Convert.ToInt32(txtSubTotalMakanan.Text);
            int subtotalMinuman = Convert.ToInt32(txtSubTotalMinuman.Text);
            int total = subtotalMakanan + subtotalMinuman;
            txtsum.Text = total.ToString();
        }

        private void txtSubTotalMinuman_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtSatuanMinuman_ValueChanged(object sender, EventArgs e)
        {
            UpdateSubtotalMinuman();
        }
    }
}
