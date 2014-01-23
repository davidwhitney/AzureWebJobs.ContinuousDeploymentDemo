using System;
using System.IO;
using System.Threading;

namespace WebJob
{
    class Program
    {
        static void Main(string[] args)
        {
            const string filename = "webjoblog.txt";

            if (!File.Exists(filename))
            {
                File.Delete(filename);
            }

            var fs = File.Create(filename);
            fs.Close();

            
            var i = 1;
            while (true)
            {
                using (var w = File.AppendText(filename))
                {
                    var msg = "Iteration: " + i;
                    
                    Console.WriteLine(msg);
                    w.WriteLine(msg);
                }

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
