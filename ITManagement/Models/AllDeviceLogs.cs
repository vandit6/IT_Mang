using System;
using System.Collections.Generic;

namespace ITManagement.Models
{
    public partial class AllDeviceLogs
    {
        public int LogId { get; set; }
        public string ChangeType { get; set; }
        public int? DeviceId { get; set; }
        public string UserId { get; set; }
        public string DeviceName { get; set; }
        public string Description { get; set; }
        public DateTime? AllotedDate { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public string UpdatedBy { get; set; }
        public bool? Isarchived { get; set; }
        public DateTime Timestamp { get; set; }
        public string CategoryName { get; set; }
    }
}
