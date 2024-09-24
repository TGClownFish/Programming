using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.LinkLabel;

namespace ObjectOrientedPractics.Model
{
    ///<summary>
    /// Хранит данные о товаре.
    ///</summary>
    internal class Item
    {
        ///<summary>
        /// ID товара.
        ///</summary>
        private readonly int _id;
        ///<summary>
        /// Хранит ID товара. Только для чтения.
        ///</summary>
        public int Id
        { get { return _id; } }

        ///<summary>
        /// Количество товаров. Статично.
        ///</summary>
        private static int _amountOfItems = 1;

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
                if (ValueValidator.AssertStringOnLength(value, 200, Name))
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
                if (ValueValidator.AssertStringOnLength(value, 1000, Name))
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
                if (ValueValidator.AssertIntegerOnBeeingInClosedInterval(value, 0, 100000, Name))
                    _cost = value; 
            }
        }

        /// <summary>
        /// Создаёт экземпляр класса <see cref="Item"/>.
        /// </summary>
        /// <param name="name">Название товара. Не более 200 символов.</param>
        /// <param name="description">Описание товара. Не более 1000 символов.</param>
        /// <param name="cost">Стоимость товара. От 0 до 200000.</param>
        public Item (string name, string description, int cost)
        {
            _id = _amountOfItems;
            _amountOfItems += 1;
            Name = name;
            Description = description;
            Cost = cost;
            
        }

        public Item ()
        {
            _id =0;
            _amountOfItems += 1;
            Name = "";
            Description = "";
            Cost = 0;
        }
    }
}
