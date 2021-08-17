using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SecurePdf
{
    static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        
        [STAThread]
        static void Main()
        {
            //Register Syncfusion license
            Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense("NDEyODEyQDMxMzgyZTM0MmUzMFBwazV6QndiV01XdDhLcEhEVDVIT1lvTzd0U3NXcGUzWThJeFBiaGZWSzQ9;NDEyODEzQDMxMzgyZTM0MmUzMG45dmhKR1BGUFloS2lidWRLOURCNDhHb3ZoaVp3ZGJRUDlVa2lsWDFnVVk9;NDEyODE0QDMxMzgyZTM0MmUzMFZEL0JVWTgvVTgrTHQ0VHFXcm00V0I1WktLZWVCVTdtd1FsSFYrbXpoOEU9;NDEyODE1QDMxMzgyZTM0MmUzMFUyeUlobDhWSmpMOHcwRHJxMnUyR3FVUTFJV2diZmRNVWYrUDhRZGJINTQ9;NDEyODE2QDMxMzgyZTM0MmUzMFhtemc2OWU2WFd0NlFGQmo2TDBKUEpqcWlld3libXM0dDM1ekRZUlYrNU09");
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //var t = new Thread(new ThreadStart(StartApplication));
            //t.Start();
            //Thread.Sleep(1000);
            //Application.Exit();
            Application.Run(new Form1());
            
        }
        public static void StartApplication()
        {
            try
            {
                while (true)
                {
                    Application.Run(new SplashScreen());
                    Thread.Sleep(1000);
                }
            }
            catch (ThreadAbortException abortException)
            {
                Console.WriteLine((string)abortException.ExceptionState);
            }

        }

    }
}

