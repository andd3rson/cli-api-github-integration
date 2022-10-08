namespace cli_api_github_integration;

public class Response<T>
{
    public T Data { get; }
    public bool IsSuccess { get; }
    
    public Response(T data, bool isSuccess)
    {
        Data = data;
        IsSuccess = isSuccess;
    }
}