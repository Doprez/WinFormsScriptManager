namespace WindowsScriptExecutionManager
{
    partial class MainScriptForm
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
            this.AvailableScriptsComboBox = new System.Windows.Forms.ComboBox();
            this.RunScriptButton = new System.Windows.Forms.Button();
            this.AvailableScriptsLabel = new System.Windows.Forms.Label();
            this.EditScriptButton = new System.Windows.Forms.Button();
            this.NewScriptButton = new System.Windows.Forms.Button();
            this.OutputRichTextBox = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // AvailableScriptsComboBox
            // 
            this.AvailableScriptsComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AvailableScriptsComboBox.BackColor = System.Drawing.SystemColors.MenuText;
            this.AvailableScriptsComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AvailableScriptsComboBox.ForeColor = System.Drawing.Color.LimeGreen;
            this.AvailableScriptsComboBox.FormattingEnabled = true;
            this.AvailableScriptsComboBox.Location = new System.Drawing.Point(12, 45);
            this.AvailableScriptsComboBox.Name = "AvailableScriptsComboBox";
            this.AvailableScriptsComboBox.Size = new System.Drawing.Size(304, 23);
            this.AvailableScriptsComboBox.TabIndex = 0;
            this.AvailableScriptsComboBox.SelectedIndexChanged += new System.EventHandler(this.AvailableScriptsComboBox_SelectedIndexChanged);
            // 
            // RunScriptButton
            // 
            this.RunScriptButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.RunScriptButton.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.RunScriptButton.Location = new System.Drawing.Point(223, 83);
            this.RunScriptButton.Name = "RunScriptButton";
            this.RunScriptButton.Size = new System.Drawing.Size(93, 23);
            this.RunScriptButton.TabIndex = 1;
            this.RunScriptButton.Text = "Run Script";
            this.RunScriptButton.UseVisualStyleBackColor = false;
            this.RunScriptButton.Click += new System.EventHandler(this.RunScriptButton_Click);
            // 
            // AvailableScriptsLabel
            // 
            this.AvailableScriptsLabel.AutoSize = true;
            this.AvailableScriptsLabel.Location = new System.Drawing.Point(12, 27);
            this.AvailableScriptsLabel.Name = "AvailableScriptsLabel";
            this.AvailableScriptsLabel.Size = new System.Drawing.Size(93, 15);
            this.AvailableScriptsLabel.TabIndex = 2;
            this.AvailableScriptsLabel.Text = "Available Scripts";
            // 
            // EditScriptButton
            // 
            this.EditScriptButton.Location = new System.Drawing.Point(12, 83);
            this.EditScriptButton.Name = "EditScriptButton";
            this.EditScriptButton.Size = new System.Drawing.Size(93, 23);
            this.EditScriptButton.TabIndex = 3;
            this.EditScriptButton.Text = "Edit Script";
            this.EditScriptButton.UseVisualStyleBackColor = true;
            this.EditScriptButton.Click += new System.EventHandler(this.EditScriptButton_Click);
            // 
            // NewScriptButton
            // 
            this.NewScriptButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.NewScriptButton.Location = new System.Drawing.Point(121, 83);
            this.NewScriptButton.Name = "NewScriptButton";
            this.NewScriptButton.Size = new System.Drawing.Size(87, 23);
            this.NewScriptButton.TabIndex = 4;
            this.NewScriptButton.Text = "New Script";
            this.NewScriptButton.UseVisualStyleBackColor = true;
            this.NewScriptButton.Click += new System.EventHandler(this.NewScriptButton_Click);
            // 
            // OutputRichTextBox
            // 
            this.OutputRichTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.OutputRichTextBox.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.OutputRichTextBox.ForeColor = System.Drawing.Color.Lime;
            this.OutputRichTextBox.Location = new System.Drawing.Point(12, 112);
            this.OutputRichTextBox.Name = "OutputRichTextBox";
            this.OutputRichTextBox.Size = new System.Drawing.Size(304, 372);
            this.OutputRichTextBox.TabIndex = 5;
            this.OutputRichTextBox.Text = "";
            // 
            // MainScriptForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(328, 496);
            this.Controls.Add(this.OutputRichTextBox);
            this.Controls.Add(this.NewScriptButton);
            this.Controls.Add(this.EditScriptButton);
            this.Controls.Add(this.AvailableScriptsLabel);
            this.Controls.Add(this.RunScriptButton);
            this.Controls.Add(this.AvailableScriptsComboBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MinimumSize = new System.Drawing.Size(343, 534);
            this.Name = "MainScriptForm";
            this.Text = "Script Runner";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComboBox AvailableScriptsComboBox;
        private Button RunScriptButton;
        private Label AvailableScriptsLabel;
        private Button EditScriptButton;
        private Button NewScriptButton;
        private RichTextBox OutputRichTextBox;
    }
}