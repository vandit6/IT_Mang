// DashboardViewModel.cs
using System;
using System.Collections.Generic;

namespace ITManagement.ViewModels
{
    public class DashboardViewModel
    {
        public int NumberOfDevices { get; set; }
        public int NumberOfUsers { get; set; }
        public int NumberOfAllottedDevices { get; set; }
        public int NumberOfUnAllottedDevices { get; set; }
        public List<BarChartData> BarChartData { get; set; }

        // Add the property for DeviceLogs
        public List<DashboardLogViewModel> DeviceLogs { get; set; }
    }

    public class BarChartData
    {
        public string Category { get; set; }
        public int NumberOfUsers { get; set; }
        public int NumberOfAllottedDevices { get; set; }
    }


    // Add a new ViewModel for DeviceLog
    public class DashboardLogViewModel
    {
        public int LogId { get; set; }
        public string ChangeType { get; set; }
        public DateTime Timestamp { get; set; }
        public int? DeviceId { get; set; } // Make DeviceId nullable
        public string CategoryName { get; set; }
        public string UserId { get; set; }
        public string DeviceName { get; set; }
        public string Description { get; set; }
        public bool Status { get; set; }
        public DateTime? AllotedDate { get; set; }
        // Add other relevant fields
    }

}
