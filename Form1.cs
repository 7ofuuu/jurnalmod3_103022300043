using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace jurnalmod3_103022300043
{
    public partial class Form1 : Form
    {
        private int hasil = 0;

        public Form1()
        {
            InitializeComponent();
            btn0.Click += tombolAngka_Click;
            btn1.Click += tombolAngka_Click;
            btn2.Click += tombolAngka_Click;
            btn3.Click += tombolAngka_Click;
            btn4.Click += tombolAngka_Click;
            btn5.Click += tombolAngka_Click;
            btn6.Click += tombolAngka_Click;
            btn7.Click += tombolAngka_Click;
            btn8.Click += tombolAngka_Click;
            btn9.Click += tombolAngka_Click;
            btnPlus.Click += tombolTambah_Click;
            btnEqual.Click += tombolHasil_Click;
            output.Text = " ";

        }

        private void tombolAngka_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            output.Text += btn.Text;
        }

        private void tombolTambah_Click(object sender, EventArgs e)
        {
            hasil += int.Parse(output.Text);
            output.Text = " ";
        }

        private void tombolHasil_Click(object sender, EventArgs e)
        {
            hasil += int.Parse(output.Text);
            output.Text = hasil.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
          

           
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
