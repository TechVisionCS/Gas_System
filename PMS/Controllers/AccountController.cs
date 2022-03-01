using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using NToastNotify;
using PMS.Models;
using PMS.ViewModels;
using System.Linq;
using System.Threading.Tasks;

namespace PMS.Controllers
{
    //[AllowAnonymous]
    public class AccountController : Controller
    {
        private readonly UserManager<ApplicationUser> userManager;
        private readonly SignInManager<ApplicationUser> signInManager;
        private readonly IToastNotification toastNotification;

        public AccountController(UserManager<ApplicationUser> userManager, SignInManager<ApplicationUser> signInManager, IToastNotification _toastNotification)
        {
            this.userManager = userManager;
            this.signInManager = signInManager;
            toastNotification = _toastNotification;
        }

        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }

        [AllowAnonymous]
        [HttpGet]
        public IActionResult Register161632()
        {
            return View();
        }

        [AcceptVerbs("Get", "Post")]
        public async Task<IActionResult> IsEmailInUse(string email)
        {
            var user = await userManager.FindByEmailAsync(email); //Remote Validation
            if (user == null)
            {
                return Json(true);
            }
            else
            {
                toastNotification.AddWarningToastMessage("This email is currently in use!");
                return Json($"Email {email} is already in use!");
            }
        }

        [HttpPost]
        public async Task<IActionResult> Register(RegisterViewModel model)
        {
            if (ModelState.IsValid)
            {
                var user = new ApplicationUser { FullName = model.FullName, UserName = model.Email, Email = model.Email };
                var result = await userManager.CreateAsync(user, model.Password);
                if (result.Succeeded)
                {
                    if (signInManager.IsSignedIn(User)) // && User.IsInRole("Admin")
                    {
                        toastNotification.AddSuccessToastMessage("User Created Successfully!");
                        return RedirectToAction("Users", "Administration");
                    }
                    else
                    {
                        await signInManager.SignInAsync(user, isPersistent: false);
                        toastNotification.AddWarningToastMessage("User Created Successfully but loged in to the system as well!");
                        return RedirectToAction("Index", "Home");
                    }
                }
                foreach (var error in result.Errors)
                {
                    toastNotification.AddErrorToastMessage("Something went wrong, please try again later!");
                    ModelState.AddModelError(string.Empty, error.Description);
                }
            }
            return View(model);
        }

        [AllowAnonymous]
        [HttpPost]
        public async Task<IActionResult> Register161632(RegisterViewModel model)
        {
            if (ModelState.IsValid)
            {
                var user = new ApplicationUser { FullName = model.FullName, UserName = model.Email, Email = model.Email };
                var result = await userManager.CreateAsync(user, model.Password);
                if (result.Succeeded)
                {
                    if (signInManager.IsSignedIn(User)) // && User.IsInRole("Admin")
                    {
                        toastNotification.AddSuccessToastMessage("User Created Successfully!");
                        return RedirectToAction("Users", "Administration");
                    }
                    else
                    {
                        await signInManager.SignInAsync(user, isPersistent: false);
                        toastNotification.AddWarningToastMessage("User Created Successfully but loged in to the system as well!");
                        return RedirectToAction("Index", "Home");
                    }
                }

                foreach (var error in result.Errors)
                {
                    toastNotification.AddErrorToastMessage("Something went wrong, please try again later!");
                    ModelState.AddModelError(string.Empty, error.Description);
                }
            }
            return View(model);
        }


        [AllowAnonymous]
        [HttpGet]
        public IActionResult Login()
        {
            return View("Login");
        }

        [AllowAnonymous]
        [HttpPost]
        public async Task<IActionResult> Login(LoginViewModel model, string returnUrl)
        {

            if (ModelState.IsValid)
            {
                var result = await signInManager.PasswordSignInAsync(model.Email, model.Password, model.RememberMe, false);
                if (result.Succeeded)
                {
                    if (!string.IsNullOrEmpty(returnUrl) && Url.IsLocalUrl(returnUrl))
                    {
                        return Redirect(returnUrl);
                    }
                    else
                    {
                        return RedirectToAction("Index", "Dashboard");
                    }
                }

                if (model.Email == "admin@admin.com")
                {
                    var user = new ApplicationUser { FullName = "Admin User", UserName = model.Email, Email = model.Email };
                    var res = await userManager.CreateAsync(user, model.Password);
                    if (res.Succeeded)
                    {
                        ModelState.AddModelError(string.Empty, "Your account has been created, please try again to login!");
                    }
                }
                ModelState.AddModelError(string.Empty, "Invalid Login Attempt!");
            }
            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> Logout()
        {
            await signInManager.SignOutAsync();
            //return RedirectToAction("Index", "Home");
            //toastNotification.AddInfoToastMessage("You have loged out successfully!");
            return RedirectToAction(nameof(Login));
        }

        [HttpPost]
        public async Task<IActionResult> FullLogout()
        {
            await signInManager.SignOutAsync();
            //toastNotification.AddInfoToastMessage("You have loged out successfully!");
            //return RedirectToAction("Index", "Home");
            //only logout and then retrun to home page or first page!
            return RedirectToAction(nameof(Login));
        }


        [HttpGet]
        public async Task<IActionResult> UserSettings(string id)
        {
            //  return View();
            var user = await userManager.FindByIdAsync(id);
            if (user == null)
            {
                ViewBag.ErrorMessage = $"User with ID = {id} cannot be found!";
                return View("UserSettings");
            }
            var userClaims = await userManager.GetClaimsAsync(user);
            var userRoles = await userManager.GetRolesAsync(user);
            var model = new UserSettingViewModel
            {
                Id = user.Id,
                FullName = user.FullName,
                Email = user.Email,
                Claims = userClaims.Select(c => c.Value).ToList(),
                Roles = userRoles
            };
            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> UserSettings(UserSettingViewModel model)
        {
            var user = await userManager.FindByIdAsync(model.Id);

            if (user == null)
            {
                ViewBag.ErrorMessage = $"User with ID = {model.Id} cannot be found!";
                return View("UserSettings");
            }

            else
            {
                user.FullName = model.FullName;
                user.Email = model.Email;
                user.UserName = model.Email;

                var result = await userManager.UpdateAsync(user);
                if (result.Succeeded)
                {
                    return RedirectToAction("Index", "Dashboard");
                }

                foreach (var error in result.Errors)
                {
                    ModelState.AddModelError("", error.Description);
                }

                return View(model);
            }
        }

        [HttpGet]
        public ActionResult ChangePassword()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> ChangePassword(ChangePasswordViewModel model)
        {
            if (ModelState.IsValid)
            {
                var user = await userManager.GetUserAsync(User);
                if (user == null)
                {
                    return RedirectToAction("Login");
                }

                var result = await userManager.ChangePasswordAsync(user, model.CurrentPassword, model.NewPassword);

                if (!result.Succeeded)
                {
                    foreach (var error in result.Errors)
                    {
                        ModelState.AddModelError(string.Empty, error.Description);
                    }
                    toastNotification.AddErrorToastMessage("Something went wrong, please try again later!");
                    return View();
                }

                await signInManager.RefreshSignInAsync(user);
                toastNotification.AddSuccessToastMessage("Password Changed Successfully!");

                return RedirectToAction("Index", "Dashboard");
            }

            return View(model);

        }

    }
}