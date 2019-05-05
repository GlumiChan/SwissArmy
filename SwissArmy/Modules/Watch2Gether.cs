using System.Windows.Forms;

namespace SwissArmy.Modules
{
    public class Watch2Gether
    {
        public static void Run()
        {
            try
            {
                var resp = Core.GetCustomResponse("https://www.watch2gether.com/rooms/create", "utf8=✓", "POST");

                string room = resp.ResponseUri.AbsoluteUri;
                Clipboard.SetText(room);
                System.Diagnostics.Process.Start(room);
            }
            catch
            {
                MessageBox.Show("Error, sorry!");
            }
        }
    }
}