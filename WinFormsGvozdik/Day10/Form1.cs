using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;
using System.IO;

namespace Day10
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            radioButton1.Checked = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(DialogResult.OK == openFileDialog1.ShowDialog())
            {
                textBox1.Text = openFileDialog1.FileName;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (DialogResult.OK == saveFileDialog1.ShowDialog())
            {
                if (DialogResult.OK == saveFileDialog2.ShowDialog())
                {
                    // открытие файлового потока на файл
                    FileStream fsFileOut = File.Create(saveFileDialog2.FileName);

                    // создание объекта класса, рализующего алгоритм шифрования DES
                    TripleDESCryptoServiceProvider cryptAlgorithm = new TripleDESCryptoServiceProvider();

                    CryptoStream csEncrypt = new CryptoStream(fsFileOut, cryptAlgorithm.CreateEncryptor(), CryptoStreamMode.Write);
                    //        fsFileOut  -   ссылка на файловый поток    
                    //        cryptAlgorithm.CreateEncryptor()/CreateDecryptor() -   вызов метода криптозащиты
                    //        CryptoStreamMode.Write/CryptoStreamMode.Read    - режим работы с потоком 

                    // Поток - куда будем записывать зашифрованные данные
                    StreamWriter swEncStream = new StreamWriter(csEncrypt, Encoding.Default);

                    StreamReader srFile = new StreamReader(textBox1.Text, Encoding.Default);

                    swEncStream.Write(srFile.ReadToEnd());

                    /*string currLine = srFile.ReadLine();
                    while(currLine != null)
                    {
                        swEncStream.Write(currLine);
                        currLine = srFile.ReadLine();
                    }*/
                    srFile.Close();

                    swEncStream.Flush();
                    swEncStream.Close();

                    // Запись в файл ключа и вектора
                    FileStream fsFileKey = File.Create(saveFileDialog1.FileName); 
                    BinaryWriter bwFile = new BinaryWriter(fsFileKey);
                    bwFile.Write(cryptAlgorithm.Key); // запись ключа
                    bwFile.Write(cryptAlgorithm.IV);  // запись вектора

                    bwFile.Flush();
                    bwFile.Close();
                }
            }  
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (DialogResult.OK == saveFileDialog3.ShowDialog())
            {
                if (DialogResult.OK == openFileDialog2.ShowDialog())
                {
                    // создание файлового потока на файл с ключами
                    FileStream fsKeyFile = File.OpenRead(openFileDialog2.FileName);
                    //создание объекта класса, рализующего алгоритм шифрования DES 
                    TripleDESCryptoServiceProvider cryptAlgorithm = new TripleDESCryptoServiceProvider();
                    // чтение ключа и вектора
                    BinaryReader brFile = new BinaryReader(fsKeyFile);
                    cryptAlgorithm.Key = brFile.ReadBytes(24);
                    cryptAlgorithm.IV = brFile.ReadBytes(8);

                    // открытие файлового потока на файл
                    FileStream fsFileIn = File.Open(textBox1.Text, FileMode.Open);

                    CryptoStream csDecrypt = new CryptoStream(fsFileIn, cryptAlgorithm.CreateDecryptor(), CryptoStreamMode.Read);
                    //        fsFileOut  -   ссылка на файловый поток    
                    //        cryptAlgorithm.CreateEncryptor()/CreateDecryptor() -   вызов метода криптозащиты
                    //        CryptoStreamMode.Write/CryptoStreamMode.Read    - режим работы с потоком 

                    // Поток - куда будем записывать зашифрованные данные
                    StreamWriter swDecStream = new StreamWriter(saveFileDialog3.FileName);

                    StreamReader srFile = new StreamReader(csDecrypt, Encoding.Default);

                    swDecStream.Write(srFile.ReadToEnd());

                    srFile.Close();

                    swDecStream.Flush();
                    swDecStream.Close();
                }
            }  
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(@"https://msdn.microsoft.com/ru-ru/library/system.security.cryptography.tripledescryptoserviceprovider.aspx");
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(@"https://msdn.microsoft.com/ru-ru/library/system.security.cryptography.tripledescryptoserviceprovider.aspx");
        }

        private void CryptDES()
        {

        }

        private void EnCruptDES()
        {

        }
    }
}
