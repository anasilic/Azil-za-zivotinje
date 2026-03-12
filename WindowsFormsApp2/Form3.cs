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

namespace WindowsFormsApp2
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        int i = 0;

        private void Form3_Load(object sender, EventArgs e)
        {
            List<string> lista = Admin.Ucitaj();
            foreach (string linija in lista)
            {
                listBox1.Items.Add(linija.Replace('|', ' '));

            }
            string[] prvi = lista[0].Split('|');
            textBox1.Text = prvi[0];
            textBox2.Text = prvi[1];
            textBox3.Text = prvi[2];
            textBox4.Text = prvi[3];
            textBox5.Text = prvi[4];
            textBox6.Text = prvi[5];
            textBox7.Text = prvi[6];
            textBox8.Text = prvi[7];
            textBox9.Text = prvi[8];
            pictureBox1.Load(prvi[9]);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<string> lista = Admin.Ucitaj();
            i++;
            if (i < lista.Count)

            {
                string[] prvi = lista[i].Split('|');
                textBox1.Text = prvi[0];
                textBox2.Text = prvi[1];
                textBox3.Text = prvi[2];
                textBox4.Text = prvi[3];
                textBox5.Text = prvi[4];
                textBox6.Text = prvi[5];
                textBox7.Text = prvi[6];
                textBox8.Text = prvi[7];
                textBox9.Text = prvi[8];
                pictureBox1.Load(prvi[9]);
            }
            else
            {
                i = 0;
                string[] prvi = lista[i].Split('|');
                textBox1.Text = prvi[0];
                textBox2.Text = prvi[1];
                textBox3.Text = prvi[2];
                textBox4.Text = prvi[3];
                textBox5.Text = prvi[4];
                textBox6.Text = prvi[5];
                textBox7.Text = prvi[6];
                textBox8.Text = prvi[7];
                textBox9.Text = prvi[8];
                pictureBox1.Load(prvi[9]);

            }


        }

        private void button2_Click(object sender, EventArgs e)
        {
            List<string> lista = Admin.Ucitaj();
            i--;
            if (i >= 0)
            {
                string[] prvi = lista[i].Split('|');
                textBox1.Text = prvi[0];
                textBox2.Text = prvi[1];
                textBox3.Text = prvi[2];
                textBox4.Text = prvi[3];
                textBox5.Text = prvi[4];
                textBox6.Text = prvi[5];
                textBox7.Text = prvi[6];
                textBox8.Text = prvi[7];
                textBox9.Text = prvi[8];
                pictureBox1.Load(prvi[9]);
            }
            else
            {
                i = lista.Count - 1;
                string[] prvi = lista[i].Split('|');
                textBox1.Text = prvi[0];
                textBox2.Text = prvi[1];
                textBox3.Text = prvi[2];
                textBox4.Text = prvi[3];
                textBox5.Text = prvi[4];
                textBox6.Text = prvi[5];
                textBox7.Text = prvi[6];
                textBox8.Text = prvi[7];
                textBox9.Text = prvi[8];
                pictureBox1.Load(prvi[9]);
            }
        }
    }
}
