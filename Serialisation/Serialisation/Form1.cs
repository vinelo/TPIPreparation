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
            StringBuilder hash = new StringBuilder();
            MD5CryptoServiceProvider md5provider = new MD5CryptoServiceProvider();
            byte[] bytes = md5provider.ComputeHash(new UTF8Encoding().GetBytes("Vincent"));

            for (int i = 0; i < bytes.Length; i++)
            {
                hash.Append(bytes[i].ToString());
            }

            

            StringBuilder hash2 = new StringBuilder();
            MD5CryptoServiceProvider md5provider2 = new MD5CryptoServiceProvider();
            byte[] bytes2 = md5provider.ComputeHash(new UTF8Encoding().GetBytes("Vincent"));

            if(bytes == bytes2)
            {
                lbl_Name.Text = "AAA";
            }
        }

    }
}
