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

namespace MyFileManager
{
    public partial class FileManagerForm : Form
    {
        public FileManagerForm()
        {
            InitializeComponent();
        }

        private void FileManagerForm_Load(object sender, EventArgs e)
        {
            DirectoryInfo anaKlasor = new DirectoryInfo(
                Environment.GetFolderPath(
                    Environment.SpecialFolder.MyDocuments));
            KlasorListele(anaKlasor);
            DosyaListele(anaKlasor);
        }

        private void KlasorListele(DirectoryInfo anaKlasor)
        {
            cbKlasorler.DataSource = anaKlasor.GetDirectories();
        }

        private void DosyaListele(DirectoryInfo anaKlasor)
        {
            /* Eğer dosyaları tek tek liste kutusuna eklemek isterseniz:
            FileInfo[] dosyalar = anaKlasor.GetFiles();
            for(int i=0; i < dosyalar.Length; i++)
            {
                lbDosyalar.Items.Add(dosyalar[i]);
            }
            */
            lbDosyalar.DataSource = anaKlasor.GetFiles();
        }

        private void lbDosyalar_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Delete)
            {
                // lbDosyalar.Items.Remove(lbDosyalar.SelectedItem);
                FileInfo seciliDosya = lbDosyalar.SelectedItem as FileInfo;
                File.Delete(seciliDosya.FullName);
                lbDosyalar.Refresh();
            }
        }

        private void cbKlasorler_SelectedIndexChanged(object sender, EventArgs e)
        {
            DirectoryInfo seciliKlasor = cbKlasorler.SelectedItem as DirectoryInfo;
            if (seciliKlasor != null)
            {
                KlasorListele(seciliKlasor);
                DosyaListele(seciliKlasor);
            }
        }
    }
}
