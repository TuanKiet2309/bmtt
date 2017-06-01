﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Libs
{
    public class Lib
    {
        //1.
        public static string GetFilePath_CSymm4(string sExt)
        {

            string result = "";
            string filePath = "";
            //Yeu cau nhap duong dan
            Console.Write("Nhập đường dẫn của tập tin dạng ." + sExt + ": ");
            filePath = Console.ReadLine();
            // Kiem tra su ton tai cua tap tin va thoa loai file
            if (File.Exists(filePath))
            {
                string fileExt = Path.GetExtension(filePath).Trim('.');
                if (fileExt.Equals(sExt))
                {
                    result = filePath;
                }
            }
            return result;
        }
        //2.
        public static void ViewData_CSymm4(string sFilePath)
        {
            FileInfo fileInfo = new FileInfo(sFilePath);
            if (sFilePath != "")
            {
                Console.Write("Đường dẫn tập tin:");
                Console.WriteLine(sFilePath);
                long fileLength = fileInfo.Length;
                Console.Write("Kích thước tập tin: ");
                Console.WriteLine(fileLength.ToString());
                string fileExt = Path.GetExtension(sFilePath).Trim('.');
                if (fileExt.Equals("txt"))
                {
                    Console.Write("Số lượng kí tự: ");
                    long n = 0;
                    try
                    {
                        StreamReader reader = new StreamReader(sFilePath, Encoding.UTF8);
                        string Line = reader.ReadLine();
                        while ((Line != null) && (Line != ""))
                        {
                            string[] mang = Line.Split('\t');
                            int i = 0;
                            while (i < mang.Length)
                            {
                                n = n + mang[i++].Length;
                            }
                            Line = reader.ReadLine();
                        }
                        reader.Close();
                    }
                    catch (Exception e)
                    {
                    }

                    Console.WriteLine(n.ToString());
                }
            }
        }
        //3.
        public static string ReadTextFile_CSymm4(string sFilePath)
        {
            string result = "";
            try
            {
                StreamReader reader = new StreamReader(sFilePath, Encoding.UTF8);
                string line = reader.ReadLine();


                while (true)
                {
                    result = result + line;
                    line = reader.ReadLine();
                    if (line == null)
                        break;
                    result = result + "\n";
                }
                reader.Close();

            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
            return result;
        }
        //4.
        public static bool WriteTextFile_CSymm4(string sFilePath, string sData)
        {
            bool bl = true;
            try
            {
                StreamWriter sw = new StreamWriter(sFilePath, false, Encoding.Unicode);
                sw.WriteLine(sData);
                sw.Close();
            }
            catch
            {
                bl = false;
            }
            return bl;
        }
        //5.
        public static byte[] ReadBinFile_CSymm4(string sFilePath)
        {
            byte[] b = null;
            try
            {
                using (Stream reader = new FileStream(sFilePath, FileMode.Open))
                {
                    using (BinaryReader binaryReader = new BinaryReader(reader))
                    {
                        b = binaryReader.ReadBytes((int)reader.Length);
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }

            return b;
        }
        public static byte[] ReadAllBytes(string fileName)
        {
            byte[] buffer = null;
            using (FileStream fs = new FileStream(fileName, FileMode.Open, FileAccess.Read))
            {
                buffer = new byte[fs.Length];
                fs.Read(buffer, 0, (int)fs.Length);
            }
            return buffer;
        }
        //6.
        public static bool WriteBinFile_CSymm4(string sFilePath, byte[] Data)
        {
            bool bl = true;
            using (Stream writer = new FileStream(sFilePath, FileMode.OpenOrCreate))
            {
                try
                {
                    using (BinaryWriter binaryWriter = new BinaryWriter(writer))
                    {
                        binaryWriter.Write(Data, 0, Data.Length);
                    }
                }
                catch (Exception e)
                {
                    bl = false;
                }
                finally
                {
                    writer.Close();
                }
            }

            return bl;
        }
        //7.
        public static string ConvertBinToBase64_CSymm4(byte[] Data)
        {
            string s = null;
            s = Convert.ToBase64String(Data);
            return s;
        }
        public static string Encrypt(string plaintext, string publicKeyXml)
        {
            byte[] data = Encoding.UTF8.GetBytes(plaintext);

            byte[] encryptedData = null;

            using (var provider = new RSACryptoServiceProvider())
            {
                provider.FromXmlString(publicKeyXml);
                if (provider.PublicOnly)
                    encryptedData = provider.Encrypt(data, false);
                else
                    MessageBox.Show("Public Key không hợp lệ!");
            }
            return BitConverter.ToString(encryptedData).Replace("-", " ");
        }

        public static string Decrypt(string ciphertext, string public_privateKeyXml)
        {
            byte[] data = Convert.FromBase64String(ciphertext);

            byte[] decryptedData = null;

            using (var provider = new RSACryptoServiceProvider())
            {
                provider.FromXmlString(public_privateKeyXml);
                if (!provider.PublicOnly)
                    decryptedData = provider.Decrypt(data, false);
                else
                    MessageBox.Show("Private Key không hợp lệ!");
            }
            return Encoding.UTF8.GetString(decryptedData);
        }

        public static void generateKey(ref string publicKey, ref string privateKey)
        {
            RSACryptoServiceProvider rsa = new RSACryptoServiceProvider(1024);
            publicKey = rsa.ToXmlString(false);
            privateKey = rsa.ToXmlString(true);
        }

    }
}
