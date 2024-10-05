using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ObjectOrientedPractics.Model.Classes;

namespace ObjectOrientedPractics.Model
{
    public class Store
    {
        /// <summary>
        /// Список объектов класса <see cref="Item"/>.
        /// </summary>
        private List<Item> _items = new List<Item>();
        /// <summary>
        /// Хранит список объектов класса <see cref="Model.Item"/>.
        /// </summary>
        public List<Item> Items { get; set; }

        /// <summary>
        /// Список объектов класса <see cref="Classes.Customer"/>.
        /// </summary>
        private List<Customer> _customers = new List<Customer>();
        /// <summary>
        /// Хранит список объектов класса <see cref="Classes.Customer"/>.
        /// </summary>
        public List <Customer> Customers { get; set; }

        /// <summary>
        /// Создаёт пустой экземпляр класса <see cref="Store"/>.
        /// </summary>
        public Store() 
        { 
            Items = new List<Item>();
            Customers = new List<Customer>();
        }
    }
}
