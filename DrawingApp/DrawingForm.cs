using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DrawingApp
{
    public partial class DrawingForm : Form
    {
        private bool bSurekliCizim = false;
        private bool bCiziyor = false;
        private Color renk = Color.Black;
        private Pen kalem;
        private List<Point> noktalar = new List<Point>();
        public DrawingForm()
        {
            InitializeComponent();
        }

        private void CizimPaneli_MouseClick(object sender, MouseEventArgs e)
        {
            if (!bSurekliCizim)
            {
                NoktaEkle(e.Location);
            }
        }

        private void rbKirikCizgi_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void rbSurekliCizgi_CheckedChanged(object sender, EventArgs e)
        {
            bSurekliCizim = rbSurekliCizgi.Checked;
            noktalar.Clear();
            CizimPaneli.Invalidate();
        }

        private void CizimPaneli_MouseDown(object sender, MouseEventArgs e)
        {
            if(bSurekliCizim)
            {
                noktalar.Clear();
                CizimPaneli.Invalidate();
                bCiziyor = true;
            }
        }

        private void CizimPaneli_MouseUp(object sender, MouseEventArgs e)
        {
            if (bSurekliCizim)
            {
                bCiziyor = false;
            }
        }

        private void CizimPaneli_MouseMove(object sender, MouseEventArgs e)
        {
            if(bSurekliCizim && bCiziyor)
            {
                NoktaEkle(e.Location);
            }
        }

        private void DrawingForm_Load(object sender, EventArgs e)
        {
            dlgRenk.ShowDialog();
            renk = dlgRenk.Color;
            cbKalinlik.SelectedIndex = 0;
        }

        private void NoktaEkle(Point nokta)
        {
            noktalar.Add(nokta);
            if (noktalar.Count > 1)
            {
                int son = noktalar.Count - 1,
                    onceki = son - 1;
                CizimPaneli.CreateGraphics().DrawLine(kalem,
                    noktalar[onceki], noktalar[son]);
            }
        }

        private void cbKalinlik_SelectedIndexChanged(object sender, EventArgs e)
        {
            double kalinlik = Convert.ToDouble(cbKalinlik.Text);
            kalem = new Pen(renk, (float)kalinlik);
        }

        private void btnRenk_Click(object sender, EventArgs e)
        {
            dlgRenk.ShowDialog();
            renk = dlgRenk.Color;
            double kalinlik = Convert.ToDouble(cbKalinlik.Text);
            kalem = new Pen(renk, (float)kalinlik);
        }
    }
}
