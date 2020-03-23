using System;
using System.Reflection;
using Microsoft.WindowsAPICodePack.Dialogs;

namespace AioiLight.PrincessTool
{
    internal static class Dialog
    {
        internal static string Folder(string def, IntPtr handle)
        {
            var dialog = new CommonOpenFileDialog();
            dialog.IsFolderPicker = true;
            dialog.DefaultDirectory = def;
            

            if (dialog.ShowDialog() == CommonFileDialogResult.Ok)
            {
                return dialog.FileName;
            }
            return null;
        }

        internal static void Error(string caption, string text, IntPtr handle)
        {
            var dialog = new TaskDialog();
            dialog.Icon = TaskDialogStandardIcon.Error;
            dialog.Text = text;
            dialog.InstructionText = caption;
            dialog.Caption = Assembly.GetExecutingAssembly().GetName().Name;

            dialog.OwnerWindowHandle = handle;

            dialog.Show();
        }
    }
}
