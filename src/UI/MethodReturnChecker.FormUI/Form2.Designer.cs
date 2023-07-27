namespace MethodReturnChecker.FormUI
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            splitContainer1 = new SplitContainer();
            label1 = new Label();
            label2 = new Label();
            dataGridView1 = new DataGridView();
            titleLabel = new Label();
            minimizedButton = new RJButton();
            closeButton = new RJButton();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // splitContainer1
            // 
            splitContainer1.Location = new Point(12, 47);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.BackColor = Color.FromArgb(247, 232, 161);
            splitContainer1.Panel1.Controls.Add(label1);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(label2);
            splitContainer1.Size = new Size(776, 46);
            splitContainer1.SplitterDistance = 393;
            splitContainer1.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(158, 17);
            label1.Name = "label1";
            label1.Size = new Size(84, 19);
            label1.TabIndex = 0;
            label1.Text = "Eşleşen Sayı";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(177, 17);
            label2.Name = "label2";
            label2.Size = new Size(13, 15);
            label2.TabIndex = 1;
            label2.Text = "0";
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.FromArgb(82, 87, 93);
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 99);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(776, 305);
            dataGridView1.TabIndex = 2;
            // 
            // titleLabel
            // 
            titleLabel.AutoSize = true;
            titleLabel.Font = new Font("Trebuchet MS", 12F, FontStyle.Regular, GraphicsUnit.Point);
            titleLabel.ForeColor = Color.White;
            titleLabel.Location = new Point(53, 9);
            titleLabel.Name = "titleLabel";
            titleLabel.Size = new Size(177, 22);
            titleLabel.TabIndex = 28;
            titleLabel.Text = "Method Return Checker";
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
            minimizedButton.Location = new Point(740, 5);
            minimizedButton.Name = "minimizedButton";
            minimizedButton.Size = new Size(21, 21);
            minimizedButton.TabIndex = 27;
            minimizedButton.TextColor = Color.White;
            minimizedButton.UseVisualStyleBackColor = false;
            minimizedButton.Click += minimizedButton_Click;
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
            closeButton.Location = new Point(767, 5);
            closeButton.Name = "closeButton";
            closeButton.Size = new Size(21, 21);
            closeButton.TabIndex = 26;
            closeButton.TextColor = Color.White;
            closeButton.UseVisualStyleBackColor = false;
            closeButton.Click += closeButton_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImageLayout = ImageLayout.Center;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(11, 5);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(37, 29);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 25;
            pictureBox1.TabStop = false;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(65, 68, 75);
            ClientSize = new Size(800, 450);
            Controls.Add(titleLabel);
            Controls.Add(minimizedButton);
            Controls.Add(closeButton);
            Controls.Add(pictureBox1);
            Controls.Add(splitContainer1);
            Controls.Add(dataGridView1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form2";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form2";
            Load += Form2_Load;
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel1.PerformLayout();
            splitContainer1.Panel2.ResumeLayout(false);
            splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private SplitContainer splitContainer1;
        private Label label1;
        private Label label2;
        private DataGridView dataGridView1;
        private Label titleLabel;
        private RJButton minimizedButton;
        private RJButton closeButton;
        private PictureBox pictureBox1;
    }
}