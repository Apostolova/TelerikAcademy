using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Write a program that replaces in a HTML document given as string all the tags <a href="…">…</a> with corresponding tags [URL=…]…/URL]. 

namespace _15.ReplaceTags
{
    class ReplaceTags
    {
        static void Main(string[] args)
        {
            string text = @"<p>Please visit <a href = ""http://academy.telerik. com"">our site</a> to choose a training course. Also visit <a href = ""www.devbg.org"">our forum</a> to discuss the courses.</p>";
            StringBuilder sb = new StringBuilder(text);
                sb.Replace( @"<a href = """, @"[URL =");
                sb.Replace(@""">", @"]");
                sb.Replace(@"</a>", @"[/URL]");
            Console.WriteLine(sb.ToString());     
        }
    }
}
