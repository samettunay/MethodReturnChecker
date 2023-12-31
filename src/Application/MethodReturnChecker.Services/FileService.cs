﻿using MethodReturnChecker.Common.Models;
using System.Text.RegularExpressions;
using MethodReturnChecker.Common.Constants;
using System;

namespace MethodReturnChecker.Services
{
    public class FileService : IFileService
    {
        public List<ResultModel> GetMatchedFileResults(string folderPath, string filePath, string pattern, string sought, bool shouldInclude)
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

                    var newResultModel = new ResultModel()
                    {
                        FilePath = filePath.Replace(folderPath, string.Empty),
                        MatchedLine = matchedLine.Trim(),
                        LineNumber = currentLineNumber,
                    };

                    if (shouldInclude)
                    {
                        if (matchedLine.Contains(sought) && matchedLine.IndexOf(sought) < matchedLine.IndexOf(match.Value))
                        {
                            resultModels.Add(newResultModel);
                        }
                    }
                    else
                    {
                        Match newMatch = match;

                        // Aşağı satıra geçenler için tekrar Matchleme
                        if (match.Value.Contains("\n"))
                        {
                            string modifiedPattern = pattern.Substring(0, pattern.Length - 2);
                            newMatch = Regex.Match(matchedLine, modifiedPattern);
                        }

                        if (!matchedLine.Contains(sought) || (matchedLine.Contains(sought) && matchedLine.IndexOf(sought) > matchedLine.IndexOf(newMatch.Value)))
                        {
                            resultModels.Add(newResultModel);
                        }
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
            {
                lineEndIndex = content.Length;
            }

            matchedLine = content.Substring(lineStartIndex, lineEndIndex - lineStartIndex);
        }
    }
}
