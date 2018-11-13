﻿using Gboxt.Common.DataModel;

namespace Flysh.Hosp.ProxyApi
{
    public interface IProxyRequestModel { }

    public abstract class ProxyRequestModelBase : IApiArgument
    {
        public virtual bool Validate(out string message)
        {
            message = string.Empty;
            return string.IsNullOrEmpty(message);
        }
    }

    public interface IProxyResponseModel { }
}
