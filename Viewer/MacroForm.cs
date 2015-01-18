using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Viewer.Macro;

namespace Viewer {
    public partial class MacroForm : Form {

        private List<MacroEvent> events;

        private int lastTimeRecorded;

        private MouseHook mouseHook;

        private KeyboardHook keyboardHook;

        public MacroForm() {
            events = new List<MacroEvent>();
            lastTimeRecorded = 0;
            mouseHook = new MouseHook();
            keyboardHook = new KeyboardHook();

            InitializeComponent();

            mouseHook.MouseMove += new MouseEventHandler(mouseHook_MouseMove);
            mouseHook.MouseDown += new MouseEventHandler(mouseHook_MouseDown);
            mouseHook.MouseUp += new MouseEventHandler(mouseHook_MouseUp);

            keyboardHook.KeyUp += new KeyEventHandler(keyboardHook_KeyUp);
        }

        public List<MacroEvent> MacroRecords {
            get { return events; }
        }

        private void btnStart_Click(object sender, EventArgs e) {
            events.Clear();
            lastTimeRecorded = Environment.TickCount;

            Start();            
        }

        private void MacroForm_FormClosed(object sender, FormClosedEventArgs e) {
            Stop();
        }

        void mouseHook_MouseMove(object sender, MouseEventArgs e) {

            events.Add(
                new MacroEvent(
                    MacroEventType.MouseMove,
                    e,
                    Environment.TickCount - lastTimeRecorded,
                    Color.Empty
                ));

            lastTimeRecorded = Environment.TickCount;

        }

        void mouseHook_MouseDown(object sender, MouseEventArgs e) {

            events.Add(
                new MacroEvent(
                    MacroEventType.MouseDown,
                    e,
                    Environment.TickCount - lastTimeRecorded,
                    ScreenSnapshoot.PrimaryScreenSnapshoot.GetColor(e.X, e.Y)
                ));

            lastTimeRecorded = Environment.TickCount;

        }

        void mouseHook_MouseUp(object sender, MouseEventArgs e) {

            events.Add(
                new MacroEvent(
                    MacroEventType.MouseUp,
                    e,
                    Environment.TickCount - lastTimeRecorded,
                    ScreenSnapshoot.PrimaryScreenSnapshoot.GetColor(e.X, e.Y)
                ));

            lastTimeRecorded = Environment.TickCount;

        }

        void keyboardHook_KeyUp(object sender, KeyEventArgs e) {
            if (e.KeyCode == Keys.F4) {
                Stop();
            }
        }

        private void Start() {
            mouseHook.Start();
            keyboardHook.Start();
            Hide();
        }

        public void Stop() {
            mouseHook.Stop();
            keyboardHook.Stop(); 
            Show();
            BringToFront();
            try {
                MacroStorage.Save(events);
            } catch (Exception ex){
                MessageBox.Show("保存宏失败：" + ex.Message);
            }
        }
    }
}
