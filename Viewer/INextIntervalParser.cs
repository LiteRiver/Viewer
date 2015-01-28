using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Viewer {
    public interface INextIntervalParser {
        TimeSpan Parse(string doc);
    }
}
