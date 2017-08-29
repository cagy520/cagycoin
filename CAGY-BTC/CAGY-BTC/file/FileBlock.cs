using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Windows.Forms;
using System.Runtime.Serialization.Formatters.Binary;
namespace CAGY_BTC
{
    public class FileBlock
    {
        /// <summary>
        /// 创建区块文件
        /// </summary>
        /// <param name="b"></param>
        /// <returns></returns>
        public string CreateBlock(Block b,int fileNo)
        {
            try
            {
                FileStream wt = new FileStream(Application.StartupPath + "\\block\\"+fileNo.ToString()+".got", FileMode.Create);
                BinaryFormatter er = new BinaryFormatter();
                er.Serialize(wt, b);
                wt.Close();
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
            return "ok";
        }
        /// <summary>
        /// 反序列化,读取区块文件
        /// </summary>
        public Block DeSerializeNow(int fileNo)
        {
            Block b = new Block();
            try
            {
                FileStream fileStream = new FileStream(Application.StartupPath + "\\block\\" + fileNo.ToString() + ".got", FileMode.Open, FileAccess.Read, FileShare.Read);
                BinaryFormatter er = new BinaryFormatter();
                b = er.Deserialize(fileStream) as Block;
                fileStream.Close();
            }
            catch (Exception)
            {
                return null;
            }
            return b;
        }

    }
}
