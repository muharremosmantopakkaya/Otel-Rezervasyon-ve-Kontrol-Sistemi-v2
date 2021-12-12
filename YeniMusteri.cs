using System;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace urunotomasyon
{
    public partial class YeniMusteri : Form
    {
        public YeniMusteri()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=LAPTOP-AGOP8H4K;Initial Catalog=TheFutureOtomasyon;Integrated Security=True");

        private void YeniMusteri_Load(object sender, EventArgs e)
        {
            //ODA 1 
            baglanti.Open(); // bağlantı açılır
            SqlCommand komut1 = new SqlCommand("select * from Oda1", baglanti); // Oda1 den seçilir.
            SqlDataReader oku1 = komut1.ExecuteReader(); // sql deki veriyi okur (  ExecuteReader= parametreleri okur )

            while (oku1.Read())
            {
                BtOda1.Text = oku1["Ad"].ToString() + " " + oku1["Soyad"].ToString(); // SQL deki Dolu olan odaya ad ve soyad eklenir.
            }
            baglanti.Close(); // bağlantı kapanır.

            if (BtOda1.Text != "1") // Odanın dolu olduğunu göstermek için  !=1 kullanırız odada bir kişinin ismi yazdığı için numara yazmaz.
            {
                BtOda1.BackColor = Color.Red; // Dolu olduğunu göstermek için kırmızı renge boyarız.
                BtOda1.Enabled = false; // Dolu olduğu için erişime kapalı
            }

            //ODA2
            baglanti.Open(); // bağlantı açılır
            SqlCommand komut2 = new SqlCommand("select * from Oda2", baglanti); // Oda1 den seçilir.
            SqlDataReader oku2 = komut2.ExecuteReader(); // sql deki veriyi okur (  ExecuteReader= parametreleri okur )

            while (oku2.Read())
            {
                BtOda2.Text = oku2["Ad"].ToString() + " " + oku2["Soyad"].ToString(); // SQL deki Dolu olan odaya ad ve soyad eklenir.
            }
            baglanti.Close(); // bağlantı kapanır.

            if (BtOda2.Text != "2") // Odanın dolu olduğunu göstermek için  !=1 kullanırız odada bir kişinin ismi yazdığı için numara yazmaz.
            {
                BtOda2.BackColor = Color.Red; // Dolu olduğunu göstermek için kırmızı renge boyarız.
                BtOda2.Enabled = false; // Dolu olduğu için erişime kapalı
            }
            //ODA3
            baglanti.Open(); // bağlantı açılır
            SqlCommand komut3 = new SqlCommand("select * from Oda3", baglanti); // Oda1 den seçilir.
            SqlDataReader oku3 = komut3.ExecuteReader(); // sql deki veriyi okur (  ExecuteReader= parametreleri okur )

            while (oku3.Read())
            {
                BtOda3.Text = oku3["Ad"].ToString() + " " + oku3["Soyad"].ToString(); // SQL deki Dolu olan odaya ad ve soyad eklenir.
            }
            baglanti.Close(); // bağlantı kapanır.

            if (BtOda3.Text != "3") // Odanın dolu olduğunu göstermek için  !=1 kullanırız odada bir kişinin ismi yazdığı için numara yazmaz.
            {
                BtOda3.BackColor = Color.Red; // Dolu olduğunu göstermek için kırmızı renge boyarız.
                BtOda3.Enabled = false; // Dolu olduğu için erişime kapalı
            }
            //ODA4
            baglanti.Open(); // bağlantı açılır
            SqlCommand komut4 = new SqlCommand("select * from Oda4", baglanti); // Oda1 den seçilir.
            SqlDataReader oku4 = komut4.ExecuteReader(); // sql deki veriyi okur (  ExecuteReader= parametreleri okur )

            while (oku4.Read())
            {
                BtOda4.Text = oku4["Ad"].ToString() + " " + oku4["Soyad"].ToString(); // SQL deki Dolu olan odaya ad ve soyad eklenir.
            }
            baglanti.Close(); // bağlantı kapanır.

            if (BtOda4.Text != "4") // Odanın dolu olduğunu göstermek için  !=1 kullanırız odada bir kişinin ismi yazdığı için numara yazmaz.
            {
                BtOda4.BackColor = Color.Red; // Dolu olduğunu göstermek için kırmızı renge boyarız.
                BtOda4.Enabled = false; // Dolu olduğu için erişime kapalı
            }
            //ODA 5
            baglanti.Open(); // bağlantı açılır
            SqlCommand komut5 = new SqlCommand("select * from Oda5", baglanti); // Oda1 den seçilir.
            SqlDataReader oku5 = komut5.ExecuteReader(); // sql deki veriyi okur (  ExecuteReader= parametreleri okur )

            while (oku5.Read())
            {
                BtOda5.Text = oku5["Ad"].ToString() + " " + oku5["Soyad"].ToString(); // SQL deki Dolu olan odaya ad ve soyad eklenir.
            }
            baglanti.Close(); // bağlantı kapanır.

            if (BtOda5.Text != "5") // Odanın dolu olduğunu göstermek için  !=1 kullanırız odada bir kişinin ismi yazdığı için numara yazmaz.
            {
                BtOda5.BackColor = Color.Red; // Dolu olduğunu göstermek için kırmızı renge boyarız.
                BtOda5.Enabled = false; // Dolu olduğu için erişime kapalı
            }
            //ODA 6
            baglanti.Open(); // bağlantı açılır
            SqlCommand komut6 = new SqlCommand("select * from Oda6", baglanti); // Oda1 den seçilir.
            SqlDataReader oku6 = komut6.ExecuteReader(); // sql deki veriyi okur (  ExecuteReader= parametreleri okur )

            while (oku6.Read())
            {
                BtOda6.Text = oku6["Ad"].ToString() + " " + oku6["Soyad"].ToString(); // SQL deki Dolu olan odaya ad ve soyad eklenir.
            }
            baglanti.Close(); // bağlantı kapanır.

            if (BtOda6.Text != "6") // Odanın dolu olduğunu göstermek için  !=1 kullanırız odada bir kişinin ismi yazdığı için numara yazmaz.
            {
                BtOda6.BackColor = Color.Red; // Dolu olduğunu göstermek için kırmızı renge boyarız.
                BtOda6.Enabled = false; // Dolu olduğu için erişime kapalı
            }
            //ODA 7
            baglanti.Open(); // bağlantı açılır
            SqlCommand komut7 = new SqlCommand("select * from Oda7", baglanti); // Oda1 den seçilir.
            SqlDataReader oku7 = komut7.ExecuteReader(); // sql deki veriyi okur (  ExecuteReader= parametreleri okur )

            while (oku7.Read())
            {
                BtOda7.Text = oku7["Ad"].ToString() + " " + oku7["Soyad"].ToString(); // SQL deki Dolu olan odaya ad ve soyad eklenir.
            }
            baglanti.Close(); // bağlantı kapanır.

            if (BtOda7.Text != "7") // Odanın dolu olduğunu göstermek için  !=1 kullanırız odada bir kişinin ismi yazdığı için numara yazmaz.
            {
                BtOda7.BackColor = Color.Red; // Dolu olduğunu göstermek için kırmızı renge boyarız.
                BtOda7.Enabled = false; // Dolu olduğu için erişime kapalı
            }
            //ODA 8
            baglanti.Open(); // bağlantı açılır
            SqlCommand komut8 = new SqlCommand("select * from Oda8", baglanti); // Oda1 den seçilir.
            SqlDataReader oku8 = komut8.ExecuteReader(); // sql deki veriyi okur (  ExecuteReader= parametreleri okur )

            while (oku8.Read())
            {
                BtOda8.Text = oku8["Ad"].ToString() + " " + oku8["Soyad"].ToString(); // SQL deki Dolu olan odaya ad ve soyad eklenir.
            }
            baglanti.Close(); // bağlantı kapanır.

            if (BtOda8.Text != "8") // Odanın dolu olduğunu göstermek için  !=1 kullanırız odada bir kişinin ismi yazdığı için numara yazmaz.
            {
                BtOda8.BackColor = Color.Red; // Dolu olduğunu göstermek için kırmızı renge boyarız.
                BtOda8.Enabled = false; // Dolu olduğu için erişime kapalı
            }
            //ODA 9
            baglanti.Open(); // bağlantı açılır
            SqlCommand komut9 = new SqlCommand("select * from Oda9", baglanti); // Oda1 den seçilir.
            SqlDataReader oku9 = komut9.ExecuteReader(); // sql deki veriyi okur (  ExecuteReader= parametreleri okur )

            while (oku9.Read())
            {
                BtOda9.Text = oku9["Ad"].ToString() + " " + oku9["Soyad"].ToString(); // SQL deki Dolu olan odaya ad ve soyad eklenir.
            }
            baglanti.Close(); // bağlantı kapanır.

            if (BtOda9.Text != "9") // Odanın dolu olduğunu göstermek için  !=1 kullanırız odada bir kişinin ismi yazdığı için numara yazmaz.
            {
                BtOda9.BackColor = Color.Red; // Dolu olduğunu göstermek için kırmızı renge boyarız.
                BtOda9.Enabled = false; // Dolu olduğu için erişime kapalı
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void TxtMail_TextChanged(object sender, EventArgs e)
        {

        }

        private void BtOda1_Click(object sender, EventArgs e)
        {
            TxtOdaNo.Text = "1"; // textboxa 1 değerini atar.

            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into Oda1 (Ad,Soyad) values ('" + TxtAd.Text + "','" + TxtSoyad.Text + "')", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();

        }

        private void BtOda2_Click(object sender, EventArgs e)
        {
            TxtOdaNo.Text = "2";
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into Oda2 (Ad,Soyad) values ('" + TxtAd.Text + "','" + TxtSoyad.Text + "')", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
        }

        private void BtOda3_Click(object sender, EventArgs e)
        {
            TxtOdaNo.Text = "3";

            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into Oda3 (Ad,Soyad) values ('" + TxtAd.Text + "','" + TxtSoyad.Text + "')", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
        }

        private void BtOda4_Click(object sender, EventArgs e)
        {
            TxtOdaNo.Text = "4";

            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into Oda4 (Ad,Soyad) values ('" + TxtAd.Text + "','" + TxtSoyad.Text + "')", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
        }

        private void BtOda5_Click(object sender, EventArgs e)
        {
            TxtOdaNo.Text = "5";

            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into Oda5 (Ad,Soyad) values ('" + TxtAd.Text + "','" + TxtSoyad.Text + "')", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
        }

        private void BtOda6_Click(object sender, EventArgs e)
        {
            TxtOdaNo.Text = "6";

            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into Oda6 (Ad,Soyad) values ('" + TxtAd.Text + "','" + TxtSoyad.Text + "')", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
        }

        private void BtOda7_Click(object sender, EventArgs e)
        {
            TxtOdaNo.Text = "7";

            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into Oda7 (Ad,Soyad) values ('" + TxtAd.Text + "','" + TxtSoyad.Text + "')", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
        }

        private void BtOda8_Click(object sender, EventArgs e)
        {
            TxtOdaNo.Text = "8";

            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into Oda8 (Ad,Soyad) values ('" + TxtAd.Text + "','" + TxtSoyad.Text + "')", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
        }

        private void BtOda9_Click(object sender, EventArgs e)
        {
            TxtOdaNo.Text = "9";

            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into Oda9 (Ad,Soyad) values ('" + TxtAd.Text + "','" + TxtSoyad.Text + "')", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
        }

        private void BtnDolu_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Kırmızı renkli butonlar dolu odaları belirtir.");
        }

        private void BtnBos_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Yeşil renkli butonlar boş odaları belirtir.");
        }

        private void txtKaydet_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into YeniMusteriEkle (Ad,Soyad,Cinsiyet,Telefon,Mail,TC,OdaNo,GirisTarihi,CikisTarihi,Ucret) values('" + TxtAd.Text + "','" + TxtSoyad.Text + "','" + comboBox1.Text + "','" + MskTxtTel.Text + "','" + TxtMail.Text + "','" + TxtTC.Text + "','" + TxtOdaNo.Text + "','" + DtpGiris.Value.ToString("yyyy-MM-dd") + "','" + DtpCikis.Value.ToString("yyyy-MM-dd") + "','" + txtUcret.Text + "')", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Müsteri Kaydı Yapılmıştır.");
        }

        private void DtpCikis_ValueChanged(object sender, EventArgs e)
        {




        }

        private void txtUcret_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void TxtAd_TextChanged(object sender, EventArgs e)
        {

        }

        private void TxtSoyad_TextChanged(object sender, EventArgs e)
        {

        }

        private void TxtTC_TextChanged(object sender, EventArgs e)
        {

        }

        private void TxtTC_TextChanged_1(object sender, EventArgs e)
        {
            TxtTC.MaxLength = 11;
        }

        private void DtpCikis_ValueChanged_1(object sender, EventArgs e)
        {
            int ucret;
            DateTime kucuktarih = Convert.ToDateTime(DtpGiris.Text);  // datetime pickerdaki değerleri alacağız. 
            DateTime buyuktarih = Convert.ToDateTime(DtpCikis.Text);  //datetime pickerdaki değerleri alacağız.

            TimeSpan Sonuc = buyuktarih - kucuktarih;   //TimeSpan aradaki farkı alır. 2 tarih arasındaki farkı alacağız.

            label11.Text = Sonuc.TotalDays.ToString(); // Toplam değeri burada göstereceğiz.
            ucret = Convert.ToInt32(label11.Text) * 270; // int değere çevirdik.

            txtUcret.Text = ucret.ToString();
        }

        private void TxtOdaNo_TextChanged(object sender, EventArgs e)
        {

        }

        private void TxtMail_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void txtUcret_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            AnaSayfa fr = new AnaSayfa(); //Anasayfayı ekranda açar.
            fr.Show(); // Anasayfayı ekrana gösterir.
            this.Hide();  // gizler.
        }

        private void DtpGiris_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
//Data Source=LAPTOP-AGOP8H4K;Initial Catalog=TheFutureOtomasyon;Integrated Security=True