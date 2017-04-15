using System;
using System.Windows.Forms;
using Newtonsoft.Json.Linq;
using System.Diagnostics;
using System.Net;
using System.ComponentModel;

namespace SwissArmy.Modules
{
    class SpotifyDownload
    {
        private static Stopwatch sw = new Stopwatch();
        private static long oldMs = 0;
        private SpotifyDownload() { }
        private static bool downloading = false;

        public static void Run(string s)
        {
            try
            {
                if (downloading)
                {
                    MessageBox.Show("Only one download at a time, please");
                    return;
                }
                downloading = true;
                string spotifyUrl = s.Contains("/") ? s.Split('/')[s.Split('/').Length - 1] : s;
                spotifyUrl = "https://api.spotify.com/v1/tracks/" + spotifyUrl;
                string spotifyResponse = Core.DoRequest(spotifyUrl);
                dynamic rawData = JObject.Parse(spotifyResponse);
                string songName = rawData.name.ToString();
                string query = songName;

                string artists = " ";
                foreach (dynamic artist in rawData.artists)
                {
                    artists += artist.name.ToString() + " ";
                }
                artists = artists.Remove(artists.Length - 1, 1);
                query += artists;
                string mp3Url = "http://mp3clan.com/mp3_source.php?q=" + query;
                string mp3Response = Core.DoRequest(mp3Url);

                string[] parsePartsBegin = mp3Response.Split(new string[] { "<a href=\"http://mp3clan.com/play.php?" }, StringSplitOptions.None);
                string[] parsePartsEnd = parsePartsBegin[1].Split(new string[] { "\" rel=\"nofollow\" onclick=\"" }, StringSplitOptions.None);
                string mp3Download = "http://mp3clan.com/play.php?" + parsePartsEnd[0];
                CookieContainer cookieCon = new CookieContainer();
                cookieCon.Add(new Cookie("download", "approved", "/", new Uri("http://mp3clan.com").Host));

                string mp3FileDownload = Core.GetLocationHeader(mp3Download, cookieCon);


                WebClient client = new WebClient()
                {
                    Proxy = null
                };

                client.DownloadFileCompleted += new AsyncCompletedEventHandler(DownloadComplete);
                client.DownloadProgressChanged += new DownloadProgressChangedEventHandler(DownloadProgress);
                sw.Start();
                client.DownloadFileAsync(new Uri(mp3FileDownload), Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\" + songName + "(" + artists + ").mp3");
            }
            catch
            {
                downloading = false;
                MessageBox.Show("Download not found, im sorry :(");
            }
        }
        private static void DownloadComplete(object sender, AsyncCompletedEventArgs e)
        {
            try
            {
                downloading = false;
                foreach (object item in Core.main.NotifyMenuStrip.Items)
                {
                    try
                    {
                        ToolStripMenuItem toolItm = (ToolStripMenuItem)item;
                        if (toolItm.Tag.ToString() == "SpotifyDownload")
                        {
                            toolItm.Dispose();
                            break;
                        }
                    }
                    catch { continue; }
                }
                MessageBox.Show("Download Complete");
            }
            catch { }
        }
        private static void DownloadProgress(object sender, DownloadProgressChangedEventArgs e)
        {
            try
            {
                long curMs = sw.ElapsedMilliseconds;
                if ((curMs - oldMs) < 1000)
                {
                    return;
                }
                oldMs = curMs;
                double bytesIn = double.Parse(e.BytesReceived.ToString());
                double totalBytes = double.Parse(e.TotalBytesToReceive.ToString());
                int percentage = (int)(bytesIn / totalBytes * 100);

                foreach (object item in Core.main.NotifyMenuStrip.Items)
                {
                    try
                    {
                        ToolStripMenuItem toolItm = (ToolStripMenuItem)item;
                        if (toolItm.Tag.ToString() == "SpotifyDownload")
                        {
                            toolItm.Text = "Spotify: " + percentage.ToString() + "%";
                            return;
                        }
                    }
                    catch { continue; }

                }

                Core.main.NotifyMenuStrip.Items.Add("Spotify: " + percentage.ToString() + "%").Tag = "SpotifyDownload";
            }
            catch { }
        }
    }
}
