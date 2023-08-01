using MethodReturnChecker.Common.Constants;
using MethodReturnChecker.Common.Models;
using MethodReturnChecker.Services;
using Newtonsoft.Json;
using System.Runtime;

namespace MethodReturnChecker.FormUI
{
    public partial class Form1 : Form
    {
        private readonly FileService _fileModelService;
        private string _defaultPattern;
        private string _defaultContaining;

        public Form1()
        {
            InitializeComponent();
            _fileModelService = new FileService();
        }

        private void selectFolderButton_Click(object sender, EventArgs e)
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
            progressBar1.Visible = true;
            progressBar1.Maximum = csFiles.Count;
            progressBar1.Value = 0;

            foreach (var csFilePath in csFiles)
            {
                var matchedResults = _fileModelService.MatchFile(folderPath, csFilePath, _defaultPattern, _defaultContaining);
                resultModels.AddRange(matchedResults);

                progressBar1.Value++;
            }

            progressBar1.Visible = false;
            displayMatchResultForm(resultModels);
        }
        private void refreshButton_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(folderBrowserDialog1.SelectedPath))
            {
                matchSelectedFiles(folderBrowserDialog1.SelectedPath, "*.cs");
            }
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

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                string settingsJson = File.ReadAllText("Settings.json");

                dynamic jsonData = JsonConvert.DeserializeObject(settingsJson);

                _defaultPattern = jsonData.DefaultPattern;
                _defaultContaining = jsonData.DefaultContainting;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, Messages.SettingsReadError);
                this.Close();
            }
        }
    }
}