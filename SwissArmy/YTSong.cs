using System.Diagnostics;

namespace SwissArmy
{
    class YTSong
    {
        public string title { get; set; }
        public string length { get; set; }
        public string link { get; set; }

        public void Download()
        {
            Process.Start(link);
        }
    }
}
