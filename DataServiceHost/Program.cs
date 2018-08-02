using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataService;
using System.ServiceModel;
using System.ServiceModel.Description;

namespace DataServiceHost
{
    class Program
    {
        static void Main(string[] args)
        {
            //step 1 create URI to serve as the base address
            Uri baseAddress = new Uri("http://localhost:8000/ServiceModelSamples/Service");

            //Step 2 create a serviceHost instance
            //ServiceHost selfHost = new ServiceHost(new CalculatorService(), baseAddress);
            ServiceHost selfHost = new ServiceHost(typeof(TextDataService), baseAddress);

            try
            {
                /* //Using .Net 4.5, so we shouldn't need this
                //Step 3 Add a service endpoint
                selfHost.AddServiceEndpoint(
                    GetType(ICalculator),
                    new WSHttpBinding(),
                    "CalculatorService");
                    */
                /*
            selfHost.AddServiceEndpoint("ICalculator",
                new WSHttpBinding(),
                "CalculatorService");*/

                //Step 4 Enable metadata exchange
                ServiceMetadataBehavior smb = new ServiceMetadataBehavior();
                smb.HttpGetEnabled = true;
                selfHost.Description.Behaviors.Add(smb);

                //Step 5 start the service
                selfHost.Open();
                Console.WriteLine("Data service is ready.");
                Console.WriteLine("Press <ENTER> to terminate service.");
                Console.WriteLine("");
                Console.ReadLine();

                //Close the ServiceHostBase to shutdown the service.
                selfHost.Close();
            }
            catch (CommunicationException ce)
            {
                Console.WriteLine("An exception occurred: {0}", ce.Message);
                selfHost.Abort();
            }

        }
    }
}
