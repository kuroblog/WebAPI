
namespace Flysh.HospInterface.ProxyApi.Infrastructures
{
    using Gboxt.Common.DataModel;
    using System;
    using System.Linq;
    using System.Threading.Tasks;

    /// <summary>
    /// runner
    /// </summary>
    public static class Runner
    {
        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="TArgs"></typeparam>
        /// <typeparam name="TResult"></typeparam>
        /// <param name="func"></param>
        /// <param name="args"></param>
        /// <returns></returns>
        public static async Task<(bool hasError, Exception error, TResult data)> ExecuteAsync<TArgs, TResult>(Func<TArgs, Task<TResult>> func, TArgs args)
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

        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="TArgs"></typeparam>
        /// <typeparam name="TResult"></typeparam>
        /// <param name="func"></param>
        /// <param name="args"></param>
        /// <returns></returns>
        public static ApiResult<TResult> Execute<TArgs, TResult>(Func<TArgs, TResult> func, TArgs args)
            where TArgs : class
            where TResult : class
        {
            ApiResult<TResult> apiResult = null;

            try
            {
                if (args == null)
                {
                    throw new ArgumentNullException(typeof(TArgs).Name);
                }

                var result = func.Invoke(args);

                apiResult = new ApiResult<TResult> { Success = true, ResultData = result };
            }
            catch (ArgumentNullException exArg)
            {
                errorHandler(exArg);
                apiResult = new ApiResult<TResult>
                {
                    Success = false,
                    Status = new OperatorStatus
                    {
                        HttpCode = "400",
                        ClientMessage = exArg.Message
                    }
                };
            }
            catch (Exception ex)
            {
                errorHandler(ex);
                apiResult = new ApiResult<TResult>
                {
                    Success = false,
                    Status = new OperatorStatus
                    {
                        HttpCode = "500",
                        ClientMessage = ex.Message
                    }
                };
            }

            return apiResult;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="TArgs"></typeparam>
        /// <typeparam name="TResult"></typeparam>
        /// <param name="func"></param>
        /// <param name="args"></param>
        /// <returns></returns>
        public static Gboxt.Common.DataModel.ApiArrayResult<TResult> Execute<TArgs, TResult>(Func<TArgs, TResult[]> func, TArgs args)
            where TArgs : class
            where TResult : class
        {
            Gboxt.Common.DataModel.ApiArrayResult<TResult> apiResult = null;

            try
            {
                if (args == null)
                {
                    throw new ArgumentNullException(typeof(TArgs).Name);
                }

                var result = func.Invoke(args);

                apiResult = new ApiArrayResult<TResult> { Success = true, ResultData = result?.ToList() };
            }
            catch (ArgumentNullException exArg)
            {
                errorHandler(exArg);
                apiResult = new ApiArrayResult<TResult>
                {
                    Success = false,
                    Status = new OperatorStatus
                    {
                        HttpCode = "400",
                        ClientMessage = exArg.Message
                    }
                };
            }
            catch (Exception ex)
            {
                errorHandler(ex);
                apiResult = new ApiArrayResult<TResult>
                {
                    Success = false,
                    Status = new OperatorStatus
                    {
                        HttpCode = "500",
                        ClientMessage = ex.Message
                    }
                };
            }

            return apiResult;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="TResult"></typeparam>
        /// <param name="func"></param>
        /// <returns></returns>
        public static async Task<(bool hasError, Exception error, TResult data)> ExecuteAsync<TResult>(Func<Task<TResult>> func)
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
