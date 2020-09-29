namespace MironovaKriptForms
{
    partial class Ex5
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtText = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtQ = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtP = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtOpenK = new System.Windows.Forms.TextBox();
            this.txtSecretK = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtSigne = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnExecuteSign = new System.Windows.Forms.Button();
            this.txtResultHash = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnExecuteHash = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.txtH = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.txtH);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtText);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtQ);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtP);
            this.groupBox1.Location = new System.Drawing.Point(12, 105);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(397, 123);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ввод";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(19, 79);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(123, 24);
            this.label4.TabIndex = 5;
            this.label4.Text = "Сообщение :";
            // 
            // txtText
            // 
            this.txtText.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtText.Location = new System.Drawing.Point(148, 76);
            this.txtText.Name = "txtText";
            this.txtText.Size = new System.Drawing.Size(229, 29);
            this.txtText.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(140, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 24);
            this.label2.TabIndex = 3;
            this.label2.Text = "q :";
            // 
            // txtQ
            // 
            this.txtQ.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtQ.Location = new System.Drawing.Point(177, 19);
            this.txtQ.Name = "txtQ";
            this.txtQ.Size = new System.Drawing.Size(68, 29);
            this.txtQ.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(15, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 24);
            this.label3.TabIndex = 1;
            this.label3.Text = "p :";
            // 
            // txtP
            // 
            this.txtP.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtP.Location = new System.Drawing.Point(52, 19);
            this.txtP.Name = "txtP";
            this.txtP.Size = new System.Drawing.Size(83, 29);
            this.txtP.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(108, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(214, 72);
            this.label1.TabIndex = 2;
            this.label1.Text = "Хэш - функция\r\n\r\nHi = (Hi-1 + Mi)^2 mod n\r\n";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnGenerate);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.txtOpenK);
            this.groupBox2.Controls.Add(this.txtSecretK);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Location = new System.Drawing.Point(12, 234);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(397, 173);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Ключи";
            // 
            // btnGenerate
            // 
            this.btnGenerate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnGenerate.Location = new System.Drawing.Point(23, 114);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(355, 38);
            this.btnGenerate.TabIndex = 10;
            this.btnGenerate.Text = "Генерация ключей";
            this.btnGenerate.UseVisualStyleBackColor = true;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(19, 74);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(158, 24);
            this.label5.TabIndex = 9;
            this.label5.Text = "Секретный ключ";
            // 
            // txtOpenK
            // 
            this.txtOpenK.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtOpenK.Location = new System.Drawing.Point(199, 23);
            this.txtOpenK.Name = "txtOpenK";
            this.txtOpenK.ReadOnly = true;
            this.txtOpenK.Size = new System.Drawing.Size(179, 29);
            this.txtOpenK.TabIndex = 6;
            // 
            // txtSecretK
            // 
            this.txtSecretK.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtSecretK.Location = new System.Drawing.Point(199, 67);
            this.txtSecretK.Name = "txtSecretK";
            this.txtSecretK.ReadOnly = true;
            this.txtSecretK.Size = new System.Drawing.Size(179, 29);
            this.txtSecretK.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(19, 26);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(150, 24);
            this.label6.TabIndex = 7;
            this.label6.Text = "Открытый ключ";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtSigne);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.btnExecuteSign);
            this.groupBox3.Controls.Add(this.txtResultHash);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.btnExecuteHash);
            this.groupBox3.Location = new System.Drawing.Point(12, 423);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(396, 220);
            this.groupBox3.TabIndex = 9;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Вывод";
            // 
            // txtSigne
            // 
            this.txtSigne.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtSigne.Location = new System.Drawing.Point(70, 122);
            this.txtSigne.Name = "txtSigne";
            this.txtSigne.Size = new System.Drawing.Size(308, 29);
            this.txtSigne.TabIndex = 9;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(13, 125);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 24);
            this.label8.TabIndex = 10;
            this.label8.Text = "ЭЦП:";
            // 
            // btnExecuteSign
            // 
            this.btnExecuteSign.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnExecuteSign.Location = new System.Drawing.Point(17, 168);
            this.btnExecuteSign.Name = "btnExecuteSign";
            this.btnExecuteSign.Size = new System.Drawing.Size(361, 39);
            this.btnExecuteSign.TabIndex = 8;
            this.btnExecuteSign.Text = "Расчитать ЭЦП";
            this.btnExecuteSign.UseVisualStyleBackColor = true;
            this.btnExecuteSign.Click += new System.EventHandler(this.btnExecuteSign_Click);
            // 
            // txtResultHash
            // 
            this.txtResultHash.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtResultHash.Location = new System.Drawing.Point(69, 19);
            this.txtResultHash.Name = "txtResultHash";
            this.txtResultHash.Size = new System.Drawing.Size(308, 29);
            this.txtResultHash.TabIndex = 6;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(12, 22);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 24);
            this.label7.TabIndex = 7;
            this.label7.Text = "Хэш:";
            // 
            // btnExecuteHash
            // 
            this.btnExecuteHash.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnExecuteHash.Location = new System.Drawing.Point(16, 65);
            this.btnExecuteHash.Name = "btnExecuteHash";
            this.btnExecuteHash.Size = new System.Drawing.Size(361, 39);
            this.btnExecuteHash.TabIndex = 2;
            this.btnExecuteHash.Text = "Расчитать ХЭШ";
            this.btnExecuteHash.UseVisualStyleBackColor = true;
            this.btnExecuteHash.Click += new System.EventHandler(this.btnExecuteHash_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(256, 22);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(44, 24);
            this.label9.TabIndex = 7;
            this.label9.Text = "H0 :";
            // 
            // txtH
            // 
            this.txtH.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtH.Location = new System.Drawing.Point(308, 19);
            this.txtH.Name = "txtH";
            this.txtH.Size = new System.Drawing.Size(70, 29);
            this.txtH.TabIndex = 6;
            // 
            // Ex5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(420, 650);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Ex5";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Ex5";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtText;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtQ;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtP;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtOpenK;
        private System.Windows.Forms.TextBox txtSecretK;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtResultHash;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnExecuteHash;
        private System.Windows.Forms.TextBox txtSigne;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnExecuteSign;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtH;
    }
}