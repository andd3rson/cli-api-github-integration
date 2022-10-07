namespace cli_api_github_integration;

public class Response<T>
{
    public T Data { get; set; }
    public bool IsSuccess { get; set; }

    public Response()
    {
    }
    public Response(T data, bool isSuccess)
    {
        Data = data;
        IsSuccess = isSuccess;
    }
}