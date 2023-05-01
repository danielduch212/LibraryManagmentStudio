namespace LibraryManagementStudio.Worker.Views;

public static class ViewStyleHelper
{
    public static void MaximizeForm(Form form)
    {
        form.TopMost = true;
        form.WindowState = FormWindowState.Maximized;
    }

    public static void MaximizeUserControl(UserControl userControl)
    {
        userControl.Dock = DockStyle.Fill;
        userControl.AutoSize = default;
    }

    public static void AddControlToPanel(UserControl userControl, Panel panel)
    {
        panel.Controls.Clear();
        panel.Controls.Add(userControl);
    }
}