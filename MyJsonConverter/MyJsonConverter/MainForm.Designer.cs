namespace MyJsonConverter
{
    partial class MainForm
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.DeleteButton = new System.Windows.Forms.Button();
            this.FilePathLabel = new System.Windows.Forms.Label();
            this.NewFileLabel = new System.Windows.Forms.Label();
            this.FilePathTextBox = new System.Windows.Forms.TextBox();
            this.NewFIleTextBox = new System.Windows.Forms.TextBox();
            this.CovertButton = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            this.AddFileButton = new System.Windows.Forms.Button();
            this.MakingCheck = new System.Windows.Forms.CheckBox();
            this.FindButton = new System.Windows.Forms.Button();
            this.MyText = new System.Windows.Forms.TextBox();
            this.DirectoryButton = new System.Windows.Forms.Button();
            this.ResultTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // DeleteButton
            // 
            this.DeleteButton.Location = new System.Drawing.Point(673, 8);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(85, 26);
            this.DeleteButton.TabIndex = 3;
            this.DeleteButton.Text = "제거";
            this.DeleteButton.UseVisualStyleBackColor = true;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // FilePathLabel
            // 
            this.FilePathLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.FilePathLabel.AutoSize = true;
            this.FilePathLabel.Font = new System.Drawing.Font("굴림체", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.FilePathLabel.Location = new System.Drawing.Point(7, 16);
            this.FilePathLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.FilePathLabel.Name = "FilePathLabel";
            this.FilePathLabel.Size = new System.Drawing.Size(105, 14);
            this.FilePathLabel.TabIndex = 0;
            this.FilePathLabel.Text = "변환할 파일 : ";
            // 
            // NewFileLabel
            // 
            this.NewFileLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.NewFileLabel.AutoSize = true;
            this.NewFileLabel.Font = new System.Drawing.Font("굴림체", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.NewFileLabel.Location = new System.Drawing.Point(362, 16);
            this.NewFileLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.NewFileLabel.Name = "NewFileLabel";
            this.NewFileLabel.Size = new System.Drawing.Size(91, 14);
            this.NewFileLabel.TabIndex = 1;
            this.NewFileLabel.Text = "새 파일 이름";
            // 
            // FilePathTextBox
            // 
            this.FilePathTextBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.FilePathTextBox.Location = new System.Drawing.Point(116, 10);
            this.FilePathTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.FilePathTextBox.Name = "FilePathTextBox";
            this.FilePathTextBox.ReadOnly = true;
            this.FilePathTextBox.Size = new System.Drawing.Size(242, 26);
            this.FilePathTextBox.TabIndex = 2;
            // 
            // NewFIleTextBox
            // 
            this.NewFIleTextBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.NewFIleTextBox.Location = new System.Drawing.Point(457, 10);
            this.NewFIleTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.NewFIleTextBox.Name = "NewFIleTextBox";
            this.NewFIleTextBox.Size = new System.Drawing.Size(115, 26);
            this.NewFIleTextBox.TabIndex = 2;
            // 
            // CovertButton
            // 
            this.CovertButton.Font = new System.Drawing.Font("굴림체", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.CovertButton.Location = new System.Drawing.Point(641, 430);
            this.CovertButton.Margin = new System.Windows.Forms.Padding(2);
            this.CovertButton.Name = "CovertButton";
            this.CovertButton.Size = new System.Drawing.Size(119, 48);
            this.CovertButton.TabIndex = 3;
            this.CovertButton.Text = "변환";
            this.CovertButton.UseVisualStyleBackColor = true;
            this.CovertButton.Click += new System.EventHandler(this.CovertButton_Click);
            // 
            // ExitButton
            // 
            this.ExitButton.Font = new System.Drawing.Font("굴림체", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.ExitButton.Location = new System.Drawing.Point(764, 430);
            this.ExitButton.Margin = new System.Windows.Forms.Padding(2);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(110, 48);
            this.ExitButton.TabIndex = 0;
            this.ExitButton.Text = "종료";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // AddFileButton
            // 
            this.AddFileButton.Location = new System.Drawing.Point(10, 51);
            this.AddFileButton.Name = "AddFileButton";
            this.AddFileButton.Size = new System.Drawing.Size(171, 31);
            this.AddFileButton.TabIndex = 4;
            this.AddFileButton.Text = "추가";
            this.AddFileButton.UseVisualStyleBackColor = true;
            this.AddFileButton.Click += new System.EventHandler(this.AddFileButton_Click);
            // 
            // MakingCheck
            // 
            this.MakingCheck.AutoSize = true;
            this.MakingCheck.Location = new System.Drawing.Point(764, 13);
            this.MakingCheck.Name = "MakingCheck";
            this.MakingCheck.Size = new System.Drawing.Size(84, 21);
            this.MakingCheck.TabIndex = 6;
            this.MakingCheck.Text = "cs생성";
            this.MakingCheck.UseVisualStyleBackColor = true;
            // 
            // FindButton
            // 
            this.FindButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FindButton.Location = new System.Drawing.Point(577, 8);
            this.FindButton.Name = "FindButton";
            this.FindButton.Size = new System.Drawing.Size(90, 26);
            this.FindButton.TabIndex = 7;
            this.FindButton.Text = "찾기";
            this.FindButton.UseVisualStyleBackColor = true;
            this.FindButton.Click += new System.EventHandler(this.FindPathButton_Click);
            // 
            // MyText
            // 
            this.MyText.Enabled = false;
            this.MyText.Location = new System.Drawing.Point(12, 444);
            this.MyText.Name = "MyText";
            this.MyText.Size = new System.Drawing.Size(176, 26);
            this.MyText.TabIndex = 8;
            this.MyText.Text = "만든이 : 김은규";
            this.MyText.TextChanged += new System.EventHandler(this.MyText_TextChanged);
            // 
            // DirectoryButton
            // 
            this.DirectoryButton.Location = new System.Drawing.Point(188, 51);
            this.DirectoryButton.Name = "DirectoryButton";
            this.DirectoryButton.Size = new System.Drawing.Size(170, 31);
            this.DirectoryButton.TabIndex = 9;
            this.DirectoryButton.Text = "파일 위치 열기";
            this.DirectoryButton.UseVisualStyleBackColor = true;
            this.DirectoryButton.Click += new System.EventHandler(this.DirectoryButton_click);
            // 
            // ResultTextBox
            // 
            this.ResultTextBox.Enabled = false;
            this.ResultTextBox.Font = new System.Drawing.Font("굴림체", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.ResultTextBox.Location = new System.Drawing.Point(12, 408);
            this.ResultTextBox.Name = "ResultTextBox";
            this.ResultTextBox.Size = new System.Drawing.Size(346, 30);
            this.ResultTextBox.TabIndex = 10;
            this.ResultTextBox.Text = "변환 준비중....";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.Cornsilk;
            this.ClientSize = new System.Drawing.Size(884, 488);
            this.Controls.Add(this.ResultTextBox);
            this.Controls.Add(this.DirectoryButton);
            this.Controls.Add(this.MyText);
            this.Controls.Add(this.FindButton);
            this.Controls.Add(this.MakingCheck);
            this.Controls.Add(this.CovertButton);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.AddFileButton);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.NewFIleTextBox);
            this.Controls.Add(this.FilePathLabel);
            this.Controls.Add(this.FilePathTextBox);
            this.Controls.Add(this.NewFileLabel);
            this.Font = new System.Drawing.Font("굴림체", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Padding = new System.Windows.Forms.Padding(8);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ExcelToJsonConverter";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox FilePathTextBox;
        private System.Windows.Forms.TextBox NewFIleTextBox;
        private System.Windows.Forms.Button CovertButton;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.Button AddFileButton;
        private System.Windows.Forms.CheckBox MakingCheck;
        private System.Windows.Forms.Button FindButton;
        private System.Windows.Forms.Button DeleteButton;
        public System.Windows.Forms.Label NewFileLabel;
        private System.Windows.Forms.TextBox MyText;
        private System.Windows.Forms.Label FilePathLabel;
        private System.Windows.Forms.Button DirectoryButton;
        private System.Windows.Forms.TextBox ResultTextBox;
    }
}

