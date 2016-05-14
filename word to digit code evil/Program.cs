using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace word_to_digit_code_evil
{
    class Program
    {
        static void Main(string[] args)
        {
            string line = "zero;two;five;seven;eight;four;three;seven;eight;nine;two";
            string[] lineItem = line.Split(';');
            
            Dictionary<string, int> dic = new Dictionary<string, int>();
            dic.Add("zero", 0);
            dic.Add("one", 1);
            dic.Add("two", 2);
            dic.Add("three", 3);
            dic.Add("four", 4);
            dic.Add("five", 5);
            dic.Add("six", 6);
            dic.Add("seven", 7);
            dic.Add("eight", 8);
            dic.Add("nine", 9);

            for (int index = 0; index <lineItem.Length; index++)
            {
                if (dic.ContainsKey(lineItem[index]))
                {
                    int value = dic[lineItem[index]];
                    Console.WriteLine(value);
                }

            }
            Console.Write("\n");
            {
                
            }



        }
    }
}
