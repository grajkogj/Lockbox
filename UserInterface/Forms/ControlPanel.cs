namespace UserInterface
{
    public partial class ControlPanel : Form
    {
        public ControlPanel()
        {
            InitializeComponent();

            FileManager.UpdateFiles();
            for(int i = 0; i < FileManager.Files.Length; i++)
            {
                FileList.Items.Add(FileManager.Files[i].Substring(15));
            }
        }

        private void ShowEncryptionKey_CheckedChanged(object sender, EventArgs e)
        {
            EncryptionKeyInput.UseSystemPasswordChar = !ShowEncryptionKey.Checked;
        }

        private void EncryptButton_Click(object sender, EventArgs e)
        {
            if (EncryptionKeyInput.Text == "") return;

            FileManager.UpdateFiles();
            for (int i = 0; i < FileManager.SelectedFiles.Count; i++)
            {
                DLLImports.EncryptFile(FileManager.SelectedFiles[i], EncryptionKeyInput.Text);
            }
        }

        private void DecryptButton_Click(object sender, EventArgs e)
        {
            if (EncryptionKeyInput.Text == "") return;

            FileManager.UpdateFiles();
            for (int i = 0; i < FileManager.SelectedFiles.Count; i++)
            {
                DLLImports.DecryptFile(FileManager.SelectedFiles[i], EncryptionKeyInput.Text);
            }
        }

        private void AddFilesButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog fd = new OpenFileDialog();

            if(fd.ShowDialog() == DialogResult.OK)
            {
                string dest = @".\LockboxFiles\";
                string sFile = fd.FileName;

                string[] sFileNameSplit = sFile.Split("\\");
                string sFileName = sFileNameSplit[sFileNameSplit.Length - 1];

                System.IO.Directory.CreateDirectory(dest);  //just in case LockboxFiles dosent exist for some reason

                System.IO.File.Copy(sFile, dest + sFileName, true);

                FileManager.UpdateFiles();
                FileList.Items.Clear();
                for (int i = 0; i < FileManager.Files.Length; i++)
                {
                    FileList.Items.Add(FileManager.Files[i].Substring(15));
                }
            }
        }

        private void FileList_SelectedIndexChanged(object sender, EventArgs e)
        {
            FileManager.SelectedFiles.Clear();
            for(int i = 0; i < FileList.CheckedItems.Count; i++)
            {
                FileManager.SelectedFiles.Add(".\\LockboxFiles\\" + FileList.CheckedItems[i].ToString());
            }
        }

        private void DownloadFilesButton_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fd = new FolderBrowserDialog();

            if(fd.ShowDialog() == DialogResult.OK)
            {
                string targetDir = fd.SelectedPath;

                for (int i = 0; i < FileManager.SelectedFiles.Count; i++)
                {
                    string[] nFileNameSplit = FileManager.SelectedFiles[i].Split("\\");
                    string nFileName = nFileNameSplit[nFileNameSplit.Length - 1];

                    System.IO.File.Copy(FileManager.SelectedFiles[i], targetDir + "\\" + nFileName, OverrideCheckbox.Checked);
                }
            }
        }

        private void DeleteFilesButton_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < FileManager.SelectedFiles.Count; i++)
            {
                System.IO.File.Delete(FileManager.SelectedFiles[i]);
            }

            FileManager.SelectedFiles.Clear();
            FileManager.UpdateFiles();

            //refreshes the file list in the form
            FileList.Items.Clear();
            for (int i = 0; i < FileManager.Files.Length; i++)
            {
                FileList.Items.Add(FileManager.Files[i].Substring(15));
            }
        }
    }
}