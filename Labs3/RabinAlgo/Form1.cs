using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RabinAlgo
{
    public partial class Form1 : Form
    {
        byte[] MESSAGE;
        int[] cipherText;
        byte[] decrMessage;
        string FileNameOpen;
        string FileNameSave;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnEncrypt_Click(object sender, EventArgs e)
        {

           
            if (checkCorrectInput())
            {
                if (checkBoxString.Checked)
                {
                    int p, q, b;
                    p = int.Parse(txtBoxP.Text);
                    q = int.Parse(txtBoxQ.Text);
                    b = int.Parse(txtBoxB.Text);
                    RabinAlgo.init(p, q, b);
                    byte[] message = Encoding.UTF8.GetBytes(txtBoxMessage.Text);
                    txtBoxMessageNumb.Text = string.Join(",", message);
                    cipherText = RabinAlgo.encrypt(message);
                    txtBoxCipherText.Text = string.Join(",", cipherText);
                }
                if (checkBoxFile.Checked)
                {
                    if (FileNameOpen != "")
                    {
                        byte[] message = new byte[1];
                        try
                        {
                            // Проверяем, существует ли файл
                            if (File.Exists(FileNameOpen))
                            {
                                // Считываем содержимое файла как массив байтов
                                message = File.ReadAllBytes(FileNameOpen);

                                txtBoxMessageNumb.Text = "";
                                for (int i = 0; i < Math.Min(60, message.Length); i++)
                                {
                                    txtBoxMessageNumb.Text += message[i] + " ";
                                }
                                byte[] output = new byte[Math.Min(60, message.Length)];
                                string str = Encoding.UTF8.GetString(output);
                                txtBoxMessage.Text = str;
                            }
                            else
                            {
                                MessageBox.Show("Файл не найден: " + FileNameOpen);
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Ошибка при чтении файла: " + ex.Message);
                        }
                        int p, q, b;
                        p = int.Parse(txtBoxP.Text);
                        q = int.Parse(txtBoxQ.Text);
                        b = int.Parse(txtBoxB.Text);
                        RabinAlgo.init(p, q, b);

                        cipherText = RabinAlgo.encrypt(message);
                        for (int i = 0; i < Math.Min(60, cipherText.Length); i++)
                        {
                            txtBoxCipherText.Text+= cipherText[i] + " ";
                        }
                    }
                    else
                    {
                        MessageBox.Show("Выберете файл");
                    }
                }
            }
        }
        private void btnDecrypt_Click(object sender, EventArgs e)
        {

            if (checkCorrectInput())
            {
                if (checkBoxString.Checked && (cipherText!=null) )
                {
                    int p, q, b;
                    p = int.Parse(txtBoxP.Text);
                    q = int.Parse(txtBoxQ.Text);
                    b = int.Parse(txtBoxB.Text);
                    RabinAlgo.init(p, q, b);
                    decrMessage = RabinAlgo.decrypt(cipherText);
                    txtBoxDecrMessage.Text = Encoding.UTF8.GetString(decrMessage);
                }
                
                if (checkBoxFile.Checked)
                {
                    if (FileNameOpen != "")
                    {
                        try
                        {
                            // Создаем объект BinaryReader для чтения из файла
                            using (BinaryReader reader = new BinaryReader(File.Open(FileNameOpen, FileMode.Open)))
                            {
                                // Получаем размер файла
                                long fileSize = new FileInfo(FileNameOpen).Length;

                                // Проверяем, что размер файла кратен размеру int (4 байта)
                                if (fileSize % sizeof(int) != 0)
                                {
                                    MessageBox.Show("Файл имеет недопустимый формат");
                                    return;
                                }

                                // Вычисляем количество int в файле
                                int numIntegers = (int)(fileSize / sizeof(int));

                                // Создаем массив int для хранения значений
                                cipherText = new int[numIntegers];

                                // Читаем каждое int из файла
                                for (int i = 0; i < numIntegers; i++)
                                {
                                    cipherText[i] = reader.ReadInt32();
                                }

                               
                                txtBoxCipherText.Text = "";
                                for (int i = 0; i < Math.Min(60, cipherText.Length); i++)
                                {
                                    txtBoxCipherText.Text += cipherText[i].ToString() + " ";
                                }
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Ошибка при чтении файла: " + ex.Message);
                        }
                        int p, q, b;
                        txtBoxMessage.Text = "";
                        p = int.Parse(txtBoxP.Text);
                        q = int.Parse(txtBoxQ.Text);
                        b = int.Parse(txtBoxB.Text);
                        RabinAlgo.init(p, q, b);
                        decrMessage = RabinAlgo.decrypt(cipherText);
                        byte[] output = new byte[(Math.Min(60, decrMessage.Length))];
                        for (int i = 0; i < Math.Min(60, decrMessage.Length); i++)
                        {
                            output[i] = (decrMessage[i]);
                        }
                        string str = Encoding.UTF8.GetString(output);
                        txtBoxDecrMessage.Text = str;
                    }
                    else
                    {
                        MessageBox.Show("Выберете файл");
                    }
                }
            }
        }

        private void txtBoxP_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkBoxFile_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxFile.Checked) { checkBoxString.Checked = false; }
        }

        private void checkBoxString_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxString.Checked) { checkBoxFile.Checked = false; }
        }

        private bool checkCorrectInput()
        {
            try
            {
                if ((int.Parse(txtBoxB.Text)) >= int.Parse(txtBoxP.Text) * int.Parse(txtBoxQ.Text))
                {
                    MessageBox.Show("Значение b указано неверно");
                    return false;
                }
                if (!RabinAlgo.checkCorrect(int.Parse(txtBoxP.Text)))
                {
                    MessageBox.Show("Значение P указанно неверно");
                    return false;
                }
                if (!RabinAlgo.checkCorrect(int.Parse(txtBoxQ.Text)))
                {
                    MessageBox.Show("Значение Q указанно неверно");
                    return false;
                }
                if (int.Parse(txtBoxQ.Text) == int.Parse(txtBoxP.Text))
                {
                    MessageBox.Show("Значение Q равно значению P");
                    return false;
                }
                return true;
            }
            catch
            {
                MessageBox.Show("данные не валидны");
                return false;
            }
        }

        private void btnChooseFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();

            // Устанавливаем свойства для OpenFileDialog
            openFileDialog1.Title = "Выберите файл";
            openFileDialog1.Filter = "Все файлы (*.*)|*.*";
            openFileDialog1.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);

            // Открываем диалоговое окно для выбора файла и проверяем результат
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                // Получаем полное имя выбранного файла
                string selectedFileName = openFileDialog1.FileName;

                // Выводим полное имя файла в консоль
                FileNameOpen = selectedFileName;
            }
        }

        private string CreateFileAndGetFileName()
        {
            // Создаем объект SaveFileDialog
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();

            // Устанавливаем свойства для SaveFileDialog
            saveFileDialog1.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
            saveFileDialog1.Title = "Создать файл";

            // Открываем диалоговое окно сохранения файла и возвращаем результат
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                return saveFileDialog1.FileName;
            }
            else
            {
                // Если диалоговое окно закрыто без выбора файла, возвращаем пустую строку
                return string.Empty;
            }
        }

        private void btnSaveEncr_Click(object sender, EventArgs e)
        {
            FileNameSave = CreateFileAndGetFileName();
            try
            {
                // Создаем объект BinaryWriter для записи в файл
                using (BinaryWriter writer = new BinaryWriter(File.Open(FileNameSave, FileMode.Create)))
                {
                    // Записываем каждое целое число из массива в файл
                    foreach (int num in cipherText)
                    {
                        writer.Write(num);
                    }
                }

                Console.WriteLine("Массив int успешно сохранен в файле: " + FileNameSave);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Ошибка при сохранении массива int: " + ex.Message);
            }
        }

        private void btnSaveDecr_Click(object sender, EventArgs e)
        {
            FileNameSave = CreateFileAndGetFileName();
            try
            {
                // Создаем объект BinaryWriter для записи в файл
                using (FileStream fs = new FileStream(FileNameSave, FileMode.Create))
                {
                    // Записываем каждый байт из массива в файл
                    fs.Write(decrMessage, 0, decrMessage.Length);

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при сохранении массива байтов: " + ex.Message);
            }
        }

        private void btnMakePrime_Click(object sender, EventArgs e)
        {
            if(txtBoxP.Text == "" && txtBoxQ.Text == "")
            {
                txtBoxP.Text = 523.ToString();
                txtBoxQ.Text = RabinAlgo.generatePair(523).ToString(); 
                Random random = new Random();
                txtBoxB.Text = random.Next((int)(int.Parse(txtBoxP.Text) * int.Parse(txtBoxP.Text) * 0.001 + 5)).ToString();

            }
            if (txtBoxP.Text == "")
            {
                txtBoxP.Text = RabinAlgo.generatePair(int.Parse(txtBoxQ.Text)).ToString();
                Random random = new Random();
                txtBoxB.Text = random.Next((int) (int.Parse(txtBoxP.Text) * int.Parse(txtBoxP.Text) * 0.001 + 5)).ToString();
            }
            if(txtBoxQ.Text == "")
            {
                int a = RabinAlgo.generatePair(int.Parse(txtBoxP.Text));
                txtBoxQ.Text = (a).ToString();
                Random random = new Random();
                txtBoxB.Text = random.Next((int) (int.Parse(txtBoxP.Text) * int.Parse(txtBoxP.Text) * 0.001 + 5)).ToString();
            }
            if( txtBoxB.Text == "")
            {
                Random random = new Random();
                txtBoxB.Text = random.Next((int)(int.Parse(txtBoxP.Text) * int.Parse(txtBoxP.Text) * 0.001 + 5)).ToString();
            }
        }
    }
}
