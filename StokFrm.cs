using System;
using System.Data.SqlClient;
using System.Windows.Forms;
namespace urunotomasyon
{
    public partial class StokFrm : Form
    {
        public StokFrm()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=LAPTOP-AGOP8H4K;Initial Catalog=TheFutureOtomasyon;Integrated Security=True"); //veritabanına bağlanıyoruz. Server name girildi

        private void veriler()
        {
            listView1.Items.Clear();
            baglanti.Open();
            SqlCommand komut = new SqlCommand(" select * from Stoklar ", baglanti);
            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                ListViewItem ekle = new ListViewItem(); //ListView adından da anlaşacağı üzere sıralı bir şekilde verileri listeleyerek üzerinde işlemler yapabilmemize imkan sağlayan çok fonksiyonel bir kontroldür. 
                ekle.Text = oku["TemelGida"].ToString();
                ekle.SubItems.Add(oku["Icecek"].ToString());    //Subitem'lar ise sırasıyla sonraki sütunlardaki değerleri ifade eder
                ekle.SubItems.Add(oku["Atistirmalik"].ToString());  //Subitem'lar ise sırasıyla sonraki sütunlardaki değerleri ifade eder
                listView1.Items.Add(ekle);
            }
            baglanti.Close();
        }
        private void veriler2()
        {
            listView3.Items.Clear();
            baglanti.Open();
            SqlCommand komut3 = new SqlCommand(" select * from Faturalar ", baglanti);
            SqlDataReader oku3 = komut3.ExecuteReader(); //ExecuteReader: Birden fazla satır sonucu döndüren sorgular için kullanılmaktadır. Geriye SqlDataReader tipinde veri döndürmektedir.
                                                         //ExecuteReader geriye SqlDataReader tipinde veri döndürmektedir.
            while (oku3.Read())                            //SqlDataReader, sadece okunabilir olarak kullanılmaktadır. Satır satır okuma işlemi yapılmaktadır. SqlDataReader kullanımı boyunca veritabanı bağlantısı açık olacaktır.
            {                                             // Çünkü SqlDataReader veritabanı ile bağlantılı olarak çalışmaktadır. Okuma işlemi sona erdiğinde SqlDataReader bağlantısınında kapatılması gerekmektedir.
                ListViewItem ekle = new ListViewItem(); //ListView adından da anlaşacağı üzere sıralı bir şekilde verileri listeleyerek üzerinde işlemler yapabilmemize imkan sağlayan çok fonksiyonel bir kontroldür.
                ekle.Text = oku3["Elektrik"].ToString();
                ekle.SubItems.Add(oku3["Su"].ToString());
                ekle.SubItems.Add(oku3["Internet"].ToString());
                listView3.Items.Add(ekle);
            }
            baglanti.Close();
        }
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit(); // Çıkma komutu
        }

        private void StokFrm_Load(object sender, EventArgs e)
        {
            veriler();
            veriler2();
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into Stoklar(TemelGida,Icecek,Atistirmalik) values('" + GıdaTxt.Text + "','" + TxtIcecek.Text + "','" + TxtAtistirmalik.Text + "')", baglanti);
            komut.ExecuteNonQuery();  // Girilen parametreler üzerinde değişiklik yapar.
            baglanti.Close();
            veriler();

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Adminİslemleri fr = new Adminİslemleri(); // obje oluşturduk
            fr.Show();
            this.Hide(); //gizlemek
        }



        private void Kaydet3Btn_Click_1(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut3 = new SqlCommand("insert into Faturalar(Elektrik,Su,Internet) values('" + ElektriksTxt.Text + "','" + SusTxt.Text + "','" + InternetsTxt.Text + "')", baglanti);  //SqlCommand, T-Sql sorguları ile veritabanı üzerinde sorgulama, ekleme, güncelleme, silme işlemlerini yapmak için kullanılmaktadır.
            komut3.ExecuteNonQuery();  // Girilen parametreler üzerinde değişiklik yapar.
            baglanti.Close();        //ExecuteNonQuery: Insert, update, delete işlemlerinde kullanılmaktadır. İşlem sonucuna göre geriye int tipinde değer döndürmektedir.
            veriler2();
        }

        private void ElektriksTxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void SusTxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void InternetsTxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {

        }

        private void listView3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void GıdaTxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void SuTxt_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
