using System;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using MyDiaryWebTest.Domain;
using MyDiaryWebTest.Domain.Entities;
using MyDiaryWebTest.Service;

namespace MyDiaryWebTest.Controllers
{
    public class NoteController : Controller
    {
        private readonly DataManager _dataManager;
        private readonly UserManager<IdentityUser> _userManager;

        public NoteController(DataManager dataManager, UserManager<IdentityUser> userManager)
        {
            _dataManager = dataManager;
            _userManager = userManager;
        } 

        public IActionResult Edit(Guid id)
        {
            var note = id == default ? new Note { UserId = Guid.Parse(_userManager.GetUserId(HttpContext.User))} : _dataManager.Notes.GetNoteById(id);
            return View(note);
        }

        [HttpPost]
        public IActionResult Edit(Note model)
        {
            if (ModelState.IsValid)
            {
                _dataManager.Notes.SaveNote(model);
                return RedirectToAction(nameof(HomeController.Index), nameof(HomeController).CutController());
            }
            return View(model);
        }

        [HttpPost]
        public IActionResult Delete(Guid id)
        {
            _dataManager.Notes.DeleteNote(id);
            return RedirectToAction(nameof(HomeController.Index), nameof(HomeController).CutController());
        }
    }
}