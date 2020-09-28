using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MironovaKriptForms
{
    public partial class Ex1 : Form
    {

        private Dictionary<int, List<int>> s1 = new Dictionary<int, List<int>>()
        {
            {0, new List<int>(){14,4,13,1,2,15,11,8,3,10,6,12,5,9,0,7} },
            {1, new List<int>(){0,15,7,4,14,2,13,1,10,6,12,11,9,5,3,8} },
            {2, new List<int>(){4,1,14,8,13,6,2,11,15,12,9,7,3,10,5,0} },
            {3, new List<int>(){15,12,8,2,4,9,1,7,5,11,3,14,10,0,6,13} }

        };
        private Dictionary<int, List<int>> s2 = new Dictionary<int, List<int>>()
        {
            {0, new List<int>(){15,1,8,14,6,11,3,4,9,7,2,13,12,0,5,10} },
            {1, new List<int>(){13,7,0,9,3,4,6,10,2,8,5,14,12,11,15,1} },
            {2, new List<int>(){0,14,7,11,10,4,13,1,5,8,12,6,9,3,2,15} },
            {3, new List<int>(){13,8,10,1,3,15,4,2,11,6,7,12,0,5,14,9} }
        };
        private Dictionary<int, List<int>> s3 = new Dictionary<int, List<int>>()
        {
            {0, new List<int>(){10,0,9,14,6,3,15,5,1,13,12,7,11,4,2,8} },
            {1, new List<int>(){13,7,0,9,3,4,6,10,2,8,5,14,12,11,15,1} },
            {2, new List<int>(){13,6,4,9,8,15,3,0,11,1,2,12,5,10,14,7} },
            {3, new List<int>(){1,10,13,0,6,9,8,7,4,15,14,3,11,5,2,12} }
        };
        private Dictionary<int, List<int>> s4 = new Dictionary<int, List<int>>()
        {
            {0, new List<int>(){7,13,14,3,0,6,9,10,1,2,8,5,11,12,4,15} },
            {1, new List<int>(){13,8,11,5,6,15,0,3,4,7,2,12,1,10,14,9} },
            {2, new List<int>(){10,6,9,0,12,11,7,13,15,1,3,14,5,2,8,4} },
            {3, new List<int>(){3,15,0,6,10,1,13,8,9,4,5,11,12,7,2,14} }
        };
        private Dictionary<int, List<int>> s5 = new Dictionary<int, List<int>>()
        {
            {0, new List<int>(){2,12,4,1,7,10,11,6,8,5,3,15,13,0,14,9} },
            {1, new List<int>(){14,11,2,12,4,7,13,1,5,0,15,10,3,9,8,6} },
            {2, new List<int>(){4,2,1,11,10,13,7,8,15,9,12,5,6,3,0,14} },
            {3, new List<int>(){11,8,12,7,1,14,2,13,6,15,0,9,10,4,5,3} }
        };
        private Dictionary<int, List<int>> s6 = new Dictionary<int, List<int>>()
        {
            {0, new List<int>(){12,1,10,15,9,2,6,8,0,13,3,4,14,7,5,11} },
            {1, new List<int>(){10,15,4,2,7,12,9,5,6,1,13,14,0,11,3,8} },
            {2, new List<int>(){9,14,15,5,2,8,12,3,7,0,4,10,1,13,11,6} },
            {3, new List<int>(){4,3,2,12,9,5,15,10,11,14,1,7,6,0,8,13} }
        };
        private Dictionary<int, List<int>> s7 = new Dictionary<int, List<int>>()
        {
            {0, new List<int>(){4,11,2,14,15,0,8,13,3,12,9,7,5,10,6,1} },
            {1, new List<int>(){13,0,11,7,4,9,1,10,14,3,5,12,2,15,8,6} },
            {2, new List<int>(){1,4,11,13,12,3,7,14,10,15,6,8,0,5,9,3} },
            {3, new List<int>(){6,11,13,8,1,4,10,7,9,5,0,15,14,2,3,12} }
        };
        private Dictionary<int, List<int>> s8 = new Dictionary<int, List<int>>()
        {
            {0, new List<int>(){13,2,8,4,6,15,11,1,10,9,3,14,5,0,12,7} },
            {1, new List<int>(){1,15,13,8,10,3,7,4,12,5,6,11,0,14,9,2} },
            {2, new List<int>(){7,11,4,1,9,12,14,2,0,6,10,13,15,3,5,8} },
            {3, new List<int>(){2,1,14,7,4,10,8,13,15,12,9,0,3,5,6,11} }
        };

        public Ex1()
        {
            InitializeComponent();
        }


        private void btnExecute_Click(object sender, EventArgs e)
        {
            if (txtFirstKeyBi.Text == "" || txtInputTextBi.Text == "")
            {
                MessageBox.Show("Необходимо перевести в двоичную систему счисления исходный текст и подключ.", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            List<int> text = new List<int>();
            List<int> X0 = new List<int>();

            foreach (char c in txtInputTextBi.Text.Replace(" ", "").ToArray())
                text.Add((int)(c - '0'));
            foreach (char c in txtFirstKeyBi.Text.Replace(" ", "").ToArray())
                X0.Add((int)(c - '0'));

            shortKey(X0);

            List<int> rText = replace(text);

            for (int i = 0; i < rText.Count; i++)
                if (i != 0 && i % 8 == 0)
                    txt1.Text += " " + rText[i];
                else
                    txt1.Text += rText[i];

            List<int> l0 = getL0(rText);
            List<int> r0 = getR0(rText);

            List<int> longR0 = longR(r0);

            for (int i = 0; i < longR0.Count; i++)
                if (i != 0 && i % 8 == 0)
                    txt2.Text += " " + longR0[i];
                else
                    txt2.Text += longR0[i];

            List<int> summaR0X0 = sum(longR0, X0);

            for (int i = 0; i < summaR0X0.Count; i++)
                if (i != 0 && i % 6 == 0)
                    txt3.Text += " " + summaR0X0[i];
                else
                    txt3.Text += summaR0X0[i];

            List<int> posleSBox = convertSBox(summaR0X0);
            //List<int> perestanovkaR = replaceAfterSbox(posleSBox);

            posleSBox.AddRange(l0);

            List<int> result = replaceFinish(posleSBox);

            for (int i = 0; i < result.Count; i++)
                if (i != 0 && i % 8 == 0)
                    txtResult.Text += " " + result[i];
                else
                    txtResult.Text += result[i];

        }

        private void btnConvert_Click(object sender, EventArgs e)
        {
            if (txtInputText.TextLength != 8)
            {
                MessageBox.Show("Введите в поле исходный текст 8 первых букв из своих данных: Фамилии Имени.", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (txtFirstKey.TextLength != 7)
            {
                MessageBox.Show("Введите в поле первый подключ 7 первых букв Отчества.", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            txtInputTextBi.Text = "";
            txtFirstKeyBi.Text = "";
            byte[] txt = Encoding.GetEncoding(1251).GetBytes(txtInputText.Text);
            foreach (byte temp in txt)
                txtInputTextBi.Text += Convert.ToString(temp, 2) + " ";
            txt = Encoding.GetEncoding(1251).GetBytes(txtFirstKey.Text);
            foreach (byte temp in txt)
                txtFirstKeyBi.Text += Convert.ToString(temp, 2) + " ";

        }

        private List<int> longR(List<int> k)
        {
            List<int> result = new List<int>();
            for (int i = 0; i < 32; i += 4)
            {
                result.Add(1);
                result.Add(k[i]);
                result.Add(k[i + 1]);
                result.Add(k[i + 2]);
                result.Add(k[i + 3]);
                result.Add(1);
            }

            return result;

        }

        private void shortKey(List<int> k)
        {
            for (int i = 7; i < k.Count; i += 8)
                k[i] = -1;
            k[k.Count - 2] = -1;
            k.RemoveAll(x => x == -1);
            txtFirstKeyBi.Text = "";
            foreach (int x in k)
                txtFirstKeyBi.Text += x;
        }

        private List<int> getL0(List<int> k)
        {
            List<int> t = new List<int>();
            for (int i = 0; i < 32; i++)
                t.Add(k[i]);
            return t;
        }
        private List<int> getR0(List<int> k)
        {
            List<int> t = new List<int>();
            for (int i = 32; i < 64; i++)
                t.Add(k[i]);
            return t;
        }

        private List<int> replace(List<int> k)
        {
            List<int> replacedText = new List<int>();
            replacedText.Add(k[57]);
            replacedText.Add(k[49]);
            replacedText.Add(k[41]);
            replacedText.Add(k[33]);
            replacedText.Add(k[25]);
            replacedText.Add(k[17]);
            replacedText.Add(k[9]);
            replacedText.Add(k[1]);
            replacedText.Add(k[59]);
            replacedText.Add(k[51]);
            replacedText.Add(k[43]);
            replacedText.Add(k[35]);
            replacedText.Add(k[27]);
            replacedText.Add(k[19]);
            replacedText.Add(k[11]);
            replacedText.Add(k[3]);
            replacedText.Add(k[61]);
            replacedText.Add(k[53]);
            replacedText.Add(k[45]);
            replacedText.Add(k[37]);
            replacedText.Add(k[29]);
            replacedText.Add(k[21]);
            replacedText.Add(k[13]);
            replacedText.Add(k[5]);
            replacedText.Add(k[63]);
            replacedText.Add(k[55]);
            replacedText.Add(k[47]);
            replacedText.Add(k[39]);
            replacedText.Add(k[31]);
            replacedText.Add(k[23]);
            replacedText.Add(k[15]);
            replacedText.Add(k[7]);
            replacedText.Add(k[56]);
            replacedText.Add(k[48]);
            replacedText.Add(k[40]);
            replacedText.Add(k[32]);
            replacedText.Add(k[24]);
            replacedText.Add(k[16]);
            replacedText.Add(k[8]);
            replacedText.Add(k[0]);
            replacedText.Add(k[58]);
            replacedText.Add(k[50]);
            replacedText.Add(k[42]);
            replacedText.Add(k[34]);
            replacedText.Add(k[26]);
            replacedText.Add(k[18]);
            replacedText.Add(k[10]);
            replacedText.Add(k[2]);
            replacedText.Add(k[60]);
            replacedText.Add(k[52]);
            replacedText.Add(k[44]);
            replacedText.Add(k[36]);
            replacedText.Add(k[28]);
            replacedText.Add(k[20]);
            replacedText.Add(k[12]);
            replacedText.Add(k[4]);
            replacedText.Add(k[62]);
            replacedText.Add(k[54]);
            replacedText.Add(k[46]);
            replacedText.Add(k[38]);
            replacedText.Add(k[30]);
            replacedText.Add(k[22]);
            replacedText.Add(k[14]);
            replacedText.Add(k[6]);
            return replacedText;
        }


        private List<int> sum(List<int> r0long, List<int> x0)
        {
            List<int> result = new List<int>();
            string R0 = "";
            r0long.ForEach(m => R0 += m);
            string X0 = "";
            x0.ForEach(m => X0 += m);

            long a = Convert.ToInt64(R0, 2);
            long b = Convert.ToInt64(X0, 2);

            char[] binaryResult = Convert.ToString(a ^ b, 2).ToArray();
            if (binaryResult.Length < 48)
                for (int i = 0; i < 48 - binaryResult.Length; i++)
                    result.Add(0);
            foreach (char c in binaryResult)
                result.Add(c - '0');


            return result;
        }

        private List<int> convertSBox(List<int> r)
        {
            List<int> result = new List<int>();

            List<int> tempValueFromS = new List<int>();

            int fromS1 = s1[r[0] * 2 + r[5]][r[1] * 8 + r[2] * 4 + r[3] * 2 + r[4]];
            addToRes(result, fromS1);
            int fromS2 = s2[r[6] * 2 + r[11]][r[7] * 8 + r[8] * 4 + r[9] * 2 + r[10]];
            addToRes(result, fromS2);
            int fromS3 = s3[r[12] * 2 + r[17]][r[13] * 8 + r[14] * 4 + r[15] * 2 + r[16]];
            addToRes(result, fromS3);
            int fromS4 = s4[r[18] * 2 + r[23]][r[19] * 8 + r[20] * 4 + r[21] * 2 + r[22]];
            addToRes(result, fromS4);
            int fromS5 = s5[r[24] * 2 + r[29]][r[25] * 8 + r[26] * 4 + r[27] * 2 + r[28]];
            addToRes(result, fromS5);
            int fromS6 = s6[r[30] * 2 + r[35]][r[31] * 8 + r[32] * 4 + r[33] * 2 + r[34]];
            addToRes(result, fromS6);
            int fromS7 = s7[r[36] * 2 + r[41]][r[37] * 8 + r[38] * 4 + r[39] * 2 + r[40]];
            addToRes(result, fromS7);
            int fromS8 = s8[r[42] * 2 + r[47]][r[43] * 8 + r[44] * 4 + r[45] * 2 + r[46]];
            addToRes(result, fromS8);


            return result;
        }

        private void addToRes(List<int> res, int s)
        {
            char[] str = Convert.ToString(s, 2).ToArray();
            for (int i = 0; i < 4 - str.Length; i++)
                res.Add(0);
            foreach (char c in str)
                res.Add(c - '0');
        }

        private List<int> replaceAfterSbox(List<int> r)
        {
            List<int> result = new List<int>();
            result.Add(r[15]);
            result.Add(r[6]);
            result.Add(r[19]);
            result.Add(r[20]);
            result.Add(r[28]);
            result.Add(r[11]);
            result.Add(r[27]);
            result.Add(r[16]);
            result.Add(r[0]);
            result.Add(r[14]);
            result.Add(r[22]);
            result.Add(r[25]);
            result.Add(r[4]);
            result.Add(r[17]);
            result.Add(r[30]);
            result.Add(r[9]);
            result.Add(r[1]);
            result.Add(r[7]);
            result.Add(r[23]);
            result.Add(r[13]);
            result.Add(r[31]);
            result.Add(r[26]);
            result.Add(r[2]);
            result.Add(r[8]);
            result.Add(r[18]);
            result.Add(r[12]);
            result.Add(r[29]);
            result.Add(r[5]);
            result.Add(r[21]);
            result.Add(r[10]);
            result.Add(r[3]);
            result.Add(r[24]);
            return result;
        }

        private List<int> replaceFinish(List<int> r)
        {
            List<int> result = new List<int>();
            result.Add(r[39]);
            result.Add(r[7]);
            result.Add(r[47]);
            result.Add(r[15]);
            result.Add(r[55]);
            result.Add(r[23]);
            result.Add(r[63]);
            result.Add(r[31]);
            result.Add(r[38]);
            result.Add(r[6]);
            result.Add(r[46]);
            result.Add(r[14]);
            result.Add(r[54]);
            result.Add(r[22]);
            result.Add(r[62]);
            result.Add(r[30]);
            result.Add(r[37]);
            result.Add(r[5]);
            result.Add(r[45]);
            result.Add(r[13]);
            result.Add(r[53]);
            result.Add(r[21]);
            result.Add(r[61]);
            result.Add(r[29]);
            result.Add(r[36]);
            result.Add(r[4]);
            result.Add(r[44]);
            result.Add(r[12]);
            result.Add(r[52]);
            result.Add(r[20]);
            result.Add(r[60]);
            result.Add(r[28]);
            result.Add(r[35]);
            result.Add(r[3]);
            result.Add(r[43]);
            result.Add(r[11]);
            result.Add(r[51]);
            result.Add(r[19]);
            result.Add(r[59]);
            result.Add(r[27]);
            result.Add(r[34]);
            result.Add(r[2]);
            result.Add(r[42]);
            result.Add(r[10]);
            result.Add(r[50]);
            result.Add(r[18]);
            result.Add(r[58]);
            result.Add(r[26]);
            result.Add(r[31]);
            result.Add(r[1]);
            result.Add(r[41]);
            result.Add(r[9]);
            result.Add(r[49]);
            result.Add(r[17]);
            result.Add(r[57]);
            result.Add(r[25]);
            result.Add(r[32]);
            result.Add(r[0]);
            result.Add(r[40]);
            result.Add(r[8]);
            result.Add(r[48]);
            result.Add(r[16]);
            result.Add(r[56]);
            result.Add(r[24]);

            return result;
        }


    }
}
