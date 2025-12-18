using System.ComponentModel;

namespace DarkControls;

public class DarkThemeButton : Button
{
    private Color disabledForeColor = Color.Gray;

    private Color enabledForeColor = Color.White;

    [Description("The text color for disabled buttons")]
    [Category("Appearance")]
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
    public Color DisabledForeColor
    {
        get
        {
            return disabledForeColor;
        }
        set
        {
            disabledForeColor = value;
        }
    }

    [Description("The text color for enabled buttons")]
    [Category("Appearance")]
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
    public Color EnabledForeColor
    {
        get
        {
            return enabledForeColor;
        }
        set
        {
            enabledForeColor = value;
        }
    }

    public DarkThemeButton()
    {
        BackColor = Color.FromArgb(69, 69, 73);
        base.FlatStyle = FlatStyle.Flat;
        ForeColor = Color.White;
        base.FlatAppearance.BorderColor = Color.FromArgb(69, 69, 73);
    }

    protected override void OnPaint(PaintEventArgs pevent)
    {
        if (!base.DesignMode)
        {
            ForeColor = base.Enabled ? enabledForeColor : disabledForeColor;
            base.OnPaint(pevent);
            if (!base.Enabled)
            {
                TextRenderer.DrawText(pevent.Graphics, Text, Font, base.ClientRectangle, ForeColor);
            }
        }
        else
        {
            base.OnPaint(pevent);
        }
    }
}
