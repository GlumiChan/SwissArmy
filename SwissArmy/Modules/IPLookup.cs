using System;
using System.Windows.Forms;

namespace SwissArmy.Modules
{
    class IPLookup
    {
        private IPLookup() { }
        public static void Run(string ip)
        {
            IPClass lookupIP = IPClass.Lookup(ip);

            if (lookupIP == null)
            {
                MessageBox.Show("Not found");
                return;
            }

            MessageBox.Show(String.Format("ISP: {0}\n\n\n{1} ({2}) ({3})", lookupIP.hostname, lookupIP.city, lookupIP.region, lookupIP.country));
        }
    }
}
