using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace CAGY_BTC
{
    class FileWatcher
    {
        private delegate void setLogTextDelegate(FileSystemEventArgs e);
        private delegate void renamedDelegate(RenamedEventArgs e);
     

        /// <summary>
        /// 监视文件变化
        /// 如果发生了变化就扫描当前的文件内容，把需要的报警提取出来，再发出去
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void fileSystemWatcher_EventHandle(object sender, FileSystemEventArgs e)
        {
            string[] strArr = e.FullPath.Split(new char[] { '\\' });
            if (!strArr[1].Equals("$RECYCLE.BIN"))  //回收站
            {
                //strArr[strArr.Length - 1]); //文件名
                //e.FullPath;//路径
                try
                {
                    if (e.FullPath.Contains(".got") && !e.FullPath.Contains(".got.")) CheckBlock(e.FullPath);
                }
                catch (Exception ex)
                {
                }

            }
        }

        public void Start(string path)
        {
            FileSystemWatcher fsw = new FileSystemWatcher();
            if (Directory.Exists(path))
            {
                try
                {
                    fsw.Path = path;//路径
                    fsw.IncludeSubdirectories = true;  //获取或设置一个值，该值指示是否监视指定路径中的子目录。
                    fsw.NotifyFilter = NotifyFilters.FileName | NotifyFilters.DirectoryName | NotifyFilters.Size;
                    fsw.Created += new FileSystemEventHandler(this.fileSystemWatcher_EventHandle);
                    fsw.Changed += new FileSystemEventHandler(this.fileSystemWatcher_EventHandle);
                    fsw.EnableRaisingEvents = true;
                }
                catch (Exception)
                {

                }
            }
            else ;
        }

        /// <summary>
        /// 扫描检查区块文件
        /// </summary>
        /// <param name="path"></param>
        private void CheckBlock(string path)
        {
            FileBlock fb=new FileBlock();
            //block\\
            string[] arrayPath=path.Split('\\');
            int fileNum=Convert.ToInt32(arrayPath[arrayPath.Length-1].Replace(".got",""));
            Block b= fb.DeSerializeNow(fileNum);//当前区块
            Block _b = fb.DeSerializeNow(fileNum-1);//上一个区块文件

        }
        /// <summary>
        /// 计算当前区块里面的所有输入金额，是否来自于之前的，或者是之前的之前的，区块
        /// </summary>
        private void CalcBlock()
        {
                
        }
    }
}
