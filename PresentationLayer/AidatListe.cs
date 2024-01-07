using BusinessLayer.Concrete;
using DataAccessLayer.Concrete;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace PresentationLayer
{
    public partial class AidatListe : Form
    {
        public AidatListe()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            UyeListe uyeliste = new UyeListe();

            uyeliste.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AidatService aidatservice = new AidatService(new AidatDal());
            List<Entities.Concrete.Aidat> aidatlistesi = aidatservice.GetAllAidat();
            listView1.Items.Clear();
            foreach (Entities.Concrete.Aidat aidat in aidatlistesi)
            {
                ListViewItem item = new ListViewItem();
                item.Text = aidat.aidat_id.ToString();
                item.SubItems.Add(aidat.aidat_month);
                item.SubItems.Add(aidat.aidat_price);
                listView1.Items.Add(item);
            }
        }
    }
}
