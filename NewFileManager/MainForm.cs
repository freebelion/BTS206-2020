using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace NewFileManager
{
    public partial class MainForm : Form
    {
        #region Degiskenler
        DirectoryInfo kokKlasor;
        #endregion
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            kokKlasor = new DirectoryInfo(
                Environment.GetFolderPath(
                    Environment.SpecialFolder.MyDocuments));

            TreeNode kok = new TreeNode(kokKlasor.Name);
            KlasorPanel.Nodes.Add(kok);
            KlasorlerListele(kok, kokKlasor);
        }

        private void KlasorlerListele(TreeNode anadal, DirectoryInfo anaKlasor)
        {
            try
            {
                DirectoryInfo[] altKlasorler = anaKlasor.GetDirectories();
                foreach (DirectoryInfo klasor in altKlasorler)
                {
                    TreeNode dal = new TreeNode(klasor.Name);
                    dal.Tag = klasor;
                    anadal.Nodes.Add(dal);
                    KlasorlerListele(dal, klasor);
                }
            }
            catch { }
        }

        private void KlasorPanel_AfterSelect(object sender, TreeViewEventArgs e)
        {
            TreeNode seciliDal = e.Node;
            DirectoryInfo seciliKlasor = seciliDal.Tag as DirectoryInfo;
            if(seciliKlasor != null)
            {
                DosyalariListele(seciliKlasor);
            }
        }

        private void DosyalariListele(DirectoryInfo klasor)
        {
            DosyaPanel.Clear();
            FileInfo[] dosyalar = klasor.GetFiles();

            for(int i=0; i < dosyalar.Length; i++)
            {
                ListViewItem lvEleman = new ListViewItem(dosyalar[i].Name);
                lvEleman.Tag = dosyalar[i];
                if (dosyalar[i].Extension == ".pdf")
                { lvEleman.ImageIndex = 1; }
                else if (dosyalar[i].Extension == ".png")
                { lvEleman.ImageIndex = 2; }
                else
                { lvEleman.ImageIndex = 0; }
                DosyaPanel.Items.Add(lvEleman);
            }
        }

        private void sckKucukSimgeler_Click(object sender, EventArgs e)
        {
            DosyaPanel.View = View.SmallIcon;
        }

        private void sckBuyukSimgeler_Click(object sender, EventArgs e)
        {
            DosyaPanel.View = View.LargeIcon;
        }

        private void sckDose_Click(object sender, EventArgs e)
        {
            DosyaPanel.View = View.Tile;
        }

        private void sckListe_Click(object sender, EventArgs e)
        {
            DosyaPanel.View = View.List;
        }

        private void DosyaPanel_AfterLabelEdit(object sender, LabelEditEventArgs e)
        {
            // Bu olay fonksiyonu dosya panelinde (bir ListView kontrolü)
            // bir dosyayı temsil eden eleman üzerinde etiket metni değiştikten
            // sonra işleme konacak ve isim değişikliğini elemanın temsil
            // ettiği asıl dosyaya yansıtacaktır. Ama eksik veya hatalıdır.
            ListViewItem seciliEleman = DosyaPanel.SelectedItems[0];
            FileInfo dosya = seciliEleman.Tag as FileInfo;
            if(dosya != null)
            {
                File.Replace(seciliEleman.Text, dosya.FullName,
                    dosya.Name + "_yedek");
            }
        }
    }
}
