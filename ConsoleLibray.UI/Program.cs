using ConsoleLibray.UI.Models.Enums;
using ConsoleLibray.UI.UI;

bool isRun = true;

while (isRun)
{
    Console.WriteLine("Выберите действие:");
    Console.WriteLine("1 - Создать библотеку");
    Console.WriteLine("4 - Очистить консоль");
    Console.WriteLine("5 - Выйти из приложения");

    StartMenuEnum userInput;
    try
    {
         userInput = (StartMenuEnum)Convert.ToInt32(Console.ReadLine());

    }
    catch
    {
        Console.Clear();
        continue;
    }

    switch (userInput)
    {
        case StartMenuEnum.Create:
            CreateLibrayUI.CreateLibray();
            break;
        case StartMenuEnum.Clear:
            Console.Clear();
            break;
        case StartMenuEnum.Exit:
            isRun = false;
            break;
        default:
            Console.Clear();
            Console.WriteLine("Неизвестная enum");
            Console.WriteLine();
            break;
    }
}