using MethodReturnChecker.Common.Constants;
using MethodReturnChecker.Common.Models;
using MethodReturnChecker.Services;
using System.ComponentModel;
using System.Diagnostics.Metrics;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace MethodReturnChecker.FormUI
{
    public partial class Form1 : Form
    {
        private readonly FileService _fileModelService;
        private bool isDragging = false;
        private Point dragStartPoint;
        public Form1()
        {
            InitializeComponent();
            _fileModelService = new FileService();
        }

        private async void selectFolderButton_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                folderPathTextBox.Text = folderBrowserDialog1.SelectedPath;
                matchSelectedFiles(folderBrowserDialog1.SelectedPath, "*.cs");
            }

        }

        private void matchSelectedFiles(string folderPath, string fileExtention)
        {
            var csFiles = Directory.GetFiles(folderPath, fileExtention, SearchOption.AllDirectories).ToList();

            var resultModels = new List<ResultModel>();

            progressBar1.Maximum = csFiles.Count;
            progressBar1.Value = 0;

            foreach (var csFilePath in csFiles)
            {
                var matchedResults = _fileModelService.MatchFile(csFilePath, RegexDefaults.DefaultPattern, RegexDefaults.DefaultContainting);
                resultModels.AddRange(matchedResults);

                progressBar1.Value++;
            }

            displayMatchResultForm(resultModels);
        }

        private void displayMatchResultForm(List<ResultModel> matchedResults)
        {
            dataGridView1.DataSource = matchedResults;
            label2.Text = matchedResults.Count.ToString();
            if (matchedResults.Count > 0)
            {
                splitContainer1.Panel2.BackColor = Color.IndianRed;
            }
            else
            {
                splitContainer1.Panel2.BackColor = Color.PaleGreen;
            }
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void minimizedButton_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                isDragging = true;
                dragStartPoint = new Point(e.X, e.Y);
            }
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (!isDragging)
                return;

            Point newLocation = this.PointToScreen(new Point(e.X, e.Y));
            newLocation.Offset(-dragStartPoint.X, -dragStartPoint.Y);
            this.Location = newLocation;
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            isDragging = false;
        }
    }
}