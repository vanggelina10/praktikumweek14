using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace praktikumweek14
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1Reverse_Click(object sender, EventArgs e)
        {
                if (textBox1Input.Text == "")
                {
                    MessageBox.Show("Tolong isi textbox terlebih dahulu!");
                }
        }

        private void button2Sort_Click(object sender, EventArgs e)
        {
                if (textBox1Input.Text == "")
                {
                    MessageBox.Show("Tolong isi textbox terlebih dahulu!");
                }
        }
    }
}
