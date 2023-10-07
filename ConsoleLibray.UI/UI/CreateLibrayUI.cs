using ConsoleLibray.BLL;
using ConsoleLibray.BLL.Contracts;

namespace ConsoleLibray.UI.UI
{
    public static class CreateLibrayUI
    {
        private static ILibraryService _libraryService = new LibraryService();
        public static void CreateLibray()
        {
            bool isError = true;
            Console.WriteLine("Введите название библиотеки:");
            var libraryName = Console.ReadLine();

            Console.WriteLine("Введите максимальное количество книг, которое может храниться:");

            int bookCount = 0;
            while (isError)
            {
                try
                {
                    bookCount = Convert.ToInt32(Console.ReadLine());
                    isError = false;
                }
                catch
                {
                    Console.WriteLine("Введите коректное число");
                }
            }

            _libraryService.Create(libraryName, bookCount);
        }
    }
}
