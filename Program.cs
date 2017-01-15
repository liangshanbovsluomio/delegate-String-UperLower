using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 用delegate将数组大小写
{

    class Program
    {
        public delegate string StrUpLw(string str);
        static void Main(string[] args)
        {
            string[] str = new string[] { "ffssdfs", "bbbbsds", "dfdfdf" };
            string[] str2 = new string[] { "FDSFSF", "CXCXCX", "POPIOPIP" };

            StrUpLw strUp = ProUper;
            ProString(str, strUp);

            StrUpLw strLw = (string a) => { return a.ToLower(); };//匿名函数或LAMBDA表达式可节省下面写函数的麻烦 毕竟一次
            ProString(str2, strLw);

        }
        static void ProString(string[] name,StrUpLw sul)
        {
            for (int i = 0; i < name.Length; i++)
            {
                name[i] = sul(name[i]);
                Console.WriteLine(name[i]);
               
            }
            Console.ReadLine();

        }

        static string ProUper(string a)
        {
            return a.ToUpper();
        }

        //static string ProLower(string b)
        //{
        //    return b.ToLower();
        //}
    }
}
