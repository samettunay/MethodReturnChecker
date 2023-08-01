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
            pictureBox1 = new PictureBox();
            rjButton1 = new RJButton();
            closeButton = new RJButton();
            minimizedButton = new RJButton();
            titleLabel = new Label();
            splitContainer1 = new SplitContainer();
            label1 = new Label();
            label2 = new Label();
            dataGridView1 = new DataGridView();
            progressBar1 = new ProgressBar();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // folderPathTextBox
            // 
            folderPathTextBox.BackColor = Color.FromArgb(82, 87, 93);
            folderPathTextBox.BorderStyle = BorderStyle.None;
            folderPathTextBox.ForeColor = Color.FromArgb(246, 244, 230);
            folderPathTextBox.Location = new Point(12, 78);
            folderPathTextBox.Multiline = true;
            folderPathTextBox.Name = "folderPathTextBox";
            folderPathTextBox.Size = new Size(623, 29);
            folderPathTextBox.TabIndex = 17;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImageLayout = ImageLayout.Center;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(7, 6);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(37, 29);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 20;
            pictureBox1.TabStop = false;
            // 
            // rjButton1
            // 
            rjButton1.BackColor = Color.FromArgb(251, 195, 78);
            rjButton1.BackgroundColor = Color.FromArgb(251, 195, 78);
            rjButton1.BorderColor = Color.PaleVioletRed;
            rjButton1.BorderRadius = 10;
            rjButton1.BorderSize = 0;
            rjButton1.FlatAppearance.BorderSize = 0;
            rjButton1.FlatStyle = FlatStyle.Flat;
            rjButton1.Font = new Font("Segoe UI Emoji", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            rjButton1.ForeColor = Color.White;
            rjButton1.Location = new Point(665, 78);
            rjButton1.Name = "rjButton1";
            rjButton1.Size = new Size(123, 27);
            rjButton1.TabIndex = 21;
            rjButton1.Text = "Klasör Seç";
            rjButton1.TextColor = Color.White;
            rjButton1.UseVisualStyleBackColor = false;
            rjButton1.Click += selectFolderButton_Click;
            // 
            // closeButton
            // 
            closeButton.BackColor = Color.Crimson;
            closeButton.BackgroundColor = Color.Crimson;
            closeButton.BorderColor = Color.PaleVioletRed;
            closeButton.BorderRadius = 11;
            closeButton.BorderSize = 0;
            closeButton.FlatAppearance.BorderSize = 0;
            closeButton.FlatStyle = FlatStyle.Flat;
            closeButton.ForeColor = Color.White;
            closeButton.Location = new Point(784, 6);
            closeButton.Name = "closeButton";
            closeButton.Size = new Size(22, 21);
            closeButton.TabIndex = 22;
            closeButton.TextColor = Color.White;
            closeButton.UseVisualStyleBackColor = false;
            closeButton.Click += closeButton_Click;
            // 
            // minimizedButton
            // 
            minimizedButton.BackColor = Color.Gold;
            minimizedButton.BackgroundColor = Color.Gold;
            minimizedButton.BorderColor = Color.PaleVioletRed;
            minimizedButton.BorderRadius = 11;
            minimizedButton.BorderSize = 0;
            minimizedButton.FlatAppearance.BorderSize = 0;
            minimizedButton.FlatStyle = FlatStyle.Flat;
            minimizedButton.ForeColor = Color.White;
            minimizedButton.Location = new Point(757, 6);
            minimizedButton.Name = "minimizedButton";
            minimizedButton.Size = new Size(22, 21);
            minimizedButton.TabIndex = 23;
            minimizedButton.TextColor = Color.White;
            minimizedButton.UseVisualStyleBackColor = false;
            minimizedButton.Click += minimizedButton_Click;
            // 
            // titleLabel
            // 
            titleLabel.AutoSize = true;
            titleLabel.Font = new Font("Trebuchet MS", 12F, FontStyle.Regular, GraphicsUnit.Point);
            titleLabel.ForeColor = Color.White;
            titleLabel.Location = new Point(49, 10);
            titleLabel.Name = "titleLabel";
            titleLabel.Size = new Size(177, 22);
            titleLabel.TabIndex = 24;
            titleLabel.Text = "Method Return Checker";
            // 
            // splitContainer1
            // 
            splitContainer1.Location = new Point(12, 146);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.BackColor = Color.FromArgb(251, 195, 78);
            splitContainer1.Panel1.Controls.Add(label1);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.BackColor = Color.SlateGray;
            splitContainer1.Panel2.Controls.Add(label2);
            splitContainer1.Size = new Size(776, 46);
            splitContainer1.SplitterDistance = 393;
            splitContainer1.TabIndex = 26;
            // 
            // label1
            // 
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
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BackgroundColor = Color.FromArgb(82, 87, 93);
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 198);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(776, 305);
            dataGridView1.TabIndex = 25;
            // 
            // progressBar1
            // 
            progressBar1.Location = new Point(12, 113);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(623, 23);
            progressBar1.TabIndex = 27;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(65, 68, 75);
            ClientSize = new Size(814, 530);
            Controls.Add(progressBar1);
            Controls.Add(splitContainer1);
            Controls.Add(dataGridView1);
            Controls.Add(titleLabel);
            Controls.Add(minimizedButton);
            Controls.Add(closeButton);
            Controls.Add(rjButton1);
            Controls.Add(pictureBox1);
            Controls.Add(folderPathTextBox);
            Font = new Font("Segoe UI Emoji", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            ForeColor = Color.Black;
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            MouseDown += Form1_MouseDown;
            MouseMove += Form1_MouseMove;
            MouseUp += Form1_MouseUp;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
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
        private PictureBox pictureBox1;
        private RJButton rjButton1;
        private RJButton closeButton;
        private RJButton minimizedButton;
        private Label titleLabel;
        private SplitContainer splitContainer1;
        private Label label1;
        private Label label2;
        private DataGridView dataGridView1;
        private ProgressBar progressBar1;
    }
}