using System;
using System.Threading.Tasks;
using Twilio;
using Twilio.Rest.Api.V2010.Account;
using Twilio.Types;

namespace TWILIO.CMDR
{
    class Program
    {
        static void Main(string[] args)
        {
            SendSms().Wait();
            Console.Write("Press any key to continue.");
            Console.ReadKey();
        }

        static async Task SendSms()
        {
            // Your Account SID from twilio.com/console
            var accountSid = "AC4a6fc4497ee8fa1ba43514df6270c790";
            // Your Auth Token from twilio.com/console
            var authToken = "0b3cbfd4d401ed6780b0bfc9320533cb";

            TwilioClient.Init(accountSid, authToken);

            var message = await MessageResource.CreateAsync(
                to: new PhoneNumber("+15558675309"),
                from: new PhoneNumber("+15017250604"),
                body: "Hello from C#");

            Console.WriteLine(message.Sid);
        }
    }
}
