using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedPractics.Model
{
    /// <summary>
    /// Хранит данные о покупателе.
    /// </summary>
    class Customer
    {
       /// <summary>
       /// ID покупателя.
       /// </summary>
        private readonly int _id;
        /// <summary>
        /// Хранит ID покупателя. Только для чтения.
        /// </summary>
        public int Id 
        { get { return _id; } }

        /// <summary>
        /// Количество покупателей. Статично.
        /// </summary>
        private static int _amountOfCustomers = 1;

        /// <summary>
        /// Полное имя покупателя.
        /// </summary>
        private string _name;
        /// <summary>
        /// Хранит полное имя покупателя. Не более 200 символов.
        /// </summary>
        public string Name { 
            get { return _name; } 
            set 
            { 
                if (ValueValidator.AssertStringOnLength(value, 200, Name))
                    _name = value; 
            } 
        }

        /// <summary>
        /// Адрес покупателя.
        /// </summary>
        private string _address;
        /// <summary>
        /// Хранит адрес покупателя. Не более 500 символов.
        /// </summary>
        public string Address 
        { 
            get { return _address; } 
            set 
            {
                if (ValueValidator.AssertStringOnLength(value, 500, Name))
                    _address = value; 
            } 
        }

        /// <summary>
        /// Создаёт экземпляр класса <see cref="Customer"/>.
        /// </summary>
        /// <param name="name">Полное имя покупателя. Не более 200 символов.</param>
        /// <param name="address">Адрес покупателя. Не более 500 символов.</param>
        public Customer (string name,string address)
        {
            _id = _amountOfCustomers;
            _amountOfCustomers += 1;
            Name = name;
            Address = address;
        }
        /// <summary>
        /// Создаёт пустой экземпляр класса <see cref="Customer"/>.
        /// </summary>
        public Customer ()
        {
            _id = _amountOfCustomers;
            _amountOfCustomers +=1;
            Name = "";
            Address = "";
        }
    }
}
