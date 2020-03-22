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

namespace PrincessTool
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
            TextBox_Extact_Folder.Text = Path.Combine(appDir, @"dest\");

        }
    }
}
