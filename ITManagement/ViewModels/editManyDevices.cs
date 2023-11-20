using ITManagement.Models;
using System;
using System.Collections.Generic;

namespace ITManagement.ViewModels
{
    public class editManyDeviceModel
    {
        public List<int> selectedDeviceIds { get; set; }
        public int categoryId { get; set; }
        public bool status { get; set; }
        public string userId { get; set; }
        public bool isUpdateCategory { get; set; }
        public bool isAllotment { get; set; }
       
    }
}
