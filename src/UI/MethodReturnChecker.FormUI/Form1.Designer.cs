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
            inputLabel = new Label();
            patternLabel = new Label();
            folderBrowserDialog1 = new FolderBrowserDialog();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            folderPathTextBox = new TextBox();
            patternTextBox = new TextBox();
            containingTextBox = new TextBox();
            pictureBox1 = new PictureBox();
            rjButton1 = new RJButton();
            closeButton = new RJButton();
            minimizedButton = new RJButton();
            titleLabel = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // inputLabel
            // 
            inputLabel.AutoSize = true;
            inputLabel.ForeColor = Color.FromArgb(246, 244, 230);
            inputLabel.Location = new Point(13, 283);
            inputLabel.Name = "inputLabel";
            inputLabel.Size = new Size(100, 20);
            inputLabel.TabIndex = 15;
            inputLabel.Text = "Aranan Değer";
            // 
            // patternLabel
            // 
            patternLabel.AutoSize = true;
            patternLabel.ForeColor = Color.FromArgb(246, 244, 230);
            patternLabel.Location = new Point(12, 237);
            patternLabel.Name = "patternLabel";
            patternLabel.Size = new Size(101, 20);
            patternLabel.TabIndex = 12;
            patternLabel.Text = "Regex Pattern";
            // 
            // folderPathTextBox
            // 
            folderPathTextBox.BackColor = Color.FromArgb(82, 87, 93);
            folderPathTextBox.BorderStyle = BorderStyle.None;
            folderPathTextBox.ForeColor = Color.FromArgb(246, 244, 230);
            folderPathTextBox.Location = new Point(12, 78);
            folderPathTextBox.Multiline = true;
            folderPathTextBox.Name = "folderPathTextBox";
            folderPathTextBox.Size = new Size(244, 29);
            folderPathTextBox.TabIndex = 17;
            // 
            // patternTextBox
            // 
            patternTextBox.BackColor = Color.FromArgb(82, 87, 93);
            patternTextBox.BorderStyle = BorderStyle.None;
            patternTextBox.ForeColor = Color.FromArgb(246, 244, 230);
            patternTextBox.Location = new Point(129, 239);
            patternTextBox.Name = "patternTextBox";
            patternTextBox.Size = new Size(217, 20);
            patternTextBox.TabIndex = 18;
            // 
            // containingTextBox
            // 
            containingTextBox.BackColor = Color.FromArgb(82, 87, 93);
            containingTextBox.BorderStyle = BorderStyle.None;
            containingTextBox.ForeColor = Color.FromArgb(246, 244, 230);
            containingTextBox.Location = new Point(129, 283);
            containingTextBox.Name = "containingTextBox";
            containingTextBox.Size = new Size(218, 20);
            containingTextBox.TabIndex = 19;
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
            rjButton1.Location = new Point(262, 78);
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
            closeButton.Location = new Point(364, 5);
            closeButton.Name = "closeButton";
            closeButton.Size = new Size(21, 21);
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
            minimizedButton.Location = new Point(337, 5);
            minimizedButton.Name = "minimizedButton";
            minimizedButton.Size = new Size(21, 21);
            minimizedButton.TabIndex = 23;
            minimizedButton.TextColor = Color.White;
            minimizedButton.UseVisualStyleBackColor = false;
            minimizedButton.Click += minimizedButton_Click;
            // 
            // titleLabel
            // 
            titleLabel.AutoSize = true;
            titleLabel.Font = new Font("Trebuchet MS", 12F, FontStyle.Regular, GraphicsUnit.Point);
            titleLabel.Location = new Point(49, 10);
            titleLabel.Name = "titleLabel";
            titleLabel.Size = new Size(177, 22);
            titleLabel.TabIndex = 24;
            titleLabel.Text = "Method Return Checker";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(65, 68, 75);
            ClientSize = new Size(397, 386);
            Controls.Add(titleLabel);
            Controls.Add(minimizedButton);
            Controls.Add(closeButton);
            Controls.Add(rjButton1);
            Controls.Add(pictureBox1);
            Controls.Add(containingTextBox);
            Controls.Add(patternTextBox);
            Controls.Add(folderPathTextBox);
            Controls.Add(inputLabel);
            Controls.Add(patternLabel);
            Font = new Font("Segoe UI Emoji", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            ForeColor = Color.FromArgb(246, 244, 230);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label inputLabel;
        private Label patternLabel;
        private FolderBrowserDialog folderBrowserDialog1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private TextBox folderPathTextBox;
        private TextBox patternTextBox;
        private TextBox containingTextBox;
        private PictureBox pictureBox1;
        private RJButton rjButton1;
        private RJButton closeButton;
        private RJButton minimizedButton;
        private Label titleLabel;
    }
}