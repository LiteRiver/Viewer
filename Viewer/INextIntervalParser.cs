using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Viewer {
    /// <summary>
    /// 提取观看时间
    /// </summary>
    public interface INextIntervalParser {
        TimeSpan Parse(string doc);
    }
}
