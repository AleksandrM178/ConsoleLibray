using ConsoleLibray.Core.Models;
using ConsoleLibray.DAL.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace ConsoleLibray.DAL
{
    public class LibraryDao : ILibraryDao
    {
        private const string PATH = "C:\\Library\\library.json";
        public void Create(Library library)
        {
            var libraries = new List<Library>(); 
            
            if(File.Exists(PATH)) 
            {
                using (FileStream fs = new FileStream(PATH, FileMode.OpenOrCreate))
                {
                    libraries = JsonSerializer.Deserialize<List<Library>>(fs);
                }
            }

            libraries.Add(library);
            Write(libraries);
        }

        private void Write(List<Library> library)
        {
            using (FileStream fs = new FileStream(PATH, FileMode.OpenOrCreate))
            {
                JsonSerializer.Serialize<List<Library>>(fs, library);
            }
        }
    }
}
