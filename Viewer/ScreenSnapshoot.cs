using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Viewer {
    public class ScreenSnapshoot {

        [DllImport("user32.dll", CharSet = CharSet.Auto,
           CallingConvention = CallingConvention.StdCall, SetLastError = true)]
        static extern IntPtr GetDC(IntPtr hwnd);

        [DllImport("user32.dll", CharSet = CharSet.Auto,
           CallingConvention = CallingConvention.StdCall, SetLastError = true)]
        static extern Int32 ReleaseDC(IntPtr hwnd, IntPtr hdc);

        [DllImport("gdi32.dll", CharSet = CharSet.Auto,
           CallingConvention = CallingConvention.StdCall, SetLastError = true)]
        static extern int GetPixel(IntPtr hdc, int nXPos, int nYPos);

        private Screen m_screen;

        public ScreenSnapshoot(Screen screen) {
            m_screen = screen;
        }

        public Color GetColor(int x, int y) {
            IntPtr hdc = GetDC(IntPtr.Zero);
            var pixel = GetPixel(hdc, Cursor.Position.X, Cursor.Position.Y);
            ReleaseDC(IntPtr.Zero, hdc);
            var color = Color.FromArgb((pixel & 0x000000FF), (pixel & 0x0000FF00) >> 8, (pixel & 0x00FF0000) >> 16);

            return color;

            //using (var snapshoot = new Bitmap(m_screen.Bounds.Width, m_screen.Bounds.Height, PixelFormat.Format32bppArgb)) {
            //    using (var g = Graphics.FromImage(snapshoot)) {
            //        g.CopyFromScreen(m_screen.Bounds.Left, m_screen.Bounds.Top, 0, 0, m_screen.Bounds.Size);
            //        return snapshoot.GetPixel(x, y);
            //    }
            //}
        }

        private static ScreenSnapshoot s_primaryScreenSnapshoot;

        public static ScreenSnapshoot PrimaryScreenSnapshoot {
            get {
                if (s_primaryScreenSnapshoot == null){
                    s_primaryScreenSnapshoot = new ScreenSnapshoot(Screen.PrimaryScreen);
                }
                return s_primaryScreenSnapshoot;
            }
        }
    }
}
