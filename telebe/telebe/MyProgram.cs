using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22._06._2017
{
    class Program
    {
        static void Main(string[] args)
        {

            /*Telebe iso = new Telebe("Ismayil","Abdullayev","P202",new DateTime(1994,02,08));
            Telebe cavid = new Telebe("Cavid","Sadixov","P202",new DateTime(1993,07,28));
            Telebe uzeyir = new Telebe("Uzeyir","Haciqedirli","P202",new DateTime(1997,01,01));
            Console.WriteLine(uzeyir.getAge());
            iso.addExamResult("MT", 70);
            iso.addExamResult("Asp.net", 80);
            cavid.addExamResult("MT", 50);
            cavid.addExamResult("Asp.net", 80);
            cavid.addExamResult("C#", 70);
            iso.updateExamResult("MT", 80);
            iso.deleteExamResult("Asp.net");
           Console.WriteLine(iso.getFullName());
            foreach (KeyValuePair<string,double> child in iso.Exams)
            {
                Console.WriteLine(child.Key+"->"+ child.Value);
            }
           Console.WriteLine(cavid.getFullName());
           foreach (KeyValuePair<string,double> item in cavid.Exams)
           {
               Console.WriteLine(item.Key + "->" + item.Value);
           }
           Console.WriteLine(uzeyir.getFullName());
           foreach (KeyValuePair<string, double> item in uzeyir.Exams)
           {
               Console.WriteLine(item.Key + "->" + item.Value);
           }*/

            //Telebe.Yazdir("Salam");


            MyStatic mst = new MyStatic();

            MyStatic mst1 = new MyStatic();

            mst.countArtir();
            mst.countArtir();

            Console.WriteLine(mst1.getCount());
            mst1.countArtir();
            mst1.countArtir();
            mst1.countArtir();

            Console.WriteLine(mst.getCount());

            MyStatic.Yazdir("Salam");

        }
    }
}