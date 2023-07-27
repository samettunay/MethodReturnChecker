using MethodReturnChecker.Common.Constants;
using MethodReturnChecker.Common.Models;
using MethodReturnChecker.Services;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace MethodReturnChecker.FormUI
{
    public partial class Form1 : Form
    {
        private readonly FileModelService _fileModelService;
        public Form1()
        {
            InitializeComponent();
            _fileModelService = new FileModelService();
            patternTextBox.Text = RegexDefaults.DefaultPattern;
            containingTextBox.Text = RegexDefaults.DefaultContainting;
        }

        private void selectFolderButton_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                folderPathTextBox.Text = folderBrowserDialog1.SelectedPath;
            }
            else
            {
                folderPathTextBox.Text = string.Empty;
            }
            matchAllCsFiles();
        }

        private void matchAllCsFiles()
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
    }
}