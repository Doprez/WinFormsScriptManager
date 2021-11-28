using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsScriptExecutionManager.Models;
using WindowsScriptExecutionManager.Utils;

namespace WindowsScriptExecutionManager.Views.Utils
{
    public partial class SaveFileForm : Form
    {
        public ScriptModel script = new ScriptModel();

        public SaveFileForm(ScriptModel scriptInfo)
        {
            InitializeComponent();
            UpdateFlowPanel(scriptInfo.FilePath);
            UpdateDirectoryTreeView();
            script = scriptInfo;
        }

        private void UpdateDirectoryTreeView(string currentDirectory = "")
        {
            DirectoryTreeView.Nodes.Clear();

            var directories = DirectoryHelper.GetDirectories(currentDirectory);

            foreach (var directory in directories)
            {
                DirectoryTreeView.Nodes.Add(new TreeNode
                {
                    Text = directory.Name,
                    Tag = directory.FullName,
                    Name = directory.Name,
                    ToolTipText = directory.FullName,
                });

                DirectoryTreeView.Click += new EventHandler(DirectoryTreeView_Click);
            }

        }

        private void UpdateFlowPanel(string filePath)
        {
            FilesFlowLayoutPanel.Controls.Clear();
            var path = Path.GetDirectoryName(filePath);
            if (path == null)
            {
                return;
            }

            var files = Directory.GetFiles(path);

            foreach (var file in files)
            {
                Button newFileButton = new Button();
                newFileButton.Name = file.Replace(path + "\\", "");
                newFileButton.Text = file.Replace(path + "\\", "");
                newFileButton.Tag = file;
                newFileButton.ClientSize = new Size(130,130);
                newFileButton.TextAlign = ContentAlignment.BottomCenter;
                newFileButton.TextImageRelation = TextImageRelation.ImageAboveText;
                newFileButton.Image = Image.FromFile(@"Resources\Images\Icons\icons8-file-96.png");
                newFileButton.UseVisualStyleBackColor = false;
                newFileButton.FlatAppearance.BorderSize = 0;
                newFileButton.FlatStyle = FlatStyle.Flat;
                newFileButton.Margin = new Padding(2);
                newFileButton.Click += new EventHandler(NewFileButton_Click);
                FilesFlowLayoutPanel.Controls.Add(newFileButton);
            }
        }

        private void NewFileButton_Click(object sender, EventArgs e)
        {
            var button = (Button)sender;
            CurrentDirectoryTextBox.Text = (string)button.Tag;
            FileNameTextBox.Text = button.Text;
        }

        private void DirectoryTreeView_Click(object sender, EventArgs e)
        {
            var node = DirectoryTreeView.SelectedNode;

            if (node == null) { return; }

            UpdateDirectoryTreeView((string)node.Tag);

        }

        private void RefreshButton_Click(object sender, EventArgs e)
        {

            UpdateFlowPanel(CurrentDirectoryTextBox.Text);
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(CurrentDirectoryTextBox.Text)) { return; }
            script.FilePath = Path.GetDirectoryName(CurrentDirectoryTextBox.Text) + "\\" + FileNameTextBox.Text;
            script.Name = FileNameTextBox.Text;
            DialogResult = DialogResult.OK;
            Close();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
