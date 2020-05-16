using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KutuphaneKayitSistemiV2.Model
{
    public class Kitap
    {

        string baglan = "C:\\Users\\musta\\Desktop\\dosya.txt";

        public string Ad { get; set; }
        public string Yazar { get; set; }
        public string Yayinevi { get; set; }
        public string Fiyat { get; set; }


        public List<Kitap> Get()
        {
            List<Kitap> kitaplar = new List<Kitap>();

            StreamReader sr = new StreamReader(baglan);
            string oku = sr.ReadLine();

            while (oku != null)
            {
                string[] parcala = oku.Split('$');

                Kitap ktp = new Kitap();
                ktp.Ad = parcala[0];
                ktp.Yazar = parcala[1];
                ktp.Yayinevi = parcala[2];
                ktp.Fiyat = parcala[3];

                kitaplar.Add(ktp);


                oku = sr.ReadLine();
            }

            sr.Close();
            sr.Dispose();



            return kitaplar;
        }

        public void Kaydet(Kitap Model)
        {
            StreamWriter sw = File.AppendText(baglan);

            sw.WriteLine(
                Model.Ad+'$'+
                Model.Yazar + '$' +
                Model.Yayinevi + '$' +
                Model.Fiyat
                );

            sw.Close();
            sw.Dispose();
        }


    }
}
