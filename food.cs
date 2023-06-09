using Newtonsoft.Json.Linq;
using System;
using System.IO;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;

namespace vmpoStudy01
{
    class Program
    {

        static string targetURL = "http://apis.data.go.kr/B553748/CertImgListService/getCertImgListService?ServiceKey=";
        

        static void Main(string[] args)
        {
               
            //1.WebClient 클래스 활용
            string webClientResult = callWebClient();

            var r = JObject.Parse(webClientResult);
            
            var list = r["list"];

            Console.WriteLine(r);
            foreach (var o in list)
            {
                Console.WriteLine(string.Format("{0} : {1}", "날짜"               , o["sdate"]));
                Console.WriteLine(string.Format("{0} : {1}", "전국교통량"         , o["cjunkook"]));
                Console.WriteLine(string.Format("{0} : {1}", "지방교통량"         , o["cjibangDir"]));
                Console.WriteLine(string.Format("{0} : {1}", "서울->대전 소요시간" , o["csudj"]));
                Console.WriteLine(string.Format("{0} : {1}", "서울->대구 소요시간" , o["csudg"]));
                Console.WriteLine(string.Format("{0} : {1}", "서울->울산 소요시간" , o["csuus"]));
            }

            Console.WriteLine("*************************************************************");

            string wbRequestResult = callWebRequest();

            var r2 = JObject.Parse(webClientResult);

            var list2 = r["list"];

            Console.WriteLine(r2);
            foreach (var o in list2)
            {
                Console.WriteLine(string.Format("{0} : {1}", "날짜", o["sdate"]));
                Console.WriteLine(string.Format("{0} : {1}", "전국교통량", o["cjunkook"]));
                Console.WriteLine(string.Format("{0} : {1}", "지방교통량", o["cjibangDir"]));
                Console.WriteLine(string.Format("{0} : {1}", "대전->서울 버스 소요시간", o["cdjsu_bus"]));
                Console.WriteLine(string.Format("{0} : {1}", "대구->서울 버스 소요시간", o["cdgsu_bus"]));
                Console.WriteLine(string.Format("{0} : {1}", "울산->서울 버스 소요시간", o["cussu_bus"]));
            }


        }


        public static string callWebClient()
        {
            string result = string.Empty;
            try
            {
                WebClient client = new WebClient();

                //특정 요청 헤더값을 추가해준다. 
                client.Headers.Add("user-agent", "Mozilla/4.0 (compatible; MSIE 6.0; Windows NT 5.2; .NET CLR 1.0.3705;)");

                using (Stream data = client.OpenRead(targetURL))
                {
                    using (StreamReader reader = new StreamReader(data))
                    {
                        string s = reader.ReadToEnd();
                        result = s;

                        reader.Close();
                        data.Close();
                    }
                }

            }
            catch (Exception e)
            {
                //통신 실패시 처리로직
                Console.WriteLine(e.ToString());
            }
            return result;
        }


        public static string callWebRequest()
        {
            string responseFromServer = string.Empty;

            try
            {

                WebRequest request = WebRequest.Create(targetURL);
                request.Method = "GET";
                request.ContentType = "application/json";

                using (WebResponse response = request.GetResponse())
                using (Stream dataStream = response.GetResponseStream())
                using (StreamReader reader = new StreamReader(dataStream))
                {
                    responseFromServer = reader.ReadToEnd();
                }

            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }

            return responseFromServer;
        }

    }
}