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

            Goods.Add(good);
        }
        public string GetGoods()
        {
            string text = "";
            foreach (var item in Goods)
            {
                text += $"{item.Title} цена - {item.Price}\n";
            }
            return text;
        }

        public void Delete()
        {

        }
    }
}
