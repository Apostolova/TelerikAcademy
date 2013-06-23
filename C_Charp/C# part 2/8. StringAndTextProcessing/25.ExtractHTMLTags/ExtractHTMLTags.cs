using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Write a program that extracts from given HTML file its title (if available), and its body text without the HTML tags. 

namespace _25.ExtractHTMLTags
{
    class ExtractHTMLTags
    {
        static void Main(string[] args)
        {
            string text = @"<html><head><title>News</title></head><body><p><a href= ""http: //academy.telerik.com"">TelerikAcademy</a>aims to provide free real-world practicaltraining for young people who want to turn intoskillful .NET software engineers.</p></body></html>";
            StringBuilder sb = new StringBuilder();
            bool InTag = false;
            bool OutTag = true;
            foreach (var sing in text)
            {
                if (OutTag)
                {
                    if (sing == '<')
                    {
                        InTag = true;
                        OutTag = false;
                    }
                    else
                    {
                        sb.Append(sing);
                    }
                }
                else  if (InTag)
                {
                    if (sing == '>')
                    {
                        OutTag = true;
                    }
                    else
                    {
                        continue;
                    }
                }
            }
                Console.WriteLine(sb.ToString());  

            
        }
    }
}
