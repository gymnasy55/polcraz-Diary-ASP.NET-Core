using System;
using System.ComponentModel.DataAnnotations;

namespace MyDiaryWebTest.Domain.Entities
{
    public class EntityBase
    {
        protected EntityBase() => DateAdded = DateTime.UtcNow;
        [Required]
        public Guid Id { get; set; }

        [DataType(DataType.Time)]
        public DateTime DateAdded { get; set; }
    }
}
