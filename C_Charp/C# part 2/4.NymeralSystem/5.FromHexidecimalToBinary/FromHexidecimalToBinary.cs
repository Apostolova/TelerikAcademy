using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5.FromHexidecimalToBinary
{
    class FromHexidecimalToBinary
    {
        static void Main(string[] args)
        {
            string N = Console.ReadLine();
            string BinaryNumber = "";
            char[] arr = N.ToCharArray();
            for (int i = 0; i < arr.Length; i++)
            {
                switch (arr[i])
                {
                    case '0': BinaryNumber += "0000 ";
                        break;
                    case '1': BinaryNumber += "0001 ";
                        break;
                    case '2': BinaryNumber += "0010 ";
                        break;
                    case '3': BinaryNumber += "0011 ";
                        break;
                    case '4': BinaryNumber += "0100 ";
                        break;
                    case '5': BinaryNumber += "0101 ";
                        break;
                    case '6': BinaryNumber += "0110 ";
                        break;
                    case '7': BinaryNumber += "0111 ";
                        break;
                    case '8': BinaryNumber += "1000 ";
                        break;
                    case '9': BinaryNumber += "1001 ";
                        break;
                    case 'A': BinaryNumber += "1010 ";
                        break;
                    case 'B': BinaryNumber += "1011 ";
                        break;
                    case 'C': BinaryNumber += "1100 ";
                        break;
                    case 'D': BinaryNumber += "1101 ";
                        break;
                    case 'E': BinaryNumber += "1110 ";
                        break;
                    case 'F': BinaryNumber += "1111 ";
                        break;
                } 
            }
            Console.WriteLine(BinaryNumber);
        }
    }
}
