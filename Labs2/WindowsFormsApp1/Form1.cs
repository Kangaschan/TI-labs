using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.IO.Pipes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsFormsApp1
{   
    public partial class Form1 : Form
    {
        
        public int left, right;
        public LFSR test;
        private string filename;
        private const int REGLEN = 25;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        public class LFSR
        {
            public byte shifted;
            public byte[] buffer;
            public int length { get; private set; }
            public byte[] register;
            public int bytesRead;
            public byte[] output;
            public byte[] ByteModel;
            public int currBit;
            public int keynum = 0;
            public LFSR(int length,string inp)
            {
                
                currBit = 0;
                this.length = length;
                this.register = new byte[length];

                for (int i = 0; i < length; i++)
                {
                    register[i] = (byte)(inp[i] - '0');
                }
                ByteModel = new byte[8];
                }
            public byte[] ByteToBit(byte inp)
            {
                byte b = 0b1;
                byte[] result = new byte[8];
                for (int i = 7; i >= 0; i--)
                {
                    if ((inp & b) != 0)
                        result[i] = 1;
                    b *= 2;
                }
                return result;
            }
            private byte BXor(byte inp, System.Windows.Forms.TextBox txt)
            {
                byte b = 1;
                ByteModel = ByteToBit(inp);
                for (int i = 0; i < 8; i++)
                {
                    int tmp = ByteModel[i] ^ register[currBit];
                    ByteModel[i] = (byte)((ByteModel[i] ^ register[currBit]));
                    currBit++;
                    if (currBit == length)
                    {
                        currBit = 0;
                        ShiftL(txt);
                    }
                }
                byte result = 0;
                for (int i = 7; i >= 0; i--)
                {
                    result = (byte)(result + (byte)(ByteModel[i] * b));
                    b *= 2;
                }
                return result;
            }
            public byte[] ShiftL(System.Windows.Forms.TextBox txt)
            {
                if (keynum < 10*27)
                {
                    txt.Text += register[0].ToString();
                    txt.Text += "";
                }
                shifted = register[0];
                //   byte[] ByteModeltmp = new byte[8];
                int tmp = register[0] ^ (byte)register[22];
                byte smallest = (byte)(tmp);
                for (int i = 0; i < length-1; i++)
                {
                    register[i] = register[i + 1];
                    if(keynum < 10) 
                    { 
                    }
                }
                keynum++;
                register[ length - 1 ] = smallest;
                
                return register;
            }
            public void FRead(string filepath, System.Windows.Forms.TextBox txt)
            {
                FileStream F = new FileStream(filepath, FileMode.Open, FileAccess.ReadWrite);
                try
                {   
                    buffer = new byte[F.Length];
                    bytesRead = F.Read(buffer, 0, buffer.Length);

                    //MessageBox.Show(bytesRead.ToString());
                    output = new byte[bytesRead];
                    for (int i = 0; i < output.Length; i++)
                    {
                        output[i] = BXor(buffer[i],txt);
                    }
                }
                finally
                {
                    F.Dispose();
                }
            }
        }

        private void txtBoxKey_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == '\b')
                return;
            if(e.KeyChar != '0' && e.KeyChar != '1') 
            {
                e.Handled = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtBoxInput.Text = "";
            txtBoxOutPut.Text = "";
            txtBoxRegs.Text = txtBoxKey.Text;
            txtBoxRegs.Text += "";
            if (txtBoxKey.Text.Length < REGLEN)
            {
                MessageBox.Show("Длина стартого сотсояния меньше требуемой");
                return;
            }
            if(txtBoxKey.Text.Length > REGLEN)
                txtBoxKey.Text = txtBoxKey.Text.Substring(0, REGLEN);
            test = new LFSR(REGLEN, txtBoxKey.Text);
            if (filename != null)
            {
                test.FRead(filename,txtBoxRegs);
                right = test.bytesRead - 1;
                if (right > 4*10)
                {
                    left = right - 50;
               //     right = 4*10;
                }
                else
                    left = 0;
                for (int i = 0; i <= right; i++)
                {
                    byte[] tmp = new byte[8];
                    byte[] tmp2 = new byte[8];
                    tmp = test.ByteToBit(test.buffer[i]);
                    tmp2 = test.ByteToBit(test.output[i]);
                    for (int j = 0; j < tmp.Length; j++)
                    {
                        txtBoxInput.Text += tmp[j].ToString();
                        txtBoxOutPut.Text += tmp2[j].ToString();
                    }
                    txtBoxInput.Text += " ";
                    txtBoxOutPut.Text += " ";
                }

/*
                string tempstr = " ";
                for (int j = 0; j < test.currBit; j++)
                {
                    tempstr += test.register[j].ToString();
                }
                for (int i = test.currBit-1; i > 0; i--)
                {
                    test.register[i] = test.register[i - 1];
                }
                test.register[0] = test.shifted;
                for (int j = 0; j < test.register.Length; j++)
                {
                    txtBoxRegs.Text += test.register[j].ToString();
                }*/

                //txtBoxRegs.Text += tempstr;
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "All files(*.*)|*.*";
                saveFileDialog.Title = "Выберите место для сохранения файла";
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string filePath = saveFileDialog.FileName;

                    try
                    {
                        // Создаем новый файл или перезаписываем существующий
                        using (FileStream fileStream = new FileStream(filePath, FileMode.Create))
                        {
                            // Записываем массив байтов в файл
                            fileStream.Write(test.output, 0, test.output.Length);
                        }
                    }
                    finally
                    {

                    }
                }
                else
                    MessageBox.Show("Выберите файл!");
                }
        }


        private void button1_Click_1(object sender, EventArgs e)
        {
            OpenFileDialog openFileDial = new OpenFileDialog();
            //openFileDial.Title = "Выберите файл для работы";
            openFileDial.Filter = "All files(*.*)|*.*";
            openFileDial.RestoreDirectory = true;
            if (openFileDial.ShowDialog() == DialogResult.OK)
            {
                // Получаем полный путь к выбранному файлу
                filename = openFileDial.FileName;
                test = new LFSR(REGLEN, txtBoxKey.Text);
              //  MessageBox.Show(filename);

            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }
    }
}
