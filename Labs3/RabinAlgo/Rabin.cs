using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RabinAlgo
{
     static internal class RabinAlgo
    {
        private static int p,q;
        private static int n;
        private static int b;

        public static bool checkPrime(int p)
        {
            int tmp =(int) Math.Sqrt(p) + 1;
            for (int i = 2; i < tmp;i++)
            {
                if( p % i == 0)
                {
                    return false;
                }
            }
            return true;
        }

        public static bool checkCorrect(int P)
        {
            return ((checkPrime(P)) && (P % 4 == 3));
        }

        public static bool checkCorrectB(int B)
        {
            return (B < n);
        }
        public static int generatePair(int p)
        {
            if (p % 4 != 3)
                return -1;
            int tmp = p;
            do
            {
                tmp -= 4;
                if (checkPrime(tmp))
                    return tmp;
            }
            while (tmp > 2);
            tmp = p;
            while (tmp < int.MaxValue)
            {
                tmp += 4;
                if(checkPrime(tmp) && (tmp * p > 255))
                return tmp;
            }
            return -1;
        }

        public static void init(int P, int Q, int B)
        {
            if (checkCorrect(P) && checkCorrect(Q))
            {
                p = P;
                q = Q;
                b = B;
                n = p * q;
            }
        }
        private static int fastDegree(int a, int b, int mod)//a^b mod n 
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

        public static int EEA(int a, int b, out int Yp, out int Yq)
        {
            // Исходные значения для уравнения ax + by = НОД(a, b)
            int x0 = 1, y0 = 0;
            int x1 = 0, y1 = 1;

            while (b != 0)
            {
                int q = a / b;  
                int temp = b;
                b = a % b;
                a = temp;

                int xx = x0 - q * x1;
                int yy = y0 - q * y1;
                x0 = x1; y0 = y1;
                x1 = xx; y1 = yy;
            }

            Yp = x0;
            Yq = y0;

            return a;
        }
        private static int descr(int c)
        {
            return (b*b + 4*c) % n;
        }
        private static int[] reside(int descr)
        {
            int[] m = new int[4];
            int Mp = fastDegree(descr, (p + 1) / 4, p);
            int Mq = fastDegree(descr, (q + 1) / 4, q);
            int Yp, Yq;
            EEA(p, q, out Yp, out Yq);
            int[] d = new int[4];
            d[0] = (Yp * p * Mq + Yq * q * Mp) % n;
            d[1] = n - d[0];
            d[2] = (Yp * p * Mq - Yq * q * Mp) % n;
            d[3] = n - d[2];
            for(int i = 0; i < 4; i++)
            {
                if (d[i] < 0)
                    d[i]+=n;
            }    
            for (int i = 0; i < 4; i++)
            {
                if ((d[i] - b) % 2 == 0)
                {
                    m[i] = ((-b + d[i]) / 2) % n;
                }
                else
                {
                    m[i] = ((-b + d[i] + n) / 2) % n;
                }
            }
            for (int i = 0; i < 4; i++)
            {
                if (m[i] < 0)
                    m[i] += n;
            }
            return m;
        }
        
        public static int[] encrypt(byte[] message)
        {
            int[] cipherText;
            cipherText = new int[message.Length];

            for (int i = 0; i < message.Length; i++)
            {
                cipherText[i] = (message[i] * (message[i] + b)) % n;
            }
            return cipherText;
        }  
        public static byte[] decrypt(int[] cipherText)
        {
            byte[] message = new byte[cipherText.Length];
            for(int i = 0;i < cipherText.Length; i++ )
            {
                int[] m = reside(descr(cipherText[i]));  
                for(int j = 0; j < 4; j++)
                {
                    if (m[j] < 256)
                    {
                        message[i] = (byte)m[j];
                        break;
                    }
                }
            }
            return message;
        }

      
    }
}
