using MethodReturnChecker.Common.Models;
using MethodReturnChecker.Common.Utilities;

namespace MethodReturnChecker.Services
{
    public interface IFileModelService
    {
        IDataResult<List<ResultModel>> GetMatchedFileModelResults(List<FileModel> fileModels, string pattern, string containingValue);
        IDataResult<List<FileModel>> ReturnFileModelForPerFile(List<string> files, string folderPath);
    }
}