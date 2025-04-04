using System.Windows;
using System.Windows.Interop;
using Application = System.Windows.Application;

namespace QuadSpinner.Adjunct.WPF
{
    public static class TD
    {
        internal static int Show(
            string caption,
            string heading,
            string text,
            string footnote,
            TaskDialogIcon icon,
            bool addCancel,
            params string[] buttons)
        {
            var tdbc = new TaskDialogButtonCollection();

            for (int i = 0; i < buttons.Length; i++)
            {
                tdbc.Add(new TaskDialogButton(buttons[i]));
            }

            if (addCancel)
            {
                tdbc.Add(TaskDialogButton.Cancel);
            }

            var r = Show(caption, heading, text, footnote, icon, null, tdbc);
            return Array.IndexOf(tdbc.ToArray(), tdbc.First(x => x.Text == r.Text));
        }

        internal static TaskDialogButton Show(
            string caption,
            string heading,
            string text,
            string footnote,
            TaskDialogIcon icon,
            TaskDialogButton defaultButton,
            TaskDialogButtonCollection buttons)
        {
            TaskDialogPage tdp = new()
            {
                Caption = caption,
                Heading = heading,
                Text = text,
                Footnote = !string.IsNullOrEmpty(footnote)
                    ? new TaskDialogFootnote(footnote) { Icon = TaskDialogIcon.Warning }
                    : null,
                Icon = icon,
                AllowCancel = true,
                Buttons = buttons,
                EnableLinks = true,
                DefaultButton = defaultButton
            };

            tdp.LinkClicked += (_, e) => WPF.OpenLink(e.LinkHref);

            return TaskDialog.ShowDialog(new WindowInteropHelper(Application.Current.Windows.OfType<Window>().FirstOrDefault(w => w.IsActive)).Handle, tdp);
        }

        internal static TaskDialogButton YesNo(
            string caption,
            string heading,
            string text,
            string footnote,
            TaskDialogIcon icon,
            TaskDialogButton defaultButton)
        {
            return Show(caption, heading, text, footnote, icon, defaultButton, [TaskDialogButton.Yes, TaskDialogButton.No]);
        }

        internal static TaskDialogButton OkCancel(
            string caption,
            string heading,
            string text,
            string footnote,
            TaskDialogIcon icon,
            TaskDialogButton defaultButton)
        {
            return Show(caption, heading, text, footnote, icon, defaultButton, [TaskDialogButton.OK, TaskDialogButton.Cancel]);
        }

        internal static TaskDialogButton Ok(
            string caption,
            string heading,
            string text,
            string footnote = "")
        {
            return Show(caption, heading, text, footnote, TaskDialogIcon.Information, null, [TaskDialogButton.Close]);
        }
    }
}