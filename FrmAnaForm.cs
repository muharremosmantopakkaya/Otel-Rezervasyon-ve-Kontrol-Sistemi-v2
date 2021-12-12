using System;
using System.Windows.Forms;
namespace urunotomasyon
{
    public partial class AnaSayfa : Form
    {
        public AnaSayfa()
        {
            InitializeComponent();

        }

        private void AnaSayfa_Load(object sender, EventArgs e)
        {


        }

        /*  private void button1_Click(object sender, EventArgs e)
          {

          }

          private void button2_Click(object sender, EventArgs e)
          {

          }

          private void button3_Click(object sender, EventArgs e)
          {

          }

          private void pictureBox1_Click(object sender, EventArgs e)
          {

          }

          private void button4_Click(object sender, EventArgs e)
          {

          } 
        */

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            FrmAdmin fr = new FrmAdmin();
            fr.Show();
            this.Hide(); //gizlemek
        }

        /*    private void button5_Click(object sender, EventArgs e)
            {

            } */

        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {
            FrmAdmin fr = new FrmAdmin(); //Admin ekranı açılır
            fr.Show();
            this.Hide(); //gizlemek arka planda gözükmemesi için gizlenir
        }

        private void bunifuThinButton23_Click(object sender, EventArgs e)
        {
            YeniMusteri fr = new YeniMusteri(); // YeniMüşteri ekranı açılır
            fr.Show();
            this.Hide();
        }

        private void bunifuThinButton24_Click(object sender, EventArgs e)
        {
            Musteriler fr = new Musteriler();
            fr.Show();
            this.Hide();
        }

        private void bunifuThinButton25_Click(object sender, EventArgs e)
        {
            Odalar fr = new Odalar();
            fr.Show();
            this.Hide();
        }

        /*     private void bunifuPictureBox1_Click(object sender, EventArgs e)
             {


                 Application.Exit(); // Çarpı butonu

             }*/

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click_1(object sender, EventArgs e)
        {
            //  Application.Exit(); // Çarpı butonu
        }

        //   private void bunifuPictureBox1_Click_1(object sender, EventArgs e)
        //  {
        //   Application.Exit();
        // }//

        private void pictureBox1_Click_2(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_3(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox2_Click_2(object sender, EventArgs e)
        {

        }
    }
}
