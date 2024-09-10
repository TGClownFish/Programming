using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.LinkLabel;

namespace ObjectOrientedPractics.Model
{
    ///<summary>
    /// Хранит данные о товаре
    ///</summary>
    internal class Item
    {
        ///<summary>
        /// ID товара
        ///</summary>
        private readonly int _id;
        ///<summary>
        /// Хранит информацию о ID. Только для чтения.
        ///</summary>
        public int Id
        { get { return _id; } }

        ///<summary>
        /// Количество товаров
        ///</summary>
        private static int _amountOfItems = 0;

        ///<summary>
        /// Название товара
        ///</summary>
        /// Название
        private string _name;
        ///<summary>
        /// Хранит информацию о названии. Не более 200 символов.
        ///</summary>
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        ///<summary>
        /// Информация о товаре
        ///</summary>
        private string _info;
        ///<summary>
        /// Хранит информацию об информации о товаре. Не более 1000 символов.
        ///</summary>
        public string Info
        {
            get { return _info; }
            set { _info = value;  }
        }

        ///<summary>
        /// Стоимость товара
        ///</summary>
        private int _cost;
        ///<summary>
        /// Хранит информацию о стоимости. От 0 до 200000.
        ///</summary>
        public int Cost
        {
            get { return _cost; }
            set { _cost = value; }
        }

        /// <summary>
        /// Создаёт экземпляр класса <see cref="Item"/>.
        /// </summary>
        /// <param name="name">Название. Не более 200 символов.</param>
        /// <param name="info">Информация о товаре. Не более 1000 символов.</param>
        /// <param name="cost">Стоимость. От 0 до 200000.</param>
        public Item (string name, string info, int cost)
        {
            _id = _amountOfItems;
            _amountOfItems += 1;
            Name = name;
            Info = info;
            Cost = cost;
            
        }

    }
}
