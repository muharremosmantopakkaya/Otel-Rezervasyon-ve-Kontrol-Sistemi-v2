using System;
using System.Data.SqlClient;
using System.Windows.Forms;


namespace urunotomasyon
{
    public partial class GeriBildirimMusteri : Form
    {
        public GeriBildirimMusteri()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=LAPTOP-AGOP8H4K;Initial Catalog=TheFutureOtomasyon;Integrated Security=True"); //veritabanına bağlanıyoruz. Server name girildi

        private void verilerigoster()  // erişim belirleyici
        {
            listView1.Items.Clear();
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select * from Mesajlar", baglanti);   // YeniMusteriEkle'den seçiyoruz.
            SqlDataReader oku = komut.ExecuteReader();

            while (oku.Read())
            {

                ListViewItem ekle = new ListViewItem(); // nesne oluşturuyoruz.
                ekle.Text = oku["Mesajid"].ToString();
                ekle.SubItems.Add(oku["AdSoyad"].ToString());
                ekle.SubItems.Add(oku["Mesaj"].ToString());



                listView1.Items.Add(ekle);
            }

            baglanti.Close();
        }
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Adminİslemleri fr = new Adminİslemleri();
            fr.Show();
            this.Hide(); //gizlemek
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void GeriBildirimMusteri_Load(object sender, EventArgs e)
        {
            verilerigoster();
        }

        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into Mesajlar(AdSoyad,Mesaj) values('" + TxtAdSoyadG.Text + "','" + MesajTxt.Text + "')", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
            verilerigoster();
        }

        private void bunifuLabel1_Click(object sender, EventArgs e)
        {

        }

        int id = 0;
        private void listView1_DoubleClick(object sender, EventArgs e)
        {
            id = int.Parse(listView1.SelectedItems[0].SubItems[0].Text);
            TxtAdSoyadG.Text = listView1.SelectedItems[0].SubItems[1].Text; // listviewdeki yazıyı ad soyad ve mesajlar paneline yazıyoruz.
            MesajTxt.Text = listView1.SelectedItems[0].SubItems[2].Text;
        }

        private void TxtAdSoyadG_TextChanged(object sender, EventArgs e)
        {

        }

        private void MesajTxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void bunifuPictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
