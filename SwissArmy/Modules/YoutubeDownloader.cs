using Newtonsoft.Json;
using System;
using System.Windows.Forms;

namespace SwissArmy.Modules
{
    public class YoutubeDownloader
    {
        private YoutubeDownloader() { }
        public static void Run(string term)
        {
            if (term.Contains("?v="))
            {
                term = term.Split(new string[] { "?v=" }, StringSplitOptions.None)[1];
            }
            if (term.Trim() != "")
            {
                string json = Core.DoRequest("http://www.youtubeinmp3.com/fetch/?format=json&video=http://www.youtube.com/watch?v=" + term);
                try
                {
                    YTSong song = JsonConvert.DeserializeObject<YTSong>(json);
                    song.Download();
                }
                catch
                {
                    try
                    {
                        string url = Core.StringBetween("url=", @"""/>", json);
                        string resp2 = Core.DoRequest(url);

                        string triggerUrl = "http://www.youtubeinmp3.com" + Core.StringBetween(@"id=""download"" href=""", @"""><i class=", resp2);
                        MessageBox.Show("Please wait... your download will be starting soon");
                        Core.DoRequest(triggerUrl);


                        json = Core.DoRequest("http://www.youtubeinmp3.com/fetch/?format=json&video=http://www.youtube.com/watch?v=" + term);
                        YTSong song = JsonConvert.DeserializeObject<YTSong>(json);
                        song.Download();
                    }
                    catch
                    {
                        MessageBox.Show("Not found");
                    }
                }
            }
        }
    }
}
