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

        public static List<string> Ucitaj()
        {
            List<string> lista = new List<string>();
            StreamReader sr = new StreamReader("azil.txt");
            string linija = sr.ReadLine();
            while (linija != null)
            {
                lista.Add(linija);
                linija = sr.ReadLine();
            }
            sr.Close();
            return lista;
        }
        public static List<string> Vrste()
        {
            List<string> lista = new List<string>();
            StreamReader sr = new StreamReader("azil.txt");
            string linija = sr.ReadLine();

            while (linija != null)
            {
                string[] dijelovi = linija.Split('|');
                string vrsta = dijelovi[1];
                lista.Add(vrsta);
                linija = sr.ReadLine();
            }
            sr.Close();
            return lista;
        }
        public static List<string> PronadiPoVrsti(string kriterij)
        {
            List<string> lista = new List<string>();
            StreamReader sr = new StreamReader("azil.txt");
            string linija = sr.ReadLine();
            while (linija != null)
            {
                string[] dijelovi = linija.Split('|');

                if (dijelovi[1] == kriterij)
                {
                    lista.Add(linija);
                }
                linija = sr.ReadLine();
            }
            sr.Close();
            return lista;
        }
        public static void UnosUdomitelja(string zapis)
        {
            StreamWriter sw = new StreamWriter("udomitelji.txt", true);
            sw.WriteLine(zapis);
            sw.Close();
        }

        public static List<string> UcitajUdomitelje()
        {
            List<string> lista = new List<string>();
            StreamReader sr = new StreamReader("udomitelji.txt");
            string linija = sr.ReadLine();
            while (linija != null)
            {
                lista.Add(linija);
                linija = sr.ReadLine();
            }
            sr.Close();
            return lista;
        }

    

        public static List<string> VrsteBroj()
        {
            List
        }
    



