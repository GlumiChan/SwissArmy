using System.Windows.Forms;

namespace SwissArmy.Modules
{
    public class Watch2Gether
    {
        public static void Run()
        {
            try
            {
                string resp = Core.DoCustomRequest("https://www.watch2gether.com/rooms/create", "utf8=✓", "POST");
                string room = Core.StringBetween("og:url\" content=\"", "\">", resp);
                Clipboard.SetText(room);
                MessageBox.Show("Copied");
            }
            catch
            {
                MessageBox.Show("Error, sorry!");
            }
        }
    }
}