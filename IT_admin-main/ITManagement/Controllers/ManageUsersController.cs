using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ITManagement.Models;
using Microsoft.AspNetCore.Mvc;

namespace ITManagement.Controllers
{
    public class ManageUsersController : Controller
    {
        private readonly ITManagementContext ITM;
        public ManageUsersController(ITManagementContext _ITM)
        {
            ITM = _ITM;
        }

        public IActionResult getUser()
        {
            List<Users> obj = ITM.Users.ToList();
            ViewBag.user = obj;
            return View();
        }


        [HttpPost]
        public IActionResult CreateUser(Users userModel)
        {
            try
            {
                string defaultCreatedBy = "admin";
                string defaultUpdatedBy = "admin";
                DateTime? defaultUpdatedAt = null;
                DateTime currentDateTime = DateTime.Now;

                if (string.IsNullOrEmpty(userModel.UserId))
                {
                    throw new Exception("User ID cannot be empty.");
                }

                if (string.IsNullOrEmpty(userModel.FullName))
                {
                    throw new Exception("Full Name cannot be empty.");
                }

                if (string.IsNullOrEmpty(userModel.Email) || !IsValidEmail(userModel.Email))
                {
                    throw new Exception("Invalid Email format.");
                }

                var existingUserWithId = ITM.Users.FirstOrDefault(u => u.UserId == userModel.UserId);
                if (existingUserWithId != null)
                {
                    throw new Exception("User with the same ID already exists.");
                }

                var existingUserWithEmail = ITM.Users.FirstOrDefault(u => u.Email == userModel.Email);
                if (existingUserWithEmail != null)
                {
                    throw new Exception("User with the same Email already exists.");
                }

                var userEntity = new Users
                {
                    UserId = userModel.UserId,
                    FullName = userModel.FullName,
                    Email = userModel.Email,
                    CreatedBy = defaultCreatedBy,
                    UpdatedBy = defaultUpdatedBy,
                    UpdatedAt = defaultUpdatedAt,
                    CreatedAt = currentDateTime,
                };

                ITM.Users.Add(userEntity);
                ITM.SaveChanges();
                return Json(new { errorMessage = "" }); // No error message
            }
            catch (Exception ex)
            {
                return Json(new { errorMessage = "An error occurred: " + ex.Message });
            }
        }

        private bool IsValidEmail(string email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
        }





        [HttpPost]
        public IActionResult UpdateUser([FromBody] Users updatedUser)
        {
            if (ModelState.IsValid)
            {
                var existingUser = ITM.Users.FirstOrDefault(U => U.UserId == updatedUser.UserId);

                if (existingUser == null)
                    return NotFound("User not found");

                string defaultUpdatedBy = "admin";
                string defaultCreatedBy = "admin";
                DateTime? defaultUpdatedAt = null;
                DateTime currentDateTime = DateTime.Now;

                existingUser.FullName = updatedUser.FullName;
                existingUser.Email = updatedUser.Email;
                existingUser.CreatedBy = defaultCreatedBy;
                existingUser.UpdatedBy = defaultUpdatedBy;
                existingUser.UpdatedAt = defaultUpdatedAt;
                existingUser.CreatedAt = currentDateTime;

                ITM.SaveChanges();

                return Ok("User updated successfully");
            }
            return BadRequest(ModelState);
        }

        [HttpPost]
        public IActionResult DeleteUser(string deleteUserId)
        {
            var Use = ITM.Users.FirstOrDefault(u => u.UserId == deleteUserId);
            var device = ITM.Devices.ToList().Where(d => d.UserId == deleteUserId);
            if (device.Count() > 0)
            {
                TempData["DisplayAlert"] = true;
                return RedirectToAction("getUser");
            }
            ITM.Users.Remove(Use);
            ITM.SaveChanges();
            return RedirectToAction("getUser");
        }

        [HttpGet]
        public IActionResult Edit(string userId)
        {
            var data = ITM.Users.Where(x => x.UserId == userId).FirstOrDefault();
            return View(data);
        }

        [HttpPost]
        public IActionResult Edit(Users Model)
        {
            try
            {
                if (string.IsNullOrEmpty(Model.FullName))
                {
                    throw new Exception("Full Name cannot be empty.");
                }

                if (string.IsNullOrEmpty(Model.Email))
                {
                    throw new Exception("Email cannot be empty.");
                }

                if (!IsValidEmail(Model.Email))
                {
                    throw new Exception("Invalid Email format.");
                }

                var data = ITM.Users.FirstOrDefault(x => x.UserId == Model.UserId);

                if (data != null)
                {
                    var existingUserWithEmail = ITM.Users.FirstOrDefault(u => u.Email == Model.Email && u.UserId != Model.UserId);
                    if (existingUserWithEmail != null)
                    {
                        throw new Exception("User with the same Email already exists.");
                    }

                    data.FullName = Model.FullName;
                    data.Email = Model.Email;
                    data.UpdatedAt = DateTime.Now;
                    ITM.SaveChanges();
                }

                return RedirectToAction("getUser");
            }
            catch (Exception ex)
            {
                return Json(new { errorMessage = "An error occurred: " + ex.Message });
            }
        }


    }
}