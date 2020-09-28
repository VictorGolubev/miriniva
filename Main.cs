using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MironovaKriptForms
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Ex1 forma = new Ex1();
            forma.Visible = true;
            forma.Focus();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Ex2 forma = new Ex2();
            forma.Visible = true;
            forma.Focus();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Ex3 forma = new Ex3();
            forma.Visible = true;
            forma.Focus();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Ex4 forma = new Ex4();
            forma.Visible = true;
            forma.Focus();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Ex5 forma = new Ex5();
            forma.Visible = true;
            forma.Focus();
        }
    }
}


