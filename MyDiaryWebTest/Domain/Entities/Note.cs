using System;
using System.ComponentModel.DataAnnotations;

namespace MyDiaryWebTest.Domain.Entities
{
    public class Note : EntityBase
    {
        [Required]
        public Guid UserId { get; set; }
        
        [Required]
        public string Title { get; set; }

        [Required]
        public string Text { get; set; }
    }
}
