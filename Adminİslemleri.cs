using System;
using System.Windows.Forms;

namespace urunotomasyon
{
    public partial class Adminİslemleri : Form
    {
        public Adminİslemleri()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            FrmAdmin fr = new FrmAdmin();
            fr.Show();
            this.Hide(); //gizlemek
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            GelirGider fr = new GelirGider();

            fr.Show();
            this.Hide(); //gizlemek
        }

        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {
            StokFrm fr = new StokFrm();
            fr.Show();
            this.Hide(); //gizlemek
        }

        private void Adminİslemleri_Load(object sender, EventArgs e)
        {

        }

        private void SifreBtn_Click(object sender, EventArgs e)
        {
            SifreGuncellemeIslemleri fr = new SifreGuncellemeIslemleri();
            fr.Show();
            this.Hide();
        }

        private void FeedBackMus_Click(object sender, EventArgs e)
        {
            GeriBildirimMusteri fr = new GeriBildirimMusteri();
            fr.Show();
            this.Hide();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }
    }
}
