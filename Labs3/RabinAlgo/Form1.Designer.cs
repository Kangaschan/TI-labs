namespace RabinAlgo
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtBoxMessage = new System.Windows.Forms.TextBox();
            this.txtBoxCipherText = new System.Windows.Forms.TextBox();
            this.txtBoxP = new System.Windows.Forms.TextBox();
            this.txtBoxQ = new System.Windows.Forms.TextBox();
            this.txtBoxB = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Bc = new System.Windows.Forms.Label();
            this.txtBoxDecrMessage = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnEncrypt = new System.Windows.Forms.Button();
            this.btnDecrypt = new System.Windows.Forms.Button();
            this.txtBoxMessageNumb = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.checkBoxFile = new System.Windows.Forms.CheckBox();
            this.checkBoxString = new System.Windows.Forms.CheckBox();
            this.btnChooseFile = new System.Windows.Forms.Button();
            this.btnMakePrime = new System.Windows.Forms.Button();
            this.btnSaveEncr = new System.Windows.Forms.Button();
            this.btnSaveDecr = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtBoxMessage
            // 
            this.txtBoxMessage.AllowDrop = true;
            this.txtBoxMessage.Location = new System.Drawing.Point(177, 38);
            this.txtBoxMessage.Multiline = true;
            this.txtBoxMessage.Name = "txtBoxMessage";
            this.txtBoxMessage.Size = new System.Drawing.Size(250, 150);
            this.txtBoxMessage.TabIndex = 0;
            this.txtBoxMessage.Text = "test";
            this.txtBoxMessage.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtBoxCipherText
            // 
            this.txtBoxCipherText.Location = new System.Drawing.Point(177, 210);
            this.txtBoxCipherText.Multiline = true;
            this.txtBoxCipherText.Name = "txtBoxCipherText";
            this.txtBoxCipherText.Size = new System.Drawing.Size(550, 130);
            this.txtBoxCipherText.TabIndex = 1;
            // 
            // txtBoxP
            // 
            this.txtBoxP.Location = new System.Drawing.Point(36, 38);
            this.txtBoxP.Name = "txtBoxP";
            this.txtBoxP.Size = new System.Drawing.Size(100, 22);
            this.txtBoxP.TabIndex = 2;
            this.txtBoxP.Text = "19";
            this.txtBoxP.TextChanged += new System.EventHandler(this.txtBoxP_TextChanged);
            // 
            // txtBoxQ
            // 
            this.txtBoxQ.Location = new System.Drawing.Point(36, 82);
            this.txtBoxQ.Name = "txtBoxQ";
            this.txtBoxQ.Size = new System.Drawing.Size(100, 22);
            this.txtBoxQ.TabIndex = 3;
            this.txtBoxQ.Text = "5003";
            // 
            // txtBoxB
            // 
            this.txtBoxB.Location = new System.Drawing.Point(36, 126);
            this.txtBoxB.Name = "txtBoxB";
            this.txtBoxB.Size = new System.Drawing.Size(100, 22);
            this.txtBoxB.TabIndex = 4;
            this.txtBoxB.Text = "21";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "Простое p";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(45, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "Простое q";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(40, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "b (b < n = p * q)";
            // 
            // Bc
            // 
            this.Bc.AutoSize = true;
            this.Bc.Location = new System.Drawing.Point(174, 16);
            this.Bc.Name = "Bc";
            this.Bc.Size = new System.Drawing.Size(145, 16);
            this.Bc.TabIndex = 8;
            this.Bc.Text = "Исходное сообщение";
            this.Bc.Click += new System.EventHandler(this.label4_Click);
            // 
            // txtBoxDecrMessage
            // 
            this.txtBoxDecrMessage.Location = new System.Drawing.Point(177, 396);
            this.txtBoxDecrMessage.Multiline = true;
            this.txtBoxDecrMessage.Name = "txtBoxDecrMessage";
            this.txtBoxDecrMessage.Size = new System.Drawing.Size(550, 130);
            this.txtBoxDecrMessage.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(174, 191);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 16);
            this.label4.TabIndex = 10;
            this.label4.Text = "Шифротекст";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(174, 369);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(198, 16);
            this.label5.TabIndex = 11;
            this.label5.Text = "Расшифрованное сообщение";
            // 
            // btnEncrypt
            // 
            this.btnEncrypt.Location = new System.Drawing.Point(23, 201);
            this.btnEncrypt.Name = "btnEncrypt";
            this.btnEncrypt.Size = new System.Drawing.Size(130, 50);
            this.btnEncrypt.TabIndex = 12;
            this.btnEncrypt.Text = "Зашифровать";
            this.btnEncrypt.UseVisualStyleBackColor = true;
            this.btnEncrypt.Click += new System.EventHandler(this.btnEncrypt_Click);
            // 
            // btnDecrypt
            // 
            this.btnDecrypt.Location = new System.Drawing.Point(23, 257);
            this.btnDecrypt.Name = "btnDecrypt";
            this.btnDecrypt.Size = new System.Drawing.Size(130, 50);
            this.btnDecrypt.TabIndex = 13;
            this.btnDecrypt.Text = "Рашифровать";
            this.btnDecrypt.UseVisualStyleBackColor = true;
            this.btnDecrypt.Click += new System.EventHandler(this.btnDecrypt_Click);
            // 
            // txtBoxMessageNumb
            // 
            this.txtBoxMessageNumb.AllowDrop = true;
            this.txtBoxMessageNumb.Location = new System.Drawing.Point(477, 38);
            this.txtBoxMessageNumb.Multiline = true;
            this.txtBoxMessageNumb.Name = "txtBoxMessageNumb";
            this.txtBoxMessageNumb.ReadOnly = true;
            this.txtBoxMessageNumb.Size = new System.Drawing.Size(250, 150);
            this.txtBoxMessageNumb.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(474, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(207, 16);
            this.label6.TabIndex = 15;
            this.label6.Text = "Исходное сообщение, в числах";
            // 
            // checkBoxFile
            // 
            this.checkBoxFile.AutoSize = true;
            this.checkBoxFile.Location = new System.Drawing.Point(36, 154);
            this.checkBoxFile.Name = "checkBoxFile";
            this.checkBoxFile.Size = new System.Drawing.Size(93, 20);
            this.checkBoxFile.TabIndex = 16;
            this.checkBoxFile.Text = "Из файла";
            this.checkBoxFile.UseVisualStyleBackColor = true;
            this.checkBoxFile.CheckedChanged += new System.EventHandler(this.checkBoxFile_CheckedChanged);
            // 
            // checkBoxString
            // 
            this.checkBoxString.AutoSize = true;
            this.checkBoxString.Location = new System.Drawing.Point(36, 180);
            this.checkBoxString.Name = "checkBoxString";
            this.checkBoxString.Size = new System.Drawing.Size(95, 20);
            this.checkBoxString.TabIndex = 17;
            this.checkBoxString.Text = "Из строки";
            this.checkBoxString.UseVisualStyleBackColor = true;
            this.checkBoxString.CheckedChanged += new System.EventHandler(this.checkBoxString_CheckedChanged);
            // 
            // btnChooseFile
            // 
            this.btnChooseFile.Location = new System.Drawing.Point(23, 313);
            this.btnChooseFile.Name = "btnChooseFile";
            this.btnChooseFile.Size = new System.Drawing.Size(130, 50);
            this.btnChooseFile.TabIndex = 18;
            this.btnChooseFile.Text = "Выбрать файл";
            this.btnChooseFile.UseVisualStyleBackColor = true;
            this.btnChooseFile.Click += new System.EventHandler(this.btnChooseFile_Click);
            // 
            // btnMakePrime
            // 
            this.btnMakePrime.Location = new System.Drawing.Point(23, 369);
            this.btnMakePrime.Name = "btnMakePrime";
            this.btnMakePrime.Size = new System.Drawing.Size(130, 50);
            this.btnMakePrime.TabIndex = 19;
            this.btnMakePrime.Text = "Сгенерировать p/q/b";
            this.btnMakePrime.UseVisualStyleBackColor = true;
            this.btnMakePrime.Click += new System.EventHandler(this.btnMakePrime_Click);
            // 
            // btnSaveEncr
            // 
            this.btnSaveEncr.Location = new System.Drawing.Point(23, 425);
            this.btnSaveEncr.Name = "btnSaveEncr";
            this.btnSaveEncr.Size = new System.Drawing.Size(130, 50);
            this.btnSaveEncr.TabIndex = 20;
            this.btnSaveEncr.Text = "Сохранить шифротекст";
            this.btnSaveEncr.UseVisualStyleBackColor = true;
            this.btnSaveEncr.Click += new System.EventHandler(this.btnSaveEncr_Click);
            // 
            // btnSaveDecr
            // 
            this.btnSaveDecr.Location = new System.Drawing.Point(23, 481);
            this.btnSaveDecr.Name = "btnSaveDecr";
            this.btnSaveDecr.Size = new System.Drawing.Size(130, 50);
            this.btnSaveDecr.TabIndex = 21;
            this.btnSaveDecr.Text = "Сохранить сообщение";
            this.btnSaveDecr.UseVisualStyleBackColor = true;
            this.btnSaveDecr.Click += new System.EventHandler(this.btnSaveDecr_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(744, 538);
            this.Controls.Add(this.btnSaveDecr);
            this.Controls.Add(this.btnSaveEncr);
            this.Controls.Add(this.btnMakePrime);
            this.Controls.Add(this.btnChooseFile);
            this.Controls.Add(this.checkBoxString);
            this.Controls.Add(this.checkBoxFile);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtBoxMessageNumb);
            this.Controls.Add(this.btnDecrypt);
            this.Controls.Add(this.btnEncrypt);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtBoxDecrMessage);
            this.Controls.Add(this.Bc);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtBoxB);
            this.Controls.Add(this.txtBoxQ);
            this.Controls.Add(this.txtBoxP);
            this.Controls.Add(this.txtBoxCipherText);
            this.Controls.Add(this.txtBoxMessage);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBoxMessage;
        private System.Windows.Forms.TextBox txtBoxCipherText;
        private System.Windows.Forms.TextBox txtBoxP;
        private System.Windows.Forms.TextBox txtBoxQ;
        private System.Windows.Forms.TextBox txtBoxB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label Bc;
        private System.Windows.Forms.TextBox txtBoxDecrMessage;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnEncrypt;
        private System.Windows.Forms.Button btnDecrypt;
        private System.Windows.Forms.TextBox txtBoxMessageNumb;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox checkBoxFile;
        private System.Windows.Forms.CheckBox checkBoxString;
        private System.Windows.Forms.Button btnChooseFile;
        private System.Windows.Forms.Button btnMakePrime;
        private System.Windows.Forms.Button btnSaveEncr;
        private System.Windows.Forms.Button btnSaveDecr;
    }
}

