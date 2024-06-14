namespace Labs1
{
    partial class MainForm
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
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.textBoxtInput = new System.Windows.Forms.TextBox();
            this.textBoxtEncrypt = new System.Windows.Forms.TextBox();
            this.textBoxtDecrypt = new System.Windows.Forms.TextBox();
            this.btnText = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxtKey = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBoxText = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnFile = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBoxFile = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxfKey = new System.Windows.Forms.TextBox();
            this.btnFileEncrypt = new System.Windows.Forms.Button();
            this.btnFileDecrypt = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.textBoxFileRes = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog";
            this.openFileDialog.InitialDirectory = "\"С:\\\\\"";
            this.openFileDialog.Multiselect = true;
            this.openFileDialog.SupportMultiDottedExtensions = true;
            // 
            // textBoxtInput
            // 
            this.textBoxtInput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxtInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxtInput.Location = new System.Drawing.Point(12, 41);
            this.textBoxtInput.Multiline = true;
            this.textBoxtInput.Name = "textBoxtInput";
            this.textBoxtInput.Size = new System.Drawing.Size(350, 50);
            this.textBoxtInput.TabIndex = 0;
            this.textBoxtInput.TextChanged += new System.EventHandler(this.textBoxtInput_TextChanged);
            // 
            // textBoxtEncrypt
            // 
            this.textBoxtEncrypt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxtEncrypt.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxtEncrypt.Location = new System.Drawing.Point(420, 41);
            this.textBoxtEncrypt.Multiline = true;
            this.textBoxtEncrypt.Name = "textBoxtEncrypt";
            this.textBoxtEncrypt.ReadOnly = true;
            this.textBoxtEncrypt.Size = new System.Drawing.Size(350, 50);
            this.textBoxtEncrypt.TabIndex = 1;
            // 
            // textBoxtDecrypt
            // 
            this.textBoxtDecrypt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxtDecrypt.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxtDecrypt.Location = new System.Drawing.Point(420, 138);
            this.textBoxtDecrypt.Multiline = true;
            this.textBoxtDecrypt.Name = "textBoxtDecrypt";
            this.textBoxtDecrypt.ReadOnly = true;
            this.textBoxtDecrypt.Size = new System.Drawing.Size(350, 50);
            this.textBoxtDecrypt.TabIndex = 2;
            // 
            // btnText
            // 
            this.btnText.Location = new System.Drawing.Point(420, 196);
            this.btnText.Name = "btnText";
            this.btnText.Size = new System.Drawing.Size(166, 53);
            this.btnText.TabIndex = 3;
            this.btnText.Text = "Зашифровать";
            this.btnText.UseVisualStyleBackColor = true;
            this.btnText.Click += new System.EventHandler(this.btnText_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(341, 26);
            this.label1.TabIndex = 4;
            this.label1.Text = "Введите текст для шифрования";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(415, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(247, 26);
            this.label2.TabIndex = 5;
            this.label2.Text = "Зашифрованный текст";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(415, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(259, 26);
            this.label3.TabIndex = 6;
            this.label3.Text = "Расшифрованный текст";
            // 
            // textBoxtKey
            // 
            this.textBoxtKey.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxtKey.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxtKey.Location = new System.Drawing.Point(12, 138);
            this.textBoxtKey.Multiline = true;
            this.textBoxtKey.Name = "textBoxtKey";
            this.textBoxtKey.Size = new System.Drawing.Size(350, 50);
            this.textBoxtKey.TabIndex = 7;
            this.textBoxtKey.TextChanged += new System.EventHandler(this.textBoxtKey_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(12, 109);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 26);
            this.label4.TabIndex = 8;
            this.label4.Text = "Ключ";
            // 
            // comboBoxText
            // 
            this.comboBoxText.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxText.Items.AddRange(new object[] {
            "столбцовый метод",
            "Виженера, самогенерирующийся ключ"});
            this.comboBoxText.Location = new System.Drawing.Point(12, 225);
            this.comboBoxText.Name = "comboBoxText";
            this.comboBoxText.Size = new System.Drawing.Size(227, 24);
            this.comboBoxText.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(12, 196);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(227, 26);
            this.label5.TabIndex = 10;
            this.label5.Text = "Способ шифрования";
            // 
            // btnFile
            // 
            this.btnFile.Location = new System.Drawing.Point(17, 295);
            this.btnFile.Name = "btnFile";
            this.btnFile.Size = new System.Drawing.Size(120, 53);
            this.btnFile.TabIndex = 11;
            this.btnFile.Text = "Выбрать файл";
            this.btnFile.UseVisualStyleBackColor = true;
            this.btnFile.Click += new System.EventHandler(this.btnFile_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(189, 295);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(227, 26);
            this.label6.TabIndex = 13;
            this.label6.Text = "Способ шифрования";
            // 
            // comboBoxFile
            // 
            this.comboBoxFile.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxFile.Items.AddRange(new object[] {
            "столбцовый метод",
            "Виженера, самогенерирующийся ключ"});
            this.comboBoxFile.Location = new System.Drawing.Point(189, 324);
            this.comboBoxFile.Name = "comboBoxFile";
            this.comboBoxFile.Size = new System.Drawing.Size(227, 24);
            this.comboBoxFile.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(17, 362);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 26);
            this.label7.TabIndex = 15;
            this.label7.Text = "Ключ";
            // 
            // textBoxfKey
            // 
            this.textBoxfKey.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxfKey.Location = new System.Drawing.Point(17, 391);
            this.textBoxfKey.Multiline = true;
            this.textBoxfKey.Name = "textBoxfKey";
            this.textBoxfKey.Size = new System.Drawing.Size(350, 50);
            this.textBoxfKey.TabIndex = 14;
            this.textBoxfKey.TextChanged += new System.EventHandler(this.textBoxfKey_TextChanged);
            // 
            // btnFileEncrypt
            // 
            this.btnFileEncrypt.Location = new System.Drawing.Point(422, 268);
            this.btnFileEncrypt.Name = "btnFileEncrypt";
            this.btnFileEncrypt.Size = new System.Drawing.Size(132, 53);
            this.btnFileEncrypt.TabIndex = 16;
            this.btnFileEncrypt.Text = "Зашифровать";
            this.btnFileEncrypt.UseVisualStyleBackColor = true;
            this.btnFileEncrypt.Click += new System.EventHandler(this.btnFileEncrypt_Click);
            this.btnFileEncrypt.MouseCaptureChanged += new System.EventHandler(this.btnFileEncrypt_MouseCaptureChanged);
            // 
            // btnFileDecrypt
            // 
            this.btnFileDecrypt.Location = new System.Drawing.Point(422, 375);
            this.btnFileDecrypt.Name = "btnFileDecrypt";
            this.btnFileDecrypt.Size = new System.Drawing.Size(132, 53);
            this.btnFileDecrypt.TabIndex = 17;
            this.btnFileDecrypt.Text = "Расшифровать";
            this.btnFileDecrypt.UseVisualStyleBackColor = true;
            this.btnFileDecrypt.Click += new System.EventHandler(this.btnFileDecrypt_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(604, 196);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(166, 53);
            this.button1.TabIndex = 18;
            this.button1.Text = "Расшифровать";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_2);
            // 
            // textBoxFileRes
            // 
            this.textBoxFileRes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxFileRes.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxFileRes.Location = new System.Drawing.Point(560, 268);
            this.textBoxFileRes.Multiline = true;
            this.textBoxFileRes.Name = "textBoxFileRes";
            this.textBoxFileRes.ReadOnly = true;
            this.textBoxFileRes.Size = new System.Drawing.Size(212, 173);
            this.textBoxFileRes.TabIndex = 19;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 453);
            this.Controls.Add(this.textBoxFileRes);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnFileDecrypt);
            this.Controls.Add(this.btnFileEncrypt);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBoxfKey);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.comboBoxFile);
            this.Controls.Add(this.btnFile);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.comboBoxText);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxtKey);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnText);
            this.Controls.Add(this.textBoxtDecrypt);
            this.Controls.Add(this.textBoxtEncrypt);
            this.Controls.Add(this.textBoxtInput);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "MainForm";
            this.Text = "Laba 1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.TextBox textBoxtInput;
        private System.Windows.Forms.TextBox textBoxtEncrypt;
        private System.Windows.Forms.TextBox textBoxtDecrypt;
        private System.Windows.Forms.Button btnText;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxtKey;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBoxText;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnFile;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboBoxFile;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxfKey;
        private System.Windows.Forms.Button btnFileEncrypt;
        private System.Windows.Forms.Button btnFileDecrypt;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBoxFileRes;
    }
}

