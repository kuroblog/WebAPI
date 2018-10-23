
namespace WebApp.CallWebService.Core
{
    using System;
    using System.Threading.Tasks;

    public static class Runner
    {
        public static async Task<TResult> Execute<TArgs, TResult>(Func<TArgs, Task<TResult>> func, TArgs args)
            where TArgs : class
            where TResult : class
        {
            try
            {
                return await func.Invoke(args);
            }
            catch (Exception ex)
            {
                errorHandler(ex);

                return default(TResult);
            }
        }

        public static Action<Exception> errorHandler = (error) =>
        {
            var color = Console.ForegroundColor;
            Console.ForegroundColor = ConsoleColor.Red;

            Console.WriteLine(error.Message);

            Console.ForegroundColor = color;
        };
    }
}
