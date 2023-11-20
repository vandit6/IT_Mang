using System;
using System.Collections.Generic;

namespace ITManagement.ViewModels
{
    public class AllDeviceLogsViewModel
    {
        public List<AllLogViewModel> Logs { get; set; }
        public List<string> ChangeTypes { get; set; }
        public List<string> CategoryNames { get; set; }
        public List<int?> DeviceIds { get; set; }
        public List<string> UserIds { get; set; }
        public List<string> DeviceNames { get; set; }
        public List<bool?> IsArchivedOptions { get; set; }
        public DateTime? ChangeDate { get; set; }
    }

    public class AllLogViewModel
    {
        public int LogId { get; set; }
        public string ChangeType { get; set; }
        public int? DeviceId { get; set; }
        public string CategoryName { get; set; } 
        public string UserId { get; set; }
        public string DeviceName { get; set; }
        public string Description { get; set; }
        public DateTime? AllotedDate { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public string UpdatedBy { get; set; }
        public bool IsArchived { get; set; }
        public DateTime? Timestamp { get; set; }
    }
}
