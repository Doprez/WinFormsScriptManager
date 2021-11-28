using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsScriptExecutionManager.Controllers;
using WindowsScriptExecutionManager.Models;
using WindowsScriptExecutionManager.Views.Utils;

namespace WindowsScriptExecutionManager.Views
{
    public partial class ScriptEditorForm : Form
    {
        private readonly ScriptController _scriptController = new ScriptController();

        public string? FilePath;
        public ScriptModel CurrentScript = new ScriptModel();

        public ScriptEditorForm()
        {
            InitializeComponent();
            LoadScript();
        }

        public ScriptEditorForm(ScriptModel filePath)
        {
            InitializeComponent();
            LoadScript(filePath.FilePath);
        }

        private void SaveScript()
        {
            
            SaveFileForm saveFileForm = new SaveFileForm(CurrentScript);
            var result = saveFileForm.ShowDialog();

            if (result == DialogResult.OK)
            {
                _scriptController.SaveScript(new ScriptModel
                {
                    FilePath = saveFileForm.script.FilePath,
                    Contents = ScriptRichTextBox.Text,
                });
            }

        }

        private void LoadScript(string filePath = "")
        {
            FilePath = filePath;
            if (!string.IsNullOrWhiteSpace(FilePath))
            {
                CurrentScript = _scriptController.GetScript(filePath);
                ScriptRichTextBox.Text = CurrentScript.Contents;
            }
        }

        private void SaveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveScript();
        }

        private void OpenToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }


    }
}
