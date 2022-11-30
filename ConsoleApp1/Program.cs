using ConsoleApp1;
using System.Runtime.CompilerServices;

internal class Program
{
    private static void Main(string[] args)
    {

        Console.WriteLine("Выберите команду");


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

                default:
                    Console.WriteLine("Ошибка в команде");
                    break;
            }
        }

        


        //List<Goods> list = new List<Goods>();

        //for (int i = 0; i < 3; i++)
        //{
        //    Goods x = new Goods();
        //    Console.WriteLine("Напишите название товара");
        //    x.Name = Console.ReadLine();
        //    Console.WriteLine("Напишите стоимость товара");
        //    x.Cost = Console.ReadLine();
        //    list.Add(x);
        //}

        //Controller serialize = new Controller();

        //serialize.Save(list);

        //string path = "list.json";
        //var t = serialize.Load(path);

        //if (t == null)
        //    return;

        //foreach (var item in t)
        //{
        //    Console.WriteLine("{0} {1}", item.Name, item.Cost);
        //}
    }
}