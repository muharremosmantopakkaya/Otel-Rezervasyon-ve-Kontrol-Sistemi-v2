using System;
using System.Data.SqlClient;
using System.Windows.Forms;
namespace urunotomasyon
{
    public partial class GelirGider : Form
    {
        public GelirGider()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=LAPTOP-AGOP8H4K;Initial Catalog=TheFutureOtomasyon;Integrated Security=True"); //veritabanına bağlanıyoruz. Server name girildi

        private void bunifuLabel1_Click(object sender, EventArgs e)
        {

        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            /*baglanti.Open();
            SqlCommand komut = new SqlCommand(" Select sum(Ucret) as toplam from YeniMusteriEkle ", baglanti);  // sum topluyor
            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                LblKasaToplam.Text = oku["toplam"].ToString();


            }*/


            int personel; // değişken atarız.
            personel = Convert.ToInt16(bunifuTextBox1.Text);
            LblMaas.Text = (personel * 3000).ToString(); // değişken ile çarpıp maaşı elde ederiz.
            baglanti.Close();


            int sonuc;
            sonuc = Convert.ToInt32(LblKasaToplam.Text) - ((Convert.ToInt32(LblMaas.Text) + Convert.ToInt32(LblAlınanUrun1.Text) + Convert.ToInt32(LblAlınanUrun2.Text) + Convert.ToInt32(LblAlınanUrun3.Text) + Convert.ToInt32(LblFatura1.Text) + Convert.ToInt32(LblFatura2.Text) + Convert.ToInt32(LblFatura3.Text)));
            LblSonuc.Text = sonuc.ToString();

            //public void GelirGider_Load(object sender, EventArgs e)
            // {   

            //}



        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Adminİslemleri fr = new Adminİslemleri();
            fr.Show();
            this.Hide(); //gizlemek
        }

        private void GelirGider_Load(object sender, EventArgs e)
        {
            //Müsterilerin verdiği tutar kasa tutarı

            baglanti.Open();
            SqlCommand komut = new SqlCommand(" Select sum(Ucret) as toplam from YeniMusteriEkle ", baglanti);  // sum topluyor
            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                LblKasaToplam.Text = oku["toplam"].ToString();


            }
            baglanti.Close();



            // Gıda giderleri
            baglanti.Open();
            SqlCommand komut2 = new SqlCommand(" Select sum(TemelGida) as toplam1 from Stoklar", baglanti);  // sum topluyor
            SqlDataReader oku2 = komut2.ExecuteReader();
            while (oku2.Read())
            {
                LblAlınanUrun1.Text = oku2["toplam1"].ToString();


            }
            baglanti.Close();


            // İcecek giderleri
            baglanti.Open();
            SqlCommand komut3 = new SqlCommand(" Select sum(Icecek) as toplam2 from Stoklar", baglanti);  // sum topluyor
            SqlDataReader oku3 = komut3.ExecuteReader();
            while (oku3.Read())
            {
                LblAlınanUrun2.Text = oku3["toplam2"].ToString();


            }
            baglanti.Close();

            // Atıştırmalık giderleri
            baglanti.Open();
            SqlCommand komut4 = new SqlCommand(" Select sum(Atistirmalik) as toplam3 from Stoklar", baglanti);  // sum topluyor
            SqlDataReader oku4 = komut4.ExecuteReader();
            while (oku4.Read())
            {
                LblAlınanUrun3.Text = oku4["toplam3"].ToString();


            }
            baglanti.Close();
            // Elektrik giderleri
            baglanti.Open();
            SqlCommand komut5 = new SqlCommand(" Select sum(Elektrik) as toplam4 from Faturalar", baglanti);  // sum topluyor
            SqlDataReader oku5 = komut5.ExecuteReader();
            while (oku5.Read())
            {
                LblFatura1.Text = oku5["toplam4"].ToString();


            }
            baglanti.Close();
            // Su giderleri
            baglanti.Open();
            SqlCommand komut6 = new SqlCommand(" Select sum(Su) as toplam5 from Faturalar", baglanti);  // sum topluyor
            SqlDataReader oku6 = komut6.ExecuteReader();
            while (oku6.Read())
            {
                LblFatura2.Text = oku6["toplam5"].ToString();


            }
            baglanti.Close();
            // İnrernet giderleri
            baglanti.Open();
            SqlCommand komut7 = new SqlCommand(" Select sum(Internet) as toplam6 from Faturalar", baglanti);  // sum topluyor
            SqlDataReader oku7 = komut7.ExecuteReader();
            while (oku7.Read())
            {
                LblFatura3.Text = oku7["toplam6"].ToString();


            }
            baglanti.Close();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void LblKasaToplam_Click(object sender, EventArgs e)
        {

        }

        private void LblAlınanUrun1_Click(object sender, EventArgs e)
        {

        }

        private void bunifuTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void LblSonuc_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void LblMaas_Click(object sender, EventArgs e)
        {

        }

        private void LblAlınanUrun2_Click(object sender, EventArgs e)
        {

        }

        private void LblAlınanUrun3_Click(object sender, EventArgs e)
        {

        }

        private void LblFatura1_Click(object sender, EventArgs e)
        {

        }

        private void LblFatura2_Click(object sender, EventArgs e)
        {

        }

        private void LblFatura3_Click(object sender, EventArgs e)
        {

        }
    }
}
