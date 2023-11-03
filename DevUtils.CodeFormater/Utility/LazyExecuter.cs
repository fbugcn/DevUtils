using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace DevUtils.CodeFormater.Utility
{
    public class LazyExecuter : IDisposable
    {
        private Timer m_Timer;


        public LazyExecuter (TimerCallback callback)
        {
            m_Timer = new Timer(callback);
            m_Timer.Change(Timeout.Infinite, Timeout.Infinite);
        }

        // 单位毫秒
        public void Invoke(int delayMilliseconds)
        {
            m_Timer.Change(delayMilliseconds, Timeout.Infinite);
        }


        public void Dispose()
        {
            m_Timer.Change(Timeout.Infinite, Timeout.Infinite);
            m_Timer.Dispose();
            m_Timer = null;
        }

        
    }
}
