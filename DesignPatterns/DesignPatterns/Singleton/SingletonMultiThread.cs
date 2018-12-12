using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Singleton
{    
    public sealed class SingletonMultiThread
    {
        // Lazy<T> initialisation tardive
        private static readonly Lazy<SingletonMultiThread> Lazy = new Lazy<SingletonMultiThread>(() => new SingletonMultiThread());

        public static SingletonMultiThread Instance => Lazy.Value;

        private SingletonMultiThread()
        {
        }
    }
}
