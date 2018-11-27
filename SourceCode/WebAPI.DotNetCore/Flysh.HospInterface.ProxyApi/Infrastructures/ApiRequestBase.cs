
namespace Flysh.HospInterface.ProxyApi.Infrastructures
{
    using Gboxt.Common.DataModel;
    using System;
    using System.Linq.Expressions;

    /// <summary>
    /// 
    /// </summary>
    public abstract class ApiRequestBase : IApiArgument
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="message"></param>
        /// <returns></returns>
        public virtual bool Validate(out string message)
        {
            message = string.Empty;
            return string.IsNullOrEmpty(message);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="TProperty"></typeparam>
        /// <param name="propertyExpression"></param>
        /// <param name="errorMessageForamt"></param>
        /// <returns></returns>
        public virtual string ErrorMessage<TProperty>(Expression<Func<TProperty>> propertyExpression, string errorMessageForamt = "the property named {0} is null.")
        {
            var propertyName = PropertySupport.ExtractPropertyName(propertyExpression);

            return string.Format(errorMessageForamt, propertyName);
        }
    }
}
