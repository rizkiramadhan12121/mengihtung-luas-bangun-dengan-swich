using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Program_Menghitung_Luas_bangun_Dengan_Swich
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int nomorBangun;
            double radius, panjang, tinggi, lebar, luas;
          
            nomorBangun = Int32.Parse(txtSeleksiBangun.Text);

            switch (nomorBangun)
            {
                case 1:
                    txtPanjang.Clear();
                    txtTinggi.Clear();
                    txtLebar.Clear();
                    radius = Double.Parse(txtRadius.Text);
                    luas = 3.141593 * Math.Pow(radius, 2);
                    txtLuasBangun.Text = luas.ToString();
                    break;

                case 2:
                    txtRadius.Clear();
                    txtLebar.Clear();
                    panjang = Double.Parse(txtPanjang.Text);
                    tinggi = Double.Parse(txtTinggi.Text);
                    luas = panjang * tinggi;
                    txtLuasBangun.Text = luas.ToString();
                    break;

                case 3:
                    txtTinggi.Clear();
                    txtRadius.Clear();
                    panjang = Double.Parse(txtPanjang.Text);
                    lebar = Double.Parse(txtLebar.Text);
                    luas = panjang * lebar / 2;
                    txtLuasBangun.Text = luas.ToString();
                    break;
            }
        }
    }
}
