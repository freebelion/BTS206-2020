using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace SudokuApp
{
    static class MyGlobal
    {
        private static Random rnd = new Random();

        public static int RandomSayiAl(int min, int max)
        { return rnd.Next(min, max); }

        public static Color RandomRenkAl()
        { return Color.FromArgb(rnd.Next(256), rnd.Next(256), rnd.Next(256)); }
    }
}
