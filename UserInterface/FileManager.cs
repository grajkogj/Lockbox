using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace UserInterface
{
    public static class FileManager
    {
        public static string[] Files = Directory.GetFiles(@".\LockboxFiles");
        public static List<string> SelectedFiles = new List<string>();

        public static void UpdateFiles()
        {
            Files = Directory.GetFiles(@".\LockboxFiles");
        }
    }
}
