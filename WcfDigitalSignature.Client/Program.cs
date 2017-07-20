using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WcfDigitalSignature.Client
{
    class Program
    {
        static void Main(string[] args)
        {
            ExecuteWsc(Echo);
            Console.Write("Press any key to end...");
            Console.ReadKey();
        }

        private static void ExecuteWsc(Func<string> method)
        {
            try
            {
                Console.WriteLine("Result: " + method());
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
        }

        private static string Echo()
        {
            using (var client = new EchoService.EchoServiceClient())
            {
                Console.WriteLine($"Calling echo at {client.Endpoint.Address}...");
                return client.Echo("Hello World");
            }
        }
    }
}
