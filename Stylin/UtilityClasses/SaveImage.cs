using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace Stylin.UtilityClasses
{
    //Create a method here that will save the image file onto the server and returns file path
    public class SaveImage
    {
        private IWebHostEnvironment _hostingEnvironment;

        public SaveImage(IWebHostEnvironment environment)
        {
            _hostingEnvironment = environment;
        }


            public async Task<string> Save(IFormFile file)
            {
            string uploads = Path.Combine(_hostingEnvironment.WebRootPath, "Uploads");
            string filePath = "";
            if (file.Length > 0)
            {
                filePath = Path.Combine(uploads, file.FileName);
                using (Stream fileStream = new FileStream(filePath, FileMode.Create))
                {
                    await file.CopyToAsync(fileStream);
                }
            }
            return filePath;
        }
    }
}
