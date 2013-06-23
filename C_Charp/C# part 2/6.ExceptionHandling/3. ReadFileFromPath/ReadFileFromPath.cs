using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Security;

namespace _3.ReadFileFromPath
{
    class ReadFileFromPath
    {
        public static void ReadAllText(string filePath)
        {
            string fileContent = File.ReadAllText(filePath);
            Console.WriteLine(fileContent);         
        }

        static void Main(string[] args)
        {
            string name = @"C:\Users\Elena\Desktop\eli.txt";
            try
            {
                ReadAllText(name);
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("File not found.");
            }
            catch (NotSupportedException)
            {
                Console.WriteLine("Is not valid format 'path'.");
            }
            catch (SecurityException)
            {
                Console.WriteLine("You don't have permission for this file");
            }
            catch (ArgumentException)
            {
                Console.WriteLine("Invalid 'path'.");
            }
            catch (DirectoryNotFoundException)
            {
                Console.WriteLine("The specified path is invalid");
            }
  
        }
    }
}
