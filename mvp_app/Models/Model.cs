using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mvp_app.Models
{
    public class Model
    {
        private List<Item> items = new List<Item>(); // Список для хранения элементов

        public int Id { get; set; }
        public string Title { get; set; }
        public string Data { get; set; }

        public void LoadData()
        {
            Data = "Hello, MVP!";
        }
        public void Save(Item item)
        {
            items.Add(item); // Сохраняем элемент в список
        }

        public Item GetLastSavedItem()
        {
            return items.LastOrDefault(); // Возвращаем последний сохранённый элемент
        }

        public class Item
        {
            public int Id { get; set; }
            public string Title { get; set; }
        }

    }
}
