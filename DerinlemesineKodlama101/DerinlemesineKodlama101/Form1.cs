namespace DerinlemesineKodlama101
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //scope   

            //tekli yorum sat�r�
            /*
            �oklu
            Yorum
            Sat�r�
             */

            //De�i�kenler (Variable)

            //Bilgisayar belle�inde baz� de�erleri tutmaya yarayan yap�lard�r.

            string name = "Ahmet";
            string nameSurname = "Ahmet Aksakal";

            //camelCase,PascalCase, Snake_Case

            int sayi = 456;
            byte deger = 255;

            float ondalikSayi = 2.5f;
            double deger1 = 45.65;
            decimal ondalikSayi2 = 980.54m;

            bool cevap = true;
            bool sonuc = false;

            //txtAdSoyad.Text = "Ahmet Aksakal";

            string adSoyad = txtAdSoyad.Text;

            //T�r D�n���mleri
            //string to byte (int)
            int gelenDeger = Convert.ToInt32(true);
            byte not = Convert.ToByte("45");
            byte dersNotu = Convert.ToByte(txtDersNotu.Text);
            double notHesaplama = dersNotu * 0.40;

            //byte to string
            // MessageBox.Show(notHesaplama.ToString());

            //Ahmet Aksakal adl� ��rencimizin not ortalamas� : 56.5

            string ifade = adSoyad + " " + "adl� ��rencimizin not ortalamas� :" + notHesaplama;
            // MessageBox.Show(ifade);

            string ifade1 = $"{adSoyad} adl� ��rencimizin not ortalamas� : {notHesaplama}";

            MessageBox.Show(ifade1);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string urunAdi = txtProductName.Text;
            double urunFiyati = Convert.ToDouble(txtUnitPrice.Text);

            double kdvliFiyat = urunFiyati * 1.20;

            lblMesaj.Text = $"{urunAdi} isimli �r�n�n %20 kdv dahil fiyat�: {kdvliFiyat}";
        }
    }
}
