using SmartNotes.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartNotes.Tests
{
    //public class MockDbContext
    //{
    //    int Add(object record);
    //    int Delete(object record);
    //    public int SaveChanges();
    //}

    public interface MockBookService
    {
        int noteCount { get; set; }
        List<NoteViewModel> Get();
        //List<NoteViewModel> GetBooksFilter(string filter);
    }
}
