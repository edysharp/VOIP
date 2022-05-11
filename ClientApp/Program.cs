using System.Diagnostics;
using System.Net;

namespace ClientApp
{
    public static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>


        static Form1 form;

        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(form = new Form1());
        }

        public static string GetIPAddress() // ok so this is to get the ip address of the current public ip
        {
            String address = "";
            try
            {
            WebRequest request = WebRequest.Create("http://checkip.dyndns.org/");
            using (WebResponse response = request.GetResponse())
            using (StreamReader stream = new StreamReader(response.GetResponseStream()))
            {
                address = stream.ReadToEnd();
            }

            int first = address.IndexOf("Address: ") + 9;
            int last = address.LastIndexOf("</body>");
            address = address.Substring(first, last - first);

            }catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
            }
            return address;
        }


    }
}