using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NetWhiteBee
{
    class Program
    {
        static void Main(string[] args)
        {
            XiaoLongNv longer = new XiaoLongNv();
            LaoWanTong tong = new LaoWanTong();
            HuangRong rong = new HuangRong();
            YangGuo guo = new YangGuo();

            longer.WhiteBeeEvent += tong.ProcessBeeLetter;
            longer.WhiteBeeEvent += rong.ProcessBeeLetter;

            longer.OnFlyBee();

            guo.Sign();

            Console.ReadLine();

        }
    }
}
