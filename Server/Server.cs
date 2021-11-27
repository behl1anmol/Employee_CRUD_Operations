using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;

namespace Server
{
    public class Server
    {
        static ServiceHost Host;
        static void Main(string[] args)
        {

            int ch = 1;
            int flag = 0;
           
            
            while (true)
            {
                Console.WriteLine("[1.] Press 1 to start service.\n[2.] Press 2 to stop the service.\n[3.] Press 3 to exit.\n");
                Console.WriteLine("Enter your choice:");
                ch = Convert.ToInt32(Console.ReadLine());
                if(ch == 1 && flag == 0)
                {
                    Host = new ServiceHost(typeof(EmployeeService.EmployeeService));
                    Host.Open();
                    flag = 1;
                    Console.WriteLine("\nService is Running.\n");
                }
                if(ch == 2 && flag == 1)
                {
                    Host.Close();
                    flag = 0;
                    Console.WriteLine("\nService is Closed.\n");
                }
                if(ch == 3)
                {
                    if (flag == 1) { Host.Close(); }
                    break;
                }

            }
            
        }
    }
}
