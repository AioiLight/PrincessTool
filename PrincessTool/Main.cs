using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AioiLight.PrincessTool
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();

            var localDir = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
            var localLowDir = localDir += "Low";
            TextBox_Origin_Folder.Text = Path.Combine(localLowDir, @"Cygames\PrincessConnectReDive\");

            var appDir = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
            TextBox_Extract_Folder.Text = Path.Combine(appDir, @"dest\");
        }

        private void Button_Origin_Open_Click(object sender, EventArgs e)
        {
            var result = Dialog.Folder(TextBox_Origin_Folder.Text, Handle);
            if (result != null)
            {
                TextBox_Origin_Folder.Text = result;
            }
        }

        private void Button_Extract_Open_Click(object sender, EventArgs e)
        {
            var result = Dialog.Folder(TextBox_Extract_Folder.Text, Handle);
            if (result != null)
            {
                TextBox_Extract_Folder.Text = result;
            }
        }

        private void Button_Extract_Click(object sender, EventArgs e)
        {
            Program.Origin = TextBox_Origin_Folder.Text;
            Program.Dest = TextBox_Extract_Folder.Text;
            if (!Directory.Exists(Program.Origin))
            {
                Dialog.Error("Original directory is not found",
                    "Original directory is not found.\n" +
                    "Check path of directory.",
                    Handle);
            }

            Directory.CreateDirectory(Program.Dest);

            //new Works.FileCopy();

            if (CheckBox_Rename.Checked)
            {
                new Works.RenameHashedFile();
            }
            if (CheckBox_Convert_BGM.Checked)
            {
                new Works.ConvertSound("b", "Convert BGM audio");
            }

        }
    }
}
