using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace StreamCipher
{
    public class CipherMachine
    {
        public int countBit { get; private set; }

        static private Random random = new Random();

        public int[] Polynomial { get; set; }

        public BigInteger StartRegister { get; set; }

        public string key { get; set; }

        private string GetBinoryRepresentation(string text)
        {
            int i = 0, len = text.Length;
            StringBuilder s = new StringBuilder();
            while (i < len)
            {
                string binory = Convert.ToString(text[i], 2).PadLeft(countBit, '0');
                s.Append(binory);
                i++;
            }

            return s.ToString();
        }

        private string ConvertBinoryToString(string binory)
        {
            StringBuilder text = new StringBuilder();
            int from = 0, len = binory.Length;
            while (from < len)
            {
                char[] letter = new char[countBit];
                binory.CopyTo(from, letter, 0, countBit);
                from += countBit;
                string binorySymb = new String(letter);
                BigInteger num = BinaryToDecimal(binorySymb);
                text.Append((char)num);
            }

            return text.ToString();
        }

        public CipherMachine(int[] polynomial)
        {
            StartRegister = 0x3CBBF17;
            Polynomial = polynomial;
            countBit = 16;
        }

        public BigInteger LFSR(ref BigInteger S)
        {
            S = ((((S >> 0) ^ (S >> 18) ^ (S >> 17) ^ (S >> 25)) & 1) << 25) | (S >> 1);
            return S & 1;
        }

        private BigInteger GenerateBitNumber(long numBit)
        {
            StringBuilder s = new StringBuilder();
            int j = 0;
            while (j < numBit - 1)
            {
                s.Append(random.Next(2).ToString());
                j++;
            }

            s.Insert(0, "1");
            return BinaryToDecimal(s.ToString());
        }

        public string GenerateKey(long bit)
        {
            StringBuilder s = new StringBuilder();
            StartRegister = GenerateBitNumber(Polynomial[0]);
            BigInteger register = StartRegister;
            s.Clear();
            for (int i = 0; i < bit * countBit; i++)
            {
                s.Append(LFSR(ref register));
            }

            return s.ToString();
        }

        private string XOR(string num1, string num2)
        {
            var res = new StringBuilder();
            for (var i = 0; i < num1.Length; i++)
            {
                res.Append(((num1[i] ^ num2[i])).ToString());
            }

            return res.ToString();
        }

        public string Cipher(string text)
        {
            string binory = XOR(GetBinoryRepresentation(text), this.key);
            return binory;
        }

        public BigInteger BinaryToDecimal(string binaryNumber)
        {
            long exponent = 0;
            BigInteger result = 0;
            for (var i = binaryNumber.Length - 1; i >= 0; i--)
            {
                if (binaryNumber[i] == '1')
                {
                    result += Convert.ToInt32(Math.Pow(2, (long)exponent));
                }

                exponent++;
            }

            return result;
        }

        public string Decipher(string cipherText)
        {
            string binory = XOR(cipherText, key);
            string text = ConvertBinoryToString(binory);
            return text;
        }
    }
}
