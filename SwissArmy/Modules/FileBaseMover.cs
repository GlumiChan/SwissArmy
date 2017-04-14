using System;
using System.IO;
using System.Windows.Forms;

namespace SwissArmy.Modules
{
    public class FileBaseMover
    {
        public static void Run(string basePath)
        {
            foreach (string file in Directory.GetFiles(basePath, "*.*", SearchOption.AllDirectories))
            {
                File.Move(file, basePath + @"\" + Path.GetFileName(file));
            }

            MessageBox.Show("Done");
        }
    }
}
