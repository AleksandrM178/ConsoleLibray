using ConsoleLibray.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleLibray.DAL.Contracts
{
    public interface ILibraryDao
    {
        void Create(Library library);
    }
}
