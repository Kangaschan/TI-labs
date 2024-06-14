using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace RSA_Sign
{
    public class RSA
    {
        string M,S;
        public int hash;
        public int m;
        public int r, p, q, fi_r, d, e;
        private bool type;
        public RSA(int p, int q, string content)
        {
            this.p = p;
            this.q = q;
            this.M = content;
           
            this.r = p * q;
            this.fi_r = (p - 1) * (q - 1);

            Random rand = new Random();

            do
            {
                e = rand.Next(2, fi_r); // Генерируем случайное число в диапазоне (1, phi(r))
            }
            while (!AreRelativelyPrime(e, fi_r)); // Повторяем, пока e не будет взаимно простым с phi(r)

            int x, y;
            ExtendedGCD(e, fi_r, out x, out y);

            // x может быть отрицательным, поэтому мы добавляем phi_r, чтобы получить положительное значение d
            d = (x % fi_r + fi_r) % fi_r;

            type = true;
        }
        public RSA(int p, int q, int d,string content)
        {
            this.p = p;
            this.q = q;
            this.M = content;
            this.r = p * q;
            this.fi_r = (p - 1) * (q - 1);
            this.d = d;

            Random rand = new Random();

            do
            {
                e = rand.Next(2, fi_r); // Генерируем случайное число в диапазоне (1, phi(r))
            }
            while (!AreRelativelyPrime(e, fi_r)); // Повторяем, пока e не будет взаимно простым с phi(r)
            type = true;
        }
        public RSA(int p, int q, int d, int e, string content)
        {
            this.p = p;
            this.q = q;
            this.r = p * q;
            this.d = d;
            this.e = e;
            this.M = content;

            this.fi_r = (p - 1) * (q - 1);
        }
        public RSA(int r, int e, string content, string Sign)
        {
            this.r = r;
            this.e = e;
            this.M = content;
            this.S = Sign;
        }
        private int EulerPhi(int n)
        {
            int result = n; // Инициализируем результат значением n

            // Проверяем делимость числа n на каждое целое число от 2 до sqrt(n)
            for (int p = 2; p * p <= n; ++p)
            {
                // Если p является простым делителем n
                if (n % p == 0)
                {
                    // Вычитаем из результата значение result / p
                    // Пока n делится на p
                    while (n % p == 0)
                    {
                        n /= p;
                    }
                    result -= result / p;
                }
            }

            // Если n имеет еще простые делители, то уменьшаем результат
            if (n > 1)
            {
                result -= result / n;
            }

            return result;
        }

        private int GCD(int a, int b)
        {
            while (b != 0)
            {
                int temp = b;
                b = a % b;
                a = temp;
            }
            return a;
        }

        private bool AreRelativelyPrime(int a, int b)
        {
            return GCD(a, b) == 1;
        }

        private int ExtendedGCD(int a, int b, out int x, out int y)
        {
            if (a == 0)
            {
                x = 0;
                y = 1;
                return b;
            }

            int x1, y1;
            int gcd = ExtendedGCD(b % a, a, out x1, out y1);

            x = y1 - (b / a) * x1;
            y = x1;

            return gcd;
        }
       
        private  int fastDegree(int a, int b, int mod)//a^b mod n 
        {
            int result = 1;
            a %= mod;

            while (b > 0)
            {
                if ((b & 1) == 1)
                    result = (result * a) % mod;

                b >>= 1;
                a = (a * a) % mod;
            }

            return result;
        }

        public string HashFunc()
        {
            int H0 = 100;
            int H;
            if (M.Length > 0) 
            {
                int tmp = Convert.ToInt32(M[0]);
            H = ((H0 + tmp) * (H0 + tmp)) % r;
            }
            else
            {
                hash = (( H0) % r);
                return ((H0) % r).ToString();
            }
            for (int i = 1; i < this.M.Length; i++)
            {
                int tmp = Convert.ToInt32(M[i]);
                H = ((H + tmp) * (H + tmp)) % r;
            }
            hash = H;
            return H.ToString();
        }

        public string Sign()
        {
            HashFunc();
            return (fastDegree(hash,d,r)).ToString();
        }
        public bool check()
        {
            HashFunc();
/*            if(M.Length ==0)
            m = fastDegree(0, e, r);
            else*/
            m = fastDegree(Convert.ToInt32(S), e, r);
            if(m == hash)
                return true;
            else
            return false;
        }

        public int checkD(int p, int q, int d)
        {
            
            int r = p * q; // Вычисляем произведение p и q
            int phi_r = (p - 1) * (q - 1); // Вычисляем значение функции Эйлера для r

            int e;
            int x, y;
            for (e = 2; e < phi_r; e++)
            {
                if (ExtendedGCD(e, phi_r, out x, out y) == 1)
                {
                    bool isCorrect = (e * d) % phi_r == 1;
                    if (isCorrect)
                        return e;
                    
                }
            }
                return -30;
            // Проверяем условие e * d ≡ 1 (mod φ(r))

        }
    }
}
