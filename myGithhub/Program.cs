using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myGithhub
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] code = new char[] {'-','.','/',':','a','b','c','g','h','i','m','n','o','p','r','s','t','u' };
            var bored = new char[] { 'm', 'i', 'a', ' ', 'r', 'a', 'i', ' ', 'u', 's', 's', 't', '-', 'u', 'c', 'a', 'r', 'l', 'i', 'c', 's', 't', 't', 'h', 'i', 'x', 'a', 'a', 'n' };
            string enc = @"EZ[J";            
            StringBuilder path = new StringBuilder();
            for (int i=0;i<4;i++)
            {
                path.Append((char)(code[i] ^ enc[i]));
            }
            path.Append(code[code.Length/2 + 6]);
            path.Append(':');
            path.Append((char)('.' + 1));
            path.Append((char)('.' + 1));            
            path.Append(code[7]);
            path.Append(code[9]);
            path.Append(code[code.Length-2]);
            path.Append(code[8]);
            path.Append(code[17]);
            path.Append(code[5]);
            path.Append(".com/");
            var linque = bored.Where((ch, ind) => ind % 2 == 0);
            foreach(var x in linque)
            {
                path.Append(x);
            }            
            System.Diagnostics.Process.Start(path.ToString());
        }
    }
}
