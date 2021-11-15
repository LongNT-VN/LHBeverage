using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LHBeverage.Helper
{
    public class AddNewPage
    {
        public static void addUserControl(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            // delete control.
            PublicParam.panelRoot.Controls.Clear();
            // create control new
            PublicParam.panelRoot.Controls.Add(userControl);
            userControl.BringToFront();
        }
    }
}
