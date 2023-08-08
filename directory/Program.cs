using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace directory
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"E:\nithu";
            Directory.CreateDirectory(path);
            string[] a = Directory.GetDirectories(path);
            for(int i=0; i<a.Length;i++)
            {
                Console.WriteLine(a[i]);
            }
        }
    }
}
