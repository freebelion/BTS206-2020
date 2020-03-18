using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SudokuApp
{
    public partial class SudokuCtrl : UserControl
    {
        // Bu iki boyutlu dizi oyun panelini oluşturan
        // rakam panelleri matrisini temsil edecek.
        PictureBox[,] rakamKutulari;
        // Bu da tüm oyun panellerinin ortak kullanacağı
        // rakam resimelri listesidir.
        private static ImageList rakamResimleri;
        
        /// <summary>
        /// Bu ortak kurucu fonksiyon her nesne için ayrı ayrı değil,
        /// kod çalışmaya başladığında bir kez çağrılacak
        /// ve ortak kullanılacak rakam resimleri listesini oluşturacaktır.
        /// </summary>
        static SudokuCtrl()
        {
            rakamResimleri = new ImageList();
            rakamResimleri.ImageSize = new Size(256, 256);
            // Rakam resimlerini isterseniz dosyalardan yükletin,
            // isterseniz resimleri kodlarla oluşturun.
            RakamResimleriOlustur();
        }

        /// <summary>
        /// Ortak kullanılacak bu fonksiyon rakam resimlerini
        /// kodlarla oluşturur.
        /// </summary>
        private static void RakamResimleriOlustur()
        {
            // Kodla oluşturulacak resmin referans değişkeni
            Bitmap bmpRakam;
            // Kodla oluşturulan resim üzerinde şekil oluşturacak grafik referansı
            Graphics imgr;
            // Rakam yazı tipi
            Font fntRakam = new Font("Arial Black", 140F);
            // Rakam konumu
            Point rakamKonum = new Point(20, 0);
            
            for (int rakam = 1; rakam < 10; rakam++)
            {// her bir rakam resmini adı döngüde oluşturulan dosyadan yüklet
                bmpRakam = new Bitmap(256, 256);
                imgr = Graphics.FromImage(bmpRakam);
                imgr.DrawString(rakam.ToString(), fntRakam, Brushes.Black, rakamKonum);
                rakamResimleri.Images.Add(bmpRakam);
            }
        }

        /// <summary>
        /// Ortak kullanılacak bu fonksiyon var olan
        /// rakam resimlerini var olan dosyalardan yükler.
        /// </summary>
        private static void RakamResimleriYukle()
        {
            Image rakamResim;
            for (int rakam = 1; rakam < 10; rakam++)
            {// her bir rakam resmini adı döngüde oluşturulan dosyadan yüklet
                rakamResim = Image.FromFile("rakam" + rakam.ToString() + ".png");
                rakamResimleri.Images.Add(rakamResim);
            }
        }

        /// <summary>
        /// Normal kurucu fonksiyon her nesnenin kendisine ait
        /// ön işlemleri yapmak içindir.
        /// </summary>
        public SudokuCtrl()
        {
            InitializeComponent();
            // Bu kontrol ekrana geldiğinde işleme konacak fonksiyonu belirle.
            this.Load += SudokuCtrl_Load;
            this.Resize += SudokuCtrl_Resize;
        }

        /// <summary>
        /// Bu fonksiyon kontrolün yeniden boyutlandırılması
        /// durumunda gerekli düzenlemeleri yaptırır.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SudokuCtrl_Resize(object sender, EventArgs e)
        {
            if (rakamKutulari != null)
            { RakamKutulariDuzenle(); }
        }

        /// <summary>
        /// Bu fonksiyon kontrol ilk ekrana geldiğinde,
        /// yapılacak işlemler içindir.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SudokuCtrl_Load(object sender, EventArgs e)
        {
            RakamKutulariOlustur();
            RakamKutulariDuzenle();
        }

        /// <summary>
        /// Bu fonksiyon oyun panelini oluşturan rakam kutularını oluşturur.
        /// Yalnızca bir kez, panel kontrolü ekrana geldiğinde çağrılır.
        /// </summary>
        private void RakamKutulariOlustur()
        {
            rakamKutulari = new PictureBox[3, 3];
            // Bu döngüler de matristeki rakam kutularını oluşturmak içindir.
            for(int j=0, k=0; j<3; j++)
            {
                for(int i=0; i<3; i++, k++)
                {
                    rakamKutulari[i, j] = new PictureBox();
                    rakamKutulari[i, j].BorderStyle = BorderStyle.FixedSingle;
                    rakamKutulari[i, j].SizeMode = PictureBoxSizeMode.StretchImage;
                    rakamKutulari[i, j].Image = rakamResimleri.Images[k];
                    // Hangi kutuda hangi rakam olduğunu sayısal bilgi olarak da kaydet
                    rakamKutulari[i, j].Tag = k + 1;
                    // Aşağıdaki özellik ataması sürükleme-bırakma işlemlerine izin verir.
                    rakamKutulari[i, j].AllowDrop = true;
                    // Bu olay fonksiyonu ataması da sürükleme-bırakma işlemini başlatmak için
                    rakamKutulari[i, j].MouseDown += RakamKutu_MouseDown;
                    rakamKutulari[i, j].DragEnter += RakamKutu_DragEnter;
                    // Bu olay fonksiyonu ataması da sürükleme-bırakma işlemini bitirmek için
                    rakamKutulari[i, j].DragDrop += RakamKutu_DragDrop;
                    // Oluşturulan her kutu bu kontrolün bir alt kontrolü olacaktır.
                    this.Controls.Add(rakamKutulari[i, j]);
                }
            }

            RakamKutulariDuzenle();
        }

        private void RakamKutu_DragEnter(object sender, DragEventArgs e)
        {
            if(e.Data.GetDataPresent(typeof(PictureBox)))
            { e.Effect = DragDropEffects.Move; }
            else { e.Effect = DragDropEffects.None; }
        }

        /// <summary>
        /// Bu fonksiyon sürüklemeden sonraki bırakma olayını yanıtlar.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RakamKutu_DragDrop(object sender, DragEventArgs e)
        {
            this.SuspendLayout();
            // Sürükleme işleminin hedefi olan kutuyu belirle
            PictureBox hedefKutu = sender as PictureBox;
            if(hedefKutu != null)
            {
                // Sürüklenen veriden kaynak kutu referansını al
                PictureBox kaynakKutu = e.Data.GetData(typeof(PictureBox)) as PictureBox;
                if(kaynakKutu != null)
                {
                    // Kaynak kutu da bu oyun panelinde olmalıdır.
                    // Paneller arası sürüklemeye izin yok!
                    if (this.Controls.Contains(kaynakKutu))
                    {
                        // Kutular arasında resimleri yer değiştirt:
                        Image imgtmp = hedefKutu.Image;
                        hedefKutu.Image = kaynakKutu.Image;
                        kaynakKutu.Image = imgtmp;
                        // Rakam bilgilerini de yer değiştirt:
                        int tmp = (int)hedefKutu.Tag;
                        hedefKutu.Tag = (int)kaynakKutu.Tag;
                        kaynakKutu.Tag = tmp;
                    }
                }
            }
            this.ResumeLayout();
        }

        private void RakamKutu_MouseDown(object sender, MouseEventArgs e)
        {
            // Sürükleme işleminin başladığı kutunun referansını veri olarak sakla
            PictureBox kaynakKutu = sender as PictureBox;
            if(kaynakKutu != null)
            {
                kaynakKutu.DoDragDrop(kaynakKutu, DragDropEffects.Move);
            }
        }

        /// <summary>
        /// Bu fonksiyon kontrol içindeki rakam kutularını düzenlemek içindir.
        /// Kontrol ilk oluşturulduğunda ve kontrol boyutları değiştiğinde çağrılır.
        /// </summary>
        private void RakamKutulariDuzenle()
        {
            // Öncelikle kare düzen oluşturmak için kenar uzunluğu belirle
            int kontrolBoyut = Math.Min(this.ClientRectangle.Width,
                this.ClientRectangle.Height);
            int kutuBoyut = kontrolBoyut / 3;
            // Matristeki panelleri boyutlandır ve yerleştir:
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    rakamKutulari[i, j].Location = new Point(i * kutuBoyut, j * kutuBoyut);
                    rakamKutulari[i, j].Size = new Size(kutuBoyut, kutuBoyut);
                }
            }
        }
    }
}
