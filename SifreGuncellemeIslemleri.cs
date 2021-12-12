using System;
using System.Data.SqlClient;
using System.Windows.Forms;


namespace urunotomasyon
{
    public partial class SifreGuncellemeIslemleri : Form
    {
        public SifreGuncellemeIslemleri()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=LAPTOP-AGOP8H4K;Initial Catalog=TheFutureOtomasyon;Integrated Security=True"); //veritabanına bağlanıyoruz. Server name girildi
        private void BtnGiris_Click(object sender, EventArgs e)
        {

            baglanti.Open();
            SqlCommand komut = new SqlCommand("update AdminGirisi set Kullanıcı='" + txtKadi.Text + "',Sifre='" + txtSifre.Text + "' ", baglanti);
            komut.ExecuteNonQuery(); // Parametreler üzerinde değişiklik yapıyoruz.
            baglanti.Close();
            MessageBox.Show("Şifre Başarıyla Güncellendi");
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

        private void txtSifre_TextChanged(object sender, EventArgs e)
        {

        }

        private void SifreGuncellemeIslemleri_Load(object sender, EventArgs e)
        {

        }

        private void txtKadi_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
