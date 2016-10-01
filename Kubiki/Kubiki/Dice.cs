using System;
using System.Threading;

namespace Kubiki
{
    class Dice
    {
        private int a, b;
        public Thread Thread1 { get; }

        public Dice(DelegateShow show)
        {
            this._show = show;
            Thread1=new Thread(Run);
            Thread1.IsBackground = true;
            Thread1.Start();
        }

        public void Go()
        {
            a = rand.Next(1, 6);
            b = rand.Next(1, 6);
            _show(a, b);
        }

        private static Random rand=new Random();
        private DelegateShow _show;

        public void Run()
        {
            while (true)
            {
                Go();
                Thread.Sleep(1000);
            }
        }
    }
}
