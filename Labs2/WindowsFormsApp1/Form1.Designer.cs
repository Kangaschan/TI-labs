namespace WindowsFormsApp1
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
            this.txtBoxKey = new System.Windows.Forms.TextBox();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnFile = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBoxInput = new System.Windows.Forms.TextBox();
            this.txtBoxOutPut = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtBoxRegs = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtBoxKey
            // 
            this.txtBoxKey.Location = new System.Drawing.Point(28, 54);
            this.txtBoxKey.Name = "txtBoxKey";
            this.txtBoxKey.Size = new System.Drawing.Size(485, 22);
            this.txtBoxKey.TabIndex = 0;
            this.txtBoxKey.Text = "1011100001110011100000111";
            this.txtBoxKey.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBoxKey_KeyPress);
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(671, 36);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(98, 58);
            this.btnStart.TabIndex = 1;
            this.btnStart.Text = "начать";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnFile
            // 
            this.btnFile.Location = new System.Drawing.Point(567, 36);
            this.btnFile.Name = "btnFile";
            this.btnFile.Size = new System.Drawing.Size(98, 58);
            this.btnFile.TabIndex = 2;
            this.btnFile.Text = "Выбрать файл";
            this.btnFile.UseVisualStyleBackColor = true;
            this.btnFile.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(212, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "начальное состояние регистра";
            // 
            // txtBoxInput
            // 
            this.txtBoxInput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBoxInput.Location = new System.Drawing.Point(28, 122);
            this.txtBoxInput.Multiline = true;
            this.txtBoxInput.Name = "txtBoxInput";
            this.txtBoxInput.Size = new System.Drawing.Size(230, 295);
            this.txtBoxInput.TabIndex = 4;
            // 
            // txtBoxOutPut
            // 
            this.txtBoxOutPut.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBoxOutPut.Location = new System.Drawing.Point(526, 122);
            this.txtBoxOutPut.Multiline = true;
            this.txtBoxOutPut.Name = "txtBoxOutPut";
            this.txtBoxOutPut.Size = new System.Drawing.Size(230, 295);
            this.txtBoxOutPut.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(180, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "значение входного файла";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(523, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(189, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "значение выходного файла";
            // 
            // txtBoxRegs
            // 
            this.txtBoxRegs.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBoxRegs.Location = new System.Drawing.Point(278, 122);
            this.txtBoxRegs.Multiline = true;
            this.txtBoxRegs.Name = "txtBoxRegs";
            this.txtBoxRegs.Size = new System.Drawing.Size(230, 295);
            this.txtBoxRegs.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(275, 103);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(217, 16);
            this.label4.TabIndex = 9;
            this.label4.Text = "послдение 2 значения регистра";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtBoxRegs);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtBoxOutPut);
            this.Controls.Add(this.txtBoxInput);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnFile);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.txtBoxKey);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBoxKey;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnFile;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBoxInput;
        private System.Windows.Forms.TextBox txtBoxOutPut;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtBoxRegs;
        private System.Windows.Forms.Label label4;
    }
}

