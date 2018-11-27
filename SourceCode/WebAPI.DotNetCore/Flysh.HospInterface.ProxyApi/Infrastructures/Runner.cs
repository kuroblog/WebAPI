
namespace Flysh.HospInterface.ProxyApi.Infrastructures
{
    using Gboxt.Common.DataModel;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    /// <summary>
    /// runner
    /// </summary>
    public static class Runner
    {
        //public static async Task<(bool hasError, Exception error, TResult data)> ExecuteAsync<TArgs, TResult>(Func<TArgs, Task<TResult>> func, TArgs args)
        //    where TArgs : class
        //    where TResult : class
        //{
        //    try
        //    {
        //        var result = await func.Invoke(args);

        //        return (false, null, result);
        //    }
        //    catch (Exception ex)
        //    {
        //        errorHandler(ex);

        //        return (true, ex, null);
        //    }
        //}

        //public static (bool hasError, Exception error, TResult data) Execute<TArgs, TResult>(Func<TArgs, TResult> func, TArgs args)
        //    where TArgs : class
        //    where TResult : class
        //{
        //    try
        //    {
        //        if (args == null)
        //        {
        //            throw new ArgumentNullException(typeof(TArgs).Name);
        //        }

        //        var result = func.Invoke(args);

        //        return (false, null, result);
        //    }
        //    catch (Exception ex)
        //    {
        //        errorHandler(ex);

        //        return (true, ex, null);
        //    }
        //}

        //public static async Task<(bool hasError, Exception error, TResult data)> ExecuteAsync<TResult>(Func<Task<TResult>> func)
        //    where TResult : class
        //{
        //    try
        //    {
        //        var result = await func.Invoke();

        //        return (false, null, result);
        //    }
        //    catch (Exception ex)
        //    {
        //        errorHandler(ex);

        //        return (true, ex, null);
        //    }
        //}

        private static Action<Exception> errorHandler = (error) =>
        {
            var color = Console.ForegroundColor;
            Console.ForegroundColor = ConsoleColor.Red;

            Console.WriteLine(error.Message);

            Console.ForegroundColor = color;
        };

        private static ApiResult<TResult> ApiResultGenerator<TResult>((bool result, string message, TResult data) hisResult, string message = "", string httpCode = "200")
        {
            return new ApiResult<TResult>
            {
                Success = hisResult.result,
                ResultData = hisResult.data,
                Status = new OperatorStatus
                {
                    InnerMessage = hisResult.message,
                    HttpCode = httpCode,
                    ClientMessage = message
                }
            };
        }

        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="TArgs"></typeparam>
        /// <typeparam name="TResult"></typeparam>
        /// <param name="func"></param>
        /// <param name="args"></param>
        /// <returns></returns>
        public static ApiResult<TResult> Execute<TArgs, TResult>(Func<TArgs, (bool result, string message, TResult data)> func, TArgs args)
            where TArgs : class
            //where TResult : class
        {
            ApiResult<TResult> apiResult = null;

            try
            {
                if (args == null)
                {
                    throw new ArgumentNullException(typeof(TArgs).Name);
                }

                var result = func.Invoke(args);

                apiResult = ApiResultGenerator(result);
            }
            catch (ArgumentNullException exArg)
            {
                errorHandler(exArg);
                apiResult = ApiResultGenerator((result: false, message: "", data: default(TResult)), exArg.Message, "400");
            }
            catch (Exception ex)
            {
                errorHandler(ex);
                apiResult = ApiResultGenerator((result: false, message: "", data: default(TResult)), ex.Message, "500");
            }

            return apiResult;
        }

        private static ApiArrayResult<TResult> ApiArrayResultGenerator<TResult>((bool result, string message, IEnumerable<TResult> data) hisResult, string message = "", string httpCode = "200")
        {
            return new ApiArrayResult<TResult>
            {
                Success = hisResult.result,
                ResultData = hisResult.data?.ToList(),
                Status = new OperatorStatus
                {
                    InnerMessage = hisResult.message,
                    HttpCode = httpCode,
                    ClientMessage = message
                }
            };
        }

        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="TArgs"></typeparam>
        /// <typeparam name="TResult"></typeparam>
        /// <param name="func"></param>
        /// <param name="args"></param>
        /// <returns></returns>
        public static ApiArrayResult<TResult> Execute<TArgs, TResult>(Func<TArgs, (bool result, string message, IEnumerable<TResult> data)> func, TArgs args)
            where TArgs : class
            //where TResult : class
        {
            ApiArrayResult<TResult> apiResult = null;

            try
            {
                if (args == null)
                {
                    throw new ArgumentNullException(typeof(TArgs).Name);
                }

                var result = func.Invoke(args);

                apiResult = ApiArrayResultGenerator(result);
            }
            catch (ArgumentNullException exArg)
            {
                errorHandler(exArg);
                apiResult = ApiArrayResultGenerator((result: false, message: "", data: default(IEnumerable<TResult>)), exArg.Message, "400");
            }
            catch (Exception ex)
            {
                errorHandler(ex);
                apiResult = ApiArrayResultGenerator((result: false, message: "", data: default(IEnumerable<TResult>)), ex.Message, "500");
            }

            return apiResult;
        }
    }
}
