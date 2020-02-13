using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace ServerQuanLyDiemHocSinh
{
    class HttpServerClass
    {
        private HttpListener listener;
        private string data;
        public HttpServerClass()
        {
            listener = new HttpListener();
        }
     
        public void AddPrefix(string prefix)
        {
            listener.Prefixes.Add(prefix);
        }
     
        public void Start()
        {
            listener.Start();
            Respone();
        }

        public void Respone()
        {
            while(true)
            {
                HttpListenerContext context = listener.GetContext();
                string msg = "Connected";
                var body = new StreamReader(context.Request.InputStream).ReadToEnd();
                data = body;
                Console.WriteLine(body);
                context.Response.ContentLength64 = Encoding.UTF8.GetByteCount(msg);
                context.Response.StatusCode = (int)HttpStatusCode.OK;
                using (Stream stream = context.Response.OutputStream)
                {
                    using (StreamWriter sw = new StreamWriter(stream))
                    {
                        sw.Write(msg);
                    }
                }
                Console.WriteLine(msg);
            }
        }
    }
}
