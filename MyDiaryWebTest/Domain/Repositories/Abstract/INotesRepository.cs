using System;
using System.Linq;
using MyDiaryWebTest.Domain.Entities;

namespace MyDiaryWebTest.Domain.Repositories.Abstract
{
    public interface INotesRepository
    {
        IQueryable<Note> GetNotesByUserId(Guid id);
        Note GetNoteById(Guid id);
        void SaveNote(Note note);
        void DeleteNote(Guid id);
    }
}
