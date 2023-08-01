using MethodReturnChecker.Common.Models;
using MethodReturnChecker.Common.Utilities;

namespace MethodReturnChecker.Services
{
    public interface IFileService
    {
        List<ResultModel> MatchFile(string filePath, string pattern, string containingValue);
    }
}