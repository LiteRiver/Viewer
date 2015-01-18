using System;
using System.Collections.Generic;
using System.Linq;
using Viewer.Macro;

namespace Viewer {
    public class TaskContext {
        private TimeSpan m_changeInterval;

        private TimeSpan m_macroInterval;

        private IList<Uri> m_urls;

        private IEnumerable<MacroEvent> m_macroEvents;

        public TimeSpan ChangeInterval {
            get { return m_changeInterval == default(TimeSpan) ? TimeSpan.FromHours(1) : m_changeInterval; }
            set { m_changeInterval = value; }
        }

        public TimeSpan MacroInterval {
            get { return m_macroInterval == default(TimeSpan) ? TimeSpan.FromMinutes(1) : m_macroInterval; }
            set { m_macroInterval = value; }
        }

        public IList<Uri> Urls {
            get { return m_urls ?? (m_urls = new List<Uri>()); }
            set { m_urls = value; }
        }

        public IEnumerable<MacroEvent> MacroEvents {
            get { return m_macroEvents ?? (m_macroEvents = Enumerable.Empty<MacroEvent>()); }
            set { m_macroEvents = value; }
        }
    }
}
