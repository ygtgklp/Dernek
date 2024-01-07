using BusinessLayer.Concrete;
using DataAccessLayer.Concrete;
using Entities.Concrete;
using System.Security.Policy;

namespace PresentationLayer
{
    public partial class UyeListe : Form
    {
        public UyeListe()
        {
            InitializeComponent();

        }



        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string ad = textBox1.Text;
            string soyad = textBox2.Text;
            string tc = textBox3.Text;
            string country = textBox4.Text;
            string blood = textBox5.Text;
            bool active = checkBox1.Checked;

            Entities.Concrete.Uyeler uye = new Entities.Concrete.Uyeler();
            uye.uye_name = ad;
            uye.uye_surname = soyad;
            uye.uye_tc = tc;
            uye.uye_country = country;
            uye.uye_bloodtype = blood;
            uye.uye_active = active;

            UyelerService uyelerservice = new UyelerService(new UyelerDal());
            uyelerservice.Add(uye);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            UyelerService uyelerservice = new UyelerService(new UyelerDal());
            List<Entities.Concrete.Uyeler> uyelistesi = uyelerservice.GetAllUyeler();
            listView1.Items.Clear();
            foreach (Entities.Concrete.Uyeler uye in uyelistesi)
            {
                ListViewItem item = new ListViewItem();
                item.Text = uye.uye_id.ToString();
                item.SubItems.Add(uye.uye_name);
                item.SubItems.Add(uye.uye_surname);
                item.SubItems.Add(uye.uye_tc);
                item.SubItems.Add(uye.uye_country);
                item.SubItems.Add(uye.uye_bloodtype);
                item.SubItems.Add(uye.uye_active.ToString());
                listView1.Items.Add(item);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string arama = textBox6.Text;
            UyelerService uyelerservice = new UyelerService(new UyelerDal());
            List<Entities.Concrete.Uyeler> uyelistesi = uyelerservice.GetAllByCountry(arama);
            listView1.Items.Clear();
            foreach (Entities.Concrete.Uyeler uye in uyelistesi)
            {
                ListViewItem item = new ListViewItem();
                item.Text = uye.uye_id.ToString();
                item.SubItems.Add(uye.uye_name);
                item.SubItems.Add(uye.uye_surname);
                item.SubItems.Add(uye.uye_tc);
                item.SubItems.Add(uye.uye_country);
                item.SubItems.Add(uye.uye_bloodtype);
                item.SubItems.Add(uye.uye_active.ToString());
                listView1.Items.Add(item);
            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            string arama = textBox6.Text;
            UyelerService uyelerservice = new UyelerService(new UyelerDal());
            List<Entities.Concrete.Uyeler> uyelistesi = uyelerservice.GetAllByBlood(arama);
            listView1.Items.Clear();
            foreach (Entities.Concrete.Uyeler uye in uyelistesi)
            {
                ListViewItem item = new ListViewItem();
                item.Text = uye.uye_id.ToString();
                item.SubItems.Add(uye.uye_name);
                item.SubItems.Add(uye.uye_surname);
                item.SubItems.Add(uye.uye_tc);
                item.SubItems.Add(uye.uye_country);
                item.SubItems.Add(uye.uye_bloodtype);
                item.SubItems.Add(uye.uye_active.ToString());
                listView1.Items.Add(item);
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            AidatListe aidat = new AidatListe();
            aidat.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            UyelerService uyelerservice = new UyelerService(new UyelerDal());
            List<Entities.Concrete.Uyeler> uyelistesi = uyelerservice.GetAllByActive(true);
            listView1.Items.Clear();
            foreach (Entities.Concrete.Uyeler uye in uyelistesi)
            {
                ListViewItem item = new ListViewItem();
                item.Text = uye.uye_id.ToString();
                item.SubItems.Add(uye.uye_name);
                item.SubItems.Add(uye.uye_surname);
                item.SubItems.Add(uye.uye_tc);
                item.SubItems.Add(uye.uye_country);
                item.SubItems.Add(uye.uye_bloodtype);
                item.SubItems.Add(uye.uye_active.ToString());
                listView1.Items.Add(item);
            }
        }
    }
}
