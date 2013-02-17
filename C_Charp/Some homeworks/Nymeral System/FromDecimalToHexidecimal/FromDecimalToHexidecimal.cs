using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Write a program to convert decimal numbers to their hexadecimal representation.

namespace _3.FromDecimalToHexidecimal
{
    class FromDecimalToHexidecimal
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            int digit =0;
            List<string> HexidecimalList = new List<string>();
            while (N > 0)
            {
                digit = N % 16;
                N /= 16;
                if (digit > 9)
                {
                    switch (digit)
                    {
                        case 10: HexidecimalList.Add("A");
                            break;
                        case 11: HexidecimalList.Add("B");
                            break;
                        case 12: HexidecimalList.Add("C");
                            break;
                        case 13: HexidecimalList.Add("D");
                            break;
                        case 14: HexidecimalList.Add("E");
                            break;
                        case 15:
                            HexidecimalList.Add("F");
                            break;
                    }
                }
                else
                {
                    string a = Convert.ToString(digit);
                    HexidecimalList.Add(a);
                }
            }
                for (int i = HexidecimalList.Count-1; i>=0; i--)
                {
                    Console.Write(HexidecimalList[i]);
                }
                Console.WriteLine();
            }
        }
    }

