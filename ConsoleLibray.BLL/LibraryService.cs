using ConsoleLibray.BLL.Contracts;
using ConsoleLibray.Core.Models;
using ConsoleLibray.DAL;
using ConsoleLibray.DAL.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleLibray.BLL
{
    public class LibraryService : ILibraryService
    {
        private readonly ILibraryDao _libraryDao = new LibraryDao();
        public void Create(string name, int count)
        {
            var library = new Library(name, count);
            _libraryDao.Create(library);
        }
    }
}
