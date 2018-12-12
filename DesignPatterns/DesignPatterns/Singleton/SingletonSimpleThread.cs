using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Singleton
{
    public sealed class SingletonSimpleThread
    {
        private static SingletonSimpleThread _instance = null;
        private static readonly object Padlock = new object();

        private SingletonSimpleThread()
        {
        }

        public static SingletonSimpleThread Instance
        {
            get
            {
                lock (Padlock)
                {
                    return _instance ?? (_instance = new SingletonSimpleThread());
                }
            }
        }
    }    
}
