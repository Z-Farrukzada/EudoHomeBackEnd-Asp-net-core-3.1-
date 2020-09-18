using Microsoft.AspNetCore.Http;
using Microsoft.VisualStudio.Web.CodeGeneration;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace MyBackEndProject_Asp.Net_Core_3._1_.Extensions
{
    public static class Extention
    {
        public static bool IsImage(this IFormFile file)
        {
            return file.ContentType.Contains("image/");
        }

        public static bool MaxLength(this IFormFile file,int kb)
        {
            return file.Length / 1024 > kb;
        }
        public static async Task<string> SaveImage(this IFormFile file,string root,string folder)
        {
            string filename = Guid.NewGuid().ToString() + file.FileName;
            string resultway = Path.Combine(root, folder, filename);
            using(FileStream fileStream =new FileStream(resultway, FileMode.Create))
            {
                 await file.CopyToAsync(fileStream);
            }
            return filename;
        }
     }
}
