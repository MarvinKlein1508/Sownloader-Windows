using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DarkControls
{
    public class DarkThemeTextBox : TextBox
    {
        public DarkThemeTextBox()
        {
            BackColor = Color.FromArgb(61, 61, 65);
            base.BorderStyle = BorderStyle.FixedSingle;
            ForeColor = Color.White;
            Font = new Font("Consolas", 12f);
        }
    }
}
