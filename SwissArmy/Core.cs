using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace SwissArmy
{
    public static class Core
    {
        #region Declatarion Stuff
        public static WebClient client = null;
        public static Form1 main;
        private static Dictionary<double, Thread> threadPool = new Dictionary<double, Thread>();
        private static ManualResetEvent syncEvent = new ManualResetEvent(false);
        #endregion
        public static void Init(Form1 frm)
        {
            main = frm;
        }
        public static Thread RunThread(Action methodName)
        {
            ManualResetEvent syncEvent = new ManualResetEvent(false);
            double unixMilli = (DateTime.UtcNow - new DateTime(1970, 1, 1)).TotalMilliseconds;
            Thread newThread = new Thread(
        () =>
        {
            syncEvent.Set();
            methodName();
            syncEvent.WaitOne();
            threadPool.Remove(unixMilli);
        }

    );
            if (threadPool.ContainsKey(unixMilli))
            {
                Thread.Sleep(5);
                threadPool.Add(unixMilli, newThread);
            }

            newThread.Start();
            return newThread;
        }
        public static void CloseAllThreads()
        {
            foreach (double key in threadPool.Keys)
            {
                threadPool[key].Abort();
            }
        }
        public static string DoCustomRequest(string url, string postData, string method = "GET")
        {
            var response = GetCustomResponse(url, postData, method);
            var responseString = new StreamReader(response.GetResponseStream()).ReadToEnd();

            return responseString;
        }

        public static HttpWebResponse GetCustomResponse(string url, string postData, string method = "GET")
        {
            ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
            var request = (HttpWebRequest)WebRequest.Create(url);
            request.Proxy = null;
            var data = Encoding.ASCII.GetBytes(postData);

            request.Method = method;
            request.ContentType = "application/x-www-form-urlencoded";
            request.ContentLength = data.Length;
            request.AllowAutoRedirect = true;

            using (var stream = request.GetRequestStream())
            {
                stream.Write(data, 0, data.Length);
            }

            var response = (HttpWebResponse)request.GetResponse();
            return response;
        }

        public static string DoRequest(string url)
        {
            try
            {
                HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
                request.Proxy = null;
                HttpWebResponse response = (HttpWebResponse)request.GetResponse();

                Stream receiveStream = response.GetResponseStream();
                StreamReader readStream = new StreamReader(receiveStream, Encoding.UTF8);


                string output = readStream.ReadToEnd();
                return output;
            }
            catch
            {
                return "";
            }
        }
        public static string GetLocationHeader(string url, CookieContainer con = null)
        {
            try
            {
                HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
                request.UserAgent = "Mozilla/5.0 (Windows NT 6.1; WOW64; rv:52.0) Gecko/20100101 Firefox/52.0";
                request.CookieContainer = con == null ? new CookieContainer() : con;
                request.AllowAutoRedirect = false;
                HttpWebResponse response = (HttpWebResponse)request.GetResponse();
                foreach (string header in response.Headers.Keys)
                {
                    if (header == "Location")
                    {
                        return response.Headers[header];
                    }
                }
                return "";
            }
            catch
            {
                return "";
            }
        }

        public static bool IsIP(string s)
        {
            IPAddress address;
            if (IPAddress.TryParse(s, out address))
            {
                switch (address.AddressFamily)
                {
                    case System.Net.Sockets.AddressFamily.InterNetwork:
                        return true;
                    case System.Net.Sockets.AddressFamily.InterNetworkV6:
                        return true;
                    default:
                        return false;
                }
            }
            return false;
        }
        public static string MD5Hash(string s)
        {
            byte[] bytes = Encoding.GetEncoding("iso-8859-1").GetBytes(s);
            byte[] numArray = (new MD5CryptoServiceProvider()).ComputeHash(bytes);
            string str = "";
            byte[] numArray1 = numArray;
            int num = 0;
            do
            {
                string str1 = Conversion.Hex(numArray1[num]);
                if ((str1.Length < 2))
                {
                    str1 = string.Concat("0", str1);
                }
                str = string.Concat(str, str1);
                num = num + 1;
            } while (num < Convert.ToInt32(numArray1.Length));
            return str;
        }
        public static string SHA1Hash(string s)
        {
            SHA1CryptoServiceProvider sh = new SHA1CryptoServiceProvider();
            sh.ComputeHash(ASCIIEncoding.ASCII.GetBytes(s));
            byte[] re = sh.Hash;
            StringBuilder sb = new StringBuilder();
            foreach (byte b in re)
            {
                sb.Append(b.ToString("X2"));
            }
            return sb.ToString();
        }
        public static string GenerateString(int len, bool numeric, bool lower, bool upper, List<string> customChrs = null)
        {
            if (!numeric && !lower && !upper && customChrs == null)
            {
                return "";
            }
            List<string> chrPool = new List<string>();
            Random rnd = new Random();
            StringBuilder builder = new StringBuilder();

            if (numeric)
            {
                chrPool.AddRange(Settings.NUMERIC);
            }
            if (lower)
            {
                chrPool.AddRange(Settings.LOWERALPHA);
            }
            if (upper)
            {
                chrPool.AddRange(Settings.UPPERALPHA);
            }
            if (customChrs != null)
            {
                chrPool.AddRange(customChrs);
            }


            for (int i = 0; i < len; i++)
            {
                builder.Append(chrPool[rnd.Next(0, chrPool.Count)]);
            }

            if (numeric && !StringBuilderContains(Settings.NUMERIC, builder))
            {
                int replaceIndex = rnd.Next(0, builder.Length);
                int replaceChr = rnd.Next(0, Settings.NUMERIC.Count);

                builder[replaceIndex] = Convert.ToChar(Settings.NUMERIC[replaceChr]);
            }


            if (lower && !StringBuilderContains(Settings.LOWERALPHA, builder))
            {
                int replaceIndex = rnd.Next(0, builder.Length);
                int replaceChr = rnd.Next(0, Settings.LOWERALPHA.Count);

                builder[replaceIndex] = Convert.ToChar(Settings.LOWERALPHA[replaceChr]);
            }


            if (upper && !StringBuilderContains(Settings.UPPERALPHA, builder))
            {
                int replaceIndex = rnd.Next(0, builder.Length);
                int replaceChr = rnd.Next(0, Settings.UPPERALPHA.Count);

                builder[replaceIndex] = Convert.ToChar(Settings.UPPERALPHA[replaceChr]);
            }


            if (customChrs != null && customChrs.Count > 0 && !StringBuilderContains(customChrs, builder))
            {
                int replaceIndex = rnd.Next(0, builder.Length);
                int replaceChr = rnd.Next(0, customChrs.Count);

                builder[replaceIndex] = Convert.ToChar(customChrs[replaceChr]);
            }


            string output = builder.ToString();
            return output;
        }
        private static bool StringBuilderContains(List<string> needleList, StringBuilder builder)
        {
            foreach (string needle in needleList)
            {
                foreach (char chr in builder.ToString())
                {
                    if (needle == chr.ToString())
                    {
                        return true;
                    }
                }
            }

            return false;
        }
        public static string StringBetween(string s1, string s2, string full)
        {
            string output = full.Split(new string[] { s1 }, StringSplitOptions.None)[1];
            output = output.Split(new string[] { s2 }, StringSplitOptions.None)[0];
            return output;
        }
        public static string GetUserinput(string title, string msg, string def = "")
        {
            string result = Microsoft.VisualBasic.Interaction.InputBox(msg, title, def);
            return result;
        }
    }
}
