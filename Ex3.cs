using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MironovaKriptForms
{
    public partial class Ex3 : Form
    {
        public Ex3()
        {
            InitializeComponent();
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            int p = Convert.ToInt32(txtP.Text);
            int q = Convert.ToInt32(txtQ.Text);
            int pq = p * q;
            int f_n = (p - 1) * (q - 1);
            int d = getD(f_n);
            int param_e = getE(d,f_n);
            txtOpenK.Text = String.Format("({0},{1})",param_e,pq);
            txtSecretK.Text = String.Format("({0},{1})",d,pq);

        }
        
        int getE(int d, int f_n)
        {
            //e*d=f_n*k+1 уравнение
            int e = -1;

            int k=1;
            while (e < 0)
            {
                e = (f_n * k + 1) % d == 0 ? (f_n * k + 1) / d : -1;
                k++;
            }
            return e;
        }
        int getD(int f_n)
        {
            int res = -1;

            int temp = 2;
            while (res < 0)
            {
                if (NOD(temp, f_n) == 1 && temp < f_n)
                    res = temp;
                temp++;
            }
            return res;
        }
        int NOD(int x, int y)
        {
            while (x != y)
            {
                if (x > y)
                    x = x - y;
                else
                    y = y - x;
            }
            return x;
        }

        private void btnEncode_Click(object sender, EventArgs e)
        {
            if (txtOpenK.Text == "" || txtSecretK.Text == "")
            {
                MessageBox.Show("Необходимо сгенерировать ключи.", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string[] openKeys = txtOpenK.Text.Replace("(", "").Replace(")","").Split(',');
            int key1 = Convert.ToInt32(openKeys[0]);
            int key2 = Convert.ToInt32(openKeys[1]);


            byte[] codeText = Encoding.GetEncoding(1251).GetBytes(txtText.Text);
            foreach (byte temp in codeText)
            {
                BigInteger b = new BigInteger(temp);
                b = BigInteger.Pow(b, key1);
                b %= key2;
                txtCode.Text += b.ToString() + ",";
            }

            
            txtCode.Text = txtCode.Text.Substring(0, txtCode.Text.Length - 1);
            txtText.Text = "";
        }

        private void btnDecode_Click(object sender, EventArgs e)
        {
            if (txtOpenK.Text == "" || txtSecretK.Text == "")
            {
                MessageBox.Show("Необходимо сгенерировать ключи.", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string[] Keys = txtSecretK.Text.Replace("(", "").Replace(")", "").Split(',');
            int key1 = Convert.ToInt32(Keys[0]);
            int key2 = Convert.ToInt32(Keys[1]);

            string[] codeText = txtCode.Text.Replace(" ", "").Split(',');
            byte[] res = new byte[codeText.Length];
            for(int i=0; i < codeText.Length; i++)
            {
                int num = Convert.ToInt32(codeText[i]);
                BigInteger b = new BigInteger(num);
                b = BigInteger.Pow(b, key1);
                b %= key2;
                res[i] = Convert.ToByte(b.ToString());
            }

            txtText.Text = Encoding.GetEncoding(1251).GetString(res);
            txtCode.Text = "";
        }
    }
}
