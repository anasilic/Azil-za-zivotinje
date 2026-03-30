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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            string slika = openFileDialog1.FileName;
            pictureBox1.Load(slika);
        }

        private void button2_Click(object sender, EventArgs e)
        {

            
            string slika = openFileDialog1.FileName;
            string spol = "";
            string kast = "";
            string cjep="";
            if (cbCijep.Checked == true)
                {
                    cjep = "Cijepljen";
                }
                else 
                {
                    cjep = "Nije cijepljen";
            }
            if (cbKast.Checked == true)
            {
                kast = "Kastriran";
            }
             else
            {
                kast = "Nije kastriran";
            }
            if (rbM.Checked == true)
            {
                spol = "Muško";
            }
            else if (rbZ.Checked == true)
            {
                spol = "Žensko";
            }
            string zapis =Ime.Text + "|" + Vrsta.Text + "|" + Pasmina.Text + "|" + rbM.Checked + "|" + rbZ.Checked + "|" + nudDob.Text + "|" + dtpDolazak.Text + "|" + cbCijep.Checked + "|" + cbKast.Checked + "|" + txtNapomena.Text + "|" + slika;
            Admin.Unos(zapis);
            Ime.Clear();
            Vrsta.Clear();
            Pasmina.Clear();
            rbM.Checked = false;
            rbZ.Checked = false;
            nudDob.Value = 0;
            dtpDolazak.Value = DateTime.Now;
            cbCijep.Checked = false;
            cbKast.Checked = false;
            txtNapomena.Clear();
                
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
