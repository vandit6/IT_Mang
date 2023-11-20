using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ITManagement.Models;
using ITManagement.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ITManagement.Controllers
{
    public class DashboardController : Controller
    {
        private readonly ITManagementContext ITM;

        public DashboardController(ITManagementContext _ITM)
        {
            ITM = _ITM;
        }

        public IActionResult Dashboard()
        {

            var viewModel = new DashboardViewModel
            {
                NumberOfDevices = ITM.Devices.Where(d=>d.Isarchived==false).Count(),
                NumberOfUsers = ITM.Users.Where(d=>d.Isarchived==false).Count(),
                NumberOfAllottedDevices = ITM.Devices.Where(d => d.Isarchived == false).Count(d => d.Status == true),
                NumberOfUnAllottedDevices = ITM.Devices.Where(d => d.Isarchived == false).Count(d => !d.Status),
                BarChartData = ITM.Categories.Select(c => new BarChartData
                {
                    Category = c.CategoryName,
                    NumberOfUsers = c.Devices.Where(d => d.Isarchived == false).Count(),
                    NumberOfAllottedDevices=c.Devices.Where(d => d.Isarchived == false).Count(d => d.Status == true)
                }).ToList(),

                DeviceLogs = ITM.AllDeviceLogs
                    .OrderByDescending(log => log.Timestamp)
                    .Take(4)
                    .Select(log => new DashboardLogViewModel
                    {
                        LogId = log.LogId,
                        ChangeType = log.ChangeType,
                        DeviceId = log.DeviceId.GetValueOrDefault(),
                        CategoryName = ITM.Devices
                    .Where(d => d.DeviceId == log.DeviceId && !d.Isarchived)
                    .Select(d => d.Category.CategoryName)
                    .FirstOrDefault(),
                        UserId = log.UserId,
                        DeviceName = log.DeviceName,
                        Description = log.Description,
                        AllotedDate = log.AllotedDate,
                        Timestamp=log.Timestamp
                        // Add other relevant fields
                    })
                    .ToList()
            };

            return View(viewModel);
        }
    }
}