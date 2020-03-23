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
            this.GroupBox_Options.Controls.Add(this.CheckBox_Rename);
            this.GroupBox_Options.Location = new System.Drawing.Point(12, 47);
            this.GroupBox_Options.Name = "GroupBox_Options";
            this.GroupBox_Options.Size = new System.Drawing.Size(560, 130);
            this.GroupBox_Options.TabIndex = 3;
            this.GroupBox_Options.TabStop = false;
            this.GroupBox_Options.Text = "Extract options:";
            // 
            // checkBox1
            // 
            this.CheckBox_Rename.AutoSize = true;
            this.CheckBox_Rename.Location = new System.Drawing.Point(6, 26);
            this.CheckBox_Rename.Name = "checkBox1";
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
    }
}

