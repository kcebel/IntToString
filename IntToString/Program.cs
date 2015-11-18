using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntToString
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 2147483647;
            Console.WriteLine(MakeAString(num));
            
        }
        static public string MakeAString(int num)
        {
            string[] numArray = { "0", "1", "2", "3", "4", "5", "6", "7", "8", "9" };

            int rem;
            string ans = "";
            if (num == 0)
            {
                ans = "0";
            }
            else if (num < 0)
            {
                num = num * -1;
                while (num > 0)
                {
                    rem = num % 10;
                    string str = numArray[rem];
                    ans = str + ans;
                    num /= 10;
                }
                ans = "-" + ans;

            }
            else
            {
                while (num > 0)
                {
                    rem = num % 10;
                    string str = numArray[rem];
                    ans = str + ans;
                    num /= 10;
                }
            }
            return ans;
        }
    }
}