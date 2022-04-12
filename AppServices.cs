using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Net;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using Microsoft.VisualBasic.CompilerServices;
using Newtonsoft.Json;
namespace qtellq
{
    public class AppServices
    {
        Configuration aconfig;

        private static HttpClient client = new HttpClient();

        public AppServices()
        {
            aconfig = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
        }

        public String getCounter(String counter)
        {
            return ConfigurationManager.AppSettings[counter];

        }

        public async  Task<string> getGeneralFLow()
        {
            client.BaseAddress = new Uri("http://10.0.34.37:3333/");
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/json"));

            HttpResponseMessage response = await client.GetAsync("qtel/general");
            if (response.IsSuccessStatusCode)
            {
                return response.ToString();
            }
            else
            {
                Console.WriteLine("Internal server Error");
            }

            return null;
        }

        public async Task<String> ActionQtel(String action)
        {
            
            var qpay = new Qdata();
            qpay.service = ConfigurationManager.AppSettings["service"];
            qpay.counter = ConfigurationManager.AppSettings["counter"];
            qpay.number = "";
            qpay.txid = action;

            var json = JsonConvert.SerializeObject(qpay);
            var data = new StringContent(json, Encoding.UTF8, "application/json");

            var url = "http://10.0.34.37:3333/qtel";
            using var client = new HttpClient();

            var response = await client.PostAsync(url, data);

            //string result = response.Content.ReadAsStringAsync().Result;
            response.EnsureSuccessStatusCode();
            //var contentStream = await response.Content.ReadAsStreamAsync();

            //using var streamReader = new StreamReader(contentStream);
            //using var jsonReader = new JsonTextReader(streamReader);

            //JsonSerializer serializer = new JsonSerializer();

            //try
            //{
            //    return serializer.Deserialize<Qdata>(jsonReader);
            //}
            //catch (JsonReaderException)
            //{
            //    Console.WriteLine("Invalid JSON.");
            //}
            using (HttpContent con = response.Content)
            {
                string dt = await con.ReadAsStringAsync();
                if (dt != null)
                {
                    return dt;
                }
            }



            return String.Empty;
        }

        public async Task<string> getGeneral()
        {
            var url = "http://10.0.34.37:3333/qtel/general";
            using var client = new HttpClient();
            try
            {
                var response = await client.GetAsync(url);

                response.EnsureSuccessStatusCode();
                using (HttpContent con = response.Content)
                {
                    string dt = await con.ReadAsStringAsync();
                    if (dt != null)
                    {
                        return dt;
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
            return  String.Empty;
        }


        public async Task<string> getQflowl()
        {
            var url = "http://10.0.34.37:3333/qtel/flow";
            using var client = new HttpClient();

            var response = await client.GetAsync(url);

            response.EnsureSuccessStatusCode();
            using (HttpContent con = response.Content)
            {
                string dt = await con.ReadAsStringAsync();
                if (dt != null)
                {
                    return dt;
                }
            }
            return String.Empty;
        }


        public async Task<string> getSevWaiting()
        {
            var url = "http://10.0.34.37:3333/qtel/services";
            using var client = new HttpClient();

            var response = await client.GetAsync(url);

            response.EnsureSuccessStatusCode();
            using (HttpContent con = response.Content)
            {
                string dt = await con.ReadAsStringAsync();
                if (dt != null)
                {
                    return dt;
                }
            }
            return String.Empty;
        }
    }

    public class Qdata
    {
        public string service { get; set; }
        public string counter { get; set; }
        public string number { get; set; }
        public string txid { get; set; }

        public override string ToString()
        {
            return $"{number}: {number}";
        }
    }
}
