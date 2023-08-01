using MethodReturnChecker.Common.Models;

namespace MethodReturnChecker.Services
{
    public interface IFileService
    {
        List<ResultModel> GetMatchedFileResults(string folderPath, string filePath, string pattern, string containingValue);
    }
}