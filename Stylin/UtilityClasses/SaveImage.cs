using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Stylin.Services;
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

    //This is not inside SAveImgae classs. SendMessages and SAveImage classes are inside UtilityClasses namespace.
    //I see. but, not technically.
    public class SendMessage
    {

        public SendMessage()
        {
            
        }
        public void SendText(string PhoneNumber, string TextBody)
        {
           //APIKeys class obstantiated
           
            APIKeys aPIKeys = new APIKeys();
            //Twilio library
            //Twilio.TwilioClient is the packge in .net which is responsbile for talking to all the twilio apis.
            Twilio.TwilioClient.SetUsername("TLaw92");
            //TwilioClient.Init() is the function which actually kicks start your twilioclient library to call differnt mehtods in that.

            TwilioClient.Init(APIKeys.TWILIO_API_SID, APIKeys.TWILIO_API_AUTH);

            //mesage resouurce is class in TwilioClient is to send and receieve messages to and from your application
            // with the power of Twilio.
            var message = MessageResource.Create(
                body: TextBody,///body key of message object where all the body of message is present.
                from: new Twilio.Types.PhoneNumber("+14049943666"),//Your Twilio Number, where the message will be sent.
                to: new Twilio.Types.PhoneNumber(PhoneNumber)//The number to which the message will be sent.
            );
        }

    }
}
