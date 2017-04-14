using System.Diagnostics;

namespace SwissArmy.Modules
{
    public class PHPDocs
    {
        private PHPDocs() { }
        public static void Run(string term)
        {
                Process.Start("http://php.net/manual-lookup.php?pattern=" + term + "&scope=quickref");
        }
    }
}
