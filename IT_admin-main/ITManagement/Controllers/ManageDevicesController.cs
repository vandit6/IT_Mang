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
                .Select(val => new SelectListItem
                {
                    Text = val.CategoryName,
                    Value = val.CategoryId.ToString()
                }).ToList();

            ViewBag.UserId = new SelectList(_context.Users, "UserId", "UserId");
            ViewBag.Device = _context.Devices.Include(d => d.User).Include(d => d.Category).ToList();

            return View();
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
        public IActionResult Create([Bind("DeviceName,CategoryId,Description,Status,UserId,AllotedDate,CreatedBy,CreatedAt,UpdatedAt,UpdatedBy")] Devices devices)
        {
            try
            {
                if (string.IsNullOrEmpty(devices.DeviceName))
                {
                    throw new Exception("Device Name cannot be empty.");
                }

                if (devices.CategoryId == 0)
                {
                    throw new Exception("Please select a valid Category.");
                }

                if (string.IsNullOrEmpty(devices.Description))
                {
                    throw new Exception("Description cannot be empty.");
                }

                if (devices.Status && !string.IsNullOrEmpty(devices.UserId))
                {
                    // Device is allotted
                    devices.AllotedDate = DateTime.Now;
                }
                else
                {
                    // Device is unallotted
                    devices.AllotedDate = null;
                    devices.UserId = null; // Ensure that UserId is null for unallotted devices
                    if (devices.Status)
                        throw new Exception("Select a valid user if you want to keep device allocated.");
                }

                // Check for duplicate devices
                var duplicateDevice = _context.Devices.FirstOrDefault(d => d.DeviceName == devices.DeviceName);
                if (duplicateDevice != null)
                {
                    throw new Exception("A device with the same name already exists.");
                }

                devices.CreatedBy = "admin";
                devices.UpdatedBy = "admin";
                devices.UpdatedAt = DateTime.Now;

                devices.CreatedAt = DateTime.Now;
                if (devices.Status)
                    devices.AllotedDate = DateTime.Now;
                else
                    devices.AllotedDate = null;
                _context.Add(devices);
                _context.SaveChanges();

                return Json(new { errorMessage = "" }); // No error message
            }
            catch (Exception ex)
            {
                return Json(new { errorMessage = "An error occurred: " + ex.Message });
            }
        }


        [HttpPost]
        public IActionResult DeleteDevice(int deleteDeviceId)
        {
            var Use = _context.Devices.FirstOrDefault(u => u.DeviceId == deleteDeviceId);

            _context.Devices.Remove(Use);
            _context.SaveChanges();

            return RedirectToAction("Index");
        }
        [HttpPost]
        public IActionResult Edit(Devices updatedDevice)
        {
            try
            {
                if (string.IsNullOrEmpty(updatedDevice.DeviceName))
                {
                    throw new Exception("Device name cannot be empty.");
                }

                if (updatedDevice.CategoryId == 0)
                {
                    throw new Exception("Category ID cannot be empty.");
                }

                if (string.IsNullOrEmpty(updatedDevice.Description))
                {
                    throw new Exception("Description cannot be empty.");
                }

                if (updatedDevice.Status && updatedDevice.UserId == null)
                {
                    throw new Exception("User ID cannot be empty when the status is true.");
                }

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

                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            catch (Exception ex)
            {
                return Json(new { errorMessage = "An error occurred: " + ex.Message });
            }
        }




        [HttpPost]
        public ActionResult UpdateAllDevices(editManyDeviceModel InpDevices)
        {
            try
            {
                if (InpDevices.selectedDeviceIds == null || InpDevices.selectedDeviceIds.Count == 0)
                {
                    throw new Exception("No devices were selected.");
                }

                if (InpDevices.isUpdateCategory && InpDevices.categoryId == 0)
                {
                    throw new Exception("Please select a category.");
                }

                foreach (var deviceId in InpDevices.selectedDeviceIds)
                {
                    var existingDevice = _context.Devices.FirstOrDefault(D => D.DeviceId == deviceId);

                    if (existingDevice != null)
                    {
                        if (InpDevices.isUpdateCategory)
                        {
                            existingDevice.CategoryId = InpDevices.categoryId;
                        }

                        if (InpDevices.isAllotment)
                        {
                            if (InpDevices.status && string.IsNullOrEmpty(InpDevices.userId))
                            {
                                throw new Exception("User ID cannot be empty when device status is true.");
                            }

                            existingDevice.Status = InpDevices.status;

                            if (!InpDevices.status)
                            {
                                existingDevice.AllotedDate = null;
                                existingDevice.UserId = null;
                            }
                            else
                            {

                                if (!_context.Users.Any(u => u.UserId == InpDevices.userId))
                                {
                                    throw new Exception($"User with ID {InpDevices.userId} does not exist.");
                                }

                                existingDevice.UserId = InpDevices.userId;
                                existingDevice.AllotedDate = DateTime.Now;
                            }
                        }
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