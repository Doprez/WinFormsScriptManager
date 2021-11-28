using WindowsScriptExecutionManager.Controllers;
using WindowsScriptExecutionManager.Models;
using WindowsScriptExecutionManager.Views;

namespace WindowsScriptExecutionManager
{
    public partial class MainScriptForm : Form
    {

        private readonly ScriptController _scriptController = new ScriptController();

        public MainScriptForm()
        {
            InitializeComponent();
            LoadData();
        }

        private void LoadData()
        {
            AvailableScriptsComboBox.Items.Clear();
            AvailableScriptsComboBox.Items.AddRange(_scriptController.GetScripts().ToArray());
            AvailableScriptsComboBox.DisplayMember = "Name";
        }

        private void AvailableScriptsComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            //maybe do something 
        }

        private void NewScriptButton_Click(object sender, EventArgs e)
        {
            ScriptEditorForm scriptEditor = new ScriptEditorForm();
            scriptEditor.ShowDialog();
            LoadData();
        }

        private void EditScriptButton_Click(object sender, EventArgs e)
        {
            if (AvailableScriptsComboBox.SelectedItem != null)
            {
                ScriptEditorForm scriptEditor = new ScriptEditorForm((ScriptModel)AvailableScriptsComboBox.SelectedItem);
                scriptEditor.ShowDialog();
                LoadData();
            }
        }

        private void RunScriptButton_Click(object sender, EventArgs e)
        {
            if (AvailableScriptsComboBox.SelectedItem != null)
            {
                ScriptModel script = (ScriptModel)AvailableScriptsComboBox.SelectedItem;

                ProcessOutputModel output = _scriptController.RunScript("PowerShell.exe", "powershell -ExecutionPolicy ByPass -File " + script.FilePath);

                OutputRichTextBox.Text = output.Output;
            }
        }
    }
}