using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;

namespace ConsoleApp1
{
    public static class Sonar
    {


        public static void GetAllIssues(string url)
        {
            HttpClient client = new HttpClient();
            var byteArray = Encoding.ASCII.GetBytes("rathinam@zilliontechnologies:Sadhana@2014");// df6d6f8a441dfee7cf78827669266e4f525bc4a6");
            client.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Basic", Convert.ToBase64String(byteArray));
            string responseString = string.Empty;
            var response = client.PostAsync(url, null).Result;
            if (response.IsSuccessStatusCode)
            {
                var responseContent = response.Content;
                responseString = responseContent.ReadAsStringAsync().Result;
            }
        }

        public  static void GetSonarIssues()
        {


            string url = "https://sonarcloud.io/api/issues/search?project=dev-group-zhive_zhive&organization=dev-group-zhive";
            HttpClient client = new HttpClient();
            var byteArray = Encoding.ASCII.GetBytes("ab9fcfdbb5b89d6643bdf23ab33f447aa2b5cf93:");
            client.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Basic", Convert.ToBase64String(byteArray));
            string responseString = string.Empty;
            var response = client.PostAsync(url, null).Result;
            if (response.IsSuccessStatusCode)
            {
                var responseContent = response.Content;
                responseString = responseContent.ReadAsStringAsync().Result;
            }
        }

        public static void GetQualityGate()
        {
            string url = "https://sonarcloud.io/api/project_badges/measure?project=dev-group-zhive_zhive&metric=alert_status&token=197416a9f8f9864a8ceff787bd47e7fec157808e";
            HttpClient client = new HttpClient();
            string responseString = string.Empty;
            var response = client.PostAsync(url, null).Result;
            if (response.IsSuccessStatusCode)
            {
                var responseContent = response.Content;
                responseString = responseContent.ReadAsStringAsync().Result;
            }
        }


        public static void GetBugs()
        {
            string url = "https://sonarcloud.io/api/project_badges/measure?project=dev-group-zhive_zhive&metric=bugs&token=197416a9f8f9864a8ceff787bd47e7fec157808e";
            HttpClient client = new HttpClient();
            string responseString = string.Empty;
            var response = client.PostAsync(url, null).Result;
            if (response.IsSuccessStatusCode)
            {
                var responseContent = response.Content;
                responseString = responseContent.ReadAsStringAsync().Result;
            }
        }

        public static void GetSmells()
        {
            string url = "https://sonarcloud.io/api/project_badges/measure?project=dev-group-zhive_zhive&metric=code_smells&token=197416a9f8f9864a8ceff787bd47e7fec157808e";
            HttpClient client = new HttpClient();
            string responseString = string.Empty;
            var response = client.PostAsync(url, null).Result;
            if (response.IsSuccessStatusCode)
            {
                var responseContent = response.Content;
                responseString = responseContent.ReadAsStringAsync().Result;
            }
        }


        public static void GetCoverage()
        {
            string url = "https://sonarcloud.io/api/issues/search?project=dev-group-zhive_zhive&organization=dev-group-zhive&types=BUG&token=197416a9f8f9864a8ceff787bd47e7fec157808e";
            HttpClient client = new HttpClient();
            string responseString = string.Empty;
            var response = client.PostAsync(url, null).Result;
            if (response.IsSuccessStatusCode)
            {
                var responseContent = response.Content;
                responseString = responseContent.ReadAsStringAsync().Result;
            }
        }


     
    } 
}



