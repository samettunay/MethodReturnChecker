using MethodReturnChecker.Common.Models;

namespace MethodReturnChecker.Services
{
    public interface IFileService
    {
        List<ResultModel> MatchFile(string folderPath, string filePath, string pattern, string containingValue);
    }
}