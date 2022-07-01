namespace UserInterface
{
    partial class ControlPanel
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.ControlsGroupBox = new System.Windows.Forms.GroupBox();
            this.ShowEncryptionKey = new System.Windows.Forms.CheckBox();
            this.EncryptionKeyInput = new System.Windows.Forms.TextBox();
            this.SelectedFilesGroupBox = new System.Windows.Forms.GroupBox();
            this.DeleteFilesButton = new System.Windows.Forms.Button();
            this.OverrideCheckbox = new System.Windows.Forms.CheckBox();
            this.DownloadFilesButton = new System.Windows.Forms.Button();
            this.DecryptButton = new System.Windows.Forms.Button();
            this.EncryptButton = new System.Windows.Forms.Button();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.FileList = new System.Windows.Forms.CheckedListBox();
            this.FIleMenuPanel = new System.Windows.Forms.Panel();
            this.AddFilesButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.ControlsGroupBox.SuspendLayout();
            this.SelectedFilesGroupBox.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.FIleMenuPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(this.ControlsGroupBox, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.SelectedFilesGroupBox, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(822, 473);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // ControlsGroupBox
            // 
            this.ControlsGroupBox.Controls.Add(this.ShowEncryptionKey);
            this.ControlsGroupBox.Controls.Add(this.EncryptionKeyInput);
            this.ControlsGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ControlsGroupBox.ForeColor = System.Drawing.Color.White;
            this.ControlsGroupBox.Location = new System.Drawing.Point(3, 3);
            this.ControlsGroupBox.Name = "ControlsGroupBox";
            this.ControlsGroupBox.Size = new System.Drawing.Size(183, 467);
            this.ControlsGroupBox.TabIndex = 0;
            this.ControlsGroupBox.TabStop = false;
            this.ControlsGroupBox.Text = "Controls";
            // 
            // ShowEncryptionKey
            // 
            this.ShowEncryptionKey.AutoSize = true;
            this.ShowEncryptionKey.Location = new System.Drawing.Point(9, 51);
            this.ShowEncryptionKey.Name = "ShowEncryptionKey";
            this.ShowEncryptionKey.Size = new System.Drawing.Size(77, 19);
            this.ShowEncryptionKey.TabIndex = 1;
            this.ShowEncryptionKey.Text = "Show Key";
            this.ShowEncryptionKey.UseVisualStyleBackColor = true;
            this.ShowEncryptionKey.CheckedChanged += new System.EventHandler(this.ShowEncryptionKey_CheckedChanged);
            // 
            // EncryptionKeyInput
            // 
            this.EncryptionKeyInput.BackColor = System.Drawing.Color.White;
            this.EncryptionKeyInput.ForeColor = System.Drawing.Color.Black;
            this.EncryptionKeyInput.HideSelection = false;
            this.EncryptionKeyInput.Location = new System.Drawing.Point(9, 22);
            this.EncryptionKeyInput.Name = "EncryptionKeyInput";
            this.EncryptionKeyInput.PlaceholderText = "Encryption Key";
            this.EncryptionKeyInput.Size = new System.Drawing.Size(168, 23);
            this.EncryptionKeyInput.TabIndex = 0;
            this.EncryptionKeyInput.UseSystemPasswordChar = true;
            this.EncryptionKeyInput.WordWrap = false;
            // 
            // SelectedFilesGroupBox
            // 
            this.SelectedFilesGroupBox.Controls.Add(this.DeleteFilesButton);
            this.SelectedFilesGroupBox.Controls.Add(this.OverrideCheckbox);
            this.SelectedFilesGroupBox.Controls.Add(this.DownloadFilesButton);
            this.SelectedFilesGroupBox.Controls.Add(this.DecryptButton);
            this.SelectedFilesGroupBox.Controls.Add(this.EncryptButton);
            this.SelectedFilesGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SelectedFilesGroupBox.ForeColor = System.Drawing.Color.White;
            this.SelectedFilesGroupBox.Location = new System.Drawing.Point(619, 3);
            this.SelectedFilesGroupBox.Name = "SelectedFilesGroupBox";
            this.SelectedFilesGroupBox.Size = new System.Drawing.Size(200, 467);
            this.SelectedFilesGroupBox.TabIndex = 1;
            this.SelectedFilesGroupBox.TabStop = false;
            this.SelectedFilesGroupBox.Text = "Selected Files";
            // 
            // DeleteFilesButton
            // 
            this.DeleteFilesButton.ForeColor = System.Drawing.Color.Black;
            this.DeleteFilesButton.Location = new System.Drawing.Point(6, 435);
            this.DeleteFilesButton.Name = "DeleteFilesButton";
            this.DeleteFilesButton.Size = new System.Drawing.Size(188, 23);
            this.DeleteFilesButton.TabIndex = 6;
            this.DeleteFilesButton.Text = "Delete Selected Files";
            this.DeleteFilesButton.UseVisualStyleBackColor = true;
            this.DeleteFilesButton.Click += new System.EventHandler(this.DeleteFilesButton_Click);
            // 
            // OverrideCheckbox
            // 
            this.OverrideCheckbox.AutoSize = true;
            this.OverrideCheckbox.Checked = true;
            this.OverrideCheckbox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.OverrideCheckbox.Location = new System.Drawing.Point(6, 138);
            this.OverrideCheckbox.Name = "OverrideCheckbox";
            this.OverrideCheckbox.Size = new System.Drawing.Size(141, 19);
            this.OverrideCheckbox.TabIndex = 5;
            this.OverrideCheckbox.Text = "Override Existing Files";
            this.OverrideCheckbox.UseVisualStyleBackColor = true;
            // 
            // DownloadFilesButton
            // 
            this.DownloadFilesButton.ForeColor = System.Drawing.Color.Black;
            this.DownloadFilesButton.Location = new System.Drawing.Point(6, 109);
            this.DownloadFilesButton.Name = "DownloadFilesButton";
            this.DownloadFilesButton.Size = new System.Drawing.Size(188, 23);
            this.DownloadFilesButton.TabIndex = 4;
            this.DownloadFilesButton.Text = "Download Selected Files";
            this.DownloadFilesButton.UseVisualStyleBackColor = true;
            this.DownloadFilesButton.Click += new System.EventHandler(this.DownloadFilesButton_Click);
            // 
            // DecryptButton
            // 
            this.DecryptButton.BackColor = System.Drawing.Color.Transparent;
            this.DecryptButton.ForeColor = System.Drawing.Color.Black;
            this.DecryptButton.Location = new System.Drawing.Point(6, 51);
            this.DecryptButton.Name = "DecryptButton";
            this.DecryptButton.Size = new System.Drawing.Size(188, 23);
            this.DecryptButton.TabIndex = 3;
            this.DecryptButton.Text = "Decrypt";
            this.DecryptButton.UseVisualStyleBackColor = false;
            this.DecryptButton.Click += new System.EventHandler(this.DecryptButton_Click);
            // 
            // EncryptButton
            // 
            this.EncryptButton.BackColor = System.Drawing.Color.Transparent;
            this.EncryptButton.ForeColor = System.Drawing.Color.Black;
            this.EncryptButton.Location = new System.Drawing.Point(6, 21);
            this.EncryptButton.Name = "EncryptButton";
            this.EncryptButton.Size = new System.Drawing.Size(188, 23);
            this.EncryptButton.TabIndex = 2;
            this.EncryptButton.Text = "Encrypt";
            this.EncryptButton.UseVisualStyleBackColor = false;
            this.EncryptButton.Click += new System.EventHandler(this.EncryptButton_Click);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.FileList, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.FIleMenuPanel, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.label1, 0, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(192, 3);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(421, 470);
            this.tableLayoutPanel2.TabIndex = 2;
            // 
            // FileList
            // 
            this.FileList.AllowDrop = true;
            this.FileList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.FileList.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.FileList.CausesValidation = false;
            this.FileList.CheckOnClick = true;
            this.FileList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FileList.ForeColor = System.Drawing.Color.White;
            this.FileList.FormattingEnabled = true;
            this.FileList.Location = new System.Drawing.Point(3, 53);
            this.FileList.Name = "FileList";
            this.FileList.Size = new System.Drawing.Size(415, 414);
            this.FileList.Sorted = true;
            this.FileList.TabIndex = 4;
            this.FileList.SelectedIndexChanged += new System.EventHandler(this.FileList_SelectedIndexChanged);
            // 
            // FIleMenuPanel
            // 
            this.FIleMenuPanel.AutoSize = true;
            this.FIleMenuPanel.Controls.Add(this.AddFilesButton);
            this.FIleMenuPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FIleMenuPanel.Location = new System.Drawing.Point(3, 3);
            this.FIleMenuPanel.Name = "FIleMenuPanel";
            this.FIleMenuPanel.Size = new System.Drawing.Size(415, 29);
            this.FIleMenuPanel.TabIndex = 5;
            // 
            // AddFilesButton
            // 
            this.AddFilesButton.Location = new System.Drawing.Point(3, 3);
            this.AddFilesButton.Name = "AddFilesButton";
            this.AddFilesButton.Size = new System.Drawing.Size(75, 23);
            this.AddFilesButton.TabIndex = 0;
            this.AddFilesButton.Text = "Add File";
            this.AddFilesButton.UseVisualStyleBackColor = true;
            this.AddFilesButton.Click += new System.EventHandler(this.AddFilesButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Left;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(3, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 15);
            this.label1.TabIndex = 6;
            this.label1.Text = "Files in your Lockbox:";
            // 
            // ControlPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(822, 473);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "ControlPanel";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Lockbox";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ControlsGroupBox.ResumeLayout(false);
            this.ControlsGroupBox.PerformLayout();
            this.SelectedFilesGroupBox.ResumeLayout(false);
            this.SelectedFilesGroupBox.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.FIleMenuPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private GroupBox ControlsGroupBox;
        private TextBox EncryptionKeyInput;
        private CheckBox ShowEncryptionKey;
        private Button EncryptButton;
        private Button DecryptButton;
        private GroupBox SelectedFilesGroupBox;
        private TableLayoutPanel tableLayoutPanel2;
        private CheckedListBox FileList;
        private Panel FIleMenuPanel;
        private Button AddFilesButton;
        private Button DownloadFilesButton;
        private CheckBox OverrideCheckbox;
        private Button DeleteFilesButton;
        private Label label1;
    }
}