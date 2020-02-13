using System;
using System.Net.Http;
using System.Threading.Tasks;
using System.Text;
using System.Diagnostics;

namespace QuanLyDiem
{
    public class Client
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
                HttpResponseMessage response = await httpClient.SendAsync(request).ConfigureAwait(false);
                string rcontent = await response.Content.ReadAsStringAsync();                    
                return rcontent;
            }
            catch (Exception e)
            {
                Trace.WriteLine(e.StackTrace);
                throw e;                
            }
        }       
    }
}
