using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace HG.Result;
public sealed class Result<T>
{
    public T? Data { get; set; }
    public List<string>? ErrorMessages { get; set; }
    public bool IsSuccessful { get; set; } = true;
    public HttpStatusCode StatusCode { get; set; } = HttpStatusCode.OK;

    public Result(T data)
    {
        Data = data;
    }

    public Result(HttpStatusCode statusCode, List<string> errorMessage)
    {
        IsSuccessful = false;
        StatusCode = statusCode;
        ErrorMessages = errorMessage;
    }

    public Result(HttpStatusCode statusCode, string errorMessage)
    {
        IsSuccessful = false;
        StatusCode = statusCode;
        ErrorMessages = new() { errorMessage };
    }

    public static implicit operator Result<T>(T data)
    {
        return new(data);
    }

    public static implicit operator Result<T>((HttpStatusCode statusCode, List<string> errorMessage) parameters)
    {
        return new(parameters.statusCode, parameters.errorMessage);
    }

    public static implicit operator Result<T>((HttpStatusCode statusCode, string errorMessage) parameters)
    {
        return new(parameters.statusCode, parameters.errorMessage);
    }
}