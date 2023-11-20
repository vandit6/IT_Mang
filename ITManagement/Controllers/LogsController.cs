using System;
using System.Collections.Generic;
using System.Linq;
using ITManagement.Models;
using ITManagement.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace ITManagement.Controllers
{
    public class LogsController : Controller
    {
        private readonly ITManagementContext ITM;

        public LogsController(ITManagementContext _ITM)
        {
            ITM = _ITM;
        }

        public IActionResult Logs(string categoryId, string deviceId, string userId, string deviceName, string isArchived, DateTime? changeDate)
        {
            var logs = ITM.DevicesLog.ToList();

            if (!string.IsNullOrEmpty(categoryId))
                logs = logs.Where(log => log.CategoryId.ToString() == categoryId).ToList();

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

            if (changeDate.HasValue)
                logs = logs.Where(log => log.ChangeDate.HasValue && log.ChangeDate.Value.Date == changeDate.Value.Date).ToList();

            var viewModel = logs.Select(log => new LogViewModel
            {
                LogId = log.LogId,
                ChangeType = log.ChangeType,
                ChangeDate = log.ChangeDate,
                DeviceId = log.DeviceId,
                CategoryId = log.CategoryId,
                UserId = log.UserId,
                DeviceName = log.DeviceName,
                Description = log.Description,
                Status = log.Status,
                AllotedDate = log.AllotedDate,
                CreatedBy = log.CreatedBy,
                CreatedAt = log.CreatedAt,
                UpdatedAt = log.UpdatedAt,
                UpdatedBy = log.UpdatedBy,
                IsArchived = log.Isarchived ?? false, 
                Action = log.Action,
                Timestamp = log.Timestamp
            }).ToList();

            var categoryIds = logs.Select(log => log.CategoryId).Distinct().ToList();
            var deviceIds = logs.Select(log => log.DeviceId).Distinct().ToList();
            var userIds = logs.Select(log => log.UserId).Distinct().ToList();
            var deviceNames = logs.Select(log => log.DeviceName).Distinct().ToList();
            var isArchivedOptions = logs.Select(log => log.Isarchived).Distinct().ToList();

            var logFilterViewModel = new LogFilterViewModel
            {
                Logs = viewModel,
                CategoryIds = categoryIds,
                DeviceIds = deviceIds,
                UserIds = userIds,
                DeviceNames = deviceNames,
                IsArchivedOptions = isArchivedOptions,
                ChangeDate = changeDate
            };

            return View(logFilterViewModel);
        }
    }
}
