using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonPattern
{
    public class Singleton
    {
        public static Singleton _instance;

        private static readonly object Locker = new object();

        private Singleton()
        {

        }

        public static Singleton Instance()
        {
            //没有第一重 instance == null 的话，每一次有线程进入 GetInstance()时，均会执行锁定操作来实现线程同步，
            //非常耗费性能 增加第一重instance ==null 成立时的情况下执行一次锁定以实现线程同步
            if (_instance == null)
            {
                lock (Locker)
                {
                    //Double-Check Locking 双重检查锁定
                    if (_instance == null)
                    {
                        _instance = new Singleton();
                    }
                }
            }

            return _instance;
        }
    }
}
