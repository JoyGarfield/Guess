using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using IniHelperDll;

namespace GuessNumGame
{
    public partial class Form1 : Form
    {
        #region 属性 字段 变量
        string[] strAryBlue = null;
        string[] strAryRed = null;

        bool bFlag = false;
        static object Object_Lock = new object();
        string strPath = Application.StartupPath + "\\ConfigParament.ini";
        string strRed = string.Empty;
        string strBlue = string.Empty;
        List<Task> tasklist = new List<Task>();
        public static int iMinTime = 0;
        public static int iMaxTime = 0;
        #endregion
        /// <summary>
        /// 构造函数
        /// </summary>
        public Form1()
        {
            InitializeComponent();
            ReadIni();
        }
        /// <summary>
        /// 获取当前页面红色标签的数字
        /// </summary>
        /// <returns></returns>
        public List<string> GetCurrentRedNum()
        {
            List<string> listStrRed = new List<string>();
            foreach (var control in panel1.Controls)
            {
                if (control is Label)
                {
                    Label label = (Label)control;
                    if (label.Name.Contains("Red"))
                    {
                        listStrRed.Add(label.Text);
                    }
                }
            }
            //如果该方法中的集合出现了重复数字，则表示曾经这个界面出现重复数字
            //1.数字不包含"00",
            if (listStrRed.Count(c => c == "00") == 0 && listStrRed.Distinct().Count() < 6)
            {
                Console.WriteLine("该页面出现重复数字");
                for (int i = 0; i < listStrRed.Count; i++)
                {
                    Console.WriteLine(listStrRed[i]);
                }
            }
            return listStrRed;
        }

        /// <summary>
        /// 获取页面标签结果
        /// </summary>
        public void ShowResult()
        {
            MessageBox.Show($"中奖结果：红球：{lblRed1.Text},  {lblRed2.Text},  {lblRed3.Text},  {lblRed4.Text},  {lblRed5.Text},  {lblRed6.Text}   蓝球：{lblBlue.Text}");
        }
        #region 自写代码
        public void ReadIni()
        {
            IniHelper iniHelper = new IniHelper(strPath);
            strRed = iniHelper.ReadValue("NumArray", "Red");
            strAryRed = new string[strRed.Split(',').Length];
            strAryRed = strRed.Split(',');
            strBlue = iniHelper.ReadValue("NumArray", "Blue");
            strAryBlue = new string[strBlue.Split(',').Length];
            strAryBlue = strBlue.Split(',');
            iMinTime = int.Parse( iniHelper.ReadValue("DelayTime", "min"));
            iMaxTime = int.Parse( iniHelper.ReadValue("DelayTime", "max"));
        }
        //public List<string> GetRedLblTxt(List<string> lstrRed)
        //{
        //    foreach (Control control in panel1.Controls)
        //    {
        //        if (control is Label)
        //        {
        //            if (control.Name.Contains("Red"))
        //            {
        //                this.Invoke((MethodInvoker)delegate { lstrRed.Add(control.Text); });
        //            }
        //        }
        //    }
        //    return lstrRed;
        //}
        #endregion

