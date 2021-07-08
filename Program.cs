using System;
using System.Net.Http;
using System.Text;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            double time = 1625589550000;
            var dateTime2 = DateTimeOffset.FromUnixTimeSeconds(1625589550000 / 1000).DateTime;
            var dateTime3 = DateTimeOffset.FromUnixTimeSeconds(1625589550000 / 1000).LocalDateTime;
            var  dateTime4 = new DateTime(1970, 1, 1, 0, 0, 0, 0).AddSeconds(1625589550000 / 1000).ToLocalTime();
          // Unix time in microseconds.
            double epoch = time; //this microseconds 
            epoch /= 1000; // convert to milliseconds by divide 1000  
            Console.WriteLine(epoch2string(epoch));

            Console.WriteLine(dateTime2);
            Console.WriteLine(dateTime3);
            Console.WriteLine(dateTime4);
            var dt = new DateTime(1970, 1, 1, 0, 0, 0, 0).AddSeconds(Math.Round(1625589550000 / 1000d)).ToLocalTime();
            Console.WriteLine(dt);
            Console.WriteLine(dt.ToShortDateString() + "" + dt.ToShortTimeString() );
            //   JenkinTesting();

            //Sonar
            // Sonar.GetSonarIssues();
            //Sonar.GetQualityGate();
            // Sonar.GetBugs();
            //Sonar.GetCoverage();

            //GetSonarIssues();
            //  GetQualityGate();
            // return Ok(responseString);
            //TestHistory();
            Console.ReadLine();
            Console.WriteLine("Hello World!");


            //Jenkin
           // GetBuildStatus();

        }
        private static string epoch2string(double epoch)
        {
            DateTime dateTime = new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc).AddSeconds(epoch);
            return dateTime.ToShortDateString() + " " + dateTime.ToShortTimeString();
        }

        private static void JenkinTesting()
        {


            string url = "http://73.147.133.253:8080/api/json?tree=jobs[name,url]";
            HttpClient client = new HttpClient();
            var byteArray = Encoding.ASCII.GetBytes("jenkins:113340cb1b573f720814aa78fb88ae4803");
            client.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Basic", Convert.ToBase64String(byteArray));
            string responseString = string.Empty;
            var response = client.GetAsync(url).Result;
            if (response.IsSuccessStatusCode)
            {
                var responseContent = response.Content;
                responseString = responseContent.ReadAsStringAsync().Result;
            }


        }

        private static void SonarTesting()
        {


            string url = "https://sonarcloud.io/api/components/search_projects?organization=dev-group-zhive&token=197416a9f8f9864a8ceff787bd47e7fec157808e&ps=500";
            HttpClient client = new HttpClient();
            string responseString = string.Empty;
            var response = client.GetAsync(url).Result;
            if (response.IsSuccessStatusCode)
            {
                var responseContent = response.Content;
                responseString = responseContent.ReadAsStringAsync().Result;
            }


        }



        private static void GetBuildStatus()
        {


     
            string url = "http://73.147.133.253:8080/job/zHive-Multi-Branch-Pipeline/job/master/lastBuild/api/json";
                HttpClient client = new HttpClient();
                var byteArray = Encoding.ASCII.GetBytes("jenkins:113340cb1b573f720814aa78fb88ae4803");
                  client.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Basic", Convert.ToBase64String(byteArray));
               //client.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", Convert.ToBase64String(byteArray));
                string responseString = string.Empty;
                var response = client.PostAsync(url, null).Result;
                if (response.IsSuccessStatusCode)
                {
                    var responseContent = response.Content;
                    responseString =  responseContent.ReadAsStringAsync().Result;
                }
               
            
        }
        private static void GetQualityGate()
        {

            //string url = "http://localhost:9000/api/project_badges/quality_gate?project=sonar-scanner";
            string url = "https://sonarcloud.io/api/project_badges/measure?project=dev-group-zhive_zhive&metric=alert_status&token=197416a9f8f9864a8ceff787bd47e7fec157808e";//  "https://sonarcloud.io/api/project_badges/quality_gate?project=dev-group-zhive_zhive";
            HttpClient client = new HttpClient();
          //  var byteArray = Encoding.ASCII.GetBytes("c25f1fcc6f666af4c1956ad75a1fc953f6a14c1a");// rathinam@zilliontechnologies:Sadhana@2014");// df6d6f8a441dfee7cf78827669266e4f525bc4a6");
           // client.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("token", "Bearer 197416a9f8f9864a8ceff787bd47e7fec157808e");// Convert.ToBase64String(byteArray));
            string responseString = string.Empty;
            var response = client.PostAsync(url, null).Result;
            if (response.IsSuccessStatusCode)
            {
                var responseContent = response.Content;
                responseString = responseContent.ReadAsStringAsync().Result;
            }
        }

        //Issues 

       
        private static void TestHistory()
        {
                        string url = "http://localhost:8080/job/dashdemoJenkinTest/17/testReport/UnitTestProject/history/";
            HttpClient client = new HttpClient();
            var byteArray = Encoding.ASCII.GetBytes("rathinam:114901cf8678b5ce60c2d8f3e762f1815c");// df6d6f8a441dfee7cf78827669266e4f525bc4a6");
            client.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Basic", Convert.ToBase64String(byteArray));
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
