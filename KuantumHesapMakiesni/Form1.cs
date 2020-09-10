using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KuantumHesapMakiesni
{
    public partial class Form1 : Form
    {
        //Özel değişkenler
        double deger;
        string islem;
        bool islem_b = false;
        //Özel değişkenler
        public Form1()
        {
            InitializeComponent();
        }


        private void yaz(object sender, EventArgs e)
        {
            if ((cıktı.Text == "0")||(islem_b))
            {
                cıktı.Text = "";
                islem_b = false;
            }
            Button b = (Button)sender;
            cıktı.Text = cıktı.Text + b.Text;

        }

        private void girdiyi_sil(object sender, EventArgs e)
        {
            cıktı.Text = "0";
        }

        private void hepsini_sil(object sender, EventArgs e)
        {
            cıktı.Text = "0";
            deger = 0;
            denklem.Text = "";
        }

        private void islem_basla(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            deger = Double.Parse(cıktı.Text);
            islem = b.Text;
            islem_b = true;
            if (denklem.Text == "0")
            {
                denklem.Text = "";
            }
            denklem.Text = deger + " " + b.Text;

        }

        private void islem_tamamla(object sender, EventArgs e)
        {
            switch (islem)
            {
                case "+":
                    cıktı.Text = (deger + Double.Parse(cıktı.Text)).ToString();
                    denklem.Text = "";
                    break;
                case "-":
                    cıktı.Text = (deger - Double.Parse(cıktı.Text)).ToString();
                    denklem.Text = "";
                    break;
                case "*":
                    cıktı.Text = (deger * Double.Parse(cıktı.Text)).ToString();
                    denklem.Text = "";
                    break;
                case "/":
                    cıktı.Text = (deger / Double.Parse(cıktı.Text)).ToString();
                    denklem.Text = "";
                    break;
            }
        }
    }
}
