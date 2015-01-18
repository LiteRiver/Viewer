using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Viewer {
    public class ToolStripAddress : ToolStripTextBox {
        public override Size GetPreferredSize(System.Drawing.Size constrainingSize) {
            if (IsOnOverflow || Owner.Orientation == Orientation.Vertical) {
                return DefaultSize;
            }

            Int32 width = Owner.DisplayRectangle.Width;

            if (Owner.OverflowButton.Visible) {
                width = width - Owner.OverflowButton.Width -
                    Owner.OverflowButton.Margin.Horizontal;
            }

            Int32 addressBoxCount = 0;

            foreach (ToolStripItem item in Owner.Items) {
                if (item.IsOnOverflow) continue;

                if (item is ToolStripAddress) {
                    addressBoxCount++;
                    width -= item.Margin.Horizontal;
                } else {
                    width = width - item.Width - item.Margin.Horizontal;
                }
            }

            if (addressBoxCount > 1) width /= addressBoxCount;


            if (width < DefaultSize.Width) width = DefaultSize.Width;

            Size size = base.GetPreferredSize(constrainingSize);
            size.Width = width;
            return size;
        }
    }
}
