using System;
using System.Windows.Forms;
using System.IO;

namespace Labs1
{
    public partial class MainForm : Form
    {
        private const string alphabet = "АБВГДЕЁЖЗИЙКЛМНОПРСТУФХЦЧШЩЪЫЬЭЮЯZ";
        protected string[] fInput;
        protected string fKey;
        protected string tIutput;
        protected string tEncrypt;
        protected string tDecrypt;
        protected string tKey;

        private string InpChek(string inp)
        {

            string result = "";
            for (int i = 0; i < inp.Length; i++)
            {
                if (((inp[i] >= 'а' && inp[i] <= 'я') || inp[i] == 'ё') || ((inp[i] >= 'А' && inp[i] <= 'Я') || inp[i] == 'Ё'))
                    result += inp[i];
            }
            result = result.ToUpper();
            return result;
        }

        private void ColumnEncrypt(string tKey, string tInput)
        {
            int inpLen = tIutput.Length;
            int keyLen = tKey.Length;
            string[] matr = new string[keyLen];

            for (int i = 0; i < keyLen; i++) //matr init
            {
                matr[i] = tKey[i].ToString();
            }

            int k = 0;
            for (int i = 0; i < inpLen; i++)
            {
                matr[k++] += tIutput[i];
                if (k >= keyLen)
                {
                    k = 0;
                }
            }

            tEncrypt = "";
            int min = 0;
            k = 0;
            while (k <= keyLen)
            {

                for (int i = 0; i < keyLen; i++)
                {
                    if (alphabet.IndexOf(matr[i][0]) < alphabet.IndexOf(matr[min][0]))
                        min = i;
                }
                tEncrypt += matr[min].Substring(1);
                matr[min] = "Z";
                k++;
            }

        }
        private void ColumnDecrypt(string tKey, string tInput)
        {


            int inpLen = tIutput.Length;
            int keyLen = tKey.Length;
            string[] matr = new string[keyLen];

            for (int i = 0; i < keyLen; i++) //matr init
            {
                matr[i] = tKey[i].ToString();
            }


            int k = inpLen % keyLen, j = 0, add = inpLen / keyLen;

            int min = 0;
            for (int i = 0; i < keyLen; i++)
            { 
                for (int z = 0; z < keyLen; z++)
                {
                    if (alphabet.IndexOf(matr[z][0]) < alphabet.IndexOf(matr[min][0]))
                        min = z;
                }
                matr[min] = "Z";

                if (min < k)
                {
                    matr[min] += tIutput.Substring(j, add + 1);
                    j += add + 1;
                }

                else
                {
                    matr[min] += tIutput.Substring(j, add);
                    j += add;
                }

            }

            tDecrypt = "";
            k = 1;
            j = keyLen;
            for (int i = 0; i < inpLen; i++)
            {
                if (i >= j)
                {
                    k++;
                    j += keyLen;
                }
                tDecrypt += matr[i % keyLen][k].ToString();

            }
            // textBoxtDecrypt.Text = tDecrypt;


        }
        private void VizhinerEncrypt(string tKey, string tInput)
        {

            tEncrypt = "";
            int inpLen = tIutput.Length;
            int keyLen = tKey.Length;
            int i = 0;
            while ((i < keyLen) && (i < inpLen))
            {
                tEncrypt += alphabet[((alphabet.IndexOf(tIutput[i]) + alphabet.IndexOf(tKey[i])) % 33)];
                i++;
            }
            while (i < inpLen)
            {
                tEncrypt += alphabet[((alphabet.IndexOf(tIutput[i]) + alphabet.IndexOf(tIutput[i - keyLen])) % 33)];
                i++;
            }
            //  textBoxtEncrypt.Text = tEncrypt;
        }
        private void VizhinerDecrypt(string tKey, string tInput)
        {
            tIutput = InpChek(tIutput);
            tKey = InpChek(tKey);
            if (tKey.Length == 0)
            {
                MessageBox.Show("Ваш ключ не валиден");
            }
            else
            {
                if (tIutput.Length == 0)
                {
                    MessageBox.Show("Ваш текст не валиден");
                }
                else
                {
                    tDecrypt = "";
                    int inpLen = tIutput.Length;
                    int keyLen = tKey.Length;
                    int i = 0;
                    int k;
                    while ((i < keyLen) && (i < inpLen))
                    {
                        k = (alphabet.IndexOf(tIutput[i]) - alphabet.IndexOf(tKey[i]));
                        if (k < 0)
                        {
                            k += 33;
                        }
                        tDecrypt += alphabet[k];
                        i++;
                    }
                    while (i < inpLen)
                    {
                        k = (alphabet.IndexOf(tIutput[i]) - alphabet.IndexOf(tDecrypt[i - keyLen]));
                        if (k < 0)
                        {
                            k += 33;
                        }
                        tDecrypt += alphabet[k];
                        i++;
                    }
                  //  textBoxtDecrypt.Text = tDecrypt;
                }
            }
        }

        
        public MainForm()
        {
            InitializeComponent();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
        
        }
  

