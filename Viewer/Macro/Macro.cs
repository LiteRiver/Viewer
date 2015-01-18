using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Viewer.Macro {
    /// <summary>
    /// All possible events that macro can record
    /// </summary>
    [Serializable]
    public enum MacroEventType {
        MouseMove,
        MouseDown,
        MouseUp,
        MouseWheel,
        KeyDown,
        KeyUp
    }

    /// <summary>
    /// Series of events that can be recorded any played back
    /// </summary>
    [Serializable]
    public class MacroEvent {

        public MacroEventType MacroEventType;

        [JsonProperty(TypeNameHandling = TypeNameHandling.Objects)]
        public EventArgs EventArgs;
        public int TimeSinceLastEvent;
        public Color Color;
        public MacroEvent(MacroEventType macroEventType, EventArgs eventArgs, int timeSinceLastEvent, Color color) {

            MacroEventType = macroEventType;
            EventArgs = eventArgs;
            TimeSinceLastEvent = timeSinceLastEvent;
            Color = color;
        }

        public static void Playback(IEnumerable<MacroEvent> macroEvents) {
            foreach (var macroEvent in macroEvents) {

                Thread.Sleep(macroEvent.TimeSinceLastEvent);

                switch (macroEvent.MacroEventType) {
                    case MacroEventType.MouseMove: {

                            MouseEventArgs mouseArgs = (MouseEventArgs)macroEvent.EventArgs;

                            MouseSimulator.X = mouseArgs.X;
                            MouseSimulator.Y = mouseArgs.Y;

                        }
                        break;
                    case MacroEventType.MouseDown: {

                            MouseEventArgs mouseArgs = (MouseEventArgs)macroEvent.EventArgs;

                            if (ScreenSnapshoot.PrimaryScreenSnapshoot.GetColor(mouseArgs.X, mouseArgs.Y) == macroEvent.Color) {
                                MouseSimulator.MouseDown(mouseArgs.Button);
                            }
                        }
                        break;
                    case MacroEventType.MouseUp: {

                            MouseEventArgs mouseArgs = (MouseEventArgs)macroEvent.EventArgs;

                            if (ScreenSnapshoot.PrimaryScreenSnapshoot.GetColor(mouseArgs.X, mouseArgs.Y) == macroEvent.Color) {
                                MouseSimulator.MouseUp(mouseArgs.Button);
                            }
                        }
                        break;
                    case MacroEventType.KeyDown: {

                            KeyEventArgs keyArgs = (KeyEventArgs)macroEvent.EventArgs;

                            KeyboardSimulator.KeyDown(keyArgs.KeyCode);

                        }
                        break;
                    case MacroEventType.KeyUp: {

                            KeyEventArgs keyArgs = (KeyEventArgs)macroEvent.EventArgs;

                            KeyboardSimulator.KeyUp(keyArgs.KeyCode);

                        }
                        break;
                    default:
                        break;
                }
            }
        }
    }
}
