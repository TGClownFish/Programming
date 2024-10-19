using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.LinkLabel;

namespace ObjectOrientedPractics.Model.Classes
{
    ///<summary>
    /// Хранит данные о товаре.
    ///</summary>
    public class Item
    {
        ///<summary>
        /// ID товара. Только для чтения.
        ///</summary>
        private readonly int _id;
        ///<summary>
        /// Хранит ID товара. Только для чтения.
        ///</summary>
        public int Id { get; }

        ///<summary>
        /// Количество товаров. Статично.
        ///</summary>
        private static int _amountOfItems = 0;

        ///<summary>
        /// Название товара.
        ///</summary>
        /// Название
        private string _name;
        ///<summary>
        /// Хранит  название товара. Не более 200 символов.
        ///</summary>
        public string Name
        {
            get { return _name; }
            set 
            {
                if (ValueValidator.IsLessThanOrEqual(value, 200, Name))
                    _name = value; 
            }

        }

        ///<summary>
        /// Описание товара.
        ///</summary>
        private string _description;
        ///<summary>
        /// Хранит описание товара. Не более 1000 символов.
        ///</summary>
        public string Description
        {
            get { return _description; }
            set 
            {
                if (ValueValidator.IsLessThanOrEqual(value, 1000, Name))
                    _description = value;  
            }
        }

        ///<summary>
        /// Стоимость товара.
        ///</summary>
        private int _cost;
        ///<summary>
        /// Хранит стоимость товара. От 0 до 100000.
        ///</summary>
        public int Cost
        {
            get { return _cost; }
            set 
            { 
                if (ValueValidator.IsInInterval(value, 0, 100000, Name))
                    _cost = value; 
            }
        }

        /// <summary>
        /// Хранит категорию товара. Является перечилсением типа <see cref="Category"/>.
        /// </summary>
        public Category Category { get; set; }

        /// <summary>
        /// Создаёт экземпляр класса <see cref="Item"/>.
        /// </summary>
        /// <param name="name">Название товара. Не более 200 символов.</param>
        /// <param name="description">Описание товара. Не более 1000 символов.</param>
        /// <param name="cost">Стоимость товара. От 0 до 200000.</param>
        /// <param name="category">Хранит категорию товара. Является перечилсением типа <see cref="Category"/>.</param>
        public Item (string name, string description, int cost, Category category)
        {
            Id = _amountOfItems;
            _amountOfItems += 1;
            Name = name;
            Description = description;
            Cost = cost;
            Category = category;
        }
        /// <summary>
        /// Создаёт пустой экземпляр класса <see cref="Item"/>.
        /// </summary>
        public Item() 
        { 
            Id = _amountOfItems;
            _amountOfItems += 1;
            Name = "";
            Description = "";
            Cost = 0;
            Category = 0;
        }
    }
}
