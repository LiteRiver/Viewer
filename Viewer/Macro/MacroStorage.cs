using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;

namespace Viewer.Macro {
    public static class MacroStorage {

        private const string FileName = "macro.data";

        private static object s_lockObj = new object();

        public static void Save(IEnumerable<MacroEvent> macroEvents) {
            if (macroEvents == null) {
                throw new ArgumentNullException("macroEvents");
            }

            lock (s_lockObj) {
                File.WriteAllText(GetFilePath(), JsonConvert.SerializeObject(macroEvents));
            }
            
        }

        public static IEnumerable<MacroEvent> Load() {
            lock (s_lockObj) {
                return JsonConvert.DeserializeObject<IEnumerable<MacroEvent>>(File.ReadAllText(GetFilePath()));
            }
        }

        public static string GetFilePath() {
            return Path.Combine(AppDomain.CurrentDomain.BaseDirectory, FileName);
        }
    }
}
