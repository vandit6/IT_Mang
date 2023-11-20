using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ITManagement.Models;
using ITManagement.ViewModels;

namespace ITManagement.Controllers
{
    public class ManageDevicesController : Controller
    {
        private readonly ITManagementContext _context;
        public ManageDevicesController(ITManagementContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            ViewBag.CategoryId = _context.Categories
                 .Where(c => c.Isarchived == false)
                 .Select(val => new SelectListItem
                 {
                     Text = val.CategoryName,
                     Value = val.CategoryId.ToString()

                 }).ToList();
            ViewBag.UserId = new SelectList(_context.Users.Where(u => u.Isarchived == false), "UserId", "UserId");

            ViewBag.Device = _context.Devices.Include(d => d.User).Include(d => d.Category).ToList();

            return View();
        }

        public IActionResult DeviceHistory(int deviceId)
        {
            var deviceHistories = _context.DeviceHistory.Where(dh => dh.DeviceId == deviceId).ToList();
            return View(deviceHistories);
        }

        [HttpPost]
        public IActionResult History(Devices updatedDevice)
        {
            var deviceHistory = new DeviceHistory
            {
                DeviceId = updatedDevice.DeviceId,
                CategoryId = updatedDevice.CategoryId,
                UserId = updatedDevice.Status ? updatedDevice.UserId : null, 
                UpdatedBy = "Admin",
                UpdatedAt = DateTime.Now,
                Description = updatedDevice.Description,
                DeviceName = _context.Devices
                    .Where(d => d.DeviceId == updatedDevice.DeviceId)
                    .Select(d => d.DeviceName)
                    .FirstOrDefault(),
                UserName = updatedDevice.Status && updatedDevice.UserId != null
                    ? _context.Users
                        .Where(u => u.UserId == updatedDevice.UserId)
                        .Select(u => u.FullName)
                        .FirstOrDefault()
                    : null,
                CategoryName = updatedDevice.CategoryId != null
                    ? _context.Categories
                        .Where(c => c.CategoryId == updatedDevice.CategoryId)
                        .Select(c => c.CategoryName)
                        .FirstOrDefault()
                    : null
            };

            _context.DeviceHistory.Add(deviceHistory);
            _context.SaveChanges();


            return View("Index");
        }



        [HttpPost]
        public IActionResult DeviceFilter(int? CategoryId, string Status, string DeviceName, string FullName)
        {
            List<Categories> allCategories = _context.Categories.ToList();

            ViewBag.Categories = new SelectList(allCategories, "CategoryId", "CategoryName");

            ViewBag.CategoryId = _context.Categories
               .Select(val => new SelectListItem
               {
                   Text = val.CategoryName,
                   Value = val.CategoryId.ToString()
               }).ToList();

            ViewBag.UserId = new SelectList(_context.Users, "UserId", "UserId");
            ViewBag.Device = _context.Devices.Include(d => d.User).Include(d => d.Category).ToList();

            var devicesQuery = _context.Devices.AsQueryable();

            if (CategoryId.HasValue && CategoryId > 0)
            {
                devicesQuery = devicesQuery.Where(d => d.CategoryId == CategoryId);
            }

            if (!string.IsNullOrEmpty(Status))
            {
                bool statusValue;
                if (bool.TryParse(Status, out statusValue))
                {
                    devicesQuery = devicesQuery.Where(d => d.Status == statusValue);
                }
            }

            if (!string.IsNullOrEmpty(FullName))
            {
                devicesQuery = devicesQuery.Where(d => d.User.FullName.Contains(FullName, StringComparison.OrdinalIgnoreCase));
            }

            if (!string.IsNullOrEmpty(DeviceName))
            {
                devicesQuery = devicesQuery.Where(d => d.DeviceName.Contains(DeviceName, StringComparison.OrdinalIgnoreCase));
            }

            var devices = devicesQuery.ToList();

            var viewModel = new DeviceViewModel
            {
                Category = allCategories,
                Device = devices,
                SelectedCategoryId = CategoryId ?? 0,
                SelectedStatus = string.IsNullOrEmpty(Status) ? false : bool.Parse(Status),
                SelectedDeviceName = DeviceName,
                SelectedUserName = FullName
            };

            foreach (var device in viewModel.Device)
            {
                if (device.UserId != null)
                {
                    device.User = new Users
                    {
                        FullName = _context.Users.FirstOrDefault(u => u.UserId == device.UserId)?.FullName,
                        UserId = _context.Users.FirstOrDefault(u => u.UserId == device.UserId)?.UserId
                    };
                }

                if (device.CategoryId != 0)
                {
                    device.Category = new Categories
                    {
                        CategoryName = _context.Categories.FirstOrDefault(c => c.CategoryId == device.CategoryId)?.CategoryName
                    };
                }
            }

            ViewBag.Device = viewModel.Device;
            
            return View("Index");

        }



