using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/*******
 * 主要分为挖矿模块，还有区块模块，钱包界面模块
 * 首先创建一个创始快
 * 
 * 
 * ************/

namespace CAGY_BTC
{
    [Serializable]
    public class Block
    {
        int _version;
        /// <summary>
        /// 版本
        /// </summary>
        public int Version
        {
            get { return _version; }
            set { _version = value; }
        }

        long _timeStamp;
        /// <summary>
        /// 时间戳
        /// </summary>
        public long TimeStamp
        {
            get { return _timeStamp; }
            set { _timeStamp = value; }
        }

        private string _prevBlockHash;
        /// <summary>
        /// 上一区块HASH值 32位
        /// </summary>
        public string PrevBlockHash
        {
            get { return _prevBlockHash; }
            set { _prevBlockHash = value; }
        }

        private int _size;
        /// <summary>
        /// 区块大小
        /// </summary>
        public int Size
        {
            get { return _size; }
            set { _size = value; }
        }

        private int _nonce;
        /// <summary>
        /// 挖矿的随机数
        /// </summary>
        public int Nonce
        {
            get { return _nonce; }
            set { _nonce = value; }
        }

        private int _bits;
        /// <summary>
        /// 当前难度
        /// </summary>
        public int Bits
        {
            get { return _bits; }
            set { _bits = value; }
        }


        private List<Transaction> _transactions;
        /// <summary>
        /// 交易信息
        /// </summary>
        public List<Transaction> Transactions
        {
            get { return _transactions; }
            set { _transactions = value; }
        }


    }
}
