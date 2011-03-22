namespace JournalAnalyzer
{
    partial class AnalysisForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AnalysisForm));
            this.txtJournalFile = new System.Windows.Forms.TextBox();
            this.btnStartAnalysis = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTopCommands = new System.Windows.Forms.TextBox();
            this.txtTopShortcuts = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtShortcutsFile = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtJournalFile
            // 
            this.txtJournalFile.Location = new System.Drawing.Point(449, 85);
            this.txtJournalFile.Margin = new System.Windows.Forms.Padding(4);
            this.txtJournalFile.Name = "txtJournalFile";
            this.txtJournalFile.Size = new System.Drawing.Size(476, 26);
            this.txtJournalFile.TabIndex = 0;
            this.txtJournalFile.Text = "C:\\Program Files\\Autodesk\\Revit Structure 2011\\Journals\\";
            // 
            // btnStartAnalysis
            // 
            this.btnStartAnalysis.Location = new System.Drawing.Point(624, 182);
            this.btnStartAnalysis.Margin = new System.Windows.Forms.Padding(4);
            this.btnStartAnalysis.Name = "btnStartAnalysis";
            this.btnStartAnalysis.Size = new System.Drawing.Size(107, 26);
            this.btnStartAnalysis.TabIndex = 1;
            this.btnStartAnalysis.Text = "Analyze";
            this.btnStartAnalysis.UseVisualStyleBackColor = true;
            this.btnStartAnalysis.Click += new System.EventHandler(this.btnStartAnalysis_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(573, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(341, 37);
            this.label1.TabIndex = 2;
            this.label1.Text = "Journal File Analyzer";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(446, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 18);
            this.label2.TabIndex = 3;
            this.label2.Text = "Journal Directory:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtTopCommands);
            this.groupBox1.Controls.Add(this.txtTopShortcuts);
            this.groupBox1.Location = new System.Drawing.Point(12, 207);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1445, 533);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Command Analysis";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(943, 36);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(243, 18);
            this.label4.TabIndex = 6;
            this.label4.Text = "Top Commands Without Shortcuts";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(262, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(143, 18);
            this.label3.TabIndex = 5;
            this.label3.Text = "Top Shortcuts Used";
            // 
            // txtTopCommands
            // 
            this.txtTopCommands.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTopCommands.Location = new System.Drawing.Point(746, 57);
            this.txtTopCommands.Multiline = true;
            this.txtTopCommands.Name = "txtTopCommands";
            this.txtTopCommands.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtTopCommands.Size = new System.Drawing.Size(693, 437);
            this.txtTopCommands.TabIndex = 1;
            this.txtTopCommands.WordWrap = false;
            // 
            // txtTopShortcuts
            // 
            this.txtTopShortcuts.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTopShortcuts.Location = new System.Drawing.Point(11, 57);
            this.txtTopShortcuts.Multiline = true;
            this.txtTopShortcuts.Name = "txtTopShortcuts";
            this.txtTopShortcuts.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtTopShortcuts.Size = new System.Drawing.Size(723, 437);
            this.txtTopShortcuts.TabIndex = 0;
            this.txtTopShortcuts.WordWrap = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 769);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(317, 18);
            this.label5.TabIndex = 5;
            this.label5.Text = "By Rod Howarth - http://www.rodhowarth.com";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(446, 126);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(158, 18);
            this.label6.TabIndex = 8;
            this.label6.Text = "Current Shortcuts File";
            // 
            // txtShortcutsFile
            // 
            this.txtShortcutsFile.Location = new System.Drawing.Point(449, 148);
            this.txtShortcutsFile.Margin = new System.Windows.Forms.Padding(4);
            this.txtShortcutsFile.Name = "txtShortcutsFile";
            this.txtShortcutsFile.Size = new System.Drawing.Size(476, 26);
            this.txtShortcutsFile.TabIndex = 6;
            this.txtShortcutsFile.Text = "C:\\Program Files\\Autodesk\\Revit Structure 2011\\Journals\\";
            // 
            // AnalysisForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1486, 799);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtShortcutsFile);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnStartAnalysis);
            this.Controls.Add(this.txtJournalFile);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AnalysisForm";
            this.Text = "Journal Analyzer";
            this.Load += new System.EventHandler(this.AnalysisForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtJournalFile;
        private System.Windows.Forms.Button btnStartAnalysis;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtTopCommands;
        private System.Windows.Forms.TextBox txtTopShortcuts;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtShortcutsFile;
    }
}