        [HttpGet]
        public IActionResult Create()
        {
            List<Categories> list = _context.Categories.ToList();
            var put = list.Select(val => new SelectListItem
            {
                Text = val.CategoryName,
                Value = val.CategoryId.ToString(),
            }).ToList();
            ViewBag.CategoryId = put;
            ViewBag.UserId = new SelectList(_context.Users, "UserId", "UserId");
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create([Bind("DeviceName,CategoryId,Description,Status,UserId,AllotedDate,CreatedBy,CreatedAt,UpdatedAt,UpdatedBy")] Devices devices)
        {
            try
            {
                if (string.IsNullOrEmpty(devices.DeviceName))
                    throw new Exception("Device Name cannot be empty.");

                if (devices.CategoryId == 0)
                    throw new Exception("Please select a valid Category.");

                if (string.IsNullOrEmpty(devices.Description))
                    throw new Exception("Description cannot be empty.");

                if (devices.Status && !string.IsNullOrEmpty(devices.UserId))
                    devices.AllotedDate = DateTime.Now;
                else
                {
                    devices.AllotedDate = null;
                    devices.UserId = null;
                    if (devices.Status)
                        throw new Exception("Select a valid user if you want to keep the device allocated.");
                }

                var duplicateDevice = await _context.Devices.FirstOrDefaultAsync(d => d.DeviceName == devices.DeviceName);
                if (duplicateDevice != null)
                    throw new Exception("A device with the same name already exists.");

                devices.CreatedBy = "admin";
                devices.UpdatedBy = "admin";
                devices.UpdatedAt = DateTime.Now;

                devices.CreatedAt = DateTime.Now;
                if (devices.Status)
                    devices.AllotedDate = DateTime.Now;
                else
                    devices.AllotedDate = null;

                _context.Add(devices);
                await _context.SaveChangesAsync(); 
                var categoryName = _context.Categories
                                .Where(c => c.CategoryId == devices.CategoryId)
                                .Select(c => c.CategoryName)
                                .FirstOrDefault();
                var allDeviceLog = new AllDeviceLogs
                {
                    ChangeType = "Create",
                    DeviceId = devices.DeviceId, 
                    CategoryName = categoryName,
                    UserId = devices.UserId,
                    DeviceName = devices.DeviceName,
                    Description = devices.Description,
                    AllotedDate = devices.AllotedDate,
                    CreatedBy = devices.CreatedBy,
                    CreatedAt = devices.CreatedAt,
                    UpdatedAt = null,
                    UpdatedBy = null,
                    Isarchived = devices.Isarchived,
                    Timestamp = DateTime.Now
                };

                _context.AllDeviceLogs.Add(allDeviceLog);

                await _context.SaveChangesAsync();

                return Json(new { errorMessage = "" });
            }
            catch (Exception ex)
            {
                return Json(new { errorMessage = "An error occurred: " + ex.Message });
            }
        }


        [HttpPost]
        public IActionResult DeleteDevice(int deleteDeviceId)
        {
            try
            {
                var existingDevice = _context.Devices.FirstOrDefault(u => u.DeviceId == deleteDeviceId);

                if (existingDevice == null)
                {
                    throw new Exception("Device not found for deletion.");
                }

                var deviceHistoriesToDelete = _context.DeviceHistory.Where(dh => dh.DeviceId == deleteDeviceId).ToList();
                if (deviceHistoriesToDelete.Any())
                {
                    _context.DeviceHistory.RemoveRange(deviceHistoriesToDelete);
                }
                existingDevice.Isarchived = true;
                var categoryName = _context.Categories
                                  .Where(c => c.CategoryId == existingDevice.CategoryId)
                                  .Select(c => c.CategoryName)
                                  .FirstOrDefault();
                var allDeviceLog = new AllDeviceLogs
                {
                    ChangeType = "Delete",
                    DeviceId = existingDevice.DeviceId,
                    CategoryName = categoryName,
                    UserId = existingDevice.UserId,
                    DeviceName = existingDevice.DeviceName,
                    Description = existingDevice.Description,
                    AllotedDate = existingDevice.AllotedDate,
                    CreatedBy = existingDevice.CreatedBy,
                    CreatedAt = existingDevice.CreatedAt,
                    UpdatedAt = existingDevice.UpdatedAt,
                    UpdatedBy = existingDevice.UpdatedBy,
                    Isarchived = existingDevice.Isarchived,
                    Timestamp = DateTime.Now
                };

                _context.AllDeviceLogs.Add(allDeviceLog);
                _context.SaveChanges();

                return RedirectToAction("Index");
            }
            catch (Exception ex)
            {
                return Json(new { errorMessage = "An error occurred: " + ex.Message });
            }
        }

        [HttpPost]
        public IActionResult Edit(Devices updatedDevice)
        {
            try
            {
                if (string.IsNullOrEmpty(updatedDevice.DeviceName))
                    throw new Exception("Device name cannot be empty.");

                if (updatedDevice.CategoryId == 0)
                    throw new Exception("Category ID cannot be empty.");

                if (string.IsNullOrEmpty(updatedDevice.Description))
                    throw new Exception("Description cannot be empty.");

                if (updatedDevice.Status && updatedDevice.UserId == null)
                    throw new Exception("User ID cannot be empty when the status is true.");

                var existingDevice = _context.Devices.FirstOrDefault(D => D.DeviceId == updatedDevice.DeviceId);

                if (existingDevice == null)
                    return NotFound("Device not found");

                string defaultUpdatedBy = "admin";
                string defaultCreatedBy = "admin";
                DateTime? defaultUpdatedAt = null;
                DateTime currentDateTime = DateTime.Now;

                existingDevice.DeviceName = updatedDevice.DeviceName;
                existingDevice.CategoryId = updatedDevice.CategoryId;
                existingDevice.Description = updatedDevice.Description;
                existingDevice.Status = updatedDevice.Status;

                if (existingDevice.Status == false)
                {
                    existingDevice.AllotedDate = null;
                    existingDevice.UserId = null;
                }
                else
                {
                    existingDevice.UserId = updatedDevice.UserId;
                    existingDevice.AllotedDate = currentDateTime;
                }

                existingDevice.CreatedBy = defaultCreatedBy;
                existingDevice.UpdatedBy = defaultUpdatedBy;
                existingDevice.UpdatedAt = defaultUpdatedAt;
                existingDevice.CreatedAt = currentDateTime;



                var categoryName = _context.Categories
                    .Where(c => c.CategoryId == updatedDevice.CategoryId)
                    .Select(c => c.CategoryName)
                    .FirstOrDefault();
                var allDeviceLog = new AllDeviceLogs
                {
                    ChangeType = "Edit",
                    DeviceId = existingDevice.DeviceId,
                    CategoryName = categoryName,
                    UserId = existingDevice.UserId,
                    DeviceName = existingDevice.DeviceName,
                    Description = existingDevice.Description,
                    AllotedDate = existingDevice.AllotedDate,
                    CreatedBy = existingDevice.CreatedBy,
                    CreatedAt = existingDevice.CreatedAt,
                    UpdatedAt = existingDevice.UpdatedAt,
                    UpdatedBy = existingDevice.UpdatedBy,
                    Isarchived = existingDevice.Isarchived,
                    Timestamp = DateTime.Now
                };

                _context.AllDeviceLogs.Update(allDeviceLog);

                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred: " + ex.Message);
                Console.WriteLine("Stack Trace: " + ex.StackTrace);

                return Json(new { errorMessage = "An error occurred: " + ex.Message });
            }
        }



        [HttpPost]
        public ActionResult UpdateAllDevices(editManyDeviceModel InpDevices)
        {
            try
            {
                if (InpDevices.selectedDeviceIds == null || InpDevices.selectedDeviceIds.Count == 0)
                    throw new Exception("No devices were selected.");

                if (InpDevices.isUpdateCategory && InpDevices.categoryId == 0)
                    throw new Exception("Please select a category.");

                foreach (var deviceId in InpDevices.selectedDeviceIds)
                {
                    var existingDevice = _context.Devices.FirstOrDefault(D => D.DeviceId == deviceId);

                    if (existingDevice != null)
                    {
                        if (InpDevices.isUpdateCategory)
                            existingDevice.CategoryId = InpDevices.categoryId;

                        if (InpDevices.isAllotment)
                        {
                            if (InpDevices.status && string.IsNullOrEmpty(InpDevices.userId))
                                throw new Exception("User ID cannot be empty when device status is true.");

                            existingDevice.Status = InpDevices.status;

                            if (!InpDevices.status)
                            {
                                existingDevice.AllotedDate = null;
                                existingDevice.UserId = null;
                            }
                            else
                            {

                                if (!_context.Users.Any(u => u.UserId == InpDevices.userId))
                                    throw new Exception($"User with ID {InpDevices.userId} does not exist.");

                                existingDevice.UserId = InpDevices.userId;
                                existingDevice.AllotedDate = DateTime.Now;
                            }
                        }
                        var categoryName = _context.Categories
                                            .Where(c => c.CategoryId == existingDevice.CategoryId)
                                            .Select(c => c.CategoryName)
                                            .FirstOrDefault();
                        var allDeviceLog = new AllDeviceLogs
                        {
                            ChangeType = "Update Many",
                            DeviceId = existingDevice.DeviceId,
                            CategoryName = categoryName,
                            UserId = existingDevice.UserId,
                            DeviceName = existingDevice.DeviceName,
                            Description = existingDevice.Description,
                            AllotedDate = existingDevice.AllotedDate,
                            CreatedBy = existingDevice.CreatedBy,
                            CreatedAt = existingDevice.CreatedAt,
                            UpdatedAt = DateTime.Now,
                            UpdatedBy = existingDevice.UpdatedBy,
                            Isarchived = existingDevice.Isarchived,
                            Timestamp = DateTime.Now
                        };

                        _context.AllDeviceLogs.Add(allDeviceLog);
                        _context.SaveChanges();
                    }
                }

                return RedirectToAction("Index");
            }
            catch (Exception ex)
            {
                return Json(new { errorMessage = "An error occurred: " + ex.Message });
            }
        }

    }
}