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
    public partial class Ex5 : Form
    {
        public Ex5()
        {
            InitializeComponent();
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            int p = Convert.ToInt32(txtP.Text);
            int q = Convert.ToInt32(txtQ.Text);
            int proz = p * q;
            int f_n = (p - 1) * (q - 1);
            int d = getD(f_n);
            int param_e = getE(d, f_n);
            txtOpenK.Text = String.Format("({0},{1})", param_e, proz);
            txtSecretK.Text = String.Format("({0},{1})", d, proz);
        }


        int getE(int d, int f_n)
        {
            //e*d=f_n*k+1 уравнение
            int e = -1;

            int k = 1;
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

        private void btnExecuteHash_Click(object sender, EventArgs e)
        {
            if (txtText.TextLength == 0)
            {
                MessageBox.Show("Введите сообщение, для которого расчитывается хэш.", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            int H = Convert.ToInt32(txtH.Text);
            int p = Convert.ToInt32(txtP.Text);
            int q = Convert.ToInt32(txtQ.Text);
            int pq = p * q;
            byte[] txt = Encoding.GetEncoding(1251).GetBytes(txtText.Text);
            foreach(byte temp in txt)
                H = (H + temp) * (H + temp) % pq;
            txtResultHash.Text = Convert.ToString(H);


        }

        private void btnExecuteSign_Click(object sender, EventArgs e)
        {
            if (txtOpenK.Text == "" || txtSecretK.Text == "")
            {
                MessageBox.Show("Необходимо сгенерировать ключи.", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string[] openKeys = txtSecretK.Text.Replace("(", "").Replace(")", "").Split(',');
            int key1 = Convert.ToInt32(openKeys[0]);
            int key2 = Convert.ToInt32(openKeys[1]);

            //Расчет ЭЦП
            int hash = Convert.ToInt32(txtResultHash.Text);
            BigInteger b1 = new BigInteger(hash);
            b1 = BigInteger.Pow(b1, key1);
            b1 %= key2;
            txtSigne.Text = b1.ToString();


            //Проверка ЭЦП
            string[] keys = txtOpenK.Text.Replace("(", "").Replace(")", "").Split(',');
            key1 = Convert.ToInt32(keys[0]);
            key2 = Convert.ToInt32(keys[1]);
            int sign = Convert.ToInt32(txtSigne.Text);
            BigInteger b2 = new BigInteger(sign);
            b2 = BigInteger.Pow(b2, key1);
            b2 %= key2;

            if(b2.Equals(hash))
                MessageBox.Show("Проверка ЭЦП прошла успешно, подпись признается подлинной.", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show("ЭЦП не прошла проверку, подпись не признается подлинной.", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }
    }
}
