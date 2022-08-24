using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DarkControls
{
    public class DarkThemeMenuStrip : MenuStrip
    {
		public DarkThemeMenuStrip()
		{
			base.BackColor = Color.FromArgb(45, 45, 48);
			base.ForeColor = Color.White;
			base.RenderMode = ToolStripRenderMode.System;
			base.Renderer = new ToolStripProfessionalRenderer(new DarkColorTable());
		}
	}
}
