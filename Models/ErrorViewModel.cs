using System;

namespace DashJenkinCiDemo.Models
{
    public class ErrorViewModel
    {
        public string RequestId { get; set; }
        public string Forename { get; set; }
        public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);
    }
}
