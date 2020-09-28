using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MironovaKriptForms
{
    public partial class Ex2 : Form
    {
        Dictionary<int, List<int>> s = new Dictionary<int, List<int>>()
        {
            {0, new List<int>(){ 4, 14, 5, 7, 6, 4, 13, 1 } },
            {1, new List<int>(){ 10, 11, 8, 13, 12, 11, 11, 15 } },
            {2, new List<int>(){ 9, 4, 1, 10, 7, 10, 4, 13 } },
            {3, new List<int>(){ 2, 12, 13, 1, 1, 0, 1, 0 } },
            {4, new List<int>(){ 13, 6, 10, 0, 5, 7, 3, 5 } },
            {5, new List<int>(){ 8, 13, 3, 8, 15, 2, 15, 7 } },
            {6, new List<int>(){ 0, 15, 4, 9, 13, 1, 5, 10 } },
            {7, new List<int>(){ 14, 10, 2, 15, 8, 13, 9, 4 } },
            {8, new List<int>(){ 6, 2, 14, 14, 4, 3, 0, 9 } },
            {9, new List<int>(){ 11, 3, 15, 4, 10, 6, 10, 2 } },
            {10, new List<int>(){ 1, 8, 12, 6, 9, 8, 14, 3 } },
            {11, new List<int>(){ 12, 1, 7, 12, 14, 5, 7, 14 } },
            {12, new List<int>(){ 7, 0, 6, 11, 0, 9, 6, 6 } },
            {13, new List<int>(){ 15, 7, 0, 2, 3, 12, 8, 11 } },
            {14, new List<int>(){ 5, 5, 9, 5, 11, 15, 2, 8 } },
            {15, new List<int>(){ 3, 9, 11, 3, 2, 14, 12, 12 } },
        };
        public Ex2()
        {
            InitializeComponent();
        }

        private void btnConvert_Click(object sender, EventArgs e)
        {
            if (txtInputText.TextLength != 8)
            {
                MessageBox.Show("Введите в поле исходный текст 8 первых букв из своих данных: Фамилии Имени.", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (txtFirstKey.TextLength != 4)
            {
                MessageBox.Show("Введите в поле первый подключ 4 первых букв Отчества.", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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


            List<int> L0 = getL0(text);
            List<int> R0 = getR0(text);

            List<int> suma = sumR0X0(R0, X0);

            List<int> afterTable = transform(suma);

            //циклический сдвиг влево на 11
            for(int i=0; i<11; i++)
            {
                int temp = afterTable[0];
                afterTable.RemoveAt(0);
                afterTable.Add(temp);
            }

            List<int> R1 = getR1(L0,afterTable);

            for (int i = 0; i < R1.Count; i++)
                if (i != 0 && i % 8 == 0)
                    txtResult.Text += " " + R1[i];
                else
                    txtResult.Text += R1[i];
        }

        private List<int> getL0(List<int> text)
        {
            List<int> res = new List<int>();
            for (int i = 0; i < 32; i++)
                res.Add(text[i]);
            return res;
        }

        private List<int> getR0(List<int> text)
        {
            List<int> res = new List<int>();
            for (int i = 32; i < 64; i++)
                res.Add(text[i]);
            return res;
        }
        private List<int> sumR0X0(List<int> r0, List<int> x0)
        {
            List<int> res = new List<int>();
            string R0 = "";
            r0.ForEach(m => R0 += m);
            string X0 = "";
            x0.ForEach(m => X0 += m);

            long a = Convert.ToInt64(R0, 2);
            long b = Convert.ToInt64(X0, 2);

            long maska = 0b11111111111111111111111111111111;

            //txtFirstKeyBi.Text = Convert.ToString(sum(a, b) & maska, 2);
            foreach (char c in Convert.ToString(sum(a, b) & maska, 2).ToArray())
              res.Add(c - '0');
            return res;
        }

        private long sum(long a, long b)
        {
            long s = 0;
            long carryin = 0; // перенос из предыдущего разряда
            long k = 1; // маска для получения самого младшего бита
            long temp_a = a;
            long temp_b = b;

            while (temp_a != 0 || temp_b != 0)
            {
                // извлечение самых младших битов
                long ak = a & k, bk = b & k;

                // вычисляем бит который переносится в следующий разряд
                long carryout = (ak & bk) | (ak & carryin) | (bk & carryin);

                // комбинация двух складываемых битов
                // и бита перенесенного из предыдущего разряда
                s |= (ak ^ bk ^ carryin);

                // то что будет перенесено в следующий разряд
                carryin = carryout << 1;

                // сдвигаем маску на один бит влево
                k <<= 1;

                // отрезаем уже обработанные младшие биты
                // остатки используются для контроля продолжения цикла
                temp_a >>= 1;
                temp_b >>= 1;
            }

            return s | carryin;
        }

        private List<int> transform(List<int> suma)
        {
            txtFirstKeyBi.Text = "";
            List<int> res = new List<int>();

            int counter = 7;
            for(int i=0; i<32; i+=4,counter --)
            {
                int znach = suma[i] * 8 + suma[i + 1] * 4 + suma[i + 2] * 2 + suma[i + 3];
                string binZnach = Convert.ToString(s[znach][counter], 2);
                if (binZnach.Length < 4)
                    for (int ii = 0; ii < 4 - binZnach.Length; ii++)
                        res.Add(0);
                foreach (char c in binZnach)
                    res.Add(c - '0');
            }
            return res;
        }
        private List<int> getR1(List<int> L0, List<int> afterTable)
        {
            List<int> res = new List<int>();
            string l0 = "";
            L0.ForEach(m => l0 += m);
            string f = "";
            afterTable.ForEach(m => f += m);

            long a = Convert.ToInt64(l0, 2);
            long b = Convert.ToInt64(f, 2);

            long R1 = a ^ b;
            string r1 = Convert.ToString(R1, 2);
            if (r1.Length < 32)
                for (int i = 0; i < 32 - r1.Length; i++)
                    res.Add(0);
            foreach (char c in r1.ToArray())
                res.Add(c - '0');
            return res;
        }
    }
}
