using PerformanceTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;

namespace KafkaPerformanceTesting
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        static void Main()
        {
            KafkaDbContext dbContext = new KafkaDbContext();
            var runTest = dbContext.Get_RunTest_Table();

            ServiceBase[] ServicesToRun;

            ServicesToRun = new ServiceBase[]
            {
                new Service1()
            };
            ServiceBase.Run(ServicesToRun);
        }
    }
}
