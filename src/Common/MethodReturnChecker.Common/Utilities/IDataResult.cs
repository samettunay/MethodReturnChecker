namespace MethodReturnChecker.Common.Utilities
{
    public interface IDataResult<T> : IResult
    {
        T Data { get; }
    }
}
