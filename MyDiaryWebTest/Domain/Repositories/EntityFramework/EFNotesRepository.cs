using System;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using MyDiaryWebTest.Domain.Entities;
using MyDiaryWebTest.Domain.Repositories.Abstract;

namespace MyDiaryWebTest.Domain.Repositories.EntityFramework
{
    public class EFNotesRepository : INotesRepository
    {
        private readonly AppDbContext _context;

        public EFNotesRepository(AppDbContext context) => _context = context;

        public IQueryable<Note> GetNotesByUserId(Guid id) => _context.Notes.Where(x => x.UserId == id);

        public Note GetNoteById(Guid id) => _context.Notes.FirstOrDefault(x => x.Id == id);

        public void SaveNote(Note note)
        {
            _context.Entry(note).State = note.Id == default ? EntityState.Added : EntityState.Modified;
            _context.SaveChanges();
        }

        public void DeleteNote(Guid id)
        {
            _context.Notes.Remove(new Note { Id = id });
            _context.SaveChanges();
        }
    }
}
