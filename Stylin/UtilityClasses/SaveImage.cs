using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Twilio;
using Twilio.Clients;
using Twilio.Rest.Api.V2010.Account;

namespace Stylin.UtilityClasses
{
    //Utility class Name Space create all the classes which does extra functions in the app.
    public class SaveImage
    {
        private IWebHostEnvironment _hostingEnvironment;

        public SaveImage(IWebHostEnvironment environment)
        {
            _hostingEnvironment = environment;
        }


        //method saves the image file onto the server and returns file path
        public async Task<string> Save(IFormFile file)//IFormFile is the datatype of file that comes from client to be saved onto server
        {
            //Create uploads Folder to hold Pictures saved to server
            //uploads variable is the path of the directory in which image file is saved to
            string uploads = Path.Combine(_hostingEnvironment.WebRootPath, "Uploads");
            //Hosting Environment is an instance that holds the absolute path of the current server 
            string filePath = "";
            if (file.Length > 0)
            {
                //Path.Combine combines the absolute path with the file name
                //............../Uploades/aladin.jpg
                filePath = Path.Combine(uploads, file.FileName);

                //FileStream class is creating a new empty file on the server 
                using (Stream fileStream = new FileStream(filePath, FileMode.Create))
                {
                    //and copying all the stream from the file that we get from client and psting it into the newly created file.
                    await file.CopyToAsync(fileStream);
                }
            }
            return filePath;
        }
    }


    public class SendMessage
    {

        public SendMessage()
        {
            //Nothing
        }
        public void SendText(string PhoneNumber, string TextBody)
        {

            Twilio.TwilioClient.SetUsername("TLaw92");
            TwilioClient.Init("AC640eee77dd161632095708a5a4a23255", "a57428eb0c67cbb00bc29777de013abc");

            var message = MessageResource.Create(
                body: TextBody,
                from: new Twilio.Types.PhoneNumber("+14049943666"),
                to: new Twilio.Types.PhoneNumber(PhoneNumber)
            );
        }

    }
}