        private void btnFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.ShowDialog();
            fInput = fileDialog.FileNames;
            for (int i = 0; i < fInput.Length; i++)
            {
                if (fInput[i].EndsWith(".txt") == false)
                {
                    MessageBox.Show("Вы выбрали не текстовый файл");
                }
            }

        }

        private void textBoxtInput_TextChanged(object sender, EventArgs e)
        {
            tIutput = textBoxtInput.Text;
        }

        private void textBoxtKey_TextChanged(object sender, EventArgs e)
        {
            tKey = textBoxtKey.Text;
        }

        private void textBoxfKey_TextChanged(object sender, EventArgs e)
        {
            fKey = textBoxtKey.Text;
        }

        private void btnText_Click(object sender, EventArgs e)
        {
            tIutput = InpChek(tIutput);
            tKey = InpChek(tKey);
            if (tKey.Length == 0)
            {
                MessageBox.Show("Ваш ключ не валиден");
            }
            else
            {
                if (tIutput.Length == 0)
                {
                    MessageBox.Show("Ваш текст не валиден");
                }
                else
                {
                    if (comboBoxText.SelectedIndex == 0)
                    {

                        ColumnEncrypt(tKey, tIutput);
                        textBoxtEncrypt.Text = tEncrypt;
                    }
                    if (comboBoxText.SelectedIndex == 1)
                    {
                        if (tKey.Length == 0)
                        {
                            MessageBox.Show("Ваш ключ не валиден");
                        }
                        VizhinerEncrypt(tKey, tIutput);
                        textBoxtEncrypt.Text = tEncrypt;
                    }
                }
            }
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            tIutput = InpChek(tIutput);
            tKey = InpChek(tKey);
            if (tKey.Length == 0)
            {
                MessageBox.Show("Ваш ключ не валиден");
            }
            else
            {
                if (tIutput.Length == 0)
                {
                    MessageBox.Show("Ваш текст не валиден");
                }
                else
                {
                    if (comboBoxText.SelectedIndex == 0)
                    {
                       
                        ColumnDecrypt(tKey, tIutput);
                        textBoxtDecrypt.Text = tDecrypt;
                    }
                    if (comboBoxText.SelectedIndex == 1)
                    {
                        VizhinerDecrypt(tKey, tIutput);
                        textBoxtDecrypt.Text = tDecrypt;
                    }
                }
            }
        }

        private void btnFileDecrypt_Click(object sender, EventArgs e)
        {
            tIutput = File.ReadAllText(fInput[0]);
            tIutput = InpChek(tIutput);
            tKey = InpChek(textBoxfKey.Text);
            if (tKey.Length == 0)
            {
                MessageBox.Show("Ваш ключ не валиден");
            }
            else
            {
                if (tIutput.Length == 0)
                {
                    MessageBox.Show("Ваш текст не валиден");
                }
                else
                {
                    if (comboBoxFile.SelectedIndex == 0)
                    {
                        ColumnDecrypt(tKey, tIutput);
                        textBoxFileRes.Text = tDecrypt;
                        using (StreamWriter writer = new StreamWriter(fInput[0]))
                        {
                            writer.Write(tDecrypt);
                        }
                    }
                    if (comboBoxFile.SelectedIndex == 1)
                    {
                        VizhinerDecrypt(tKey, tIutput);
                        textBoxFileRes.Text = tDecrypt;
                        using (StreamWriter writer = new StreamWriter(fInput[0]))
                        {
                            writer.Write(tDecrypt);
                        }
                    }
                }
            }
        }

        private void btnFileEncrypt_Click(object sender, EventArgs e)
        {
            tIutput = File.ReadAllText(fInput[0]);
            tIutput = InpChek(tIutput);
            tKey = InpChek(textBoxfKey.Text);
            if (tKey.Length == 0)
            {
                MessageBox.Show("Ваш ключ не валиден");
            }
            else
            {
                if (tIutput.Length == 0)
                {
                    MessageBox.Show("Ваш текст не валиден");
                }
                else
                {
                    if (comboBoxFile.SelectedIndex == 0)
                    {
                        ColumnEncrypt(tKey, tIutput);
                        textBoxFileRes.Text = tEncrypt;
                        using (StreamWriter writer = new StreamWriter(fInput[0]))
                        {
                            writer.Write(tEncrypt);
                        }
                    }
                    if (comboBoxFile.SelectedIndex == 1)
                    {
                        VizhinerEncrypt(tKey, tIutput);
                        textBoxFileRes.Text = tEncrypt;
                        using (StreamWriter writer = new StreamWriter(fInput[0]))
                        {
                            writer.Write(tEncrypt);
                        }
                    }
                }
            }
        }

        private void btnFileEncrypt_MouseCaptureChanged(object sender, EventArgs e)
        {

        }
    }
}
