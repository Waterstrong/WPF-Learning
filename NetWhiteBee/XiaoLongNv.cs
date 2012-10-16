using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NetWhiteBee
{
    public delegate void WhiteBee(string param);
    class XiaoLongNv
    {
        public event WhiteBee WhiteBeeEvent;
        public void OnFlyBee()
        {
            Console.WriteLine("小龙女在谷底日复一日放着玉蜂，希望有一天杨过能够看到……");
            WhiteBeeEvent(msg);
        }
        private string msg = "我在绝情谷底";
    }
}
