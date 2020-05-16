using KutuphaneKayitSistemiV2.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KutuphaneKayitSistemiV2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Kitap ktp = new Kitap();
            ktp.Ad = textBox1.Text;
            ktp.Yazar = textBox2.Text;
            ktp.Yayinevi = textBox3.Text;
            ktp.Fiyat = textBox4.Text;

            ktp.Kaydet(ktp);

            MessageBox.Show("Kayıt Başarılı", "Kitap Kaydı");

            Yukle();

            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
        }


        public void Yukle()
        {
            dataGridView1.DataSource = null;

            Kitap ktp = new Kitap();
            dataGridView1.DataSource = ktp.Get();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Yukle();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Delete();
            Yukle();
        }

        private void Delete()
        {
            int rowIndex = dataGridView1.CurrentCell.RowIndex;
            var dosya = new List<string>(File.ReadAllLines("C:\\Users\\musta\\Desktop\\dosya.txt"));
            dosya.RemoveAt(rowIndex);

            File.WriteAllLines("C:\\Users\\musta\\Desktop\\dosya.txt", dosya.ToArray());
        }
    }
}
