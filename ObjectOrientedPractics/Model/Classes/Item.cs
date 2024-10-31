using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.LinkLabel;
using ObjectOrientedPractics.Model.Enums;

namespace ObjectOrientedPractics.Model.Classes
{
    ///<summary>
    /// Хранит данные о товаре.
    ///</summary>
    public class Item : ICloneable, IEquatable<Item>, IComparable<Item>
    {

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

        /// <summary>
        /// Копирует экземпляр класса <see cref="Item"/>.
        /// </summary>
        public object Clone()
        { 
            return new Item (this.Name, this.Description, this.Cost, this.Category); 
        }

        /// <summary>
        /// Проверяет, схож ли оригианальный объект с входящим. Перегрузка стандартного метода Equals.
        /// </summary>
        /// <param name="other">Проверяемый объект.</param>
        /// <returns>true, если объекты схожи, иначе - false.</returns>
        public override bool Equals(object other)
        {
            if (other == null) 
                return false;
            if ((other is not Item)) 
                return false;
            if (ReferenceEquals(this, other)) 
                return true;
            var otherItem = (Item) other;
            return (this.Name == otherItem.Name && this.Cost == otherItem.Cost && this.Category == otherItem.Category);
        }

        /// <summary>
        /// Проверяет, схож ли оригианальный объект с входящим. Реализация стандартного интерфейса IEquatable<T>.
        /// </summary>
        /// <param name="other">Проверяемый объект.</param>
        /// <returns>true, если объекты схожи, иначе - false.</returns>
        public bool Equals(Item other)
        {
            if (other == null)
                return false;
            if (this.Name == other.Name && this.Cost == other.Cost && this.Category == other.Category)
                return true;
            else
                return false;
        }

        /// <summary>
        /// Сравнивает оригинальный объект с входящимм.
        /// </summary>
        /// <param name="other"></param>
        /// <returns>0, если цены объектов равны; 1, если цена оригианального объект больше или нет входящего объекта; 
        /// -1, если цена оригианального объект ниже</returns>
        public int CompareTo(Item other)
        {
            if (other == null)
                return 1;
            if (this.Cost == other.Cost)  
                return 0;
            if (this.Cost < other.Cost)
                return -1;
            else
                return 1;
        }
    }
}
