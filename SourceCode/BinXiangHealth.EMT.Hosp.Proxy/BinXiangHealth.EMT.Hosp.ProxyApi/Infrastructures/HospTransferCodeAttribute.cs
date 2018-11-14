using System;

namespace Flysh.Hosp.ProxyApi
{
    [AttributeUsage(AttributeTargets.Class, Inherited = false)]
    public class HospTransferCodeAttribute : Attribute
    {
        public string TransferCode { get; }

        public HospTransferCodeAttribute(string transferCode)
        {
            TransferCode = transferCode;
        }
    }
}
