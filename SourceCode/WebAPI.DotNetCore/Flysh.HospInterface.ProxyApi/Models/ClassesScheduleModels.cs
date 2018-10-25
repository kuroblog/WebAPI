
namespace Flysh.HospInterface.ProxyApi.Models
{
    using Gboxt.Common.DataModel;

    public class ClassesScheduleRequest : IApiArgument
    {
        public string beginDate { get; set; }

        public string endDate { get; set; }

        public string deptCode { get; set; }

        public string isPre { get; set; }

        public bool Validate(out string message)
        {
            message = string.Empty;

            return string.IsNullOrEmpty(message);
        }
    }

    public class ClassesScheduleResponse
    {
        public string id { get; set; }

        public string seeDate { get; set; }

        public string week { get; set; }

        public string nooncode { get; set; }

        public string beginTime { get; set; }

        public string endTime { get; set; }

        public string deptCode { get; set; }

        public string deptName { get; set; }

        public string doctCode { get; set; }

        public string doctName { get; set; }

        public string regLmt { get; set; }

        public string regReged { get; set; }

        public string regLevl { get; set; }

        public string totCost { get; set; }

        public string adress { get; set; }

        public string regType { get; set; }
    }
}
