using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EditorApp
{
    public partial class EditorForm : Form
    {
        public EditorForm()
        {
            InitializeComponent();
        }

        private void kaydetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog dlgDosyaKaydet = new SaveFileDialog();
            dlgDosyaKaydet.Filter = "RTF dosyaları|*.rtf";
            if(dlgDosyaKaydet.ShowDialog() == DialogResult.OK)
            {
                editor.SaveFile(dlgDosyaKaydet.FileName);
            }
        }

        private void yükleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlgDosyaAc = new OpenFileDialog();
            dlgDosyaAc.Filter = "RTF dosyaları|*.rtf";
            if (dlgDosyaAc.ShowDialog() == DialogResult.OK)
            {
                editor.LoadFile(dlgDosyaAc.FileName);
            }
        }

        private void btnKalin_Click(object sender, EventArgs e)
        {
            Font seciliYaziTipi = editor.SelectionFont;
            editor.SelectionFont = new Font(seciliYaziTipi, FontStyle.Bold);
        }

        private void btnYatik_Click(object sender, EventArgs e)
        {
            Font seciliYaziTipi = editor.SelectionFont;
            editor.SelectionFont = new Font(seciliYaziTipi, FontStyle.Italic);
        }
    }
}
