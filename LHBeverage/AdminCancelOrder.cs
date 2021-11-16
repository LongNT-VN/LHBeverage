using LHBeverage.Model;
using LHBeverage.ModelService;
using LHBeverage.UserControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LHBeverage
{
    public partial class AdminCancelOrder : Form
    {
        Order tmp;
        Boolean isadmin;
        public AdminCancelOrder(Order order, Boolean isAdmin=false)
        {
            InitializeComponent();
            tmp = order;
            isadmin = isAdmin;
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Submit_Click(object sender, EventArgs e)
        {
            if(Reason_tb.Text == null)
            {
                MessageBox.Show("Please add reason cancel order");
            }
            else
            {
                try
                {
                    tmp.Status = "Cancelled";
                    tmp.Reason = Reason_tb.Text;
                    OrderConnect.UpdateReasonOrder(tmp, Reason_tb.Text, "Cancelled");
                   // AdminManageOrder.instance.initOrders();
                    if(isadmin)
                    {
                        AdminDetailOrder.instance.initDetailOrder(tmp);
                    }
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
    }
}
