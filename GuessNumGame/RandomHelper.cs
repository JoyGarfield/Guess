using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace GuessNumGame
{
    public class RandomHelper
    {
        /// <summary>
        /// 获取随机数时延时
        /// </summary>
        /// <param name="min"></param>
        /// <param name="max"></param>
        /// <returns></returns>
        public int GetRandomDelay(int min,int max)
        {
            Thread.Sleep(GetRandomNum(Form1.iMinTime, Form1.iMaxTime));
            return GetRandomNum(min, max);
        }
        /// <summary>
        /// 获取随机数，尽量不重复
        /// </summary>
        /// <param name="min"></param>
        /// <param name="max"></param>
        /// <returns></returns>
        public int GetRandomNum(int min,int max)
        {
            Guid guid = new Guid();
            string strGuid = guid.ToString();
            int seed = DateTime.Now.Millisecond;
            for(int i = 0; i < strGuid.Length; i++)
            {
                switch (strGuid[i])
                {
                    case 'a':
                    case 'b':
                    case 'c':
                    case 'd':
                    case 'e':
                    case 'f':
                    case 'g':
                        seed = seed + 1;
                        break;
                    case 'h':
                    case 'i':
                    case 'j':
                    case 'k':
                    case 'l':
                    case 'm':
                    case 'n':
                        seed = seed + 2;
                        break;
                    case 'o':
                    case 'p':
                    case 'q':
                    case 'r':
                    case 's':
                    case 't':
                        seed = seed + 3;
                        break;
                    case 'u':
                    case 'v':
                    case 'w':
                    case 'x':
                    case 'y':
                    case 'z':
                        seed = seed + 4;
                        break;
                    default:
                        seed = seed + 5;
                        break;
                }
            }
            Random random = new Random(seed);
            return random.Next(min, max);
        }
    }
}
