using System.Threading;
using log4net;
using log4net.Config;

namespace WebJob
{
    internal class Program
    {
        private static readonly ILog log = LogManager.GetLogger("WebJob");

        private static void Main(string[] args)
        {
            XmlConfigurator.Configure();

            var i = 1;
            while (true)
            {

                var msg = "Iteration: " + i;

                log.Debug(msg);


                i++;

                Thread.Sleep(1000);

                if (i >= 100000)
                {
                    break;
                }
            }

        }
    }
}
