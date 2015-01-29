using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Viewer {

    /// <summary>
    /// 提取观看时间的默认实现
    /// </summary>
    public class DefaultNextIntervalParser : INextIntervalParser {
        public TimeSpan Parse(string doc) {
            TimeSpan interval = TimeSpan.Zero;
            try {
                // 网页中的 hidStandardStudyHours 表单记录了当前课时时间，以分钟为单位的;
                var regex = new Regex("<input\\s+name=\"hidStandardStudyHours\"\\s+type=\"hidden\"\\s+id=\"hidStandardStudyHours\"\\s+value=\"(?<time>\\d+)\"\\s+/>", RegexOptions.Compiled);
                var match = regex.Match(doc);
                if (match.Success) {
                    interval = TimeSpan.FromMinutes(int.Parse(match.Groups["time"].Value));
                    interval = interval.Add(TimeSpan.FromMinutes(5));
                }
            } catch { 
                // 提取异常，忽略错误
            }

            return interval;
        }
    }
}
