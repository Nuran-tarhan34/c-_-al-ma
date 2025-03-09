using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DerinlemesineKodlama101
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            /*
             IF KARAR YAPILARI

            OPERATÖRLER

            Karşılaştırma Operatörleri
            <,>,<=,>=,==,!=

            Mantıksal Operatörler
            &, && (ve) - |,|| (veya)

            Aktarma Operatörleri
            +=, -=, *=, /=

            Aritmetik Operatörler
            +, -, *, /, %
             */

            byte notOrtalamasi = 30;

            if (notOrtalamasi >= 45)
            {
                MessageBox.Show("Sınıfını Geçti.");
            }
            else
            {
                MessageBox.Show("Kaldınız.");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Ahmet'in sınıfını geçebilmesi için devamsızlık sayısının 10 günün altında olması aynı zamanda not ortalamasının 70'e eşit ya da üzerinde olması gerekmektedir.


            byte devamsizlikSayisi = 5;
            byte notOrtalamasi = 90;

            //sınıfını gecebilmesi için 2 kosulda aynı anda gercekleşmeli mi?
            //Yoksa sadece bir koşulun gercekleşmesi yeterli mi?

            if (devamsizlikSayisi < 10 && notOrtalamasi >= 70)
            {
                //Ahmet sınıfını geçmiştir.
            }
            else
            {
                //Ahmet sınıfıta kalmıştır.
            }

            /*
             && operatörü

            true , true >> true
            true , false >> false
            false, true >> false
            false, false >> false
             */
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Ahmet'in sınıfını geçebilmesi için proje notu ortalamasının 65'in üzerinde ya da genel not ortalamasının 90'e eşit ya da üzerinde olması gerekmektedir.

            byte pNOrt = 66;
            byte gNOrt = 75;

            if (pNOrt > 65 || gNOrt >= 90)
            {
                //sınıfını geçmiştir.
            }
            else
            {
                //kalmıştır.
            }

            /*
             || veya operatörü:
            true, false >> true
            false, true >> true
            true, true >> true
            false, false >> false
             */
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            /*
             500 ile 1000 tl arasında alışveris yapan müşterilere %20,
             1000 ile 2500 tl arasında alışveris yapan müşterilere %25,
             2500 ile 5000 tl arasında alışveris yapan müşterilere %35,
             5000 tl den fazla alışveris yapan müşterilere %45,
             */

            bool indirimVarmi = true;
            double musteriSatisTutari = Convert.ToDouble(txtMusteriTutari.Text);

            if (musteriSatisTutari >= 500 && musteriSatisTutari <= 1000)
            {
                //%20
                //double yeniTutar = musteriSatisTutari - (musteriSatisTutari * 0.20);
                //musteriSatisTutari = musteriSatisTutari - (musteriSatisTutari * 0.20);
                musteriSatisTutari -= musteriSatisTutari * 0.20;
            }
            else if (musteriSatisTutari > 1000 && musteriSatisTutari <= 2500)
            {
                //%25
                musteriSatisTutari -= musteriSatisTutari * 0.25;

            }
            else if (musteriSatisTutari > 2500 && musteriSatisTutari <= 5000)
            {
                //%35
                musteriSatisTutari -= musteriSatisTutari * 0.35;
            }
            else if (musteriSatisTutari > 5000)
            {
                //%45
                musteriSatisTutari -= musteriSatisTutari * 0.45;
            }
            else {
                //500 TL den faz alışveriş yapıldığı zaman
                //indirim yok
                indirimVarmi = false;   
            }

            //indirimVarmi==true  >> indirimVarmi
            //indirimVarmi==false >>!indirimVarmi
            if (indirimVarmi)
            {
                lblSonDurum.Text = $"İndirimli satış tutarı: {musteriSatisTutari}";
            }
            else
            {
                lblSonDurum.Text = "İndirim hakkınız bulunmamaktadır.";
            }

            //22:00 de devam ediyoruz.
        }
    }
}
