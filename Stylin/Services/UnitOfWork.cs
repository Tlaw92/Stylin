//using Microsoft.AspNetCore.Hosting;
//using Microsoft.AspNetCore.Http;
//using Stylin.Infastructure;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Threading.Tasks;

//namespace Stylin.Services
//{
//    public class UnitOfWork : IUnitOfWork
//    {
//        private IHostingEnvironment _hostingEnvironment;

//        public UnitOfWork(IHostingEnvironment hostingEnvironment)
//        {
//            _hostingEnvironment = hostingEnvironment;
//        }

//        public void UploadImage(IFormFile file)
//        {
//            long totalBytes = file.Length;
//            string fileName = file.FileName.Trim('"');
//            fileName = EnsureFileName(fileName);
//            byte[] buffer = new byte[16 * 1024];
//            using (FileStream output = System.IO.File.Create(fileName)))
//            {
//                using (Stream input = file.OpenReadStream())
//                    (
//                    int readBytes;
//                while ((readBytes = input.Read(buffer, 0, readBytes);
//                    )
//            }

//        }
//    }
//}
