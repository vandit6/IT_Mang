using System;
using System.Collections.Generic;
using System.Linq;
using ITManagement.Models;
using ITManagement.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace ITManagement.Controllers
{
    public class AllDeviceLogsController : Controller
    {
        private readonly ITManagementContext _context;

        public AllDeviceLogsController(ITManagementContext context)
        {
            _context = context;
        }

        public IActionResult AllDeviceLogs(string changeType, string categoryName, string deviceId, string userId, string deviceName, string isArchived)
        {
            var logs = _context.AllDeviceLogs.ToList();

            if (!string.IsNullOrEmpty(changeType))
                logs = logs.Where(log => log.ChangeType == changeType).ToList();

            if (!string.IsNullOrEmpty(categoryName))
                logs = logs.Where(log => log.CategoryName == categoryName).ToList();

            if (!string.IsNullOrEmpty(deviceId))
                logs = logs.Where(log => log.DeviceId.ToString() == deviceId).ToList();

            if (!string.IsNullOrEmpty(userId))
                logs = logs.Where(log => log.UserId == userId).ToList();

            if (!string.IsNullOrEmpty(deviceName))
                logs = logs.Where(log => log.DeviceName == deviceName).ToList();

            if (!string.IsNullOrEmpty(isArchived))
            {
                bool isArchivedBool;
                if (bool.TryParse(isArchived, out isArchivedBool))
                    logs = logs.Where(log => log.Isarchived == isArchivedBool).ToList();
            }

            var viewModel = logs.Select(log => new AllLogViewModel
            {
                LogId = log.LogId,
                ChangeType = log.ChangeType,
                DeviceId = log.DeviceId,
                UserId = log.UserId,
                DeviceName = log.DeviceName,
                Description = log.Description,
                AllotedDate = log.AllotedDate,
                CreatedBy = log.CreatedBy,
                CreatedAt = log.CreatedAt,
                UpdatedAt = log.UpdatedAt,
                UpdatedBy = log.UpdatedBy,
                IsArchived = log.Isarchived ?? false, 
                Timestamp = log.Timestamp,
                CategoryName = log.CategoryName
            }).ToList();

            var changeTypes = logs.Select(log => log.ChangeType).Distinct().ToList();
            var categoryNames = logs.Select(log => log.CategoryName).Distinct().ToList();
            var deviceIds = logs.Select(log => log.DeviceId).Distinct().ToList();
            var userIds = logs.Select(log => log.UserId).Distinct().ToList();
            var deviceNames = logs.Select(log => log.DeviceName).Distinct().ToList();
            var isArchivedOptions = logs.Select(log => log.Isarchived).Distinct().ToList();

            var allDeviceLogsViewModel = new AllDeviceLogsViewModel
            {
                Logs = viewModel,
                ChangeTypes = changeTypes,
                CategoryNames = categoryNames, 
                DeviceIds = deviceIds,
                UserIds = userIds,
                DeviceNames = deviceNames,
                IsArchivedOptions = isArchivedOptions
            };

            return View(allDeviceLogsViewModel);
        }
    }
}
