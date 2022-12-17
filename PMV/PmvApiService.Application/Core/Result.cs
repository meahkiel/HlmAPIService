namespace PMV.PmvApiService.Application.Core
{
    public  class Result<T>
    {

        public T Data { get; set; }

        public int HttpStatus { get; set; }

        public string? Message { get; set; }

        public bool IsSuccess { get; set; }

        public static Result<T> Failure(string message) {
            return new Result<T> { Message = message, IsSuccess = false, HttpStatus = 401 };
        }

        public static Result<T> Success(T value) {
            return new Result<T> {Data = value, IsSuccess = true, HttpStatus = 200, Message = "Success"};
        }


    }
}