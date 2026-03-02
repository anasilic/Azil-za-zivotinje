using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2
{
    internal static class Admin
    {

        public static void Unos(string zapis)
        {
            StreamWriter sw = new StreamWriter("azil.txt", true);
            sw.WriteLine(zapis);
            sw.Close();
        }

        public static  List<string> Ucitaj ()
        {
            List<string> lista = new List<string>();
            StreamReader sr = new StreamReader("azil.txt");
            string linija = sr.ReadLine();
            while (linija !=null)
            {
                lista.Add(linija);
                linija = sr.ReadLine();
            }
            sr.Close();
            return lista;
        }
    }
}
