namespace RSA_Sign
{
    public partial class MainForm : Form
    {
        public bool checkPrime(int p)
        {
            int tmp = (int)Math.Sqrt(p) + 1;
            for (int i = 2; i < tmp; i++)
            {
                if (p % i == 0)
                {
                    return false;
                }
            }
            return true;
        }

        string WorkMessage;
        string SignedMessage;
        string FileNameOpen;
        RSA rsaSign;
        public MainForm()
        {
            WorkMessage = "";
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            WorkMessage = "";

        }
        private void btnOpenFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();

            // Устанавливаем свойства для OpenFileDialog
            openFileDialog1.Title = "Выберите файл";
            openFileDialog1.Filter = "Текстовые файлы (*.txt)|*.txt";
            openFileDialog1.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);

            // Открываем диалоговое окно для выбора файла и проверяем результат
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                // Получаем полное имя выбранного файла
                string selectedFileName = openFileDialog1.FileName;

                // Выводим полное имя файла в консоль
                FileNameOpen = selectedFileName;
                try
                {
                    WorkMessage = File.ReadAllText(FileNameOpen);
                }
                catch
                {
                    MessageBox.Show("не удалось прочитать файл, будет использована пустая строка");
                    WorkMessage = "";
                }
            }

        }

        static void SaveStringToFile(string data, string filePath)
        {
            try
            {
                if (string.IsNullOrEmpty(filePath))
                {
                    Console.WriteLine("Не указан путь к файлу.");
                    return;
                }

                // Удаляем расширение файла, если оно присутствует
                string fileNameWithoutExtension = Path.GetFileNameWithoutExtension(filePath);

                // Получаем путь к директории
                string directory = Path.GetDirectoryName(filePath);

                // Создаем новое имя файла с добавлением "_signed" и расширением ".txt"
                string newFileName = fileNameWithoutExtension + "_signed.txt";
                string newFilePath = Path.Combine(directory, newFileName);

                // Сохраняем строку в файл
                File.WriteAllText(newFilePath, data);

                Console.WriteLine("Строка успешно сохранена в файл: " + newFilePath);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Ошибка при сохранении файла: " + ex.Message);
            }
        }
        private void btnSign_Click(object sender, EventArgs e)
        {
            RSA tmp = new RSA(11, 11, "");
            if (!checkBoxD.Checked)
            {
                int p = 0;
                int q = 0;

                bool flag = true;
                try
                {
                    p = Convert.ToInt32(textBoxP.Text);
                    q = Convert.ToInt32(textBoxQ.Text);
                }
                catch
                {
                    MessageBox.Show("Числа не валидны");
                    flag = false;
                }
                if (flag)
                {
                    if (checkPrime(p) && checkPrime(q))
                    {
                        rsaSign = new RSA(p, q, WorkMessage);
                        textBoxHash.Text = rsaSign.HashFunc();
                        textBoxSign.Text = rsaSign.Sign();
                        textBoxD.Text = rsaSign.d.ToString();
                        SignedMessage = WorkMessage + "Sign_start Sign:" + rsaSign.Sign() + " e:" + rsaSign.e.ToString() + " r:" + rsaSign.r.ToString();

                        SaveStringToFile(SignedMessage, FileNameOpen);
                        //MessageBox.Show(rsaSign.HashFunc());
                    }
                    else
                    {
                        MessageBox.Show("p и q не простые");
                    }
                }
            }
            else
            {
                int p = 0;
                int q = 0;
                int d = 0;
                bool flag = true;
                try
                {
                    p = Convert.ToInt32(textBoxP.Text);
                    q = Convert.ToInt32(textBoxQ.Text);
                    d = Convert.ToInt32(textBoxD.Text);
                }
                catch
                {
                    MessageBox.Show("Числа не валидны");
                    flag = false;
                }
                if (flag)
                {
                    if (checkPrime(p) && checkPrime(q) && (tmp.checkD(p,q,d) > 0))
                    {
                        rsaSign = new RSA(p, q, d, tmp.checkD(p, q, d),WorkMessage);
                        textBoxHash.Text = rsaSign.HashFunc();
                        textBoxSign.Text = rsaSign.Sign();
                        SignedMessage = WorkMessage + "Sign_start Sign:" + rsaSign.Sign() + " e:" + rsaSign.e.ToString() + " r:" + rsaSign.r.ToString();

                        SaveStringToFile(SignedMessage, FileNameOpen);
                    }
                    else
                    {
                        MessageBox.Show("p, q или d не валидны");
                    }
                }
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (!checkBoxD.Checked)
            {
                textBoxD.Text = "";
                textBoxD.ReadOnly = true;
            }
            else
            {
                textBoxD.ReadOnly = false;

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
          //  string SignedMessage = "WorkMessage Sign_start Sign:123456 e:7 r:10";

            // Разделяем строку на подстроки по ключевым словам
            string[] parts = WorkMessage.Split(new string[] { "Sign_start", " Sign:", " e:", " r:" }, StringSplitOptions.None);

            if (parts.Length == 5)
            {
                string workMessage = parts[0]; // Получаем WorkMessage
                string sign = parts[2]; // Получаем Sign
                string ee = parts[3]; // Получаем e
                string r = parts[4]; // Получаем r
                bool flag = true;
                try 
                {
                    int E = Convert.ToInt32(ee);
                    int R = Convert.ToInt32(r);
                   
                }
                catch
                {
                    flag = false;
                    MessageBox.Show("E или R не валидны");
                }
                if (flag)
                {
                    RSA rsa = new RSA(Convert.ToInt32(r), Convert.ToInt32(ee), workMessage, sign);
                    if (rsa.check())
                    {
                        textBoxHash.Text = rsa.HashFunc();
                        textBoxSign.Text = sign;
                        MessageBox.Show("Файл подписан верно \n Хэш сообщения по открытому ключу : " + rsa.m.ToString() + " \n Хэш по тексту: " + rsa.hash.ToString());
                       
                    }
                    else
                    {
                        MessageBox.Show("Файл подписан не верно \n хэш сообщения по открытому ключу : " + rsa.m.ToString() + " \n хэш по тексту: " + rsa.hash.ToString());
                    }
                }
            }
            else
            {
                MessageBox.Show("Некорректный формат подписанного файла.");
            }
        }
    }
}
