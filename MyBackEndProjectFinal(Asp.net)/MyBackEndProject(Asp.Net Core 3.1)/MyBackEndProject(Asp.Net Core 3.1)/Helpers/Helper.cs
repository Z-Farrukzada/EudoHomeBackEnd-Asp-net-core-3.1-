using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace MyBackEndProject_Asp.Net_Core_3._1_.Helpers
{
    public static class Helper
    {
        public static void DeleteImage(string root, string folder, string filename)
        {
            string filepath = Path.Combine(root, folder, filename);
            if (File.Exists(filepath))
            {
                File.Delete(filepath);
            }
        }
    }
}
