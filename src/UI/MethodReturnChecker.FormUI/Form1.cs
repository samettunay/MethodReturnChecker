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
        private dynamic _settings;
        private string _pattern;
        private string _containing;
        private bool _sought;
        private string _fileExtention;

        public Form1()
        {
            InitializeComponent();
            _fileModelService = new FileService();
            _fileExtention = "*.cs";
        }

        private void selectFolderButton_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                folderPathTextBox.Text = folderBrowserDialog1.SelectedPath;
                matchSelectedFiles(folderBrowserDialog1.SelectedPath, _fileExtention, _pattern, _containing, _sought);
            }

        }

        private void refreshButton_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(folderBrowserDialog1.SelectedPath))
            {
                matchSelectedFiles(folderBrowserDialog1.SelectedPath, _fileExtention, _pattern, _containing, _sought);
            }
        }

        private void matchSelectedFiles(string folderPath, string fileExtention, string pattern, string sought, bool shouldInclude)
        {
            var resultModels = new List<ResultModel>();
            var csFiles = Directory.GetFiles(folderPath, fileExtention, SearchOption.AllDirectories).ToList();

            selectMethodComboBox.Visible = false;
            progressBar1.Visible = true;
            progressBar1.Maximum = csFiles.Count;
            progressBar1.Value = 0;

            foreach (var csFilePath in csFiles)
            {
                var matchedResults = _fileModelService.GetMatchedFileResults(folderPath, csFilePath, pattern, sought, shouldInclude);
                resultModels.AddRange(matchedResults);

                progressBar1.Value++;
            }

            progressBar1.Visible = false;
            selectMethodComboBox.Visible = true;
            displayMatchResult(resultModels);
        }

        private void displayMatchResult(List<ResultModel> matchedResults)
        {
            dataGridView1.DataSource = matchedResults;
            resultCountLabel.Text = matchedResults.Count.ToString();
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

                _settings = jsonData;
                _containing = jsonData.Containting;
                selectMethodComboBox.SelectedIndex = 0;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, Messages.SettingsReadError);
                this.Close();
            }
            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (selectMethodComboBox.SelectedIndex.Equals(0))
            {
                _pattern = _settings.ReadPattern;
                _sought = true;
            }
            else
            {
                _pattern = _settings.GetPattern;
                _sought = false;
            }
        }
    }
}