using System;
using System.Windows.Forms;

namespace AioiLight.PrincessTool
{
    public partial class Progress : Form
    {
        public Progress(string caption, int maxProg, Action<IProgress<int>> task)
        {
            InitializeComponent();
            MaxValue = maxProg;

            Bar_Progress.Maximum = MaxValue;
            Bar_Progress.Minimum = 0;

            Task = task;

            Text = $"Progressing: {caption}";
            Label_Desc.Text = $"Progressing: {caption}";

            ShowDialog(Program.MainWindow);
        }

        private int MaxValue { get; set; }
        private Action<IProgress<int>> Task { get; set; }

        private void Progress_Load(object sender, EventArgs e)
        {
            StartTask();
        }

        private async void StartTask()
        {
            var prog = new Progress<int>(TickBar);

            var task = System.Threading.Tasks.Task.Run(() => { Task(prog); });

            await task;

            Close();
        }

        private void TickBar(int value)
        {
            Bar_Progress.Value = value;
        }
    }
}
