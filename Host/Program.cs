using System;
using System.ServiceModel;

// This must be debugged as administrator due to tcp bindings

namespace Host
{
    class Program
    {
        static void Main(string[] args)
        {
            using (ServiceHost host = new ServiceHost(
                  typeof(HelloIndigo.HelloIndigoService),
                  new Uri("http://localhost:8001/HelloIndigo")))
            {
                host.AddServiceEndpoint(
                    typeof(HelloIndigo.IHelloIndigoService),
                    new BasicHttpBinding(),
                    "HelloIndigoService");

                host.Open();

                Console.WriteLine("Press [Enter] to terminate the service host");
                Console.ReadLine();
            }

        }
    }
}
