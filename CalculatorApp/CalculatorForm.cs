using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculatorApp
{
    public partial class CalculatorForm : Form
    {
        #region Member variables
        const int BOS = 5;
        private TextBox tbEkran;
        private Button[] dugmeler;
        #endregion

        public CalculatorForm()
        {
            InitializeComponent();
            // Formu boyutlandırılabilir bir araç kutusuna dönüştür
            this.FormBorderStyle = FormBorderStyle.SizableToolWindow;
            // Minimum boyut belirle
            this.MinimumSize = new Size(200, 300);
            // Form ekrana geldiğinde devreye girecek fonksiyonu belirle
            this.Load += CalculatorForm_Load;
            // Form boyutları değişince devreye girecek fonksiyonu belirle
            this.Resize += CalculatorForm_Resize;
        }

        private void CalculatorForm_Load(object sender, EventArgs e)
        {
            // Kontrolleri tanımla
            KontrolleriOlustur();
            // Kontrolleri pencere boyutlarına göre yerleştir
            KontrolleriYerlestir();
        }

        private void KontrolleriOlustur()
        {
            tbEkran = new TextBox();
            this.Controls.Add(tbEkran);
            tbEkran.ReadOnly = true;

            dugmeler = new Button[12];

            for (int i = 0; i < 12; i++)
            {
                dugmeler[i] = new Button();
                this.Controls.Add(dugmeler[i]);
                dugmeler[i].Text = (i + 1).ToString();
                /// Tüm düğmeler içn tıklanma olay fonksiyonu bu olacak
                dugmeler[i].Click += Dugme_Click;
            }

            dugmeler[9].Text = "0";
            dugmeler[10].Text = "+";
            dugmeler[11].Text = "=";
            // ama = düğmesi için işlem yapacak ayrı bir olay fonksiyonu olmalıydı
        }

        private void KontrolleriYerlestir()
        {
            int gen = this.ClientRectangle.Width;
            int yuk = this.ClientRectangle.Height;

            tbEkran.Left = BOS;
            tbEkran.Top = BOS;

            tbEkran.Width = gen - 2 * BOS;

            int ust = tbEkran.Bottom + BOS;
            int duggen = (gen - 4 * BOS) / 3;
            int dugyuk = (yuk - ust - 4 * BOS) / 4;

            for (int i = 0, k = 0; i < 4; i++)
            {
                for (int j = 0; j < 3; j++, k++)
                {
                    dugmeler[k].Height = dugyuk;
                    dugmeler[k].Top = ust + i * (dugyuk + BOS);

                    dugmeler[k].Width = duggen;
                    dugmeler[k].Left = BOS + j * (duggen + BOS);
                }
            }
        }

        private void Dugme_Click(object sender, EventArgs e)
        {
            // Rakam düğmelerinden biri tıklandığında ekrana
            // düğme üzerindeki karakteri ekle
            Button dugme = sender as Button;

            if(dugme != null)
            {
                tbEkran.Text += dugme.Text;
            }
        }

        private void CalculatorForm_Resize(object sender, EventArgs e)
        {
            // Form boyutları değiştirildiğinde yerleşimi yeniden düzenle
            KontrolleriYerlestir();
        }
    }
}
