using KTBook.Data;
using KTBook.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace KTBook.Controllers
{

    public class AdminController : Controller
    {
        private readonly ApplicationDbContext context;
        public AdminController(ApplicationDbContext dbContext)
        {
            context = dbContext;

        }

        [Route("/Admin")]
        public IActionResult Index()
        {
            var categories = context.Category.ToList();
            ViewBag.Checks = categories.Count;
            return View(categories);
        }

        public IActionResult Reset()
        {
            // select user by roles
            var users = context.Users.ToList();
            var roles = context.Roles.ToList();
            ViewBag.Roles = roles;
            return View(users);
        }
        public IActionResult Edit(string? id)
        {
            var users = context.Users.ToList();
            var user = users.Find(p => p.Id == id);
            return View(user);
        }


        [HttpPost]
        public IActionResult Update()
        {
            string id = Request.Form["id"];
            string old_pass = Request.Form["oldpass"];
            string new_pass = Request.Form["newpass"];
            string confirm_pass = Request.Form["confirmpass"];

            ViewData["OldPass"] = old_pass;
            ViewData["NewPass"] = new_pass;
            ViewData["ConfirmPass"] = confirm_pass;

            var list_users = context.Users.ToList();
            var user = list_users.Find(p => p.Id == id);

            var passwordHasher = new PasswordHasher<ApplicationUser>();

            var temp_user = new ApplicationUser
            {
                Id = id,
                UserName = user.UserName,
                Email = user.Email,
                PasswordHash = user.PasswordHash,
            };

            var result = passwordHasher.VerifyHashedPassword(temp_user, user.PasswordHash, old_pass);

            if (result == PasswordVerificationResult.Success)
            {
                if (new_pass == confirm_pass)
                {
                    TempData["Message"] = "Update password successfully!";
                    var new_hash = passwordHasher.HashPassword(temp_user, new_pass);
                    user.PasswordHash = new_hash;
                    context.Users.Update(user);
                    context.SaveChanges();
                    return Redirect("/Admin/Reset");
                }
                else
                {
                    ViewBag.Error1 = "Confirm password is not match";
                    return View("Edit", user);
                }
            }
            else
            {
                ViewBag.Error2 = "Old password is not match";
                return View("Edit", user);
            }

        }

    }
}
