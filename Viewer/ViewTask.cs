using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Viewer.Macro;

namespace Viewer {
    public class ViewTask {
        // 默认 1s 报告一次进度
        private static readonly TimeSpan DefaultReportInterval = TimeSpan.FromSeconds(1);

        private TaskContext m_context;

        private int m_index = -1;

        private Timer m_changeTimer;

        private Timer m_macroTimer;

        private Timer m_reportTimer;

        private ITaskObserver m_taskObserver;

        private DateTime m_endTime;


        public ViewTask(TaskContext context, ITaskObserver taskObserver) {
            m_context = context;
            m_taskObserver = taskObserver;
        }

        public void Start() {
            Stop();
            ViewCurrent();
            m_taskObserver.OnStart();
        }

        public void Stop() {
            m_index = -1;
            StopTimer();
        }

        public void PendingNext(TimeSpan nextInterval) {
            if (nextInterval == TimeSpan.Zero) {
                nextInterval = m_context.ChangeInterval;
            }

            m_endTime = DateTime.Now + nextInterval;

            StopTimer();
            // 开始切换网页的定时器
            m_changeTimer = new Timer(ChangeTimerCallback, null, nextInterval, TimeSpan.FromMilliseconds(-1));
            // 开始执行宏的定时器
            m_macroTimer = new Timer(MacroTimerCallback, null, m_context.MacroInterval, m_context.MacroInterval);
            // 开始报告进度的定时器
            m_reportTimer = new Timer(ReportTimerCallback, null, TimeSpan.Zero, DefaultReportInterval);
        }

        private void ChangeTimerCallback(object state) {
            ViewCurrent();
        }

        private void ViewCurrent() {
            var next = Next();
            if (next != null) {
                m_taskObserver.OnView(next, m_index);
            } else {
                Stop();
                m_taskObserver.OnComplete();
            }
        }

        private void MacroTimerCallback(object state) {
            lock (this) {
                MacroEvent.Playback(m_context.MacroEvents);
            }
        }

        private void ReportTimerCallback(object state) {
            m_taskObserver.OnReport(m_endTime - DateTime.Now);
        }

        private Uri Next() {
            if (m_index < m_context.Urls.Count - 1) {
                m_index++;
                return m_context.Urls[m_index];
            }
            return null;
        }

        private void StopTimer() {
            if (m_changeTimer != null) {
                m_changeTimer.Dispose();
                m_changeTimer = null;
            }

            if (m_macroTimer != null) {
                m_macroTimer.Dispose();
                m_macroTimer = null;
            }

            if (m_reportTimer != null) {
                m_reportTimer.Dispose();
                m_reportTimer = null;
            }
        }
    }
}
