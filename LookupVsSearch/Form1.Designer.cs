namespace LookupVsSearch
{
    partial class MainForm
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
            this.fileLocationLabel = new System.Windows.Forms.Label();
            this.dataFilePathTextBox = new System.Windows.Forms.TextBox();
            this.browseButton = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.panel1 = new System.Windows.Forms.Panel();
            this.searchData1Button = new System.Windows.Forms.Button();
            this.loadData1Button = new System.Windows.Forms.Button();
            this.search1Label = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.searchData2Button = new System.Windows.Forms.Button();
            this.loadData2Button = new System.Windows.Forms.Button();
            this.search2Label = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.searchData3Button = new System.Windows.Forms.Button();
            this.loadData3Button = new System.Windows.Forms.Button();
            this.search3Label = new System.Windows.Forms.Label();
            this.searchLogGroupBox = new System.Windows.Forms.GroupBox();
            this.searchLogTextBox = new System.Windows.Forms.TextBox();
            this.searchTermLabel = new System.Windows.Forms.Label();
            this.searchTermTextBox = new System.Windows.Forms.TextBox();
            this.copyLogToClipboardButton = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.searchLogGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // fileLocationLabel
            // 
            this.fileLocationLabel.AutoSize = true;
            this.fileLocationLabel.Location = new System.Drawing.Point(11, 14);
            this.fileLocationLabel.Name = "fileLocationLabel";
            this.fileLocationLabel.Size = new System.Drawing.Size(52, 13);
            this.fileLocationLabel.TabIndex = 0;
            this.fileLocationLabel.Text = "Data File:";
            // 
            // dataFilePathTextBox
            // 
            this.dataFilePathTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataFilePathTextBox.Location = new System.Drawing.Point(69, 11);
            this.dataFilePathTextBox.Name = "dataFilePathTextBox";
            this.dataFilePathTextBox.Size = new System.Drawing.Size(376, 20);
            this.dataFilePathTextBox.TabIndex = 1;
            // 
            // browseButton
            // 
            this.browseButton.Location = new System.Drawing.Point(451, 9);
            this.browseButton.Name = "browseButton";
            this.browseButton.Size = new System.Drawing.Size(75, 23);
            this.browseButton.TabIndex = 2;
            this.browseButton.Text = "Browse";
            this.browseButton.UseVisualStyleBackColor = true;
            this.browseButton.Click += new System.EventHandler(this.browseButton_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.Filter = "CSV Files (*.csv)|*.csv|All Files (*.*)|*.*";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.searchData1Button);
            this.panel1.Controls.Add(this.loadData1Button);
            this.panel1.Controls.Add(this.search1Label);
            this.panel1.Location = new System.Drawing.Point(14, 83);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(119, 150);
            this.panel1.TabIndex = 3;
            // 
            // searchData1Button
            // 
            this.searchData1Button.Enabled = false;
            this.searchData1Button.Location = new System.Drawing.Point(15, 95);
            this.searchData1Button.Name = "searchData1Button";
            this.searchData1Button.Size = new System.Drawing.Size(86, 23);
            this.searchData1Button.TabIndex = 2;
            this.searchData1Button.Text = "Search Data 1";
            this.searchData1Button.UseVisualStyleBackColor = true;
            this.searchData1Button.Click += new System.EventHandler(this.searchData1Button_Click);
            // 
            // loadData1Button
            // 
            this.loadData1Button.Location = new System.Drawing.Point(15, 59);
            this.loadData1Button.Name = "loadData1Button";
            this.loadData1Button.Size = new System.Drawing.Size(86, 23);
            this.loadData1Button.TabIndex = 1;
            this.loadData1Button.Text = "Load Data 1";
            this.loadData1Button.UseVisualStyleBackColor = true;
            this.loadData1Button.Click += new System.EventHandler(this.loadData1Button_Click);
            // 
            // search1Label
            // 
            this.search1Label.AutoSize = true;
            this.search1Label.Location = new System.Drawing.Point(28, 16);
            this.search1Label.Name = "search1Label";
            this.search1Label.Size = new System.Drawing.Size(50, 13);
            this.search1Label.TabIndex = 0;
            this.search1Label.Text = "Search 1";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.searchData2Button);
            this.panel2.Controls.Add(this.loadData2Button);
            this.panel2.Controls.Add(this.search2Label);
            this.panel2.Location = new System.Drawing.Point(200, 83);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(119, 150);
            this.panel2.TabIndex = 4;
            // 
            // searchData2Button
            // 
            this.searchData2Button.Enabled = false;
            this.searchData2Button.Location = new System.Drawing.Point(15, 95);
            this.searchData2Button.Name = "searchData2Button";
            this.searchData2Button.Size = new System.Drawing.Size(84, 23);
            this.searchData2Button.TabIndex = 2;
            this.searchData2Button.Text = "Search Data 2";
            this.searchData2Button.UseVisualStyleBackColor = true;
            this.searchData2Button.Click += new System.EventHandler(this.searchData2Button_Click);
            // 
            // loadData2Button
            // 
            this.loadData2Button.Location = new System.Drawing.Point(15, 59);
            this.loadData2Button.Name = "loadData2Button";
            this.loadData2Button.Size = new System.Drawing.Size(84, 23);
            this.loadData2Button.TabIndex = 1;
            this.loadData2Button.Text = "Load Data 2";
            this.loadData2Button.UseVisualStyleBackColor = true;
            this.loadData2Button.Click += new System.EventHandler(this.loadData2Button_Click);
            // 
            // search2Label
            // 
            this.search2Label.AutoSize = true;
            this.search2Label.Location = new System.Drawing.Point(28, 16);
            this.search2Label.Name = "search2Label";
            this.search2Label.Size = new System.Drawing.Size(50, 13);
            this.search2Label.TabIndex = 0;
            this.search2Label.Text = "Search 2";
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.searchData3Button);
            this.panel3.Controls.Add(this.loadData3Button);
            this.panel3.Controls.Add(this.search3Label);
            this.panel3.Location = new System.Drawing.Point(389, 83);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(119, 150);
            this.panel3.TabIndex = 5;
            // 
            // searchData3Button
            // 
            this.searchData3Button.Enabled = false;
            this.searchData3Button.Location = new System.Drawing.Point(15, 95);
            this.searchData3Button.Name = "searchData3Button";
            this.searchData3Button.Size = new System.Drawing.Size(84, 23);
            this.searchData3Button.TabIndex = 2;
            this.searchData3Button.Text = "Search Data 3";
            this.searchData3Button.UseVisualStyleBackColor = true;
            this.searchData3Button.Click += new System.EventHandler(this.searchData3Button_Click);
            // 
            // loadData3Button
            // 
            this.loadData3Button.Location = new System.Drawing.Point(15, 59);
            this.loadData3Button.Name = "loadData3Button";
            this.loadData3Button.Size = new System.Drawing.Size(84, 23);
            this.loadData3Button.TabIndex = 1;
            this.loadData3Button.Text = "Load Data 3";
            this.loadData3Button.UseVisualStyleBackColor = true;
            this.loadData3Button.Click += new System.EventHandler(this.loadData3Button_Click);
            // 
            // search3Label
            // 
            this.search3Label.AutoSize = true;
            this.search3Label.Location = new System.Drawing.Point(28, 16);
            this.search3Label.Name = "search3Label";
            this.search3Label.Size = new System.Drawing.Size(50, 13);
            this.search3Label.TabIndex = 0;
            this.search3Label.Text = "Search 3";
            // 
            // searchLogGroupBox
            // 
            this.searchLogGroupBox.Controls.Add(this.searchLogTextBox);
            this.searchLogGroupBox.Location = new System.Drawing.Point(14, 268);
            this.searchLogGroupBox.Name = "searchLogGroupBox";
            this.searchLogGroupBox.Size = new System.Drawing.Size(512, 199);
            this.searchLogGroupBox.TabIndex = 7;
            this.searchLogGroupBox.TabStop = false;
            this.searchLogGroupBox.Text = "Search Log";
            // 
            // searchLogTextBox
            // 
            this.searchLogTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.searchLogTextBox.Location = new System.Drawing.Point(3, 16);
            this.searchLogTextBox.Multiline = true;
            this.searchLogTextBox.Name = "searchLogTextBox";
            this.searchLogTextBox.Size = new System.Drawing.Size(506, 180);
            this.searchLogTextBox.TabIndex = 0;
            // 
            // searchTermLabel
            // 
            this.searchTermLabel.AutoSize = true;
            this.searchTermLabel.Location = new System.Drawing.Point(48, 41);
            this.searchTermLabel.Name = "searchTermLabel";
            this.searchTermLabel.Size = new System.Drawing.Size(59, 13);
            this.searchTermLabel.TabIndex = 8;
            this.searchTermLabel.Text = "Search For";
            // 
            // searchTermTextBox
            // 
            this.searchTermTextBox.Location = new System.Drawing.Point(113, 38);
            this.searchTermTextBox.Name = "searchTermTextBox";
            this.searchTermTextBox.Size = new System.Drawing.Size(376, 20);
            this.searchTermTextBox.TabIndex = 9;
            // 
            // copyLogToClipboardButton
            // 
            this.copyLogToClipboardButton.Location = new System.Drawing.Point(17, 239);
            this.copyLogToClipboardButton.Name = "copyLogToClipboardButton";
            this.copyLogToClipboardButton.Size = new System.Drawing.Size(116, 23);
            this.copyLogToClipboardButton.TabIndex = 10;
            this.copyLogToClipboardButton.Text = "Copy to Clipboard";
            this.copyLogToClipboardButton.UseVisualStyleBackColor = true;
            this.copyLogToClipboardButton.Click += new System.EventHandler(this.copyLogToClipboardButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(545, 479);
            this.Controls.Add(this.copyLogToClipboardButton);
            this.Controls.Add(this.searchTermTextBox);
            this.Controls.Add(this.searchTermLabel);
            this.Controls.Add(this.searchLogGroupBox);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.browseButton);
            this.Controls.Add(this.dataFilePathTextBox);
            this.Controls.Add(this.fileLocationLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.Text = "Lookup Vs Search Demonstration";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.searchLogGroupBox.ResumeLayout(false);
            this.searchLogGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label fileLocationLabel;
        private System.Windows.Forms.TextBox dataFilePathTextBox;
        private System.Windows.Forms.Button browseButton;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button searchData1Button;
        private System.Windows.Forms.Button loadData1Button;
        private System.Windows.Forms.Label search1Label;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button searchData2Button;
        private System.Windows.Forms.Button loadData2Button;
        private System.Windows.Forms.Label search2Label;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button searchData3Button;
        private System.Windows.Forms.Button loadData3Button;
        private System.Windows.Forms.Label search3Label;
        private System.Windows.Forms.GroupBox searchLogGroupBox;
        private System.Windows.Forms.TextBox searchLogTextBox;
        private System.Windows.Forms.Label searchTermLabel;
        private System.Windows.Forms.TextBox searchTermTextBox;
        private System.Windows.Forms.Button copyLogToClipboardButton;
    }
}

