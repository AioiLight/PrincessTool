namespace PrincessTool
{
    partial class Progress
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Label_Desc = new System.Windows.Forms.Label();
            this.Bar_Progress = new System.Windows.Forms.ProgressBar();
            this.SuspendLayout();
            // 
            // Label_Desc
            // 
            this.Label_Desc.AutoSize = true;
            this.Label_Desc.Location = new System.Drawing.Point(12, 9);
            this.Label_Desc.Name = "Label_Desc";
            this.Label_Desc.Size = new System.Drawing.Size(88, 20);
            this.Label_Desc.TabIndex = 0;
            this.Label_Desc.Text = "Progressing:";
            // 
            // Bar_Progress
            // 
            this.Bar_Progress.Location = new System.Drawing.Point(12, 43);
            this.Bar_Progress.Name = "Bar_Progress";
            this.Bar_Progress.Size = new System.Drawing.Size(360, 23);
            this.Bar_Progress.TabIndex = 1;
            // 
            // Progress
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 78);
            this.ControlBox = false;
            this.Controls.Add(this.Bar_Progress);
            this.Controls.Add(this.Label_Desc);
            this.Font = new System.Drawing.Font("メイリオ", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Progress";
            this.ShowInTaskbar = false;
            this.Text = "Progressing:";
            this.Load += new System.EventHandler(this.Progress_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Label_Desc;
        private System.Windows.Forms.ProgressBar Bar_Progress;
    }
}