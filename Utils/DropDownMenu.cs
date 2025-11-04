using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;

namespace prj_LTTQ_BTL.Utils
{
    internal class DropDownMenu
    {
        public void HideSubMenu(Panel pnl)
        {
            pnl.Height = 0;
        }
        public void ShowSubMenu(Panel pnl, int number)
        {
            pnl.Height = pnl.Controls.OfType<Button>().Count() * number + 15;
        }
    }
}
