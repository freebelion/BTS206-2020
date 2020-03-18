using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SudokuApp
{
    public partial class SudokuForm : Form
    {
        // Bu sabit değer yanyana veya alt alta kaç oyun paneli olacağını belirler.
        const short PANELSAYI = 3;
        // Bu iki boyutlu dizi oyun panelleri matrisini temsil eder.
        SudokuCtrl[,] panelMatris;
        
        /// <summary>
        /// Kurucu fonksiyon form nesnesi oluşturulduğunda
        /// yapılacak ilk işlemleri gerçekleştirir.
        /// </summary>
        public SudokuForm()
        {
            InitializeComponent();
            // Bu form ekrana gelince işleme konacak olan fonksiyonu belirle
            this.Load += SudokuForm_Load;
            // Boyut değişikliği olayını yanıtlayacak fonksiyonu belirle
            this.Resize += SudokuForm_Resize;
        }

        /// <summary>
        /// Bu fonksiyon (ekranı kaplama durumu dahil)
        /// boyut değişikliği durumunda oyun panellerini düzenler.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SudokuForm_Resize(object sender, EventArgs e)
        {
            if (panelMatris != null)
            { PanelMatrisDuzenle(); }
        }

        /// <summary>
        /// Bu olay fonksiyonu form ekrana geldiğinde
        /// yapılacak ilk işlemler içindir.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SudokuForm_Load(object sender, EventArgs e)
        {
            // Form ekrana geldiğinde önce panel matrisi oluşturulacak
            PanelMatrisOlustur();
            PanelMatrisDuzenle();
        }

        /// <summary>
        /// Bu fonksiyon oyun paneli matrisini ve eleman panelleri oluşturur.
        /// Yalnızca bir kez, form ilk kez ekrana geldiğinde çağrılır.
        /// </summary>
        private void PanelMatrisOlustur()
        {
            // bu sayaç kutulara rakam yerleştirmek 
            panelMatris = new SudokuCtrl[PANELSAYI, PANELSAYI];
            // Bu iç içe döngüler matristeki oyun panellerini oluşturur.
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    panelMatris[i, j] = new SudokuCtrl();
                    panelMatris[i, j].BorderStyle = BorderStyle.Fixed3D;
                    // Oluşturulan her panel bu formun bir alt kontrolü olacaktır.
                    this.Controls.Add(panelMatris[i, j]);
                }
            }

            PanelMatrisDuzenle();
        }

        /// <summary>
        /// Bu fonksiyon var olan oyun paneli matrisini düzenlemek içindir.
        /// Matris ilk oluşturuluğunda ve form boyutları değiştiğinde çağrılır.
        /// </summary>
        private void PanelMatrisDuzenle()
        {
            // Öncelikle kare düzen oluşturmak için kenar uzunluğu belirle
            int matrisBoyut = Math.Min(this.ClientRectangle.Width,
                this.ClientRectangle.Height);
            // Matrisi ortalamak için kenar boşluklarını belirle
            int solBosluk = (this.ClientRectangle.Width - matrisBoyut) / 2;
            int ustBosluk = (this.ClientRectangle.Height - matrisBoyut) / 2;

            int panelBoyut = matrisBoyut / PANELSAYI;
            // Matristeki panelleri boyutlandır ve yerleştir:
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    panelMatris[i, j].Location = new Point(
                        solBosluk + i * panelBoyut,
                        ustBosluk + j * panelBoyut);
                    panelMatris[i, j].Size = new Size(panelBoyut, panelBoyut);
                }
            }
        }
    }
}
