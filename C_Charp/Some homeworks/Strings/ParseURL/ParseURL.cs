using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Write a program that parses an URL address given in the format: [protocol]://[server]/[resource]
//and extracts from it the [protocol], [server] and [resource] elements.
//For example from the URL http://www.devbg.org/forum/index.php the following information should be extracted:
		//[protocol] = "http"
		//[server] = "www.devbg.org"
		//[resource] = "/forum/index.php"

namespace _12.ParseURL
{
    class ParseURL
    {
        static void Main(string[] args)
        {
            string url = @"http://www.devbg.org/forum/index.php";
            int startIndex = 0;
            int endIndex;
                startIndex = url.IndexOf(":");
                int lenght = startIndex - 0;
                string protocol = url.Substring(0, lenght);
                Console.WriteLine("[protocol] = \"{0}\"",protocol);

                endIndex = url.IndexOf("/", startIndex+3);
                lenght = endIndex - (startIndex+3);
                string server = url.Substring(startIndex+3, lenght);
                Console.WriteLine("[server] = \"{0}\"", server);

                string resource = url.Substring(endIndex);
                Console.WriteLine("[resource] = \"{0}\"", resource);
                 
        }
    }
}