        /// <summary>
        /// 开始
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnStart_Click(object sender, EventArgs e)
        {
            #region 自写代码
            //List<Task> taskList = new List<Task>();
            //bFlag = true;
            ////判断蓝色or红色标签
            //foreach (Control control in panel1.Controls)
            //{
            //    if (control is Label)
            //    {
            //        if (control.Name.Contains("Blue"))//蓝色标签
            //        {

            //            taskList.Add(Task.Run(() =>
            //           {
            //               while (bFlag)
            //               {
            //                   string str = new Random().Next(1, 17).ToString("00");
            //                   this.Invoke((MethodInvoker)delegate
            //                       { control.Text = str; });
            //                   Thread.Sleep(new Random().Next(200, 400));
            //               }
            //           }));
            //        }
            //        else//红色标签
            //        {
            //            taskList.Add(Task.Run(() =>
            //           {
            //               while (bFlag)
            //               {
            //                   string str = new Random().Next(1, 34).ToString("00");
            //                   lock (Object_Lock)
            //                   {
            //                       List<string> lstrRed = new List<string>();
            //                       lstrRed = GetRedLblTxt(lstrRed);
            //                       if (lstrRed.Contains(str))//判断当前红色标签的值，如果一致则返回，重新赋值
            //                       {
            //                           Thread.Sleep(30);
            //                           return;
            //                       }
            //                       else
            //                       {
            //                           this.Invoke((MethodInvoker)delegate { control.Text = str; });
            //                           Thread.Sleep(new Random().Next(200, 400));
            //                       }
            //                   }

            //               }
            //           }));
            //        }
            //    }
            //}
            //    //线程等待
            //    if (!bFlag)
            //    {
            //        this.Invoke((MethodInvoker)delegate
            //        {
            //            Task.Run(() =>
            //            {
            //                Task.WaitAll(taskList.ToArray());

            //                this.Invoke((MethodInvoker)delegate
            //                {
            //                    MessageBox.Show($"中奖号码：{lblRed1.Text},{lblRed2.Text},{lblRed3.Text},{lblRed4.Text},{lblRed5.Text},{lblBlue.Text}");
            //                });
            //            });
            //        });
            //    }
            #endregion

            #region 初始化
            btnStart.Text = "运行中";
            lblRed1.Text = "00";
            lblRed2.Text = "00";
            lblRed3.Text = "00";
            lblRed4.Text = "00";
            lblRed5.Text = "00";
            lblRed6.Text = "00";
            lblBlue.Text = "00";
            bFlag = true;
            btnStart.Enabled = false;
            btnStop.Enabled = true;
            tasklist = new List<Task>();
            #endregion

            //访问控件的label标签，进入线程
            foreach (var control in panel1.Controls)
            {
                if (control is Label)
                {
                    Label lbl = (Label)control;
                    if (lbl.Name.Contains("Blue"))//蓝色标签
                    {
                        tasklist.Add(Task.Run(() =>
                       {
                           while (bFlag)
                           {
                               int index = new RandomHelper().GetRandomDelay(0, strAryBlue.Length);
                               string strBNum = strAryBlue[index];
                               Invoke((MethodInvoker)delegate
                               {
                                   lbl.Text = strBNum;
                               });
                           }
                       }));
                    }
                    else//红色标签
                    {
                        tasklist.Add(Task.Run(() =>
                       {
                           while (bFlag)
                           {
                               int index = new RandomHelper().GetRandomDelay(0, strAryRed.Length);
                               string strRNum = strAryRed[index];
                               //在赋值前先看看界面有无这个值
                               //list 放在锁外：出现重复；原因：可能有两条线程同时获取页面数据，发现没有某一值，因此重复赋相同值
                               //list 放在锁内，没有重复
                               lock (Object_Lock)
                               {
                                   List<string> lCurrentRed = GetCurrentRedNum();
                                   if (!lCurrentRed.Contains(strRNum))
                                   {
                                       Invoke((MethodInvoker)delegate
                                       {
                                           lbl.Text = strRNum;
                                       });
                                   }
                               }
                           }
                       }));
                    }
                }
            }

            //只要bFlag=false，所有线程都可以结束执行

            Task.Run(() =>
            {
                Task.WaitAll(tasklist.ToArray());
                ShowResult();
            });

        }
        /// <summary>
        /// 结束
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnStop_Click(object sender, EventArgs e)
        {
            //出现新问题：弹窗显示的值和标签显示的值不一致
            //原因：弹窗时线程未停止
            //解决方法：等待所有线程执行完毕

            //没有开启新线程，就执行等待线程，出现线程死锁问题----子线程和主线程互相等待
            //解决方法：开启一个新线程等待子线程执行完毕
            //停止按钮只需要标志位置零，开始按钮的子线程就能停止
            bFlag = false;
            btnStart.Enabled = true;
            btnStop.Enabled = false;
            btnStart.Text = "开始";
        }
    }
}
