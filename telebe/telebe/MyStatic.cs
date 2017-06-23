using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22._06._2017
{
    class MyStatic
    {
        static private int count = 0;

        public void countArtir()
        {
            count++;
        }
        public int getCount()
        {
            return count;
        }
        static public void Yazdir(string key)
        {
            Console.WriteLine(key);
        }
    }
}