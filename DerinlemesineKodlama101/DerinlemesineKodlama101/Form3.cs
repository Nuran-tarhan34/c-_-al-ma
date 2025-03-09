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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            /*
             DİZİLER (Arrays)
            Diziler içerisinde aynı türden birden çok değeri tutabilen indis numaraları ile bu değerlere ulaşabildiğimiz veri yapılarıdır. Dizinin içerisinde bulunan değerlere o dizinin elemanları denir. 

             İndis değerleri 0'dan başlar.
             */

            //string ad1 = "Ahmet";
            //string soyad1 = "Molla";

            //string ad2 = "Caner";
            //string soyad2 = "Veli";

            //string bir dizi oluşturalım:

            string[] ogrenciListesi = new string[3];
            string[] egitimListesi = new string[] { "C# Eğitimi", "Sql Eğitimi", "Java Eğitimi" };

            int[] sayiDizisi = new int[5];

            //diziye değer atama:
            ogrenciListesi[0] = "Caner Mollaoğlu";
            ogrenciListesi[1] = "Ahmet Aksakal";
            ogrenciListesi[2] = "Emir Turkan";

            //System.IndexOutOfRangeException: 'Index was outside the bounds of the array.'
            //ogrenciListesi[3] = "Kuzey Mollaoğlu";

            //diziden değer okuma:
            string ogrenciAdi = ogrenciListesi[2];

        }

        string[] studentList = new string[1];
        int sayac = 0;
        private void btnEkle_Click(object sender, EventArgs e)
        {
            //textbox'a girilen herbir öğrenci adı ve soyadı bilgisi sırası ile diziye eklenecektir.

            string nameSurname = txtOgrenciAdi.Text;

            studentList[sayac] = nameSurname;
            sayac = sayac + 1;

            int elemanSayisi = studentList.Length;

            Array.Resize(ref studentList, elemanSayisi + 1);


        }
    }
}
