using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MorePractice
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] wordString = new string[3] {"apple","ape","aphor"};


            //palindromeNumber(2345432);
            //palindromeNumber(11111);
            //palindromeNumber(3139999);
            //palindromeNumber(1000021);
            //Console.WriteLine( RomanToInt("MMCMIVII"));
            Console.WriteLine(LongestCommonPrefix(wordString));
            Console.WriteLine("Press enter to exit");
            Console.ReadLine();
        }


        public static void palindromeNumber(int x)
        {

            string tempString = " ";
            bool stringFlag = false;
            tempString = x.ToString();
            for (int i = 0; i < tempString.Length / 2; i++)
            {
                Console.WriteLine(tempString[i]);
                Console.WriteLine(tempString[tempString.Length - i - 1]);
                if (tempString[i] == tempString[tempString.Length - i - 1])
                {
                    stringFlag = true;

                }
                else
                {
                    stringFlag = false;
                }
            }
            Console.WriteLine(stringFlag);

        }
        public static int RomanToInt(string arr)
        {
            int returnNumber = 0;
            char[] s;
            s = arr.ToCharArray();
            
            for(int i = 0; i < s.Length; i++)
            {
               
                    if (s[i] == 'M')
                    {
                        returnNumber = returnNumber + 1000;
                    }
                    else if (s[i] == 'D')
                    {
                        returnNumber = returnNumber + 500;
                    }
                    else if (s[i] == 'C'&& i < s.Length - 1 && s[i + 1] == 'M')
                    {
                        returnNumber = returnNumber + 900;
                        i++;
                    }
                    else if (s[i] == 'C' && i < s.Length - 1 && s[i + 1] == 'D')
                    {
                        returnNumber = returnNumber + 400;
                        i++;
                    }
                    else if (s[i] == 'C')
                    {
                        returnNumber = returnNumber + 100;
                    }
                    else if (s[i] == 'L')
                    {
                        returnNumber = returnNumber + 50;
                    }
                    else if (s[i] == 'X' && i < s.Length - 1 && s[i + 1] == 'C')
                    {
                        returnNumber = returnNumber + 90;
                        i++;
                    }
                    else if (s[i] == 'X' && i < s.Length - 1 && s[i + 1] == 'L')
                    {
                        returnNumber = returnNumber + 40;
                        i++;
                    }
                    else if (s[i] == 'X')
                    {
                        returnNumber = returnNumber + 10;
                    }
                    else if (s[i] == 'V')
                    {
                        returnNumber = returnNumber + 5;
                    }
                    else if (s[i] == 'I' && i < s.Length - 1 && s[i + 1] == 'X')
                    {
                        returnNumber = returnNumber + 9;
                        i++;
                    }
                    else if (s[i] == 'I' && i < s.Length - 1 && s[i + 1] == 'V')
                    {
                        returnNumber = returnNumber + 4;
                        i++;
                    }
                    else if (s[i] == 'I')
                    {
                        returnNumber = returnNumber + 1;
                    }
                    if (s[i] == 'I' && i == s.Length)
                    {
                        returnNumber = returnNumber + 1;
                    }
                Console.WriteLine(returnNumber);
                
            }
            return returnNumber;
        }

        public static int RomanToInt2(string s)
        {
            int finalNumber = 0;
            for(int i = 0; i < s.Length; i++)
            {
                switch (s[i])
                {
                    case 'M':
                        finalNumber = finalNumber + 1000;
                        break;
                    //case ''
                }
            }

            return finalNumber;
        }
    
    public static string reverseAStringInAnArray(string[] strs)
        {
            string prefix = "";
            string character = "a";
            bool flag = true;
            //while (flag == true)
            //{
            //    if (wordCharacter == wordCharacter2)
            //    {
            //        prefix = prefix + character;
            //    }
            //}
            //prefix = prefix + character;
            character = strs[2];
            for (int i = 0; i < strs[2].Length; i++)
            {
                //prefix = prefix + character[strs[2].Length - i];
                prefix = prefix + strs[2][strs[2].Length - 1 - i];
            }

            return prefix;
        }

        public static string LongestCommonPrefix(string[] strs)
        {
            string prefix = "";
           //string character = "a";
            //bool flag = true;
            int shortestStringLength = shortestString(strs);
            //int shortStringLen = 0;
            //if (strs.Length <= 1)
            //{
            //    flag = false;
            //}
            //if (strs[0].Length < strs[1].Length)
            //{
            //    shortStringLen = strs[0].Length;
            //}
            //else
            //{
            //    shortStringLen = strs[1].Length;
            //}
            //for (int j = 0; j < shortStringLen; j++)
            //{
            //    if (strs[0][j] == strs[1][j])
            //    {
            //        prefix = prefix + strs[0][j];
            //    }
            //    else
            //    {
            //        break;
            //    }
            //}


            
            for (int i = 0; i < strs.Length -1; i++)
            {
                prefix = "";
                for (int j = 0; j < shortestStringLength; j++)
                {
                    if (strs[i][j] == strs[i+1][j])
                    {
                        prefix = prefix + strs[i][j];
                    }
                    else
                    {
                        break;
                    }
                }
            }
                
                
            
            return prefix;
        }

        public static int shortestString(string[] stir)
        {
            int shStr = 0;
            for(int i = 0; i < stir.Length - 1; i++)
            {
                if (stir[i].Length <= stir[i + 1].Length)
                {
                    shStr = stir[i].Length;
                }
                else
                {
                    shStr = stir[i + 1].Length;
                }
            }

            return shStr;
        }
    }
}
            
       

       
 