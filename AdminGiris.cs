using System;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
namespace urunotomasyon
{
    public partial class FrmAdmin : Form
    {
        public FrmAdmin()
        {
            InitializeComponent();
        }
        // SqlConnection baglan = new SqlConnection(@"Data Source = LAPTOP - AGOP8H4K; Initial Catalog = TheFutureOtomasyon; Integrated Security = True");
        SqlConnection baglanti = new SqlConnection("Data Source=LAPTOP-AGOP8H4K;Initial Catalog=TheFutureOtomasyon;Integrated Security=True"); //veritabanına bağlanıyoruz. Server name girildi
        private void verilerigöster()
        {

        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            // verilerigöster();
            Application.Exit();
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void BtnGiris_Click(object sender, EventArgs e)
        {

            // deneme demektir.  Eğer yanlışsa catch butonunda  hata yakalanır.

            baglanti.Open();
            string sql = "select * from AdminGirisi where Kullanıcı=@KullaniciAd AND Sifre=@Sifresi"; // veritabanındaki alan adına @lerle geçici isim oluşturduk.
            SqlParameter prm1 = new SqlParameter("KullaniciAd", txtKadi.Text.Trim());  // yeni obje ile parametre atadık.
            SqlParameter prm2 = new SqlParameter("Sifresi", txtSifre.Text.Trim());
            SqlCommand komut = new SqlCommand(sql, baglanti);

            komut.Parameters.Add(prm1); // parametrelerin içi doldurulur.
            komut.Parameters.Add(prm2);

            DataTable dt = new DataTable(); // sanal tablo oluştururuz.
            SqlDataAdapter da = new SqlDataAdapter(komut);  // sql yani sanal tablonun içini doldurmak için obje oluştururuz.



            da.Fill(dt); //doldurduk.

            if (dt.Rows.Count > 0)
            {
                Adminİslemleri fr = new Adminİslemleri();

                fr.Show();
                this.Hide(); // sekmeyi gizler
            }
            //  baglanti.Close();

            else // yakalama
            {

                MessageBox.Show("Kullanıcı Adı veya Şifre Yanlış");
                baglanti.Close();
            }

            /*if (txtKadi.Text=="admin" && txtSifre.Text=="12345")  // Admin giriş bilgileri
            {
                Adminİslemleri fr = new Adminİslemleri(); // Personel Maaş bölümünü ekranda açar.
                fr.Show(); // Anasayfayı ekrana gösterir.
                this.Hide();  // gizler.
            }
            else // eğer şifre yanlış girilmişse
            {
                MessageBox.Show("Kullanıcı Adı veya Şifre Yanlış");
            }
            */


        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void TxtSifre_TextChanged(object sender, EventArgs e)
        {


        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void bunifuTextBox2_TextChanged(object sender, EventArgs e)
        {
            txtSifre.PasswordChar = '*';
            // txtSifre.MaxLength = 25;
        }

        private void bunifuTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            AnaSayfa fr = new AnaSayfa(); //Anasayfayı ekranda açar.
            fr.Show(); // Anasayfayı ekrana gösterir.
            this.Hide();  // gizler.
        }

        private void bunifuLabel1_Click(object sender, EventArgs e)
        {

        }
    }
}
