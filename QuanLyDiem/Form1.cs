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
namespace QuanLyDiem
{
    public partial class Form1 : Form
    {
        private string username, password;
        public Form1()
        {
            InitializeComponent();
        }
        public string ComputeHash(string input, HashAlgorithm algorithm)
        {
            Byte[] inputBytes = Encoding.UTF8.GetBytes(input);

            Byte[] hashedBytes = algorithm.ComputeHash(inputBytes);

            return BitConverter.ToString(hashedBytes);
        }
        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            username = textBoxTenDangNhap.Text;
            password = textBoxPassWord.Text;
            string hPassword = ComputeHash(password, new SHA256CryptoServiceProvider());
            var url = "http://localhost:1300/quanlydiem/";
            var json = @"
                {" + @"""username"":" + username + @",
                    ""password"":" + hPassword + @",
                 }";

            client clt = new client();

            var task = clt.SendAsyncJson(url, json);
            
            task.Wait();

            
        }
    }
}
