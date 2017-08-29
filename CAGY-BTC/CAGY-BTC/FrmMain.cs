using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
/***********
 * 启动就尝试联网，接收区块文件.(需要一个区块发送测试工具)---此处省略
 * 接收区块文件要检查区块文件的正确性，（hash检查，所有交易结合上一次的交易信息，满足UTXO）
 * --监视文件，然后反序列化文件，然后检查计算
 * 
 * 检查是否有与当前钱包地址有关的交易，（或者统计所有钱包地址的剩余金额）有收入就显示到钱包上
 * 
 * 钱包地址就是自己的账号
 * 
 * 转账问题
 * 
 * 挖矿问题
 * 
 * 
 * 
 * ***********/



namespace CAGY_BTC
{
    public partial class FrmMain :DevExpress.XtraEditors.XtraForm
    {
        public FrmMain()
        {
            InitializeComponent();
            FileWatcher fw = new FileWatcher();
            fw.Start(Application.StartupPath + "\\block\\");//实时扫描文件夹下面的文件变化
            blFile.Caption += "Blockchain listen";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Block b = new Block();
            b.Version = 0;
            b.Size = 1000;
            b.PrevBlockHash = "0x000000000000000000000000000000000000000000000";
            b.Nonce = 0;
            b.TimeStamp = DateTime.Now.Ticks;
            b.Bits = 0;
            b.Transactions = new List<Transaction>();
            Transaction tx=new Transaction();
            tx.Coin=50;
            tx.Address="cagy";
            tx.TransType=1;//收到50个币
            b.Transactions.Add(tx);
            FileBlock f = new FileBlock();
            f.CreateBlock(b,0);
        }
    }
}
