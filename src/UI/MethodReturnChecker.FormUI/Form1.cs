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
        private readonly FileModelService _fileModelService;
        private bool isDragging = false;
        private Point dragStartPoint;
        public Form1()
        {
            InitializeComponent();
            _fileModelService = new FileModelService();
            patternTextBox.Text = RegexDefaults.DefaultPattern;
            containingTextBox.Text = RegexDefaults.DefaultContainting;
        }

        private async void selectFolderButton_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                folderPathTextBox.Text = folderBrowserDialog1.SelectedPath;
                
            }
            else
            {
                folderPathTextBox.Text = string.Empty;
            }

            loadingLabel.Visible = true;
            await Task.Run(matchAllCsFiles);
            loadingLabel.Visible = false;
        }

        private async Task matchAllCsFiles()
        {
            if (!string.IsNullOrWhiteSpace(folderPathTextBox.Text))
            {
                var csFiles = getFilesWithFileExtention(folderPathTextBox.Text, "*.cs");

                var csFileModelsResult = _fileModelService.ReturnFileModelForPerFile(csFiles, folderPathTextBox.Text);

                if (!csFileModelsResult.Success)
                {
                    MessageBox.Show(csFileModelsResult.Message);
                }

                var matchedResults = _fileModelService.GetMatchedFileModelResults(csFileModelsResult.Data, patternTextBox.Text, containingTextBox.Text);
                displayMatchResultForm(matchedResults.Data);
            }
        }

        private void displayMatchResultForm(List<ResultModel> matchedResults)
        {
            
            Form2 form2 = new Form2(matchedResults);
            form2.ShowDialog();
        }

        private List<string> getFilesWithFileExtention(string folderPath, string fileExtention)
        {
            List<string> files = Directory.GetFiles(folderPath, fileExtention, SearchOption.AllDirectories).ToList();

            if (files != null)
            {
                return files;
            }

            return new List<string>();
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