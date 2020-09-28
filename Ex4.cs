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
    public partial class Ex4 : Form
    {
        public Ex4()
        {
            InitializeComponent();
        }

        private void btnExecute_Click(object sender, EventArgs e)
        {
            if(txtText.TextLength == 0)
            {
                MessageBox.Show("Введите сообщение, для которого расчитывается хэш.", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            int p = Convert.ToInt32(txtP.Text);
            int q = Convert.ToInt32(txtQ.Text);
            int n = p * q;
            int H = 12; //вариант
            byte[] txt = Encoding.GetEncoding(1251).GetBytes(txtText.Text);
            foreach (byte temp in txt)
                H = (H + temp) * (H + temp) % n;
            txtResult.Text = Convert.ToString(H);
        }
    }
}
