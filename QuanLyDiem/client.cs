using System;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using System.IO;
using System.Text;


namespace QuanLyDiem
{
    public class client
    {
        HttpClient _httpClient = null;
        public HttpClient httpClient => _httpClient ?? (new HttpClient());
        
        public  async Task<string> SendAsyncJson(string url, string json)
        {
            
            try
            {

                HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Post, url);
                HttpContent httpContent = new StringContent(json, Encoding.UTF8, "application/json");
                request.Content = httpContent;
                var response = await httpClient.SendAsync(request);
                var rcontent = await response.Content.ReadAsStringAsync();
                return rcontent;

            }
            catch (Exception e)
            {
                throw e;
                
            }
        }

       
    }
}
