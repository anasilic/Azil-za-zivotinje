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
    public partial class frmPocetna : Form
    {
        public frmPocetna()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 fm2 = new Form2();
            fm2.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Close();
                
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form3 fm3 = new Form3();
            fm3.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form4 fm4 = new Form4();
            fm4.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form5 fm5 = new Form5();
            fm5.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form6 fm6 = new Form6();    
            fm6.ShowDialog();
        }
    }
}
