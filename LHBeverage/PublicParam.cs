using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LHBeverage
{
    public class PublicParam
    {
        public static Panel panelRoot { get; set; } = new Panel();
        public static DataTable dataTableImgPro { get; set; } = new DataTable();
    }
}
