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

            // ������������� �������� ��� OpenFileDialog
            openFileDialog1.Title = "�������� ����";
            openFileDialog1.Filter = "��������� ����� (*.txt)|*.txt";
            openFileDialog1.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);

            // ��������� ���������� ���� ��� ������ ����� � ��������� ���������
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                // �������� ������ ��� ���������� �����
                string selectedFileName = openFileDialog1.FileName;

                // ������� ������ ��� ����� � �������
                FileNameOpen = selectedFileName;
                try
                {
                    WorkMessage = File.ReadAllText(FileNameOpen);
                }
                catch
                {
                    MessageBox.Show("�� ������� ��������� ����, ����� ������������ ������ ������");
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
                    Console.WriteLine("�� ������ ���� � �����.");
                    return;
                }

                // ������� ���������� �����, ���� ��� ������������
                string fileNameWithoutExtension = Path.GetFileNameWithoutExtension(filePath);

                // �������� ���� � ����������
                string directory = Path.GetDirectoryName(filePath);

                // ������� ����� ��� ����� � ����������� "_signed" � ����������� ".txt"
                string newFileName = fileNameWithoutExtension + "_signed.txt";
                string newFilePath = Path.Combine(directory, newFileName);

                // ��������� ������ � ����
                File.WriteAllText(newFilePath, data);

                Console.WriteLine("������ ������� ��������� � ����: " + newFilePath);
            }
            catch (Exception ex)
            {
                Console.WriteLine("������ ��� ���������� �����: " + ex.Message);
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
                    MessageBox.Show("����� �� �������");
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
                        MessageBox.Show("p � q �� �������");
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
                    MessageBox.Show("����� �� �������");
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
                        MessageBox.Show("p, q ��� d �� �������");
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

            // ��������� ������ �� ��������� �� �������� ������
            string[] parts = WorkMessage.Split(new string[] { "Sign_start", " Sign:", " e:", " r:" }, StringSplitOptions.None);

            if (parts.Length == 5)
            {
                string workMessage = parts[0]; // �������� WorkMessage
                string sign = parts[2]; // �������� Sign
                string ee = parts[3]; // �������� e
                string r = parts[4]; // �������� r
                bool flag = true;
                try 
                {
                    int E = Convert.ToInt32(ee);
                    int R = Convert.ToInt32(r);
                   
                }
                catch
                {
                    flag = false;
                    MessageBox.Show("E ��� R �� �������");
                }
                if (flag)
                {
                    RSA rsa = new RSA(Convert.ToInt32(r), Convert.ToInt32(ee), workMessage, sign);
                    if (rsa.check())
                    {
                        textBoxHash.Text = rsa.HashFunc();
                        textBoxSign.Text = sign;
                        MessageBox.Show("���� �������� ����� \n ��� ��������� �� ��������� ����� : " + rsa.m.ToString() + " \n ��� �� ������: " + rsa.hash.ToString());
                       
                    }
                    else
                    {
                        MessageBox.Show("���� �������� �� ����� \n ��� ��������� �� ��������� ����� : " + rsa.m.ToString() + " \n ��� �� ������: " + rsa.hash.ToString());
                    }
                }
            }
            else
            {
                MessageBox.Show("������������ ������ ������������ �����.");
            }
        }
    }
}
