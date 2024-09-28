using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ObjectOrientedPractics.Model
{
    //Хранит данные об адрессе покупателя. 
    public class Address
    {
        /// <summary>
        /// Почтовый индекс.
        /// </summary>
        private string _index;
        /// <summary>
        /// Хранит данные об почтовый индексе. Целое шестизначное число.
        /// </summary>
        public string Index 
        {
            get { return _index; }
            set 
            { 
                if (ValueValidator.ValidateStringOnBeingAPostalIndex(value,Index))
                    _index = value; 
            }
        }

        /// <summary>
        /// Страна/регион.
        /// </summary>
        private string _country;
        /// <summary>
        /// Хранит данные о стране/регионе. Не более 50 символов.
        /// </summary>
        public string Country
        {
            get { return _country; }
            set
            {
                if (ValueValidator.AssertStringOnLength(value, 50, Country))
                    _country = value;
            }
        }

        /// <summary>
        /// Город (населенный пункт).
        /// </summary>
        private string _city;
        /// <summary>
        /// Хранит данные о городе (населенном пункте). Не более 50 символов.
        /// </summary>
        public string City
        {
            get { return _city; }
            set
            {
                if (ValueValidator.AssertStringOnLength(value, 50, City))
                    _city = value;
            }
        }

        /// <summary>
        /// Улица.
        /// </summary>
        private string _street;
        /// <summary>
        /// Хранит данные об улице. Не более 100 символов.
        /// </summary>
        public string Street
        {
            get { return _street; }
            set
            {
                if (ValueValidator.AssertStringOnLength(value, 100, Street))
                    _street = value;
            }
        }

        /// <summary>
        /// Номер дома.
        /// </summary>
        private string _building;
        /// <summary>
        /// Хранит данные о номере дома. Не более 10 символов.
        /// </summary>
        public string Building
        {
            get { return _building; }
            set
            {
                if (ValueValidator.AssertStringOnLength(value, 10, Building))
                    _building = value;
            }
        }

        /// <summary>
        /// Номер квартиры/помещения.
        /// </summary>
        private string _apartment;
        /// <summary>
        /// Хранит данные о номере квартиры/помещения. Не более 10 символов.
        /// </summary>
        public string Apartment
        {
            get { return _apartment; }
            set
            {
                if (ValueValidator.AssertStringOnLength(value, 50, Apartment))
                    _apartment = value;
            }
        }

        /// <summary>
        /// Создаёт экземпляр класса <see cref="Address"/>.
        /// </summary>
        /// <param name="index">Почтовый индекс. Целое шестизначное число.</param>
        /// <param name="country">Страна/регион. Не более 50 символов.</param>
        /// <param name="city">Город (населенный пункт). Не более 50 символов.</param>
        /// <param name="street">Улица. Не более 100 символов.</param>
        /// <param name="building">Номер дома. Не более 10 символов.</param>
        /// <param name="apartment">Номер квартиры/помещения. Не более 10 символов.</param>
        public Address (string index, string country, string city, string street, string building, string apartment)
        {
            _index = index;
            _country = country;
            _city = city;
            _street = street;
            _building = building;
            _apartment = apartment;
        }

        /// <summary>
        /// Создаёт пустой экземпляр класса <see cref="Address"/>.
        /// </summary>
        public Address () 
        {
            _index = "000000";
            _country = "";
            _city = "";
            _street = "";
            _building = "";
            _apartment = "";
        }
    }

}
