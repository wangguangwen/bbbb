using log4net;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Messaging;
using System.Net.Http;
using System.Net.Http.Headers;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.Security.Cryptography.X509Certificates;
using System.Security.Cryptography;
using System.Web.Security;
using System.Threading;
using System.Net;
using System.IO;
using Microsoft.TeamFoundation.Client;
using Microsoft.TeamFoundation.WorkItemTracking.Client;
using System.Collections.ObjectModel;
using Microsoft.TeamFoundation.Framework.Common;
using Microsoft.TeamFoundation.Framework.Client;
using System.Linq.Expressions;
using System.ServiceModel.Routing;
using System.ServiceModel;
using Hello.Contract;
using System.Collections;

namespace ConsoleApplication1
{
    public class AClass
    {
        public void Run()
        {
            while (true)
            {
                Console.Read();
                try
                {

                    int a = 0;
                    int b = 1;
                    int c = b / a;
                }
                catch (Exception ex)
                {
                    Program._Log.Error(ex.Message);
                }
            }
        }
    }
    class Program
    {
        public static readonly ILog _Log = LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        private static string GetGeneralContent(string strUrl)
        {
            string strMsg = string.Empty;
            try
            {
                WebRequest request = WebRequest.Create("http://tfsapp:8080/tfs/OnlyEduCollection/%E6%8E%88%E6%9D%83%E7%AE%A1%E7%90%86_RLS/_dashboards");
                request.Credentials = new NetworkCredential("wangguangwen", "Onlyedu2016");
                WebResponse response = request.GetResponse();
                StreamReader reader = new StreamReader(response.GetResponseStream(), Encoding.GetEncoding("gb2312"));

                strMsg = reader.ReadToEnd();

                reader.Close();
                reader.Dispose();
                response.Close();
            }
            catch(Exception ex)
            {

            }
            return strMsg;
        }


        public enum VVV:int
        {
            test=1

        }
        public class Taw
        {
           
            public async void Add(int i)
            {
               
                    await dddd(i);
                
            }
            public Task dddd(int i)
            {
              return  Task.Run(() => {
                  while (true)
                  {
                      Thread.Sleep(1000);
                      Console.WriteLine(i);
                  }
              });
            }
        }

        public class Bis
        {
            public IEnumerable<int> Test() {

                yield return 1;
                yield return 2;

            }
         
        }
        public class Cat
        {

            public delegate void Crying(object ogb,EventArgs e);
            public event Crying OnCry;
            public void Start()
            {
                Console.WriteLine("cat cring");
                if (OnCry != null)
                {
                    EventArgs e = new EventArgs();
                    OnCry(this, e);
                }

            }
            
        }
        public class Mouse {

            public delegate void Run(object sender, EventArgs e);
            public delegate void Runsss(string sender, string e);
            public event Run OnRun;
            public Mouse(Cat cat)
            {
               // Delegate.
                Runsss d = new Runsss(bbb);
                d.BeginInvoke("", "", dd, "ddddd");
                cat.OnCry += Cat_OnCry;
                throw new Exception("test oam");
            }
             void dd(IAsyncResult f) {
                
                return ;
            }
            public  void bbb(string sender, string e){
                Console.WriteLine("bbb begin run");
            }
     
            public void BeginRun()
            {
                Console.WriteLine("mouse begin run");
                if (OnRun != null)
                {
                    OnRun(null,null);
                }
            }

            private void Cat_OnCry(object ogb, EventArgs e)
            {
                BeginRun();
            }
        }
        public class Person
        {
            public Person(Mouse m)
            {
                m.OnRun += M_OnRun;
            }
            public void weekUp()
            {
                Console.WriteLine("week up");
            }
            private void M_OnRun(object sender, EventArgs e)
            {
                weekUp();
            }
        }

