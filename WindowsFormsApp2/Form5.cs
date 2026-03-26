using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }
        int i = 0;

        private void Form5_Load(object sender, EventArgs e)
        {
            List<string> lista = Admin.Ucitaj();
            foreach (string linija in lista)
            {
                NaseZivotinje.Items.Add(linija.Replace('|', ' '));
            }


        }

        private void NaseZivotinje_DoubleClick(object sender, EventArgs e)
        {
            i = NaseZivotinje.SelectedIndex;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            NaseZivotinje.Items.RemoveAt(i);
            string zapis = textBox1.Text + "|" + textBox2.Text + "|" + textBox3.Text;
            Admin.UnosUdomitelja(zapis);
        }
    }

}





