namespace RSA_Sign
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnOpenFile = new Button();
            btnSign = new Button();
            textBoxP = new TextBox();
            textBoxQ = new TextBox();
            label1 = new Label();
            label2 = new Label();
            textBoxHash = new TextBox();
            label3 = new Label();
            label4 = new Label();
            textBoxSign = new TextBox();
            label5 = new Label();
            textBoxD = new TextBox();
            checkBoxD = new CheckBox();
            btnCheck = new Button();
            SuspendLayout();
            // 
            // btnOpenFile
            // 
            btnOpenFile.Location = new Point(275, 6);
            btnOpenFile.Name = "btnOpenFile";
            btnOpenFile.Size = new Size(117, 29);
            btnOpenFile.TabIndex = 0;
            btnOpenFile.Text = "открыть файл";
            btnOpenFile.UseVisualStyleBackColor = true;
            btnOpenFile.Click += btnOpenFile_Click;
            // 
            // btnSign
            // 
            btnSign.Location = new Point(275, 45);
            btnSign.Name = "btnSign";
            btnSign.Size = new Size(117, 29);
            btnSign.TabIndex = 1;
            btnSign.Text = "подписать";
            btnSign.UseVisualStyleBackColor = true;
            btnSign.Click += btnSign_Click;
            // 
            // textBoxP
            // 
            textBoxP.Location = new Point(50, 12);
            textBoxP.Name = "textBoxP";
            textBoxP.Size = new Size(125, 27);
            textBoxP.TabIndex = 2;
            textBoxP.Text = "83";
            // 
            // textBoxQ
            // 
            textBoxQ.Location = new Point(50, 45);
            textBoxQ.Name = "textBoxQ";
            textBoxQ.Size = new Size(125, 27);
            textBoxQ.TabIndex = 3;
            textBoxQ.Text = "43";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(26, 15);
            label1.Name = "label1";
            label1.Size = new Size(18, 20);
            label1.TabIndex = 4;
            label1.Text = "p";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(26, 48);
            label2.Name = "label2";
            label2.Size = new Size(18, 20);
            label2.TabIndex = 5;
            label2.Text = "q";
            // 
            // textBoxHash
            // 
            textBoxHash.Location = new Point(50, 115);
            textBoxHash.Name = "textBoxHash";
            textBoxHash.ReadOnly = true;
            textBoxHash.Size = new Size(125, 27);
            textBoxHash.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(7, 118);
            label3.Name = "label3";
            label3.Size = new Size(37, 20);
            label3.TabIndex = 7;
            label3.Text = "Хэш";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(7, 151);
            label4.Name = "label4";
            label4.Size = new Size(40, 20);
            label4.TabIndex = 9;
            label4.Text = "ЭЦП";
            // 
            // textBoxSign
            // 
            textBoxSign.Location = new Point(50, 148);
            textBoxSign.Name = "textBoxSign";
            textBoxSign.ReadOnly = true;
            textBoxSign.Size = new Size(125, 27);
            textBoxSign.TabIndex = 8;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(26, 81);
            label5.Name = "label5";
            label5.Size = new Size(18, 20);
            label5.TabIndex = 11;
            label5.Text = "d";
            // 
            // textBoxD
            // 
            textBoxD.Location = new Point(50, 78);
            textBoxD.Name = "textBoxD";
            textBoxD.Size = new Size(125, 27);
            textBoxD.TabIndex = 10;
            // 
            // checkBoxD
            // 
            checkBoxD.AutoSize = true;
            checkBoxD.Checked = true;
            checkBoxD.CheckState = CheckState.Checked;
            checkBoxD.Location = new Point(181, 84);
            checkBoxD.Name = "checkBoxD";
            checkBoxD.Size = new Size(18, 17);
            checkBoxD.TabIndex = 12;
            checkBoxD.UseVisualStyleBackColor = true;
            checkBoxD.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // btnCheck
            // 
            btnCheck.Location = new Point(275, 84);
            btnCheck.Name = "btnCheck";
            btnCheck.Size = new Size(117, 29);
            btnCheck.TabIndex = 13;
            btnCheck.Text = "проверить";
            btnCheck.UseVisualStyleBackColor = true;
            btnCheck.Click += button1_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(418, 199);
            Controls.Add(btnCheck);
            Controls.Add(checkBoxD);
            Controls.Add(label5);
            Controls.Add(textBoxD);
            Controls.Add(label4);
            Controls.Add(textBoxSign);
            Controls.Add(label3);
            Controls.Add(textBoxHash);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBoxQ);
            Controls.Add(textBoxP);
            Controls.Add(btnSign);
            Controls.Add(btnOpenFile);
            Name = "MainForm";
            StartPosition = FormStartPosition.Manual;
            Text = "RSA Sign";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnOpenFile;
        private Button btnSign;
        private TextBox textBoxP;
        private TextBox textBoxQ;
        private Label label1;
        private Label label2;
        private TextBox textBoxHash;
        private Label label3;
        private Label label4;
        private TextBox textBoxSign;
        private Label label5;
        private TextBox textBoxD;
        private CheckBox checkBoxD;
        private Button btnCheck;
    }
}
