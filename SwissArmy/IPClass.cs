using Newtonsoft.Json.Linq;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace SwissArmy
{
    class IPClass
    {
        private static Dictionary<string, IPClass> ipList = new Dictionary<string, IPClass>();
        public string ip { get; set; }
        public string hostname { get; set; }
        public string city { get; set; }
        public string region { get; set; }
        public string country { get; set; }
        public string loc { get; set; }
        public string org { get; set; }
        public string postal { get; set; }

        public static IPClass Lookup(string ip)
        {
            try
            {
                string json = Core.DoRequest("http://ipinfo.io/" + ip + "/json");
                IPClass parsed = JsonConvert.DeserializeObject<IPClass>(json);
                ipList.Add(parsed.ip, parsed);
                return parsed;
            }
            catch
            {
                return null;
            }
        }
        public static IPClass GetCached(string ip)
        {
            if (ipList.ContainsKey(ip))
            {
                return ipList[ip];
            }
            return null;
        }
        public static Dictionary<string, IPClass> GetIPCach()
        {
            return ipList;
        }
    }
}