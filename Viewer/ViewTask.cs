using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Viewer.Macro;

namespace Viewer {
    public class ViewTask {
        private TaskContext m_context;

        private int m_index = -1;

        private Timer m_changeTimer;

        private Timer m_macroTimer;

        private ITaskNotify m_taskNotify;


        public ViewTask(TaskContext context, ITaskNotify taskNotify) {
            m_context = context;
            m_taskNotify = taskNotify;
        }

        public void Start() {
            Stop();
            m_index = -1;
            m_changeTimer = new Timer(ChangeTimerCallback, null, TimeSpan.Zero, m_context.ChangeInterval);
            m_macroTimer = new Timer(MacroTimerCallback, null, m_context.MacroInterval, m_context.MacroInterval);
            m_taskNotify.OnStart();
        }

        public void Stop() {
            m_index = -1;
            if (m_changeTimer != null) {
                m_changeTimer.Dispose();
                m_changeTimer = null;
            }

            if (m_macroTimer != null) {
                m_macroTimer.Dispose();
                m_macroTimer = null;
            }
        }

        private void ChangeTimerCallback(object state) {
            var next = Next();
            if (next != null) {
                m_taskNotify.OnView(next, m_index);
            } else {
                Stop();
                m_taskNotify.OnComplete();
            }
        }

        private void MacroTimerCallback(object state) {
            lock (this) {
                MacroEvent.Playback(m_context.MacroEvents);
            }
        }

        private Uri Next() {
            if (m_index < m_context.Urls.Count - 1) {
                m_index++;
                return m_context.Urls[m_index];
            }
            return null;
        }
    }
}
