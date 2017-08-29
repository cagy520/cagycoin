using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CAGY_BTC
{
    public class Transaction
    {
        private string _Address;
        /// <summary>
        /// 地址 
        /// </summary>
        public string Address
        {
            get { return _Address; }
            set { _Address = value; }
        }


        private double _Coin;
        /// <summary>
        /// 交易的币的数量
        /// </summary>
        public double Coin
        {
            get { return _Coin; }
            set { _Coin = value; }
        }

        private int _transType;
        /// <summary>
        /// 1=输入COIN,2=输出COIN
        /// </summary>
        public int TransType
        {
            get { return _transType; }
            set { _transType = value; }
        }


    }
}
