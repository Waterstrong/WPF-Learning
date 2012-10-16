﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;
using System.Globalization;

namespace CustomLib
{
    [TypeConverter(typeof(MoneyConverter))]
    public class MoneyType
    {
        private double _value;
        public MoneyType()
        {
            _value = 0;
        }
        public MoneyType(double value)
        {
            _value = value;
        }
        public override string ToString()
        {
            return _value.ToString();
        }
        public static MoneyType Parse(string value)
        {
            string str = (value as string).Trim();
            if (str[0] == '$')
            {
                string newprice = str.Remove(0, 1);
                double price = double.Parse(newprice);
                return new MoneyType(price * 6.8);
            }
            else
            {
                double price = double.Parse(str);
                return new MoneyType(price);
            }
        }
    }
}
