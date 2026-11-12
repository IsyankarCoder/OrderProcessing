using System.ComponentModel;

namespace OrderProcessing.Helpers;
/*public class Result<T>
{
    public bool IsSuccess{get;}
    public bool IsFailure=>!IsSuccess;

    public T? Value{get;}
    public string? Error{get;}

    private Result(bool isSuccess,
                   T? value,
                   string? error)
    {
         IsSuccess=isSuccess;
         Value=value;
         Error =error;
    }

    public static Result<T> Success(T value)=>   
        new Result<T>(true,value,null);
    public static Result<T> Failure(string error)=> 
       new Result<T>(false,default,error);
}*/

public class Result
{
    public bool IsSuccess{get;}
    public bool IsFailure=>!IsSuccess;

    public OrderResult? Value{get;}

    

    protected Result(bool isSuccess, OrderResult? value)
    {
        Value=value;
        IsSuccess=isSuccess;
    }

    public static Result Success(OrderResult value)=> new Result(true,value);
    public static Result Failure(OrderResult value)=> new Result(false,value);
}

/*public class Result<T> : Result
{
    public T? Value{get;}
    public Result(bool isSuccess,T? value,string?error)
         : base(isSuccess, error)
    {
        Value=value;
    }

    public static Result<T> Success(T value)
                            =>new(true,value,null);

    public static new Result<T> Failure(string error)
                            =>new(false,default,error);


} */

