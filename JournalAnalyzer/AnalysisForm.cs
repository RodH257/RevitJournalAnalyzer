using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace JournalAnalyzer
{
    /// <summary>
    /// Author: Rod Howarth http://www.rodhowarth.com 
    /// </summary>
    public partial class AnalysisForm : Form
    {
        public AnalysisForm()
        {
            InitializeComponent();
        }

        private void btnStartAnalysis_Click(object sender, EventArgs e)
        {
            KeyboardShortcutAnalyzer analyzer = new KeyboardShortcutAnalyzer(this.txtJournalFile.Text, this.txtShortcutsFile.Text);

            IEnumerable<string> topShortcuts = analyzer.GetTopShortcutsUsed();
            IEnumerable<string> topCommands = analyzer.GetTopRibbonCommandsUsed(this.chkbIncludeContext.Checked);

            string outputMessage = "";
            foreach (string shortcut in topShortcuts)
            {
                outputMessage += shortcut + Environment.NewLine;
            }
            this.txtTopShortcuts.Text = outputMessage;

            outputMessage = "";
            foreach (string shortcut in topCommands)
            {
                outputMessage += shortcut + Environment.NewLine;
            }
            this.txtTopCommands.Text = outputMessage;
        }

        private void AnalysisForm_Load(object sender, EventArgs e)
        {
            string currentKeyboard = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
            currentKeyboard += @"\Autodesk\Revit\Autodesk Revit Structure 2011" + @"\KeyboardShortcuts.xml";
            this.txtShortcutsFile.Text = currentKeyboard;
        }
    }
}
