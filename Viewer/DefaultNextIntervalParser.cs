using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Viewer {
    public class DefaultNextIntervalParser : INextIntervalParser {
        public TimeSpan Parse(string doc) {
            TimeSpan interval = TimeSpan.Zero;
            try {
                var regex = new Regex("<input\\s+name=\"hidStandardStudyHours\"\\s+type=\"hidden\"\\s+id=\"hidStandardStudyHours\"\\s+value=\"(?<time>\\d+)\"\\s+/>", RegexOptions.Compiled);
                var match = regex.Match(doc);
                if (match.Success) {
                    interval = TimeSpan.FromMinutes(int.Parse(match.Groups["time"].Value));
                }
            } catch {
                // 忽略错误
            }

            return interval;
        }
    }
}
