using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using System.Web;

namespace JavaRestfulAspClient.Models
{
    public class DemoRestfulClient
    {
        private String BASE_URL = "http://localhost:8080/Asp.net_project_Java_Web_API/rest/demo/";

        public Task<String> helloWorld(){
            try
            {
                var client = new HttpClient();
                client.BaseAddress = new Uri(BASE_URL);
                client.DefaultRequestHeaders.Accept.Add(
                    new MediaTypeWithQualityHeaderValue("text/plain"));
                HttpResponseMessage response = client.GetAsync("helloWorld").Result;
                return response.Content.ReadAsStringAsync();
            }
            catch
            {
                return null;
            }
        }

        public Task<String> helloWorldHTML()
        {
            try
            {
                var client = new HttpClient();
                client.BaseAddress = new Uri(BASE_URL);
                client.DefaultRequestHeaders.Accept.Add(
                    new MediaTypeWithQualityHeaderValue("text/html"));
                HttpResponseMessage response = client.GetAsync("helloWorldHTML").Result;
                return response.Content.ReadAsStringAsync();
            }
            catch
            {
                return null;
            }
        }

        public Task<String> hi( string fullName)
        {
            try
            {
                var client = new HttpClient();
                client.BaseAddress = new Uri(BASE_URL);
                client.DefaultRequestHeaders.Accept.Add(
                    new MediaTypeWithQualityHeaderValue("text/html"));
                HttpResponseMessage response = client.GetAsync(String.Format("hi/{0}",fullName)).Result;
                return response.Content.ReadAsStringAsync();
            }
            catch
            {
                return null;
            }
        }
    }
}