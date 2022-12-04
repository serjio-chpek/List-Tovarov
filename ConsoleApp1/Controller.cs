using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Controller
    {

        public static List<Goods> Goods = new List<Goods>();
        public void AddGood (string title, float price, float sale)
        {
            Goods good = new Goods()
            {
                Title = title,
                Price = price,
                Sale = sale,
                
            };
            good.Price = good.Price - good.Sale;
            Goods.Add(good);
        }
        public string GetGoods()
        {
            string text = "";
            foreach (var item in Goods)
            {

                text += $"{item.Title}, цена со скидкой- {item.Price}\n";
            }
            return text;
        }

        public void Delete(string t)
        {
            

            var x = Goods.FirstOrDefault(x => x.Title == t);

            if (x == null)
                return;

            Goods.Remove(x);





            //Console.WriteLine("Введите номер товара по порядку, который хотите удалить");
            //int nomer_tovara = Convert.ToInt32(Console.ReadLine());

            //Goods.RemoveAt(nomer_tovara-1);
        }

        public void SaveList()
        {
            var json = JsonSerializer.Serialize<List<Goods>>(Goods);

            File.WriteAllText("list.json", json);
        }
        public void OpenList()
        {
            if (!File.Exists("list.json"))
                return;

            var json = File.ReadAllText("list.json");

            Goods = JsonSerializer.Deserialize<List<Goods>>(json);
        }
    }
}
