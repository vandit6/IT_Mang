using ITManagement.Models;
using System;
using System.Collections.Generic;

namespace ITManagement.ViewModels
{
    public class LogViewModel
    {
        public int LogId { get; set; }
        public string ChangeType { get; set; }
        public DateTime? ChangeDate { get; set; }
        public int? DeviceId { get; set; }
        public int? CategoryId { get; set; }
        public string UserId { get; set; }
        public string DeviceName { get; set; }
        public string Description { get; set; }
        public bool? Status { get; set; }
        public DateTime? AllotedDate { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public string UpdatedBy { get; set; }
        public bool IsArchived { get; set; }
        public string Action { get; set; }
        public DateTime? Timestamp { get; set; }
    }

    public class LogFilterViewModel
    {
        public List<LogViewModel> Logs { get; set; }
        public List<int?> CategoryIds { get; set; }
        public List<int?> DeviceIds { get; set; }
        public List<string> UserIds { get; set; }
        public List<string> DeviceNames { get; set; }
        public List<bool?> IsArchivedOptions { get; set; }
        public DateTime? ChangeDate { get; set; }
    }
}
