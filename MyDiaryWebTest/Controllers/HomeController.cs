using System;
using System.Linq;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using MyDiaryWebTest.Domain;
using MyDiaryWebTest.ViewModels;

namespace MyDiaryWebTest.Controllers
{
    [Authorize]
    public class HomeController : Controller
    {
        private readonly DataManager _dataManager;
        private readonly UserManager<IdentityUser> _userManager;

        public HomeController(DataManager dataManager, UserManager<IdentityUser> userManager)
        {
            _dataManager = dataManager;
            _userManager = userManager;
        }

        [AllowAnonymous]
        public IActionResult Index()
        {
            if (!HttpContext.User.Identity.IsAuthenticated)
                return View();
            var user = _userManager.Users.FirstOrDefault(x => x.Id == _userManager.GetUserId(HttpContext.User));
            var userNotes = _dataManager.Notes.GetNotesByUserId(Guid.Parse(user.Id.ToUpper())).OrderBy(s => s.DateAdded).ToList();
            return View(new MainViewModel {User = user, Notes = userNotes});
        }
    }
}