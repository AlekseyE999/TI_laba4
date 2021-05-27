using StreamCipher;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class Form1 : Form
    {
        public CipherMachine cipherMachine { get; set; }

        public Form1()
        {
            InitializeComponent();
            var polynomial = new int[] { 26, 8, 7, 1 };
            cipherMachine = new CipherMachine(polynomial);
        }

        private void GenKey_Click(object sender, EventArgs e)
        {
            long len = inputText.Text.Length;
            cipherMachine.GenerateKey(len);
            string key = cipherMachine.GenerateKey(len);
            for (int i = 8; i < key.Length; i += 9)
            {
                key = key.Insert(i, " ");
            }

            this.key.Text = key;
        }

        private void open_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;

            string filePath = openFileDialog1.FileName;
            using (StreamReader reader = new StreamReader(filePath))
            {
                inputText.Text = reader.ReadToEnd();
            }
        }

        private void cipher_Click(object sender, EventArgs e)
        {
            string key = this.key.Text.Replace(" ", "");
            string pattern = @"[^01]";
            Regex reg = new Regex(pattern);
            if (reg.IsMatch(key))
            {
                MessageBox.Show("Wrong key entered");
                return;
            }

            
            if (this.inputText.Text.Length * cipherMachine.countBit != key.Length)
            {
                MessageBox.Show("Key and text doesn't match");
                return;
            }

            cipherMachine.key = this.key.Text.Replace(" ", "");
            string cipherText = cipherMachine.Cipher(inputText.Text);
            for (int i = 8; i < cipherText.Length; i += 9)
            {
                cipherText = cipherText.Insert(i, " ");
            }

            this.result.Text = cipherText;
        }

        private void decipher_Click(object sender, EventArgs e)
        {
            cipherMachine.key = this.key.Text;
            string cipherText = this.inputText.Text.Replace(" ", "");
            string pattern = @"[^01]";
            Regex reg = new Regex(pattern);
            if (reg.IsMatch(cipherText))
            {
                MessageBox.Show("Wrong cipher entered");
                return;
            }

            string key = this.key.Text.Replace(" ", "");
            if (reg.IsMatch(key))
            {
                MessageBox.Show("Wrong key entered");
                return;
            }

            if (key.Length != cipherText.Length)
            {
                MessageBox.Show("Key and cipher doesn't match");
                return;
            }

            cipherMachine.key = this.key.Text.Replace(" ", "");
            string text = cipherMachine.Decipher(cipherText);

            this.result.Text = text;
        }

        private void save_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;

            string filePath = openFileDialog1.FileName;
            using (StreamWriter writer = new StreamWriter(filePath))
            {
                writer.Write(this.result.Text);
            }
        }
    }

}




