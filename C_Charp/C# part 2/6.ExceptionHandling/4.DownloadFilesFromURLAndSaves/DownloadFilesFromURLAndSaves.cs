using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;


namespace _6.DownloadFilesFromURLAndSaves
{
    class DownloadFilesFromURLAndSaves
    {
        static void Main(string[] args)
        {
            WebClient Client = new WebClient();

            try
            {

                Client.DownloadFile("http://www.devbg.org/img/Logo-BASD.jpg", "../../MyFiles.jpg");
            }

            catch (WebException)
            {
                Console.Error.WriteLine("Typed Adress Is Not Valid!");
            }

            catch (NotSupportedException)
            {
                Console.Error.WriteLine("The Method Have Out Of Range Calls!");
            }
            finally
            {
                Client.Dispose();
            }
        }

    }
}
