using ConsoleApp1;
using System.Runtime.CompilerServices;

internal class Program
{
    private static void Main(string[] args)
    {

        Console.WriteLine("Выберите команду");
        Console.WriteLine("доступный команды: добавить, список, удалить, сохранить, загрузить");
        Console.WriteLine("Примеры написания команд: \n добавить яблоко 150(цена) 10(скидка) \n удалить, ENTER, 1 \n список \n сохранить \n загрузить");

        while (true)
        {
            var  command = Console.ReadLine().ToLower().Split(' ');
            Controller s = new Controller();
            switch (command[0])
            {

                case "добавить":
                    s.AddGood(command[1], float.Parse(command[2]), float.Parse(command[3]));
                    break;
                case "список":
                    Console.WriteLine(s.GetGoods());
                    break;
                case "сохранить":
                    s.SaveList();
                    break;
                case "загрузить":
                    s.OpenList();
                    break;
                case "удалить":
                    s.Delete();
                    break;
                default:
                    Console.WriteLine("Ошибка в команде");
                    break;
            }
        }


    }

}