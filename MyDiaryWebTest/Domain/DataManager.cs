using MyDiaryWebTest.Domain.Repositories.Abstract;

namespace MyDiaryWebTest.Domain
{
    public class DataManager
    {
        public INotesRepository Notes { get; set; }

        public DataManager(INotesRepository notes)
        {
            Notes = notes;
        }
    }
}
