using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace urunotomasyon
{
    public partial class Musteriler : Form
    {
        public Musteriler()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=LAPTOP-AGOP8H4K;Initial Catalog=TheFutureOtomasyon;Integrated Security=True"); //veritabanına bağlanıyoruz. Server name girildi

        private void verilerigoster()  // erişim belirleyici
        {
            listView1.Items.Clear();
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select * from YeniMusteriEkle", baglanti);   // YeniMusteriEkle'den seçiyoruz.
            SqlDataReader oku = komut.ExecuteReader();

            while (oku.Read())
            {

                ListViewItem ekle = new ListViewItem(); // nesne oluşturuyoruz.
                ekle.Text = oku["Musteriid"].ToString();
                ekle.SubItems.Add(oku["Ad"].ToString());
                ekle.SubItems.Add(oku["Soyad"].ToString());
                ekle.SubItems.Add(oku["Cinsiyet"].ToString());
                ekle.SubItems.Add(oku["Telefon"].ToString());
                ekle.SubItems.Add(oku["Mail"].ToString());
                ekle.SubItems.Add(oku["TC"].ToString());
                ekle.SubItems.Add(oku["OdaNo"].ToString());
                ekle.SubItems.Add(oku["GirisTarihi"].ToString());
                ekle.SubItems.Add(oku["CikisTarihi"].ToString());
                ekle.SubItems.Add(oku["Ucret"].ToString());


                listView1.Items.Add(ekle);
            }

            baglanti.Close();
        }

        private void Musteriler_Load(object sender, EventArgs e)
        {

        }

        private void Btnİslemler_Click(object sender, EventArgs e)
        {
            verilerigoster();
        }

        private void txtUcret_TextChanged(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        int id = 0;
        private void listView1_DoubleClick(object sender, EventArgs e)
        {
            id = int.Parse(listView1.SelectedItems[0].SubItems[0].Text);  // Müşteri Id
            TxtAd.Text = listView1.SelectedItems[0].SubItems[1].Text;  // Ad
            TxtSoyad.Text = listView1.SelectedItems[0].SubItems[2].Text; // Soyad
            comboBox1.Text = listView1.SelectedItems[0].SubItems[3].Text;
            MskTxtTel.Text = listView1.SelectedItems[0].SubItems[4].Text;
            TxtMail.Text = listView1.SelectedItems[0].SubItems[5].Text;
            TxtTC.Text = listView1.SelectedItems[0].SubItems[6].Text;
            TxtOdaNo.Text = listView1.SelectedItems[0].SubItems[7].Text;
            DtpGiris.Text = listView1.SelectedItems[0].SubItems[8].Text;
            DtpCikis.Text = listView1.SelectedItems[0].SubItems[9].Text;
            txtUcret.Text = listView1.SelectedItems[0].SubItems[10].Text;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            AnaSayfa fr = new AnaSayfa(); // Obje oluştuyoruz. 
            fr.Show(); // Anasayfayı ekrana gösterir.
            this.Hide();  // gizler. Menüler arası geçişte görünmesini istemiyorsak
        }

        private void BtnSil_Click(object sender, EventArgs e)
        {
            if (TxtOdaNo.Text == "1")
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("delete from Oda1  ", baglanti);
                komut.ExecuteNonQuery();

                baglanti.Close();

                verilerigoster();

            }

            if (TxtOdaNo.Text == "2")
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("delete from Oda2  ", baglanti);
                komut.ExecuteNonQuery();

                baglanti.Close();

                verilerigoster();

            }

            if (TxtOdaNo.Text == "3")
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("delete from Oda3  ", baglanti);
                komut.ExecuteNonQuery();

                baglanti.Close();

                verilerigoster();

            }
            if (TxtOdaNo.Text == "4")
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("delete from Oda4  ", baglanti);
                komut.ExecuteNonQuery();

                baglanti.Close();

                verilerigoster();

            }
            if (TxtOdaNo.Text == "5")
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("delete from Oda5  ", baglanti);
                komut.ExecuteNonQuery();

                baglanti.Close();

                verilerigoster();

            }
            if (TxtOdaNo.Text == "6")
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("delete from Oda6  ", baglanti);
                komut.ExecuteNonQuery();

                baglanti.Close();

                verilerigoster();

            }
            if (TxtOdaNo.Text == "7")
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("delete from Oda7  ", baglanti);
                komut.ExecuteNonQuery();

                baglanti.Close();

                verilerigoster();

            }
            if (TxtOdaNo.Text == "8")
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("delete from Oda8  ", baglanti);
                komut.ExecuteNonQuery();

                baglanti.Close();

                verilerigoster();

            }
            if (TxtOdaNo.Text == "9")
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("delete from Oda9  ", baglanti);
                komut.ExecuteNonQuery();

                baglanti.Close();

                verilerigoster();

            }

        }

        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("update YeniMusteriEkle set Ad='" + TxtAd.Text + "',Soyad='" + TxtSoyad.Text + "',Cinsiyet='" + comboBox1.Text + "',Telefon='" + MskTxtTel.Text + "',Mail='" + TxtMail.Text + "',TC='" + TxtTC.Text + "',OdaNo='" + TxtOdaNo.Text + "',GirisTarihi='" + DtpGiris.Value.ToString("yyyy-MM-dd") + "',CikisTarihi='" + DtpCikis.Value.ToString("yyyy-MM-dd") + "',Ucret='" + txtUcret.Text + "' where Musteriid= " + id + "", baglanti);
            komut.ExecuteNonQuery(); // Parametreler üzerinde değişiklik yapıyoruz.
            baglanti.Close();
            verilerigoster();
        }

        private void BtnTemizle_Click(object sender, EventArgs e)
        {
            TxtAd.Clear();  // TextBox temizlenmesi için Clear yapılır.
            TxtSoyad.Clear();
            comboBox1.Text = "";
            MskTxtTel.Clear();
            TxtMail.Clear();
            TxtTC.Clear();
            TxtOdaNo.Clear();
            DtpGiris.Text = "";
            DtpCikis.Text = "";
            txtUcret.Clear();

        }

        private void TxtTC_TextChanged(object sender, EventArgs e)
        {

        }

        private void BtnAra_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select * from YeniMusteriEkle where Ad like '%" + TxtİsimAra.Text + "%'", baglanti);   // YeniMusteriEkle'den seçiyoruz.
            SqlDataReader oku = komut.ExecuteReader();

            while (oku.Read())
            {

                ListViewItem ekle = new ListViewItem(); // nesne oluşturuyoruz.
                ekle.Text = oku["Musteriid"].ToString();
                ekle.SubItems.Add(oku["Ad"].ToString());
                ekle.SubItems.Add(oku["Soyad"].ToString());
                ekle.SubItems.Add(oku["Cinsiyet"].ToString());
                ekle.SubItems.Add(oku["Telefon"].ToString());
                ekle.SubItems.Add(oku["Mail"].ToString());
                ekle.SubItems.Add(oku["TC"].ToString());
                ekle.SubItems.Add(oku["OdaNo"].ToString());
                ekle.SubItems.Add(oku["GirisTarihi"].ToString());
                ekle.SubItems.Add(oku["CikisTarihi"].ToString());
                ekle.SubItems.Add(oku["Ucret"].ToString());


                listView1.Items.Add(ekle);
            }

            baglanti.Close();
        }

        private void bunifuPictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
// Data Source = LAPTOP - AGOP8H4K; Initial Catalog = TheFutureOtomasyon; Integrated Security = True