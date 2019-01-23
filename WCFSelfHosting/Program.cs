using System;
using System.ServiceModel;
using WCFServices.Services;

namespace WCFSelfHosting
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            ServiceHost EmployeeServiceHost = new ServiceHost(typeof(EmployeeService));
            EmployeeServiceHost.Open();
            Console.WriteLine("Employee service hosted successfully.");
            Console.Read();
        }
    }
}