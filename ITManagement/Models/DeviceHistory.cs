 using System;
using System.Collections.Generic;

namespace ITManagement.Models
{
    public partial class DeviceHistory
    {
        public int HistoryId { get; set; }
        public int? DeviceId { get; set; }
        public int? CategoryId { get; set; }
        public string UserId { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public string Description { get; set; }

        // Additional fields from Devices, Users, and Categories models
        public string DeviceName { get; set; }
        public string UserName { get; set; }
        public string CategoryName { get; set; }

        public Devices Device { get; set; }
        public Users UpdatedByNavigation { get; set; }
    }


}