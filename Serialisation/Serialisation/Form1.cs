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

namespace Serialisation
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        static string GetMd5Hash(MD5 md5Hash, string input)
        {

            // Convert the input string to a byte array and compute the hash.
            byte[] data = md5Hash.ComputeHash(Encoding.UTF8.GetBytes(input));

            // Create a new Stringbuilder to collect the bytes
            // and create a string.
            StringBuilder sBuilder = new StringBuilder();

            // Loop through each byte of the hashed data 
            // and format each one as a hexadecimal string.
            for (int i = 0; i < data.Length; i++)
            {
                sBuilder.Append(data[i].ToString("x2"));
            }

            // Return the hexadecimal string.
            return sBuilder.ToString();
        }

        // Verify a hash against a string.
        static bool VerifyMd5Hash(MD5 md5Hash, string input, string hash)
        {
            // Hash the input.
            string hashOfInput = GetMd5Hash(md5Hash, input);

            // Create a StringComparer an compare the hashes.
            StringComparer comparer = StringComparer.OrdinalIgnoreCase;

            if (0 == comparer.Compare(hashOfInput, hash))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void btn_Serialization_Click(object sender, EventArgs e)
        {
            //System.IO.StreamWriter file = new System.IO.StreamWriter("C:\\Users\\NAEFV_INFO\\Desktop\\a.txt", true);
            //file.WriteLine("");
            //file.Close();

            //MD5 first = MD5.Create();
            
            //MD5 second = MD5.Create();
            
            //if(firstHash == secondHash)
            //{
            //    lbl_Name.Text = "ZER";
            //}
            //StringBuilder hash = new StringBuilder();
            //MD5CryptoServiceProvider md5provider = new MD5CryptoServiceProvider();
            //byte[] bytes = md5provider.ComputeHash(new UTF8Encoding().GetBytes("Vincent"));

            //for (int i = 0; i < bytes.Length; i++)
            //{
            //    hash.Append(bytes[i].ToString());
            //}

            

            //StringBuilder hash2 = new StringBuilder();
            //MD5CryptoServiceProvider md5provider2 = new MD5CryptoServiceProvider();
            //byte[] bytes2 = md5provider.ComputeHash(new UTF8Encoding().GetBytes("Vincent"));

            //if(bytes == bytes2)
            //{
            //    lbl_Name.Text = "AAA";
            //}
        }

    }
}
