using System;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;


namespace urunotomasyon
{
    public partial class Odalar : Form
    {
        public Odalar()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=LAPTOP-AGOP8H4K;Initial Catalog=TheFutureOtomasyon;Integrated Security=True");
        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {

        }

        private void Odalar_Load(object sender, EventArgs e)
        {

            //ODA 1 
            baglanti.Open(); // bağlantı açılır
            SqlCommand komut1 = new SqlCommand("select * from Oda1", baglanti); // Oda1 den seçilir.
            SqlDataReader oku1 = komut1.ExecuteReader(); // sql deki veriyi okur (  ExecuteReader= parametreleri okur )

            while (oku1.Read())
            {
                Oda1.Text = oku1["Ad"].ToString() + " " + oku1["Soyad"].ToString(); // SQL deki Dolu olan odaya ad ve soyad eklenir.
            }
            baglanti.Close(); // bağlantı kapanır.

            if (Oda1.Text != "1") // Odanın dolu olduğunu göstermek için  !=1 kullanırız odada bir kişinin ismi yazdığı için numara yazmaz.
            {
                Oda1.BackColor = Color.Red; // Dolu olduğunu göstermek için kırmızı renge boyarız.
                Oda1.Enabled = false;
            }
            //ODA2
            baglanti.Open(); // bağlantı açılır
            SqlCommand komut2 = new SqlCommand("select * from Oda2", baglanti); // Oda1 den seçilir.
            SqlDataReader oku2 = komut2.ExecuteReader(); // sql deki veriyi okur (  ExecuteReader= parametreleri okur )

            while (oku2.Read())
            {
                Oda2.Text = oku2["Ad"].ToString() + " " + oku2["Soyad"].ToString(); // SQL deki Dolu olan odaya ad ve soyad eklenir.
            }
            baglanti.Close(); // bağlantı kapanır.

            if (Oda2.Text != "2") // Odanın dolu olduğunu göstermek için  !=1 kullanırız odada bir kişinin ismi yazdığı için numara yazmaz.
            {
                Oda2.BackColor = Color.Red; // Dolu olduğunu göstermek için kırmızı renge boyarız.
                Oda2.Enabled = false; // Dolu olduğu için erişime kapalı
            }
            //ODA3
            baglanti.Open(); // bağlantı açılır
            SqlCommand komut3 = new SqlCommand("select * from Oda3", baglanti); // Oda1 den seçilir.
            SqlDataReader oku3 = komut3.ExecuteReader(); // sql deki veriyi okur (  ExecuteReader= parametreleri okur )

            while (oku3.Read())
            {
                Oda3.Text = oku3["Ad"].ToString() + " " + oku3["Soyad"].ToString(); // SQL deki Dolu olan odaya ad ve soyad eklenir.
            }
            baglanti.Close(); // bağlantı kapanır.

            if (Oda3.Text != "3") // Odanın dolu olduğunu göstermek için  !=1 kullanırız odada bir kişinin ismi yazdığı için numara yazmaz.
            {
                Oda3.BackColor = Color.Red; // Dolu olduğunu göstermek için kırmızı renge boyarız.
                Oda3.Enabled = false; // Dolu olduğu için erişime kapalı
            }
            //ODA4
            baglanti.Open(); // bağlantı açılır
            SqlCommand komut4 = new SqlCommand("select * from Oda4", baglanti); // Oda1 den seçilir.
            SqlDataReader oku4 = komut4.ExecuteReader(); // sql deki veriyi okur (  ExecuteReader= parametreleri okur )

            while (oku4.Read())
            {
                Oda4.Text = oku4["Ad"].ToString() + " " + oku4["Soyad"].ToString(); // SQL deki Dolu olan odaya ad ve soyad eklenir.
            }
            baglanti.Close(); // bağlantı kapanır.

            if (Oda4.Text != "4") // Odanın dolu olduğunu göstermek için  !=1 kullanırız odada bir kişinin ismi yazdığı için numara yazmaz.
            {
                Oda4.BackColor = Color.Red; // Dolu olduğunu göstermek için kırmızı renge boyarız.
                Oda4.Enabled = false; // Dolu olduğu için erişime kapalı
            }
            //ODA 5
            baglanti.Open(); // bağlantı açılır
            SqlCommand komut5 = new SqlCommand("select * from Oda5", baglanti); // Oda1 den seçilir.
            SqlDataReader oku5 = komut5.ExecuteReader(); // sql deki veriyi okur (  ExecuteReader= parametreleri okur )

            while (oku5.Read())
            {
                Oda5.Text = oku5["Ad"].ToString() + " " + oku5["Soyad"].ToString(); // SQL deki Dolu olan odaya ad ve soyad eklenir.
            }
            baglanti.Close(); // bağlantı kapanır.

            if (Oda5.Text != "5") // Odanın dolu olduğunu göstermek için  !=1 kullanırız odada bir kişinin ismi yazdığı için numara yazmaz.
            {
                Oda5.BackColor = Color.Red; // Dolu olduğunu göstermek için kırmızı renge boyarız.
                Oda5.Enabled = false; // Dolu olduğu için erişime kapalı
            }
            //ODA 6
            baglanti.Open(); // bağlantı açılır
            SqlCommand komut6 = new SqlCommand("select * from Oda6", baglanti); // Oda1 den seçilir.
            SqlDataReader oku6 = komut6.ExecuteReader(); // sql deki veriyi okur (  ExecuteReader= parametreleri okur )

            while (oku6.Read())
            {
                Oda6.Text = oku6["Ad"].ToString() + " " + oku6["Soyad"].ToString(); // SQL deki Dolu olan odaya ad ve soyad eklenir.
            }
            baglanti.Close(); // bağlantı kapanır.

            if (Oda6.Text != "6") // Odanın dolu olduğunu göstermek için  !=1 kullanırız odada bir kişinin ismi yazdığı için numara yazmaz.
            {
                Oda6.BackColor = Color.Red; // Dolu olduğunu göstermek için kırmızı renge boyarız.
                Oda6.Enabled = false;
            }
            //ODA 7
            baglanti.Open(); // bağlantı açılır
            SqlCommand komut7 = new SqlCommand("select * from Oda7", baglanti); // Oda1 den seçilir.
            SqlDataReader oku7 = komut7.ExecuteReader(); // sql deki veriyi okur (  ExecuteReader= parametreleri okur )

            while (oku7.Read())
            {
                Oda7.Text = oku7["Ad"].ToString() + " " + oku7["Soyad"].ToString(); // SQL deki Dolu olan odaya ad ve soyad eklenir.
            }
            baglanti.Close(); // bağlantı kapanır.

            if (Oda7.Text != "7") // Odanın dolu olduğunu göstermek için  !=1 kullanırız odada bir kişinin ismi yazdığı için numara yazmaz.
            {
                Oda7.BackColor = Color.Red; // Dolu olduğunu göstermek için kırmızı renge boyarız.
                Oda7.Enabled = false; // Dolu olduğu için erişime kapalı
            }
            //ODA 8
            baglanti.Open(); // bağlantı açılır
            SqlCommand komut8 = new SqlCommand("select * from Oda8", baglanti); // Oda1 den seçilir.
            SqlDataReader oku8 = komut8.ExecuteReader(); // sql deki veriyi okur (  ExecuteReader= parametreleri okur )

            while (oku8.Read())
            {
                Oda8.Text = oku8["Ad"].ToString() + " " + oku8["Soyad"].ToString(); // SQL deki Dolu olan odaya ad ve soyad eklenir.
            }
            baglanti.Close(); // bağlantı kapanır.

            if (Oda8.Text != "8") // Odanın dolu olduğunu göstermek için  !=1 kullanırız odada bir kişinin ismi yazdığı için numara yazmaz.
            {
                Oda8.BackColor = Color.Red; // Dolu olduğunu göstermek için kırmızı renge boyarız.
                Oda8.Enabled = false; // Dolu olduğu için erişime kapalı
            }
            //ODA 9
            baglanti.Open(); // bağlantı açılır
            SqlCommand komut9 = new SqlCommand("select * from Oda9", baglanti); // Oda1 den seçilir.
            SqlDataReader oku9 = komut9.ExecuteReader(); // sql deki veriyi okur (  ExecuteReader= parametreleri okur )

            while (oku9.Read())
            {
                Oda9.Text = oku9["Ad"].ToString() + " " + oku9["Soyad"].ToString(); // SQL deki Dolu olan odaya ad ve soyad eklenir.
            }
            baglanti.Close(); // bağlantı kapanır.

            if (Oda9.Text != "9") // Odanın dolu olduğunu göstermek için  !=1 kullanırız odada bir kişinin ismi yazdığı için numara yazmaz.
            {
                Oda9.BackColor = Color.Red; // Dolu olduğunu göstermek için kırmızı renge boyarız.
                Oda9.Enabled = false; // Dolu olduğu için erişime kapalı
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
            // Application.Exit();

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            AnaSayfa fr = new AnaSayfa(); //Anasayfayı ekranda açar.
            fr.Show(); // Anasayfayı ekrana gösterir.
            this.Hide();  // gizler.


        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void Oda2_Click(object sender, EventArgs e)
        {

        }

        private void Oda3_Click(object sender, EventArgs e)
        {

        }

        private void Oda4_Click(object sender, EventArgs e)
        {

        }

        private void Oda5_Click(object sender, EventArgs e)
        {

        }

        private void Oda6_Click(object sender, EventArgs e)
        {

        }

        private void Oda7_Click(object sender, EventArgs e)
        {

        }

        private void Oda9_Click(object sender, EventArgs e)
        {

        }
    }
}
