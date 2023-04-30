namespace Troshka.Blazor.Models
{
    public class ResultModel
    {
        public bool IsSuccess { get; set; }
        public string Message { get; set; }
    }

    public class ResultModel<T> : ResultModel
    {
        public T Value { get; set; }
    }
}
