
namespace WebApp.CallWebService.Core
{
    using System;
    using System.Threading.Tasks;

    public static class Runner
    {
        public static async Task<(bool hasError, Exception error, TResult data)> Execute<TArgs, TResult>(Func<TArgs, Task<TResult>> func, TArgs args)
            where TArgs : class
            where TResult : class
        {
            try
            {
                var result = await func.Invoke(args);

                return (false, null, result);
            }
            catch (Exception ex)
            {
                errorHandler(ex);

                return (true, ex, null);
            }
        }

        public static async Task<(bool hasError, Exception error, TResult data)> Execute<TResult>(Func<Task<TResult>> func)
            where TResult : class
        {
            try
            {
                var result = await func.Invoke();

                return (false, null, result);
            }
            catch (Exception ex)
            {
                errorHandler(ex);

                return (true, ex, null);
            }
        }

        private static Action<Exception> errorHandler = (error) =>
        {
            var color = Console.ForegroundColor;
            Console.ForegroundColor = ConsoleColor.Red;

            Console.WriteLine(error.Message);

            Console.ForegroundColor = color;
        };
    }
}
