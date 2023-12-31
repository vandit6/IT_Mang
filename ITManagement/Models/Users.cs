﻿using System;
using System.Collections.Generic;

namespace ITManagement.Models
{
    public partial class Users
    {
        public Users()
        {
            DeviceHistory = new HashSet<DeviceHistory>();
            Devices = new HashSet<Devices>();
        }

        public int Id { get; set; }
        public string UserId { get; set; }
        public string FullName { get; set; }
        public string Email { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public string UpdatedBy { get; set; }
        public bool Isarchived { get; set; }


        public ICollection<DeviceHistory> DeviceHistory { get; set; }
        public ICollection<Devices> Devices { get; set; }
    }
}
