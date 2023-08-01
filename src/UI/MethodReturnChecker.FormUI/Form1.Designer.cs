namespace MethodReturnChecker.FormUI
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            folderBrowserDialog1 = new FolderBrowserDialog();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            folderPathTextBox = new TextBox();
            rjButton1 = new RJButton();
            splitContainer1 = new SplitContainer();
            label1 = new Label();
            label2 = new Label();
            dataGridView1 = new DataGridView();
            progressBar1 = new ProgressBar();
            refreshButton = new RJButton();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // folderPathTextBox
            // 
            folderPathTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            folderPathTextBox.BackColor = Color.FromArgb(82, 87, 93);
            folderPathTextBox.BorderStyle = BorderStyle.None;
            folderPathTextBox.ForeColor = Color.FromArgb(246, 244, 230);
            folderPathTextBox.Location = new Point(12, 36);
            folderPathTextBox.Multiline = true;
            folderPathTextBox.Name = "folderPathTextBox";
            folderPathTextBox.Size = new Size(623, 29);
            folderPathTextBox.TabIndex = 17;
            // 
            // rjButton1
            // 
            rjButton1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            rjButton1.BackColor = Color.FromArgb(251, 195, 78);
            rjButton1.BackgroundColor = Color.FromArgb(251, 195, 78);
            rjButton1.BorderColor = Color.PaleVioletRed;
            rjButton1.BorderRadius = 10;
            rjButton1.BorderSize = 0;
            rjButton1.FlatAppearance.BorderSize = 0;
            rjButton1.FlatStyle = FlatStyle.Flat;
            rjButton1.Font = new Font("Segoe UI Emoji", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            rjButton1.ForeColor = Color.White;
            rjButton1.Location = new Point(665, 36);
            rjButton1.Name = "rjButton1";
            rjButton1.Size = new Size(123, 27);
            rjButton1.TabIndex = 21;
            rjButton1.Text = "Klasör Seç";
            rjButton1.TextColor = Color.White;
            rjButton1.UseVisualStyleBackColor = false;
            rjButton1.Click += selectFolderButton_Click;
            // 
            // splitContainer1
            // 
            splitContainer1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            splitContainer1.Location = new Point(12, 116);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.AutoScroll = true;
            splitContainer1.Panel1.BackColor = Color.FromArgb(251, 195, 78);
            splitContainer1.Panel1.Controls.Add(label1);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.AutoScroll = true;
            splitContainer1.Panel2.BackColor = Color.SlateGray;
            splitContainer1.Panel2.Controls.Add(label2);
            splitContainer1.Size = new Size(776, 46);
            splitContainer1.SplitterDistance = 393;
            splitContainer1.TabIndex = 26;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Emoji", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(121, 15);
            label1.Name = "label1";
            label1.Size = new Size(160, 17);
            label1.TabIndex = 0;
            label1.Text = "Bulunan Method Sayısı";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.ForeColor = Color.White;
            label2.Location = new Point(177, 13);
            label2.Name = "label2";
            label2.Size = new Size(17, 20);
            label2.TabIndex = 1;
            label2.Text = "0";
            // 
            // dataGridView1
            // 
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BackgroundColor = Color.FromArgb(82, 87, 93);
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 182);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(776, 321);
            dataGridView1.TabIndex = 25;
            // 
            // progressBar1
            // 
            progressBar1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            progressBar1.Location = new Point(12, 72);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(623, 23);
            progressBar1.TabIndex = 27;
            progressBar1.Visible = false;
            // 
            // refreshButton
            // 
            refreshButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            refreshButton.BackColor = Color.FromArgb(251, 195, 78);
            refreshButton.BackgroundColor = Color.FromArgb(251, 195, 78);
            refreshButton.BorderColor = Color.PaleVioletRed;
            refreshButton.BorderRadius = 10;
            refreshButton.BorderSize = 0;
            refreshButton.FlatAppearance.BorderSize = 0;
            refreshButton.FlatStyle = FlatStyle.Flat;
            refreshButton.Font = new Font("Segoe UI Emoji", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            refreshButton.ForeColor = Color.White;
            refreshButton.Location = new Point(665, 68);
            refreshButton.Name = "refreshButton";
            refreshButton.Size = new Size(123, 27);
            refreshButton.TabIndex = 28;
            refreshButton.Text = "Yenile";
            refreshButton.TextColor = Color.White;
            refreshButton.UseVisualStyleBackColor = false;
            refreshButton.Click += refreshButton_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(65, 68, 75);
            ClientSize = new Size(814, 530);
            Controls.Add(refreshButton);
            Controls.Add(progressBar1);
            Controls.Add(splitContainer1);
            Controls.Add(dataGridView1);
            Controls.Add(rjButton1);
            Controls.Add(folderPathTextBox);
            Font = new Font("Segoe UI Emoji", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            ForeColor = Color.Black;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Method Return Checker";
            Load += Form1_Load;
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel1.PerformLayout();
            splitContainer1.Panel2.ResumeLayout(false);
            splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private FolderBrowserDialog folderBrowserDialog1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private TextBox folderPathTextBox;
        private RJButton rjButton1;
        private SplitContainer splitContainer1;
        private Label label1;
        private Label label2;
        private DataGridView dataGridView1;
        private ProgressBar progressBar1;
        private RJButton refreshButton;
    }
}