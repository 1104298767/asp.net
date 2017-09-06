using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test0_1
{
    class Program
    {
        static void Main(string[] args)
        {
            tushu ts1=new tushu(1,"高数",100,"新华","张龙涛","2017");
            tushu ts2 = new tushu(2, "英语", 101, "新华", "安玉海", "2016");
            tushu ts3 = new tushu(3, "os", 102, "新华", "穆宇", "2015");
            tushu ts4 = new tushu(4, "程序结构", 103, "新华", "贺军", "2014");
            tushu ts5 = new tushu(5, "大物", 104, "新华", "陈龙", "2013");

            tushu[] tushus = new tushu[5];
            tushus[0] = ts1;
            tushus[1] = ts2;
            tushus[2] = ts3;
            tushus[3] = ts4;
            tushus[4] = ts5;

            foreach (tushu tushu in tushus)
            {
                tushu.print();
            }

        }
    }
}
