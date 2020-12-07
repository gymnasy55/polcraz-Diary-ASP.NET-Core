using System.Collections.Generic;
using Microsoft.AspNetCore.Identity;
using MyDiaryWebTest.Domain.Entities;

namespace MyDiaryWebTest.ViewModels
{
    public class MainViewModel
    {
        public IdentityUser User { get; set; }
        public List<Note> Notes { get; set; }
    }
}
