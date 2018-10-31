using System.Diagnostics;

namespace SwissArmy.Modules
{
    public class Speedtest
    {
        public static void Run()
        {
            Process.Start("http://www.speedtest.net/");
        }
    }
}