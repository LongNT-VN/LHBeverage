using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LHBeverage.Helper
{
    class SetMode
    {
        public static void SetModeFunc(UserControl userControl, Panel panel, Color Backcolor, Color Forecolor, Color SpecialBackcolor, Color SpecialForecolor, Color BackcolorUsercontrol)
        {
            if (userControl != null)
            {
                userControl.BackColor = BackcolorUsercontrol;
                userControl.ForeColor = Forecolor;
                foreach (Control selected in userControl.Controls)
                {
                    if (selected is Button)
                    {
                        selected.BackColor = SpecialBackcolor;
                        selected.ForeColor = SpecialForecolor;
                    }
                    else
                    {
                        if (selected is Label)
                        {
                            selected.ForeColor = Forecolor;
                        }
                        else
                        {
                            selected.BackColor = Backcolor;
                            selected.ForeColor = Forecolor;
                            foreach (Control selected2 in selected.Controls)
                            {
                                if (selected2 is Button)
                                {
                                    selected2.BackColor = SpecialBackcolor;
                                    selected2.ForeColor = SpecialForecolor;
                                }
                                else if (selected2 is Label)
                                {
                                    selected2.ForeColor = Forecolor;
                                }
                                else
                                {
                                    selected2.BackColor = Backcolor;
                                    selected2.ForeColor = Forecolor;
                                    foreach (Control selected3 in selected2.Controls)
                                    {
                                        if (selected3 is Button)
                                        {
                                            selected3.BackColor = SpecialBackcolor;
                                            selected3.ForeColor = SpecialForecolor;
                                        }
                                        else if (selected2 is Label)
                                        {
                                            selected2.ForeColor = Forecolor;
                                        }
                                    }
                                }

                            }
                        }

                    }
                }
            }
            if (panel != null)
            {
                panel.BackColor = Backcolor;
                panel.ForeColor = Forecolor;
                foreach (Control selected in panel.Controls)
                {
                    if (selected is Panel)
                    {
                        selected.BackColor = Backcolor;
                        selected.ForeColor = Forecolor;
                    }
                }
            }
        }
    }
}
