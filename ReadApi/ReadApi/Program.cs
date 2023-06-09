    using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Diagnostics;
using System.IO;
using Newtonsoft.Json.Linq;
using System.Net;
using System.Net.Http;

namespace ReadApi
{
    internal class Program
    {
        static string requestURL = "https://apis.data.go.kr/B553748/CertImgListService/getCertImgListService?ServiceKey=2i6XheyjgH%2BcezCZYg6pS5dJ0QXvD8OBZJKwG20hrN3E8EiuESAVG8QCWtNq9EzKtt9Sjv4JUMLZEGyM64OHoQ%3D%3D&returnType=JSON&prdlstNm=설화눈꽃팝김부각스낵   ";
        static void Main(string[] args)
        {
            WebRequest request = WebRequest.Create(requestURL);
            request.Method = "GET";
            request.ContentType = "application/json";

            using (WebResponse response = request.GetResponse())
            using (Stream stream = response.GetResponseStream())
            using (StreamReader reader = new StreamReader(stream))
            {
                string data = reader.ReadToEnd();
                var obj = JObject.Parse(data);
                var list = obj["list"];

                Console.WriteLine("============ List ============");
                //Console.WriteLine(obj);

                Console.WriteLine("============ Item ============");
                Console.WriteLine(list);
                //foreach (var item in list)
                //{
                //    Console.WriteLine(item);
                //}
            }
        }
    }
}
