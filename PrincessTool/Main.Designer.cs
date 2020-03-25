namespace AioiLight.PrincessTool
{
    partial class Main
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.Button_Origin_Open = new System.Windows.Forms.Button();
            this.TextBox_Origin_Folder = new System.Windows.Forms.TextBox();
            this.Label_Origin_Text = new System.Windows.Forms.Label();
            this.GroupBox_Options = new System.Windows.Forms.GroupBox();
            this.CheckBox_Rename = new System.Windows.Forms.CheckBox();
            this.Button_Extract = new System.Windows.Forms.Button();
            this.Label_Extract_Text = new System.Windows.Forms.Label();
            this.TextBox_Extract_Folder = new System.Windows.Forms.TextBox();
            this.Button_Extract_Open = new System.Windows.Forms.Button();
            this.CheckBox_Convert_Voice = new System.Windows.Forms.CheckBox();
            this.CheckBox_Convert_SE = new System.Windows.Forms.CheckBox();
            this.CheckBox_Convert_BGM = new System.Windows.Forms.CheckBox();
            this.GroupBox_Options.SuspendLayout();
            this.SuspendLayout();
            // 
            // Button_Origin_Open
            // 
            this.Button_Origin_Open.Location = new System.Drawing.Point(480, 12);
            this.Button_Origin_Open.Name = "Button_Origin_Open";
            this.Button_Origin_Open.Size = new System.Drawing.Size(92, 30);
            this.Button_Origin_Open.TabIndex = 0;
            this.Button_Origin_Open.Text = "Open...";
            this.Button_Origin_Open.UseVisualStyleBackColor = true;
            this.Button_Origin_Open.Click += new System.EventHandler(this.Button_Origin_Open_Click);
            // 
            // TextBox_Origin_Folder
            // 
            this.TextBox_Origin_Folder.Location = new System.Drawing.Point(135, 14);
            this.TextBox_Origin_Folder.Name = "TextBox_Origin_Folder";
            this.TextBox_Origin_Folder.ReadOnly = true;
            this.TextBox_Origin_Folder.Size = new System.Drawing.Size(339, 27);
            this.TextBox_Origin_Folder.TabIndex = 1;
            // 
            // Label_Origin_Text
            // 
            this.Label_Origin_Text.AutoSize = true;
            this.Label_Origin_Text.Location = new System.Drawing.Point(12, 17);
            this.Label_Origin_Text.Name = "Label_Origin_Text";
            this.Label_Origin_Text.Size = new System.Drawing.Size(117, 20);
            this.Label_Origin_Text.TabIndex = 2;
            this.Label_Origin_Text.Text = "Origin resources:";
            // 
            // GroupBox_Options
            // 
            this.GroupBox_Options.Controls.Add(this.CheckBox_Convert_BGM);
            this.GroupBox_Options.Controls.Add(this.CheckBox_Convert_SE);
            this.GroupBox_Options.Controls.Add(this.CheckBox_Convert_Voice);
            this.GroupBox_Options.Controls.Add(this.CheckBox_Rename);
            this.GroupBox_Options.Location = new System.Drawing.Point(12, 47);
            this.GroupBox_Options.Name = "GroupBox_Options";
            this.GroupBox_Options.Size = new System.Drawing.Size(560, 130);
            this.GroupBox_Options.TabIndex = 3;
            this.GroupBox_Options.TabStop = false;
            this.GroupBox_Options.Text = "Extract options:";
            // 
            // CheckBox_Rename
            // 
            this.CheckBox_Rename.AutoSize = true;
            this.CheckBox_Rename.Location = new System.Drawing.Point(6, 26);
            this.CheckBox_Rename.Name = "CheckBox_Rename";
            this.CheckBox_Rename.Size = new System.Drawing.Size(192, 24);
            this.CheckBox_Rename.TabIndex = 0;
            this.CheckBox_Rename.Text = "Rename Hashed filename";
            this.CheckBox_Rename.UseVisualStyleBackColor = true;
            // 
            // Button_Extract
            // 
            this.Button_Extract.Font = new System.Drawing.Font("メイリオ", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Button_Extract.Location = new System.Drawing.Point(452, 206);
            this.Button_Extract.Name = "Button_Extract";
            this.Button_Extract.Size = new System.Drawing.Size(120, 40);
            this.Button_Extract.TabIndex = 4;
            this.Button_Extract.Text = "Extract";
            this.Button_Extract.UseVisualStyleBackColor = true;
            this.Button_Extract.Click += new System.EventHandler(this.Button_Extract_Click);
            // 
            // Label_Extract_Text
            // 
            this.Label_Extract_Text.AutoSize = true;
            this.Label_Extract_Text.Location = new System.Drawing.Point(12, 222);
            this.Label_Extract_Text.Name = "Label_Extract_Text";
            this.Label_Extract_Text.Size = new System.Drawing.Size(64, 20);
            this.Label_Extract_Text.TabIndex = 5;
            this.Label_Extract_Text.Text = "Dest dir:";
            // 
            // TextBox_Extract_Folder
            // 
            this.TextBox_Extract_Folder.Location = new System.Drawing.Point(82, 219);
            this.TextBox_Extract_Folder.Name = "TextBox_Extract_Folder";
            this.TextBox_Extract_Folder.ReadOnly = true;
            this.TextBox_Extract_Folder.Size = new System.Drawing.Size(364, 27);
            this.TextBox_Extract_Folder.TabIndex = 6;
            // 
            // Button_Extract_Open
            // 
            this.Button_Extract_Open.Location = new System.Drawing.Point(354, 183);
            this.Button_Extract_Open.Name = "Button_Extract_Open";
            this.Button_Extract_Open.Size = new System.Drawing.Size(92, 30);
            this.Button_Extract_Open.TabIndex = 7;
            this.Button_Extract_Open.Text = "Open...";
            this.Button_Extract_Open.UseVisualStyleBackColor = true;
            this.Button_Extract_Open.Click += new System.EventHandler(this.Button_Extract_Open_Click);
            // 
            // CheckBox_Convert_Voice
            // 
            this.CheckBox_Convert_Voice.AutoSize = true;
            this.CheckBox_Convert_Voice.Location = new System.Drawing.Point(232, 26);
            this.CheckBox_Convert_Voice.Name = "CheckBox_Convert_Voice";
            this.CheckBox_Convert_Voice.Size = new System.Drawing.Size(224, 24);
            this.CheckBox_Convert_Voice.TabIndex = 1;
            this.CheckBox_Convert_Voice.Text = "Convert voice audio file (.wav)";
            this.CheckBox_Convert_Voice.UseVisualStyleBackColor = true;
            // 
            // CheckBox_Convert_SE
            // 
            this.CheckBox_Convert_SE.AutoSize = true;
            this.CheckBox_Convert_SE.Location = new System.Drawing.Point(6, 86);
            this.CheckBox_Convert_SE.Name = "CheckBox_Convert_SE";
            this.CheckBox_Convert_SE.Size = new System.Drawing.Size(207, 24);
            this.CheckBox_Convert_SE.TabIndex = 2;
            this.CheckBox_Convert_SE.Text = "Convert SE audio file (.wav)";
            this.CheckBox_Convert_SE.UseVisualStyleBackColor = true;
            // 
            // CheckBox_Convert_BGM
            // 
            this.CheckBox_Convert_BGM.AutoSize = true;
            this.CheckBox_Convert_BGM.Location = new System.Drawing.Point(6, 56);
            this.CheckBox_Convert_BGM.Name = "CheckBox_Convert_BGM";
            this.CheckBox_Convert_BGM.Size = new System.Drawing.Size(220, 24);
            this.CheckBox_Convert_BGM.TabIndex = 3;
            this.CheckBox_Convert_BGM.Text = "Convert BGM audio file (.wav)";
            this.CheckBox_Convert_BGM.UseVisualStyleBackColor = true;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 258);
            this.Controls.Add(this.Button_Extract_Open);
            this.Controls.Add(this.TextBox_Extract_Folder);
            this.Controls.Add(this.Label_Extract_Text);
            this.Controls.Add(this.Button_Extract);
            this.Controls.Add(this.GroupBox_Options);
            this.Controls.Add(this.Label_Origin_Text);
            this.Controls.Add(this.Button_Origin_Open);
            this.Controls.Add(this.TextBox_Origin_Folder);
            this.Font = new System.Drawing.Font("メイリオ", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Main";
            this.Text = "PrincessTool";
            this.GroupBox_Options.ResumeLayout(false);
            this.GroupBox_Options.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Button_Origin_Open;
        private System.Windows.Forms.TextBox TextBox_Origin_Folder;
        private System.Windows.Forms.Label Label_Origin_Text;
        private System.Windows.Forms.GroupBox GroupBox_Options;
        private System.Windows.Forms.CheckBox CheckBox_Rename;
        private System.Windows.Forms.Button Button_Extract;
        private System.Windows.Forms.Label Label_Extract_Text;
        private System.Windows.Forms.TextBox TextBox_Extract_Folder;
        private System.Windows.Forms.Button Button_Extract_Open;
        private System.Windows.Forms.CheckBox CheckBox_Convert_BGM;
        private System.Windows.Forms.CheckBox CheckBox_Convert_SE;
        private System.Windows.Forms.CheckBox CheckBox_Convert_Voice;
    }
}

