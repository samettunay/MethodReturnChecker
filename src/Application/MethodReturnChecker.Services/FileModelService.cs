using MethodReturnChecker.Common.Models;
using MethodReturnChecker.Common.Utilities;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using MethodReturnChecker.Common.Constants;

namespace MethodReturnChecker.Services
{
    public class FileModelService : IFileModelService
    {
        public IDataResult<List<FileModel>> ReturnFileModelForPerFile(List<string> files, string folderPath)
        {
            List<FileModel> fileModels = new List<FileModel>();

            foreach (string filePath in files)
            {
                try
                {
                    var fileModel = new FileModel()
                    {
                        FilePath = filePath.Replace(folderPath, string.Empty),
                        Content = File.ReadAllText(filePath),
                    };

                    fileModels.Add(fileModel);
                }
                catch (Exception ex)
                {
                    return new ErrorDataResult<List<FileModel>>(fileModels, Messages.ErrorWhileReadingFile);
                }
            }

            if (fileModels.Any())
            {
                return new SuccessDataResult<List<FileModel>>(fileModels);
            }

            return new ErrorDataResult<List<FileModel>>(fileModels, Messages.DataIsEmpty);
        }

        // Eşleşme yapılıyor, Satır ve satır numarası belirleniyor son olarak ResultModel oluşturuluyor
        public IDataResult<List<ResultModel>> GetMatchedFileModelResults(List<FileModel> fileModels, string pattern, string containingValue)
        {
            List<ResultModel> resultModels = new List<ResultModel>();

            foreach (var fileModel in fileModels)
            {
                string input = fileModel.Content;
                MatchCollection matches = Regex.Matches(input, pattern, RegexOptions.Multiline);

                foreach (Match match in matches)
                {
                    int matchStartIndex = match.Index;
                    int lineStartIndex = input.LastIndexOf('\n', matchStartIndex) + 1;

                    int currentLineNumber = input.Substring(0, lineStartIndex).Count(c => c == '\n') + 1;
                    int lineEndIndex = input.IndexOf('\n', matchStartIndex);

                    if (lineEndIndex == -1)
                        lineEndIndex = input.Length;

                    string matchedLine = input.Substring(lineStartIndex, lineEndIndex - lineStartIndex);

                    // Fonksiyondan önce ki index'de "List" içerecek
                    if (matchedLine.Contains(containingValue) && matchedLine.IndexOf(containingValue) < matchedLine.IndexOf(match.Value))
                    {
                        var newResultModel = new ResultModel()
                        {
                            FilePath = fileModel.FilePath,
                            MatchedLine = matchedLine.Trim(),
                            LineNumber = currentLineNumber,
                        };

                        resultModels.Add(newResultModel);
                    }
                }
            }

            if (resultModels.Any())
            {
                return new SuccessDataResult<List<ResultModel>>(resultModels);
            }

            return new ErrorDataResult<List<ResultModel>>(resultModels, Messages.DataIsEmpty);
        }
    }
}