        static void tt(int [] arr)
        {
            arr[0] = 100;
        }
        public struct AAA
        {
            public string Name { get; set; }
        }
        static void Main(string[] args)
        {


          string dd=  Get("http://rls.qaline.com/issue/wsfed?wa=wsignin1.0&wtrealm=http%3a%2f%2fehs.qaline.com%2f&wctx=rm%3d0%26id%3dpassive%26ru%3d%252fHome%252fFirstPage&wct=2017-06-26T08%3a49%3a05Z");
            Console.WriteLine(dd);
            Console.Read();
            int a1 = 1;
            int b1 = 1;
            
            if (object.Equals(a1,b1))
            {
                Console.WriteLine("true");
            }



         

      
            Console.Read();

            Cat c = new Cat();
            Mouse m = new Mouse(c);
            Person p = new Person(m);
            c.Start();


            Console.Read();

            Bis b = new Bis();
         int a =   b.Test().GetEnumerator().Current;
            foreach (var i in b.Test())
            {
                Console.WriteLine(i);
            }
        //    b.Test();


            Console.Read();


            //var v = new { userMail = "wangguangwen@onlyedu.com" };
            //var vs=   Newtonsoft.Json.JsonConvert.SerializeObject(v);
            //HttpContent httpContent = new StringContent(vs);
            //httpContent.Headers.ContentType = new MediaTypeHeaderValue("application/json");
            //var httpClient = new HttpClient();
            //var responseJson = httpClient.PostAsync("http://icm.local.com/Coremail/ValidateMailExist", httpContent)
            //.Result.Content.ReadAsStringAsync().Result;
           


            //  Byte[] plainTextByte = Encoding.UTF8.GetBytes("");
            //  X509Certificate2 myX509Certificate2 = new X509Certificate2(@"D:\ddd.pfx", "123456");
            //  //从证书中获得含私钥的RSACryptoServiceProvider
            //  RSACryptoServiceProvider myRSACryptoServiceProvider = (RSACryptoServiceProvider)myX509Certificate2.PrivateKey;
            //  //使用RSACryptoServiceProvider把密文字节流解密为明文字节流
            //  string ll = "77u/PD94bWwgdmVyc2lvbj0iMS4wIiBlbmNvZGluZz0idXRmLTgiPz48U2VjdXJpdHlDb250ZXh0VG9rZW4gcDE6SWQ9Il8yOGJjZDMzZS0xNDhhLTRhNjctOGU3Ni0wY2YwODNiYWEyOGItQTQ4NjFGRjJCMTBCNDc0MTM4MjRERTNBMDlFRjRGRDYiIHhtbG5zOnAxPSJodHRwOi8vZG9jcy5vYXNpcy1vcGVuLm9yZy93c3MvMjAwNC8wMS9vYXNpcy0yMDA0MDEtd3NzLXdzc2VjdXJpdHktdXRpbGl0eS0xLjAueHNkIiB4bWxucz0iaHR0cDovL2RvY3Mub2FzaXMtb3Blbi5vcmcvd3Mtc3gvd3Mtc2VjdXJlY29udmVyc2F0aW9uLzIwMDUxMiI+PElkZW50aWZpZXI+dXJuOnV1aWQ6MDQ5NjRhODEtYzJjYy00NWJkLWJhNjctOTFkNTkyZTEwZjZlPC9JZGVudGlmaWVyPjxDb29raWUgeG1sbnM9Imh0dHA6Ly9zY2hlbWFzLm1pY3Jvc29mdC5jb20vd3MvMjAwNi8wNS9zZWN1cml0eSI+QVFBQUFOQ01uZDhCRmRFUmpIb0F3RS9DbCtzQkFBQUFXT1pwV0oyeXNrRytpL2dBb2txYVB3QUFBQUFDQUFBQUFBQURaZ0FBd0FBQUFCQUFBQUJiT3Y0dk1RNXc0ek90VE8xQUM4QkJBQUFBQUFTQUFBQ2dBQUFBRUFBQUFOMzJjdGNBK0p5Tnh4dkZMSVF2UU1ib0JBQUEvZ3p6eGU2ZWI2T2FudHA1N01mNEhaZEd4VVpCa3k1eWpTUy9jRXRUWmRwOCtIWDhiWlZGVXVjVTNOUC9nTzJsU1h2OFpkYTVLbkpXaTJGSTRVSGVETjlJTjd4cXF5OERoWTF3Ukw1ajhPdzM2ejhtaW53SE95TzBsRklXR203MEg2YW80bFVhTkQ2VXVwKzZsN0M2cytZV0lPZTROK1ovTUJWNXh2SDdLRzl2TUszYUJrMHZrTEsxdk5MdVZ3ckpPS1Nob2F3alRuemt2NWlGYi9QSU5GekhqMVFVaU9nUXU5bjl3WWlNem9FbU1mQ3FQVy9JZnc5WkRLT2VzTkJTR0E0ckRyeGlTZXJQamJWUmJYL2tFVnBEVC95dUhvWUtKakMwTFdqWDU2VjFnamcxd1hISnRUSGx0Y1BnRFlhSTd1dWVEU2I5amhEVUZDNkk2bGZ3QXFiT1BGRlBrV25MMkI4QktwWnNSSzBiU1FYNGVrZzg3NDlkSVp4U0FLUFZUcnBSOC9lOXhNVC8zL1dZUzNPY09mZ3RRUThNSERObjhHRTZzblArTWJPWjVxN0pnbVUva3FvbjNHVXZZdEV0ZUdjOWtNbVpqOGhUNUpzeG1QbHJ0S2J0dDM3ZzFBa3JOOXAvNjRGSEgxRXgrRVdHaTBsQjcrOWtvTHZwVENBNDV5SW1oYmV5aU4vSlZqdGxDTmx5Qks1c2NhRHM5MFlDeFBpUHF3bDRndTZQV0c4cUwxZjlPV0NTSmQ3ZzFnZDhwbzlMOXduSGtrV3psdHNBdHJnMlRQUXJQMFdyRzNXckNsTStRZnlmRTVjd3dtZkJlUE0vSjBGWlEyTDhtZDJYejg4SDJSLzZyeU1US09UUzVNMS9qMExQMGtUdzBhKzVlL2diandncjNhZXRsa1F4cUthNmV1NmsyS1puWjFrVHlKMkM4NllaQ0pacDkvUG16c29pcnlEU1lmNjY2Vlkra0puUEw1ZFZxcENpYU9HVjdkNWp6bHdoVXlUNFpyUDQzeGVDUjNvejRYZVp5SW95Y3VXZEVWaThOSEVETWh5ZStZNTBITEZuOG12Wm1yY296YWs5RTFEUEZuQWdvS21hamc1MXVDL0ZWYnlnZHorSkM4Yk1JYnhsaUFaWE95Y2ZWejJLRGY0VFQyelFOa0xqRlZpcnBNRnphOG5iSmVaclk5d1VYRDNjQTV1";

            //var bp=  FormsAuthentication.Decrypt(ll);

            //  string bb = "bVdreUdNOEh1bWE3NjVHeGNnVU5MVVVYaHR4RDk2S1VSV3JmUDhGanBENzR2RGk1VUNUai9xVU1adWVJbTdwTFM2eUhaVVhnOEQ4WThtMGV6UlRGemU5TXpYWGZsRER0NEFiYXdBaGRDSHRBdXdTUG9heFZJNlFFdzN1Qll4a3VPSHFYelprRmxEci9aaHBGVjh3cDZtamFSbElhNDJVYUZQOVdpSWRYdTZ5bFcyMEc2Yms2ZGRvMWJ1bXFmTDZSWE1SSzdHSmsrMGhQbnhtTVpaVnc3MURPdjJuYzNMVjYzZ055RmE3bFVCcUZXMzFxYVFtTlBnOWJEanBzMGNZb1RMV1o4Sk4xbXVibEtyaHZNUHdDUStTeWw4WWhyaW9FY1hxL3pHbHhzR2l0dSs2c1IvQjJjVm05cHR6ZW9MREtaVUtzWGU0WjNxbXhpQW8za0Zwem9FL0hFTW5FK0Z3ampzVDVXbW9rUWkxRGoyU0NPMUVRUm5Ga2pkNVlYL01LUkNEWkNsZVBiLzVJWVVCakN5KzJMMlVVVUU4NVphelUxS0RkTXFDT1cwcjRmelB4WWVQSDRNSU52ZmpzWnRRbVY4WUVoeUdxL3Y2bXBEUHpDd3ZjekdLK3VLcmpSZW1IRVVIQ1dqSElUcGNFTTBBeCs2S3ZweU0zMTlLa2tXb2E5bDBrTEI0aW1uMlNVYUhzWUtLekp5UGpTSUlsMkxMRlJndnkwMFJ4dmR1VGNOdGJzMFo3UitiWWoxSFhhTFBpRkJMb1ZtOUljTGQ3MEsvbHV2MTFDYjNvcVRXZEN1Snd1a2grd3EzMXBGOUdUeTh1U3NLTCtrK3lwT05sSnc3RVRUL1FmSWcxbUxXWU43ZEJQMkR3eTRlTUZNa3FlRXcrWW1GN2lyVEgwanRiVGw4bkVSNGphbFVmWmFWTjVWN01JaVo2MHl1d2lhaXYySnp5RmlRRXhPcEVnN01nWGpVMVROeEdOQWhiaGdSWnVnVkZyb09xbVJyVzNYWko4M2lFVUFBQUFTY3BBTkh4MDFoeHUzWS9hUitvNXpxRUtoWVk9PC9Db29raWU";
            //  string v = "AQAAANCMnd8BFdERjHoAwE/Cl+sBAAAAWOZpWJ2yskG+i/gAokqaPwAAAAACAAAAAAADZgAAwAAAABAAAABbOv4vMQ5w4zOtTO1AC8BBAAAAAASAAACgAAAAEAAAAN32ctcA+JyNxxvFLIQvQMboBAAA/gzzxe6eb6Oantp57Mf4HZdGxUZBky5yjSS/cEtTZdp8+HX8bZVFUucU3NP/gO2lSXv8Zda5KnJWi2FI4UHeDN9IN7xqqy8DhY1wRL5j8Ow36z8minwHOyO0lFIWGm70H6ao4lUaND6Uup+6l7C6s+YWIOe4N+Z/MBV5xvH7KG9vMK3aBk0vkLK1vNLuVwrJOKShoawjTnzkv5iFb/PINFzHj1QUiOgQu9n9wYiMzoEmMfCqPW/Ifw9ZDKOesNBSGA4rDrxiSerPjbVRbX/kEVpDT/yuHoYKJjC0LWjX56V1gjg1wXHJtTHltcPgDYaI7uueDSb9jhDUFC6I6lfwAqbOPFFPkWnL2B8BKpZsRK0bSQX4ekg8749dIZxSAKPVTrpR8/e9xMT/3/WYS3OcOfgtQQ8MHDNn8GE6snP+MbOZ5q7JgmU/kqon3GUvYtEteGc9kMmZj8hT5JsxmPlrtKbtt37g1AkrN9p/64FHH1Ex+EWGi0lB7+9koLvpTCA45yImhbeyiN/JVjtlCNlyBK5scaDs90YCxPiPqwl4gu6PWG8qL1f9OWCSJd7g1gd8po9L9wnHkkWzltsAtrg2TPQrP0WrG3WrClM+QfyfE5cwwmfBePM/J0FZQ2L8md2Xz88H2R/6ryMTKOTS5M1/j0LP0kTw0a+5e/gbjwgr3aetlkQxqKa6eu6k2KZnZ1kTyJ2C86YZCJZp9/PmzsoiryDSYf666VY+kJnPL5dVqpCiaOGV7d5jzlwhUyT4ZrP43xeCR3oz4XeZyIoycuWdEVi8NHEDMhye+Y50HLFn8mvZmrcozak9E1DPFnAgoKmajg51uC/FVbygdz+JC8bMIbxliAZXOycfVz2KDf4TT2zQNkLjFVirpMFza8nbJeZrY9wUXD3cA5u";
            //  var Cryptograph= Encoding.UTF8.GetBytes(ll);
            //  string a = "aaaabbbbccccdddd";
            // // byte[] bytes = Convert.FromBase64String(v);
            // // string jsonToken = Encoding.UTF8.GetString(bytes);
            //  var b =  myRSACryptoServiceProvider.Encrypt(Encoding.UTF8.GetBytes(ll),false);

            //  string a1 = Encoding.UTF8.GetString(b);

            //  byte[] plaintextByte = myRSACryptoServiceProvider.Decrypt(b, false);

            //  string Plaintext = Encoding.Unicode.GetString(plaintextByte);

            var t = new
            {
                ClientId = "OnlyEduZLF",
                Secret = "4c3f9a6ea6629d2b71ae73ee938df188"

            };
            string req = Newtonsoft.Json.JsonConvert.SerializeObject(t);
            var token = Get("https://localhost:4436/api/Test/GetV?id=1&sex=ddd");
            Console.WriteLine(token);
            Console.Read();
            var obj = JsonConvert.DeserializeObject<token>(token);
            var o = new { Access_Token = obj.Access_Token, AppId = 1, ClientId = "OnlyEduZLF" };
            var bbb = Post("http://sso1.onlyedu.com.cn/OnlyEduAuthorize/AuthorizeToken", Newtonsoft.Json.JsonConvert.SerializeObject(o));
            Console.Read();
            Console.Read();


        }
        public class token
        {
            public string Access_Token { get; set; }
            public int Expires_In { get; set; }
            public bool IsSuccess { get; set; }
            public ErrorInfo ErrorInfo { get; set; }

        }
        public class ErrorInfo
        {
            public int ErrorCode { get; set; }
            public string ErrorMessage { get; set; }
        }


        public static string Post(string Url, string data)
        {

            HttpContent httpContent = new StringContent(data);
            var httpClient = new HttpClient();
            httpContent.Headers.ContentType = new MediaTypeHeaderValue("application/json");
            var responseJson = httpClient.PostAsync(Url, httpContent)
            .Result.Content.ReadAsStringAsync().Result;
            return responseJson;


        }
        public static string Get(string Url)
        {

          //  HttpContent httpContent = new StringContent(data);
            var httpClient = new HttpClient();
           // httpContent.Headers.ContentType = new MediaTypeHeaderValue("application/json");
            var responseJson = httpClient.GetAsync(Url)
            .Result.Content.ReadAsStringAsync().Result;
            return responseJson;


        }

        private static void L_EntryWritten(object sender, EntryWrittenEventArgs e)
        {

        }

        private static void Log_EntryWritten(object sender, EntryWrittenEventArgs e)
        {
            //throw new NotImplementedException();
        }
    }
}
