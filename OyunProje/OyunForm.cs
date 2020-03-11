using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OyunProje
{
    public partial class OyunForm : Form
    {
        private Random rnd = new Random();
        private Properties.Settings ayarlar = new Properties.Settings();
        private Rectangle[] hedefler;
        private Brush hedefFirca;
        public OyunForm()
        {
            InitializeComponent();
        }

        private void Zamanlayici_Tick(object sender, EventArgs e)
        {
            Graphics gr = OyunPanel.CreateGraphics();
            int x;
            int y;
            for (int i = 0; i < hedefler.Length; i++)
            {
                x = rnd.Next(OyunPanel.Width - ayarlar.HedefBoyutu);
                y = rnd.Next(OyunPanel.Height - ayarlar.HedefBoyutu);
                hedefler[i] = new Rectangle(x, y,
                    ayarlar.HedefBoyutu, ayarlar.HedefBoyutu);
            }
            OyunPanel.Invalidate();
        }

        private void btnBaslat_Click(object sender, EventArgs e)
        {
            Zamanlayici.Start();
        }

        private void btnDur_Click(object sender, EventArgs e)
        {
            Zamanlayici.Stop();
        }

        private void OyunForm_Load(object sender, EventArgs e)
        {
            ayarlar.Reload();
            Zamanlayici.Interval = ayarlar.Sure;
            hedefler = new Rectangle[ayarlar.HedefSayisi];
            hedefFirca = new SolidBrush(ayarlar.HedefRenk);
        }

        private void OyunPanel_Paint(object sender, PaintEventArgs e)
        {
            for (int i = 0; i < hedefler.Length; i++)
            {
                e.Graphics.FillEllipse(hedefFirca, hedefler[i]);
            }
        }

        private void OyunPanel_MouseDown(object sender, MouseEventArgs e)
        {
            Point tiklananNokta = e.Location;
            for (int i = 0; i < hedefler.Length; i++)
            {
                if(hedefler[i].Contains(tiklananNokta))
                {
                    hedefler[i] = Rectangle.Empty;
                    OyunPanel.Invalidate();
                    break;
                }
            }
        }
    }
}
