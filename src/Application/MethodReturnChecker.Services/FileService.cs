using MethodReturnChecker.Common.Models;
using MethodReturnChecker.Common.Utilities;
using System.Text.RegularExpressions;
using MethodReturnChecker.Common.Constants;
using System;

namespace MethodReturnChecker.Services
{
    public class FileService : IFileService
    {
        public List<ResultModel> MatchFile(string folderPath, string filePath, string pattern, string containingValue)
        {
            List<ResultModel> resultModels = new List<ResultModel>();

            try
            {
                string content = File.ReadAllText(filePath);
                MatchCollection matches = Regex.Matches(content, pattern, RegexOptions.Multiline);

                foreach (Match match in matches)
                {
                    int currentLineNumber;
                    string matchedLine;

                    getMatchedLineWithNumber(content, match, out currentLineNumber, out matchedLine);

                    // Fonksiyondan önce ki index'de "List" içerecek
                    if (matchedLine.Contains(containingValue) && matchedLine.IndexOf(containingValue) < matchedLine.IndexOf(match.Value))
                    {
                        var newResultModel = new ResultModel()
                        {
                            FilePath = filePath.Replace(folderPath, string.Empty),
                            MatchedLine = matchedLine.Trim(),
                            LineNumber = currentLineNumber,
                        };

                        resultModels.Add(newResultModel);
                    }
                }
            }
            catch (Exception ex)
            {
                var errorResultModel = new ResultModel()
                {
                    FilePath = filePath,
                    MatchedLine = string.Empty,
                    LineNumber = 0,
                    Error = ex.Message
                };

                resultModels.Add(errorResultModel);
            }

            return resultModels;
        }

        private static void getMatchedLineWithNumber(string content, Match match, out int currentLineNumber, out string matchedLine)
        {
            int matchStartIndex = match.Index;
            int lineStartIndex = content.LastIndexOf('\n', matchStartIndex) + 1;

            currentLineNumber = content.Substring(0, lineStartIndex).Count(c => c == '\n') + 1;
            int lineEndIndex = content.IndexOf('\n', matchStartIndex);

            if (lineEndIndex == -1)
                lineEndIndex = content.Length;

            matchedLine = content.Substring(lineStartIndex, lineEndIndex - lineStartIndex);
        }
    }
}
