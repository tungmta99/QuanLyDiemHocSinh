using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ServerQuanLyDiemHocSinh
{
    class Program
    {
        static void Main(string[] args)
        {
            HttpServerClass http = new HttpServerClass();
            Console.Write("Connected Success!");
            http.AddPrefix("http://localhost:1300/quanlydiem/");
            http.Start();
        }
    }
}
